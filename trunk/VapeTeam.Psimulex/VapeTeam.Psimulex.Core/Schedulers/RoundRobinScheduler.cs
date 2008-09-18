﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Schedulers
{
    /// <summary>
    /// Classic time-slicing based scheduler.
    /// </summary>
    public class RoundRobinScheduler : IScheduler
    {
        private Queue<Thread> scheduleQueue = new Queue<Thread>();

        private Dictionary<Thread, int> lastSwitchTime = new Dictionary<Thread, int>();

        private ProcessorList processors;
        private ThreadList threads = new ThreadList();

        #region IScheduler Members

        public void Schedule()
        //{
        //}

        //public void Schedule(ProcessorList processors, ThreadList threads)
        {
            /* Pseduo-code
             * 
             * The processors point to the beginnin
             * 
             */
            //for (int i = 0; i < processors.Count; ++i)
            //{
            //    if (processors[i].RunningTask != null)
            //    {
            //        scheduleQueue.Enqueue(processors[i].RunningTask);
            //    }
            //}

            // Keep schedule queue up to date.
            // threads.Where(thread => !scheduleQueue.Contains(thread)).ToList().ForEach(
            //   thread => scheduleQueue.Enqueue(thread));           

            foreach (var processor in processors)
            {
                var thread = FindNext();
                if (thread != null)
                {
                    Thread dequeuedThread = null;
                    while (dequeuedThread != thread)
                    {
                        dequeuedThread = scheduleQueue.Dequeue();
                        scheduleQueue.Enqueue(dequeuedThread);
                    }
                }
                processor.RunningTask = thread;
            }
        }

        //private void

        private Thread FindNext()
        {
            return scheduleQueue.FirstOrDefault(t => !processors.Exists(p => p.RunningTask == t) && t.State == ThreadStates.Running);
            //Thread thread = null;
            //var threadArray = scheduleQueue.ToArray().Where(t => t.State == ThreadStates.Running);
            //for (int i=0; i<threadArray
            //do
            //{
            //    if (scheduleQueue.Count > 0)
            //    {
            //        thread = scheduleQueue.Dequeue();
            //        if (thread.State != ThreadStates.Running)
            //        {
            //            scheduleQueue.Enqueue(thread);
            //        }
            //    }
            //} while (thread != null && thread.State != ThreadStates.Running);
            //return thread;
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
            scheduleQueue.Enqueue(thread);
        }

        public void RemoveThread(Thread thread)
        {
            threads.Remove(thread);
        }

        #endregion
    }
}