using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Factories
{
    public class OperatingSystemBuilder
    {
        public static OperatingSystem CreateOSWithRoundRobin()
        {
            var os = new OperatingSystem(new Schedulers.RoundRobinScheduler());
            os.InstallLibrary(new VapeTeam.Psimulex.Core.Libraries.StandardLibrary());
            return os;
        }
    }
}
