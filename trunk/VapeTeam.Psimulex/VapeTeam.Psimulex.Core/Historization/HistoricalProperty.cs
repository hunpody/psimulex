using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Historization
{
    /// <summary>
    /// A historical property wraps a general property and records its changes.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HistoricalProperty<T> 
    {
        private class HistoricalPropertyChange : IHistoricalOperation
        {
            public HistoricalProperty<T> Property { get; set; }
            public T ValueBefore { get; set; }
            public T Value { get; set; }

            #region IHistoricalOperation Members

            public void Redo()
            {
                Property.UnhistorizedSetValue(Value);
            }

            public void Undo()
            {
                Property.UnhistorizedSetValue(ValueBefore);
            }


            public override string ToString()
            {
                return string.Format("Property change: {0} -> {1}", ValueBefore, Value);
            }

            #endregion
        }

        private IHistory history;

        private object hostObject;
        private System.Reflection.PropertyInfo propertyInfo;

        public HistoricalProperty(IHistory history, object hostObject, string propertyName)
        {
            this.history = history;
            this.hostObject = hostObject;
            try
            {
                propertyInfo = hostObject.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
            }
            catch (Exception ex)
            {
                throw new Exceptions.PsimulexCoreException(string.Format("Error creating HistoricalProperty for object {0} and property name \"{1}\".",
                    hostObject, propertyName), ex);
            }
        }

        private void UnhistorizedSetValue(T value)
        {
            propertyInfo.SetValue(hostObject, value, null);
        }

        public T Value
        {
            get
            {
                return (T) propertyInfo.GetValue(hostObject, null);
            }
            set
            {
                history.Record(new HistoricalPropertyChange { Property = this, Value = value, ValueBefore = Value });
                UnhistorizedSetValue(value);
            }
        }


        public static implicit operator T(HistoricalProperty<T> hp)
        {
            return hp.Value;
        }
    }
}
