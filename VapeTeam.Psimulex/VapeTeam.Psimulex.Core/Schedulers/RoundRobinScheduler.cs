using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Schedulers
{
    public class RoundRobinScheduler : IScheduler
    {
        #region IScheduler Members

        public void Schedule(ProcessorList processors, ThreadList threads)
        {
            throw new NotImplementedException();
        }

        public int SwitchTime
        {
            get { return 10; }
        }

        #endregion
    }
}
