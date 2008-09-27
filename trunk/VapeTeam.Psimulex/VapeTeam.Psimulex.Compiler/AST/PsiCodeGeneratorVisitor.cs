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

        /// <summary>
        /// Global or Struct Member Variables.
        /// </summary>
        private Member lastCompiledMember;

        private TypeEnum lastCompiledDataType;
        private string lastCompiledUserDefinedDataType;

        private int lastCompiledDimensionCount;
        private List<int> lastCompiledDimensionList;

        private bool addToProgram;
        private BaseType lastCompiledConstantValue;

        private bool lastCompiledArrayIsDynamic;

        private Assign lastCompiledAssign;

        private bool operatorIsPrefixUnary;

        private bool isCompilingAssignmentTarget;

        private System.Collections.Generic.Stack<Jump> lazyEvaluationJumpStack;
        private System.Collections.Generic.Stack<Jump> jumpStack;

        private void InitHelpers()
        {
            lastCompiledMember = new Member();

            lastCompiledDataType = TypeEnum.Undefined;
            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();

            addToProgram = true;
            lastCompiledConstantValue = null;

            lastCompiledArrayIsDynamic = false;
            lastCompiledAssign = null;

            operatorIsPrefixUnary = false;

            lazyEvaluationJumpStack = new System.Collections.Generic.Stack<Jump>();
            jumpStack = new System.Collections.Generic.Stack<Jump>();
        }

        private string SplitQuotes(string s)
        {
            if (s[0] == '\'' || s[0] == '\"')
                return s.Substring(1, s.Length - 2);
            return s;
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
            bool memberIsInitialised = false;

            // MemberInitiaValue
            BaseType memberValue = null;
            if (node.MemberInitialValue != null)
            {
                addToProgram = false;
                node.MemberInitialValue.Accept(this);
                memberValue = lastCompiledConstantValue;
                memberIsInitialised = true;
            }

            lastCompiledMember = new Member(
                memberType,
                memberTypeName,
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

        public void Visit(BlockNode node) { VisitChildren(node); }
        public void Visit(StatementNode node) { VisitChildren(node); }

        public void Visit(IfStatementNode node)
        {
            // IfBranch
            node.IfBranch.Accept(this);

            // ElseIfBranchList
            foreach (IPsiNode child in node.ElseIfBranchList)
                child.Accept(this);

            // Else Branch
            node.ElseBranch.Accept(this);
        }

        public void Visit(IfBranchNode node) { VisitChildren(node); }
        public void Visit(ElseIfBranchNode node) { VisitChildren(node); }
        public void Visit(ElseBranchNode node) 
        {
            // AddCommand( new PushState() );

            node.

            // AddCommand( new PopState() );
        }

        public void Visit(PForStatementNode node)
        { 
            VisitChildren(node);
            throw new NotImplementedException("PFor not implemented yet.");
        }

        public void Visit(ForStatementNode node) 
        {
            // Itt mentjük el az állapotot ( Simulexben Volt És most ? )
            // AddCommand(new PushState());

            // ForInitialization
            node.ForInitialization.Accept(this);

            int conditionAddress = ProgramSize;

            // ForCondition
            node.ForCondition.Accept(this);

            RelativeJumpIfFalse dj = new RelativeJumpIfFalse(0);
            AddCommand(dj);
            jumpStack.Push(dj);

            // ForCore
            node.ForCore.Accept(this);

            // ForUpdate
            node.ForUpdate.Accept(this);

            // Jump To The ForCondition
            AddCommand(new RelativeJump(conditionAddress - ProgramSize));

            // A blokkban előforduló breakokat címzi a blokk utánra
            while (jumpStack.Peek().GetType() == (new Break()).GetType() && !(jumpStack.Peek() as Break).IsSettedUp)
            {
                Break br = (jumpStack.Pop() as Break);
                br.JumpSize = ProgramSize - GetCommandIndex(br);
            }

            Jump jmp = jumpStack.Pop();
            jmp.PC = ProgramSize - GetCommandIndex(jmp);

            // Itt állítjuk visza az állípotot és takarítunk ( Simulexben Volt És most ? )
            // AddCommand(new PopState());
        }
        public void Visit(ForInitializationNode node) { VisitChildren(node); }
        public void Visit(ForUpdateNode node) { VisitChildren(node); }

        public void Visit(DoStatementNode node) { VisitChildren(node); }
        public void Visit(WhileStatementNode node) { VisitChildren(node); }
        public void Visit(PForEachStatementNode node) { VisitChildren(node); }
        public void Visit(ForEachStatementNode node) { VisitChildren(node); }
        public void Visit(ForEachControlNode node) { VisitChildren(node); }
        public void Visit(LoopStatementNode node) { VisitChildren(node); }
        public void Visit(LoopControlNode node) { VisitChildren(node); }
        public void Visit(ConditionNode node) { VisitChildren(node); }
        public void Visit(CoreNode node) { VisitChildren(node); }
        public void Visit(PDoStatementNode node) { VisitChildren(node); }
        public void Visit(AsynStatementNode node) { VisitChildren(node); }
        public void Visit(LockStatementNode node) { VisitChildren(node); }
        public void Visit(ReturnNode node) { VisitChildren(node); }

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

            string varTypeName = lastCompiledUserDefinedDataType;
            bool varArrayIsDynamic = lastCompiledArrayIsDynamic;
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

            // If this is UserDefined, then use lastCompiledUserDefinedDataType
            TypeEnum varType = lastCompiledDataType;

            string varTypeName = lastCompiledUserDefinedDataType;
            bool varArrayIsDynamic = lastCompiledArrayIsDynamic;
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
            bool isUnary = operatorIsPrefixUnary;
            operatorIsPrefixUnary = false;

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
            else if (operatorIsPrefixUnary)
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
            operatorIsPrefixUnary = true;
            VisitChildren(node);
            operatorIsPrefixUnary = false;
        }

        public void Visit(SelectorNode node)
        {
            // SelectorOperand
            node.SelectorOperand.Accept(this);

            // SelectorList
            foreach (IPsiNode child in node.SelectorList)
                child.Accept(this);
        }

        public void Visit(MemberSelectNode node)
        {
            // MemberName
            string memberName = node.Left.Value;

            // MemberSelect
            AddCommand(new Select(memberName));
        }

        public void Visit(MemberFunctionCallNode node)
        {
            // Name
            string memberFunctionName = node.MemberFunctionName.Value;

            // Arguments
            foreach (IPsiNode child in node.MemberFunctionArgumentList)
                child.Accept(this);

            // MemberFunctionCall
            AddCommand(new CallMethod(memberFunctionName));
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
            // Concret Indexis
            VisitChildren(node);

            // Dimension Number
            int dim = node.Children.Count;

            // Indexing
            if(dim > 1)
                throw new PsiCodeGeneratorVisitorException("More than one dimension array indexing is not supported yet!");
            else
                AddCommand(new Indexing());
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
                lastCompiledDimensionList.Add(Convert.ToInt32(SplitQuotes(node.Children[i].Value)));
            lastCompiledDimensionCount = lastCompiledDimensionList.Count;
        }

        public void Visit(DimensionMarkerNode node)
        {
            lastCompiledDimensionCount = node.ChildrenCount - 2;
            lastCompiledDimensionList = new List<int>();
            lastCompiledArrayIsDynamic = true;
        }

        #endregion

        /*Identifier*/
        public void Visit(IdentifierNode node) 
        {
            AddCommand(new Push(node.Value, 
                isCompilingAssignmentTarget ? ValueAccessModes.LocalVariableReference : ValueAccessModes.LocalVariable));
        }

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
            // ???
            VisitChildren(node);
        }

        public void Visit(InfinityLiteralNode node)
        {
            // ???
            VisitChildren(node);
        }

        #endregion


        /*Types*/
        public void Visit(TypeNode node) { VisitChildren(node); }
        public void Visit(DataTypeNode node)
        {
            lastCompiledDataType = TypeEnumFactory.CreateTypeEnum(node.Left.Value);
            lastCompiledUserDefinedDataType = node.Left.Value;

            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();
        }

        /**/public void Visit(DataTypeNameNode node) { VisitChildren(node); }
        /**/public void Visit(ReferenceNode node) { VisitChildren(node); }

        #endregion
    }
}
