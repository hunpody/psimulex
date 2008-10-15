using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

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
    public class PsiFunctionsVariablesNode : PsiNode
    {
        public BlockType BlockType { get; set; }
        public Interval Interval { get; set; }
        public bool IsMarked { get; set; }
        public bool[] ViewConfig { get; set; }

        public PsiFunctionsVariablesNode()
        {
            Init();
            IsMarked = true;
        }

        public TreeViewItem ToTreeView(List<KeyValuePair<PsiFunctionsVariablesNode,CheckBox>> list)
        {
            TreeViewItem twi = new TreeViewItem();
            twi.IsExpanded = true;

            CheckBox cb = new CheckBox();
            cb.IsChecked = IsMarked;
            cb.Content = ToString(ViewConfig[0], ViewConfig[1]);

            twi.Header = cb;

            if (Children != null)
                Children.ForEach(item => twi.Items.Add((item as PsiFunctionsVariablesNode).ToTreeView(list)));

            list.Add(new KeyValuePair<PsiFunctionsVariablesNode,CheckBox>(this,cb));

            return twi;
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
