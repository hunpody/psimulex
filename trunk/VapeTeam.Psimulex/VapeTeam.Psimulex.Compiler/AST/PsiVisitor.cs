using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Compiler.Utils;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Compiler.Info;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public abstract class PsiVisitor : IPsiVisitor
    {
        /*Input*/
        #region Input

        public CompilerDTO DTO { get; set; }
        public CompilationUnit CurrentCompilationUnit { get; set; }

        public string Source { get { return CurrentCompilationUnit.Source; } }
        public string SourceFileName { get { return CurrentCompilationUnit.FileName; } }
        public string ProgramPath { get { return DTO.ProgramPath; } }

        public List<CompilationUnit> CompilationUnitList { get { return DTO.CompilationUnitList; } }

        public List<UserDefinedTypeInfo> UserDefinedTypeInfoList { get { return DTO.UserDefinedTypeInfoList; } }
        public List<UserDefinedFunctionInfo> UserDefinedFunctionInfoList { get { return DTO.UserDefinedFunctionInfoList; } }
        public List<GlobalVariableInfo> GlobalVariableInfoList { get { return DTO.GlobalVariableInfoList; } }
        
        public CommandPositionChanges CommandPositionChanges { get { return DTO.CommandPositionChanges; } }

        public PsiVisitor(CompilationUnit cu, CompilerDTO dto)
        {
            DTO = dto;
            CurrentCompilationUnit = cu;

            InitHelpers();
        }

        #endregion

        /*Helper Methods*/
        #region Helper Methods

        protected BaseType lastCompiledConstantValue;
        protected TypeEnum lastCompiledDataType;
        protected string lastCompiledDataTypeName;
        protected int lastCompiledDimensionCount;
        protected List<int> lastCompiledDimensionList;
        protected UserDefinedFunction lastCompiledUserDefinedFunction;

        private void InitHelpers()
        {
            lastCompiledConstantValue = null;
            lastCompiledDataType = TypeEnum.Undefined;
            lastCompiledDataTypeName = "";
            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();
            lastCompiledUserDefinedFunction = new UserDefinedFunction();
        }

        #endregion

        /*Message Generators*/
        #region Message Generators

        protected void AddInformation(string msg, NodeValueInfo info)
        {
            DTO.AddInformation(msg, info, SourceFileName);
        }

        protected void AddWarning(CompilerErrorCode code, string warning, NodeValueInfo info)
        {
            DTO.AddWarning(code, warning, info, SourceFileName);
        }

        protected void AddError(CompilerErrorCode code, string error, NodeValueInfo info)
        {
            DTO.AddError(code, error, info, SourceFileName);
        }

        protected void AddError(CompilerErrorCode code, string error, NodeValueInfo info, Exception ex)
        {
            DTO.AddError(code, error, info, ex, SourceFileName);
        }

        #endregion

        /*Literals*/
        #region Literals

        protected BaseType CharLiteralNodeToBaseType(CharLiteralNode node)
        {
            char charChar = ' ';
            string strChar = node.Value.SplitQuotes();
            switch (strChar)
            {
                case "\\n": charChar = '\n'; break; // Milegyen itt, hogy jólegyen ?
                case "\\\'": charChar = '\''; break;
                case "\\\"": charChar = '\"'; break;
                case "\\\\": charChar = '\\'; break;
                default: charChar = strChar[0]; break;
            }
            return ValueFactory.Create(charChar);
        }

        protected BaseType StringLiteralNodeToBaseType(StringLiteralNode node)
        {
            string str = node.Value.SplitQuotes()
                .Replace("\\n", "\r\n")
                .Replace("\\\'", "\'")
                .Replace("\\\"", "\"")
                .Replace("\\\\", "\\");
            return ValueFactory.Create(Convert.ToString(str));
        }

        protected BaseType IntLiteralNodeToBaseType(IntLiteralNode node)
        {
            return ValueFactory.Create(Convert.ToInt32(node.Value.SplitQuotes()));
        }

        protected BaseType DecimalLiteralNodeToBaseType(DecimalLiteralNode node)
        {
            string str = node.Value
                .Replace(".", ",")
                .Replace("m", "")
                .Replace("M", "")
                .Replace("d", "")
                .Replace("D", "");
            if (str[0] == '.')
                str = "0" + str;
            if (str[str.Length - 1] == '.')
                str += "0";

            return ValueFactory.Create(Convert.ToDecimal(str));
        }

        protected BaseType BoolLiteralNodeToBaseType(BoolLiteralNode node)
        {
            string constant = node.Value.SplitQuotes();
            bool l = Convert.ToBoolean(constant);
            return ValueFactory.Create(l);
        }

        protected BaseType NullLiteralNodeToBaseType(NullLiteralNode node)
        {
            return ValueFactory.Create(null);
        }

        #endregion

        #region IPsiVisitor Members

        public virtual void VisitChildren(IPsiNode node)
        {
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
        }

        /*Unknow Nodes*/
        #region Unknow Nodes

        /*Common Tree Node*/
        public virtual void Visit(PsiNode node) { VisitChildren(node); }

        /*Undefined Tree Node*/
        public virtual void Visit(XNode node) { VisitChildren(node); }

        #endregion

        /*High Level Tree Nodes*/
        #region High Level Tree Nodes

        public virtual void Visit(CompilationUnitNode node) { if(node != null) VisitChildren(node); }
        public virtual void Visit(SimpleProgramNode node) { VisitChildren(node); }
        public virtual void Visit(MultiFuncionalProgramNode node) { VisitChildren(node); }
        public virtual void Visit(ImportDeclarationNode node) { VisitChildren(node); }
        public virtual void Visit(TypeDeclarationNode node) { VisitChildren(node); }
        public virtual void Visit(StructDeclarationNode node) { VisitChildren(node); }
        public virtual void Visit(MemberDeclarationNode node) { VisitChildren(node); }
        public virtual void Visit(GlobalVariableDeclarationsNode node) { VisitChildren(node); }
        public virtual void Visit(FunctionDeclarationsNode node) { VisitChildren(node); }
        public virtual void Visit(FunctionDeclarationNode node) { VisitChildren(node); }
        public virtual void Visit(FormalParameterListNode node) { VisitChildren(node); }
        public virtual void Visit(FormalParameterNode node) { VisitChildren(node); }

        #endregion

        /*Program Structures*/
        #region Program Structures

        public virtual void Visit(BlockNode node) { VisitChildren(node); }
        public virtual void Visit(StatementNode node) { VisitChildren(node); }
        public virtual void Visit(IfStatementNode node) { VisitChildren(node); }
        public virtual void Visit(IfBranchNode node) { VisitChildren(node); }
        public virtual void Visit(ElseIfBranchNode node) { VisitChildren(node); }
        public virtual void Visit(ConditionalBranchNode node) { VisitChildren(node); }
        public virtual void Visit(ElseBranchNode node) { VisitChildren(node); }
        public virtual void Visit(PForStatementNode node) { VisitChildren(node); }
        public virtual void Visit(ForStatementNode node) { VisitChildren(node); }
        public virtual void Visit(ForInitializationNode node) { VisitChildren(node); }
        public virtual void Visit(ForConditionNode node) { VisitChildren(node); }
        public virtual void Visit(ForUpdateNode node) { VisitChildren(node); }
        public virtual void Visit(DoStatementNode node) { VisitChildren(node); }
        public virtual void Visit(WhileStatementNode node) { VisitChildren(node); }
        public virtual void Visit(PForEachStatementNode node) { VisitChildren(node); }
        public virtual void Visit(ForEachStatementNode node) { VisitChildren(node); }
        public virtual void Visit(ForEachInitializationNode node) { VisitChildren(node); }
        public virtual void Visit(ForEachCollectionExpressionNode node) { VisitChildren(node); }
        public virtual void Visit(LoopStatementNode node) { VisitChildren(node); }
        public virtual void Visit(LoopInitializationNode node) { VisitChildren(node); }
        public virtual void Visit(LoopLimitNode node) { VisitChildren(node); }
        public virtual void Visit(ConditionNode node) { VisitChildren(node); }
        public virtual void Visit(CoreNode node) { VisitChildren(node); }
        public virtual void Visit(PDoStatementNode node) { VisitChildren(node); }
        public virtual void Visit(AsynStatementNode node) { VisitChildren(node); }
        public virtual void Visit(LockStatementNode node) { VisitChildren(node); }
        public virtual void Visit(ReturnStatementNode node) { VisitChildren(node); }
        public virtual void Visit(ReturnNode node) { VisitChildren(node); }
        public virtual void Visit(BreakNode node) { VisitChildren(node); }
        public virtual void Visit(ExpressionStatementNode node) { VisitChildren(node); }
        public virtual void Visit(VariableDeclarationStatementNode node) { VisitChildren(node); }
        public virtual void Visit(VariableInitializationNode node) { VisitChildren(node); }
        public virtual void Visit(VariableDeclarationNode node) { VisitChildren(node); }

        #endregion

        /*Operators*/
        #region Operators   

        public virtual void Visit(AssignmentOpNode node) { VisitChildren(node); }
        public virtual void Visit(LogicalOrOpNode node) { VisitChildren(node); }
        public virtual void Visit(LogicalAndOpNode node) { VisitChildren(node); }
        public virtual void Visit(EqualityOpNode node) { VisitChildren(node); }
        public virtual void Visit(RelationOpNode node) { VisitChildren(node); }
        public virtual void Visit(AdditiveOpNode node) { VisitChildren(node); }
        public virtual void Visit(MultiplicativeOpNode node) { VisitChildren(node); }
        public virtual void Visit(UnaryOpNode node) { VisitChildren(node); }

        #endregion

        /*Expressions*/
        #region Expression 

        public virtual void Visit(ExpressionNode node) { VisitChildren(node); }
        public virtual void Visit(CastNode node) { VisitChildren(node); }
        public virtual void Visit(PrefixUnaryOperationNode node) { VisitChildren(node); }
        public virtual void Visit(SelectorNode node) { VisitChildren(node); }
        public virtual void Visit(MemberSelectNode node) { VisitChildren(node); }
        public virtual void Visit(MemberFunctionCallNode node) { VisitChildren(node); }
        public virtual void Visit(FunctionCallNode node) { VisitChildren(node); }
        public virtual void Visit(ArgumentsNode node) { VisitChildren(node); }
        public virtual void Visit(IndexingNode node) { VisitChildren(node); }
        public virtual void Visit(ArrayInitializatorNode node) { VisitChildren(node); }
        public virtual void Visit(CollectionInitializatorNode node) { VisitChildren(node); }

        #endregion

        /*Identifier*/
        #region Identifier

        public virtual void Visit(IdentifierNode node) { VisitChildren(node); }

        #endregion

        /*Literals*/
        #region Literals

        public virtual void Visit(CharLiteralNode node) { lastCompiledConstantValue = CharLiteralNodeToBaseType(node); }
        public virtual void Visit(StringLiteralNode node) { lastCompiledConstantValue = StringLiteralNodeToBaseType(node); }
        public virtual void Visit(IntLiteralNode node) { lastCompiledConstantValue = IntLiteralNodeToBaseType(node); }
        public virtual void Visit(DecimalLiteralNode node) { lastCompiledConstantValue = DecimalLiteralNodeToBaseType(node); }
        public virtual void Visit(BoolLiteralNode node) { lastCompiledConstantValue = BoolLiteralNodeToBaseType(node); }
        public virtual void Visit(NullLiteralNode node) { lastCompiledConstantValue = NullLiteralNodeToBaseType(node); }

        public virtual void Visit(InfinityLiteralNode node)
        {
            // ???
            VisitChildren(node);
        }

        #endregion

        /*Types*/
        #region Types

        public virtual void Visit(DimensionMarkerNode node)
        {
            lastCompiledDimensionCount = node.ChildrenCount - 1;
            lastCompiledDimensionList = new List<int>();
        }

        public virtual void Visit(TypeNode node) { VisitChildren(node); }
        public virtual void Visit(DataTypeNode node)
        {
            lastCompiledDataType = TypeEnumFactory.CreateTypeEnum(node.Left.Value);
            lastCompiledDataTypeName = node.Left.Value;

            // Set back to Defaults
            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();
        }

        public virtual void Visit(DataTypeNameNode node) { VisitChildren(node); }
        public virtual void Visit(ReferenceNode node) { VisitChildren(node); }

        #endregion

        #endregion
    }
}
