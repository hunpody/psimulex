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
            if (map.ContainsKey(systemFunction.Name))
            {
                throw new PsimulexCoreException(
                    string.Format("System function with name {0} already defined.", systemFunction.Name));
            }

            map.Add(systemFunction.Name, systemFunction);
        }

        public SystemFunction GetFunction(Function function)
        {
            if (map.ContainsKey(function.Name))
            {
                return map[function.Name];
            }
            else
            {
                return null;
            }
        }

    }
}
