using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler;

namespace VapeTeam.Psimulex.Compiler.Tests.Helpers
{
    static class CompilerProxy
    {
        public static Program Compile(string source)
        {
            var compiler = new Compiler();
            var result = compiler.Compile(source,"teszt.psi");
            return result.CompiledProgram;
        }

        public static CompileResult CompileResult(string source)
        {
            var compiler = new Compiler();
            var result = compiler.Compile(source, "teszt.psi");
            return result;
        }
    }
}
