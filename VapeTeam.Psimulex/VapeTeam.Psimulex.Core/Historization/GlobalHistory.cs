using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Historization
{
    public static class GlobalHistory
    {
        private static IHistory _instance;

        public static IHistory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = CreateHistory();
                }
                return _instance;
            }
        }

        private static IHistory CreateHistory()
        {
            return new History();
        }
    }
}
