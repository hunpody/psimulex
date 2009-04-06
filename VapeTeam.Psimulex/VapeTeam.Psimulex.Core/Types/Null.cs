using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Null : BaseType
    {
        public bool IsNull { get; set; }

        public Null()
        {
            IsNull = true;
        }

        public override BaseType Clone()
        {
            return new Null();
        }

        public override bool EqualsTo(IBaseType value)
        {
            return value.ToNull().IsNull;
        }
                
        public override Null ToNull()
        {
            return new Null();
        }

        public override string ToString()
        {
            return "NULL";
        }

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Null; }
        }
    }
}
