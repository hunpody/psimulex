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
        public static ISystemContext CurrentContext
        {
            get;
            private set;
        }

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
        /// This is the thread that has currently called the library functions of the operating system.
        /// It is usually null unless it calls down to the system (f.e. print, or new_thread) 
        /// </summary>
        public Thread CallingThread { get; set; }

        /// <summary>
        /// Performs a system call. It reads all the parameters from the Run Stack and passes them 
        /// to the requested library function before invoking it via reflection.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public BaseType SystemCall(Function function, IEnumerable<BaseType> parameters)
        {
            // Set the static current context 
            CurrentContext = this;
            var systemFunction = systemFunctions.GetFunction(Function.CreateId(function.Name, parameters.Count()));

            ParameterInfo[] parameterInfoCollection = systemFunction.MethodInfo.GetParameters();

            // Convert psimulex types to .net types
            var convertedTypes = ValueFactory.TransformBaseTypeArrayToDotnetType(parameters, 
                    parameterInfoCollection.Select(par => par.ParameterType).ToArray());

            // Call the function
            object returnValue = systemFunction.MethodInfo.Invoke(systemFunction.HostObject, convertedTypes);

            var parametersList = parameters.ToList();

            // Map back .net types to psimulex types (this makes possible to keep track of a pass-by-ref parameter)
            for (int i=0; i<parametersList.Count(); ++i)
            {
                parametersList[i].Assign(ValueFactory.Create(convertedTypes[i]));
            }

            // If the type of return value is not void, then push it back
            if (systemFunction.HasReturnValue)
            {
                return ValueFactory.Create(returnValue);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Initializes the main thread of a given process.
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        protected virtual Thread CreateMainThread(Process process)
        {
            var thread = CreateThread(process);
            thread.Name = string.Format("{0} Main Thread", process.Program.Name);
            return thread;
        }

        protected virtual Thread CreateThread(Process process)
        {
            var id = NextThreadId;
            var thread = new Thread
            {
                Program = process.Program,
                Id = id,
                Name = string.Format("{0} Thread Id={1}", process.Program.Name, id),
                State = ThreadStates.Stopped,
                HostProcess = process
            };
            return thread;
        }

        /// <summary>
        /// Initializes a new thread. Registers to the process's thread list.
        /// </summary>
        /// <param name="callingThread"></param>
        /// <param name="entryPoint">The instruction pointer where the thread will start</param>
        /// <returns></returns>
        public Thread CreateThread(Thread callingThread, int entryPoint)
        {
            Thread thread = CreateThread(callingThread.HostProcess);
            thread.Program = callingThread.Program;
            thread.PC = entryPoint;
            thread.CopyGlobalVariablesFromThread(callingThread);
            callingThread.HostProcess.AddThread(thread);
            AddThread(thread);
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
            AddThread(thread);
            // Join commands of the program
            program.JoinCommands();
            return process;
        }

        public void Run(Program program)
        {
            // Create a process that will execute the program and put this process into the list 
            Process process = Load(program);

            // If there is no "job" (active process running) then call schedule immediately

            // Do we need to simulate the bootup and process creation or the prescheduling?
            if (!machine.Processors.Exists(p => p.CurrentThread == null))
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
            if (!machine.Processors.Exists(p => p.CurrentThread == null))
            {
                Schedule();
            }

            process.MainThread.State = ThreadStates.Running;

            Schedule();

            while (HasActiveProcesses)
            {
                machine.Step();
            }

        }

        public void Run(string programName)
        {

        }

        private void AddThread(Thread thread)
        {
            Threads.Add(thread);
            Scheduler.AddThread(thread);
        }

        public void Setup(Machine machine)
        {
            this.machine = machine;
            Scheduler.Initialize(machine.Processors);
            this.machine.Processors[0].SetupPeriodicalTimeInterrupt(Scheduler.SwitchTime, new EventHandler<InterruptRequestEventArgs>(ProcessorInterruptEventHandler));
        }

        private void ProcessorInterruptEventHandler(object sender, InterruptRequestEventArgs e)
        {
            Schedule();
        }

        public void Schedule()
        {
            Scheduler.Schedule();
        }

        public OperatingSystem(IScheduler scheduler)
        {
            Scheduler = scheduler;
            Processes = new ProcessList();
            Threads = new ThreadList();
        }

        //public OperatingSystem()
        //    : this(null)
        //{
        //}

        public void InstallLibrary(ILibrary library)
        {
            libraries.Add(library);
            Explore(library);
        }

        private void Explore(ILibrary library)
        {
            // The BindingFlags parameter must be extended
            MethodInfo[] methodsOfLibrary = library.GetType().GetMethods(System.Reflection.BindingFlags.IgnoreCase |
                        System.Reflection.BindingFlags.Instance |
                        System.Reflection.BindingFlags.Public);


            methodsOfLibrary = methodsOfLibrary.Where(mi => mi.Name != "get_System" && mi.Name != "set_System").ToArray();

            foreach (var method in methodsOfLibrary)
            {
                var systemFunction = new SystemFunction
                {
                    Name = method.Name.ToLower(),
                    HostObject = library,
                    MethodInfo = method,
                };
                if (method.ReturnType != typeof(void))
                {
                    systemFunction.ReturnValue = new VariableDescriptor { Name = null, Type = CreateTypeIdFromSystemType(method.ReturnType) };
                }

                foreach(var parameter in method.GetParameters())
                {
                    systemFunction.Parameters.Add(new VariableDescriptor 
                    { 
                        Name = parameter.Name, 
                        Type = CreateTypeIdFromSystemType(parameter.ParameterType),
                        IsReference = parameter.ParameterType.IsByRef || parameter.IsOut
                    });
                }

                systemFunctions.Add(systemFunction);
            }
        }

        private static TypeIdentifier CreateTypeIdFromSystemType(Type type)
        {
            return new TypeIdentifier { TypeName = type.FullName, TypeEnum = TypeEnum.DotNetType };
        }

        #region IFunctionLookup Members

        public Function GetFunctionByName(string name)
        {
            return GetFunctionByNameAndParameterCount(name, -1);
        }

        public Function GetFunctionByNameAndParameterCount(string name, int paramCount)
        {
            Function function = null;

            // User can override system functions
            if (paramCount >= 0)
            {
                function = CallingThread.HostProcess.Program.GetFunction(name, paramCount);
            }
            else
            {
                function = CallingThread.HostProcess.Program.GetFunction(name);
            }

            // Try system function
            if (function == null)
            {
                if (paramCount >= 0)
                {
                    function = systemFunctions.GetFunction(Function.CreateId(name, paramCount));
                }
                else
                {
                    function = systemFunctions.GetFunctionByName(name);
                }
            }
            return function;
        }

        #endregion
    }
}
