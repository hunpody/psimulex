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

        public override object ToObject()
        {
            return value;
        }

        /// <summary>
        /// ToUpper remains in the Psimulex Type System.
        /// </summary>
        /// <returns></returns>
        public String ToUpper()
        {
            return new String(value.ToUpper());
        }

        /// <summary>
        /// Contains gets out of the type system but still discoverable by the engine.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Contains(string s)
        {
            return value.Contains(s);
        }
    }
}
