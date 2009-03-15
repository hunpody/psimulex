using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public enum BlockType
    {
        CompilationUnitBlock,

        FunctionBlock,

        ForBlock,
        WhileBlock,
        DoBlock,
        ForEachBlock,
        LoopBlock,
        PDoBlock,
        PForBlock,
        PForEchBlock,
        IfBlock,
        ElseIfBlock,
        ElseBlock,

        VariableBlock
    }

    [Serializable]
    public class PsiFunctionsVariablesNode
    {
        public BlockType BlockType { get; set; }
        public Interval Interval { get; set; }

        public bool IsMarked { get; set; }
        public bool[] ViewConfig { get; set; }

        public string Value { get; set; }

        public PsiFunctionsVariablesNode Parent { get; set; }
        public List<PsiFunctionsVariablesNode> Children { get; set; }
        public int ChildrenCount { get { return Children.Count; } }

        public PsiFunctionsVariablesNode()
        {
            Children = new List<PsiFunctionsVariablesNode>();
            IsMarked = true;
        }

        public void Add(PsiFunctionsVariablesNode child)
        {
            if (!Children.Contains(child))
            {
                child.Parent = this;
                Children.Add(child);
            }
        }

        public bool StructuralEquals(PsiFunctionsVariablesNode node)
        {
            if (BlockType != node.BlockType || Value != node.Value)
                return false;
            if (ChildrenCount != node.ChildrenCount)
                return false;

            for (int i = 0; i < ChildrenCount; i++)
                if (!(Children[i] as PsiFunctionsVariablesNode).StructuralEquals(node.Children[i] as PsiFunctionsVariablesNode))
                    return false;

            return true;
        }

        public void CopyMarksFrom(PsiFunctionsVariablesNode node)
        {
            IsMarked = node.IsMarked;
            for (int i = 0; i < ChildrenCount; i++)
                (Children[i] as PsiFunctionsVariablesNode).CopyMarksFrom(node.Children[i] as PsiFunctionsVariablesNode);
        }

        public override string ToString()
        {
            return ToString(true, true);
        }

        public string ToString(bool showType, bool showValue)
        {
            string type = showType ? "( " + BlockType.ToString() + " )" : "";
            string value = showValue ? Value : "";
            return string.Format("{0} {1}", type, value);
        }
    }
}
