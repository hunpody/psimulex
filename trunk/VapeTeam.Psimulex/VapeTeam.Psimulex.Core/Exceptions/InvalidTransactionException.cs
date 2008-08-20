using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Exceptions
{
    /// <summary>
    /// The exception that is being thrown if a transaction becomes invalid. (f.e. other transaction commits to the same target)
    /// </summary>
    public class InvalidTransactionException : PsimulexCoreException
    {
        public InvalidTransactionException(string message)
            : base(message)
        {

        }

        public InvalidTransactionException()
            : this("The transaction was in an invalid status")
        {

        }
    }
}
