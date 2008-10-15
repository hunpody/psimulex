using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace VapeTeam.Psimulex.Compiler.AST
{  
    public class PsiFunctionsVariablesQueryVisitor : IPsiVisitor
    {
        public List<PsiFunctionsVariablesNode> PsiNodeList { get; set; }
        public string Source { get; set; }
        public string FileName { get; set; }

        private List<int> lineLengthList;

        public PsiFunctionsVariablesQueryVisitor(string source, string fileName)
        {
            PsiNodeList = new List<PsiFunctionsVariablesNode>();
            Source = source;
            FileName = fileName;

            InitHelperVariables();
            lineLengthList = SourceInfoUtils.FindLineLengths(Source);
        }

        #region Helper Functions Variables

        private void PushVisitCreate(string value, BlockType type, IPsiNode node, bool[] viewConfig)
        {
            PushNewList();
            VisitChildren(node);
            CreateNewNode(value, type, SourceInfoUtils.CreateInterval(node, Source, lineLengthList, FileName), viewConfig,true);
        }

        private void PushVisitCreate(string value, BlockType type, IPsiNode node)
        {
            PushVisitCreate(value, type, node, new bool[2] { true, true });
        }

        private void CreateNewNode(string value, BlockType type, Interval interval)
        {
            CreateNewNode(value, type, interval, new bool[2] { true, true });
        }

        private void CreateNewNode(string value, BlockType type, Interval interval, bool[] viewConfig)
        {
            CreateNewNode(value, type, interval, new bool[2] { true, true }, false); 
        }

        private void CreateNewNode(string value, BlockType type, Interval interval, bool[] viewConfig, bool pop)
        {
            var node = new PsiFunctionsVariablesNode();
            node.Value = value;
            node.Interval = interval;
            node.BlockType = type;
            node.ViewConfig = viewConfig;
            
            if(pop) lastCreatedNodeListStack.Pop().ForEach(item => node.Add(item));

            lastCreatedNodeListStack.Peek().Add(node);
        }

        private void PushNewList()
        {
            lastCreatedNodeListStack.Push(new List<PsiFunctionsVariablesNode>());
        }
       
        private Stack<List<PsiFunctionsVariablesNode>> lastCreatedNodeListStack;

        private void InitHelperVariables()
        {
            lastCreatedNodeListStack = new Stack<List<PsiFunctionsVariablesNode>>();
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
            PushNewList();

            PushVisitCreate(FileName, BlockType.CompilationUnitBlock, node);

            PsiNodeList.AddRange(lastCreatedNodeListStack.Pop());
        }

        public void Visit(SimpleProgramNode node) { VisitChildren(node); }
        public void Visit(MultiFuncionalProgramNode node) { VisitChildren(node); }
        public void Visit(ImportDeclarationNode node)
        {
            // Here will be Query the Variable and Function names in the imported files
            // Start for each Fiel a new visitor
            VisitChildren(node); 
        }

        public void Visit(TypeDeclarationNode node) { VisitChildren(node); }
        public void Visit(StructDeclarationNode node) { VisitChildren(node); }
        public void Visit(MemberDeclarationNode node) { VisitChildren(node); }
        public void Visit(GlobalVariableDeclarationsNode node) { VisitChildren(node); /*If We Need it*/}
        public void Visit(FunctionDeclarationsNode node) { VisitChildren(node); }
        public void Visit(FunctionDeclarationNode node)
        {
            PushVisitCreate(
                node.FunctionName.Value + " ParameterCount: " + node.FunctionParameterList.Children.Count(),
                BlockType.FunctionBlock, node);
        }

        public void Visit(FormalParameterListNode node) { VisitChildren(node); }
        public void Visit(FormalParameterNode node)
        {
            PushVisitCreate(
                node.ParameterName.Value,
                BlockType.VariableBlock, node);
        }

        /*Program Structures*/
        public void Visit(BlockNode node) { VisitChildren(node); }
        public void Visit(StatementNode node) { VisitChildren(node); }
        public void Visit(IfStatementNode node) { VisitChildren(node); }
        public void Visit(IfBranchNode node) 
        {
            PushVisitCreate("If", BlockType.IfBlock, node, new bool[2] { true, false });
        }

        public void Visit(ElseIfBranchNode node) 
        {
            PushVisitCreate("ElseIf", BlockType.ElseIfBlock, node, new bool[2] { true, false });
        }

        public void Visit(ConditionalBranchNode node) { VisitChildren(node); }
        public void Visit(ElseBranchNode node) 
        {
            PushVisitCreate("Else", BlockType.ElseBlock, node, new bool[2] { true, false });
        }

        public void Visit(PForStatementNode node) { VisitChildren(node); }
        public void Visit(ForStatementNode node)
        {
            PushVisitCreate("For", BlockType.ForBlock, node, new bool[2] { true, false });
        }

        public void Visit(ForInitializationNode node) { VisitChildren(node); }
        public void Visit(ForConditionNode node) { VisitChildren(node); }
        public void Visit(ForUpdateNode node) { VisitChildren(node); }

        public void Visit(DoStatementNode node)
        {
            PushVisitCreate("Do", BlockType.DoBlock, node, new bool[2] { true, false });
        }

        public void Visit(WhileStatementNode node)
        {
            PushVisitCreate("While", BlockType.WhileBlock, node, new bool[2] { true, false });
        }

        public void Visit(PForEachStatementNode node) { VisitChildren(node); }
        public void Visit(ForEachStatementNode node)
        {
            PushNewList();
            CreateNewNode(node.ForEachRunningVariableName.Value,
                BlockType.VariableBlock, SourceInfoUtils.CreateInterval(node, Source, lineLengthList, FileName), new bool[2] { true, false }, false);

            PushVisitCreate("ForEach", BlockType.ForEachBlock, node, new bool[2] { true, false });
        }

        public void Visit(ForEachInitializationNode node) { VisitChildren(node); }
        public void Visit(ForEachCollectionExpressionNode node) { VisitChildren(node); }

        public void Visit(LoopStatementNode node)
        {
            PushVisitCreate("Loop", BlockType.LoopBlock, node, new bool[2] { true, false });
        }

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
            PushVisitCreate(node.VariableName.Value, BlockType.VariableBlock, node);
        }
        public void Visit(VariableDeclarationNode node)
        {
            PushVisitCreate(node.VariableName.Value, BlockType.VariableBlock, node);
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
