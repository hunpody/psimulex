using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Schedulers
{
    /// <summary>
    /// A really random scheduler.
    /// </summary>
    public class RandomScheduler : IScheduler
    {
        private Random rnd = new Random();

        private ProcessorList processors;
        private ThreadList threads = new ThreadList();

        #region IScheduler Members

        public void Schedule()
        {
            // Just for testing, not serious. :)
            
            var runningThreads = threads.Where(t => t.State == ThreadStates.Running).ToArray();
            processors[0].CurrentThread = runningThreads[rnd.Next(0, runningThreads.Length)];
        }

        public int SwitchTime
        {
            get { return 1; }
        }

        public void Initialize(ProcessorList processors)
        {
            this.processors = processors;
        }

        public void AddThread(Thread thread)
        {
            threads.Add(thread);
        }

        public void RemoveThread(Thread thread)
        {
            threads.Remove(thread);
        }

        #endregion
    }
}
