using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// General exception base class.
    /// </summary>
    public class PsimulexException : ApplicationException
    {
        public PsimulexException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public PsimulexException(string message)
            : this(message, null)
        {

        }

        public PsimulexException()
            : this("An error occured in Psimulex")
        {

        }
    }
}
