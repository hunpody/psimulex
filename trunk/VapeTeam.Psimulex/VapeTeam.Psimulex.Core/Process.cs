using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    public class Process : VapeTeam.Psimulex.Core.ISystemItem
    {
        #region ISystemItem Members

        public int Id { get; set; }
        public string Name { get; set; }

        #endregion

        /// <summary>
        /// The program that the process is executing.
        /// </summary>
        public Program Program { get; set; }

        public Machine Machine { get; set; }

        public ISystemContext System { get; set; }

        /// <summary>
        /// True if there are active threads.
        /// </summary>
        public bool IsActive
        {
            get
            {
                return Threads.Exists(thread => thread.State == ThreadStates.Running);
            }
        }

        public Process ParentProcess { get; set; }
        public List<Process> ChildProcesses { get; set; }
        public ThreadList Threads { get; set; }
        public Thread MainThread
        {
            get
            {
                if (Threads != null && Threads.Count > 0)
                {
                    return Threads[0];
                }
                return null;
            }
        }

        internal void AddToStandardOutput(string message)
        {
            StandardOutput += message;
            Machine.ScreenContent += message;
        }

        public string StandardOutput { get; internal set; }

        public Process()
        {
            ChildProcesses = new List<Process>();
            Threads = new ThreadList();
            StandardOutput = string.Empty;
        }

        /// <summary>
        /// Registers the thread to the process's thread list.
        /// </summary>
        /// <param name="thread"></param>
        public void AddThread(Thread thread)
        {
            thread.HostProcess = this;
            thread.State = ThreadStates.Stopped;
            Threads.Add(thread);
        }
    }

    public class ProcessList : List<Process>
    {
    }
}
