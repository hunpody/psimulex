using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// A function-base object that can wrap user-defined or library-provided system function.
    /// </summary>
    public class Function
    {
        public string Name { get; set; }

        public List<VariableDescriptor> Parameters { get; set; }

        public VariableDescriptor ReturnValueType { get; set; }

        public virtual bool IsUserDefined
        {
            get
            {
                return false;
            }
        }

        public int ParameterCount
        {
            get
            {
                return Parameters.Count;
            }
        }

        public bool HasReturnValue
        {
            get
            {
                return ReturnValueType != null && ReturnValueType.Type.TypeEnum != TypeEnum.Undefined;
            }
        }

        public string Id
        {
            get
            {
                return CreateId(Name, ParameterCount);
            }
        }

        public static string CreateId(string name, int parameterCount)
        {
            return string.Format("{0}_{1}", name, parameterCount.ToString()).ToLower();
        }

        public Function()
        {
            Parameters = new List<VariableDescriptor>();
        }
    }
}
