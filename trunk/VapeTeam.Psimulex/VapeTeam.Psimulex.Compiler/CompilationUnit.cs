using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Compiler.Result;
using System.IO;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// Holds information about Compilation Units
    /// (The main information is the PsiAST tree)
    /// </summary>
    public class CompilationUnit
    {
        public CompilationUnit()
        {
            FileName = "";
            Source = "";
            CleanedSourceText = "";
            PsiNodeSyntaxTree = null;
        }

        /// <summary>
        /// The file name of the Compilation unit
        /// </summary>
        public string FileName { get; set; }
        
        /// <summary>
        /// The original source code of the Compilation unit
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// The CleanedSourceText is identical with the Source yet
        /// </summary>
        public string CleanedSourceText { get; set; }

        /// <summary>
        /// The Syntax tree of the CompilationUnit
        /// </summary>
        public IPsiNode PsiNodeSyntaxTree { get; set; }
    }
}
