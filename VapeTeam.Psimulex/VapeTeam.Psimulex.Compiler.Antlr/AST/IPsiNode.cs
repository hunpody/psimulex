using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
{
    public interface IPsiNode
    {
        IPsiNode Parent { get; set; }
        List<IPsiNode> Children { get; set; }

        NodeType Type { get; set; }
        string Value { get; set; }
        bool IsVirtual { get; set; }

        string ViewComment { get; set; }
        

        void Accept(IPsiVisitor v);
        IPsiNode Clone();
        void Add(IPsiNode child);


        void Init();
        void Init(IPsiNode parent, string value, NodeType type);
        void Init(IPsiNode parent, string value, NodeType type, bool isVirtual, string viewComment);
    }
}
