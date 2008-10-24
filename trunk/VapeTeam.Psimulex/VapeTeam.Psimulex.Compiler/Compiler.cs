using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Compiler.AntlrTools;
using VapeTeam.Psimulex.Core;
using System.IO;

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
            // SourceFilePath is the path of the main source file.
            // All other relative imports calculated from this path.

            string fullPath = Path.GetFullPath(sourceFileName);
            sourceFileName = Path.GetFileName(fullPath);
            string sourceFilePath = Path.GetDirectoryName(fullPath);

            return Compile(new CompilerDTO
            {
                Source = source,
                SourceFileName = sourceFileName,
                ProgramPath = sourceFilePath
            }, true);
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
                var msgList = new MessageList();

                result.ANTLRErrorMessages.ForEach(x =>
                    msgList.AntlrErrors.Add(new AntlrError
                    {
                        Interval = new Interval() { FileName = dto.SourceFileName },
                        MessageText = x
                    }));

                if (result.ANTLRExceptionText != "")
                    msgList.AntlrErrors.Add(new AntlrError
                    {
                        Interval = new Interval(),
                        MessageText = result.ANTLRExceptionText
                    });

                dto.CompilationUnitList.Add(new CompilationUnit{CompilerMessages = msgList});
                CompileResult.CompilationUnitList = dto.CompilationUnitList;
                return;
            }

            var visitor = new PsiCodeGeneratorVisitor(dto/*, result.ANTLRExceptionText, result.ANTLRErrorMessages*/);

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
            CompileResult.UserDefinedFunctionList = visitor.UserDefinedFunctionList;            
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
            CompileResult.CompiledProgram.AddFunctions(CompileResult.UserDefinedFunctionList);
            foreach (var item in CompileResult.CompilationUnitList)
            {
                CompileResult.CompilerMessages.Informations.AddRange(item.CompilerMessages.Informations);
                CompileResult.CompilerMessages.Warnings.AddRange(item.CompilerMessages.Warnings);
                CompileResult.CompilerMessages.Errors.AddRange(item.CompilerMessages.Errors);
            }


            // Merge The messageLists
            // ...
            // Add getters to he result
        }
    }
}
