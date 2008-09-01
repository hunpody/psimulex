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
        

        #endregion

        #region ICompiler Members

        public CompileResult Compile(string source)
        {
            var stream = new global::Antlr.Runtime.ANTLRStringStream(source);       
            PsimulexLexer lexer = new PsimulexLexer(stream);
            PsimulexParser p = new PsimulexParser(new global::Antlr.Runtime.CommonTokenStream(lexer));

            PsimulexParser.parExpression_return tree = p.parExpression();
            var treeAdaptor = p.TreeAdaptor;

            _errorMessages = p.ErrorMessages;

            CompileResult result = new CompileResult();

            //...

            output = ((global::Antlr.Runtime.Tree.BaseTree)tree.Tree).ToStringTree();
            global::Antlr.Runtime.Tree.BaseTree t = (global::Antlr.Runtime.Tree.BaseTree)tree.Tree;
            
            return result;
        }

        #endregion
    }
}
