using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// The interface of a Parser, what will be create a PsiAST tree from a source code.
    /// </summary>
    public interface IPsiNodeParser
    {
        /// <summary>
        /// Parse the source code into a PsiAST tree.
        /// This function dont load source code from file.
        /// The file name used just for labelling the CompilationUnit,
        /// what created in the dto object.
        /// </summary>
        /// <param name="source">The source code</param>
        /// <param name="sourceFileName">The file name of teh source code</param>
        /// <param name="dto">The place of teh result</param>
        void Parse(string source, string sourceFileName, CompilerDTO dto);
    }
}
