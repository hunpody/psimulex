using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    public static class Logger
    {
        static StringBuilder sb = new StringBuilder();

        public static void Log(string msg)
        {
            sb.AppendLine(msg);
        }
    }
}
