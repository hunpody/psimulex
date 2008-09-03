using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class ValueFactory
    {
        /// <summary>
        /// Creates a Psimulex value object from the .NET object. It wraps .NET objects into Psimulex ones.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BaseType Create(object value)
        {
            if (value.GetType() == typeof(BaseType) || value.GetType().IsSubclassOf(typeof(BaseType)))
            {
                return (BaseType) value;
            }
            else if (value.GetType() == typeof(long))
            {
                return new Integer((long)value);
            }
            else if (value.GetType() == typeof(int))
            {
                long x = (int) value;
                return new Integer(x);
            }
            else if (value.GetType() == typeof(string))
            {
                return new String((string)value);
            }
            else if (value.GetType() == typeof(bool))
            {
                return new Boolean((bool)value);
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

        /// <summary>
        /// Creates a BaseType value from the given typeEnum.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static BaseType CreateValue(TypeEnum type)
        {
            switch (type)
            {
                case TypeEnum.Void:
                    return null;
                    break;
                case TypeEnum.Integer:
                    return new Integer();
                    break;
                case TypeEnum.Char:
                    //return new Char();
                    return null;
                    break;
                case TypeEnum.String:
                    return new String();
                    break;
                default:
                    return null;
                    break;
            }
        }


        /// <summary>
        /// Creates a BaseType value from the type name string.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static BaseType CreateValue(string type)
        {
            object parsedType = Enum.Parse(typeof(TypeEnum), type);
            if (parsedType != null)
            {
                return CreateValue((TypeEnum)parsedType);
            }
            else
            {
                // throw ex?
                return null;
            }
        }

        //public static void ConvertToHigher(BaseType a, BaseType b, out BaseType convertedA, out BaseType convertedB)
        //{          

        //}
    }
}
