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
    public class HistoricalValue<T>
    {
        private class HistoricalValueChange : IHistoricalOperation
        {
            public HistoricalValue<T> HistValue { get; set; }
            public T ValueBefore { get; set; }
            public T Value { get; set; }

            #region IHistoricalOperation Members

            public void Redo()
            {
                HistValue.value = Value;
            }

            public void Undo()
            {
                HistValue.value = ValueBefore;
            }

            #endregion

            public override string ToString()
            {
                return string.Format("Value change: {0} -> {1}", ValueBefore, Value);
            }
        }

        private IHistory history;

        private T value;

        public HistoricalValue(IHistory history)
        {
            this.history = history;
        }

        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                history.Record(new HistoricalValueChange { HistValue = this, Value = value, ValueBefore = this.value });
                this.value = value;
            }
        }


        public static implicit operator T(HistoricalValue<T> hv)
        {
            return hv.Value;
        }
    }
}
