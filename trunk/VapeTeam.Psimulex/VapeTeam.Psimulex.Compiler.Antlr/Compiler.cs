using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using global::Antlr.Runtime;

namespace VapeTeam.Psimulex.Compiler.Antlr
{
    public class Compiler : VapeTeam.Psimulex.Compiler.ICompiler
    {
        private List<string> _errorMessages = new List<string>();
        public List<string> ErrorMessages
        {
            get
            {
                return _errorMessages; 
            }
        }

        #region Compiler TempMembers

        public string output;
        public string exception;
        public global::Antlr.Runtime.Tree.CommonTree SintaxTree;

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

                _errorMessages = p.ErrorMessages;                

                //...

                output = ((global::Antlr.Runtime.Tree.CommonTree)tree.Tree).ToStringTree();
                SintaxTree = (global::Antlr.Runtime.Tree.CommonTree)tree.Tree;

                #region Added by pody, for temporary use (2008.09.21. 18:40)

                var visitor = new Psimulex.Compiler.AST.PsiCodeGeneratorVisitor(source, "teszt.psi");
                visitor.Visit(TreeConverter.FromCommonTreeToPsiNode(SintaxTree) as AST.CompilationUnitNode);
                result.CompiledProgram = visitor.Program;

                #endregion
            }
            catch (Exception e)
            {

                exception = e.ToString();
            }
            
            return result;
        }

        #endregion
    }
}
