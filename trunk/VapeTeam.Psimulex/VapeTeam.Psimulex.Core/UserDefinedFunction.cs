using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// User defined function.
    /// The Function Object Contains the CommandList.
    /// </summary>
    public class UserDefinedFunction
    {
        public class Parameter
        {
            public string Name { get; set; }

            public TypeEnum Type { get; set; }
            public string TypeName { get; set; }    // If the type is Userdefined, we need TypeName
            public bool IsReference { get; set; }
            public bool IsDynamicArray { get; set; }
            public int ArrayDimension { get; set; }
        }

        public string Name { get; set; }

        public List<Parameter> ParameterList { get; set; }

        public TypeEnum ReturnType { get; set; }
        public string ReturnTypeName { get; set; }  // If the type is Userdefined, we need TypeName
        public bool ReturnTypeIsReference { get; set; }
        public bool ReturnTypeIsDynamicArray { get; set; }
        public int ReturnTypeArrayDimension { get; set; }

        public CommandList Code { get; set; }
    }
}
