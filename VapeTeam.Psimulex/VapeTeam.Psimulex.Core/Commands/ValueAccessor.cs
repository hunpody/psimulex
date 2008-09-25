using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// It is intended to be an implicit command executed when a value is referenced by name, 
    /// register id or memory address.
    /// </summary>
    internal class ValueAccessor
    {
    }

    /// <summary>
    /// The modes how the values can be accessed.
    /// </summary>
    public enum ValueAccessModes
    {
        Constant,
        LocalVariable,
        LocalVariableReference
    }
}
