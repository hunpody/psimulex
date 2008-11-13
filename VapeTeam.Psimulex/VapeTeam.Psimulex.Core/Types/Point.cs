using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Point : BaseType
    {
        public float X { get; set; }
        public float Y { get; set; }

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Point; }
        }
    }
}
