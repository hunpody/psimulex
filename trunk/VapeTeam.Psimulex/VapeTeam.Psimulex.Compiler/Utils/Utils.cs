using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Utils
{
    public static class Utils
    {
        public static string SplitQuotes(this string s)
        {
            if (s[0] == '\'' || s[0] == '\"')
                return s.Substring(1, s.Length - 2);
            return s;
        }
    }
}
