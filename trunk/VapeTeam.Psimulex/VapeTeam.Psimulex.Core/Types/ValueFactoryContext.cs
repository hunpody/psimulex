using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// It remembers what has been created and eases the process to clean up temporary values.
    /// Not a good name!
    /// </summary>
    internal class ValueFactoryContext : IDisposable
    {
        public List<BaseType> CreatedValues { get; private set; }

        public ValueFactoryContext()
        {
            CreatedValues = new List<BaseType>();
        }

        public BaseType Create(object value)
        {
            var bt = ValueFactory.Create(value);
            CreatedValues.Add(bt);
            return bt;
        }

        public void DeleteValues()
        {
            foreach (var value in CreatedValues)
            {
                value.Delete();
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            DeleteValues();
        }

        #endregion
    }
}
