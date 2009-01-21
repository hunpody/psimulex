using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Info
{
    /// <summary>
    /// Holds informations about declared Global variables
    /// </summary>
    public class GlobalVariableInfo : VariableInfo
    {
        public GlobalVariableInfo(string name, TypeIdentifier ti, BaseType value, string fileName, NodeValueInfo nvi)
            : base(name,ti,fileName,nvi)
        {
            Value = value;
        }

        public BaseType Value { get; set; }
        public bool IsInitialised { get { return Value == null; } }
    }
}
