using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Info
{
    /// <summary>
    /// Holds informations about User defined functions
    /// </summary>
    public class UserDefinedFunctionInfo : Info
    {
        public UserDefinedFunctionInfo(UserDefinedFunction udf, string fileName, NodeValueInfo nvi)
            : base(fileName, nvi)
        {
            Function = udf;
        }

        public string Name { get { return Function.Name; } }
        public UserDefinedFunction Function { get; set; }

        public int ParameterCount { get { return Function.ParameterCount; } }
    }
}
