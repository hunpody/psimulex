using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphDrawerPOC
{
    public class Graph
    {
        public class Node
        {
            public object Value { get; set; }
            public System.Windows.Point Position { get; set; }
            public System.Windows.Size Size { get; set; }
        }
        public class Edge
        {
            public object Cost { get; set; }
            public Node From { get; set; }
            public Node To { get; set; }
        }

        public List<Node> Nodes { get; private set; }
        public List<Edge> Edges { get; private set; }

        public Graph()
        {
            Nodes = new List<Node>();
            Edges = new List<Edge>();
        }
    }
}
