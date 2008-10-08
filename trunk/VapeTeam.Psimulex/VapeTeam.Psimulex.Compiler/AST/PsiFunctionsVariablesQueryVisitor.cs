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

        public TreeViewItem ToTreeView()
        {
            TreeViewItem twi = new TreeViewItem();
            twi.IsExpanded = true;

            CheckBox cb = new CheckBox();
            cb.IsChecked = IsMarked;
            cb.Content = ToString(ViewConfig[0], ViewConfig[1]);

            twi.Header = cb;

            if (Children != null)
                Children.ForEach(item => twi.Items.Add((item as PsiFunctionsVariablesNode).ToTreeView()));

            return twi;
        }

        public string ToString(bool showType, bool showValue)
        {
            string type = showType ? "( " + BlockType.ToString() + " )" : "";
            string value = showValue ? Value : "";
            return string.Format("{0} {1}", type, value);
        }
    }

    public class PsiFunctionsVariablesQueryVisitor : IPsiVisitor
    {
        public List<PsiFunctionsVariablesNode> PsiNodeList { get; set; }
        public string Source { get; set; }
        public string FileName { get; set; }

        public PsiFunctionsVariablesQueryVisitor(string source, string fileName)
        {
            PsiNodeList = new List<PsiFunctionsVariablesNode>();
            Source = source;
            FileName = fileName;

            InitHelperVariables();
            FindLineLengths();
        }

        #region Helper Functions Variables

        private void AddNewNodeToList(string value, BlockType type, Interval interval)
        {
            AddNewNodeToList(value, type, interval, new bool[2] { true, true });
        }

        private void AddNewNodeToList(string value, BlockType type, Interval interval, bool[] viewConfig)
        {
            var node = new PsiFunctionsVariablesNode();
            node.Value = value;
            node.Interval = interval;
            node.BlockType = type;
            node.ViewConfig = viewConfig;

            lastCreatedNodeList.ForEach(item => node.Children.Add(item));
            node.Children.ForEach(child => child.Parent = node);
            lastCreatedNodeList.Clear();
            lastCreatedNodeList.Add(node);
        }

        private void CreateNewNodeFromListAndPushBack()
        { }

        private void CreateNewNodeAndPush()
        { }

        private Interval CreateInterval(IPsiNode node)
        {
                Interval range = new Interval
                {
                    FromLine = node.NodeValueInfo.StartLine,
                    FromColumn = node.NodeValueInfo.StartColumn,
                    ToLine = node.NodeValueInfo.EndLine,
                    ToColumn = node.NodeValueInfo.EndColumn
                };

                range.StartIndex = 0;
                for (int i = 1; i < node.NodeValueInfo.StartLine; i++)
                    range.StartIndex += lineLengthList[i];

                range.StartIndex += node.NodeValueInfo.StartColumn;

                range.EndIndex = 0;
                for (int i = 1; i < node.NodeValueInfo.EndLine; i++)
                    range.EndIndex += lineLengthList[i];

                range.EndIndex += node.NodeValueInfo.EndColumn;

                // Is it a Leaf Virtual Node or not
                if (range.StartIndex != -1 && range.EndIndex != -1)
                    CorrectSelectionIntervalWithFindingClosingChar(range);

                return range;
        }

        private List<PsiFunctionsVariablesNode> lastCreatedNodeList;

        // ToDo
        private List<List<PsiFunctionsVariablesNode>> lastCreatedNodeListList;

        private void InitHelperVariables()
        {
            lastCreatedNodeList = new List<PsiFunctionsVariablesNode>();
        }


        // Ideiglenes Kopi Paszta valamin tökölök

        private List<int> lineLengthList;
        private void FindLineLengths()
        {
            lineLengthList = new List<int>();
            lineLengthList.Add(0);

            int len = 0;
            for (int i = 0; i < Source.Length; ++i)
            {
                if (Source[i] == '\n')
                {
                    lineLengthList.Add(len + 1);
                    len = -1;
                }
                len++;
            }
        }        

        private void CorrectSelectionIntervalWithFindingClosingChar(Interval interval)
        {
            int start = interval.StartIndex;
            int end = interval.EndIndex;

            // Just For Try
            end += FindCharPositionExpceptedChars(end, '(', ";)tTiI");


            int parenthesises = 0;		// ()
            int brackets = 0;			// []

            int i = start;
            while ((i < Source.Length) && (i < end || parenthesises > 0 || brackets > 0))
            {
                switch (Source[i])
                {
                    case '(':
                        ++parenthesises;
                        break;
                    case ')':
                        if (parenthesises > 0)
                            --parenthesises;
                        break;
                    case '[':
                        ++brackets;
                        break;
                    case ']':
                        if (brackets > 0)
                            --brackets;
                        break;
                }
                ++i;
            }

           //while (i < Source.Length && Source[i].ToString().ToLower() != closingChar.ToString().ToLower())
           //    ++i;

            interval.EndIndex = i;
        }

        private int FindCharPositionExpceptedChars(int from, char findChar, string excepts)
        {
            int ind = 0;
            while (from + ind < Source.Length)
            {
                if (excepts.Contains(Source[from + ind].ToString()))
                    return 0;

                char ch = Source[from + ind];
                if (ch == findChar)
                    return ind + 1;

                ind++;
            }
            return 0;
        }

        #endregion

        #region Additional Functions

        /*Children Visiting*/
        public void VisitChildren(IPsiNode node)
        {
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
        }

        #endregion

        #region Typed Node Visit() -s

        /*Common Tree Node*/
        public void Visit(PsiNode node) { VisitChildren(node); }

        /*Undefined Tree Node*/
        public void Visit(XNode node) { VisitChildren(node); }

        /*High Level Tree Nodes*/
        public void Visit(CompilationUnitNode node)
        {
            VisitChildren(node);

            AddNewNodeToList(FileName, BlockType.CompilationUnitBlock, CreateInterval(node));
            
            PsiNodeList.AddRange(lastCreatedNodeList);
            lastCreatedNodeList.Clear();
        }

        public void Visit(SimpleProgramNode node) { VisitChildren(node); }
        public void Visit(MultiFuncionalProgramNode node) { VisitChildren(node); }
        public void Visit(ImportDeclarationNode node) { VisitChildren(node); }
        public void Visit(TypeDeclarationNode node) { VisitChildren(node); }
        public void Visit(StructDeclarationNode node) { VisitChildren(node); }
        public void Visit(MemberDeclarationNode node) { VisitChildren(node); }
        public void Visit(GlobalVariableDeclarationsNode node) { VisitChildren(node); /*If We Need it*/}
        public void Visit(FunctionDeclarationsNode node) { VisitChildren(node); }
        public void Visit(FunctionDeclarationNode node)
        {
            VisitChildren(node);

            AddNewNodeToList(
                node.FunctionName.Value + " ParameterCount: " + node.FunctionParameterList.Children.Count(),
                BlockType.FunctionBlock, CreateInterval(node));
        }

        public void Visit(FormalParameterListNode node) { VisitChildren(node); }
        public void Visit(FormalParameterNode node) { VisitChildren(node); }

        /*Program Structures*/
        public void Visit(BlockNode node) { VisitChildren(node); }
        public void Visit(StatementNode node) { VisitChildren(node); }
        public void Visit(IfStatementNode node) { VisitChildren(node); }
        public void Visit(IfBranchNode node) 
        {
            VisitChildren(node);
            AddNewNodeToList("If", BlockType.IfBlock, CreateInterval(node), new bool[2] { true, false });
        }

        public void Visit(ElseIfBranchNode node) 
        {
            VisitChildren(node);
            AddNewNodeToList("ElseIf", BlockType.ElseIfBlock, CreateInterval(node), new bool[2] { true, false });
        }

        public void Visit(ConditionalBranchNode node) { VisitChildren(node); }
        public void Visit(ElseBranchNode node) 
        { 
            VisitChildren(node);
            AddNewNodeToList("Else", BlockType.IfBlock, CreateInterval(node), new bool[2] { true, false });
        }

        public void Visit(PForStatementNode node) { VisitChildren(node); }
        public void Visit(ForStatementNode node) { VisitChildren(node); }
        public void Visit(ForInitializationNode node) { VisitChildren(node); }
        public void Visit(ForConditionNode node) { VisitChildren(node); }
        public void Visit(ForUpdateNode node) { VisitChildren(node); }
        public void Visit(DoStatementNode node) { VisitChildren(node); }
        public void Visit(WhileStatementNode node) { VisitChildren(node); }
        public void Visit(PForEachStatementNode node) { VisitChildren(node); }
        public void Visit(ForEachStatementNode node) { VisitChildren(node); }
        public void Visit(ForEachInitializationNode node) { VisitChildren(node); }
        public void Visit(ForEachCollectionExpressionNode node) { VisitChildren(node); }
        public void Visit(LoopStatementNode node) { VisitChildren(node); }
        public void Visit(LoopInitializationNode node) { VisitChildren(node); }
        public void Visit(LoopLimitNode node) { VisitChildren(node); }
        public void Visit(ConditionNode node) { VisitChildren(node); }
        public void Visit(CoreNode node) { VisitChildren(node); }
        public void Visit(PDoStatementNode node) { VisitChildren(node); }
        public void Visit(AsynStatementNode node) { VisitChildren(node); }
        public void Visit(LockStatementNode node) { VisitChildren(node); }
        public void Visit(ReturnStatementNode node) { VisitChildren(node); }
        public void Visit(ReturnNode node) { VisitChildren(node); }
        public void Visit(BreakNode node) { VisitChildren(node); }
        //public void Visit(ContinueNode node) { VisitChildren(node); }
        public void Visit(ExpressionStatementNode node) { VisitChildren(node); }
        public void Visit(VariableDeclarationStatementNode node) { VisitChildren(node); }
        public void Visit(VariableInitializationNode node)
        {
            VisitChildren(node);
            AddNewNodeToList(node.VariableName.Value, BlockType.VariableBlock, CreateInterval(node));
        }
        public void Visit(VariableDeclarationNode node)
        {
            VisitChildren(node);
            AddNewNodeToList(node.VariableName.Value, BlockType.VariableBlock, CreateInterval(node));
        }

        /*Operators*/
        public void Visit(AssignmentOpNode node) { VisitChildren(node); }
        public void Visit(LogicalOrOpNode node) { VisitChildren(node); }
        public void Visit(LogicalAndOpNode node) { VisitChildren(node); }
        public void Visit(EqualityOpNode node) { VisitChildren(node); }
        public void Visit(RelationOpNode node) { VisitChildren(node); }
        public void Visit(AdditiveOpNode node) { VisitChildren(node); }
        public void Visit(MultiplicativeOpNode node) { VisitChildren(node); }
        public void Visit(UnaryOpNode node) { VisitChildren(node); }

        /*Expressions*/
        public void Visit(ExpressionNode node) { VisitChildren(node); }
        public void Visit(CastNode node) { VisitChildren(node); }
        public void Visit(PrefixUnaryOperationNode node) { VisitChildren(node); }
        /*
        public void Visit(LambdaExpressionNode node) { VisitChildren(node); }
        public void Visit(LambdaParameterNode node) { VisitChildren(node); }
        public void Visit(LambdaStatementNode node) { VisitChildren(node); }
        */

        public void Visit(SelectorNode node) { VisitChildren(node); }
        public void Visit(MemberSelectNode node) { VisitChildren(node); }
        public void Visit(MemberFunctionCallNode node) { VisitChildren(node); }
        public void Visit(FunctionCallNode node) { VisitChildren(node); }
        public void Visit(ArgumentsNode node) { VisitChildren(node); }
        public void Visit(IndexingNode node) { VisitChildren(node); }
        public void Visit(DimensionsNode node) { VisitChildren(node); }
        public void Visit(ConstantDimensionsNode node) { VisitChildren(node); }
        public void Visit(DimensionMarkerNode node) { VisitChildren(node); }

        /*ID*/
        public void Visit(IdentifierNode node) { VisitChildren(node); }

        /*Literals*/
        public void Visit(CharLiteralNode node) { VisitChildren(node); }
        public void Visit(StringLiteralNode node) { VisitChildren(node); }
        public void Visit(IntLiteralNode node) { VisitChildren(node); }
        public void Visit(DecimalLiteralNode node) { VisitChildren(node); }
        public void Visit(BoolLiteralNode node) { VisitChildren(node); }
        public void Visit(NullLiteralNode node) { VisitChildren(node); }
        public void Visit(InfinityLiteralNode node) { VisitChildren(node); }

        /*Types*/
        public void Visit(DataTypeNameNode node) { VisitChildren(node); }
        public void Visit(DataTypeNode node) { VisitChildren(node); }
        /*
        public void Visit(FunctionPointerTypeNode node) { VisitChildren(node); }
        */
        public void Visit(TypeNode node) { VisitChildren(node); }
        public void Visit(ReferenceNode node) { VisitChildren(node); }

        #endregion
    }
}
