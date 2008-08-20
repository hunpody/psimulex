using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class String : BaseType
    {
        private string value;

        public String(string value)
        {
            this.value = value;
        }

        public String()
            : this(string.Empty)
        {
        }

        public override string ToString()
        {
            return value;
        }
    }
}
