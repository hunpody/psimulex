using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class ValueFactory
    {
        public static BaseType Create(object value)
        {
            if (value.GetType() == typeof(string))
            {
                return new String((string)value);
            }
            else
            {
                return new String(value.ToString());
            }
        }

        /// <summary>
        /// Transforms a Psimulex type to its closest .NET equivalent.
        /// It is mainly utilized by the SystemCall mechanism.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object TransformToDotnetType(BaseType value, Type type)
        {
            if (type == typeof(string))
            {
                return value.ToString();
            }
            else
                return null;
        }

        /// <summary>
        /// Transforms an array of Psimulex types to their closest .NET equivalent.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="targetTypes"></param>
        /// <returns></returns>
        public static object[] TransformBaseTypeArrayToDotnetType(IEnumerable<BaseType> parameters, Type[] targetTypes)
        {
            object[] objArray = new object[parameters.Count()];
            int objArrayPointer = 0;
            foreach (var par in parameters)
            {
                objArray[objArrayPointer] = TransformToDotnetType(par, targetTypes[objArrayPointer]);
                ++objArrayPointer;
            }

            return objArray;
        }
    }
}
