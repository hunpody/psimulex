using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The states of a thread.
    /// </summary>
    public enum ThreadStates
    {
        /// <summary>
        /// The thread gets into this state when it was just created or explicitly stopped.
        /// Cannot be scheduled.
        /// </summary>
        Stopped,

        /// <summary>
        /// The thread gets into this state when it is running. 
        /// However it doesn't mean it is scheduled to actually run on a processor but it can be 
        /// chosen to schedule onto the processor by the scheduler engine.
        /// </summary>
        Running,

        /// <summary>
        /// The thread gets into this state when it has finished running. 
        /// Cannot be scheduled.
        /// </summary>
        Finished
    }

    /// <summary>
    /// The representation of a thread that cannot be parallelized.
    /// </summary>
    public class Thread : ISystemItem, ICommandContext
    {
        /// <summary>
        /// The program that the thread is running.
        /// </summary>
        public Program Program { get; set; }

        /// <summary>
        /// The pointer to the current instruction that the thread is running.
        /// </summary>
        public int PC { get; set; }

        /// <summary>
        /// The current state of the thread.
        /// </summary>
        public ThreadStates State { get; set; }

        /// <summary>
        /// The process that owns the thread.
        /// </summary>
        public Process HostProcess { get; set; }

        public Thread()
        {
            CallStack = new CallStack();
            RunStack = new RunStack();
        }

        #region ISystemItem Members

        public string Name { get; set; }
        public int Id { get; set; }

        #endregion

        #region ICommandContext Members

        public CallStack CallStack
        {
            get;
            set;
        }

        public RunStack RunStack
        {
            get;
            set;
        }

        public IFunctionLookup FunctionLookup
        {
            get
            {
                return ((IFunctionLookup)HostProcess.System);
            }
        }

        public ISystemContext System
        {
            get
            {
                return HostProcess.System;
            }
        }

        private Dictionary<string, int> _variableMap = new Dictionary<string, int>();

        public BaseType GetVariable(string name)
        {
            if (_variableMap.ContainsKey(name))
            {
                return RunStack[_variableMap[name]];
            }
            throw new PsimulexCoreException(string.Format("Undefined variable: {0}.",name));
        }

        public void AddVariable(string name, BaseType value)
        {
            RunStack.Push(value);

            _variableMap.Add(name, RunStack.Count - 1);
        }


        #endregion
    }

    public class ThreadList : List<Thread>
    {
    }
}
