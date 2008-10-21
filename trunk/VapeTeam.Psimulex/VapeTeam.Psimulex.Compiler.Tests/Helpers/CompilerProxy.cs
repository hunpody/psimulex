using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Compiler.Tests.Helpers
{
    static class CompilerProxy
    {
        public static Program Compile(string source)
        {
            var compiler = new VapeTeam.Psimulex.Compiler.Antlr.Compiler();
            var result = compiler.Compile(source);
            return result.CompiledProgram;
        }

        public static CompileResult CompileResult(string source)
        {
            var compiler = new VapeTeam.Psimulex.Compiler.Antlr.Compiler();
            var result = compiler.Compile(source);
            return result;
        }
    }
}
