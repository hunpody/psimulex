using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// Half-road between the array and the linked list.
    /// </summary>
    public class List : AbstractList
    {
        #region Constructors

        public List()
        {
        }

        public List(BaseType value)
            : base(value)
        {
        }

        public List(IEnumerable<BaseType> rep)
            : base(rep)
        {
        }

        #endregion

        public override TypeEnum TypeEnum
        {
            get
            {
                return TypeEnum.List;
            }
        }
    }
}
