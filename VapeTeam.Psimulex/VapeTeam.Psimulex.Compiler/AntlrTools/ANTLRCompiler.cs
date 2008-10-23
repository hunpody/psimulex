using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.AST;
using global::Antlr.Runtime;
using global::Antlr.Runtime.Tree;
using VapeTeam.Psimulex.Compiler.Result;

namespace VapeTeam.Psimulex.Compiler.AntlrTools
{
    public static class ANTLRCompiler
    {
        public static ANTLRCompileResult CompileCompilationUnit(string source, string fileName)
        {
            string antlrExceptionText = "";
            IPsiNode psiNode = null;
            List<string> antlrErrorMessages = new List<string>();

            try
            {
                // StringStreem
                var stream = new ANTLRStringStream(source);

                // Lexer
                PsimulexLexer lexer = new PsimulexLexer(stream);

                // TokenStreem
                CommonTokenStream tokenStreem = new CommonTokenStream(lexer);

                // Parser
                PsimulexParser parser = new PsimulexParser(tokenStreem);

                // Parse Compilation Unit
                PsimulexParser.compilationUnit_return tree = parser.compilationUnit();
         
                // Save Antlr Messages
                antlrErrorMessages = parser.ErrorMessages;

                // Syntax Tree
                CommonTree syntaxTree = (CommonTree)tree.Tree;

                // PsiNode Tree
                psiNode = TreeConverter.FromCommonTreeToPsiNode(syntaxTree);
            }
            catch (Exception ex)
            {
                antlrExceptionText = ex.ToString();
            }

            return new ANTLRCompileResult
            {
                ANTLRErrorMessages = antlrErrorMessages,
                PsiNode = psiNode,
                ANTLRExceptionText = antlrExceptionText
            };
        }
    }
}
