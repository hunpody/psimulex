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
    /// <summary>
    /// Wrapp the ANTLR Lexer and Parser.
    /// It parse the source code and convert the ANTLR AST to PsiNode Tree.
    /// </summary>
    public static class ANTLRCompiler
    {
        public static ANTLRCompileResult CompileCompilationUnit(string source, string fileName)
        {
            return Compile(source, fileName, ProgramPart.CompilationUnit);
        }

        public static ANTLRCompileResult CompileStatement(string source, string fileName)
        {
            return Compile(source, fileName, ProgramPart.Statement);
        }

        /// <summary>
        /// Compile a program part
        /// </summary>
        /// <param name="source">The source code</param>
        /// <param name="fileName">The filename of the source file</param>        
        /// <param name="part">Part of a program</param>
        /// <returns>The result</returns>
        public static ANTLRCompileResult Compile(string source, string fileName, ProgramPart part)
        {
            string antlrExceptionText = "";
            IPsiNode psiNode = null;
            List<string> antlrErrorMessages = new List<string>();

            try
            {
                // Create parser
                var parser = CreateParser(source);

                ParserRuleReturnScope tree = null;

                // Parse a program part
                switch (part)
                {
                    case ProgramPart.CompilationUnit:
                        tree = parser.compilationUnit();
                        break;
                    case ProgramPart.Statement:
                        tree = parser.statement();
                        break;
                    default:
                        tree = parser.compilationUnit();
                        break;
                }

                // Save Antlr Messages
                antlrErrorMessages = parser.ErrorMessages;

                // Convert
                psiNode = ConvertToPsiNode((CommonTree)tree.Tree);
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

        /// <summary>
        /// Create a Lexer,
        /// get the tokens from the source,
        /// create a Parser.
        /// </summary>
        /// <param name="source">The source code</param>
        /// <returns>The Psimulex Parser</returns>
        private static PsimulexParser CreateParser(string source)
        {
            // StringStreem
            var stream = new ANTLRStringStream(source);

            // Lexer
            PsimulexLexer lexer = new PsimulexLexer(stream);

            // TokenStreem
            CommonTokenStream tokenStreem = new CommonTokenStream(lexer);

            // Parser
            return new PsimulexParser(tokenStreem);
        }

        /// <summary>
        /// Convert the ANTLR AST to PsiNode Tree
        /// </summary>
        /// <param name="syntaxTree">The ANTLR AST</param>
        /// <returns>The PsiNode Tree</returns>
        private static IPsiNode ConvertToPsiNode(CommonTree syntaxTree)
        {
            // PsiNode Tree
            return TreeConverter.FromCommonTreeToPsiNode(syntaxTree);
        }
    }
}
