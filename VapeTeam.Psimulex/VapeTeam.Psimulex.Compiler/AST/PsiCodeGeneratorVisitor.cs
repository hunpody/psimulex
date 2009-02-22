using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.Utils;
using System.IO;
using VapeTeam.Psimulex.Compiler.Info;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public class PsiCodeGeneratorVisitor : PsiVisitor
    {
        #region PsiBuilderVisitor Members

        /*Input*/
        #region Input

        private ProgramBuilder Program { get { return DTO.Program; } }
        private int ProgramSize { get { return DTO.Program.Program.CommandList.Count; } }
        private int CurrentFunctionSize { get { return isCurrentCompiledTheMainProgram ? ProgramSize : currentUserDefinedFunctionInfo.Function.Commands.Count; } }

        public PsiCodeGeneratorVisitor(CompilationUnit cu, CompilerDTO dto)
            : base (cu,dto)
        {
            InitHelpers();
        }

        #endregion       

        /*Program build Helpers*/
        #region Program build Helpers

        public void AddCommandBefore(ICommand commandToAdd, ICommand before)
        {
            if (isCurrentCompiledTheMainProgram)
                Program.Program.CommandList.Insert(Program.Program.CommandList.IndexOf(before), commandToAdd);
            else
                currentUserDefinedFunctionInfo.Function.Commands.Insert(currentUserDefinedFunctionInfo.Function.Commands.IndexOf(before), commandToAdd);
        }

        public void AddCommand(ICommand command)
        {
            if (isCurrentCompiledTheMainProgram)
                Program.Add(command);
            else
                currentUserDefinedFunctionInfo.Function.Commands.Add(command);
        }

        public void AddCommand(params ICommand[] commands)
        {
            if (isCurrentCompiledTheMainProgram)
                Program.Add(commands);
            else
                foreach (var cmd in commands)
                    currentUserDefinedFunctionInfo.Function.Commands.Add(cmd);
        }

        public int GetCommandIndex(CommandBase cmd)
        {
            if (isCurrentCompiledTheMainProgram)
                return Program.GetCommandIndex(cmd);
            else
                return currentUserDefinedFunctionInfo.Function.Commands.GetCommandIndex(cmd);
        }

        public void SetLastCompiledConstant(BaseType value)
        {
            lastCompiledConstantValue = value;
            if (addToProgram)
                AddCommand(new Push(lastCompiledConstantValue));
            addToProgram = true;
        }

        #endregion        

        /*Highlighter, Stepping Helpers*/
        #region Highlighter, Stepping Helpers

        private void RegisterIntervalChange(IPsiNode node)
        {
            Interval range = SourceInfoUtils.CreateInterval(node, Source, lineLengthList, SourceFileName);

            // If lastCompiledUserDefinedFunction == null, than we compile, the main program
            if (!isCurrentCompiledTheMainProgram && currentUserDefinedFunctionInfo != null)
            {
                CommandPositionChanges[currentUserDefinedFunctionInfo.Function.Name,
                    currentUserDefinedFunctionInfo.Function.Commands.Count] = range;
            }
            else
            {
                CommandPositionChanges["", ProgramSize] = range;
            }
        }
        
        #endregion

        /*Compile Helpers*/
        #region Compiler Helpers

        private bool addToProgram;
        private Assign lastCompiledAssign;

        private bool isOperatorUnaryPrefix;
        private bool isCompilingAssignmentTarget;
        private bool isSelectorsFirstCompile;
        private bool isCurrentCompiledTheMainProgram;

        private System.Collections.Generic.Stack<Jump> lazyEvaluationJumpStack;
        private System.Collections.Generic.Stack<Jump> jumpStack;

        private int conditionCount;
        private List<int> lineLengthList;

        private GlobalVariableInfo currentGlobalVariableInfo;
        private UserDefinedFunctionInfo currentUserDefinedFunctionInfo;

        private void InitHelpers()
        {
            addToProgram = true;
            lastCompiledAssign = null;

            isOperatorUnaryPrefix = false;
            isCompilingAssignmentTarget = false;
            isSelectorsFirstCompile = true;
            isCurrentCompiledTheMainProgram = true;

            lazyEvaluationJumpStack = new System.Collections.Generic.Stack<Jump>();
            jumpStack = new System.Collections.Generic.Stack<Jump>();

            conditionCount = 0;
            lineLengthList = SourceInfoUtils.FindLineLengths(Source);

            currentGlobalVariableInfo = null;
            currentUserDefinedFunctionInfo = null;
        }

        private string GenerateIteratorName()
        {
            return string.Format("iterator_{0}", DateTime.Now.ToShortTimeString().Replace(":", "_").Replace(" ", "_").Replace(".", "_"));
        }

        private void SetUpTopJumpInJumpStack(int corrigation)
        {
            Jump jmp = jumpStack.Pop();
            jmp.PC = CurrentFunctionSize - GetCommandIndex(jmp) + corrigation;
        }

        private bool IsCurrentCompilationUnitTheLastErrorFree()
        {
            int index = DTO.CompilationUnitList.IndexOf(CurrentCompilationUnit);

            if(index == DTO.CompilationUnitList.Count - 1)
                return true;

            if (DTO.CompilerMessages.AntlrErrors.Find(x =>
                x.Interval.FileName == DTO.CompilationUnitList[index + 1].FileName
               ) == null)
            {
                return true;
            }

            return false;
        }

        private void SetCurrentGlobalVariableInfo(string globalVariableName)
        {
            currentGlobalVariableInfo = DTO.GlobalVariableInfoList.Find(global => global.Name == globalVariableName);
        }

        private void SetCurrentUserDefinedFunctionInfo(string name, int parameterCount)
        {
            currentUserDefinedFunctionInfo = DTO.UserDefinedFunctionInfoList.Find(func =>
                func.Name == name && func.ParameterCount == parameterCount);
        }

        #endregion         

        #endregion

        #region IPsiVisitor Members

        /*High Level Tree Nodes*/
        #region High Level Tree Nodes

        public override void Visit(CompilationUnitNode node)
        {
            DTO.AddInformation(string.Format("Code generation started at {0}",
                DateTime.Now.ToLongTimeString()), node.NodeValueInfo, SourceFileName);

            base.Visit(node);
        }

        public override void Visit(SimpleProgramNode node)
        {
            isCurrentCompiledTheMainProgram = true;
            VisitChildren(node);
        }

        public override void Visit(MultiFuncionalProgramNode node)
        {
            // Compile the Functions
            isCurrentCompiledTheMainProgram = false;

            node.ProgramGlobalVariableDeclarations.Accept(this);
            node.ProgramFunctionDeclarations.Accept(this);            

            isCurrentCompiledTheMainProgram = true;

            // Generate a main function call if this is the last ANTLR Error free CompilationUnit
            if (IsCurrentCompilationUnitTheLastErrorFree() && DTO.UserDefinedFunctionInfoList.Count != 0)
            {
                string mainFunctionName = "main";
                int mainFunctionArity = 0;

                // Check Existance of Main() function.
                if (DTO.UserDefinedFunctionInfoList.Find(func =>
                    func.Name.ToLower() == mainFunctionName.ToLower() &&
                    func.ParameterCount == mainFunctionArity)
                    != null)
                {
                    mainFunctionName = DTO.UserDefinedFunctionInfoList[0].Name;
                    mainFunctionArity = DTO.UserDefinedFunctionInfoList[0].ParameterCount;
                }

                // Generate a main function call.
                // This will be the work of the VurtualMachine
                AddCommand(new Call(mainFunctionName, mainFunctionArity));
                AddCommand(new Return(false));
            }
        }

        public override void Visit(ImportDeclarationNode node)
        {
            // Nothing to do !
            return;
        }

        public override void Visit(TypeDeclarationNode node)
        {            
            // Nothing to do !
            return;
        }

        public override void Visit(MemberDeclarationNode node)
        {
            // MemberName
            string memberName = node.MemberName.Value;

            // Set current global variable info
            SetCurrentGlobalVariableInfo(memberName);
        }

        public override void Visit(GlobalVariableDeclarationsNode node)
        {
            RegisterIntervalChange(node);

            foreach (IPsiNode child in node.Children)
            {
                child.Accept(this);

                //CheckGlobalVariableName(lastCompiledMember.Name, node.NodeValueInfo);

                // Add Global Variable declaration or Initialization to the progrem
                // If NOT added already! (IsCompiled)
                if (!currentGlobalVariableInfo.IsCompiled)
                {
                    if (currentGlobalVariableInfo.IsInitialised)
                        AddCommand(
                            new Push(currentGlobalVariableInfo.Value),
                            new Initialize(currentGlobalVariableInfo.Name, currentGlobalVariableInfo.Type.TypeEnum)
                            );
                    else
                        if (currentGlobalVariableInfo.Type.Dimensions.Count > 0)
                            AddCommand(
                                new ArrayDeclare(
                                    currentGlobalVariableInfo.Name,
                                    currentGlobalVariableInfo.Type.TypeEnum,
                                    currentGlobalVariableInfo.Type.Dimensions.Count
                                    )
                                );
                        else
                            AddCommand(new Declare(currentGlobalVariableInfo.Name, currentGlobalVariableInfo.Type.TypeEnum));
                }
            }
        }

        public override void Visit(FunctionDeclarationNode node)
        {
            // FunctionName
            string functionName = node.FunctionName.Value;

            // Function Parameter Count
            int functionParameterCount = node.FunctionParameterList.Children.Count;

            // Set current User defined function info
            SetCurrentUserDefinedFunctionInfo(functionName, functionParameterCount);

            if (!currentUserDefinedFunctionInfo.IsCompiled)
            {
                // FunctionBlock
                node.FunctionBlock.Accept(this);

                // Generate auto return if needed
                if (currentUserDefinedFunctionInfo.Function.Commands.Count == 0
                    ||
                    currentUserDefinedFunctionInfo.Function.Commands
                    [
                    currentUserDefinedFunctionInfo.Function.Commands.Count - 1
                    ].GetType() != typeof(Return))

                    currentUserDefinedFunctionInfo.Function.Commands.Add(new Return(false));
            }
        }

        #endregion

        /*Program Structures*/
        #region Program Structures

        public override void Visit(IfStatementNode node)
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

        public override void Visit(ConditionalBranchNode node)
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

        public override void Visit(ElseBranchNode node) 
        {
            // AddCommand( new PushState() );

            // ElseCore
            node.Left.Accept(this);

            // AddCommand( new PopState() );
        }

        public override void Visit(PForStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "PFor is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public override void Visit(ForStatementNode node) 
        {
            AddCommand(new PushScope());

            // ForInitialization
            node.ForInitialization.Accept(this);

            int conditionAddress = CurrentFunctionSize;

            // ForCondition
            node.ForCondition.Accept(this);

            // Jump To The end of the ForStatement if the ForCondition is false
            RelativeJumpIfFalse rj = new RelativeJumpIfFalse(0);
            AddCommand(rj);
            jumpStack.Push(rj);

            // ForCore
            AddCommand(new PushScope());
            node.ForCore.Accept(this);
            AddCommand(new PopScope());

            // ForUpdate
            node.ForUpdate.Accept(this);

            // Jump To The ForCondition
            AddCommand(new RelativeJump(conditionAddress - CurrentFunctionSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (typeof(Break)))
            {
                AddCommandBefore(new PopScope(), jumpStack.Peek());
                SetUpTopJumpInJumpStack(0);
            }

            SetUpTopJumpInJumpStack(0);

            AddCommand(new PopScope());
        }

        public override void Visit(ForInitializationNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public override void Visit(ForConditionNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public override void Visit(ForUpdateNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public override void Visit(DoStatementNode node)
        {
            // AddCommand(new PushState());

            int beginingAddress = CurrentFunctionSize;

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

            rj.PC = beginingAddress - CurrentFunctionSize;
            AddCommand(rj);

            // AddCommand(new PopState());
        }

        public override void Visit(WhileStatementNode node) 
        {
            // AddCommand(new PushState());

            int conditionAddress = CurrentFunctionSize;

            // WhileCondition
            node.WhileCondition.Accept(this);

            // Jump To The end of the WhileStatement if the WhileCondition if false
            RelativeJumpIfFalse rj = new RelativeJumpIfFalse(0);
            AddCommand(rj);
            jumpStack.Push(rj);

            // WhileCore
            node.WhileCore.Accept(this);

            // Jump to the while condition
            AddCommand(new RelativeJump(conditionAddress - CurrentFunctionSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType())
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);

            // AddCommand(new PopState());
        }

        public override void Visit(PForEachStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "PForEach is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public override void Visit(ForEachStatementNode node)
        {
            // AddCommand(new PushState());

            RegisterIntervalChange(node.ForEachInitialization);

            // ForEachRunningVariableType
            node.ForEachRunningVariableType.Accept(this);

            // If this is UserDefined, then use lastCompiledUserDefinedDataTypeName
            TypeEnum forEachRunningVariableType = lastCompiledDataType;
            string forEachRunningVariableTypeName = lastCompiledDataTypeName;

            // IteratorVariableName
            string forEachRunningVariableName = node.ForEachRunningVariableName.Value;

            // Check variable name
            //CheckAndAddLocalVariableName(forEachRunningVariableName, node.NodeValueInfo);

            // IteratorVariableDeclaration
            AddCommand(new Declare(forEachRunningVariableName, forEachRunningVariableType));

            // ForEachCollectionExpression, IteratorInitialization
            node.ForEachCollectionExpression.Accept(this);
            AddCommand(new CallMethod("GetIterator"));            
            string iteratorName = GenerateIteratorName();
            AddCommand(new Initialize(iteratorName, TypeEnum.Iterator));

            int conditionAddress = CurrentFunctionSize;

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

            AddCommand(new RelativeJump( conditionAddress - CurrentFunctionSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType())
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);

            // AddCommand(new PopState());
        }

        public override void Visit(ForEachInitializationNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public override void Visit(ForEachCollectionExpressionNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public override void Visit(LoopStatementNode node) 
        {
            // AddCommand(new PushState());

            // LoopIteratorInitialization
            node.LoopIteratorInitialization.Accept(this);

            int conditionAddress = CurrentFunctionSize;

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

            AddCommand(new RelativeJump(conditionAddress - CurrentFunctionSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType())
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);

            // AddCommand(new PopState());
        }

        public override void Visit(LoopInitializationNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public override void Visit(LoopLimitNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public override void Visit(ConditionNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public override void Visit(PDoStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "PDo is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public override void Visit(AsynStatementNode node) 
        {
            AddError(CompilerErrorCode.NotImplemented, "Async is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public override void Visit(LockStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "Lock is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public override void Visit(ReturnStatementNode node)
        {             
            RegisterIntervalChange(node);

            // Has or Not Has Return Value
            bool hasReturnValue = false;
            if(node.ReturnValue != null)
            {
                node.ReturnValue.Accept(this);
                hasReturnValue = true;
            }

            AddCommand(new Return(hasReturnValue));
        }

        public override void Visit(BreakNode node) 
        {
            RegisterIntervalChange(node);

            Break b = new Break();
            AddCommand(b);
            jumpStack.Push(b);
        }

        public override void Visit(ExpressionStatementNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public override void Visit(VariableDeclarationStatementNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public override void Visit(VariableInitializationNode node)
        {
            // Type
            node.VariableType.Accept(this);

            // If this is UserDefined, than use lastCompiledUserDefinedDataType
            TypeEnum varType = lastCompiledDataType;

            string varTypeName = lastCompiledDataTypeName;
            int varDimensionCount = lastCompiledDimensionCount;

            // Reference
            bool varIsReference = false;
            if (node.VariableReference != null)
                varIsReference = true;

            // Name
            string varName = node.VariableName.Value;

            // Check variable name
            //CheckAndAddLocalVariableName(varName, node.NodeValueInfo);

            // Initialize
            if (varType != TypeEnum.UserDefinedType)
            {
                if (varDimensionCount > 0)
                {
                    AddCommand(new ArrayDeclare(varName, varType, varDimensionCount));
                    AddCommand(new Push(varName, ValueAccessModes.LocalVariableReference));

                    // Expression
                    node.VariableInitialValue.Accept(this);
                    
                    AddCommand(new Assign(false));
                }
                else
                {
                    // Expression
                    node.VariableInitialValue.Accept(this);

                    var init = new Initialize(varName, varType);
                    init.IsReference = varIsReference;
                    AddCommand(init);
                }
            }
            else
            {
                AddError(CompilerErrorCode.Custom, string.Format("User defined type initialization is not supported yet! ({0})", varTypeName), node.NodeValueInfo);
            }
        }

        public override void Visit(VariableDeclarationNode node)
        {
            RegisterIntervalChange(node);

            // Type
            node.VariableType.Accept(this);

            // If this is UserDefined, then use lastCompiledUserDefinedDataTypeName
            TypeEnum varType = lastCompiledDataType;

            string varTypeName = lastCompiledDataTypeName;
            int varDimensionCount = lastCompiledDimensionCount;

            // Name
            string varName = node.VariableName.Value;

            // Check variable name
            //CheckAndAddLocalVariableName(varName, node.NodeValueInfo);

            // Declare
            if (varType != TypeEnum.Undefined)
            {
                if (varDimensionCount > 0)
                    AddCommand(new ArrayDeclare(varName, varType, varDimensionCount));
                else
                    AddCommand(new Declare(varName, varType));
            }
            else
            {
                //AddError(CompilerErrorCode.Custom, string.Format("User defined types is not supported yet! ({0})", varTypeName), node.NodeValueInfo);
                if (varDimensionCount > 0)
                {    //AddCommand(new ArrayDeclare(varName, TypeEnum.UserDefinedType, varDimensionCount));
                    AddError(CompilerErrorCode.Custom, string.Format("User defined array types is not supported yet! ({0})", varTypeName), node.NodeValueInfo);
                }
                else
                {
                    var ti =  new TypeIdentifier
                    {
                        TypeEnum = TypeEnum.UserDefinedType,
                        TypeName = varTypeName,
                        UserDefinedType = DTO.Program.Program.GetUserDefinedType(varTypeName)
                    };

                    AddCommand(new Declare(varName, ti));
                }
            }
        }

        #endregion

        /*Operators*/
        #region Operators        

        public override void Visit(AssignmentOpNode node)
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
                        AddError(CompilerErrorCode.Custom, string.Format("Unknown Assign Operator : {0}", node.Value), node.NodeValueInfo);
                        break;
                }

                AddCommand(lastCompiledAssign = new Assign(true));
            }
        }

        public override void Visit(LogicalOrOpNode node)
        {   
            // Left Operand
            node.Left.Accept(this);
            
            // Lazy Jump
            int address = CurrentFunctionSize;
            SilentRelativeJumpIfTrue jmp = new SilentRelativeJumpIfTrue(0);
            AddCommand(jmp);
            lazyEvaluationJumpStack.Push(jmp);

            // Right Operand
            node.Right.Accept(this);

            // Logical Or Operator
            AddCommand(new BinaryOperation(BinaryOperation.Operations.LogicalOr));

            lazyEvaluationJumpStack.Pop().PC = CurrentFunctionSize - address;
        }

        public override void Visit(LogicalAndOpNode node)
        {
            // Left Operand
            node.Left.Accept(this);

            // Lazy Jump
            int address = CurrentFunctionSize;
            SilentRelativeJumpIfFalse jmp = new SilentRelativeJumpIfFalse(0);
            AddCommand(jmp);
            lazyEvaluationJumpStack.Push(jmp);

            // Right Operand
            node.Right.Accept(this);

            // Logical And Operator
            AddCommand(new BinaryOperation(BinaryOperation.Operations.LogicalAnd));

            lazyEvaluationJumpStack.Pop().PC = CurrentFunctionSize - address;
        }

        public override void Visit(EqualityOpNode node)
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Compare Operator : {0}", node.Value), node.NodeValueInfo);
                    break;
            }
        }

        public override void Visit(RelationOpNode node)
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Compare Operator : {0}", node.Value), node.NodeValueInfo);
                    break;
            }
        }

        public override void Visit(AdditiveOpNode node)
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Additive Operator : {0}", node.Value), node.NodeValueInfo);
                    break;
            }
        }

        public override void Visit(MultiplicativeOpNode node)
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Additive Operator : {0}", node.Value), node.NodeValueInfo);
                    break;
            }
        }

        public override void Visit(UnaryOpNode node)
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
                bool pushResult = true;
                if (node.Parent.Type == NodeType.PrefixUnaryOperation)
                {
                    if (node.Parent.Parent.Type == NodeType.Expression)
                        if (node.Parent.Parent.Parent.Type == NodeType.ForUpdate ||
                            node.Parent.Parent.Parent.Type == NodeType.ExpressionStatement)
                            pushResult = false;
                }
                else
                {
                    if (node.Parent.Type == NodeType.Expression)
                        if (node.Parent.Parent.Type == NodeType.ForUpdate ||
                            node.Parent.Parent.Type == NodeType.ExpressionStatement)
                            pushResult = false;
                }




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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown UnaryPrefix Operator : {0}", node.Value), node.NodeValueInfo);
                }

                // 04 Add Operation
                // 05 Assign Operation with PushBack
                AddCommand
                    (
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Assign(pushResult)
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

                // 2008.11.22. BUG! Leaks the runstack. Should be removed but some tests fail.
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown UnaryPostfix Operator : {0}", node.Value), node.NodeValueInfo);
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

        public override void Visit(ExpressionNode node)
        {
            VisitChildren(node);
            if (lastCompiledAssign != null) lastCompiledAssign.PushResult = false;
            lastCompiledAssign = null;
        }

        public override void Visit(CastNode node)
        {
            // Cast Operand
            node.CastOperand.Accept(this);

            // Cast TypeName
            string castTypeName = node.CastTypeName.Value;
            
            // Cast Operation
            AddCommand(new Cast(TypeEnumFactory.CreateTypeEnum(castTypeName)));
        }

        public override void Visit(PrefixUnaryOperationNode node)
        {
            isOperatorUnaryPrefix = true;
            VisitChildren(node);
            isOperatorUnaryPrefix = false;
        }

        public override void Visit(SelectorNode node)
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

        public override void Visit(MemberSelectNode node)
        {
            if (!isSelectorsFirstCompile)
            {
                // MemberName
                string memberName = node.Left.Value;

                // MemberSelect
                AddCommand(new Select(memberName));
            }
        }

        public override void Visit(MemberFunctionCallNode node)
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

        public override void Visit(FunctionCallNode node)
        {
            // Name
            string functionName = node.FunctionName.Value;
            
            // Arguments
            foreach (IPsiNode child in node.FunctionArgumentList)
                child.Accept(this);

            // FunctionCall
            AddCommand(new Call(functionName, node.FunctionArgumentList.Count));
        }

        public override void Visit(IndexingNode node)
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
                    AddError(CompilerErrorCode.Custom, "More than one dimension array indexing is not supported yet!", node.NodeValueInfo);
                else
                    AddCommand(new Indexing());
            }
        }

        public override void Visit(ArrayInitializatorNode node)
        {
            // Array initialize type
            node.ArrayDataType.Accept(this);

            TypeEnum arrayType = lastCompiledDataType;
            string arrayTypeName = lastCompiledDataTypeName;

            int arrayDim = node.ArrayDimensionList.Count;            

            // Dimensions
            foreach (var item in node.ArrayDimensionList)
                item.Accept(this);

            AddCommand(new CollectionInitializer(new TypeIdentifier { TypeEnum = TypeEnum.Array, GenericType = arrayType }, arrayDim));
        }

        public override void Visit(CollectionInitializatorNode node)
        {
            // Collection Type
            node.CollectionType.Accept(this);

            // Collection Type
            TypeIdentifier collectionType = lastCompiledDataType;
            string collectionTypeName = lastCompiledDataTypeName;

            // IsArray init
            bool isArray = false;
            if (node.CollectionType.Children.Count == 2)
                isArray = true;

            // Array Dimension
            int arrayDim = lastCompiledDimensionCount;

            // Collection Count
            int collectionCount = node.CollectionElementList.Count;

            // Set the type identifier
            if (isArray)
            {
                collectionType = new TypeIdentifier { TypeEnum = TypeEnum.Array, GenericType = collectionType, Dimensions = new List<int> { collectionCount } };
            }

            node.CollectionElementList.Reverse();
            foreach (var item in node.CollectionElementList)
                item.Accept(this);
            node.CollectionElementList.Reverse();

            AddCommand(new CollectionInitializer(collectionType, 1, collectionCount));

        }

        #endregion

        /*Identifier*/
        #region Identifier

        public override void Visit(IdentifierNode node) 
        {
            AddCommand(
                new Push(node.Value, isCompilingAssignmentTarget || node.ChildrenCount != 0
                    ? ValueAccessModes.LocalVariableReference
                    : ValueAccessModes.LocalVariable));
        }

        #endregion

        /*Literals*/
        #region Literals

        public override void Visit(CharLiteralNode node) { SetLastCompiledConstant(CharLiteralNodeToBaseType(node)); }
        public override void Visit(StringLiteralNode node) { SetLastCompiledConstant(StringLiteralNodeToBaseType(node)); }
        public override void Visit(IntLiteralNode node) { SetLastCompiledConstant(IntLiteralNodeToBaseType(node)); }
        public override void Visit(DecimalLiteralNode node) { SetLastCompiledConstant(DecimalLiteralNodeToBaseType(node)); }
        public override void Visit(BoolLiteralNode node) { SetLastCompiledConstant(BoolLiteralNodeToBaseType(node)); }
        public override void Visit(NullLiteralNode node) { SetLastCompiledConstant(NullLiteralNodeToBaseType(node)); }

        #endregion

        #endregion
    }
}
