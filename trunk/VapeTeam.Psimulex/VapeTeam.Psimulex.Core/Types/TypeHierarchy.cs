using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public static class TypeHierarchy
    {
        private static Dictionary<TypeEnum, int> _typePriorities = new Dictionary<TypeEnum, int>();

        static TypeHierarchy()
        {
            _typePriorities.Add(TypeEnum.Undefined, 0);
            _typePriorities.Add(TypeEnum.Character, 10);
            _typePriorities.Add(TypeEnum.Integer, 100);
            _typePriorities.Add(TypeEnum.String, 10000);
            _typePriorities.Add(TypeEnum.Void, 0);

        }

        public static bool IsBiggerThan(TypeEnum type1, TypeEnum type2)
        {
            //if (_typePriorities.ContainsKey(type1) && _typePriorities.ContainsKey(type2))
            //{
            //    return _typePriorities[type1] > _typePriorities[type2];
            //}

            return type1 > type2;
        }
    }
}
