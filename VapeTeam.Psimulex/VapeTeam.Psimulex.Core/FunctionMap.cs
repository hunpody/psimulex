using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The FunctionMap maps strings to basetypes in order to find functions by name. 
    /// Useful for user defined functions.
    /// </summary>
    public class FunctionMap : Dictionary<string, UserDefinedFunction>
    {
        public void Add(UserDefinedFunction func)
        {
            Add(CreateFunctionID(func.Name, func.Parameters.Count), func);
        }

        public UserDefinedFunction this[string functionName, int parameterCount]
        {
            get 
            {
                return this[CreateFunctionID(functionName,parameterCount)];
            }
        }

        private string CreateFunctionID(string functionName, int parameterCount)
        {
            return string.Format("{0}_{1}", functionName, parameterCount);
        }
    }
}
