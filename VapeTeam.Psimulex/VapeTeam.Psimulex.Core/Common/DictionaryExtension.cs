using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Common
{
    public static class DictionaryExtension
    {
        /// <summary>
        /// Tries to retrieve the value by the given key. If present, overwrites it, otherwise adds a new key/value pair.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddOrOverwrite(this IDictionary<string, BaseType> dictionary, string key, BaseType value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }
    }
}
