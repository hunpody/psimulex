using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Antlr.AntlrTools;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr
{
    public class PsiNodeParser : IPsiNodeParser
    {
        #region IPsiNodeParser Members

        public void Parse(string source, string sourceFileName, CompilerDTO dto, ProgramPart part)
        {
            // ANTLR Compile
            var result = ANTLRCompiler.Compile(source, sourceFileName, part);

            // Simple program can not be imported
            if (dto.CompilationUnitList.Count != 0 &&
                result.PsiNode != null &&
                result.PsiNode.Left != null &&
                result.PsiNode.Left.GetType() == typeof(SimpleProgramNode))
            {
                dto.CompilerMessages.Warnings.Add(new Warning
                    {
                        Interval = new Interval() { FileName = sourceFileName },
                        MessageText = string.Format(
                        "Simple programs can not be imported! Compilation unit will be skipped!")
                    });
                return;
            }

            // Create CompilationUnit
            dto.CompilationUnitList.Add(
                new CompilationUnit
                {
                    Source = source,
                    CleanedSourceText = source,
                    FileName = sourceFileName,
                    PsiNodeSyntaxTree = result.PsiNode
                });

            // Generate messages
            if (result.ANTLRExceptionText != "" || result.ANTLRErrorMessages.Count != 0)
            {
                result.ANTLRErrorMessages.ForEach(x =>
                    dto.CompilerMessages.AntlrErrors.Add(new AntlrError
                    {
                        Interval = new Interval() { FileName = sourceFileName },
                        MessageText = x
                    }));

                if (result.ANTLRExceptionText != "")
                    dto.CompilerMessages.AntlrErrors.Add(new AntlrError
                    {
                        Interval = new Interval(),
                        MessageText = result.ANTLRExceptionText
                    });
            }
        }

        #endregion
    }
}
