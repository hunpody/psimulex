using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    public class Registry : VapeTeam.Psimulex.Core.IRegistry
    {
        private BaseType[] registry = new BaseType[4];

        public BaseType this[int index]
        {
            get
            {
                if (!(0 <= index && index < registry.Length))
                {
                    throw new Exceptions.IndexOutOfRangeException(index, 0, registry.Length);
                }
                else
                {
                    return registry[index];
                }
            }
            set
            {
                if (!(0 <= index && index < registry.Length))
                {
                    throw new Exceptions.IndexOutOfRangeException(index, 0, registry.Length);
                }
                else
                {
                    registry[index] = value;
                }
            }
        }

        private static int TranslateStringIndexToIntegerIndex(string index)
        {
            index = index.ToLower();
            if (index.EndsWith("ax"))
                return 0;
            else if (index.EndsWith("bx"))
                return 1;
            else if (index.EndsWith("cx"))
                return 2;
            else if (index.EndsWith("dx"))
                return 3;
            return -1;
        }


        /// <summary>
        /// Common indexing by string. For supporting traditional index names like "AX", "BX", "CX", etc.
        /// </summary>
        /// <param name="registryName"></param>
        /// <returns></returns>
        public BaseType this[string registryName]
        {
            get
            {
                return this[TranslateStringIndexToIntegerIndex(registryName)];
            }
            set
            {
                registry[TranslateStringIndexToIntegerIndex(registryName)] = value;
            }
        }

    }
}
