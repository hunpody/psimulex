using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public interface IPsiVisitor
    {
        #region Additional Functions

        /*Children Visiting*/
        void VisitChildren(IPsiNode node);

        #endregion

        #region Typed Node Visit() -s

        /*Common Tree Node*/
        void Visit(PsiNode node);

        /*Undefined Tree Node*/
        void Visit(XNode node);

        /*High Level Tree Nodes*/
        void Visit(CompilationUnitNode node);
        void Visit(SimpleProgramNode node);
        void Visit(MultiFuncionalProgramNode node);
        void Visit(ImportDeclarationNode node);
        void Visit(TypeDeclarationNode node);
        void Visit(StructDeclarationNode node);
        void Visit(MemberDeclarationNode node);
        void Visit(GlobalVariableDeclarationsNode node);
        void Visit(FunctionDeclarationsNode node);
        void Visit(FunctionDeclarationNode node);
        void Visit(FormalParameterListNode node);
        void Visit(FormalParameterNode node);

        /*Program Structures*/
        void Visit(BlockNode node);
        void Visit(StatementNode node);
        void Visit(IfStatementNode node);
        void Visit(IfBranchNode node);
        void Visit(ElseIfBranchNode node);
        void Visit(ElseBranchNode node);
        void Visit(PForStatementNode node);
        void Visit(ForStatementNode node);
        void Visit(ForInitializationNode node);
        void Visit(ForUpdateNode node);
        void Visit(DoStatementNode node);
        void Visit(WhileStatementNode node);
        void Visit(PForEachStatementNode node);
        void Visit(ForEachStatementNode node);
        void Visit(ForEachControlNode node);
        void Visit(LoopStatementNode node);
        void Visit(LoopControlNode node);
        void Visit(ConditionNode node);
        void Visit(CoreNode node);
        void Visit(PDoStatementNode node);
        void Visit(AsynStatementNode node);
        void Visit(LockStatementNode node);
        void Visit(ReturnNode node);
        void Visit(BreakNode node);
        //void Visit(ContinueNode node);
        void Visit(VariableInitializationNode node);
        void Visit(VariableDeclarationNode node);

        /*Operators*/
        void Visit(AssignmentOpNode node);
        void Visit(LogicalOrOpNode node);
        void Visit(LogicalAndOpNode node);
        void Visit(EqualityOpNode node);
        void Visit(RelationOpNode node);
        void Visit(AdditiveOpNode node);
        void Visit(MultiplicativeOpNode node);
        void Visit(UnaryOpNode node);

        /*Expressions*/
        void Visit(ExpressionNode node);
        void Visit(CastNode node);
        void Visit(PrefixUnaryOperationNode node);
        /*
        void Visit(LambdaExpressionNode node);
        void Visit(LambdaParameterNode node);
        void Visit(LambdaStatementNode node);
        */

        void Visit(SelectorNode node);
        void Visit(MemberSelectNode node);
        void Visit(MemberFunctionCallNode node);
        void Visit(FunctionCallNode node);
        void Visit(ArgumentsNode node);
        void Visit(IndexingNode node);
        void Visit(DimensionsNode node);
        void Visit(ConstantDimensionsNode node);
        void Visit(DimensionMarkerNode node);

        /*ID*/
        void Visit(IdentifierNode node);

        /*Literals*/
        void Visit(CharLiteralNode node);
        void Visit(StringLiteralNode node);
        void Visit(IntLiteralNode node);
        void Visit(DecimalLiteralNode node);
        void Visit(BoolLiteralNode node);
        void Visit(NullLiteralNode node);
        void Visit(InfinityLiteralNode node);

        /*Types*/
        void Visit(DataTypeNameNode node);
        void Visit(DataTypeNode node);
        /*
        void Visit(FunctionPointerTypeNode node);
        */
        void Visit(TypeNode node);
        void Visit(ReferenceNode node);

        #endregion
    }
}
