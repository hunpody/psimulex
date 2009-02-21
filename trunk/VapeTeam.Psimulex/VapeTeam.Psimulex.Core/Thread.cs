using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Common;
using VapeTeam.Psimulex.Core.Exceptions;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The states of a thread.
    /// </summary>
    public enum ThreadStates
    {
        /// <summary>
        /// The thread gets into this state when it was just created or explicitly stopped.
        /// A thread being is this state cannot be scheduled.
        /// </summary>
        Stopped,

        /// <summary>
        /// The thread gets into this state when it is running. 
        /// However it doesn't mean it is scheduled to actually run on a processor but it can be 
        /// chosen to schedule onto a processor by the scheduler engine.
        /// </summary>
        Running,

        /// <summary>
        /// The thread gets into this state when it has finished running. 
        /// A thread being is this state cannot be scheduled.
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
        public virtual int PC { get; set; }

        /// <summary>
        /// The current state of the thread.
        /// </summary>
        public ThreadStates State { get; set; }

        /// <summary>
        /// The process that owns the thread.
        /// </summary>
        public Process HostProcess { get; set; }

      /// <summary>
        /// The global variables are those values that are initally defined or initialized outside any functions.
        /// </summary>
        public VariableMap GlobalVariables
        {
            get; private set;
        }

        #region Registers

        /// <summary>
        /// The registry of the processor.
        /// </summary>
        public IRegistry Registry { get; internal set; }
        
        #endregion

        public Thread()
        {
            CallStack = new CallStack();
            RunStack = new RunStack();
            GlobalVariables = new VariableMap();
            Registry = new Registry();
        }

        void RunStack_BeingPopped(object sender, Stack<BaseType>.PopEventArgs e)
        {
            // If a local variable is being popped we don't need to deallocate it.
            foreach (int stackIndex in _variableMap.Values)
            {
                if (RunStack[stackIndex].MemoryAddress == e.PoppedValue.MemoryAddress)
                {
                    return;
                }
            }
            e.PoppedValue.Delete();
        }

        /// <summary>
        /// Returns true if the thread has operations left to execute.
        /// </summary>
        public bool CanExecuteNext
        {
            get 
            {
                return PC < Program.CommandList.Count;
            }
        }

        #region ISystemItem Members

        public string Name { get; set; }
        public int Id { get; set; }

        #endregion

        #region ICommandContext Members

        public IStack<State> CallStack
        {
            get;
            internal set;
        }

        private Stack<BaseType> _runStack;

        public Stack<BaseType> RunStack
        {
            get
            {
                return _runStack;
            }

            internal set
            {
                if (_runStack != null)
                    _runStack.BeingPopped -= RunStack_BeingPopped;
                _runStack = value;
                RunStack.BeingPopped += new EventHandler<Stack<BaseType>.PopEventArgs>(RunStack_BeingPopped);
            }
        }

        IStack<BaseType> ICommandContext.RunStack
        {
            get { return RunStack; }
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

        public void PushScope()
        {
            CallStack.Push(new State(PC, RunStack.Count, _variableMap));
            // Copy local variables
            _variableMap = new VariableLocator(_variableMap);
        }

        public void PopScope()
        {
            if (CallStack.IsEmpty)
            {
                State = ThreadStates.Finished;
                return;
            }

            // Not safe!

            State state = CallStack.Pop();
            _variableMap = state.VariableMap;
            int itemsToPop = Math.Max(0, RunStack.Count - state.SP);
            var poppedValues = RunStack.Pop(itemsToPop);
            foreach (var value in poppedValues)
            {   
                value.Delete();
            }
            
            //RunStack.Pop(_variableMap.Count - state.VariableMap.Count);
            
            //RunStack.Pop(Math.Max(0, RunStack.Count - state.SP));

            //PC = state.PC + 1;
        }

        /// <summary>
        /// Pushes the current state into the callstack.
        /// (PC, SP and VariableMap)
        /// </summary>
        public void PushState()
        {
            CallStack.Push(new State(PC, RunStack.Count, _variableMap));
            _variableMap = new VariableLocator();
        }

        /// <summary>
        /// Restores the previously pushed state.
        /// (PC, SP and VariableMap)
        /// </summary>
        public void PopState()
        {
            if (CallStack.IsEmpty)
            {
                State = ThreadStates.Finished;
                _variableMap.Clear();
                RunStack.Pop(RunStack.Count);
                return;
            }

            State state = CallStack.Pop();
            
            int numberOfLocalVariables = _variableMap.Count;

            _variableMap = state.VariableMap;

            // Not safe!
            RunStack.Pop(numberOfLocalVariables);

            RunStack.Pop(Math.Max(0, RunStack.Count - state.SP));

            PC = state.PC + 1;
        }

        private VariableLocator _variableMap = new VariableLocator();

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
            if (_variableMap.ContainsKey(name))
            {
                RunStack[_variableMap[name]] = value;
            }
            else
            {
                RunStack.Push(value);

                _variableMap.AddOrOverwrite(name, RunStack.Count - 1);
            }

            if (CallStack.Count == 0)
            {
                GlobalVariables.AddOrOverwrite(name, value);
            }
        }

        #endregion

        /// <summary>
        /// Starts the thread. Precondition: the thread shouldn't be finished or running.
        /// </summary>
        public void Start()
        {
            if (State == ThreadStates.Stopped)
            {
                State = ThreadStates.Running;
            }
        }

        /// <summary>
        /// Copies the global variables from the other thread.
        /// </summary>
        /// <param name="callingThread"></param>
        public void CopyGlobalVariablesFromThread(Thread thread)
        {
            foreach (var variableKeyValuePair in thread.GlobalVariables)
            {
                AddVariable(variableKeyValuePair.Key, variableKeyValuePair.Value);
            }
        }

        public override string ToString()
        {
            return string.Format("Thread ({1}) \"{0}\" @{2}", this.Name, this.Id, this.PC);
        }
    }

    public class ThreadList : List<Thread>
    {
    }
}
