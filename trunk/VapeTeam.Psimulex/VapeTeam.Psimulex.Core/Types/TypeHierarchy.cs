using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// This class tells which type has more priority.
    /// </summary>
    public static class TypeHierarchy
    {
        public static bool IsBiggerThan(TypeEnum type1, TypeEnum type2)
        {
            return type1 > type2;
        }

        public static void OrderTypes(ref BaseType first, ref BaseType second)
        {
            BaseType higher;
            if (IsBiggerThan(second.TypeEnum, first.TypeEnum))
            {
                higher = second;
                second = first;
                first = higher;
            }                
        }
    }
}
