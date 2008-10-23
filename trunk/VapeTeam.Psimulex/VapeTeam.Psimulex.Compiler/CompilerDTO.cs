using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Core;

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
            CommandPositionChanges = new CommandPositionChanges();
            GlobalVariableList = new List<string>();
            CompilationUnitList = new List<CompilationUnit>();
            UserDefinedFunctionList = new List<UserDefinedFunction>();
        }

        public string Source { get; set; }
        public string SourceFileName { get; set; }

        public CommandPositionChanges CommandPositionChanges { get; set; }
        public List<string> GlobalVariableList { get; set; }
        public List<CompilationUnit> CompilationUnitList { get; set; }
        public List<UserDefinedFunction> UserDefinedFunctionList { get; set; }
    }
}
