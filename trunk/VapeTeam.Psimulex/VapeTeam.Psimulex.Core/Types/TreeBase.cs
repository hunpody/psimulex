using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class TreeBase : BaseType
    {
        public BaseType Value { get; set; }

        protected abstract IEnumerable<TreeBase> GetChildren();

        public int ChildrenCount
        {
            get
            {
                return GetChildren().Count();
            }
        }

        public bool IsLeaf
        {
            get
            {
                return ChildrenCount == 0;
            }
        }

        public int Count
        {
            get
            {
                return 1 + GetChildren().Sum(child => child.Count);
            }
        }

        public int Height
        {
            get
            {
                if (IsLeaf)
                {
                    return 0;
                }
                else
                {
                    return 1 + GetChildren().Max(child => child.Height);
                }
            }
        }
    }
}
