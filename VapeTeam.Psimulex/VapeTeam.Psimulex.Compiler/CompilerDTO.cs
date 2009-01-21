using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Compiler.Info;
using VapeTeam.Psimulex.Core;
using System.IO;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Factories;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// Simple Data Transfer Object class for compilation Datas.
    /// </summary>
    public class CompilerDTO
    {
        public CompilerDTO()
        {
            Program = ProgramBuilder.Create();

            CompilationUnitList = new List<CompilationUnit>();   
            
            UserDefinedTypeInfoList = new List<UserDefinedTypeInfo>();
            UserDefinedFunctionInfoList = new List<UserDefinedFunctionInfo>();
            GlobalVariableInfoList = new List<GlobalVariableInfo>();            

            CommandPositionChanges = new CommandPositionChanges();

            CompilerMessages = new MessageList();
            
            ProgramPath = "";
        }

        /*Properties*/
        #region Properties       

        /// <summary>
        /// The compiled program (Without User functions and User types)
        /// </summary>
        public ProgramBuilder Program { get; set; }

        /// <summary>
        /// List of Compilation Units
        /// </summary>
        public List<CompilationUnit> CompilationUnitList { get; set; }

        /// <summary>
        /// List of User defined type informations
        /// </summary>
        public List<UserDefinedTypeInfo> UserDefinedTypeInfoList { get; set; }

        /// <summary>
        /// List of User defined function informations
        /// </summary>
        public List<UserDefinedFunctionInfo> UserDefinedFunctionInfoList { get; set; }

        /// <summary>
        /// List of Global variable informations
        /// </summary>
        public List<GlobalVariableInfo> GlobalVariableInfoList { get; set; }

        /// <summary>
        /// Command position changes for the LexLighter function
        /// </summary>
        public CommandPositionChanges CommandPositionChanges { get; set; }

        /// <summary>
        /// Messages of the compiler. (Informations,Warnings,Errors,ANTLRErrors)
        /// </summary>
        public MessageList CompilerMessages { get; set; }

        /// <summary>
        /// The absolute path of the main source file.
        /// </summary>
        public string ProgramPath { get; set; }

        #endregion

        /*Helper Methods*/
        #region Helper Methods

        /// <summary>
        /// Get the ITypeDescriptor of an User defined type, by name.
        /// If does not exist (Undefined), return null.
        /// </summary>
        /// <param name="typeName">The type name</param>
        /// <returns>If type name does not exist, return null, else the UserTypeDescriptor.</returns>
        public ITypeDescriptor GetUserTypeDescriptor(string typeName)
        {
            ITypeDescriptor td = null;
            var ti = UserDefinedTypeInfoList.Find(t => t.Name == typeName);
            if (ti != null)
                td = ti.Type.UserDefinedType;
            return td;
        }

        #endregion

        /*Message Generators*/
        #region Message Generators

        public void AddInformation(string msg, NodeValueInfo info, string sourceFileName)
        {
            CompilerMessages.Informations.Add(
                new Information { MessageText = msg, Interval = info.ToInterval(sourceFileName) });
        }

        public void AddWarning(CompilerErrorCode code, string warning, NodeValueInfo info, string sourceFileName)
        {
            CompilerMessages.Warnings.Add(
                new Warning { ErrorCode = code, MessageText = warning, Interval = info.ToInterval(sourceFileName) });
        }

        public void AddError(CompilerErrorCode code, string error, NodeValueInfo info, string sourceFileName)
        {
            CompilerMessages.Errors.Add(
                new Error { ErrorCode = code, MessageText = error, Interval = info.ToInterval(sourceFileName) });
        }

        public void AddError(CompilerErrorCode code, string error, NodeValueInfo info, Exception ex, string sourceFileName)
        {
            AddError(code, error, info, sourceFileName);
            throw ex;
        }

        #endregion
    }
}
