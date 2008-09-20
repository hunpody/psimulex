using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// This value wraps a .NET property. It is not part of the type system because it is only useful for selecting a built-in type's property.
    /// </summary>
    public class PropertyWrapper : BaseType
    {
        private object targetObject;
        private System.Reflection.PropertyInfo propertyInfo;

        private BaseType correspondingPsimulexValue;

        public PropertyWrapper(object targetObject, System.Reflection.PropertyInfo propertyInfo)
        {
            this.targetObject = targetObject;
            this.propertyInfo = propertyInfo;
            this.correspondingPsimulexValue = ValueFactory.Create(GetValueObject());
        }

        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.PropertyWrapper; }
        }

        protected object GetValueObject()
        {
            object value = null;
            try
            {
                value = propertyInfo.GetValue(targetObject, null);
            }
            catch (Exception ex)
            {
                throw new Exceptions.PsimulexCoreException(
                    string.Format("Couldn't access property {1} of {0}.", targetObject.GetType().Name, propertyInfo.Name),
                    ex);
            }
            return value;
        }

        public override object ToObject()
        {
            return correspondingPsimulexValue.ToObject();
        }
    }
}
