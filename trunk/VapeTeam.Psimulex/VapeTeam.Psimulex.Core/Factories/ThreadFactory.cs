using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Factories
{
    public class ThreadFactory : VapeTeam.Psimulex.Core.Factories.IThreadFactory
    {
        public Thread CreateThread()
        {
            return new Thread();
        }
    }
}
