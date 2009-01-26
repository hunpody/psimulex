using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Utils;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.Info;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /// <summary>
    /// Semantic analizer.
    /// Search for semantic errors and generate Error/Warning messages.
    /// </summary>
    public class PsiSemanticAnaliserVisitor : PsiVisitor
    {
        /*Input*/
        #region Input

        public PsiSemanticAnaliserVisitor(CompilationUnit cu, CompilerDTO dto)
            : base(cu, dto)
        {
            CurrentCompilationUnit = cu;
            DTO = dto;

            InitHelpers();
        }

        #endregion

        /*Helper Methods*/
        #region Helper Methods

        private List<List<VariableInfo>> currentLocalVariableList;

        private void InitHelpers()
        {
            currentLocalVariableList = new List<List<VariableInfo>>();
        }

        #endregion

        /*Name collision checkings helpers*/
        #region Name collision checkings helpers

        private void NewScope()
        {
            currentLocalVariableList.Add(new List<VariableInfo>());
        }

        private void DeleteScope()
        {
            currentLocalVariableList.RemoveAt(currentLocalVariableList.Count - 1);
        }

        private bool IsExistsLocalVariable(string name)
        {
            foreach (var varList in currentLocalVariableList)
                foreach (var var in varList)
                    if (var.Name == name)
                        return true;

            return false;
        }

        private void AddLocalVariable(string name, TypeIdentifier ti, NodeValueInfo nvi)
        {
            if (currentLocalVariableList.Count == 0)
                NewScope();
            currentLocalVariableList.Last<List<VariableInfo>>().Add(new VariableInfo(name, ti, SourceFileName, nvi));
        }

        private void CheckAndAddLocalVariable(string name, TypeIdentifier ti, NodeValueInfo nvi)
        {
            if (IsExistsLocalVariable(name))
                AddWarning(CompilerErrorCode.LocalVariableNameCollision, string.Format("Local variable name \"{0}\" is already exist in the current scope.", name), nvi);
            else
                AddLocalVariable(name, ti, nvi);
        }

        #endregion

        #region IPsiVisitor members

        /*High Level Tree Nodes*/
        #region High Level Tree Nodes

        //public override void Visit(CompilationUnitNode node) { if (node != null) VisitChildren(node); }
        public override void Visit(SimpleProgramNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(MultiFuncionalProgramNode node) { VisitChildren(node); }
        public override void Visit(ImportDeclarationNode node) { VisitChildren(node); }
        public override void Visit(TypeDeclarationNode node) { VisitChildren(node); }
        public override void Visit(StructDeclarationNode node) { VisitChildren(node); }
        public override void Visit(MemberDeclarationNode node) { VisitChildren(node); }
        public override void Visit(GlobalVariableDeclarationsNode node) { VisitChildren(node); }
        public override void Visit(FunctionDeclarationsNode node) { VisitChildren(node); }
        
        public override void Visit(FunctionDeclarationNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(FormalParameterListNode node) { VisitChildren(node); }
        public override void Visit(FormalParameterNode node) { VisitChildren(node); }

        #endregion

        /*Program Structures*/
        #region Program Structures

        public override void Visit(BlockNode node) { VisitChildren(node); }
        public override void Visit(StatementNode node) { VisitChildren(node); }
        public override void Visit(IfStatementNode node) { VisitChildren(node); }
        public override void Visit(IfBranchNode node) { VisitChildren(node); }
        public override void Visit(ElseIfBranchNode node) { VisitChildren(node); }

        public override void Visit(ConditionalBranchNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(ElseBranchNode node) 
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(PForStatementNode node) { VisitChildren(node); }

        public override void Visit(ForStatementNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(ForInitializationNode node) { VisitChildren(node); }
        public override void Visit(ForConditionNode node) { VisitChildren(node); }
        public override void Visit(ForUpdateNode node) { VisitChildren(node); }

        public override void Visit(DoStatementNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(WhileStatementNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(PForEachStatementNode node) { VisitChildren(node); }
        
        public override void Visit(ForEachStatementNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(ForEachInitializationNode node) { VisitChildren(node); }
        public override void Visit(ForEachCollectionExpressionNode node) { VisitChildren(node); }

        public override void Visit(LoopStatementNode node)
        {
            NewScope();
            VisitChildren(node);
            DeleteScope();
        }

        public override void Visit(LoopInitializationNode node) { VisitChildren(node); }
        public override void Visit(LoopLimitNode node) { VisitChildren(node); }
        public override void Visit(ConditionNode node) { VisitChildren(node); }
        public override void Visit(CoreNode node) { VisitChildren(node); }
        public override void Visit(PDoStatementNode node) { VisitChildren(node); }
        public override void Visit(AsynStatementNode node) { VisitChildren(node); }
        public override void Visit(LockStatementNode node) { VisitChildren(node); }
        public override void Visit(ReturnStatementNode node) { VisitChildren(node); }
        public override void Visit(ReturnNode node) { VisitChildren(node); }
        public override void Visit(BreakNode node) { VisitChildren(node); }
        public override void Visit(ExpressionStatementNode node) { VisitChildren(node); }
        public override void Visit(VariableDeclarationStatementNode node) { VisitChildren(node); }
        public override void Visit(VariableInitializationNode node) { VisitChildren(node); }
        public override void Visit(VariableDeclarationNode node) { VisitChildren(node); }

        #endregion

        /*Operators*/
        #region Operators

        public override void Visit(AssignmentOpNode node) { VisitChildren(node); }
        public override void Visit(LogicalOrOpNode node) { VisitChildren(node); }
        public override void Visit(LogicalAndOpNode node) { VisitChildren(node); }
        public override void Visit(EqualityOpNode node) { VisitChildren(node); }
        public override void Visit(RelationOpNode node) { VisitChildren(node); }
        public override void Visit(AdditiveOpNode node) { VisitChildren(node); }
        public override void Visit(MultiplicativeOpNode node) { VisitChildren(node); }
        public override void Visit(UnaryOpNode node) { VisitChildren(node); }

        #endregion

        /*Expressions*/
        #region Expression

        public override void Visit(ExpressionNode node) { VisitChildren(node); }
        public override void Visit(CastNode node) { VisitChildren(node); }
        public override void Visit(PrefixUnaryOperationNode node) { VisitChildren(node); }
        public override void Visit(SelectorNode node) { VisitChildren(node); }
        public override void Visit(MemberSelectNode node) { VisitChildren(node); }
        public override void Visit(MemberFunctionCallNode node) { VisitChildren(node); }
        public override void Visit(FunctionCallNode node) { VisitChildren(node); }
        public override void Visit(ArgumentsNode node) { VisitChildren(node); }
        public override void Visit(IndexingNode node) { VisitChildren(node); }
        public override void Visit(ArrayInitializatorNode node) { VisitChildren(node); }
        public override void Visit(CollectionInitializatorNode node) { VisitChildren(node); }

        #endregion

        /*Identifier*/
        #region Identifier

        public override void Visit(IdentifierNode node) { VisitChildren(node); }

        #endregion

        /*Types*/
        #region Types

        public virtual void Visit(TypeNode node)
        {
            VisitChildren(node);

            // Elméletielg itt már összetudjuk pattintani a type Identifiert !
        }

        #endregion

        #endregion
    }
}
