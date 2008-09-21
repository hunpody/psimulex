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

        IPsiNode Left { get; set; }
        IPsiNode Right { get; set; }
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
            StartIndex = -1;
            StopIndex = -1;
            TokenStartIndex = -1;
            TokenStopIndex = -1;
        }

        public NodeValueInfo(int charPositionInLine, int line, int startIndex, int stopIndex, int tokenStartIndex, int tokenStopIndex)
        {
            CharPositionInLine = charPositionInLine;
            Line = line;
            StartIndex = startIndex;
            StopIndex = stopIndex;
            TokenStartIndex = tokenStartIndex;
            TokenStopIndex = tokenStopIndex;
        }

        public int CharPositionInLine { get; set; }
        public int Line { get; set; }
        public int StartIndex { get; set; }
        public int StopIndex { get; set; }
        public int TokenStartIndex { get; set; }
        public int TokenStopIndex { get; set; }
    }
}
