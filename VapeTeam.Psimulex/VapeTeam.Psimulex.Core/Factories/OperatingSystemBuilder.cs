using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Factories
{
    public class OperatingSystemBuilder
    {
        //private static VapeTeam.Psimulex.Core.Historization.IHistory h = new Historization.History();

        public static OperatingSystem CreateOSWithRoundRobin()
        {
            var os = new OperatingSystem(new Schedulers.RoundRobinScheduler());
            os.ThreadFactory = new HistoricalThreadFactory(VapeTeam.Psimulex.Core.Historization.GlobalHistory.Instance);
            os.InstallLibrary(new VapeTeam.Psimulex.Core.Libraries.StandardLibrary());
            return os;
        }
    }
}
