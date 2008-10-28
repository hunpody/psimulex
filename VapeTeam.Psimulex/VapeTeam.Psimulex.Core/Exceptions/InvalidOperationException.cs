using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Exceptions
{
    public class InvalidOperationException : PsimulexCoreException
    {
        public InvalidOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidOperationException(string message)
            : this(message, null)
        {
        }

        public InvalidOperationException()
            : this("The requested operation is not valid.")
        {

        }
    }
}
