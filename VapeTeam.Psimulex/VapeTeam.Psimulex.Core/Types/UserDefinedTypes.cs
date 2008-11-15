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
    /// An attributo of an usertype.
    /// </summary>
    public class Attribute
    {
        public string Name { get; set; }
        public VariableDescriptor Descriptor { get; set; }
        public BaseType Value { get; set; }

        public Attribute Clone()
        {
            Attribute attr = new Attribute
            {
                Name = this.Name,
                Descriptor = this.Descriptor.Clone(),
                Value = this.Value == null ? null : this.Value.Clone()
            };

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
            if ( Name != a.Name || Descriptor.Type != a.Descriptor.Type )
                return false;
            return true;
        }

        public override string ToString()
        {
            string dimmarker = "";
            if (Descriptor.Type.Dimensions.Count > 0)
            {
                dimmarker = "[" + string.Join(",", new string[Descriptor.Type.Dimensions.Count]) + "]";
                /*dimmarker += "[";
                for (int i = 0; i < Descriptor.Type.Dimensions.Count; i++)
                    dimmarker += ",";
                dimmarker += "]";*/
            }
            return string.Format("{0} {1} {2} = {3}",
                Descriptor.Type.TypeEnum == TypeEnum.UserDefinedType
                ? Descriptor.Type.TypeName
                : Descriptor.Type.TypeEnum.ToString(),
                dimmarker, Name, 
                Value != null ? Value.ToString() : "null" );
        }
    }

    /// <summary>
    /// The base for structs and classes.
    /// </summary>
    public abstract class UserDefinedType : BaseType
    {
        public abstract Attribute this[string name] { get; set; }
        public string Name { get; set; }

        public override BaseType Clone()
        {
            return base.Clone();
        }

        public override TypeIdentifier Type
        {
            get
            {
                return new TypeIdentifier { TypeEnum = TypeEnum.UserDefinedType, TypeName = Name };
            }
        }
    }

    /// <summary>
    /// Structs have only fields no methods.
    /// </summary>
    public class Struct : UserDefinedType
    {
        public Dictionary<string,Attribute> Attributes { get; set; }

        public Struct()
        {
            Attributes = new Dictionary<string, Attribute>();
        }

        public Struct(StructDescriptor sd)
        {
            var s = sd.CreateAnInstance() as Struct;
            Attributes = s.Attributes;
            Name = s.Name;
        }

        public void AddAttribute(Attribute attr)
        {
            Attributes.Add(attr.Name, attr);
        }

        public override Attribute this[string name]
        {
            get
            {
                if (!Attributes.ContainsKey(name))
                    throw new UserDefinedTypeException(string.Format("Type {0} has no attribute named: {1} !", Name, name));
                return Attributes[name];
            }
            set
            {
                if (!Attributes.ContainsKey(name))
                    throw new UserDefinedTypeException(string.Format("Type {0} has no attribute named: {1} !", Name, name));
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
            return string.Format("{{0}}",
                string.Join(", ", Attributes.Values.Select(value => value.ToString()).ToArray()));
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
            if (value.GetType() == typeof(Struct) && StructuralEquals(value as Struct))
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

        public override bool EqualsTo(BaseType value)
        {
            if (value == null)
                return false;

            if (value.GetType() != typeof(Struct))
                return false;

            if (!StructuralEquals(value as Struct))
                return false;

            foreach (var item in (value as Struct).Attributes)
                if (!item.Value.Value.EqualsTo(Attributes[item.Key].Value))
                    return false;

            return true;
        }
    }

    #region Class Section

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

    #endregion
}
