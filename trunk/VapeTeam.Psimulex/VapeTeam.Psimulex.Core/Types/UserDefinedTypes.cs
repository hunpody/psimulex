using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Core.Types
{
    public class UserDefinedTypeException : Exception
    {
        public UserDefinedTypeException(string message)
            : base(message)
        {
        }

        public UserDefinedTypeException()
            : this("UserDefinedTypeException")
        {
        }
    }

    /// <summary>
    /// This is Simpli a List of User Defined Types.
    /// Create one for each Program.
    /// </summary>
    public class UserDefinedTypes
    {
        Dictionary<string,UserDefinedType> UserDefinedTypeDictionary { get; set; }

        public UserDefinedTypes()
        {
            UserDefinedTypeDictionary = new Dictionary<string, UserDefinedType>();
        }

        /// <summary>
        /// Created Instance can assigned as a BaseType.
        /// </summary>
        /// <param name="typeName">The user defined type name.</param>
        /// <returns>An "instance" of an user type.</returns>
        public UserDefinedType CreatAnInstanceOf(string typeName)
        {
            if (!UserDefinedTypeDictionary.ContainsKey(typeName))
                throw new UserDefinedTypeException(string.Format("Type {0} not defined!", typeName));
            return UserDefinedTypeDictionary[typeName].Clone() as UserDefinedType;
        }
    }

    /// <summary>
    /// An attributo of an usertype.
    /// </summary>
    public class Attribute
    {
        public string Name { get; set; }
            public TypeEnum Type { get; set; }
            public string TypeName { get; set; }
            public BaseType Value { get; set; }

            public Attribute Clone()
            {
                return new Attribute
                {
                    Name = this.Name,
                    Type = this.Type,
                    TypeName = this.TypeName,
                    Value = this.Value.Clone()
                };
            }
    }

    /// <summary>
    /// Types what can define the user.
    /// </summary>
    public abstract class UserDefinedType : BaseType
    {        
        public abstract Attribute this[string name] { get; set; }
        public string Name { get; set; }

        public override BaseType Clone()
        {
            return base.Clone();
        }

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Undefined; }
        }
    }

    /// <summary>
    /// DataStructure what have attributes.
    /// </summary>
    public class Struct : UserDefinedType
    {
        public Dictionary<string,Attribute> Attributes { get; set; }

        public override Attribute this[string name]
        {
            get
            {
                if (!Attributes.ContainsKey(name))
                    throw new UserDefinedTypeException(string.Format("Type {0} has no attribute named : {1} !", Name, name));
                return Attributes[name];
            }
            set
            {
                if (!Attributes.ContainsKey(name))
                    throw new UserDefinedTypeException(string.Format("Type {0} has no attribute named : {1} !", Name, name));
                Attributes[name] = value;
            }
        }

        public override BaseType Clone()
        {
            return new Struct
            {
                Attributes = CloneAttributes(),
                Name = this.Name,
                isConversionToScalarBasedOnToInt = this.isConversionToScalarBasedOnToInt
            };
        }

        private Dictionary<string, Attribute> CloneAttributes()
        {
            Dictionary<string, Attribute> dic = new Dictionary<string, Attribute>();
            foreach (Attribute attr in Attributes.Values)
                dic.Add(attr.Name, attr.Clone());
            return dic;
        }
    }




    /// <summary>
    /// Just for joke/thinking at this time.
    /// </summary>
    public class Class : UserDefinedType
    {     
        public class Function
        {
            public class Parameter
            {
                public string Name { get; set; }
                public TypeEnum Type { get; set; }
                public string TypeName { get; set; }
                public bool IsReference { get; set; }
            }

            public string Name { get; set; }
            
            public List<Parameter> ParameterList { get; set; }
            public TypeEnum ReturnType { get; set; }
            public string ReturnTypeName { get; set; }
            public bool ReturnTypeIsReference { get; set; }

            public CommandList Code { get; set; }
        }

        public string ParentClassName { get; set; }
        public Dictionary<string, Attribute> Attributes { get; set; }
        public Dictionary<string, Function> Functions { get; set; }

        public override Attribute this[string name]
        {
            get
            {
                if (!Attributes.ContainsKey(name))
                    throw new UserDefinedTypeException(string.Format("Type {0} has no attribute named : {1} !", Name, name));
                return Attributes[name];
            }
            set
            {
                if (!Attributes.ContainsKey(name))
                    throw new UserDefinedTypeException(string.Format("Type {0} has no attribute named : {1} !", Name, name));
                Attributes[name] = value;
            }
        }

        public override BaseType Clone()
        {
            return base.Clone();
        }
    }
}
