using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Libraries;

namespace VapeTeam.Psimulex.Core
{
    public class OperatingSystem
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

        public IScheduler Scheduler { get; private set; }
        public ProcessList Processes { get; private set; }
        public ThreadList Threads { get; private set; }


        public bool HasActiveProcesses
        {
            get
            {
                return Processes != null && Processes.Count > 0;
            }
        }

        /// <summary>
        /// This is the process that has currently called the library functions of the operating system.
        /// It is usually null but when it calls down to the system (f.e. print, or new_thread) 
        /// </summary>
        public Process SystemCallingProcess { get; private set; }

        protected virtual Thread CreateMainThread(Process process)
        {
            var thread = new Thread { 
                Program = process.Program, 
                Id = _nextThreadId,
                Name = string.Format("{0} Main Thread", process.Program.Name), 
                State = ThreadStates.Stopped };
            return thread;
        }

        public Process Load(Program program)
        {
            var process = new Process { Id = NextProcessId, Program = program };
            var thread = CreateMainThread(process);
            process.Threads.Add(thread);
            Processes.Add(process);
            Threads.Add(thread);
            return process;
        }

        public void Run(Program program)
        {
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
            libraries.Add(library);
        }
    }
}
