using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Info
{
    /// <summary>
    /// Holds informations about declared variables
    /// </summary>
    public class VariableInfo : Info
    {
        public VariableInfo(string name, TypeIdentifier ti, string fileName, NodeValueInfo nvi)
            : base(fileName, nvi)
        {
            Name = name;
            Type = ti;
        }

        public string Name { get; set; }
        public TypeIdentifier Type { get; set; }
    }
}
