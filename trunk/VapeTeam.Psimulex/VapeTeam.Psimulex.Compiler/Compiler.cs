using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Compiler.AntlrTools;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Compiler
{
    /// <summary>
    /// Psimulex Compiler.
    /// Generate the Comand Object Array,
    /// Generate FunctionVariableTree.
    /// </summary>
    public class Compiler : VapeTeam.Psimulex.Compiler.ICompiler
    {
        /// <summary>
        /// The result of, the last compile.
        /// </summary>
        public CompileResult CompileResult { get; private set; }

        public Compiler()
        {
            CompileResult = new CompileResult();
        }

        public CompileResult Compile(string source, string sourceFileName)
        {
            return Compile(new CompilerDTO{ Source = source, SourceFileName = sourceFileName }, true);
        }

        public CompileResult Compile(CompilerDTO dto)
        {
            return Compile(dto, true);
        }

        public CompileResult Compile(CompilerDTO dto, bool compileFuncVarTree)
        {
            CompileResult = new CompileResult();

            GenerateMicrolexCode(dto);

            if (compileFuncVarTree)
                CompileResult.PsiFunctionsVariablesNodeList = GenerateFuncVarTree(CompileResult.CompilationUnitList);

            FinalizeTheResult();

            return CompileResult;
        }

        public void GenerateMicrolexCode(CompilerDTO dto)
        {
            var result = ANTLRCompiler.CompileCompilationUnit(dto.Source, dto.SourceFileName);

            if (result.ANTLRExceptionText != "" || result.ANTLRErrorMessages.Count != 0)
            {
                CompileResult.CompilationUnitList.Add(new CompilationUnit
                {
                    ANTLRErrorMessages = result.ANTLRErrorMessages,
                    ANTLRExceptionText = result.ANTLRExceptionText
                });
                return;
            }

            var visitor = new PsiCodeGeneratorVisitor(dto, result.ANTLRExceptionText, result.ANTLRErrorMessages);

            try
            {
                visitor.Visit(result.PsiNode as CompilationUnitNode);
                visitor.CurrentCompilationUnit.PsiNodeSyntaxTree = result.PsiNode as CompilationUnitNode;
            }
            catch (Exception e)
            {
                visitor.CurrentCompilationUnit.CompilerMessages.Errors.Add(new Error
                {
                    MessageText = e.ToString(),
                    Interval = new Interval
                    {
                        FromLine = -1,
                        FromColumn = -1,
                        ToLine = -1,
                        ToColumn = -1,
                        FileName = dto.SourceFileName
                    }
                });
            }

            CompileResult.CompiledProgram = visitor.Program;
            CompileResult.CommandPositionChanges = visitor.CommandPositionChanges;
            CompileResult.CompilationUnitList = visitor.CompilationUnitList;
            CompileResult.UserDefinedFunctionsList = visitor.UserDefinedFunctionList;            
        }

        public List<PsiFunctionsVariablesNode> GenerateFuncVarTree(List<CompilationUnit> compilationUnitList)
        {
            List<PsiFunctionsVariablesNode> list = new List<PsiFunctionsVariablesNode>();

            foreach (var item in compilationUnitList)
            {
                if (item.PsiNodeSyntaxTree != null)
                {
                    var q = new PsiFunctionsVariablesQueryVisitor(item.Source, item.FileName);
                    q.Visit(item.PsiNodeSyntaxTree as CompilationUnitNode);
                    list.AddRange(q.PsiNodeList);
                }
            }           

            return list;
        }

        /// <summary>
        /// The last steps on the result befor return.
        /// </summary>
        public void FinalizeTheResult()
        {
            // Add functions to the program
            CompileResult.CompiledProgram.AddFunctions(CompileResult.UserDefinedFunctionsList);

            // Merge The messageLists
            // ...
            // Add getters to he result
        }
    }
}
