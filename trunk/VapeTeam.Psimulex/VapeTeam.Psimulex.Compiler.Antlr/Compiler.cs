using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using global::Antlr.Runtime;

namespace VapeTeam.Psimulex.Compiler.Antlr
{
    public class Compiler : VapeTeam.Psimulex.Compiler.ICompiler
    {
        #region Compiler TempMembers

        public List<string> ErrorMessages { get; set; }

        public string OutputString { get; set; }
        public string ExceptionMessages { get; set; }
        public global::Antlr.Runtime.Tree.CommonTree SyntaxTree { get; set; }

        #endregion

        #region ICompiler Members

        public CompileResult Compile(string source)
        {
            CompileResult result = new CompileResult();

            try
            {  
                var stream = new global::Antlr.Runtime.ANTLRStringStream(source);       
                PsimulexLexer lexer = new PsimulexLexer(stream);
                PsimulexParser p = new PsimulexParser(new global::Antlr.Runtime.CommonTokenStream(lexer));

                PsimulexParser.compilationUnit_return tree = p.compilationUnit();
                //PsimulexParser.block_return tree = p.block();
                //PsimulexParser.expression_return tree = p.expression();

                var treeAdaptor = p.TreeAdaptor;

                ErrorMessages = p.ErrorMessages;                

                OutputString = ((global::Antlr.Runtime.Tree.CommonTree)tree.Tree).ToStringTree();
                SyntaxTree = (global::Antlr.Runtime.Tree.CommonTree)tree.Tree;

                #region Added by pody, for temporary use (2008.09.21. 18:40)

                var visitor = new Psimulex.Compiler.AST.PsiCodeGeneratorVisitor(source, "teszt.psi");
                visitor.Visit(TreeConverter.FromCommonTreeToPsiNode(SyntaxTree) as AST.CompilationUnitNode);
                result.CompiledProgram = visitor.Program;
                result.PsiNodeTree = TreeConverter.FromCommonTreeToPsiNode(SyntaxTree);
                #endregion

                #region Added by pody, for temporary use (2008.10.06. 11:48)

                visitor.Program.Program.AddFunctions(visitor.UserDefinedFunctionList);
                
                #endregion
            }
            catch (Exception e)
            {
                ExceptionMessages = e.ToString();
            }
            
            return result;
        }

        #endregion
    }
}
