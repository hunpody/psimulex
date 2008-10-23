using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /// <summary>
    /// Help class for Struct Members and
    /// for function formal parameters.
    /// </summary>
    public class Member
    {
        public TypeEnum Type { get; set; }
        public string TypeName { get; set; }
        public int DimensionCount { get; set; }
        public List<int> DimensionList { get; set; }
        public string Name { get; set; }

        // For struct Members
        public BaseType Value { get; set; }
        public bool IsInitialized { get; set; }

        // For Function Parameter
        public bool IsDynamicArray { get; set; }
        public bool IsReference { get; set; }

        public Member()
        {
            Type = TypeEnum.Undefined;
            TypeName = "";
            DimensionCount = 0;
            DimensionList = new List<int>();
            Name = "";
            Value = null;
            IsInitialized = false;
            IsDynamicArray = false;
            IsReference = false;
        }

        public override string ToString()
        {
            string member = "";

            if (Type == TypeEnum.UserDefinedType)
                member += TypeName + " ";
            else
                member += Type + " ";
            member += " ( Dim:" + DimensionCount + " ";
            member += "[";
            for (int i = 0; i < DimensionList.Count; i++)
            {
                member += DimensionList[i];
                if (i != DimensionList.Count - 1)
                    member += ", ";
            }
            member += "] ) ";
            member += IsReference ? "& " : "";
            member += Name + " ";
            member += Value;

            return member;
        }
    }
}
