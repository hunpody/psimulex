using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Result
{
    public class CompileResult
    {
        /// <summary>
        /// The compiled program.
        /// </summary>
        public Program CompiledProgram { get; set; }

        /// <summary>
        /// The syntax tree of all Compilation Unit imported in the program
        /// </summary>
        public List<CompilationUnit> CompilationUnitList { get; set; }

        /// <summary>
        /// Highlight intervals and stepping informations.
        /// </summary>
        public CommandPositionChanges CommandPositionChanges { get; set; }

        /// <summary>
        /// PsiFunctionsVariablesNodeList.
        /// </summary>
        public List<PsiFunctionsVariablesNode> PsiFunctionsVariablesNodeList { get; set; }

        /// <summary>
        /// User defined functions list.
        /// </summary>
        public List<UserDefinedFunction> UserDefinedFunctionsList { get; set; }

        
        // public UserDefinedTypesList ...

        // Additional Getter on teh list unions Example Warnings etc

        public CompileResult()
        {
            CompiledProgram = new Program();
            CompilationUnitList = new List<CompilationUnit>();
            CommandPositionChanges = new CommandPositionChanges();
            UserDefinedFunctionsList = new List<UserDefinedFunction>();
        }
    }
}
