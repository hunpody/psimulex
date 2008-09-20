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
        /// <summary>
        /// Tells if the type1 has bigger priority than type2.
        /// </summary>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <returns></returns>
        public static bool IsBiggerThan(TypeEnum type1, TypeEnum type2)
        {
            return type1 > type2;
        }

        /// <summary>
        /// Returns the bigger type enum.
        /// </summary>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <returns></returns>
        public static TypeEnum GetBiggerType(TypeEnum type1, TypeEnum type2)
        {
            if (IsBiggerThan(type1, type2))
                return type1;
            else
                return type2;
        }

        /// <summary>
        /// Orders the given value references by their type-priorities.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
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
