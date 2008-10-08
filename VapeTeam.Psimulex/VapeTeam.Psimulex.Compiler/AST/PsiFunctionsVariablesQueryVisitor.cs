using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    class PsiFunctionsVariablesQueryVisitor : IPsiVisitor
    {
        #region IPsiVisitor Members

        public void VisitChildren(IPsiNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PsiNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(XNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(CompilationUnitNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(SimpleProgramNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(MultiFuncionalProgramNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ImportDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(TypeDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(StructDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(MemberDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(GlobalVariableDeclarationsNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(FunctionDeclarationsNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(FunctionDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(FormalParameterListNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(FormalParameterNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(BlockNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(StatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(IfStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(IfBranchNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ElseIfBranchNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ConditionalBranchNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ElseBranchNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PForStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ForStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ForInitializationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ForConditionNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ForUpdateNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(DoStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(WhileStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PForEachStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ForEachStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ForEachInitializationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ForEachCollectionExpressionNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(LoopStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(LoopInitializationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(LoopLimitNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ConditionNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(CoreNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PDoStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(AsynStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(LockStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ReturnStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ReturnNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(BreakNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ExpressionStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(VariableDeclarationStatementNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(VariableInitializationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(VariableDeclarationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(AssignmentOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(LogicalOrOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(LogicalAndOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(EqualityOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(RelationOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(AdditiveOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(MultiplicativeOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(UnaryOpNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ExpressionNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(CastNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PrefixUnaryOperationNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(SelectorNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(MemberSelectNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(MemberFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(FunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ArgumentsNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(IndexingNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(DimensionsNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ConstantDimensionsNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(DimensionMarkerNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(IdentifierNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(CharLiteralNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(StringLiteralNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(IntLiteralNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(DecimalLiteralNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(BoolLiteralNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(NullLiteralNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(InfinityLiteralNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(DataTypeNameNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(DataTypeNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(TypeNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ReferenceNode node)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
