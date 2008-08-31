using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        #region ICompiler Members

        public CompileResult Compile(string source)
        {
            var stream = new global::Antlr.Runtime.ANTLRStringStream(source);       
            PsimulexLexer lexer = new PsimulexLexer(stream);
            PsimulexParser p = new PsimulexParser(new global::Antlr.Runtime.CommonTokenStream(lexer));

            var tree = p.compilationUnit();
            var treeAdaptor = p.TreeAdaptor;

            _errorMessages = p.ErrorMessages;

            CompileResult result = new CompileResult();
            return result;
        }

        #endregion
    }
}
