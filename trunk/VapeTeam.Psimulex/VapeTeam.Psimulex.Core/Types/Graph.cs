using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Types
{
    public class Graph : BaseType
    {
        public override TypeEnum TypeEnum
        {
            get { return TypeEnum.Graph; }
        }

        private bool isDirected;

        public bool IsDirected
        {
            get 
            { 
                return isDirected; 
            }
            set
            {
                isDirected = value;
            }
        }

        protected List<GraphEdge> _edges = new List<GraphEdge>();
        protected List<GraphNode> _nodes = new List<GraphNode>();
    }
}
