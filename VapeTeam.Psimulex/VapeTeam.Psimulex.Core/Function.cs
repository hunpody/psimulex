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

        public VariableDescriptor ReturnValue { get; set; }

        public virtual bool IsUserDefined
        {
            get
            {
                return false;
            }
        }

        public int ParametersCount
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
                return ReturnValue != null && ReturnValue.Type.TypeEnum != TypeEnum.Undefined;
            }
        }

        public Function()
        {
            Parameters = new List<VariableDescriptor>();
        }
    }
}
