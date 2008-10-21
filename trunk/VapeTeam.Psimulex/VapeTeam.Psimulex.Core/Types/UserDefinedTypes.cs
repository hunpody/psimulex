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
    public class UserDefinedTypes : Dictionary<string,UserDefinedType>
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
            return this[typeName].Clone() as UserDefinedType;
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
        public List<int> DimensionList { get; set; }
        public BaseType Value { get; set; }

        public Attribute Clone()
        {
            Attribute attr = new Attribute
            {
                Name = this.Name,
                Type = this.Type,
                TypeName = this.TypeName,
                DimensionList = new List<int>(),
                Value = this.Value.Clone()
            };

            DimensionList.ForEach(x => attr.DimensionList.Add(x));

            return attr;
        }

        /// <summary>
        /// Two Attribute is StructuralEquivalent if they
        /// have a same type, name and dimension.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool StructuralEquals(Attribute a)
        {
            if (Name != a.Name || TypeName != a.TypeName || Type != a.Type || DimensionList.Count != a.DimensionList.Count)
                return false;
            
            for (int i = 0; i < DimensionList.Count; i++)
                if (DimensionList[i] != a.DimensionList[i])
                    return false;

            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} [Dim:{1}] {2} = {3}", 
                TypeName, DimensionList.Count, Name, 
                Value != null ? Value.ToString() : "null" );
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
            get { return TypeEnum.UserDefinedType; }
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

        public override string ToString()
        {
            string ret = Name + " { ";
            foreach (Attribute attr in Attributes.Values)
                ret += attr.ToString() + ", ";
            return ret + " }";
        }

        public bool StructuralEquals(Struct s)
        {
            foreach (var attr in Attributes.Values)
            {
                bool l = false;
                foreach (var item in s.Attributes.Values)
                    if (item.StructuralEquals(attr))
                        l = true;

                if (!l)
                    return false;
            }

            return true;
        }

        public override void Assign(BaseType value)
        {
            if (value.GetType() != typeof(Struct) && StructuralEquals(value as Struct))
            {
                foreach (var item in (value as Struct).Attributes.Values)
                    this[item.Name] = item.Clone();
            }
            else
            {
                throw new UserDefinedTypeException(
                    string.Format("Struct {0} is structural unequivalent with struct {1} !", 
                    Name, (value as Struct).Name));
            }
        }
    }

    /// <summary>
    /// Just for joke/thinking at this time.
    /// </summary>
    public class Class : UserDefinedType
    {     
        public class ClassFunction
        {
            public class FunctionParameter
            {
                public string Name { get; set; }
                public TypeEnum Type { get; set; }
                public string TypeName { get; set; }
                public bool IsReference { get; set; }
            }

            public string Name { get; set; }
            
            public List<FunctionParameter> ParameterList { get; set; }
            public TypeEnum ReturnType { get; set; }
            public string ReturnTypeName { get; set; }
            public bool ReturnTypeIsReference { get; set; }

            public CommandList Code { get; set; }
        }

        public string ParentClassName { get; set; }
        public Dictionary<string, Attribute> Attributes { get; set; }
        public Dictionary<string, ClassFunction> Functions { get; set; }

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
