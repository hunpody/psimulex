using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Factories;

namespace VapeTeam.Psimulex.Compiler.AST
{
    #region PsiCodeGeneratorVisitor Exceptions

    public class PsiCodeGeneratorVisitorException : Exception
    {         
        public PsiCodeGeneratorVisitorException(string message)
            : base(message)
        {
        }

        public PsiCodeGeneratorVisitorException()
        : this("PsiCodeGeneratorVisitorException")
        {
        }
    }

    public class UnknownOperatorException : PsiCodeGeneratorVisitorException
    {
        public UnknownOperatorException(string message)
            : base(message)
        {
        }

        public UnknownOperatorException()
            : this("UnknownOperatorException")
        {
        }
    }

    #endregion

    public class PsiCodeGeneratorVisitor : IPsiVisitor
    {
        #region PsiBuilderVisitor Members
        
        public ProgramBuilder Program { get; set; }
        public int ProgramSize { get { return Program.Program.CommandList.Count; } }
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

        public int GetCommandIndex(CommandBase cmd)
        {
            return Program.GetCommandIndex(cmd);
        }

        public void AddMessage(string msg)
        {
            CompilerMessages.AppendLine(msg);
        }

        /*Compile Helpers*/
        #region Compiler Helpers

        /// <summary>
        /// Global or Struct Member Variables.
        /// </summary>
        private Member lastCompiledMember;

        private TypeEnum lastCompiledDataType;
        private string lastCompiledUserDefinedDataTypeName;

        private int lastCompiledDimensionCount;
        private List<int> lastCompiledDimensionList;

        private bool addToProgram;
        private BaseType lastCompiledConstantValue;

        private bool isLastCompiledArrayDynamic;

        private Assign lastCompiledAssign;

        private bool isOperatorUnaryPrefix;

        private bool isCompilingAssignmentTarget;

        private bool isSelectorsFirstCompile;

        private System.Collections.Generic.Stack<Jump> lazyEvaluationJumpStack;
        private System.Collections.Generic.Stack<Jump> jumpStack;

        private int conditionCount;

        private void InitHelpers()
        {
            lastCompiledMember = new Member();

            lastCompiledDataType = TypeEnum.Undefined;
            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();

            addToProgram = true;
            lastCompiledConstantValue = null;

            isLastCompiledArrayDynamic = false;
            lastCompiledAssign = null;

            isOperatorUnaryPrefix = false;

            isCompilingAssignmentTarget = false;

            isSelectorsFirstCompile = true;

            lazyEvaluationJumpStack = new System.Collections.Generic.Stack<Jump>();
            jumpStack = new System.Collections.Generic.Stack<Jump>();

            conditionCount = 0;
        }

        private string SplitQuotes(string s)
        {
            if (s[0] == '\'' || s[0] == '\"')
                return s.Substring(1, s.Length - 2);
            return s;
        }

        private string GenerateIteratorName()
        {
            return string.Format("iterator_{0}", DateTime.Now.ToShortTimeString().Replace(":", "_").Replace(" ", "_").Replace(".", "_"));
        }

        private void SetUpTopJumpInJumpStack(int corrigation)
        {
            Jump jmp = jumpStack.Pop();
            jmp.PC = ProgramSize - GetCommandIndex(jmp) + corrigation;
        }

        #endregion
        
        #endregion

        #region IPsiVisitor Members

        /*Children Visiting*/
        public void VisitChildren(IPsiNode node)
        {
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
        }

        #region Unknow Nodes

        /*Common Tree Node*/
        public void Visit(PsiNode node) { AddMessage("PsiNode Found : " + node.ToString()); VisitChildren(node); }

        /*Undefined Tree Node*/
        public void Visit(XNode node) { AddMessage("XNode Found : " + node.ToString()); VisitChildren(node); }

        #endregion

        /*High Level Tree Nodes*/
        #region High Level Tree Nodes

        public void Visit(CompilationUnitNode node) { VisitChildren(node); }
        public void Visit(SimpleProgramNode node) { VisitChildren(node); }
        public void Visit(MultiFuncionalProgramNode node) { VisitChildren(node); }
        public void Visit(ImportDeclarationNode node)
        {
            // Majd meg kell csinálni az importálást
            /* A) Dictionary -be FV név, Parancsobjektum Párok
             * B) Importolási sorrendben végigfordítjuk és egy tömbbe pakoljuk.
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
            string structName = node.StructName.Value;
            List<Member> structMembers = new List<Member>();

            foreach (IPsiNode member in node.StructMemberList)
            {
                member.Accept(this);
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
            // MemberType
            node.MemberType.Accept(this);
            TypeEnum memberType = lastCompiledDataType;
            string memberTypeName = node.MemberTypeName.Value;

            int memberDimensionCount = lastCompiledDimensionCount;
            List<int> memberDimensionList = lastCompiledDimensionList;

            // MemberName
            string memberName = node.MemberName.Value;
            bool memberIsInitialized = false;

            // MemberInitiaValue
            BaseType memberValue = null;
            if (node.MemberInitialValue != null)
            {
                addToProgram = false;
                node.MemberInitialValue.Accept(this);
                memberValue = lastCompiledConstantValue;
                memberIsInitialized = true;
            }

            lastCompiledMember = new Member{
                Type = memberType,
                TypeName = memberTypeName,
                DimensionCount = memberDimensionCount,
                DimensionList = memberDimensionList,
                Name = memberName,
                Value = memberValue,
                IsInitialized = memberIsInitialized,
                IsDynamicArray = false,
                IsReference = false               
            };

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
                string global = "Global Variable Found : " + lastCompiledMember.ToString();
                AddMessage(global);

                // Globális változó felvétele a lastCompiledMember -ból
                // ...
            }
        }

        public void Visit(FunctionDeclarationsNode node) { VisitChildren(node); }
        public void Visit(FunctionDeclarationNode node)
        {
            // Új függvény kezdése -> név felvétele és mellé egy üres parancsobjektum tömb

            // FunctionType
            node.FunctionType.Accept(this);
            TypeEnum functionType = lastCompiledDataType;
            string functionTypeName = node.Left.Left.Left.Value;
            // lastCompiledDimensionCount, Dimensions, IsDynamic

            // FunctionReference
            bool functionIsReferenceType = false;
            if (node.FunctionReference != null)
                functionIsReferenceType = true;

            // FunctionName
            string functionName = node.GetChild(node.ChildrenCount - 3).Value;

            // Message
            string global = "Function Found : " + functionType + " " + functionName + " () ";
            AddMessage(global);
            // Message

            // FunctionParameterList
            node.FunctionParameterList.Accept(this);

            // FunctionBlock
            node.FunctionBlock.Accept(this);
            
            // Függvény felvétele, adatainak rendezése
            // ...
        }

        public void Visit(FormalParameterListNode node) { VisitChildren(node); }
        public void Visit(FormalParameterNode node)
        {
            // Szépen ki kell gyűjteni. Esetleg Member álltalánosítása és erre is hasznosítása.
            // Member Átnevezése Variable -ra ...
            VisitChildren(node);
        }

        #endregion

        /*Program Structures*/
        #region Program Structures

        public void Visit(BlockNode node) { VisitChildren(node); }
        public void Visit(StatementNode node) { VisitChildren(node); }

        public void Visit(IfStatementNode node)
        {
            // The Count of the conditionJumps pushed in the jumpStack
            conditionCount = 0;

            // IfBranch
            node.IfBranch.Accept(this);

            // ElseIfBranchList
            if( node.ElseIfBranchList != null )
                foreach (IPsiNode child in node.ElseIfBranchList)
                    child.Accept(this);

            // Else Branch
            if(node.ElseBranch != null)
                node.ElseBranch.Accept(this);

            // Set up PC of all conditionJump to the end of the IfStatement
            for (int i = 0; i < conditionCount; i++)
                SetUpTopJumpInJumpStack(0);
        }

        public void Visit(ConditionalBranchNode node)
        {
            // AddCommand( new PushState() );

            node.ConditionalBranchCondition.Accept(this);

            RelativeJumpIfFalse falseConditionJump = new RelativeJumpIfFalse(0);
            AddCommand(falseConditionJump);
            jumpStack.Push(falseConditionJump);

            // IfCore
            node.ConditionalBranchCore.Accept(this);

            // This will jump to the end of the IfStatement
            RelativeJump toEndJump = new RelativeJump(0);
            AddCommand(toEndJump);

            // Pop all Break command from the jumpStack
            System.Collections.Generic.Stack<Jump> tempBreakStack = new System.Collections.Generic.Stack<Jump>();

            while (jumpStack.Count != 0 && jumpStack.Peek().GetType() == (new Break()).GetType() )
                tempBreakStack.Push(jumpStack.Pop());

            SetUpTopJumpInJumpStack(0);

            // Push all Break back to the jumpStack
            while (tempBreakStack.Count != 0) jumpStack.Push(tempBreakStack.Pop());

            // Push the falseConditionJump to set up PC later
            jumpStack.Push(toEndJump);
            conditionCount++;

            // AddCommand( new PopState() );
        }
        
        public void Visit(IfBranchNode node) { VisitChildren(node); }
        public void Visit(ElseIfBranchNode node) { VisitChildren(node); }

        public void Visit(ElseBranchNode node) 
        {
            // AddCommand( new PushState() );

            // ElseCore
            node.Left.Accept(this);

            // AddCommand( new PopState() );
        }

        public void Visit(PForStatementNode node)
        {            
            throw new NotImplementedException("PFor is not implemented yet.");
        }

        public void Visit(ForStatementNode node) 
        {
            // AddCommand(new PushState());

            // ForInitialization
            node.ForInitialization.Accept(this);

            int conditionAddress = ProgramSize;

            // ForCondition
            node.ForCondition.Accept(this);

            // Jump To The end of the ForStatement if the ForCondition is false
            RelativeJumpIfFalse rj = new RelativeJumpIfFalse(0);
            AddCommand(rj);
            jumpStack.Push(rj);

            // ForCore
            node.ForCore.Accept(this);

            // ForUpdate
            node.ForUpdate.Accept(this);

            // Jump To The ForCondition
            AddCommand(new RelativeJump(conditionAddress - ProgramSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType() )
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);
            
            // AddCommand(new PopState());
        }
        
        public void Visit(ForInitializationNode node) { VisitChildren(node); }
        public void Visit(ForConditionNode node) { VisitChildren(node); }
        public void Visit(ForUpdateNode node) { VisitChildren(node); }

        public void Visit(DoStatementNode node) 
        {
            // AddCommand(new PushState());

            int beginingAddress = ProgramSize;

            // This is just a Fake jump, to "cover" the Break Jumps on the upper level
            RelativeJumpIfTrue rj = new RelativeJumpIfTrue(0);
            jumpStack.Push(rj);

            // DoCore
            node.DoCore.Accept(this);

            // DoCondition
            node.DoCondition.Accept(this);

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            // Correction +1 is because, de last jump, what jump to the front of the DoStatement
            while (jumpStack.Peek().GetType() == (new Break()).GetType())
                SetUpTopJumpInJumpStack(1);

            rj.PC = beginingAddress - ProgramSize;
            AddCommand(rj);

            // AddCommand(new PopState());
        }

        public void Visit(WhileStatementNode node) 
        {
            // AddCommand(new PushState());

            int conditionAddress = ProgramSize;

            // WhileCondition
            node.WhileCondition.Accept(this);

            // Jump To The end of the WhileStatement if the WhileCondition if false
            RelativeJumpIfFalse rj = new RelativeJumpIfFalse(0);
            AddCommand(rj);
            jumpStack.Push(rj);

            // WhileCore
            node.WhileCore.Accept(this);

            // Jump to the while condition
            AddCommand(new RelativeJump(conditionAddress - ProgramSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType())
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);

            // AddCommand(new PopState());
        }

        public void Visit(PForEachStatementNode node)
        {
            throw new NotImplementedException("PForEach is not implemented yet.");
        }

        public void Visit(ForEachStatementNode node)
        {
            // AddCommand(new PushState());

            // ForEachRunningVariableType
            node.ForEachRunningVariableType.Accept(this);

            // If this is UserDefined, then use lastCompiledUserDefinedDataTypeName
            TypeEnum forEachRunningVariableType = lastCompiledDataType;
            string forEachRunningVariableTypeName = lastCompiledUserDefinedDataTypeName;

            // IteratorVariableName
            string forEachRunningVariableName = node.ForEachRunningVariableName.Value;

            // IteratorVariableDeclaration
            AddCommand(new Declare(forEachRunningVariableName, forEachRunningVariableType));

            // ForEachCollectionExpression, IteratorInitialization
            node.ForEachCollectionExpression.Accept(this);
            AddCommand(new CallMethod("GetIterator"));            
            string iteratorName = GenerateIteratorName();
            AddCommand(new Initialize(iteratorName, TypeEnum.Iterator));

            int conditionAddress = ProgramSize;

            // ForEachCondition
            AddCommand(new Push(iteratorName, ValueAccessModes.LocalVariableReference));
            AddCommand(new CallMethod("MoveNext"));

            RelativeJumpIfFalse rj = new RelativeJumpIfFalse(0);
            AddCommand(rj);
            jumpStack.Push(rj);

            // ForEachUpdate
            AddCommand(new Push(forEachRunningVariableName, ValueAccessModes.LocalVariableReference));
            AddCommand(new Push(iteratorName, ValueAccessModes.LocalVariable));
            AddCommand(new CallMethod("Current"));
            AddCommand(new Assign(false));

            // ForEachCore
            node.ForEachCore.Accept(this);

            AddCommand(new RelativeJump( conditionAddress - ProgramSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType())
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);

            // AddCommand(new PopState());
        }

        public void Visit(ForEachInitializationNode node) { VisitChildren(node); }
        public void Visit(ForEachCollectionExpressionNode node) { VisitChildren(node); }

        public void Visit(LoopStatementNode node) 
        {
            // AddCommand(new PushState());

            // LoopIteratorInitialization
            node.LoopIteratorInitialization.Accept(this);

            int conditionAddress = ProgramSize;

            // LoopCondition //
            string loopIteratorName = node.LoopIteratorName.Value;
            AddCommand(new Push(loopIteratorName,ValueAccessModes.LocalVariable));

            // LoopLimitExpression
            node.LoopLimitExpression.Accept(this);

            AddCommand(new Compare(Compare.ComparisonModes.LessThanOrEqual));
            // LoopCondition //

            RelativeJumpIfFalse rj = new RelativeJumpIfFalse(0);
            AddCommand(rj);
            jumpStack.Push(rj);

            // LoopCore
            node.LoopCore.Accept(this);

            // LoopUpdate
            AddCommand(new Push(loopIteratorName, ValueAccessModes.LocalVariableReference));
            AddCommand(new Push(loopIteratorName, ValueAccessModes.LocalVariable));
            AddCommand(new Push(new Integer(1)));
            AddCommand(new BinaryOperation(BinaryOperation.Operations.Addition));
            AddCommand(new Assign(false));

            AddCommand(new RelativeJump(conditionAddress - ProgramSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType())
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);

            // AddCommand(new PopState());
        }

        public void Visit(LoopInitializationNode node) { VisitChildren(node); }
        public void Visit(LoopLimitNode node) { VisitChildren(node); }

        public void Visit(ConditionNode node) { VisitChildren(node); }
        public void Visit(CoreNode node) { VisitChildren(node); }

        public void Visit(PDoStatementNode node)
        {
            throw new NotImplementedException("PDo is not implemented yet.");
        }

        public void Visit(AsynStatementNode node) 
        {
            throw new NotImplementedException("Async is not implemented yet.");
        }

        public void Visit(LockStatementNode node)
        {
            throw new NotImplementedException("Lock is not implemented yet.");
        }

        public void Visit(ReturnNode node) 
        {
            // Has or Not Has Return Value
            bool hasReturnValue = false;
            if(node.Left != null)
            {
                node.Left.Accept(this);
                hasReturnValue = true;
            }

            AddCommand(new Return(hasReturnValue));
        }

        public void Visit(BreakNode node) 
        {
            Break b = new Break();
            AddCommand(b);
            jumpStack.Push(b);
        }

        //public void Visit(ContinueNode node) { VisitChildren(node); }

        public void Visit(VariableInitializationNode node)
        {
            // Type
            node.VariableType.Accept(this);

            // If this is UserDefined, than use lastCompiledUserDefinedDataType
            TypeEnum varType = lastCompiledDataType;

            string varTypeName = lastCompiledUserDefinedDataTypeName;
            bool varArrayIsDynamic = isLastCompiledArrayDynamic;
            int varDimensionCount = lastCompiledDimensionCount;

            // Reference
            bool varIsReference = false;
            if (node.VariableReference != null)
                varIsReference = true;

            // Name
            string varName = node.VariableName.Value;

            // Expression
            node.VariableInitialValue.Accept(this);

            // Initialize
            if (varIsReference) throw new PsiCodeGeneratorVisitorException("Reference variable definition/initialization is not supported yet!");
            if (varArrayIsDynamic) throw new PsiCodeGeneratorVisitorException("Dynamic array initialization is not supported yet!");
            if (varType != TypeEnum.UserDefinedType)
            {
                if (varDimensionCount > 0) throw new PsiCodeGeneratorVisitorException("Array initialization is not supported yet!");
                else AddCommand(new Initialize(varName, varType));
            }
            else
            {
                throw new PsiCodeGeneratorVisitorException(string.Format("User defined types is not supported yet! ({0})", varTypeName));
            }
        }

        public void Visit(VariableDeclarationNode node)
        {            
            // Type
            node.VariableType.Accept(this);

            // If this is UserDefined, then use lastCompiledUserDefinedDataTypeName
            TypeEnum varType = lastCompiledDataType;

            string varTypeName = lastCompiledUserDefinedDataTypeName;
            bool varArrayIsDynamic = isLastCompiledArrayDynamic;
            int varDimensionCount = lastCompiledDimensionCount;

            // Name
            string varName = node.VariableName.Value;

            // Declare
            if (varArrayIsDynamic) throw new PsiCodeGeneratorVisitorException("Dynamic array declaration is not supported yet!");
            if (varType != TypeEnum.UserDefinedType)
            {
                if (varDimensionCount > 0)
                {
                    AddCommand(new ArrayDeclare(varName, varType, varDimensionCount));
                }
                else
                {
                    AddCommand(new Declare(varName, varType));
                }
            }
            else
            {
                throw new PsiCodeGeneratorVisitorException(string.Format("User defined types is not supported yet! ({0})", varTypeName));
            }
        }

        #endregion

        /*Operators*/
        #region Operators        

        public void Visit(AssignmentOpNode node)
        {
            if (node.Value == "=")
            {
                isCompilingAssignmentTarget = true;
                node.Left.Accept(this);
                isCompilingAssignmentTarget = false;
                node.Right.Accept(this);
                AddCommand(lastCompiledAssign = new Assign(true));
            }
            else
            {
                // x op= y -> x = x op y //
                isCompilingAssignmentTarget = true;
                node.Left.Accept(this);
                isCompilingAssignmentTarget = false;
                node.Left.Accept(this);
                node.Right.Accept(this);

                switch (node.Value[0])
                {
                    case '+': AddCommand(new BinaryOperation(BinaryOperation.Operations.Addition)); break;
                    case '-': AddCommand(new BinaryOperation(BinaryOperation.Operations.Subtraction)); break;
                    case '*': AddCommand(new BinaryOperation(BinaryOperation.Operations.Multiplication)); break;
                    case '/': AddCommand(new BinaryOperation(BinaryOperation.Operations.Division)); break;                    
                    case '%': AddCommand(new BinaryOperation(BinaryOperation.Operations.Modulo)); break;
                    case '^': AddCommand(new BinaryOperation(BinaryOperation.Operations.Power)); break;
                    case '&': AddCommand(new BinaryOperation(BinaryOperation.Operations.LogicalAnd)); break;
                    case '|': AddCommand(new BinaryOperation(BinaryOperation.Operations.LogicalOr)); break;
                    case '~': AddCommand(new BinaryOperation(BinaryOperation.Operations.LogicalXor)); break;
                    default:
                        throw new UnknownOperatorException(string.Format("Unknown Assign Operator : {0}", node.Value));
                        break;
                }

                AddCommand(lastCompiledAssign = new Assign(true));
            }
        }

        public void Visit(LogicalOrOpNode node)
        {   
            // Left Operand
            node.Left.Accept(this);
            
            // Lazy Jump
            int address = ProgramSize;
            SilentRelativeJumpIfTrue jmp = new SilentRelativeJumpIfTrue(0);
            AddCommand(jmp);
            lazyEvaluationJumpStack.Push(jmp);

            // Right Operand
            node.Right.Accept(this);

            // Logical Or Operator
            AddCommand(new BinaryOperation(BinaryOperation.Operations.LogicalOr));

            lazyEvaluationJumpStack.Pop().PC = ProgramSize - address;
        }

        public void Visit(LogicalAndOpNode node)
        {
            // Left Operand
            node.Left.Accept(this);

            // Lazy Jump
            int address = ProgramSize;
            SilentRelativeJumpIfFalse jmp = new SilentRelativeJumpIfFalse(0);
            AddCommand(jmp);
            lazyEvaluationJumpStack.Push(jmp);

            // Right Operand
            node.Right.Accept(this);

            // Logical And Operator
            AddCommand(new BinaryOperation(BinaryOperation.Operations.LogicalAnd));

            lazyEvaluationJumpStack.Pop().PC = ProgramSize - address;
        }

        public void Visit(EqualityOpNode node)
        {
            // Left Operand
            node.Left.Accept(this);

            // Right Operand
            node.Right.Accept(this);

            // Compare Operation
            switch (node.Value)
            {
                case "==": AddCommand(new Compare(Compare.ComparisonModes.Equal)); break;
                case "!=": AddCommand(new Compare(Compare.ComparisonModes.NotEqual)); break;
                default:
                    throw new UnknownOperatorException(string.Format("Unknown Compare Operator : {0}", node.Value));
                    break;
            }
        }

        public void Visit(RelationOpNode node)
        {            
            // Left Operand
            node.Left.Accept(this);

            // Right Operand
            node.Right.Accept(this);

            // Relation Operation
            switch (node.Value)
            {
                case "<": AddCommand(new Compare(Compare.ComparisonModes.LessThan)); break;
                case "<=": AddCommand(new Compare(Compare.ComparisonModes.LessThanOrEqual)); break;
                case ">": AddCommand(new Compare(Compare.ComparisonModes.GreaterThan)); break;
                case ">=": AddCommand(new Compare(Compare.ComparisonModes.GreaterThanOrEqual)); break;
                default:
                    throw new UnknownOperatorException(string.Format("Unknown Compare Operator : {0}", node.Value));
                    break;
            }
        }

        public void Visit(AdditiveOpNode node)
        {
            bool isUnary = isOperatorUnaryPrefix;
            isOperatorUnaryPrefix = false;

            // Left Operand
            node.Left.Accept(this);

            // Right Operand if Not Unary Negation
            if (!isUnary) node.Right.Accept(this);

            // Additive Operation
            switch (node.Value)
            {
                case "+": AddCommand(new BinaryOperation(BinaryOperation.Operations.Addition)); break;
                case "-":
                    if (isUnary) AddCommand(new UnaryOperation(UnaryOperation.Operations.Negate));
                    else AddCommand(new BinaryOperation(BinaryOperation.Operations.Subtraction));
                    break;
                default:
                    throw new UnknownOperatorException(string.Format("Unknown Additive Operator : {0}", node.Value));
                    break;
            }
        }

        public void Visit(MultiplicativeOpNode node)
        {
            // Left Operand
            node.Left.Accept(this);

            // Right Operand
            node.Right.Accept(this);

            // Additive Operation
            switch (node.Value)
            {
                case "*": AddCommand(new BinaryOperation(BinaryOperation.Operations.Multiplication)); break;
                case "/": AddCommand(new BinaryOperation(BinaryOperation.Operations.Division)); break;
                case "%": AddCommand(new BinaryOperation(BinaryOperation.Operations.Modulo)); break;
                case "^": AddCommand(new BinaryOperation(BinaryOperation.Operations.Power)); break;
                default:
                    throw new UnknownOperatorException(string.Format("Unknown Additive Operator : {0}", node.Value));
                    break;
            }
        }

        public void Visit(UnaryOpNode node)
        {
            if (node.Value == "!")
            {
                /* 
                 * !EXP :
                 * -------------------
                 * 01 Push EXP
                 * 02 Not
                 * 
                */

                // 01 The Operand (EXP)
                VisitChildren(node);

                // 02 LogicalNot Operation
                AddCommand(new UnaryOperation(UnaryOperation.Operations.LogicalNot));
            }
            else if (isOperatorUnaryPrefix)
            {
                /*
                --++--i;
                ->
                ( i = ( i = ( i = ( i - 1 ) + 1 ) - 1 ) );
                */

                /* i
                 * x => { i ( y => { i i 1 - = } ) 1 + = }
                 * 1
                 * -
                 * =
                 */

                /* i
                 * { 
                 *   i 
                 *   { 
                 *     i
                 *     i 1 - =
                 *   }
                 *   1 + = 
                 * }
                 * 1 - =
                 */

                /* 
                 * ( ++EXP | --EXP ) :
                 * -------------------
                 * 01 Push UnaryOperand
                 * 02 Push EXP
                 * 03 ( Push +1 | Push -1 )
                 * 04 Add
                 * 05 Assign
                 * 
                 */

                // 01 The UnaryOperand as Assignment Target
                isCompilingAssignmentTarget = true;
                VisitChildren(node.UnaryOperand);
                isCompilingAssignmentTarget = false;

                // 02 Operand (EXP)
                VisitChildren(node);

                // 03 ( Push +1 | Push -1 )
                if (node.Value == "++")
                {
                    AddCommand(new Push(new Integer(1)));
                }
                else if (node.Value == "--")
                {
                    AddCommand(new Push(new Integer(-1)));
                }
                else
                {
                    throw new UnknownOperatorException(string.Format("Unknown UnaryPrefix Operator : {0}", node.Value));
                }

                // 04 Add Operation
                // 05 Assign Operation with PushBack
                AddCommand
                    (
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Assign(true)
                    );
            }
            else // Postfix Unary Operation
            {
                /* 
                 * ( EXP++ | EXP-- ) :
                 * -------------------
                 * 01 Push EXP
                 * 02 Pop ax -> Duplication step 1. Store
                 * 03 Push ax -> Duplication step 2. Push first
                 * 04 Push ax -> Duplication step 3. Push second
                 * 05 ( Push +1 | Push -1 )
                 * 06 Add
                 * 07 Pop bx -> Store the result
                 * 08 Push UnaryOperand
                 * 09 Push bx -> Push the result
                 * 10 Assign ( Silent )
                 */

                // 01 Operand (EXP)
                VisitChildren(node);

                // Duplicate
                // 02 Pop ax -> Duplication step 1. Store
                AddCommand(new Pop("ax"));

                // 03 Push ax -> Duplication step 2. Push first
                AddCommand(new PushRegister("ax"));

                // 04 Push ax -> Duplication step 3. Push second
                AddCommand(new PushRegister("ax"));

                // 05 Push +1 | Push -1 )
                if (node.Value == "++")
                {
                    AddCommand(new Push(new Integer(1)));
                }
                else if (node.Value == "--")
                {
                    AddCommand(new Push(new Integer(-1)));
                }
                else
                {
                    throw new UnknownOperatorException(string.Format("Unknown UnaryPostfix Operator : {0}", node.Value));
                }

                // 06 Add Operation                
                AddCommand(new BinaryOperation(BinaryOperation.Operations.Addition));

                // 07 Save result
                AddCommand(new Pop("bx"));

                // 08 The UnaryOperand as Assignment Target
                isCompilingAssignmentTarget = true;
                VisitChildren(node.UnaryOperand);
                isCompilingAssignmentTarget = false;

                // 09 Push result
                AddCommand(new PushRegister("bx"));

                // 10 Assign (Silent) Operation
                AddCommand(new Assign(false));
            }
        }

        #endregion

        /*Expressions*/
        #region Expression        

        public void Visit(ExpressionNode node)
        {
            VisitChildren(node);
            if (lastCompiledAssign != null) lastCompiledAssign.PushResult = false;
            lastCompiledAssign = null;
        }
        
        public void Visit(CastNode node)
        {
            // Cast Operand
            node.CastOperand.Accept(this);

            // Cast TypeName
            string castTypeName = node.CastTypeName.Value;
            
            // Cast Operation
            AddCommand(new Cast(TypeEnumFactory.CreateTypeEnum(castTypeName)));
        }

        public void Visit(PrefixUnaryOperationNode node)
        {
            isOperatorUnaryPrefix = true;
            VisitChildren(node);
            isOperatorUnaryPrefix = false;
        }

        public void Visit(SelectorNode node)
        {
            // SelectorList Compile Parameters
            isSelectorsFirstCompile = true;
            node.SelectorList.Reverse();
            foreach (IPsiNode child in node.SelectorList)
                child.Accept(this);

            // SelectorOperand
            node.SelectorOperand.Accept(this);

            // SelectorList Compile Selectors
            isSelectorsFirstCompile = false;
            node.SelectorList.Reverse();
            foreach (IPsiNode child in node.SelectorList)
                child.Accept(this);
        }

        public void Visit(MemberSelectNode node)
        {
            if (!isSelectorsFirstCompile)
            {
                // MemberName
                string memberName = node.Left.Value;

                // MemberSelect
                AddCommand(new Select(memberName));
            }
        }

        public void Visit(MemberFunctionCallNode node)
        {
            if (isSelectorsFirstCompile)
            {
                // Arguments
                foreach (IPsiNode child in node.MemberFunctionArgumentList)
                    child.Accept(this);
            }
            else
            {
                // Name
                string memberFunctionName = node.MemberFunctionName.Value;

                // MemberFunctionCall
                AddCommand(new CallMethod(memberFunctionName));
            }
        }

        public void Visit(FunctionCallNode node)
        {
            // Name
            string functionName = node.FunctionName.Value;
            
            // Arguments
            foreach (IPsiNode child in node.FunctionArgumentList)
                child.Accept(this);

            // FunctionCall
            AddCommand(new Call(functionName));
        }

        public void Visit(ArgumentsNode node) { VisitChildren(node); }
        public void Visit(IndexingNode node)
        {
            if (isSelectorsFirstCompile)
            {
                // Concret Indexis
                VisitChildren(node);
            }
            else
            {
                // Dimension Number
                int dim = node.Children.Count;

                // Indexing
                if (dim > 1)
                    throw new PsiCodeGeneratorVisitorException("More than one dimension array indexing is not supported yet!");
                else
                    AddCommand(new Indexing());
            }
        }

        public void Visit(DimensionsNode node)
        {
            lastCompiledDimensionCount = node.ChildrenCount;
            for (int i = 0; i < node.ChildrenCount; i++)
                node.Children[i].Accept(this);

            isLastCompiledArrayDynamic = false;
        }

        public void Visit(ConstantDimensionsNode node)
        {
            lastCompiledDimensionList = new List<int>();
            for (int i = 0; i < node.ChildrenCount; i++)
                lastCompiledDimensionList.Add(Convert.ToInt32(SplitQuotes(node.Children[i].Value)));
            lastCompiledDimensionCount = lastCompiledDimensionList.Count;
        }

        public void Visit(DimensionMarkerNode node)
        {
            lastCompiledDimensionCount = node.ChildrenCount - 2;
            lastCompiledDimensionList = new List<int>();
            isLastCompiledArrayDynamic = true;
        }

        #endregion

        /*Identifier*/
        #region Identifier

        public void Visit(IdentifierNode node) 
        {
            AddCommand(new Push(node.Value, isCompilingAssignmentTarget ? ValueAccessModes.LocalVariableReference : ValueAccessModes.LocalVariable));
        }

        #endregion

        /*Literals*/
        #region Literals

        public void Visit(CharLiteralNode node)
        {
            char charChar = ' ';
            string strChar = SplitQuotes(node.Value);
            switch (strChar)
            {
                case "\\n": charChar = '\n'; break; // Milegyne itt, hgyo jólegyen ?
                case "\\\'": charChar = '\''; break;
                case "\\\"": charChar = '\"'; break;
                case "\\\\": charChar = '\\'; break;
                default: charChar = strChar[0]; break;
            }
            lastCompiledConstantValue = ValueFactory.Create(charChar);
            if (addToProgram) AddCommand(new Push(lastCompiledConstantValue));
            addToProgram = true;
        }

        public void Visit(StringLiteralNode node)
        {
            string str = SplitQuotes(node.Value).Replace("\\n", "\r\n").Replace("\\\'", "\'").Replace("\\\"", "\"").Replace("\\\\", "\\");            
            lastCompiledConstantValue = ValueFactory.Create(Convert.ToString(str));
            if (addToProgram) AddCommand(new Push(lastCompiledConstantValue));
            addToProgram = true;
        }

        public void Visit(IntLiteralNode node)
        {
            lastCompiledConstantValue = ValueFactory.Create(Convert.ToInt32(SplitQuotes(node.Value)));
            if (addToProgram) AddCommand(new Push(lastCompiledConstantValue));
            addToProgram = true;
        }

        public void Visit(DecimalLiteralNode node)
        {
            string str = node.Value.Replace(".", ",").Replace("m", "").Replace("M", "").Replace("d", "").Replace("D", "");
            if (str[0] == '.')
                str = "0" + str;
            if (str[str.Length - 1] == '.')
                str += "0";

            lastCompiledConstantValue = ValueFactory.Create(Convert.ToDecimal(str));
            if (addToProgram) AddCommand(new Push(lastCompiledConstantValue));
            addToProgram = true;
        }

        public void Visit(BoolLiteralNode node)
        {
            string constant  = SplitQuotes(node.Value);
            bool l = Convert.ToBoolean(constant);
            lastCompiledConstantValue = ValueFactory.Create(l);
            if (addToProgram) AddCommand(new Push(lastCompiledConstantValue));
            addToProgram = true;
        }

        public void Visit(NullLiteralNode node)
        {
            AddCommand(new Push(new Null()));
        }

        public void Visit(InfinityLiteralNode node)
        {
            // ???
            VisitChildren(node);
        }

        #endregion

        /*Types*/
        #region Types

        public void Visit(TypeNode node) { VisitChildren(node); }
        public void Visit(DataTypeNode node)
        {
            lastCompiledDataType = TypeEnumFactory.CreateTypeEnum(node.Left.Value);
            lastCompiledUserDefinedDataTypeName = node.Left.Value;

            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();
        }

        public void Visit(DataTypeNameNode node) { VisitChildren(node); }
        public void Visit(ReferenceNode node) { VisitChildren(node); }

        #endregion

        #endregion
    }
}
