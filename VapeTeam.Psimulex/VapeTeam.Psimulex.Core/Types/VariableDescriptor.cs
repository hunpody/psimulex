using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// It stores the necessary information about a variable definition.
    /// It is used for parameters, local and global variable definitions and for structs also.
    /// </summary>
    public class VariableDescriptor
    {
        public string Name { get; set; }
        public TypeIdentifier Type { get; set; }
        public bool IsReference { get; set; }
        public bool IsArray { get; set; }
        public bool Dimensions { get; set; }
    }
}
