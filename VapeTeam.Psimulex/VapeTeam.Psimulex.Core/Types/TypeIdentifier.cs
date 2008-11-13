using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// This object identifies a type. It was necessary to have an identifier that is more complicated than a simple enum
    /// because the user can define custom types and the arrays are based on having generic types for example.
    /// </summary>
    public class TypeIdentifier
    {
        public TypeEnum TypeEnum { get; set; }
        
        public string TypeName { get; set; }

        /// <summary>
        /// This is the type that this type is composed of. An int[] will have the generic type of an integer type-id.
        /// </summary>
        public TypeIdentifier GenericType { get; set; }

        public ITypeDescriptor UserDefinedType { get; set; }

        public bool IsUserDefined
        {
            get
            {
                return TypeEnum == TypeEnum.UserDefinedType;
            }
        }

        public static bool operator ==(TypeIdentifier t1, TypeIdentifier t2)
        {
            if ((object)t1 == null)
            {
                return (object)t2 == null;
            }
            else
            {
                return t1.Equals(t2);
            }
        }

        public static bool operator !=(TypeIdentifier t1, TypeIdentifier t2)
        {
            return !(t1 == t2);
        }

        public override bool Equals(object obj)
        {
            if (obj is TypeIdentifier)
            {
                TypeIdentifier id = (TypeIdentifier)obj;
                return id.TypeEnum == this.TypeEnum 
                    && (string.IsNullOrEmpty(id.TypeName) && string.IsNullOrEmpty(this.TypeName) || id.TypeName == this.TypeName)
                    && id.UserDefinedType == this.UserDefinedType;
            }
            else return base.Equals(obj); 
        }

        /// <summary>
        /// Converts implicitly from TypeEnum.
        /// </summary>
        /// <param name="typeEnum"></param>
        /// <returns></returns>
        public static implicit operator TypeIdentifier(TypeEnum typeEnum)
        {
            return new TypeIdentifier { TypeEnum = typeEnum, TypeName = typeEnum.ToString() };
        }

        // This will be added later when the StructDescriptor class gets implemented.
        //
        ///// <summary>
        ///// Converts implicitly from user-defined typedescriptor.
        ///// </summary>
        ///// <param name="descriptor"></param>
        ///// <returns></returns>
        //public static implicit operator TypeIdentifier(ITypeDescriptor descriptor)
        //{
        //    return new TypeIdentifier { TypeEnum = TypeEnum.UserDefinedType, UserDefinedType = descriptor };
        //}

        /// <summary>
        /// Converts implicitly a type identifier to TypeEnum.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static implicit operator TypeEnum(TypeIdentifier type)
        {
            return type.TypeEnum;
        }
    }
}
