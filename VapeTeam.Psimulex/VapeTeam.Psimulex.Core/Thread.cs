using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    public class Thread : ISystemItem
    {
        /// <summary>
        /// The program that the thread is running.
        /// </summary>
        public Program Program { get; set; }

        /// <summary>
        /// The pointer to the current instruction that the thread is running.
        /// </summary>
        public int IP { get; set; }

        /// <summary>
        /// The current state of the thread.
        /// </summary>
        public ThreadStates State { get; set; }

        #region ISystemItem Members

        public string Name { get; set; }
        public int Id { get; set; }

        #endregion
    }

    public class ThreadList : List<Thread>
    {
    }
}
