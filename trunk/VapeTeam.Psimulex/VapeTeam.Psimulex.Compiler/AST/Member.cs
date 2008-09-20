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
        public string TypeName { get; set; }
        public int DimensionCount { get; set; }
        public List<int> DimensionList { get; set; }
        public string Name { get; set; }
        public BaseType Value { get; set; }
        public bool IsInitialised { get; set; }

        public Member()
        {
            Type = TypeEnum.Undefined;
            TypeName = "";
            DimensionCount = 1;
            DimensionList = new List<int>();
            Name = "";
            Value = null;
            IsInitialised = false;
        }

        public Member(TypeEnum type, string typeName, int dimensionCount, List<int> dimensionList, string name, BaseType value, bool isInitialised)
        {
            Type = type;
            TypeName = typeName;
            DimensionCount = dimensionCount;
            DimensionList = dimensionList;
            Name = name;
            Value = value;
            IsInitialised = isInitialised;
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
            member += Name + " ";
            member += Value;

            return member;
        }
    }
}
