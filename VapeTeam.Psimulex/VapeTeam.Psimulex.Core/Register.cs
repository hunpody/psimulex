using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// A class representing processor-level registers.
    /// It is holding a standard basetype object.
    /// </summary>
    public class Register
    {
        public BaseType Value { get; set; }
    }
}
