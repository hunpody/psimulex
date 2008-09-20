﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Factories;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public class PsiCodeGeneratorVisitor : IPsiVisitor
    {
        #region PsiBuilderVisitor Members
        
        public ProgramBuilder Program { get; set; }
        public StringBuilder CompilerMessages { get; private set; }
        
        public PsiCodeGeneratorVisitor()
        {
            Program = ProgramBuilder.Create();
            CompilerMessages = new StringBuilder();

            InitHelpers();
        }

        public void AddCommand(ICommand command)
        {
            Program.Add(command);
        }

        public void AddCommand(params ICommand[] commands)
        {
            Program.Add(commands);
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

        private TypeEnum lastCompiledDataType;
        private int lastCompiledDimensionCount;
        private List<int> lastCompiledDimensionList;

        private BaseType lastCompiledConstantValue;

        private bool lastCompiledArrayIsDynamic;

        private void InitHelpers()
        {
            lastCompiledMember = new Member();

            lastCompiledDataType = TypeEnum.Undefined;
            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();

            lastCompiledConstantValue = null;

            lastCompiledArrayIsDynamic = false;
        }

        private string ToVal(string s)
        {
            return s.Replace("\"","").Replace("\'","");
        }


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

            // Message
            string imports = "Imports Found : ( ";
            foreach (IPsiNode child in node.Children)
            {
                imports += child.Value;
                if (child != node.Right)
                    imports += ", ";
            }
            imports += " )";
            AddMessage(imports);

            // Tényleges Importálás, importált fájlok fordítása
            // ...
        }

        public void Visit(TypeDeclarationNode node) { VisitChildren(node); }
        public void Visit(StructDeclarationNode node)
        {
            // User Defined Struct Name
            string structName = node.Left.Value;
            List<Member> structMembers = new List<Member>();

            for (int i = 1; i < node.ChildrenCount; i++)
            {
                node.Children[i].Accept(this);
                structMembers.Add(lastCompiledMember);
            }

            // Message
            string record = "Struct Found : " + structName + " { ";
            foreach (Member member in structMembers)
            {
                record += member.ToString();

                if (member != structMembers[structMembers.Count - 1])
                    record += ", ";
            }
            record += " }";
            AddMessage(record);

            // Struct Hozzáadása az UserDefinedTypes -hoz
            // ...
        }

        public void Visit(MemberDeclarationNode node)
        {
            node.Left.Accept(this);
            TypeEnum memberType = lastCompiledDataType;

            int memberDimensionCount = lastCompiledDimensionCount;
            List<int> memberDimensionList = lastCompiledDimensionList;

            string memberName = node.GetChild(1).Value;
            bool memberIsInitialised = false;
            BaseType memberValue = null;
            if (node.GetChild(2) != null)
            {
                node.GetChild(2).Accept(this);
                memberValue = lastCompiledConstantValue;
                memberIsInitialised = true;
            }

            lastCompiledMember = new Member(
                memberType,
                memberDimensionCount,
                memberDimensionList,
                memberName,
                memberValue,
                memberIsInitialised
                );

            lastCompiledDimensionList = new List<int>();
            lastCompiledDimensionCount = 1;
            lastCompiledDataType = TypeEnum.Undefined;
        }

        public void Visit(GlobalVariableDeclarationsNode node)
        {
            foreach (IPsiNode child in node.Children)
            {
                child.Accept(this);

                // Message
                string record = "Global Variable Found : " + lastCompiledMember.ToString();
                AddMessage(record);

                // Globális változó felvétele a lastCompiledMember -ból
                // ...
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
            // Tömbnél tudni kell, hogy dinamikus vagy statikus.
            VisitChildren(node);
        }

        public void Visit(VariableDeclarationNode node)
        {
            // Tömbnél tudni kell, hogy dinamikus vagy statikus.
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
            lastCompiledDimensionCount = node.ChildrenCount;
            for (int i = 0; i < node.ChildrenCount; i++)
                node.Children[i].Accept(this);

            lastCompiledArrayIsDynamic = false;
        }

        public void Visit(ConstantDimensionsNode node)
        {
            lastCompiledDimensionList = new List<int>();
            for (int i = 0; i < node.ChildrenCount; i++)
                lastCompiledDimensionList.Add(Convert.ToInt32(ToVal(node.Children[i].Value)));
            lastCompiledDimensionCount = lastCompiledDimensionList.Count;
        }

        public void Visit(DimensionMarkerNode node)
        {
            lastCompiledDimensionCount = node.ChildrenCount - 2;
            lastCompiledDimensionList = new List<int>();
            lastCompiledArrayIsDynamic = true;
        }

        /*Identifier*/
        public void Visit(IdentifierNode node)
        {
            VisitChildren(node);
        }

        /*Literals*/
        public void Visit(CharLiteralNode node)
        {
            //lastCompiledBaseTypeValue = ...
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
        public void Visit(TypeNode node) { VisitChildren(node); }
        public void Visit(DataTypeNode node)
        {
            lastCompiledDataType = TypeEnumFactory.CreateTypeEnum(node.Left.Value);
            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();
        }
        
        public void Visit(DataTypeNameNode node)
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