using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Exceptions
{
    public class MemoryException : PsimulexCoreException
    {
        public MemoryException(string message)
            : base(message, null)
        {
        }
    }
}
