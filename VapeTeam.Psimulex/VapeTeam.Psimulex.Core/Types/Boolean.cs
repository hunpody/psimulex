using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Boolean : BaseType
    {
        private bool value;

        public Boolean(bool value)
        {
            this.value = value;
        }

        public Boolean()
            : this(false)
        {
        }

        public override object ToObject()
        {
            return value;
        }
    }
}
