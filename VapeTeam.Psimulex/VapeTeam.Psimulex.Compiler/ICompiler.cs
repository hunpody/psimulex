using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// General interface for Psimulex compilers.
    /// </summary>
    public interface ICompiler
    {
        CompileResult Compile(string source, string fileName);
    }
}
