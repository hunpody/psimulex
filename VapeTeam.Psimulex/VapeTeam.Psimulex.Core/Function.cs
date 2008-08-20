using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    public class Function
    {
        public string Name { get; set; }
        public virtual bool IsUserDefined { get { return true; } }

        public int ParametersCount { get; set; }

        public bool HasReturnValue { get; set; }

        public Function()
        {
        }
    }
}
