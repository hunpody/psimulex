using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Exceptions
{
    public class InvalidOperationException : PsimulexCoreException
    {
        public InvalidOperationException(string message)
            : base(message)
        {

        }

        public InvalidOperationException()
            : this("The requested operation is not valid.")
        {

        }
    }
}
