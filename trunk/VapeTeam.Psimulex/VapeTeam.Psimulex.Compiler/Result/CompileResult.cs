using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Compiler.Info;

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
        /// User defined type informations list.
        /// </summary>
        public List<UserDefinedTypeInfo> UserDefinedTypeInfoList { get; set; }

        /// <summary>
        /// User defined function informations list.
        /// </summary>
        public List<UserDefinedFunctionInfo> UserDefinedFunctionInfoList { get; set; }

        /// <summary>
        /// Global variable informations list.
        /// </summary>
        public List<GlobalVariableInfo> GlobalVariableInfoList { get; set; }

        /// <summary>
        /// The absolute path of the main source file.
        /// </summary>
        public string ProgramPath { get; set; }


        // Additional message Properties //

        public MessageList CompilerMessages { get; set; }

        public List<Information> Informations { get { return CompilerMessages.Informations; } }
        public List<Warning> Warnings { get { return CompilerMessages.Warnings; } }
        public List<Error> Errors { get { return CompilerMessages.Errors; } }

        public CompileResult()
        {
            CompiledProgram = new Program();
            CompilationUnitList = new List<CompilationUnit>();
            CommandPositionChanges = new CommandPositionChanges();
            PsiFunctionsVariablesNodeList = new List<PsiFunctionsVariablesNode>();

            UserDefinedFunctionInfoList = new List<UserDefinedFunctionInfo>();
            UserDefinedTypeInfoList = new List<UserDefinedTypeInfo>();
            GlobalVariableInfoList = new List<GlobalVariableInfo>();

            ProgramPath = "";

            CompilerMessages = new MessageList();
        }
    }
}
