using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Converter
    {
        private static T TryToConvert<T>(Func<T> convertFunction)
        {
            try
            {
                return convertFunction();
            }
            catch
            {
                // Do some logging or warning based on a policy read from config.
            }
            return default(T);
        }

        public static int ToInt32(object o)
        {
            return TryToConvert<int>(() => { return Convert.ToInt32(o); });
        }
        public static long ToInt64(object o)
        {
            return TryToConvert<long>(() => { return Convert.ToInt64(o); });
        }
        public static char ToChar(object o)
        {
            return TryToConvert<char>(() => { return Convert.ToChar(o); });
        }
        public static string ToString(object o)
        {
            return TryToConvert<string>(() => { return Convert.ToString(o); });
        }
        public static float ToFloat(object o)
        {
            return TryToConvert<float>(() => { return Convert.ToSingle(o); });
        }
        public static decimal ToDecimal(object o)
        {
            return TryToConvert<decimal>(() => { return Convert.ToDecimal(o); });
        }
        public static bool ToBoolean(object o)
        {
            return TryToConvert<bool>(() => { return Convert.ToBoolean(o); });
        }

    }
}
