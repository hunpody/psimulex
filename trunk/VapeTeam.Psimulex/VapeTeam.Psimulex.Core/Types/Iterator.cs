using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// An object of this type is able to iteratore over any enumerable collection.
    /// </summary>
    public class Iterator : BaseType
    {
        private System.Collections.Generic.IEnumerator<BaseType> enumerator;

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Iterator; }
        }

        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }

        public BaseType Current()
        {
            return enumerator.Current;
        }

        public Iterator(System.Collections.Generic.IEnumerable<BaseType> enumerable)
        {
            this.enumerator = enumerable.GetEnumerator();
        }
    }
}
