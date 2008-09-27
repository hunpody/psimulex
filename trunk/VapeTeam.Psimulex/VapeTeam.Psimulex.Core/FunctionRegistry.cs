using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    public class FunctionRegistry 
    {
        private Dictionary<string, SystemFunction> map = new Dictionary<string, SystemFunction>();

        public void Add(SystemFunction systemFunction)
        {
            string functionName = systemFunction.Name.ToLower();
            if (map.ContainsKey(functionName))
            {
                //throw new PsimulexCoreException(
                //    string.Format("System function with name {0} already defined.", systemFunction.Name));
            }
            else
            {
                map.Add(functionName, systemFunction);
            }
        }

        public SystemFunction GetFunction(Function function)
        {
            string functionName = function.Name.ToLower();
            if (map.ContainsKey(functionName))
            {
                return map[functionName];
            }
            else
            {
                return null;
            }
        }

    }
}
