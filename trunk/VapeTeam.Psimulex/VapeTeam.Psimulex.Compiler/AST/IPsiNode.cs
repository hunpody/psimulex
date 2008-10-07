using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public interface IPsiNode
    {
        IPsiNode Parent { get; set; }
        List<IPsiNode> Children { get; set; }
        List<IPsiNode> Siblings { get; }

        NodeType Type { get; set; }
        string Value { get; set; }
        bool IsVirtual { get; set; }

        string ViewComment { get; set; }

        NodeValueInfo NodeValueInfo { get; set; }

        void Init();
        void Init(IPsiNode parent, string value, NodeType type, NodeValueInfo nodeValueInfo);
        void Init(IPsiNode parent, string value, NodeType type, bool isVirtual, string viewComment, NodeValueInfo nodeValueInfo);
        void Init(IPsiNode parent, List<IPsiNode> children, string value, NodeType type, bool isVirtual, string viewComment, NodeValueInfo nodeValueInfo);
        
        void Accept(IPsiVisitor v);
        IPsiNode Clone();
        void Add(IPsiNode child);
        IPsiNode GetChild(int i);

        IPsiNode Left { get; }
        IPsiNode Right { get; }

        IPsiNode BottomLeft { get; }
        IPsiNode BottomRight { get; }

        string ToString(bool showType, bool showValue, bool showInterval);
    }

    /// <summary>
    /// Informations about the token text localisation in the source code.
    /// </summary>
    public class NodeValueInfo
    {
        public NodeValueInfo()
        {
            CharPositionInLine = -1;
            Line = -1;

            StartLine = -1;
            StartColumn = -1;

            EndLine = -1;
            EndColumn = -1;
        }

        public NodeValueInfo(int charPositionInLine, int line)
        {
            CharPositionInLine = charPositionInLine;
            Line = line;
        }

        public int CharPositionInLine { get; set; }
        public int Line { get; set; }

        public int StartColumn { get; set; }
        public int StartLine { get; set; }

        public int EndColumn { get; set; }
        public int EndLine { get; set; }
    }
}
