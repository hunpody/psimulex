using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public abstract class TreeBase : BaseType
    {
        public event EventHandler ValueInitialized;

        protected void OnValueInitialized()
        {
            if (ValueInitialized != null)
                ValueInitialized(this, EventArgs.Empty);
        }

        private BaseType _value;
        public BaseType Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value != null)
                {
                    _value.Changed -= _value_Changed;
                }                
                _value = value;
                if (_value != null)
                {
                    _value.Changed += _value_Changed;
                    OnValueInitialized();
                }
            }
        }

        void _value_Changed(object sender, BaseType.ValueChangedEventArgs e)
        {
            OnChanged();
        }

        protected abstract IEnumerable<TreeBase> GetChildren();

        public IEnumerable<TreeBase> GetChildrenAsTreeBase() 
        {
            return GetChildren();
        }

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
