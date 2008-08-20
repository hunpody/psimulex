using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// Base exception class for the exceptions thrown in the Psimulex.Core module.
    /// </summary>
    public class PsimulexCoreException : PsimulexException
    {
        public PsimulexCoreException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public PsimulexCoreException(string message)
            : this(message, null)
        {

        }

        public PsimulexCoreException()
            : this("An error occured in the Psimulex Core Engine")
        {

        }   
    }
}
