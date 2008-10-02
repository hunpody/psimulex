using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Because of the built/in types are identified by the TypeEnum and the user can expend the types with their own structs,
    /// it is necessary to have a general type identifier.
    /// </summary>
    public class TypeIdentifier
    {
        public TypeEnum TypeEnum { get; set; }
        public string TypeName { get; set; }

        public bool IsUserDefined
        {
            get
            {
                return TypeEnum == TypeEnum.UserDefinedType;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is TypeIdentifier)
            {
                TypeIdentifier id = (TypeIdentifier)obj;
                return id.TypeEnum == this.TypeEnum && id.TypeName == this.TypeName;
            }
            else return base.Equals(obj); 
        }
    }
}
