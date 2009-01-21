using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Exceptions
{
    [Serializable]
    public class CompilerException : Exception
    {
        public CompilerException()
            :this("CompilerException")
        { }
        public CompilerException(string message) : base(message) { }
        public CompilerException(string message, Exception inner) : base(message, inner) { }
        protected CompilerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}