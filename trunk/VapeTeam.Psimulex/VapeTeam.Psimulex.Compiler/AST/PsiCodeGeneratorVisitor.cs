using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public class PsiCodeGeneratorVisitor : IPsiVisitor
    {
        #region PsiBuilderVisitor Members
        
        public Program Program { get; set; }
        public StringBuilder CompilerMessages { get; private set; }
        
        public PsiCodeGeneratorVisitor()
        {
            Program = new Program();
            CompilerMessages = new StringBuilder();
            lastCompiledMember = new Member();
        }

        public void AddCommand(ICommand command)
        {
            Program.Add(command);
        }

        public void AddMessage(string msg)
        {
            CompilerMessages.AppendLine(msg);
        }

        /*Compile Helpers*/
        /// <summary>
        /// Global or Struct Member Variables.
        /// </summary>
        private Member lastCompiledMember;


        #endregion

        #region IPsiVisitor Members

        /*Children Visiting*/
        public void VisitChildren(IPsiNode node)
        {
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
        }

        /*Common Tree Node*/    // Igazából ilyennek nem szabad lennie a végén ! //
        public void Visit(PsiNode node) { AddMessage("PsiNode Found : " + node.ToString()); VisitChildren(node); }

        /*Undefined Tree Node*/     // És ilyennek sem ! //
        public void Visit(XNode node) { AddMessage("XNode Found : " + node.ToString()); VisitChildren(node); }

        /*High Level Tree Nodes*/
        public void Visit(CompilationUnitNode node) { VisitChildren(node); }
        public void Visit(SimpleProgramNode node) { VisitChildren(node); }
        public void Visit(MultiFuncionalProgramNode node) { VisitChildren(node); }
        public void Visit(ImportDeclarationNode node)
        {
            // Majd meg kell csinálni az importálást
            /* A) Dictionary -be FV név, Parancsobjektum Párok
             * B) Importolási sorrendben végigfordítjuk és egy tömbbe pakoljuk.
             * C) ???
             */
            string imports = "Imports Found : ( ";
            foreach (IPsiNode child in node.Children)
            {
                imports += child.Value;
                if (child != node.Right)
                    imports += ", ";
            }
            imports += " )";
            AddMessage(imports);
        }

        public void Visit(TypeDeclarationNode node) { VisitChildren(node); }
        public void Visit(StructDeclarationNode node)
        {
            // User Defined Struct Name
            string structName = node.Left.Value;
            for (int i = 1; i < node.ChildrenCount; i++)
            {
                //Visit(node); Return vagy nem return ?

                // Itt kell kiolvasni az lastCompiledMember -t
                // És felvenni az adott Struktúra tagváltozók közé (típus, név, esetleges kezdőérték)
            }

        }

        public void Visit(MemberDeclarationNode node)
        {
            VisitChildren(node);
            //return new Member(TypeEnum.Undefined,"","",false);
        }

        public void Visit(GlobalVariableDeclarationsNode node)
        {
            for (int i = 0; i < node.ChildrenCount; i++)
            {
                //Visit(node); Return vagy nem return ?
                
                // Itt kell kiolvasni az lastCompiledMember -t
                // És felvenni a globális változók közé (típus, név, esetleges kezdőérték)
            }
        }

        public void Visit(FunctionDeclarationsNode node)
        {
            VisitChildren(node);
        }

        public void Visit(FunctionDeclarationNode node)
        {
            VisitChildren(node);
        }

        public void Visit(FormalParameterNode node)
        {
            VisitChildren(node);
        }

        public void Visit(BlockNode node)
        {
            VisitChildren(node);
        }

        public void Visit(VariableInitialisationNode node)
        {
            VisitChildren(node);
        }

        public void Visit(VariableDeclarationNode node)
        {
            VisitChildren(node);
        }

        /*Operators*/
        public void Visit(AssignmentOpNode node)
        {
            VisitChildren(node);
        }

        public void Visit(LogicalOrOpNode node)
        {
            VisitChildren(node);
        }

        public void Visit(LogicalAndOpNode node)
        {
            VisitChildren(node);
        }

        public void Visit(EqualityOpNode node)
        {
            VisitChildren(node);
        }

        public void Visit(RelationOpNode node)
        {
            VisitChildren(node);
        }

        public void Visit(AdditiveOpNode node)
        {
            VisitChildren(node);
        }

        public void Visit(MultiplicativeOpNode node)
        {
            VisitChildren(node);
        }

        public void Visit(UnaryOpNode node)
        {
            VisitChildren(node);
        }

        /*Expressions*/
        public void Visit(ExpressionNode node)
        {
            VisitChildren(node);
        }

        public void Visit(AssignmentNode node)
        {
            VisitChildren(node);
        }

        public void Visit(MemberSelectNode node)
        {
            VisitChildren(node);
        }

        public void Visit(MemberFunctionCallNode node)
        {
            VisitChildren(node);
        }

        public void Visit(FunctionCallNode node)
        {
            VisitChildren(node);
        }

        public void Visit(IndexingNode node)
        {
            VisitChildren(node);
        }

        public void Visit(DimensionsNode node)
        {
            VisitChildren(node);
        }

        public void Visit(DimensionMarkerNode node)
        {
            VisitChildren(node);
        }

        /*Identifier*/
        public void Visit(IdentifierNode node)
        {
            VisitChildren(node);
        }

        /*Literals*/
        public void Visit(CharLiteralNode node)
        {
            VisitChildren(node);
        }

        public void Visit(StringLiteralNode node)
        {
            VisitChildren(node);
        }

        public void Visit(IntLiteralNode node)
        {
            VisitChildren(node);
        }

        public void Visit(DecimalLiteralNode node)
        {
            VisitChildren(node);
        }

        public void Visit(BoolLiteralNode node)
        {
            VisitChildren(node);
        }

        public void Visit(NullLiteralNode node)
        {
            VisitChildren(node);
        }

        public void Visit(InfinityLiteralNode node)
        {
            VisitChildren(node);
        }

        /*Types*/
        public void Visit(DataTypeNameNode node)
        {
            VisitChildren(node);
        }

        public void Visit(DataTypeNode node)
        {
            VisitChildren(node);
        }

        public void Visit(TypeNode node)
        {
            VisitChildren(node);
        }

        public void Visit(ReferenceNode node)
        {
            VisitChildren(node);
        }

        #endregion
    }
}
