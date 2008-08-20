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

        public static object TransformToDotnetType(BaseType value, Type type)
        {
            if (type == typeof(string))
            {
                return value.ToString();
            }
            else
                return null;
        }
    }
}
