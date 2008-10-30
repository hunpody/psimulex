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
            string functionId = systemFunction.Id.ToLower();
            if (map.ContainsKey(functionId))
            {
                //throw new PsimulexCoreException(
                //    string.Format("System function with name {0} already defined.", systemFunction.Name));
            }
            else
            {
                map.Add(functionId, systemFunction);
            }
        }

        public SystemFunction GetFunction(string functionId)
        {
            functionId = functionId.ToLower();
            if (map.ContainsKey(functionId))
            {
                return map[functionId];
            }
            else
            {
                return null;
            }
        }


        public SystemFunction GetFunctionByName(string name)
        {
            var item = map.FirstOrDefault(kv => kv.Value.Name.ToLower() == name.ToLower());
            //if (item == null)
            //{
            //    return null;
            //}
            //else
            //{
                return item.Value;
            //}
        }
    }
}
