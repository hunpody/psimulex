using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    public interface IScheduler
    {
        void Schedule(ProcessorList processors, ThreadList threads);
        int SwitchTime { get; }
    }
}
