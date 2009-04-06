using System;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Common
{
    public class VariableEventArgs : EventArgs
    {
        public BaseType Variable { get; set; }
        public string Name { get; set; }
    }
}
