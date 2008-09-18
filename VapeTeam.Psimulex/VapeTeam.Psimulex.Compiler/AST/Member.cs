using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public class Member
    {
        public TypeEnum Type { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool IsInitialised { get; set; }

        public Member(TypeEnum type, string name, string value, bool isInitialised)
        {
            Type = type;
            Name = name;
            Value = value;
            IsInitialised = isInitialised;
        }
    }
}
