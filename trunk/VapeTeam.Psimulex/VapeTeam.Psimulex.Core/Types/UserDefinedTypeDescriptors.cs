using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// This is Simpli a List of User Defined Types.
    /// Create one for each Program.
    /// </summary>
    public class TypeDescriptors : Dictionary<string, ITypeDescriptor>
    {
        /// <summary>
        /// Created Instance can assigned as a BaseType.
        /// </summary>
        /// <param name="typeName">The user defined type name.</param>
        /// <returns>An "instance" of an user type.</returns>
        public UserDefinedType CreatAnInstanceOf(string typeName)
        {
            if (!this.ContainsKey(typeName))
                throw new UserDefinedTypeException(string.Format("Type {0} not defined!", typeName));
            return this[typeName].CreateAnInstance() as UserDefinedType;
        }

        public void AddDescriptor(ITypeDescriptor td)
        {
            this.Add(td.Name, td);
        }
    }

    /// <summary>
    /// Describe an user defined data structure
    /// </summary>
    public class UserDefinedTypeDescriptor : ITypeDescriptor
    {
        public string Name { get; set; }
        public List<AttributeDescriptor> Attributes { get; set; }

        public UserDefinedTypeDescriptor()
        {
            Attributes = new List<AttributeDescriptor>();
        }

        public virtual BaseType CreateAnInstance()
        {
            return new Null();
        }

        public virtual ITypeDescriptor Clone()
        {
            return new UserDefinedTypeDescriptor
            {
                Attributes = new List<AttributeDescriptor>(this.Attributes),
                Name = this.Name
            };
        }

        protected Dictionary<string, Attribute> CreateAnInstanceOfAttributes()
        {
            var attributes = new Dictionary<string, Attribute>();

            foreach (var item in Attributes)
                attributes.Add(item.Descriptor.Name,
                    new Attribute
                    {
                        Name = item.Descriptor.Name,
                        Descriptor = item.Descriptor,

                        // Itt kell madj ügyesen eljárni ha rekord eleme lehet rekord is !!!
                        // Ha önmagára láncoló adatszerkezetet definiál a felhasználó, akkor ott 
                        // Végtelen körbe futhat a CreateAnInstance
                        Value = item.Value == null
                        ? ValueFactory.CreateValue(item.Descriptor.Type)
                        : item.Value.Clone()
                    });

            return attributes;
        }
    }

    /// <summary>
    /// Describe a Struct data structure
    /// </summary>
    public class StructDescriptor : UserDefinedTypeDescriptor
    {
        public override BaseType CreateAnInstance()
        {
            return new Struct
            {
                Name = Name,
                Attributes = CreateAnInstanceOfAttributes()
            };
        }
    }

    /// <summary>
    /// Just plan.
    /// </summary>
    public class ClassDescriptor : UserDefinedTypeDescriptor
    {
        public List<FunctionDescriptor> Functions { get; set; }

        protected Dictionary<string, MemberFunction> CreateAnInstanceOfMemberFunctions()
        {
            var functions = new Dictionary<string, MemberFunction>();

            foreach (var item in Functions)
                functions.Add(item.Name,
                    new MemberFunction
                    {
                        Name = item.Name,
                        ReturnTypeDescriptor = item.ReturnTypeDescriptor,
                        Code = item.Code,
                        ParameterList = item.ParameterDescriptorList
                    });

            return new Dictionary<string, MemberFunction>();
        }

        public override BaseType CreateAnInstance()
        {
            return new Class
            {
                Name = Name,
                Attributes = CreateAnInstanceOfAttributes(),
                Functions = CreateAnInstanceOfMemberFunctions()
            };
        }
    }
}
