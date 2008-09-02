using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using global::Antlr.Runtime;

namespace VapeTeam.Psimulex.Compiler.Antlr
{
    public class Compiler : VapeTeam.Psimulex.Compiler.ICompiler
    {
        private List<string> _errorMessages;
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

                //PsimulexParser.expression_return tree = p.expression();
                PsimulexParser.selecting_return tree = p.selecting();
                var treeAdaptor = p.TreeAdaptor;

                _errorMessages = p.ErrorMessages;                

                //...

                output = ((global::Antlr.Runtime.Tree.CommonTree)tree.Tree).ToStringTree();
                global::Antlr.Runtime.Tree.CommonTree t = (global::Antlr.Runtime.Tree.CommonTree)tree.Tree;
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
