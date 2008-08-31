using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Integer : BaseType
    {
        private int value;

        public Integer(int value)
        {
            this.value = value;
        }

        public Integer()
            :this(0)
        {
        }

        public override bool IsLessThan(BaseType value)
        {
            return this.value < value.ToInt();
        }

        public override object ToObject()
        {
            return value;
        }
    }
}
