using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Info
{
    /// <summary>
    /// Holds informations about User defined types
    /// </summary>
    public class UserDefinedTypeInfo : Info
    {
        public UserDefinedTypeInfo(TypeIdentifier ti, string fileName, NodeValueInfo nvi)
            : base(fileName, nvi)
        {
            Type = ti;
        }

        public string Name { get { return Type.TypeName; } }
        public TypeIdentifier Type { get; set; }
    }
}
