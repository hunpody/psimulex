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
    }

    /// <summary>
    /// Describe a Struct data structure
    /// </summary>
    public class StructDescriptor : UserDefinedTypeDescriptor
    {
        public override BaseType CreateAnInstance()
        {
            Struct s = new Struct { Name = Name };

            foreach (var item in Attributes)
                s.AddAttribute(
                    new Attribute
                    {
                        Name = item.Descriptor.Name,
                        Descriptor = item.Descriptor.Clone(),

                        // Itt kell amdj ügyesen eljárni ha rekord elmee lehet rekord is !!!
                        Value = item.Value == null
                        ? ValueFactory.CreateValue(item.Descriptor.Type)
                        : item.Value.Clone()
                    });

            return s;
        }
    }

    /// <summary>
    /// Just for joke/thinking at this time.
    /// </summary>
    public class ClassDescriptor : UserDefinedTypeDescriptor
    {
        // FunctionList
        // Constructor
        // Destructor ? Esetleg

        public override BaseType CreateAnInstance()
        {
            throw new NotImplementedException();
        }
    }
}
