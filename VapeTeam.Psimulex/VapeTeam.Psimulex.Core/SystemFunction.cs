using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace VapeTeam.Psimulex.Core
{
    public class SystemFunction : Function
    {
        public override bool IsUserDefined
        {
            get
            {
                return false;
            }
        }

        public object HostObject { get; set; }
        public MethodInfo MethodInfo { get; set; }
    }
}
