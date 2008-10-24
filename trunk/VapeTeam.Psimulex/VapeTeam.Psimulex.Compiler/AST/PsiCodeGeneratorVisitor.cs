using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Compiler.Result;
using System.IO;

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

    #endregion

    public class CompilationUnit
    {
        public string FileName { get; set; }
        public string Source { get; set; }
        public string CleanedSourceText { get; set; }

        public IPsiNode PsiNodeSyntaxTree { get; set; }

        //public string ANTLRExceptionText { get; set; }
        //public List<string> ANTLRErrorMessages { get; set; }
        public MessageList CompilerMessages { get; set; }

        public CompilationUnit()
        {
            FileName = "";
            Source = "";
            CleanedSourceText = "";
            PsiNodeSyntaxTree = null;
            //ANTLRErrorMessages = new List<string>();
            //ANTLRExceptionText = "";
            CompilerMessages = new MessageList();
        }
    }

    public class PsiCodeGeneratorVisitor : IPsiVisitor
    {
        #region PsiBuilderVisitor Members

        #region Result

        public ProgramBuilder Program { get; set; }

        public List<CompilationUnit> CompilationUnitList { get; set; }
        public CompilationUnit CurrentCompilationUnit { get; set; }

        public List<UserDefinedFunction> UserDefinedFunctionList { get; set; }
        public CommandPositionChanges CommandPositionChanges { get; set; }

        #endregion        

        public string Source { get; set; }
        public string SourceFileName { get; set; }
        public string ProgramPath { get; set; }

        public int ProgramSize { get { return Program.Program.CommandList.Count; } }

        protected int CurrentFunctionSize
        {
            get
            {
                if (isCurrentCompiledTheMainProgram)
                {
                    return ProgramSize;
                }
                else
                {
                    return lastCompiledUserDefinedFunction.Commands.Count;
                }
            }
        }
        
        public PsiCodeGeneratorVisitor(CompilerDTO dto/*, string antlrExceptionText, List<string> antlrErrorMessages*/)
        {
            Program = ProgramBuilder.Create();

            Source = dto.Source;
            SourceFileName = dto.SourceFileName;
            ProgramPath = dto.ProgramPath;

            UserDefinedFunctionList = dto.UserDefinedFunctionList;
            CommandPositionChanges = dto.CommandPositionChanges;
            CompilationUnitList = dto.CompilationUnitList;

            InitHelpers();

            globalVariableNameList = dto.GlobalVariableList;

            CurrentCompilationUnit = new CompilationUnit
            {
                Source = Source,
                CleanedSourceText = Source,
                FileName = SourceFileName
                //,ANTLRExceptionText = antlrExceptionText,
                //ANTLRErrorMessages = antlrErrorMessages
            };

            CurrentCompilationUnit.Source = Source;
            CurrentCompilationUnit.CleanedSourceText = Source;
            CurrentCompilationUnit.FileName = SourceFileName;
            //CurrentCompilationUnit.ANTLRExceptionText = antlrExceptionText;
            //CurrentCompilationUnit.ANTLRErrorMessages = antlrErrorMessages;

            CompilationUnitList.Add(CurrentCompilationUnit);
        }

        /*Program build Helpers*/
        #region Program build Helpers

        public void AddCommand(ICommand command)
        {
            if (isCurrentCompiledTheMainProgram)
                Program.Add(command);
            else
                lastCompiledUserDefinedFunction.Commands.Add(command);
        }

        public void AddCommand(params ICommand[] commands)
        {
            if (isCurrentCompiledTheMainProgram)
                Program.Add(commands);
            else
                foreach (var cmd in commands)
                    lastCompiledUserDefinedFunction.Commands.Add(cmd);
        }

        public int GetCommandIndex(CommandBase cmd)
        {
            if (isCurrentCompiledTheMainProgram)
            {
                return Program.GetCommandIndex(cmd);
            }
            else
            {
                return lastCompiledUserDefinedFunction.Commands.GetCommandIndex(cmd);
            }
        }

        #endregion        

        /*Message generators*/
        #region Message generators

        public void AddInformation(string msg, NodeValueInfo info)
        {
            CurrentCompilationUnit.CompilerMessages.Informations.Add(new Information { MessageText = msg, Interval = info.ToInterval(SourceFileName) });
        }

        public void AddWarning(CompilerErrorCode code, string warning, NodeValueInfo info)
        {
            CurrentCompilationUnit.CompilerMessages.Warnings.Add(new Warning { ErrorCode = code, MessageText = warning, Interval = info.ToInterval(SourceFileName) });
        }

        public void AddError(CompilerErrorCode code, string error, NodeValueInfo info)
        {
            CurrentCompilationUnit.CompilerMessages.Errors.Add(new Error { ErrorCode = code, MessageText = error, Interval = info.ToInterval(SourceFileName) });
        }

        public void AddError(CompilerErrorCode code, string error, NodeValueInfo info, Exception ex)
        {
            AddError(code, error, info);
            throw ex;
        }

        #endregion

        /*Highlighter, Stepping Helpers*/
        #region Highlighter, Stepping Helpers

        private void RegisterIntervalChange(IPsiNode node)
        {
            Interval range = SourceInfoUtils.CreateInterval(node, Source, lineLengthList, SourceFileName);

            // If lastCompiledUserDefinedFunction == null, than we compile, the main program
            if (!isCurrentCompiledTheMainProgram && lastCompiledUserDefinedFunction != null)
            {
                CommandPositionChanges[lastCompiledUserDefinedFunction.Name,
                    lastCompiledUserDefinedFunction.Commands.Count] = range;
            }
            else
            {
                CommandPositionChanges["", ProgramSize] = range;
            }
        }
        
        #endregion

        /*Compile Helpers*/
        #region Compiler Helpers

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
        private bool isCurrentCompiledTheMainProgram;
        private System.Collections.Generic.Stack<Jump> lazyEvaluationJumpStack;
        private System.Collections.Generic.Stack<Jump> jumpStack;
        private int conditionCount;
        private UserDefinedFunction lastCompiledUserDefinedFunction;
        private List<int> lineLengthList;

        private List<string> globalVariableNameList;
        private List<List<string>> currentLocalVariableNameList;

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
            isCurrentCompiledTheMainProgram = true;
            lazyEvaluationJumpStack = new System.Collections.Generic.Stack<Jump>();
            jumpStack = new System.Collections.Generic.Stack<Jump>();
            conditionCount = 0;
            lastCompiledUserDefinedFunction = new UserDefinedFunction();
            lineLengthList = SourceInfoUtils.FindLineLengths(Source);
            globalVariableNameList = new List<string>();
            currentLocalVariableNameList = new List<List<string>>();
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
            jmp.PC = CurrentFunctionSize - GetCommandIndex(jmp) + corrigation;
        }

        #endregion

        /*Name collision checkings helpers*/
        #region Name collision checkings helpers

        private void NewScope()
        {
            currentLocalVariableNameList.Add(new List<string>());
        }

        private void DeleteScope()
        {
            currentLocalVariableNameList.RemoveAt(currentLocalVariableNameList.Count - 1);
        }

        private bool ExistsLocalVariableName(string name)
        {
            foreach (var varList in currentLocalVariableNameList)
                foreach (var varName in varList)
                    if (varName == name)
                        return true;

            return false;
        }

        private void AddLocalVariableName(string name)
        {
            currentLocalVariableNameList.Last<List<string>>().Add(name);
        }

        private void CheckAndAddLocalVariableName(string name, NodeValueInfo nvi)
        {
            if (ExistsLocalVariableName(name))
                AddWarning(CompilerErrorCode.LocalVariableNameCollision, string.Format("Local variable name \"{0}\" is already exist in the current scope.", name), nvi);
            else
                AddLocalVariableName(name);
        }

        private void CheckGlobalVariableName(string name, NodeValueInfo nvi)
        {
            if (globalVariableNameList.Contains(name))
                AddWarning(CompilerErrorCode.GlobalVariableNameCollision, string.Format("Global variable name \"{0}\" is already exist.", name), nvi);
            else
                globalVariableNameList.Add(name);
        }

        private bool IsCompiledFunction(string name, int parameterCount, NodeValueInfo nvi)
        {
            if (UserDefinedFunctionList.Find(func =>
                func.Name == name && func.ParameterCount == parameterCount) != null)
            {
                AddWarning(CompilerErrorCode.FunctionCollison, string.Format(
                    "Function \"{0}\" with {1} parameter is already exist, the compilation of this function will skipped.",
                    name, lastCompiledUserDefinedFunction.ParameterCount), nvi);
                return true;
            }
            return false;
        }

        private bool IsCompiledCompilationUnit(string name)
        {
            if (CompilationUnitList.Find(cu => cu.FileName == name) == null)
                return false;
            return true;
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
        public void Visit(PsiNode node) { AddInformation("PsiNode Found : " + node.ToString(), node.NodeValueInfo); VisitChildren(node); }

        /*Undefined Tree Node*/
        public void Visit(XNode node) { AddInformation("XNode Found : " + node.ToString(), node.NodeValueInfo); VisitChildren(node); }

        #endregion

        /*High Level Tree Nodes*/
        #region High Level Tree Nodes

        public void Visit(CompilationUnitNode node)
        {
            AddInformation(string.Format("Build started at {0}", DateTime.Now.ToLongTimeString()), node.NodeValueInfo);
            VisitChildren(node);
        }
        public void Visit(SimpleProgramNode node) 
        {
            NewScope();

            isCurrentCompiledTheMainProgram = true;
            VisitChildren(node);

            DeleteScope();
        }

        public void Visit(MultiFuncionalProgramNode node)
        {
            // Compile the Functions
            isCurrentCompiledTheMainProgram = false;

            node.ProgramTypeDeclarations.Accept(this);
            node.ProgramGlobalVariableDeclarations.Accept(this);
            node.ProgramFunctionDeclarations.Accept(this);
            node.ProgramImports.Accept(this);

            isCurrentCompiledTheMainProgram = true;

            // Generate a main function call
            AddCommand(new Call("main", 0));
            AddCommand(new Return(false));
        }

        public void Visit(ImportDeclarationNode node)
        {
            // Message
            string imports = "Imports Found : ( ";
            foreach (IPsiNode child in node.Children)
            {
                imports += child.Value;
                if (child != node.Right)
                    imports += ", ";
            }
            imports += " )";
            AddInformation(imports, node.NodeValueInfo);

            foreach (IPsiNode child in node.Children)
            {
                string importFileName = SplitQuotes(child.Value);

                if (!IsCompiledCompilationUnit(importFileName))
                {
                    Compiler c = new Compiler();

                    string importFile = "";
                    if (Path.IsPathRooted(importFileName))
                        importFile = importFileName;
                    else
                        importFile = Path.Combine(ProgramPath, importFileName);


                    if (!File.Exists(importFile))
                    {
                        AddError(CompilerErrorCode.ImportFileNotFound, string.Format("Import file not found \"{0}\" !", importFile), child.NodeValueInfo);
                    }
                    else
                    {
                        string source = "";
                        using (StreamReader sr = new StreamReader(importFile))
                        {
                            source = sr.ReadToEnd();
                            sr.Close();
                        }

                        c.Compile(
                                    new CompilerDTO
                                    {
                                        Source = source,
                                        ProgramPath = ProgramPath,
                                        SourceFileName = importFileName,
                                        CommandPositionChanges = CommandPositionChanges,
                                        GlobalVariableList = globalVariableNameList,
                                        CompilationUnitList = CompilationUnitList,
                                        UserDefinedFunctionList = UserDefinedFunctionList
                                    }
                                    , false
                                 );

                        Program.Program.CommandList.AddRange(c.CompileResult.CompiledProgram.CommandList);
                    }
                }
            }
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
            AddInformation(record, node.NodeValueInfo);

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
            lastCompiledDimensionCount = 0;
            lastCompiledDataType = TypeEnum.Undefined;
            lastCompiledUserDefinedDataTypeName = "Undefined";
        }

        public void Visit(GlobalVariableDeclarationsNode node)
        {
            RegisterIntervalChange(node);

            foreach (IPsiNode child in node.Children)
            {
                child.Accept(this);

                // Message
                string global = "Global Variable Found : " + lastCompiledMember.ToString();
                AddInformation(global, node.NodeValueInfo);

                CheckGlobalVariableName(lastCompiledMember.Name, node.NodeValueInfo);

                // Add Global Variable declaration or Initialization to the progrem
                if(lastCompiledMember.IsInitialized)
                    AddCommand(new Push(lastCompiledMember.Value),
                        new Initialize(lastCompiledMember.Name, lastCompiledMember.Type));
                else
                    if (lastCompiledMember.DimensionCount > 0)
                        AddCommand(new ArrayDeclare(lastCompiledMember.Name,
                            lastCompiledMember.Type, lastCompiledMember.DimensionCount));
                    else
                        AddCommand(new Declare(lastCompiledMember.Name, lastCompiledMember.Type));
            }
        }

        public void Visit(FunctionDeclarationsNode node){ VisitChildren(node); }
        public void Visit(FunctionDeclarationNode node)
        {
            NewScope();

            // Start Compile a new function
            lastCompiledUserDefinedFunction = new UserDefinedFunction();

            // FunctionType
            node.FunctionType.Accept(this);
            TypeEnum functionType = lastCompiledDataType;
            string functionTypeName = lastCompiledUserDefinedDataTypeName;

            int functionDimensionCount = lastCompiledDimensionCount;
            List<int> functionDimensionList = lastCompiledDimensionList;
            bool functionIsDynamic = isLastCompiledArrayDynamic;

            // FunctionReference
            bool functionIsReferenceType = false;
            if (node.FunctionReference != null)
                functionIsReferenceType = true;

            // FunctionName
            string functionName = node.FunctionName.Value;

            // Message
            string function = "Function Found : " + functionType + " " + functionName + " () ";
            AddInformation(function, node.NodeValueInfo);
            // Message

            lastCompiledUserDefinedFunction.Name = functionName;

            // FunctionParameterList
            node.FunctionParameterList.Accept(this);

            if (!IsCompiledFunction(lastCompiledUserDefinedFunction.Name,
                lastCompiledUserDefinedFunction.ParameterCount, node.NodeValueInfo))
            {
                // FunctionBlock
                node.FunctionBlock.Accept(this);

                // Set Up rest of the function property-s.
                lastCompiledUserDefinedFunction.ReturnValue =
                    new VariableDescriptor
                        {
                            Type = new TypeIdentifier
                                {
                                    TypeEnum = functionType,
                                    TypeName = functionTypeName
                                },
                            IsArray = functionDimensionCount == 0 ? false : true,
                            IsDynamic = functionIsDynamic,
                            DimensionCount = functionDimensionCount,
                            DimensionList = functionDimensionList,
                            IsReference = functionIsReferenceType,
                            Name = ""
                        };

                if (lastCompiledUserDefinedFunction.Commands.Count == 0
                    ||
                    lastCompiledUserDefinedFunction.Commands
                    [
                        lastCompiledUserDefinedFunction.Commands.Count - 1
                    ].GetType() != typeof(Return))

                    lastCompiledUserDefinedFunction.Commands.Add(new Return(false));

                // Add new compiled function to the UserDefinedCunctionList
                UserDefinedFunctionList.Add(lastCompiledUserDefinedFunction);
            }

            DeleteScope();
        }

        public void Visit(FormalParameterListNode node) { VisitChildren(node); }
        public void Visit(FormalParameterNode node)
        {
             // Parameter Type
            node.ParameterType.Accept(this);

            TypeEnum parameterType = lastCompiledDataType;
            string parameterTypeName = lastCompiledUserDefinedDataTypeName;
            bool parameterArrayIsDynamic = isLastCompiledArrayDynamic;

            int parameterDimensionCount = lastCompiledDimensionCount;
            List<int> parameterDimensionList = lastCompiledDimensionList;

            // Parameter Reference
            bool parameterIsReference = false;
            if (node.ParameterReference != null)
                parameterIsReference = true;

            // Parameter Name
            string parameterName = node.ParameterName.Value;

            // Check Function Parameter
            if (ExistsLocalVariableName(parameterName))
                AddError(CompilerErrorCode.FormalParameterNameCollision, string.Format("Function {0} has already a parameter named {1}!",
                    lastCompiledUserDefinedFunction.Name, parameterName), node.NodeValueInfo);
            else
                AddLocalVariableName(parameterName);

            lastCompiledUserDefinedFunction.Parameters.Add
                (new VariableDescriptor
                    {
                        Type = new TypeIdentifier
                            {
                                TypeEnum = parameterType,
                                TypeName = parameterTypeName
                            },
                        Name = parameterName,
                        IsReference = parameterIsReference,
                        IsArray = parameterDimensionCount == 0 ? false : true,
                        DimensionCount = parameterDimensionCount,
                        DimensionList = parameterDimensionList,
                        IsDynamic = parameterArrayIsDynamic
                    }
                );

            lastCompiledDataType = TypeEnum.Undefined;
            lastCompiledUserDefinedDataTypeName = "";
            isLastCompiledArrayDynamic = false;
            lastCompiledDimensionCount = 0;
            lastCompiledDimensionList = new List<int>();
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
            NewScope();
            
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
            DeleteScope();
        }
        
        public void Visit(IfBranchNode node) { VisitChildren(node); }
        public void Visit(ElseIfBranchNode node) { VisitChildren(node); }

        public void Visit(ElseBranchNode node) 
        {
            // AddCommand( new PushState() );
            NewScope();

            // ElseCore
            node.Left.Accept(this);

            // AddCommand( new PopState() );
            DeleteScope();
        }

        public void Visit(PForStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "PFor is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public void Visit(ForStatementNode node) 
        {
            // AddCommand(new PushState());
            NewScope();

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
            node.ForCore.Accept(this);

            // ForUpdate
            node.ForUpdate.Accept(this);

            // Jump To The ForCondition
            AddCommand(new RelativeJump(conditionAddress - CurrentFunctionSize));

            // Pop all Break from the jumpStack and set up it's PC to the end of the block
            while (jumpStack.Peek().GetType() == (new Break()).GetType() )
                SetUpTopJumpInJumpStack(0);

            SetUpTopJumpInJumpStack(0);
            
            // AddCommand(new PopState());
            DeleteScope();
        }

        public void Visit(ForInitializationNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public void Visit(ForConditionNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public void Visit(ForUpdateNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public void Visit(DoStatementNode node) 
        {
            // AddCommand(new PushState());
            NewScope();

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
            DeleteScope();
        }

        public void Visit(WhileStatementNode node) 
        {
            // AddCommand(new PushState());
            NewScope();

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
            DeleteScope();
        }

        public void Visit(PForEachStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "PForEach is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public void Visit(ForEachStatementNode node)
        {
            // AddCommand(new PushState());
            NewScope();

            RegisterIntervalChange(node.ForEachInitialization);

            // ForEachRunningVariableType
            node.ForEachRunningVariableType.Accept(this);

            // If this is UserDefined, then use lastCompiledUserDefinedDataTypeName
            TypeEnum forEachRunningVariableType = lastCompiledDataType;
            string forEachRunningVariableTypeName = lastCompiledUserDefinedDataTypeName;

            // IteratorVariableName
            string forEachRunningVariableName = node.ForEachRunningVariableName.Value;

            // Check variable name
            CheckAndAddLocalVariableName(forEachRunningVariableName, node.NodeValueInfo);

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
            DeleteScope();
        }

        public void Visit(ForEachInitializationNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public void Visit(ForEachCollectionExpressionNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public void Visit(LoopStatementNode node) 
        {
            // AddCommand(new PushState());
            NewScope();

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
            DeleteScope();
        }

        public void Visit(LoopInitializationNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public void Visit(LoopLimitNode node) { RegisterIntervalChange(node); VisitChildren(node); }

        public void Visit(ConditionNode node) { RegisterIntervalChange(node); VisitChildren(node); }
        public void Visit(CoreNode node) { VisitChildren(node); }

        public void Visit(PDoStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "PDo is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public void Visit(AsynStatementNode node) 
        {
            AddError(CompilerErrorCode.NotImplemented, "Async is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public void Visit(LockStatementNode node)
        {
            AddError(CompilerErrorCode.NotImplemented, "Lock is not implemented yet. It was skipped!", node.NodeValueInfo);
        }

        public void Visit(ReturnStatementNode node)
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

        public void Visit(ReturnNode node) { VisitChildren(node); }

        public void Visit(BreakNode node) 
        {
            RegisterIntervalChange(node);

            Break b = new Break();
            AddCommand(b);
            jumpStack.Push(b);
        }

        //public void Visit(ContinueNode node) { VisitChildren(node); }

        public void Visit(ExpressionStatementNode node) 
        {
            RegisterIntervalChange(node);
            VisitChildren(node); 
        }

        public void Visit(VariableDeclarationStatementNode node)
        {
            RegisterIntervalChange(node);
            VisitChildren(node);
        }

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

            // Check variable name
            CheckAndAddLocalVariableName(varName, node.NodeValueInfo);

            // Expression
            node.VariableInitialValue.Accept(this);

            // Initialize
            if (varIsReference) AddError(CompilerErrorCode.Custom, "Reference variable definition/initialization is not supported yet!", node.NodeValueInfo);
            if (varArrayIsDynamic) AddError(CompilerErrorCode.Custom, "Dynamic array initialization is not supported yet!", node.NodeValueInfo);
            if (varType != TypeEnum.UserDefinedType)
            {
                if (varDimensionCount > 0) AddError(CompilerErrorCode.Custom, "Array initialization is not supported yet!", node.NodeValueInfo);
                else AddCommand(new Initialize(varName, varType));
            }
            else
            {
                AddError(CompilerErrorCode.Custom, string.Format("User defined types are not supported yet! ({0})", varTypeName), node.NodeValueInfo);
            }
        }

        public void Visit(VariableDeclarationNode node)
        {
            RegisterIntervalChange(node);

            // Type
            node.VariableType.Accept(this);

            // If this is UserDefined, then use lastCompiledUserDefinedDataTypeName
            TypeEnum varType = lastCompiledDataType;

            string varTypeName = lastCompiledUserDefinedDataTypeName;
            bool varArrayIsDynamic = isLastCompiledArrayDynamic;
            int varDimensionCount = lastCompiledDimensionCount;

            // Name
            string varName = node.VariableName.Value;

            // Check variable name
            CheckAndAddLocalVariableName(varName, node.NodeValueInfo);

            // Declare
            if (varArrayIsDynamic) AddError(CompilerErrorCode.Custom, "Dynamic array declaration is not supported yet!", node.NodeValueInfo);
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
                AddError(CompilerErrorCode.Custom, string.Format("User defined types is not supported yet! ({0})", varTypeName), node.NodeValueInfo);
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
                        AddError(CompilerErrorCode.Custom, string.Format("Unknown Assign Operator : {0}", node.Value), node.NodeValueInfo);
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

        public void Visit(LogicalAndOpNode node)
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Compare Operator : {0}", node.Value), node.NodeValueInfo);
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Compare Operator : {0}", node.Value), node.NodeValueInfo);
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Additive Operator : {0}", node.Value), node.NodeValueInfo);
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown Additive Operator : {0}", node.Value), node.NodeValueInfo);
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
                    AddError(CompilerErrorCode.Custom, string.Format("Unknown UnaryPrefix Operator : {0}", node.Value), node.NodeValueInfo);
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
                    AddError(CompilerErrorCode.Custom, "More than one dimension array indexing is not supported yet!", node.NodeValueInfo);
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
            lastCompiledDimensionCount = node.ChildrenCount - 1;
            lastCompiledDimensionList = new List<int>();
            isLastCompiledArrayDynamic = true;
        }

        #endregion

        /*Identifier*/
        #region Identifier

        public void Visit(IdentifierNode node) 
        {
            AddCommand(new Push(node.Value, isCompilingAssignmentTarget || node.ChildrenCount != 0 ? ValueAccessModes.LocalVariableReference : ValueAccessModes.LocalVariable));
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
