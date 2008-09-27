using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The VariableMap maps strings to basetypes in order to find variables by name. 
    /// Useful for global variables and registers.
    /// </summary>
    public class VariableMap : Dictionary<string, BaseType>
    {
    }
}
