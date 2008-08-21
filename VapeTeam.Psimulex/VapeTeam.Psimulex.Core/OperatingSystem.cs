using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Libraries;
using VapeTeam.Psimulex.Core.Types;
using System.Reflection;

namespace VapeTeam.Psimulex.Core
{
    public class OperatingSystem : ISystemContext, IFunctionLookup
    {
        private Machine machine;

        private int _nextProcessId = 0;
        private int NextProcessId 
        {
            get 
            {
                return ++_nextProcessId;
            }
        }

        private int _nextThreadId = 0;
        private int NextThreadId 
        {
            get 
            {
                return ++_nextThreadId;
            }
        }

        private List<ILibrary> libraries = new List<ILibrary>();

        private FunctionRegistry systemFunctions = new FunctionRegistry();

        public IScheduler Scheduler { get; private set; }
        public ProcessList Processes { get; private set; }
        public ThreadList Threads { get; private set; }


        public bool HasActiveProcesses
        {
            get
            {
                return Processes != null && Processes.Exists(p => p.IsActive);
            }
        }

        /// <summary>
        /// This is the process that has currently called the library functions of the operating system.
        /// It is usually null but when it calls down to the system (f.e. print, or new_thread) 
        /// </summary>
        public Process CallingProcess { get; set; }

        /// <summary>
        /// Performs a system call. It reads all the parameters from the Run Stack and passes them 
        /// to the requested library function before invoking it via reflection.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public BaseType SystemCall(Function function, IEnumerable<BaseType> parameters)
        {
            var systemFunction = systemFunctions.GetFunction(function);

            ParameterInfo[] parameterInfoCollection = systemFunction.MethodInfo.GetParameters();

            systemFunction.MethodInfo.Invoke(systemFunction.HostObject, 
                ValueFactory.TransformBaseTypeArrayToDotnetType(parameters, 
                    parameterInfoCollection.Select(par => par.ParameterType).ToArray()));

            return null;
        }

        /// <summary>
        /// Initializes the main thread of a given process.
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        protected virtual Thread CreateMainThread(Process process)
        {
            var thread = new Thread { 
                Program = process.Program, 
                Id = _nextThreadId,
                Name = string.Format("{0} Main Thread", process.Program.Name), 
                State = ThreadStates.Stopped };
            thread.HostProcess = process;
            return thread;
        }

        /// <summary>
        /// Loads the program which means it creates a process for it and registers its main thread as "Stopped" or "Initialized". (Undetermined yet)
        /// </summary>
        /// <param name="program"></param>
        /// <returns></returns>
        public Process Load(Program program)
        {
            var process = new Process { Id = NextProcessId, Program = program, Machine = machine, System = this };
            var thread = CreateMainThread(process);
            process.Threads.Add(thread);
            Processes.Add(process);
            Threads.Add(thread);
            return process;
        }

        public void Run(Program program)
        {
            // Create a process that will execute the program and put this process into the list 
            Process process = Load(program);

            // If there is no "job" (active process running) then call schedule immediately

            // Do we need to simulate the bootup and process creation or the prescheduling?
            if (!machine.Processors.Exists(p => p.RunningTask == null))
            {
                Schedule();
            }

            process.MainThread.State = ThreadStates.Running;

            while (HasActiveProcesses)
            {
                machine.Step();
            }                        
        }

        public void Run(Process process)
        {
            if (!machine.Processors.Exists(p => p.RunningTask == null))
            {
                Schedule();
            }

            process.MainThread.State = ThreadStates.Running;

            while (HasActiveProcesses)
            {
                machine.Step();
            }

        }

        public void Run(string programName)
        {

        }

        public void Setup(Machine machine)
        {
            this.machine = machine;
            this.machine.Processors[0].SetupPeriodicalTimeInterrupt(Scheduler.SwitchTime, new EventHandler<InterruptRequestEventArgs>(ProcessorInterruptEventHandler));
        }

        private void ProcessorInterruptEventHandler(object sender, InterruptRequestEventArgs e)
        {
            Schedule();
        }

        public void Schedule()
        {
            Scheduler.Schedule(machine.Processors, Threads);
        }

        public OperatingSystem(IScheduler scheduler)
        {
            Scheduler = scheduler;
            Processes = new ProcessList();
            Threads = new ThreadList();
        }

        public OperatingSystem()
            : this(null)
        {
        }

        public void InstallLibrary(ILibrary library)
        {
            library.System = this;
            libraries.Add(library);
            Explore(library);
        }

        private void Explore(ILibrary library)
        {
            library = new StandardLibrary(this);

            // The BindingFlags parameter must be extended
            MethodInfo[] methodsOfLibrary = library.GetType().GetMethods(System.Reflection.BindingFlags.IgnoreCase |
                        System.Reflection.BindingFlags.Instance |
                        System.Reflection.BindingFlags.Public);

            foreach (var method in methodsOfLibrary)
            {
                systemFunctions.Add(new SystemFunction
                {
                    Name = method.Name.ToLower(),
                    HostObject = library,
                    MethodInfo = method,
                    HasReturnValue = method.ReturnType != typeof(void),
                    ParametersCount = method.GetParameters().Length
                });
            }
        }


        #region IFunctionLookup Members

        public Function GetFunctionByName(string name)
        {
            return systemFunctions.GetFunction(new Function { Name = name });
        }

        #endregion
    }
}
