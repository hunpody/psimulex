using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Core;
using System.IO;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// Simple Data Transfer Object class for compilation Datas.
    /// </summary>
    public class CompilerDTO
    {
        public CompilerDTO()
        {
            Source = "";
            SourceFileName = "";
            ProgramPath = "";
            CommandPositionChanges = new CommandPositionChanges();            
            GlobalVariableList = new List<string>();
            CompilationUnitList = new List<CompilationUnit>();
            UserDefinedFunctionList = new List<UserDefinedFunction>();

            TypeIdentifierList = new List<TypeIdentifier>();
        }

        /// <summary>
        /// The source code of a compilation unit.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// The file name of the source file.
        /// </summary>
        public string SourceFileName { get; set; }

        /// <summary>
        /// The absolute path of the main source file.
        /// </summary>
        public string ProgramPath { get; set; }

        /// <summary>
        /// The absolute path of the source file.
        /// </summary>
        public string SourceFile { get { return Path.IsPathRooted(SourceFileName) ? SourceFileName : Path.Combine(ProgramPath, SourceFileName); } }

        public CommandPositionChanges CommandPositionChanges { get; set; }
        public List<string> GlobalVariableList { get; set; }
        public List<CompilationUnit> CompilationUnitList { get; set; }
        public List<UserDefinedFunction> UserDefinedFunctionList { get; set; }

        public List<TypeIdentifier> TypeIdentifierList { get; set; }
    }
}
