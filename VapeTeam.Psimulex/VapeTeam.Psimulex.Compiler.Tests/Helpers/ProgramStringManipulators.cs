using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Tests.Helpers
{
    public static class ProgramStringManipulators
    {
        public static string WrapInMainFunction(this string str)
        {
            return @"void Main(){" + str + "}";
        }
    }
}
