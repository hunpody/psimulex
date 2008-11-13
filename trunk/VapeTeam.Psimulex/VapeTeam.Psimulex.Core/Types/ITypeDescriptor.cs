using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// General interface for defining types.
    /// </summary>
    public interface ITypeDescriptor
    {
        string Name { get; set; }
        BaseType CreateAnInstance();
        ITypeDescriptor Clone();
    }

    /// <summary>
    /// Describe an attribute of a type.
    /// </summary>
    public class AttributeDescriptor
    {
        public VariableDescriptor Descriptor { get; set; }
        public BaseType Value { get; set; }

        public AttributeDescriptor Clone()
        {
            return new AttributeDescriptor
            {
                Value = this.Value.Clone(),
                Descriptor = this.Descriptor.Clone()
            };
        }
    }
}
