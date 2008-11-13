using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    /// <summary>
    /// It represents a graph node, its position and its value.
    /// </summary>
    public class GraphNode : BaseType
    {
        #region Wrapped value

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
                // Do we really care about the value if it has changed?
                // _value.Changed += new EventHandler<ValueChangedEventsArgs>(_value_Changed);
            }
        }

        private void _value_Changed(object sender, BaseType.ValueChangedEventsArgs e)
        {
        }

        #endregion

        public Point Position { get; set; }

        public GraphNode()
        {
            Position = new Point();
        }

        public override TypeIdentifier Type
        {
            get { return TypeEnum.Node; }
        }
    }
}
