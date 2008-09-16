using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    public interface IScheduler
    {
        void Initialize(ProcessorList processors);
        void AddThread(Thread thread);
        void RemoveThread(Thread thread);        
        void Schedule();
        int SwitchTime { get; }
    }
}
