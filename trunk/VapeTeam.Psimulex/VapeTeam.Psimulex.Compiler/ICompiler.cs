using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// General interface for Psimulex compilers.
    /// </summary>
    public interface ICompiler
    {
        CompileResult Compile(string source);
    }
}
