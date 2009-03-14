// $ANTLR 3.1.2 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2009-03-14 14:59:48

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;


using Antlr.Runtime.Tree;

public partial class PsimulexParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"COMPILATION_UNIT", 
		"SIMPLE_PROGRAM", 
		"MULTY_FUNCTIONAL_PROGRAM", 
		"IMPORT_DECLARATIONS", 
		"TYPE_DECLARATIONS", 
		"STRUCTDEC", 
		"GLOBAL_VARIABLE_DECLARATIONS", 
		"MEMBERDEC", 
		"FUNCTION_DECLARATIONS", 
		"FUNCDEC", 
		"FORMAL_PARAMETER_LIST", 
		"FORMAL_PARAMETER", 
		"BLOCK", 
		"STATEMENT", 
		"IFSTATEMENT", 
		"IFBRANCH", 
		"ELSEIFBRANCHES", 
		"CONDITIONALBRANCH", 
		"ELSEBRANCH", 
		"PFORSTATEMENT", 
		"FORSTATEMENT", 
		"FORCONDITION", 
		"FORINIT", 
		"FORUPDATE", 
		"DOSTATEMENT", 
		"WHILESTATEMENT", 
		"PFOREACHSTATEMENT", 
		"FOREACHSTATEMENT", 
		"FOREACHINIT", 
		"FOREACHCOLLECTION", 
		"LOOPSTATEMENT", 
		"LOOPINIT", 
		"LOOPLIMIT", 
		"CORE", 
		"CONDITION", 
		"PDOSTATEMENT", 
		"ASYNCSTATEMENT", 
		"LOCKSTATEMENT", 
		"RETURN_STATEMENT", 
		"EXPRESSION_STATEMENT", 
		"VARIABLE_DECLARATION_STATEMENT", 
		"VARINIT", 
		"VARDECLARE", 
		"TYPE", 
		"DATATYPE", 
		"FUNCTIONPOINTERTYPE", 
		"EXPRESSION", 
		"CAST", 
		"PREFIXOP", 
		"POSTFIXOP", 
		"SELECTOR", 
		"MEMBER_FUNCTION_CALL", 
		"FUNCTION_CALL", 
		"ARGUMENTS", 
		"MEMBER_SELECT", 
		"INDEXING", 
		"DIMMARKER", 
		"COLLECTION_INITIALIZER", 
		"ARRAY_INITIALIZER", 
		"Import", 
		"StringLiteral", 
		"Struct", 
		"Identifier", 
		"Assign", 
		"Reference", 
		"Bool", 
		"Char", 
		"Int", 
		"Decimal", 
		"String", 
		"Void", 
		"Tree", 
		"BinTree", 
		"Set", 
		"List", 
		"Stack", 
		"Queue", 
		"PQueue", 
		"Graph", 
		"Node", 
		"Edge", 
		"Thread", 
		"Iterator", 
		"AssignAndAdd", 
		"AssignAndSubstract", 
		"AssignAndMultiply", 
		"AssignAndDivide", 
		"AssignAndModulo", 
		"LogicalOr", 
		"LogicalAnd", 
		"RelEqual", 
		"RelNotEqual", 
		"RelLessThan", 
		"RelLessThanOrEqual", 
		"RelGreaterThan", 
		"RelGreaterThanOrEqual", 
		"Plus", 
		"Minus", 
		"Star", 
		"Divide", 
		"Modulo", 
		"LogicalNot", 
		"PlusPlus", 
		"MinusMinus", 
		"IntegerLiteral", 
		"DecimalLiteral", 
		"CharacterLiteral", 
		"BooleanLiteral", 
		"NullLiteral", 
		"InfinityLiteral", 
		"New", 
		"PDo", 
		"Async", 
		"Lock", 
		"Return", 
		"Break", 
		"If", 
		"ElseIf", 
		"Else", 
		"For", 
		"PFor", 
		"While", 
		"Do", 
		"PForEach", 
		"ForEach", 
		"In", 
		"Loop", 
		"To", 
		"Continue", 
		"Atomic", 
		"Letter", 
		"IDLetter", 
		"Digit", 
		"NotNullDigit", 
		"DecimalTypeSuffix", 
		"EscapeSequence", 
		"WS", 
		"SingleLineComment", 
		"MultiLineComment", 
		"';'", 
		"'{'", 
		"'}'", 
		"'['", 
		"','", 
		"']'", 
		"'('", 
		"')'", 
		"'.'"
    };

    public const int CAST = 51;
    public const int Iterator = 86;
    public const int CONDITIONALBRANCH = 21;
    public const int RelEqual = 94;
    public const int FORMAL_PARAMETER_LIST = 14;
    public const int TYPE_DECLARATIONS = 8;
    public const int VARINIT = 45;
    public const int AssignAndDivide = 90;
    public const int FORSTATEMENT = 24;
    public const int AssignAndMultiply = 89;
    public const int PFORSTATEMENT = 23;
    public const int CONDITION = 38;
    public const int Decimal = 72;
    public const int Modulo = 104;
    public const int PDOSTATEMENT = 39;
    public const int IDLetter = 135;
    public const int EOF = -1;
    public const int STATEMENT = 17;
    public const int INDEXING = 59;
    public const int Identifier = 66;
    public const int Int = 71;
    public const int Thread = 85;
    public const int TYPE = 47;
    public const int BinTree = 76;
    public const int PFOREACHSTATEMENT = 30;
    public const int T__148 = 148;
    public const int T__147 = 147;
    public const int To = 131;
    public const int T__149 = 149;
    public const int ForEach = 128;
    public const int Char = 70;
    public const int Edge = 84;
    public const int COMPILATION_UNIT = 4;
    public const int LOCKSTATEMENT = 41;
    public const int Do = 126;
    public const int RelGreaterThan = 98;
    public const int FORMAL_PARAMETER = 15;
    public const int Node = 83;
    public const int AssignAndModulo = 91;
    public const int LOOPLIMIT = 36;
    public const int FOREACHINIT = 32;
    public const int T__150 = 150;
    public const int T__151 = 151;
    public const int WHILESTATEMENT = 29;
    public const int FORUPDATE = 27;
    public const int Bool = 69;
    public const int FORINIT = 26;
    public const int ARGUMENTS = 57;
    public const int MEMBER_SELECT = 58;
    public const int LogicalOr = 92;
    public const int LogicalAnd = 93;
    public const int CORE = 37;
    public const int Tree = 75;
    public const int T__145 = 145;
    public const int T__146 = 146;
    public const int T__143 = 143;
    public const int T__144 = 144;
    public const int POSTFIXOP = 53;
    public const int Minus = 101;
    public const int WS = 140;
    public const int Break = 119;
    public const int GLOBAL_VARIABLE_DECLARATIONS = 10;
    public const int Async = 116;
    public const int MEMBER_FUNCTION_CALL = 55;
    public const int MULTY_FUNCTIONAL_PROGRAM = 6;
    public const int SIMPLE_PROGRAM = 5;
    public const int DATATYPE = 48;
    public const int EXPRESSION_STATEMENT = 43;
    public const int NotNullDigit = 137;
    public const int RelLessThan = 96;
    public const int Star = 102;
    public const int Else = 122;
    public const int FUNCTION_CALL = 56;
    public const int EscapeSequence = 139;
    public const int Letter = 134;
    public const int Loop = 130;
    public const int VARIABLE_DECLARATION_STATEMENT = 44;
    public const int BooleanLiteral = 111;
    public const int LOOPSTATEMENT = 34;
    public const int DIMMARKER = 60;
    public const int AssignAndAdd = 87;
    public const int Stack = 79;
    public const int NullLiteral = 112;
    public const int RelGreaterThanOrEqual = 99;
    public const int IFSTATEMENT = 18;
    public const int PQueue = 81;
    public const int SingleLineComment = 141;
    public const int CharacterLiteral = 110;
    public const int COLLECTION_INITIALIZER = 61;
    public const int AssignAndSubstract = 88;
    public const int FOREACHCOLLECTION = 33;
    public const int While = 125;
    public const int Graph = 82;
    public const int Queue = 80;
    public const int Set = 77;
    public const int SELECTOR = 54;
    public const int Assign = 67;
    public const int RETURN_STATEMENT = 42;
    public const int PForEach = 127;
    public const int RelNotEqual = 95;
    public const int FOREACHSTATEMENT = 31;
    public const int IFBRANCH = 19;
    public const int String = 73;
    public const int Return = 118;
    public const int Struct = 65;
    public const int Reference = 68;
    public const int EXPRESSION = 50;
    public const int MultiLineComment = 142;
    public const int If = 120;
    public const int FUNCTIONPOINTERTYPE = 49;
    public const int In = 129;
    public const int Import = 63;
    public const int VARDECLARE = 46;
    public const int FUNCTION_DECLARATIONS = 12;
    public const int Continue = 132;
    public const int ELSEBRANCH = 22;
    public const int Void = 74;
    public const int ASYNCSTATEMENT = 40;
    public const int Lock = 117;
    public const int PDo = 115;
    public const int ElseIf = 121;
    public const int IMPORT_DECLARATIONS = 7;
    public const int DOSTATEMENT = 28;
    public const int Digit = 136;
    public const int DecimalLiteral = 109;
    public const int STRUCTDEC = 9;
    public const int For = 123;
    public const int Divide = 103;
    public const int List = 78;
    public const int FORCONDITION = 25;
    public const int StringLiteral = 64;
    public const int LogicalNot = 105;
    public const int Plus = 100;
    public const int Atomic = 133;
    public const int RelLessThanOrEqual = 97;
    public const int New = 114;
    public const int MinusMinus = 107;
    public const int DecimalTypeSuffix = 138;
    public const int PFor = 124;
    public const int BLOCK = 16;
    public const int PREFIXOP = 52;
    public const int MEMBERDEC = 11;
    public const int ELSEIFBRANCHES = 20;
    public const int IntegerLiteral = 108;
    public const int LOOPINIT = 35;
    public const int FUNCDEC = 13;
    public const int ARRAY_INITIALIZER = 62;
    public const int InfinityLiteral = 113;
    public const int PlusPlus = 106;

    // delegates
    // delegators



        public PsimulexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PsimulexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[198+1];
             
             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return PsimulexParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g"; }
    }


    public class compilationUnit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "compilationUnit"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:98:1: compilationUnit : ( multiFunctionalProgram )? EOF ;
    public PsimulexParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        PsimulexParser.compilationUnit_return retval = new PsimulexParser.compilationUnit_return();
        retval.Start = input.LT(1);
        int compilationUnit_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken EOF2 = null;
        PsimulexParser.multiFunctionalProgram_return multiFunctionalProgram1 = default(PsimulexParser.multiFunctionalProgram_return);


        CommonTree EOF2_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:5: ( ( multiFunctionalProgram )? EOF )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:7: ( multiFunctionalProgram )? EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:7: ( multiFunctionalProgram )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == Import || (LA1_0 >= Struct && LA1_0 <= Identifier) || (LA1_0 >= Bool && LA1_0 <= Iterator)) )
            	{
            	    alt1 = 1;
            	}
            	else if ( (LA1_0 == EOF) )
            	{
            	    int LA1_2 = input.LA(2);

            	    if ( (synpred1_Psimulex()) )
            	    {
            	        alt1 = 1;
            	    }
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:29: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit352);
            	        	multiFunctionalProgram1 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram1.Tree);

            	        }
            	        break;

            	}

            	EOF2=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit357); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, compilationUnit_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "compilationUnit"

    public class simpleProgram_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "simpleProgram"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:1: simpleProgram : ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) ;
    public PsimulexParser.simpleProgram_return simpleProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.simpleProgram_return retval = new PsimulexParser.simpleProgram_return();
        retval.Start = input.LT(1);
        int simpleProgram_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.statement_return statement3 = default(PsimulexParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:2: ( ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:4: ( statement )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || (LA2_0 >= Reference && LA2_0 <= Iterator) || LA2_0 == Minus || (LA2_0 >= LogicalNot && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= ForEach) || LA2_0 == Loop || LA2_0 == 143 || LA2_0 == 149) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_simpleProgram372);
            			    	statement3 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement3.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 103:15: -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:18: ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:38: ^( SIMPLE_PROGRAM ( statement )* )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SIMPLE_PROGRAM, "SIMPLE_PROGRAM"), root_2);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:56: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, simpleProgram_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "simpleProgram"

    public class multiFunctionalProgram_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiFunctionalProgram"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:1: multiFunctionalProgram : importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) ;
    public PsimulexParser.multiFunctionalProgram_return multiFunctionalProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.multiFunctionalProgram_return retval = new PsimulexParser.multiFunctionalProgram_return();
        retval.Start = input.LT(1);
        int multiFunctionalProgram_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.importDeclarations_return importDeclarations4 = default(PsimulexParser.importDeclarations_return);

        PsimulexParser.typeDeclarations_return typeDeclarations5 = default(PsimulexParser.typeDeclarations_return);

        PsimulexParser.globalVariableDeclarations_return globalVariableDeclarations6 = default(PsimulexParser.globalVariableDeclarations_return);

        PsimulexParser.functionDeclarations_return functionDeclarations7 = default(PsimulexParser.functionDeclarations_return);


        RewriteRuleSubtreeStream stream_functionDeclarations = new RewriteRuleSubtreeStream(adaptor,"rule functionDeclarations");
        RewriteRuleSubtreeStream stream_globalVariableDeclarations = new RewriteRuleSubtreeStream(adaptor,"rule globalVariableDeclarations");
        RewriteRuleSubtreeStream stream_importDeclarations = new RewriteRuleSubtreeStream(adaptor,"rule importDeclarations");
        RewriteRuleSubtreeStream stream_typeDeclarations = new RewriteRuleSubtreeStream(adaptor,"rule typeDeclarations");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:107:2: ( importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:107:4: importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations
            {
            	PushFollow(FOLLOW_importDeclarations_in_multiFunctionalProgram401);
            	importDeclarations4 = importDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_importDeclarations.Add(importDeclarations4.Tree);
            	PushFollow(FOLLOW_typeDeclarations_in_multiFunctionalProgram403);
            	typeDeclarations5 = typeDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_typeDeclarations.Add(typeDeclarations5.Tree);
            	PushFollow(FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram405);
            	globalVariableDeclarations6 = globalVariableDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_globalVariableDeclarations.Add(globalVariableDeclarations6.Tree);
            	PushFollow(FOLLOW_functionDeclarations_in_multiFunctionalProgram407);
            	functionDeclarations7 = functionDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_functionDeclarations.Add(functionDeclarations7.Tree);


            	// AST REWRITE
            	// elements:          functionDeclarations, globalVariableDeclarations, importDeclarations, typeDeclarations
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 108:3: -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:108:6: ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:108:26: ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MULTY_FUNCTIONAL_PROGRAM, "MULTY_FUNCTIONAL_PROGRAM"), root_2);

            	    adaptor.AddChild(root_2, stream_importDeclarations.NextTree());
            	    adaptor.AddChild(root_2, stream_typeDeclarations.NextTree());
            	    adaptor.AddChild(root_2, stream_globalVariableDeclarations.NextTree());
            	    adaptor.AddChild(root_2, stream_functionDeclarations.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, multiFunctionalProgram_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multiFunctionalProgram"

    public class globalVariableDeclarations_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "globalVariableDeclarations"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:111:1: globalVariableDeclarations : ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) ;
    public PsimulexParser.globalVariableDeclarations_return globalVariableDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.globalVariableDeclarations_return retval = new PsimulexParser.globalVariableDeclarations_return();
        retval.Start = input.LT(1);
        int globalVariableDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberDeclaration_return memberDeclaration8 = default(PsimulexParser.memberDeclaration_return);


        RewriteRuleSubtreeStream stream_memberDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule memberDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:2: ( ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:4: ( memberDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:4: ( memberDeclaration )*
            	do 
            	{
            	    int alt3 = 2;
            	    alt3 = dfa3.Predict(input);
            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclarations442);
            			    	memberDeclaration8 = memberDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_memberDeclaration.Add(memberDeclaration8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements



            	// AST REWRITE
            	// elements:          memberDeclaration
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 112:23: -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:26: ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GLOBAL_VARIABLE_DECLARATIONS, "GLOBAL_VARIABLE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:58: ( memberDeclaration )*
            	    while ( stream_memberDeclaration.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_memberDeclaration.NextTree());

            	    }
            	    stream_memberDeclaration.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, globalVariableDeclarations_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "globalVariableDeclarations"

    public class importDeclarations_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "importDeclarations"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:1: importDeclarations : ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) ;
    public PsimulexParser.importDeclarations_return importDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.importDeclarations_return retval = new PsimulexParser.importDeclarations_return();
        retval.Start = input.LT(1);
        int importDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Import9 = null;
        IToken StringLiteral10 = null;
        IToken char_literal11 = null;

        CommonTree Import9_tree=null;
        CommonTree StringLiteral10_tree=null;
        CommonTree char_literal11_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_StringLiteral = new RewriteRuleTokenStream(adaptor,"token StringLiteral");
        RewriteRuleTokenStream stream_Import = new RewriteRuleTokenStream(adaptor,"token Import");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:129:5: ( ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:129:9: ( Import StringLiteral ';' )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:129:9: ( Import StringLiteral ';' )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == Import) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:129:11: Import StringLiteral ';'
            			    {
            			    	Import9=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclarations482); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_Import.Add(Import9);

            			    	StringLiteral10=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclarations484); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_StringLiteral.Add(StringLiteral10);

            			    	char_literal11=(IToken)Match(input,143,FOLLOW_143_in_importDeclarations486); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_143.Add(char_literal11);


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements



            	// AST REWRITE
            	// elements:          StringLiteral
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 129:39: -> ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:129:42: ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IMPORT_DECLARATIONS, "IMPORT_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:129:65: ( StringLiteral )*
            	    while ( stream_StringLiteral.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_StringLiteral.NextNode());

            	    }
            	    stream_StringLiteral.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, importDeclarations_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "importDeclarations"

    public class typeDeclarations_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typeDeclarations"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:1: typeDeclarations : ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) ;
    public PsimulexParser.typeDeclarations_return typeDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.typeDeclarations_return retval = new PsimulexParser.typeDeclarations_return();
        retval.Start = input.LT(1);
        int typeDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.structDeclaration_return structDeclaration12 = default(PsimulexParser.structDeclaration_return);


        RewriteRuleSubtreeStream stream_structDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule structDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:133:5: ( ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:133:9: ( structDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:133:9: ( structDeclaration )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == Struct) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: structDeclaration
            			    {
            			    	PushFollow(FOLLOW_structDeclaration_in_typeDeclarations519);
            			    	structDeclaration12 = structDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_structDeclaration.Add(structDeclaration12.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements



            	// AST REWRITE
            	// elements:          structDeclaration
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 133:28: -> ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:133:31: ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE_DECLARATIONS, "TYPE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:133:52: ( structDeclaration )*
            	    while ( stream_structDeclaration.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_structDeclaration.NextTree());

            	    }
            	    stream_structDeclaration.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, typeDeclarations_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typeDeclarations"

    public class structDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "structDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:136:1: structDeclaration : Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) ;
    public PsimulexParser.structDeclaration_return structDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.structDeclaration_return retval = new PsimulexParser.structDeclaration_return();
        retval.Start = input.LT(1);
        int structDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Struct13 = null;
        IToken Identifier14 = null;
        PsimulexParser.structBody_return structBody15 = default(PsimulexParser.structBody_return);


        CommonTree Struct13_tree=null;
        CommonTree Identifier14_tree=null;
        RewriteRuleTokenStream stream_Struct = new RewriteRuleTokenStream(adaptor,"token Struct");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_structBody = new RewriteRuleSubtreeStream(adaptor,"rule structBody");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:137:5: ( Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:137:9: Struct Identifier structBody
            {
            	Struct13=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration550); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Struct.Add(Struct13);

            	Identifier14=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration552); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier14);

            	PushFollow(FOLLOW_structBody_in_structDeclaration554);
            	structBody15 = structBody();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_structBody.Add(structBody15.Tree);


            	// AST REWRITE
            	// elements:          structBody, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 137:38: -> ^( STRUCTDEC Identifier structBody )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:137:41: ^( STRUCTDEC Identifier structBody )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(STRUCTDEC, "STRUCTDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    adaptor.AddChild(root_1, stream_structBody.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, structDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "structDeclaration"

    public class structBody_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "structBody"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:140:1: structBody : '{' ( memberDeclaration )+ '}' ;
    public PsimulexParser.structBody_return structBody() // throws RecognitionException [1]
    {   
        PsimulexParser.structBody_return retval = new PsimulexParser.structBody_return();
        retval.Start = input.LT(1);
        int structBody_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal16 = null;
        IToken char_literal18 = null;
        PsimulexParser.memberDeclaration_return memberDeclaration17 = default(PsimulexParser.memberDeclaration_return);


        CommonTree char_literal16_tree=null;
        CommonTree char_literal18_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:141:5: ( '{' ( memberDeclaration )+ '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:141:9: '{' ( memberDeclaration )+ '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal16=(IToken)Match(input,144,FOLLOW_144_in_structBody584); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:141:14: ( memberDeclaration )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == Identifier || (LA6_0 >= Bool && LA6_0 <= Iterator)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBody587);
            			    	memberDeclaration17 = memberDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberDeclaration17.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements

            	char_literal18=(IToken)Match(input,145,FOLLOW_145_in_structBody590); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, structBody_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "structBody"

    public class memberDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "memberDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:1: memberDeclaration options {k=3; } : ( type Identifier ';' -> ^( MEMBERDEC type Identifier ) | type Identifier Assign constantData ';' -> ^( MEMBERDEC type Identifier constantData ) );
    public PsimulexParser.memberDeclaration_return memberDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.memberDeclaration_return retval = new PsimulexParser.memberDeclaration_return();
        retval.Start = input.LT(1);
        int memberDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier20 = null;
        IToken char_literal21 = null;
        IToken Identifier23 = null;
        IToken Assign24 = null;
        IToken char_literal26 = null;
        PsimulexParser.type_return type19 = default(PsimulexParser.type_return);

        PsimulexParser.type_return type22 = default(PsimulexParser.type_return);

        PsimulexParser.constantData_return constantData25 = default(PsimulexParser.constantData_return);


        CommonTree Identifier20_tree=null;
        CommonTree char_literal21_tree=null;
        CommonTree Identifier23_tree=null;
        CommonTree Assign24_tree=null;
        CommonTree char_literal26_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_Assign = new RewriteRuleTokenStream(adaptor,"token Assign");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_constantData = new RewriteRuleSubtreeStream(adaptor,"rule constantData");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:5: ( type Identifier ';' -> ^( MEMBERDEC type Identifier ) | type Identifier Assign constantData ';' -> ^( MEMBERDEC type Identifier constantData ) )
            int alt7 = 2;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:9: type Identifier ';'
                    {
                    	PushFollow(FOLLOW_type_in_memberDeclaration618);
                    	type19 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_type.Add(type19.Tree);
                    	Identifier20=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberDeclaration620); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier20);

                    	char_literal21=(IToken)Match(input,143,FOLLOW_143_in_memberDeclaration622); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_143.Add(char_literal21);



                    	// AST REWRITE
                    	// elements:          Identifier, type
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 146:29: -> ^( MEMBERDEC type Identifier )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:32: ^( MEMBERDEC type Identifier )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBERDEC, "MEMBERDEC"), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:9: type Identifier Assign constantData ';'
                    {
                    	PushFollow(FOLLOW_type_in_memberDeclaration644);
                    	type22 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_type.Add(type22.Tree);
                    	Identifier23=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberDeclaration646); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier23);

                    	Assign24=(IToken)Match(input,Assign,FOLLOW_Assign_in_memberDeclaration648); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Assign.Add(Assign24);

                    	PushFollow(FOLLOW_constantData_in_memberDeclaration650);
                    	constantData25 = constantData();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_constantData.Add(constantData25.Tree);
                    	char_literal26=(IToken)Match(input,143,FOLLOW_143_in_memberDeclaration652); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_143.Add(char_literal26);



                    	// AST REWRITE
                    	// elements:          constantData, type, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 147:49: -> ^( MEMBERDEC type Identifier constantData )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:52: ^( MEMBERDEC type Identifier constantData )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBERDEC, "MEMBERDEC"), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    adaptor.AddChild(root_1, stream_constantData.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, memberDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberDeclaration"

    public class arrayType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arrayType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:156:1: arrayType : '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) ;
    public PsimulexParser.arrayType_return arrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayType_return retval = new PsimulexParser.arrayType_return();
        retval.Start = input.LT(1);
        int arrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal27 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;

        CommonTree char_literal27_tree=null;
        CommonTree char_literal28_tree=null;
        CommonTree char_literal29_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:2: ( '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:4: '[' ( ',' )* ']'
            {
            	char_literal27=(IToken)Match(input,146,FOLLOW_146_in_arrayType688); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_146.Add(char_literal27);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:8: ( ',' )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 147) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:10: ','
            			    {
            			    	char_literal28=(IToken)Match(input,147,FOLLOW_147_in_arrayType692); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal28);


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	char_literal29=(IToken)Match(input,148,FOLLOW_148_in_arrayType697); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_148.Add(char_literal29);



            	// AST REWRITE
            	// elements:          147, 148, 146
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 157:21: -> ^( DIMMARKER '[' ( ',' )* ']' )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:24: ^( DIMMARKER '[' ( ',' )* ']' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMMARKER, "DIMMARKER"), root_1);

            	    adaptor.AddChild(root_1, stream_146.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:41: ( ',' )*
            	    while ( stream_147.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_147.NextNode());

            	    }
            	    stream_147.Reset();
            	    adaptor.AddChild(root_1, stream_148.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, arrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayType"

    public class functionDeclarations_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "functionDeclarations"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:1: functionDeclarations : ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) ;
    public PsimulexParser.functionDeclarations_return functionDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclarations_return retval = new PsimulexParser.functionDeclarations_return();
        retval.Start = input.LT(1);
        int functionDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.functionDeclaration_return functionDeclaration30 = default(PsimulexParser.functionDeclaration_return);


        RewriteRuleSubtreeStream stream_functionDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule functionDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:5: ( ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:7: ( functionDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:7: ( functionDeclaration )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == Identifier || (LA9_0 >= Bool && LA9_0 <= Iterator)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: functionDeclaration
            			    {
            			    	PushFollow(FOLLOW_functionDeclaration_in_functionDeclarations736);
            			    	functionDeclaration30 = functionDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_functionDeclaration.Add(functionDeclaration30.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements



            	// AST REWRITE
            	// elements:          functionDeclaration
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 174:28: -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:31: ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION_DECLARATIONS, "FUNCTION_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:56: ( functionDeclaration )*
            	    while ( stream_functionDeclaration.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_functionDeclaration.NextTree());

            	    }
            	    stream_functionDeclaration.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, functionDeclarations_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionDeclarations"

    public class functionDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "functionDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:177:1: functionDeclaration : type ( Reference )? Identifier formalParameterList block -> ^( FUNCDEC type ( Reference )? Identifier ( formalParameterList )? block ) ;
    public PsimulexParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclaration_return retval = new PsimulexParser.functionDeclaration_return();
        retval.Start = input.LT(1);
        int functionDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference32 = null;
        IToken Identifier33 = null;
        PsimulexParser.type_return type31 = default(PsimulexParser.type_return);

        PsimulexParser.formalParameterList_return formalParameterList34 = default(PsimulexParser.formalParameterList_return);

        PsimulexParser.block_return block35 = default(PsimulexParser.block_return);


        CommonTree Reference32_tree=null;
        CommonTree Identifier33_tree=null;
        RewriteRuleTokenStream stream_Reference = new RewriteRuleTokenStream(adaptor,"token Reference");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_formalParameterList = new RewriteRuleSubtreeStream(adaptor,"rule formalParameterList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:5: ( type ( Reference )? Identifier formalParameterList block -> ^( FUNCDEC type ( Reference )? Identifier ( formalParameterList )? block ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:7: type ( Reference )? Identifier formalParameterList block
            {
            	PushFollow(FOLLOW_type_in_functionDeclaration769);
            	type31 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type31.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:12: ( Reference )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == Reference) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: Reference
            	        {
            	        	Reference32=(IToken)Match(input,Reference,FOLLOW_Reference_in_functionDeclaration771); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Reference.Add(Reference32);


            	        }
            	        break;

            	}

            	Identifier33=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration774); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier33);

            	PushFollow(FOLLOW_formalParameterList_in_functionDeclaration776);
            	formalParameterList34 = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_formalParameterList.Add(formalParameterList34.Tree);
            	PushFollow(FOLLOW_block_in_functionDeclaration779);
            	block35 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block35.Tree);


            	// AST REWRITE
            	// elements:          block, Identifier, type, formalParameterList, Reference
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 178:61: -> ^( FUNCDEC type ( Reference )? Identifier ( formalParameterList )? block )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:64: ^( FUNCDEC type ( Reference )? Identifier ( formalParameterList )? block )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCDEC, "FUNCDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:80: ( Reference )?
            	    if ( stream_Reference.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_Reference.NextNode());

            	    }
            	    stream_Reference.Reset();
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:102: ( formalParameterList )?
            	    if ( stream_formalParameterList.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_formalParameterList.NextTree());

            	    }
            	    stream_formalParameterList.Reset();
            	    adaptor.AddChild(root_1, stream_block.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, functionDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionDeclaration"

    public class formalParameterList_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "formalParameterList"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:1: formalParameterList : '(' ( formalParameter ( ',' formalParameter )* )? ')' -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? ) ;
    public PsimulexParser.formalParameterList_return formalParameterList() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameterList_return retval = new PsimulexParser.formalParameterList_return();
        retval.Start = input.LT(1);
        int formalParameterList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal36 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        PsimulexParser.formalParameter_return formalParameter37 = default(PsimulexParser.formalParameter_return);

        PsimulexParser.formalParameter_return formalParameter39 = default(PsimulexParser.formalParameter_return);


        CommonTree char_literal36_tree=null;
        CommonTree char_literal38_tree=null;
        CommonTree char_literal40_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleSubtreeStream stream_formalParameter = new RewriteRuleSubtreeStream(adaptor,"rule formalParameter");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:5: ( '(' ( formalParameter ( ',' formalParameter )* )? ')' -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:9: '(' ( formalParameter ( ',' formalParameter )* )? ')'
            {
            	char_literal36=(IToken)Match(input,149,FOLLOW_149_in_formalParameterList818); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_149.Add(char_literal36);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:13: ( formalParameter ( ',' formalParameter )* )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == Identifier || (LA12_0 >= Bool && LA12_0 <= Iterator)) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:15: formalParameter ( ',' formalParameter )*
            	        {
            	        	PushFollow(FOLLOW_formalParameter_in_formalParameterList822);
            	        	formalParameter37 = formalParameter();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_formalParameter.Add(formalParameter37.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:31: ( ',' formalParameter )*
            	        	do 
            	        	{
            	        	    int alt11 = 2;
            	        	    int LA11_0 = input.LA(1);

            	        	    if ( (LA11_0 == 147) )
            	        	    {
            	        	        alt11 = 1;
            	        	    }


            	        	    switch (alt11) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:32: ',' formalParameter
            	        			    {
            	        			    	char_literal38=(IToken)Match(input,147,FOLLOW_147_in_formalParameterList825); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal38);

            	        			    	PushFollow(FOLLOW_formalParameter_in_formalParameterList827);
            	        			    	formalParameter39 = formalParameter();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_formalParameter.Add(formalParameter39.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop11;
            	        	    }
            	        	} while (true);

            	        	loop11:
            	        		;	// Stops C# compiler whining that label 'loop11' has no statements


            	        }
            	        break;

            	}

            	char_literal40=(IToken)Match(input,150,FOLLOW_150_in_formalParameterList834); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_150.Add(char_literal40);



            	// AST REWRITE
            	// elements:          formalParameter, formalParameter
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 182:61: -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:64: ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORMAL_PARAMETER_LIST, "FORMAL_PARAMETER_LIST"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:89: ( formalParameter ( formalParameter )* )?
            	    if ( stream_formalParameter.HasNext() || stream_formalParameter.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_formalParameter.NextTree());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:107: ( formalParameter )*
            	        while ( stream_formalParameter.HasNext() )
            	        {
            	            adaptor.AddChild(root_1, stream_formalParameter.NextTree());

            	        }
            	        stream_formalParameter.Reset();

            	    }
            	    stream_formalParameter.Reset();
            	    stream_formalParameter.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, formalParameterList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameterList"

    public class formalParameter_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "formalParameter"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:1: formalParameter : type ( Reference )? Identifier -> ^( FORMAL_PARAMETER type ( Reference )? Identifier ) ;
    public PsimulexParser.formalParameter_return formalParameter() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameter_return retval = new PsimulexParser.formalParameter_return();
        retval.Start = input.LT(1);
        int formalParameter_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference42 = null;
        IToken Identifier43 = null;
        PsimulexParser.type_return type41 = default(PsimulexParser.type_return);


        CommonTree Reference42_tree=null;
        CommonTree Identifier43_tree=null;
        RewriteRuleTokenStream stream_Reference = new RewriteRuleTokenStream(adaptor,"token Reference");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:5: ( type ( Reference )? Identifier -> ^( FORMAL_PARAMETER type ( Reference )? Identifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:9: type ( Reference )? Identifier
            {
            	PushFollow(FOLLOW_type_in_formalParameter871);
            	type41 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type41.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:14: ( Reference )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == Reference) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: Reference
            	        {
            	        	Reference42=(IToken)Match(input,Reference,FOLLOW_Reference_in_formalParameter873); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Reference.Add(Reference42);


            	        }
            	        break;

            	}

            	Identifier43=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_formalParameter876); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier43);



            	// AST REWRITE
            	// elements:          Identifier, Reference, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 186:36: -> ^( FORMAL_PARAMETER type ( Reference )? Identifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:39: ^( FORMAL_PARAMETER type ( Reference )? Identifier )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORMAL_PARAMETER, "FORMAL_PARAMETER"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:64: ( Reference )?
            	    if ( stream_Reference.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_Reference.NextNode());

            	    }
            	    stream_Reference.Reset();
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, formalParameter_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameter"

    public class type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "type"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:195:1: type : dataType ( arrayType )? -> ^( TYPE dataType ( arrayType )? ) ;
    public PsimulexParser.type_return type() // throws RecognitionException [1]
    {   
        PsimulexParser.type_return retval = new PsimulexParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataType_return dataType44 = default(PsimulexParser.dataType_return);

        PsimulexParser.arrayType_return arrayType45 = default(PsimulexParser.arrayType_return);


        RewriteRuleSubtreeStream stream_dataType = new RewriteRuleSubtreeStream(adaptor,"rule dataType");
        RewriteRuleSubtreeStream stream_arrayType = new RewriteRuleSubtreeStream(adaptor,"rule arrayType");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:5: ( dataType ( arrayType )? -> ^( TYPE dataType ( arrayType )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:7: dataType ( arrayType )?
            {
            	PushFollow(FOLLOW_dataType_in_type922);
            	dataType44 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_dataType.Add(dataType44.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:16: ( arrayType )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 146) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: arrayType
            	        {
            	        	PushFollow(FOLLOW_arrayType_in_type924);
            	        	arrayType45 = arrayType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_arrayType.Add(arrayType45.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          arrayType, dataType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 196:27: -> ^( TYPE dataType ( arrayType )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:30: ^( TYPE dataType ( arrayType )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE, "TYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_dataType.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:47: ( arrayType )?
            	    if ( stream_arrayType.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_arrayType.NextTree());

            	    }
            	    stream_arrayType.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, type_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "type"

    public class dataType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "dataType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:205:1: dataType : dataTypeName -> ^( DATATYPE dataTypeName ) ;
    public PsimulexParser.dataType_return dataType() // throws RecognitionException [1]
    {   
        PsimulexParser.dataType_return retval = new PsimulexParser.dataType_return();
        retval.Start = input.LT(1);
        int dataType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataTypeName_return dataTypeName46 = default(PsimulexParser.dataTypeName_return);


        RewriteRuleSubtreeStream stream_dataTypeName = new RewriteRuleSubtreeStream(adaptor,"rule dataTypeName");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:2: ( dataTypeName -> ^( DATATYPE dataTypeName ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:4: dataTypeName
            {
            	PushFollow(FOLLOW_dataTypeName_in_dataType957);
            	dataTypeName46 = dataTypeName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_dataTypeName.Add(dataTypeName46.Tree);


            	// AST REWRITE
            	// elements:          dataTypeName
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 206:17: -> ^( DATATYPE dataTypeName )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:20: ^( DATATYPE dataTypeName )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DATATYPE, "DATATYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_dataTypeName.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, dataType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "dataType"

    public class dataTypeName_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "dataTypeName"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:1: dataTypeName : ( primitiveType | builtInType | userDefinedTypes );
    public PsimulexParser.dataTypeName_return dataTypeName() // throws RecognitionException [1]
    {   
        PsimulexParser.dataTypeName_return retval = new PsimulexParser.dataTypeName_return();
        retval.Start = input.LT(1);
        int dataTypeName_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primitiveType_return primitiveType47 = default(PsimulexParser.primitiveType_return);

        PsimulexParser.builtInType_return builtInType48 = default(PsimulexParser.builtInType_return);

        PsimulexParser.userDefinedTypes_return userDefinedTypes49 = default(PsimulexParser.userDefinedTypes_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:2: ( primitiveType | builtInType | userDefinedTypes )
            int alt15 = 3;
            switch ( input.LA(1) ) 
            {
            case Bool:
            case Char:
            case Int:
            case Decimal:
            case String:
            case Void:
            	{
                alt15 = 1;
                }
                break;
            case Tree:
            case BinTree:
            case Set:
            case List:
            case Stack:
            case Queue:
            case PQueue:
            case Graph:
            case Node:
            case Edge:
            case Thread:
            case Iterator:
            	{
                alt15 = 2;
                }
                break;
            case Identifier:
            	{
                alt15 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:4: primitiveType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primitiveType_in_dataTypeName978);
                    	primitiveType47 = primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType47.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:20: builtInType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtInType_in_dataTypeName982);
                    	builtInType48 = builtInType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType48.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:34: userDefinedTypes
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_userDefinedTypes_in_dataTypeName986);
                    	userDefinedTypes49 = userDefinedTypes();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, userDefinedTypes49.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, dataTypeName_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "dataTypeName"

    public class userDefinedTypes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "userDefinedTypes"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:1: userDefinedTypes : Identifier ;
    public PsimulexParser.userDefinedTypes_return userDefinedTypes() // throws RecognitionException [1]
    {   
        PsimulexParser.userDefinedTypes_return retval = new PsimulexParser.userDefinedTypes_return();
        retval.Start = input.LT(1);
        int userDefinedTypes_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier50 = null;

        CommonTree Identifier50_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier50=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_userDefinedTypes998); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier50_tree = (CommonTree)adaptor.Create(Identifier50);
            		adaptor.AddChild(root_0, Identifier50_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, userDefinedTypes_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "userDefinedTypes"

    public class primitiveType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "primitiveType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:1: primitiveType : ( Bool | Char | Int | Decimal | String | Void );
    public PsimulexParser.primitiveType_return primitiveType() // throws RecognitionException [1]
    {   
        PsimulexParser.primitiveType_return retval = new PsimulexParser.primitiveType_return();
        retval.Start = input.LT(1);
        int primitiveType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set51 = null;

        CommonTree set51_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:218:5: ( Bool | Char | Int | Decimal | String | Void )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set51 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Bool && input.LA(1) <= Void) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set51));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, primitiveType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "primitiveType"

    public class builtInType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "builtInType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:227:1: builtInType : ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Graph | Node | Edge | Thread | Iterator );
    public PsimulexParser.builtInType_return builtInType() // throws RecognitionException [1]
    {   
        PsimulexParser.builtInType_return retval = new PsimulexParser.builtInType_return();
        retval.Start = input.LT(1);
        int builtInType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set52 = null;

        CommonTree set52_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:5: ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Graph | Node | Edge | Thread | Iterator )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set52 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= Iterator) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set52));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, builtInType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "builtInType"

    public class expression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:264:1: expression : exp -> ^( EXPRESSION exp ) ;
    public PsimulexParser.expression_return expression() // throws RecognitionException [1]
    {   
        PsimulexParser.expression_return retval = new PsimulexParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.exp_return exp53 = default(PsimulexParser.exp_return);


        RewriteRuleSubtreeStream stream_exp = new RewriteRuleSubtreeStream(adaptor,"rule exp");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:265:2: ( exp -> ^( EXPRESSION exp ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:265:4: exp
            {
            	PushFollow(FOLLOW_exp_in_expression1155);
            	exp53 = exp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_exp.Add(exp53.Tree);


            	// AST REWRITE
            	// elements:          exp
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 265:8: -> ^( EXPRESSION exp )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:265:11: ^( EXPRESSION exp )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPRESSION, "EXPRESSION"), root_1);

            	    adaptor.AddChild(root_1, stream_exp.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, expression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class exp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:268:1: exp : ( assignment | conditionalOrExpression );
    public PsimulexParser.exp_return exp() // throws RecognitionException [1]
    {   
        PsimulexParser.exp_return retval = new PsimulexParser.exp_return();
        retval.Start = input.LT(1);
        int exp_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.assignment_return assignment54 = default(PsimulexParser.assignment_return);

        PsimulexParser.conditionalOrExpression_return conditionalOrExpression55 = default(PsimulexParser.conditionalOrExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:2: ( assignment | conditionalOrExpression )
            int alt16 = 2;
            switch ( input.LA(1) ) 
            {
            case Reference:
            	{
                int LA16_1 = input.LA(2);

                if ( (synpred33_Psimulex()) )
                {
                    alt16 = 1;
                }
                else if ( (true) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s1 =
                        new NoViableAltException("", 16, 1, input);

                    throw nvae_d16s1;
                }
                }
                break;
            case Identifier:
            	{
                int LA16_2 = input.LA(2);

                if ( (synpred33_Psimulex()) )
                {
                    alt16 = 1;
                }
                else if ( (true) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s2 =
                        new NoViableAltException("", 16, 2, input);

                    throw nvae_d16s2;
                }
                }
                break;
            case 149:
            	{
                int LA16_3 = input.LA(2);

                if ( (synpred33_Psimulex()) )
                {
                    alt16 = 1;
                }
                else if ( (true) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s3 =
                        new NoViableAltException("", 16, 3, input);

                    throw nvae_d16s3;
                }
                }
                break;
            case StringLiteral:
            case Minus:
            case LogicalNot:
            case PlusPlus:
            case MinusMinus:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            case New:
            	{
                alt16 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_exp1177);
                    	assignment54 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment54.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:17: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_exp1181);
                    	conditionalOrExpression55 = conditionalOrExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression55.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, exp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "exp"

    public class assignment_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignment"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:272:1: assignment : leftValue assignmentOperator exp ;
    public PsimulexParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        PsimulexParser.assignment_return retval = new PsimulexParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue56 = default(PsimulexParser.leftValue_return);

        PsimulexParser.assignmentOperator_return assignmentOperator57 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.exp_return exp58 = default(PsimulexParser.exp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:273:2: ( leftValue assignmentOperator exp )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:273:4: leftValue assignmentOperator exp
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_leftValue_in_assignment1194);
            	leftValue56 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue56.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment1196);
            	assignmentOperator57 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assignmentOperator57.Tree, root_0);
            	PushFollow(FOLLOW_exp_in_assignment1199);
            	exp58 = exp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exp58.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, assignment_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class assignmentOperator_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignmentOperator"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:276:1: assignmentOperator : ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo );
    public PsimulexParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        PsimulexParser.assignmentOperator_return retval = new PsimulexParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set59 = null;

        CommonTree set59_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:277:2: ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set59 = (IToken)input.LT(1);
            	if ( input.LA(1) == Assign || (input.LA(1) >= AssignAndAdd && input.LA(1) <= AssignAndModulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set59));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, assignmentOperator_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "assignmentOperator"

    public class conditionalOrExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "conditionalOrExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:280:1: conditionalOrExpression : conditionalAndExpression ( LogicalOr conditionalAndExpression )* ;
    public PsimulexParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalOrExpression_return retval = new PsimulexParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalOr61 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression60 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression62 = default(PsimulexParser.conditionalAndExpression_return);


        CommonTree LogicalOr61_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:281:5: ( conditionalAndExpression ( LogicalOr conditionalAndExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:281:9: conditionalAndExpression ( LogicalOr conditionalAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1240);
            	conditionalAndExpression60 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression60.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:281:34: ( LogicalOr conditionalAndExpression )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == LogicalOr) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:281:36: LogicalOr conditionalAndExpression
            			    {
            			    	LogicalOr61=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression1244); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalOr61_tree = (CommonTree)adaptor.Create(LogicalOr61);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalOr61_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1247);
            			    	conditionalAndExpression62 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression62.Tree);

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, conditionalOrExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "conditionalOrExpression"

    public class conditionalAndExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "conditionalAndExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:284:1: conditionalAndExpression : equalityExpression ( LogicalAnd equalityExpression )* ;
    public PsimulexParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalAndExpression_return retval = new PsimulexParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalAnd64 = null;
        PsimulexParser.equalityExpression_return equalityExpression63 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression65 = default(PsimulexParser.equalityExpression_return);


        CommonTree LogicalAnd64_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:285:5: ( equalityExpression ( LogicalAnd equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:285:9: equalityExpression ( LogicalAnd equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1269);
            	equalityExpression63 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression63.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:285:28: ( LogicalAnd equalityExpression )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == LogicalAnd) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:285:30: LogicalAnd equalityExpression
            			    {
            			    	LogicalAnd64=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression1273); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd64_tree = (CommonTree)adaptor.Create(LogicalAnd64);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd64_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1276);
            			    	equalityExpression65 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression65.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, conditionalAndExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "conditionalAndExpression"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:288:1: equalityExpression : relationalExpression ( equalityOp relationalExpression )* ;
    public PsimulexParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityExpression_return retval = new PsimulexParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.relationalExpression_return relationalExpression66 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.equalityOp_return equalityOp67 = default(PsimulexParser.equalityOp_return);

        PsimulexParser.relationalExpression_return relationalExpression68 = default(PsimulexParser.relationalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:5: ( relationalExpression ( equalityOp relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:9: relationalExpression ( equalityOp relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1298);
            	relationalExpression66 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression66.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:30: ( equalityOp relationalExpression )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( ((LA19_0 >= RelEqual && LA19_0 <= RelNotEqual)) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:32: equalityOp relationalExpression
            			    {
            			    	PushFollow(FOLLOW_equalityOp_in_equalityExpression1302);
            			    	equalityOp67 = equalityOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp67.Tree, root_0);
            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1305);
            			    	relationalExpression68 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression68.Tree);

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 27, equalityExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public class equalityOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "equalityOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:292:1: equalityOp : ( RelEqual | RelNotEqual );
    public PsimulexParser.equalityOp_return equalityOp() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityOp_return retval = new PsimulexParser.equalityOp_return();
        retval.Start = input.LT(1);
        int equalityOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set69 = null;

        CommonTree set69_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:2: ( RelEqual | RelNotEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set69 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelEqual && input.LA(1) <= RelNotEqual) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set69));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 28, equalityOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "equalityOp"

    public class relationalExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:296:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
    public PsimulexParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalExpression_return retval = new PsimulexParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.additiveExpression_return additiveExpression70 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp71 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression72 = default(PsimulexParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1340);
            	additiveExpression70 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression70.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:28: ( relationalOp additiveExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= RelLessThan && LA20_0 <= RelGreaterThanOrEqual)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression1344);
            			    	relationalOp71 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp71.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1347);
            			    	additiveExpression72 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression72.Tree);

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 29, relationalExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "relationalExpression"

    public class relationalOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationalOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:300:1: relationalOp : ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual );
    public PsimulexParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalOp_return retval = new PsimulexParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set73 = null;

        CommonTree set73_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:5: ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set73 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelLessThan && input.LA(1) <= RelGreaterThanOrEqual) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set73));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 30, relationalOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "relationalOp"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:304:1: additiveExpression : multiplicativeExpression ( additiveOp multiplicativeExpression )* ;
    public PsimulexParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveExpression_return retval = new PsimulexParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression74 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.additiveOp_return additiveOp75 = default(PsimulexParser.additiveOp_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression76 = default(PsimulexParser.multiplicativeExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:5: ( multiplicativeExpression ( additiveOp multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:9: multiplicativeExpression ( additiveOp multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1400);
            	multiplicativeExpression74 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression74.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:34: ( additiveOp multiplicativeExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( ((LA21_0 >= Plus && LA21_0 <= Minus)) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:36: additiveOp multiplicativeExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression1404);
            			    	additiveOp75 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp75.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1407);
            			    	multiplicativeExpression76 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression76.Tree);

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 31, additiveExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class additiveOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additiveOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:308:1: additiveOp : ( Plus | Minus );
    public PsimulexParser.additiveOp_return additiveOp() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveOp_return retval = new PsimulexParser.additiveOp_return();
        retval.Start = input.LT(1);
        int additiveOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set77 = null;

        CommonTree set77_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:2: ( Plus | Minus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set77 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set77));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 32, additiveOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "additiveOp"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:312:1: multiplicativeExpression : unaryExpression ( multiplicativeOp unaryExpression )* ;
    public PsimulexParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeExpression_return retval = new PsimulexParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryExpression_return unaryExpression78 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.multiplicativeOp_return multiplicativeOp79 = default(PsimulexParser.multiplicativeOp_return);

        PsimulexParser.unaryExpression_return unaryExpression80 = default(PsimulexParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:5: ( unaryExpression ( multiplicativeOp unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:9: unaryExpression ( multiplicativeOp unaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1442);
            	unaryExpression78 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression78.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:25: ( multiplicativeOp unaryExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( ((LA22_0 >= Star && LA22_0 <= Modulo)) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:27: multiplicativeOp unaryExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression1446);
            			    	multiplicativeOp79 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp79.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1449);
            			    	unaryExpression80 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression80.Tree);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 33, multiplicativeExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class multiplicativeOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:316:1: multiplicativeOp : ( Star | Divide | Modulo );
    public PsimulexParser.multiplicativeOp_return multiplicativeOp() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeOp_return retval = new PsimulexParser.multiplicativeOp_return();
        retval.Start = input.LT(1);
        int multiplicativeOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set81 = null;

        CommonTree set81_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:2: ( Star | Divide | Modulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set81 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Star && input.LA(1) <= Modulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set81));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 34, multiplicativeOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multiplicativeOp"

    public class unaryExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:320:1: unaryExpression : ( unaryPrefixExpression | unaryPostfixExpression | castExpression );
    public PsimulexParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpression_return retval = new PsimulexParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixExpression_return unaryPrefixExpression82 = default(PsimulexParser.unaryPrefixExpression_return);

        PsimulexParser.unaryPostfixExpression_return unaryPostfixExpression83 = default(PsimulexParser.unaryPostfixExpression_return);

        PsimulexParser.castExpression_return castExpression84 = default(PsimulexParser.castExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:5: ( unaryPrefixExpression | unaryPostfixExpression | castExpression )
            int alt23 = 3;
            switch ( input.LA(1) ) 
            {
            case Minus:
            case LogicalNot:
            	{
                alt23 = 1;
                }
                break;
            case StringLiteral:
            case Identifier:
            case Reference:
            case PlusPlus:
            case MinusMinus:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            case New:
            	{
                alt23 = 2;
                }
                break;
            case 149:
            	{
                int LA23_4 = input.LA(2);

                if ( (synpred53_Psimulex()) )
                {
                    alt23 = 2;
                }
                else if ( (true) )
                {
                    alt23 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d23s4 =
                        new NoViableAltException("", 23, 4, input);

                    throw nvae_d23s4;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d23s0 =
            	        new NoViableAltException("", 23, 0, input);

            	    throw nvae_d23s0;
            }

            switch (alt23) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:7: unaryPrefixExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPrefixExpression_in_unaryExpression1484);
                    	unaryPrefixExpression82 = unaryPrefixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPrefixExpression82.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:7: unaryPostfixExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPostfixExpression_in_unaryExpression1492);
                    	unaryPostfixExpression83 = unaryPostfixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPostfixExpression83.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:4: castExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpression1497);
                    	castExpression84 = castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, castExpression84.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 35, unaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class unaryPrefixExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryPrefixExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:326:1: unaryPrefixExpression : unaryPrefixOp unaryExpression -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) ) ;
    public PsimulexParser.unaryPrefixExpression_return unaryPrefixExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixExpression_return retval = new PsimulexParser.unaryPrefixExpression_return();
        retval.Start = input.LT(1);
        int unaryPrefixExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixOp_return unaryPrefixOp85 = default(PsimulexParser.unaryPrefixOp_return);

        PsimulexParser.unaryExpression_return unaryExpression86 = default(PsimulexParser.unaryExpression_return);


        RewriteRuleSubtreeStream stream_unaryPrefixOp = new RewriteRuleSubtreeStream(adaptor,"rule unaryPrefixOp");
        RewriteRuleSubtreeStream stream_unaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule unaryExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:2: ( unaryPrefixOp unaryExpression -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:4: unaryPrefixOp unaryExpression
            {
            	PushFollow(FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1511);
            	unaryPrefixOp85 = unaryPrefixOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_unaryPrefixOp.Add(unaryPrefixOp85.Tree);
            	PushFollow(FOLLOW_unaryExpression_in_unaryPrefixExpression1513);
            	unaryExpression86 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_unaryExpression.Add(unaryExpression86.Tree);


            	// AST REWRITE
            	// elements:          unaryPrefixOp, unaryExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 327:34: -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:37: ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PREFIXOP, "PREFIXOP"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:49: ^( unaryPrefixOp unaryExpression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_unaryPrefixOp.NextNode(), root_2);

            	    adaptor.AddChild(root_2, stream_unaryExpression.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 36, unaryPrefixExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryPrefixExpression"

    public class unaryPostfixExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryPostfixExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:330:1: unaryPostfixExpression : ( leftValueExpression ( unaryPostfixOp )? | primaryExpression );
    public PsimulexParser.unaryPostfixExpression_return unaryPostfixExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixExpression_return retval = new PsimulexParser.unaryPostfixExpression_return();
        retval.Start = input.LT(1);
        int unaryPostfixExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValueExpression_return leftValueExpression87 = default(PsimulexParser.leftValueExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp88 = default(PsimulexParser.unaryPostfixOp_return);

        PsimulexParser.primaryExpression_return primaryExpression89 = default(PsimulexParser.primaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:2: ( leftValueExpression ( unaryPostfixOp )? | primaryExpression )
            int alt25 = 2;
            switch ( input.LA(1) ) 
            {
            case Reference:
            	{
                int LA25_1 = input.LA(2);

                if ( (synpred55_Psimulex()) )
                {
                    alt25 = 1;
                }
                else if ( (true) )
                {
                    alt25 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d25s1 =
                        new NoViableAltException("", 25, 1, input);

                    throw nvae_d25s1;
                }
                }
                break;
            case Identifier:
            	{
                int LA25_2 = input.LA(2);

                if ( (synpred55_Psimulex()) )
                {
                    alt25 = 1;
                }
                else if ( (true) )
                {
                    alt25 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d25s2 =
                        new NoViableAltException("", 25, 2, input);

                    throw nvae_d25s2;
                }
                }
                break;
            case 149:
            	{
                int LA25_3 = input.LA(2);

                if ( (synpred55_Psimulex()) )
                {
                    alt25 = 1;
                }
                else if ( (true) )
                {
                    alt25 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d25s3 =
                        new NoViableAltException("", 25, 3, input);

                    throw nvae_d25s3;
                }
                }
                break;
            case PlusPlus:
            case MinusMinus:
            	{
                alt25 = 1;
                }
                break;
            case StringLiteral:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            case New:
            	{
                alt25 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d25s0 =
            	        new NoViableAltException("", 25, 0, input);

            	    throw nvae_d25s0;
            }

            switch (alt25) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:4: leftValueExpression ( unaryPostfixOp )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValueExpression_in_unaryPostfixExpression1543);
                    	leftValueExpression87 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValueExpression87.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:24: ( unaryPostfixOp )?
                    	int alt24 = 2;
                    	int LA24_0 = input.LA(1);

                    	if ( ((LA24_0 >= PlusPlus && LA24_0 <= MinusMinus)) )
                    	{
                    	    alt24 = 1;
                    	}
                    	switch (alt24) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:25: unaryPostfixOp
                    	        {
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1546);
                    	        	unaryPostfixOp88 = unaryPostfixOp();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp88.Tree, root_0);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:332:4: primaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryPostfixExpression1554);
                    	primaryExpression89 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression89.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 37, unaryPostfixExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryPostfixExpression"

    public class leftValueExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "leftValueExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:335:1: leftValueExpression : ( leftValue | unaryPrefixAssignerOp leftValueExpression -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) ) );
    public PsimulexParser.leftValueExpression_return leftValueExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValueExpression_return retval = new PsimulexParser.leftValueExpression_return();
        retval.Start = input.LT(1);
        int leftValueExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue90 = default(PsimulexParser.leftValue_return);

        PsimulexParser.unaryPrefixAssignerOp_return unaryPrefixAssignerOp91 = default(PsimulexParser.unaryPrefixAssignerOp_return);

        PsimulexParser.leftValueExpression_return leftValueExpression92 = default(PsimulexParser.leftValueExpression_return);


        RewriteRuleSubtreeStream stream_leftValueExpression = new RewriteRuleSubtreeStream(adaptor,"rule leftValueExpression");
        RewriteRuleSubtreeStream stream_unaryPrefixAssignerOp = new RewriteRuleSubtreeStream(adaptor,"rule unaryPrefixAssignerOp");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:336:2: ( leftValue | unaryPrefixAssignerOp leftValueExpression -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) ) )
            int alt26 = 2;
            int LA26_0 = input.LA(1);

            if ( (LA26_0 == Identifier || LA26_0 == Reference || LA26_0 == 149) )
            {
                alt26 = 1;
            }
            else if ( ((LA26_0 >= PlusPlus && LA26_0 <= MinusMinus)) )
            {
                alt26 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:336:4: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_leftValueExpression1565);
                    	leftValue90 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue90.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:4: unaryPrefixAssignerOp leftValueExpression
                    {
                    	PushFollow(FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1570);
                    	unaryPrefixAssignerOp91 = unaryPrefixAssignerOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_unaryPrefixAssignerOp.Add(unaryPrefixAssignerOp91.Tree);
                    	PushFollow(FOLLOW_leftValueExpression_in_leftValueExpression1572);
                    	leftValueExpression92 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_leftValueExpression.Add(leftValueExpression92.Tree);


                    	// AST REWRITE
                    	// elements:          unaryPrefixAssignerOp, leftValueExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 337:46: -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:49: ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PREFIXOP, "PREFIXOP"), root_1);

                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:61: ^( unaryPrefixAssignerOp leftValueExpression )
                    	    {
                    	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
                    	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_unaryPrefixAssignerOp.NextNode(), root_2);

                    	    adaptor.AddChild(root_2, stream_leftValueExpression.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 38, leftValueExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "leftValueExpression"

    public class castExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "castExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:340:1: castExpression : '(' dataType ')' unaryExpression -> ^( CAST dataType unaryExpression ) ;
    public PsimulexParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.castExpression_return retval = new PsimulexParser.castExpression_return();
        retval.Start = input.LT(1);
        int castExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal93 = null;
        IToken char_literal95 = null;
        PsimulexParser.dataType_return dataType94 = default(PsimulexParser.dataType_return);

        PsimulexParser.unaryExpression_return unaryExpression96 = default(PsimulexParser.unaryExpression_return);


        CommonTree char_literal93_tree=null;
        CommonTree char_literal95_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleSubtreeStream stream_dataType = new RewriteRuleSubtreeStream(adaptor,"rule dataType");
        RewriteRuleSubtreeStream stream_unaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule unaryExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:2: ( '(' dataType ')' unaryExpression -> ^( CAST dataType unaryExpression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:4: '(' dataType ')' unaryExpression
            {
            	char_literal93=(IToken)Match(input,149,FOLLOW_149_in_castExpression1603); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_149.Add(char_literal93);

            	PushFollow(FOLLOW_dataType_in_castExpression1605);
            	dataType94 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_dataType.Add(dataType94.Tree);
            	char_literal95=(IToken)Match(input,150,FOLLOW_150_in_castExpression1607); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_150.Add(char_literal95);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1609);
            	unaryExpression96 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_unaryExpression.Add(unaryExpression96.Tree);


            	// AST REWRITE
            	// elements:          unaryExpression, dataType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 341:37: -> ^( CAST dataType unaryExpression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:40: ^( CAST dataType unaryExpression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CAST, "CAST"), root_1);

            	    adaptor.AddChild(root_1, stream_dataType.NextTree());
            	    adaptor.AddChild(root_1, stream_unaryExpression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 39, castExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "castExpression"

    public class unaryPrefixOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryPrefixOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:344:1: unaryPrefixOp : ( Minus | LogicalNot );
    public PsimulexParser.unaryPrefixOp_return unaryPrefixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixOp_return retval = new PsimulexParser.unaryPrefixOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set97 = null;

        CommonTree set97_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:345:2: ( Minus | LogicalNot )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set97 = (IToken)input.LT(1);
            	if ( input.LA(1) == Minus || input.LA(1) == LogicalNot ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set97));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 40, unaryPrefixOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryPrefixOp"

    public class unaryPrefixAssignerOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryPrefixAssignerOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:348:1: unaryPrefixAssignerOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPrefixAssignerOp_return unaryPrefixAssignerOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixAssignerOp_return retval = new PsimulexParser.unaryPrefixAssignerOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixAssignerOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set98 = null;

        CommonTree set98_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:349:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set98 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set98));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 41, unaryPrefixAssignerOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryPrefixAssignerOp"

    public class unaryPostfixOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryPostfixOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:352:1: unaryPostfixOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPostfixOp_return unaryPostfixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixOp_return retval = new PsimulexParser.unaryPostfixOp_return();
        retval.Start = input.LT(1);
        int unaryPostfixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set99 = null;

        CommonTree set99_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:353:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set99 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set99));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 42, unaryPostfixOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryPostfixOp"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:356:1: primaryExpression : ( parExpression | leftValue | literal | functionCall | initializer );
    public PsimulexParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.primaryExpression_return retval = new PsimulexParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression100 = default(PsimulexParser.parExpression_return);

        PsimulexParser.leftValue_return leftValue101 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal102 = default(PsimulexParser.literal_return);

        PsimulexParser.functionCall_return functionCall103 = default(PsimulexParser.functionCall_return);

        PsimulexParser.initializer_return initializer104 = default(PsimulexParser.initializer_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:5: ( parExpression | leftValue | literal | functionCall | initializer )
            int alt27 = 5;
            switch ( input.LA(1) ) 
            {
            case 149:
            	{
                int LA27_1 = input.LA(2);

                if ( (synpred60_Psimulex()) )
                {
                    alt27 = 1;
                }
                else if ( (synpred61_Psimulex()) )
                {
                    alt27 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d27s1 =
                        new NoViableAltException("", 27, 1, input);

                    throw nvae_d27s1;
                }
                }
                break;
            case Reference:
            	{
                alt27 = 2;
                }
                break;
            case Identifier:
            	{
                int LA27_3 = input.LA(2);

                if ( (synpred61_Psimulex()) )
                {
                    alt27 = 2;
                }
                else if ( (synpred63_Psimulex()) )
                {
                    alt27 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d27s3 =
                        new NoViableAltException("", 27, 3, input);

                    throw nvae_d27s3;
                }
                }
                break;
            case StringLiteral:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            	{
                alt27 = 3;
                }
                break;
            case New:
            	{
                alt27 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            }

            switch (alt27) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:9: parExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1678);
                    	parExpression100 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression100.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1686);
                    	leftValue101 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue101.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1696);
                    	literal102 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal102.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:7: functionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionCall_in_primaryExpression1704);
                    	functionCall103 = functionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall103.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:361:7: initializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_initializer_in_primaryExpression1712);
                    	initializer104 = initializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer104.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 43, primaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class parExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "parExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:364:1: parExpression : '(' expression ')' ;
    public PsimulexParser.parExpression_return parExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.parExpression_return retval = new PsimulexParser.parExpression_return();
        retval.Start = input.LT(1);
        int parExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal105 = null;
        IToken char_literal107 = null;
        PsimulexParser.expression_return expression106 = default(PsimulexParser.expression_return);


        CommonTree char_literal105_tree=null;
        CommonTree char_literal107_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:5: ( '(' expression ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:9: '(' expression ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal105=(IToken)Match(input,149,FOLLOW_149_in_parExpression1731); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1734);
            	expression106 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression106.Tree);
            	char_literal107=(IToken)Match(input,150,FOLLOW_150_in_parExpression1736); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 44, parExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "parExpression"

    public class leftValue_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "leftValue"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:368:1: leftValue : ( variable | selecting );
    public PsimulexParser.leftValue_return leftValue() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValue_return retval = new PsimulexParser.leftValue_return();
        retval.Start = input.LT(1);
        int leftValue_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.variable_return variable108 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting109 = default(PsimulexParser.selecting_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:2: ( variable | selecting )
            int alt28 = 2;
            switch ( input.LA(1) ) 
            {
            case Reference:
            	{
                alt28 = 1;
                }
                break;
            case Identifier:
            	{
                int LA28_2 = input.LA(2);

                if ( (LA28_2 == 146 || LA28_2 == 149 || LA28_2 == 151) )
                {
                    alt28 = 2;
                }
                else if ( (LA28_2 == EOF || LA28_2 == Assign || (LA28_2 >= AssignAndAdd && LA28_2 <= Modulo) || (LA28_2 >= PlusPlus && LA28_2 <= MinusMinus) || LA28_2 == To || LA28_2 == 143 || LA28_2 == 145 || (LA28_2 >= 147 && LA28_2 <= 148) || LA28_2 == 150) )
                {
                    alt28 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d28s2 =
                        new NoViableAltException("", 28, 2, input);

                    throw nvae_d28s2;
                }
                }
                break;
            case 149:
            	{
                alt28 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d28s0 =
            	        new NoViableAltException("", 28, 0, input);

            	    throw nvae_d28s0;
            }

            switch (alt28) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1751);
                    	variable108 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable108.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:370:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1756);
                    	selecting109 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting109.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 45, leftValue_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "leftValue"

    public class variable_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variable"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:1: variable : ( Reference )? Identifier -> ^( Identifier ( Reference )? ) ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference110 = null;
        IToken Identifier111 = null;

        CommonTree Reference110_tree=null;
        CommonTree Identifier111_tree=null;
        RewriteRuleTokenStream stream_Reference = new RewriteRuleTokenStream(adaptor,"token Reference");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:374:2: ( ( Reference )? Identifier -> ^( Identifier ( Reference )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:374:4: ( Reference )? Identifier
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:374:4: ( Reference )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == Reference) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: Reference
            	        {
            	        	Reference110=(IToken)Match(input,Reference,FOLLOW_Reference_in_variable1767); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Reference.Add(Reference110);


            	        }
            	        break;

            	}

            	Identifier111=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1770); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier111);



            	// AST REWRITE
            	// elements:          Reference, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 374:26: -> ^( Identifier ( Reference )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:374:29: ^( Identifier ( Reference )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_Identifier.NextNode(), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:374:43: ( Reference )?
            	    if ( stream_Reference.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_Reference.NextNode());

            	    }
            	    stream_Reference.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 46, variable_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class selecting_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selecting"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:1: selecting : selector -> ^( SELECTOR selector ) ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.selector_return selector112 = default(PsimulexParser.selector_return);


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:378:2: ( selector -> ^( SELECTOR selector ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:378:4: selector
            {
            	PushFollow(FOLLOW_selector_in_selecting1792);
            	selector112 = selector();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_selector.Add(selector112.Tree);


            	// AST REWRITE
            	// elements:          selector
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 378:13: -> ^( SELECTOR selector )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:378:16: ^( SELECTOR selector )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SELECTOR, "SELECTOR"), root_1);

            	    adaptor.AddChild(root_1, stream_selector.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 47, selecting_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "selecting"

    public class selector_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selector"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:381:1: selector : ( Identifier | parExpression | functionCall ) ( memberSelect | memberFunctionCall | indexing )+ ;
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier113 = null;
        PsimulexParser.parExpression_return parExpression114 = default(PsimulexParser.parExpression_return);

        PsimulexParser.functionCall_return functionCall115 = default(PsimulexParser.functionCall_return);

        PsimulexParser.memberSelect_return memberSelect116 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall117 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing118 = default(PsimulexParser.indexing_return);


        CommonTree Identifier113_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:5: ( ( Identifier | parExpression | functionCall ) ( memberSelect | memberFunctionCall | indexing )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:9: ( Identifier | parExpression | functionCall ) ( memberSelect | memberFunctionCall | indexing )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:9: ( Identifier | parExpression | functionCall )
            	int alt30 = 3;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == Identifier) )
            	{
            	    int LA30_1 = input.LA(2);

            	    if ( (LA30_1 == 149) )
            	    {
            	        alt30 = 3;
            	    }
            	    else if ( (LA30_1 == 146 || LA30_1 == 151) )
            	    {
            	        alt30 = 1;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d30s1 =
            	            new NoViableAltException("", 30, 1, input);

            	        throw nvae_d30s1;
            	    }
            	}
            	else if ( (LA30_0 == 149) )
            	{
            	    alt30 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d30s0 =
            	        new NoViableAltException("", 30, 0, input);

            	    throw nvae_d30s0;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:11: Identifier
            	        {
            	        	Identifier113=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selector1820); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier113_tree = (CommonTree)adaptor.Create(Identifier113);
            	        		adaptor.AddChild(root_0, Identifier113_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:24: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selector1824);
            	        	parExpression114 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression114.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:40: functionCall
            	        {
            	        	PushFollow(FOLLOW_functionCall_in_selector1828);
            	        	functionCall115 = functionCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall115.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:6: ( memberSelect | memberFunctionCall | indexing )+
            	int cnt31 = 0;
            	do 
            	{
            	    int alt31 = 4;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == 151) )
            	    {
            	        int LA31_2 = input.LA(2);

            	        if ( (LA31_2 == Identifier) )
            	        {
            	            int LA31_4 = input.LA(3);

            	            if ( (LA31_4 == 149) )
            	            {
            	                alt31 = 2;
            	            }
            	            else if ( (LA31_4 == EOF || LA31_4 == Assign || (LA31_4 >= AssignAndAdd && LA31_4 <= Modulo) || (LA31_4 >= PlusPlus && LA31_4 <= MinusMinus) || LA31_4 == To || LA31_4 == 143 || (LA31_4 >= 145 && LA31_4 <= 148) || (LA31_4 >= 150 && LA31_4 <= 151)) )
            	            {
            	                alt31 = 1;
            	            }


            	        }


            	    }
            	    else if ( (LA31_0 == 146) )
            	    {
            	        alt31 = 3;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:8: memberSelect
            			    {
            			    	PushFollow(FOLLOW_memberSelect_in_selector1839);
            			    	memberSelect116 = memberSelect();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect116.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:23: memberFunctionCall
            			    {
            			    	PushFollow(FOLLOW_memberFunctionCall_in_selector1843);
            			    	memberFunctionCall117 = memberFunctionCall();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall117.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:44: indexing
            			    {
            			    	PushFollow(FOLLOW_indexing_in_selector1847);
            			    	indexing118 = indexing();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing118.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt31 >= 1 ) goto loop31;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee31 =
            		                new EarlyExitException(31, input);
            		            throw eee31;
            	    }
            	    cnt31++;
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whinging that label 'loop31' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 48, selector_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "selector"

    public class memberSelect_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "memberSelect"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:386:1: memberSelect : '.' Identifier -> ^( MEMBER_SELECT Identifier ) ;
    public PsimulexParser.memberSelect_return memberSelect() // throws RecognitionException [1]
    {   
        PsimulexParser.memberSelect_return retval = new PsimulexParser.memberSelect_return();
        retval.Start = input.LT(1);
        int memberSelect_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal119 = null;
        IToken Identifier120 = null;

        CommonTree char_literal119_tree=null;
        CommonTree Identifier120_tree=null;
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:387:2: ( '.' Identifier -> ^( MEMBER_SELECT Identifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:387:4: '.' Identifier
            {
            	char_literal119=(IToken)Match(input,151,FOLLOW_151_in_memberSelect1864); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_151.Add(char_literal119);

            	Identifier120=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect1866); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier120);



            	// AST REWRITE
            	// elements:          Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 387:19: -> ^( MEMBER_SELECT Identifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:387:22: ^( MEMBER_SELECT Identifier )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBER_SELECT, "MEMBER_SELECT"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 49, memberSelect_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberSelect"

    public class memberFunctionCall_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "memberFunctionCall"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:390:1: memberFunctionCall : '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal121 = null;
        IToken Identifier122 = null;
        PsimulexParser.arguments_return arguments123 = default(PsimulexParser.arguments_return);


        CommonTree char_literal121_tree=null;
        CommonTree Identifier122_tree=null;
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:391:2: ( '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:391:4: '.' Identifier arguments
            {
            	char_literal121=(IToken)Match(input,151,FOLLOW_151_in_memberFunctionCall1887); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_151.Add(char_literal121);

            	Identifier122=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall1889); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier122);

            	PushFollow(FOLLOW_arguments_in_memberFunctionCall1891);
            	arguments123 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_arguments.Add(arguments123.Tree);


            	// AST REWRITE
            	// elements:          Identifier, arguments
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 391:29: -> ^( MEMBER_FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:391:32: ^( MEMBER_FUNCTION_CALL Identifier arguments )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBER_FUNCTION_CALL, "MEMBER_FUNCTION_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    adaptor.AddChild(root_1, stream_arguments.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 50, memberFunctionCall_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberFunctionCall"

    public class functionCall_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "functionCall"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:394:1: functionCall : Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.functionCall_return functionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.functionCall_return retval = new PsimulexParser.functionCall_return();
        retval.Start = input.LT(1);
        int functionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier124 = null;
        PsimulexParser.arguments_return arguments125 = default(PsimulexParser.arguments_return);


        CommonTree Identifier124_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:395:2: ( Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:395:4: Identifier arguments
            {
            	Identifier124=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionCall1914); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier124);

            	PushFollow(FOLLOW_arguments_in_functionCall1916);
            	arguments125 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_arguments.Add(arguments125.Tree);


            	// AST REWRITE
            	// elements:          Identifier, arguments
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 395:25: -> ^( FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:395:28: ^( FUNCTION_CALL Identifier arguments )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION_CALL, "FUNCTION_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    adaptor.AddChild(root_1, stream_arguments.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 51, functionCall_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionCall"

    public class indexing_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "indexing"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:398:1: indexing : '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) ;
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal126 = null;
        IToken char_literal128 = null;
        IToken char_literal130 = null;
        PsimulexParser.expression_return expression127 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression129 = default(PsimulexParser.expression_return);


        CommonTree char_literal126_tree=null;
        CommonTree char_literal128_tree=null;
        CommonTree char_literal130_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:2: ( '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:4: '[' expression ( ',' expression )* ']'
            {
            	char_literal126=(IToken)Match(input,146,FOLLOW_146_in_indexing1939); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_146.Add(char_literal126);

            	PushFollow(FOLLOW_expression_in_indexing1941);
            	expression127 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression127.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:19: ( ',' expression )*
            	do 
            	{
            	    int alt32 = 2;
            	    int LA32_0 = input.LA(1);

            	    if ( (LA32_0 == 147) )
            	    {
            	        alt32 = 1;
            	    }


            	    switch (alt32) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:21: ',' expression
            			    {
            			    	char_literal128=(IToken)Match(input,147,FOLLOW_147_in_indexing1945); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal128);

            			    	PushFollow(FOLLOW_expression_in_indexing1947);
            			    	expression129 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression129.Tree);

            			    }
            			    break;

            			default:
            			    goto loop32;
            	    }
            	} while (true);

            	loop32:
            		;	// Stops C# compiler whining that label 'loop32' has no statements

            	char_literal130=(IToken)Match(input,148,FOLLOW_148_in_indexing1952); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_148.Add(char_literal130);



            	// AST REWRITE
            	// elements:          expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 399:43: -> ^( INDEXING expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:46: ^( INDEXING expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(INDEXING, "INDEXING"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:69: ( expression )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 52, indexing_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "indexing"

    public class arguments_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arguments"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:402:1: arguments : '(' ( expression ( ',' expression )* )? ')' -> ^( ARGUMENTS ( expression ( expression )* )? ) ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal131 = null;
        IToken char_literal133 = null;
        IToken char_literal135 = null;
        PsimulexParser.expression_return expression132 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression134 = default(PsimulexParser.expression_return);


        CommonTree char_literal131_tree=null;
        CommonTree char_literal133_tree=null;
        CommonTree char_literal135_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:5: ( '(' ( expression ( ',' expression )* )? ')' -> ^( ARGUMENTS ( expression ( expression )* )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:9: '(' ( expression ( ',' expression )* )? ')'
            {
            	char_literal131=(IToken)Match(input,149,FOLLOW_149_in_arguments1986); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_149.Add(char_literal131);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:13: ( expression ( ',' expression )* )?
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == StringLiteral || LA34_0 == Identifier || LA34_0 == Reference || LA34_0 == Minus || (LA34_0 >= LogicalNot && LA34_0 <= New) || LA34_0 == 149) )
            	{
            	    alt34 = 1;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:15: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_arguments1990);
            	        	expression132 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression132.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:26: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt33 = 2;
            	        	    int LA33_0 = input.LA(1);

            	        	    if ( (LA33_0 == 147) )
            	        	    {
            	        	        alt33 = 1;
            	        	    }


            	        	    switch (alt33) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:27: ',' expression
            	        			    {
            	        			    	char_literal133=(IToken)Match(input,147,FOLLOW_147_in_arguments1993); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal133);

            	        			    	PushFollow(FOLLOW_expression_in_arguments1995);
            	        			    	expression134 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_expression.Add(expression134.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop33;
            	        	    }
            	        	} while (true);

            	        	loop33:
            	        		;	// Stops C# compiler whining that label 'loop33' has no statements


            	        }
            	        break;

            	}

            	char_literal135=(IToken)Match(input,150,FOLLOW_150_in_arguments2002); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_150.Add(char_literal135);



            	// AST REWRITE
            	// elements:          expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 403:51: -> ^( ARGUMENTS ( expression ( expression )* )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:54: ^( ARGUMENTS ( expression ( expression )* )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ARGUMENTS, "ARGUMENTS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:67: ( expression ( expression )* )?
            	    if ( stream_expression.HasNext() || stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:80: ( expression )*
            	        while ( stream_expression.HasNext() )
            	        {
            	            adaptor.AddChild(root_1, stream_expression.NextTree());

            	        }
            	        stream_expression.Reset();

            	    }
            	    stream_expression.Reset();
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 53, arguments_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class literal_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "literal"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:406:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
    public PsimulexParser.literal_return literal() // throws RecognitionException [1]
    {   
        PsimulexParser.literal_return retval = new PsimulexParser.literal_return();
        retval.Start = input.LT(1);
        int literal_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set136 = null;

        CommonTree set136_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:407:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set136 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || (input.LA(1) >= IntegerLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set136));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 54, literal_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "literal"

    public class constantData_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constantData"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:416:1: constantData : ( literal | constantInitializer );
    public PsimulexParser.constantData_return constantData() // throws RecognitionException [1]
    {   
        PsimulexParser.constantData_return retval = new PsimulexParser.constantData_return();
        retval.Start = input.LT(1);
        int constantData_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.literal_return literal137 = default(PsimulexParser.literal_return);

        PsimulexParser.constantInitializer_return constantInitializer138 = default(PsimulexParser.constantInitializer_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:2: ( literal | constantInitializer )
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == StringLiteral || (LA35_0 >= IntegerLiteral && LA35_0 <= InfinityLiteral)) )
            {
                alt35 = 1;
            }
            else if ( (LA35_0 == New) )
            {
                alt35 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:4: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_constantData2113);
                    	literal137 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal137.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:14: constantInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantInitializer_in_constantData2117);
                    	constantInitializer138 = constantInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantInitializer138.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 55, constantData_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "constantData"

    public class collectionType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "collectionType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:427:1: collectionType : type ;
    public PsimulexParser.collectionType_return collectionType() // throws RecognitionException [1]
    {   
        PsimulexParser.collectionType_return retval = new PsimulexParser.collectionType_return();
        retval.Start = input.LT(1);
        int collectionType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.type_return type139 = default(PsimulexParser.type_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:428:2: ( type )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:428:4: type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_collectionType2139);
            	type139 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type139.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 56, collectionType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "collectionType"

    public class initializer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "initializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:431:1: initializer : ( collectionInitializer | arrayInitializer );
    public PsimulexParser.initializer_return initializer() // throws RecognitionException [1]
    {   
        PsimulexParser.initializer_return retval = new PsimulexParser.initializer_return();
        retval.Start = input.LT(1);
        int initializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.collectionInitializer_return collectionInitializer140 = default(PsimulexParser.collectionInitializer_return);

        PsimulexParser.arrayInitializer_return arrayInitializer141 = default(PsimulexParser.arrayInitializer_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:2: ( collectionInitializer | arrayInitializer )
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0 == New) )
            {
                switch ( input.LA(2) ) 
                {
                case Bool:
                case Char:
                case Int:
                case Decimal:
                case String:
                case Void:
                	{
                    int LA36_2 = input.LA(3);

                    if ( (LA36_2 == 146) )
                    {
                        int LA36_5 = input.LA(4);

                        if ( ((LA36_5 >= 147 && LA36_5 <= 148)) )
                        {
                            alt36 = 1;
                        }
                        else if ( (LA36_5 == StringLiteral || LA36_5 == Identifier || LA36_5 == Reference || LA36_5 == Minus || (LA36_5 >= LogicalNot && LA36_5 <= New) || LA36_5 == 149) )
                        {
                            alt36 = 2;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d36s5 =
                                new NoViableAltException("", 36, 5, input);

                            throw nvae_d36s5;
                        }
                    }
                    else if ( (LA36_2 == 144) )
                    {
                        alt36 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d36s2 =
                            new NoViableAltException("", 36, 2, input);

                        throw nvae_d36s2;
                    }
                    }
                    break;
                case Tree:
                case BinTree:
                case Set:
                case List:
                case Stack:
                case Queue:
                case PQueue:
                case Graph:
                case Node:
                case Edge:
                case Thread:
                case Iterator:
                	{
                    int LA36_3 = input.LA(3);

                    if ( (LA36_3 == 146) )
                    {
                        int LA36_5 = input.LA(4);

                        if ( ((LA36_5 >= 147 && LA36_5 <= 148)) )
                        {
                            alt36 = 1;
                        }
                        else if ( (LA36_5 == StringLiteral || LA36_5 == Identifier || LA36_5 == Reference || LA36_5 == Minus || (LA36_5 >= LogicalNot && LA36_5 <= New) || LA36_5 == 149) )
                        {
                            alt36 = 2;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d36s5 =
                                new NoViableAltException("", 36, 5, input);

                            throw nvae_d36s5;
                        }
                    }
                    else if ( (LA36_3 == 144) )
                    {
                        alt36 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d36s3 =
                            new NoViableAltException("", 36, 3, input);

                        throw nvae_d36s3;
                    }
                    }
                    break;
                case Identifier:
                	{
                    int LA36_4 = input.LA(3);

                    if ( (LA36_4 == 146) )
                    {
                        int LA36_5 = input.LA(4);

                        if ( ((LA36_5 >= 147 && LA36_5 <= 148)) )
                        {
                            alt36 = 1;
                        }
                        else if ( (LA36_5 == StringLiteral || LA36_5 == Identifier || LA36_5 == Reference || LA36_5 == Minus || (LA36_5 >= LogicalNot && LA36_5 <= New) || LA36_5 == 149) )
                        {
                            alt36 = 2;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d36s5 =
                                new NoViableAltException("", 36, 5, input);

                            throw nvae_d36s5;
                        }
                    }
                    else if ( (LA36_4 == 144) )
                    {
                        alt36 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d36s4 =
                            new NoViableAltException("", 36, 4, input);

                        throw nvae_d36s4;
                    }
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d36s1 =
                	        new NoViableAltException("", 36, 1, input);

                	    throw nvae_d36s1;
                }

            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d36s0 =
                    new NoViableAltException("", 36, 0, input);

                throw nvae_d36s0;
            }
            switch (alt36) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:4: collectionInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_collectionInitializer_in_initializer2151);
                    	collectionInitializer140 = collectionInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, collectionInitializer140.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:28: arrayInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInitializer_in_initializer2155);
                    	arrayInitializer141 = arrayInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInitializer141.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 57, initializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "initializer"

    public class collectionInitializer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "collectionInitializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:435:1: collectionInitializer : New collectionType '{' expression ( ',' expression )* '}' -> ^( COLLECTION_INITIALIZER collectionType expression ( expression )* ) ;
    public PsimulexParser.collectionInitializer_return collectionInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.collectionInitializer_return retval = new PsimulexParser.collectionInitializer_return();
        retval.Start = input.LT(1);
        int collectionInitializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken New142 = null;
        IToken char_literal144 = null;
        IToken char_literal146 = null;
        IToken char_literal148 = null;
        PsimulexParser.collectionType_return collectionType143 = default(PsimulexParser.collectionType_return);

        PsimulexParser.expression_return expression145 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression147 = default(PsimulexParser.expression_return);


        CommonTree New142_tree=null;
        CommonTree char_literal144_tree=null;
        CommonTree char_literal146_tree=null;
        CommonTree char_literal148_tree=null;
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_New = new RewriteRuleTokenStream(adaptor,"token New");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_collectionType = new RewriteRuleSubtreeStream(adaptor,"rule collectionType");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:2: ( New collectionType '{' expression ( ',' expression )* '}' -> ^( COLLECTION_INITIALIZER collectionType expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:4: New collectionType '{' expression ( ',' expression )* '}'
            {
            	New142=(IToken)Match(input,New,FOLLOW_New_in_collectionInitializer2167); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_New.Add(New142);

            	PushFollow(FOLLOW_collectionType_in_collectionInitializer2169);
            	collectionType143 = collectionType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_collectionType.Add(collectionType143.Tree);
            	char_literal144=(IToken)Match(input,144,FOLLOW_144_in_collectionInitializer2171); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_144.Add(char_literal144);

            	PushFollow(FOLLOW_expression_in_collectionInitializer2173);
            	expression145 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression145.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:38: ( ',' expression )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == 147) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:40: ',' expression
            			    {
            			    	char_literal146=(IToken)Match(input,147,FOLLOW_147_in_collectionInitializer2177); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal146);

            			    	PushFollow(FOLLOW_expression_in_collectionInitializer2179);
            			    	expression147 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression147.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements

            	char_literal148=(IToken)Match(input,145,FOLLOW_145_in_collectionInitializer2184); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_145.Add(char_literal148);



            	// AST REWRITE
            	// elements:          expression, expression, collectionType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 436:62: -> ^( COLLECTION_INITIALIZER collectionType expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:65: ^( COLLECTION_INITIALIZER collectionType expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COLLECTION_INITIALIZER, "COLLECTION_INITIALIZER"), root_1);

            	    adaptor.AddChild(root_1, stream_collectionType.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:117: ( expression )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 58, collectionInitializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "collectionInitializer"

    public class arrayInitializer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arrayInitializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:439:1: arrayInitializer : New dataType '[' expression ( ',' expression )* ']' -> ^( ARRAY_INITIALIZER dataType expression ( expression )* ) ;
    public PsimulexParser.arrayInitializer_return arrayInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayInitializer_return retval = new PsimulexParser.arrayInitializer_return();
        retval.Start = input.LT(1);
        int arrayInitializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken New149 = null;
        IToken char_literal151 = null;
        IToken char_literal153 = null;
        IToken char_literal155 = null;
        PsimulexParser.dataType_return dataType150 = default(PsimulexParser.dataType_return);

        PsimulexParser.expression_return expression152 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression154 = default(PsimulexParser.expression_return);


        CommonTree New149_tree=null;
        CommonTree char_literal151_tree=null;
        CommonTree char_literal153_tree=null;
        CommonTree char_literal155_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_New = new RewriteRuleTokenStream(adaptor,"token New");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_dataType = new RewriteRuleSubtreeStream(adaptor,"rule dataType");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:2: ( New dataType '[' expression ( ',' expression )* ']' -> ^( ARRAY_INITIALIZER dataType expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:4: New dataType '[' expression ( ',' expression )* ']'
            {
            	New149=(IToken)Match(input,New,FOLLOW_New_in_arrayInitializer2214); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_New.Add(New149);

            	PushFollow(FOLLOW_dataType_in_arrayInitializer2216);
            	dataType150 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_dataType.Add(dataType150.Tree);
            	char_literal151=(IToken)Match(input,146,FOLLOW_146_in_arrayInitializer2218); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_146.Add(char_literal151);

            	PushFollow(FOLLOW_expression_in_arrayInitializer2220);
            	expression152 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression152.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:32: ( ',' expression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 147) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:34: ',' expression
            			    {
            			    	char_literal153=(IToken)Match(input,147,FOLLOW_147_in_arrayInitializer2224); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal153);

            			    	PushFollow(FOLLOW_expression_in_arrayInitializer2226);
            			    	expression154 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression154.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements

            	char_literal155=(IToken)Match(input,148,FOLLOW_148_in_arrayInitializer2231); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_148.Add(char_literal155);



            	// AST REWRITE
            	// elements:          expression, expression, dataType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 440:56: -> ^( ARRAY_INITIALIZER dataType expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:59: ^( ARRAY_INITIALIZER dataType expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

            	    adaptor.AddChild(root_1, stream_dataType.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:100: ( expression )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 59, arrayInitializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayInitializer"

    public class constantInitializer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constantInitializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:445:1: constantInitializer : ( constantCollectionInitializer | constantArrayInitializer );
    public PsimulexParser.constantInitializer_return constantInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.constantInitializer_return retval = new PsimulexParser.constantInitializer_return();
        retval.Start = input.LT(1);
        int constantInitializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.constantCollectionInitializer_return constantCollectionInitializer156 = default(PsimulexParser.constantCollectionInitializer_return);

        PsimulexParser.constantArrayInitializer_return constantArrayInitializer157 = default(PsimulexParser.constantArrayInitializer_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:2: ( constantCollectionInitializer | constantArrayInitializer )
            int alt39 = 2;
            int LA39_0 = input.LA(1);

            if ( (LA39_0 == New) )
            {
                switch ( input.LA(2) ) 
                {
                case Bool:
                case Char:
                case Int:
                case Decimal:
                case String:
                case Void:
                	{
                    int LA39_2 = input.LA(3);

                    if ( (LA39_2 == 146) )
                    {
                        int LA39_5 = input.LA(4);

                        if ( (LA39_5 == StringLiteral || (LA39_5 >= IntegerLiteral && LA39_5 <= New)) )
                        {
                            alt39 = 2;
                        }
                        else if ( ((LA39_5 >= 147 && LA39_5 <= 148)) )
                        {
                            alt39 = 1;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d39s5 =
                                new NoViableAltException("", 39, 5, input);

                            throw nvae_d39s5;
                        }
                    }
                    else if ( (LA39_2 == 144) )
                    {
                        alt39 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d39s2 =
                            new NoViableAltException("", 39, 2, input);

                        throw nvae_d39s2;
                    }
                    }
                    break;
                case Tree:
                case BinTree:
                case Set:
                case List:
                case Stack:
                case Queue:
                case PQueue:
                case Graph:
                case Node:
                case Edge:
                case Thread:
                case Iterator:
                	{
                    int LA39_3 = input.LA(3);

                    if ( (LA39_3 == 146) )
                    {
                        int LA39_5 = input.LA(4);

                        if ( (LA39_5 == StringLiteral || (LA39_5 >= IntegerLiteral && LA39_5 <= New)) )
                        {
                            alt39 = 2;
                        }
                        else if ( ((LA39_5 >= 147 && LA39_5 <= 148)) )
                        {
                            alt39 = 1;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d39s5 =
                                new NoViableAltException("", 39, 5, input);

                            throw nvae_d39s5;
                        }
                    }
                    else if ( (LA39_3 == 144) )
                    {
                        alt39 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d39s3 =
                            new NoViableAltException("", 39, 3, input);

                        throw nvae_d39s3;
                    }
                    }
                    break;
                case Identifier:
                	{
                    int LA39_4 = input.LA(3);

                    if ( (LA39_4 == 146) )
                    {
                        int LA39_5 = input.LA(4);

                        if ( (LA39_5 == StringLiteral || (LA39_5 >= IntegerLiteral && LA39_5 <= New)) )
                        {
                            alt39 = 2;
                        }
                        else if ( ((LA39_5 >= 147 && LA39_5 <= 148)) )
                        {
                            alt39 = 1;
                        }
                        else 
                        {
                            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                            NoViableAltException nvae_d39s5 =
                                new NoViableAltException("", 39, 5, input);

                            throw nvae_d39s5;
                        }
                    }
                    else if ( (LA39_4 == 144) )
                    {
                        alt39 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d39s4 =
                            new NoViableAltException("", 39, 4, input);

                        throw nvae_d39s4;
                    }
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d39s1 =
                	        new NoViableAltException("", 39, 1, input);

                	    throw nvae_d39s1;
                }

            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d39s0 =
                    new NoViableAltException("", 39, 0, input);

                throw nvae_d39s0;
            }
            switch (alt39) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:4: constantCollectionInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantCollectionInitializer_in_constantInitializer2266);
                    	constantCollectionInitializer156 = constantCollectionInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantCollectionInitializer156.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:36: constantArrayInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantArrayInitializer_in_constantInitializer2270);
                    	constantArrayInitializer157 = constantArrayInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantArrayInitializer157.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 60, constantInitializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "constantInitializer"

    public class constantCollectionInitializer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constantCollectionInitializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:449:1: constantCollectionInitializer : New collectionType '{' constantData ( ',' constantData )* '}' -> ^( COLLECTION_INITIALIZER collectionType constantData ( constantData )* ) ;
    public PsimulexParser.constantCollectionInitializer_return constantCollectionInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.constantCollectionInitializer_return retval = new PsimulexParser.constantCollectionInitializer_return();
        retval.Start = input.LT(1);
        int constantCollectionInitializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken New158 = null;
        IToken char_literal160 = null;
        IToken char_literal162 = null;
        IToken char_literal164 = null;
        PsimulexParser.collectionType_return collectionType159 = default(PsimulexParser.collectionType_return);

        PsimulexParser.constantData_return constantData161 = default(PsimulexParser.constantData_return);

        PsimulexParser.constantData_return constantData163 = default(PsimulexParser.constantData_return);


        CommonTree New158_tree=null;
        CommonTree char_literal160_tree=null;
        CommonTree char_literal162_tree=null;
        CommonTree char_literal164_tree=null;
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_New = new RewriteRuleTokenStream(adaptor,"token New");
        RewriteRuleSubtreeStream stream_collectionType = new RewriteRuleSubtreeStream(adaptor,"rule collectionType");
        RewriteRuleSubtreeStream stream_constantData = new RewriteRuleSubtreeStream(adaptor,"rule constantData");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:2: ( New collectionType '{' constantData ( ',' constantData )* '}' -> ^( COLLECTION_INITIALIZER collectionType constantData ( constantData )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:4: New collectionType '{' constantData ( ',' constantData )* '}'
            {
            	New158=(IToken)Match(input,New,FOLLOW_New_in_constantCollectionInitializer2282); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_New.Add(New158);

            	PushFollow(FOLLOW_collectionType_in_constantCollectionInitializer2284);
            	collectionType159 = collectionType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_collectionType.Add(collectionType159.Tree);
            	char_literal160=(IToken)Match(input,144,FOLLOW_144_in_constantCollectionInitializer2286); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_144.Add(char_literal160);

            	PushFollow(FOLLOW_constantData_in_constantCollectionInitializer2288);
            	constantData161 = constantData();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_constantData.Add(constantData161.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:40: ( ',' constantData )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == 147) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:42: ',' constantData
            			    {
            			    	char_literal162=(IToken)Match(input,147,FOLLOW_147_in_constantCollectionInitializer2292); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal162);

            			    	PushFollow(FOLLOW_constantData_in_constantCollectionInitializer2294);
            			    	constantData163 = constantData();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_constantData.Add(constantData163.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	char_literal164=(IToken)Match(input,145,FOLLOW_145_in_constantCollectionInitializer2299); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_145.Add(char_literal164);



            	// AST REWRITE
            	// elements:          constantData, collectionType, constantData
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 450:66: -> ^( COLLECTION_INITIALIZER collectionType constantData ( constantData )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:69: ^( COLLECTION_INITIALIZER collectionType constantData ( constantData )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COLLECTION_INITIALIZER, "COLLECTION_INITIALIZER"), root_1);

            	    adaptor.AddChild(root_1, stream_collectionType.NextTree());
            	    adaptor.AddChild(root_1, stream_constantData.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:123: ( constantData )*
            	    while ( stream_constantData.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_constantData.NextTree());

            	    }
            	    stream_constantData.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 61, constantCollectionInitializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "constantCollectionInitializer"

    public class constantArrayInitializer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constantArrayInitializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:453:1: constantArrayInitializer : New dataType '[' constantData ( ',' constantData )* ']' -> ^( ARRAY_INITIALIZER dataType constantData ( constantData )* ) ;
    public PsimulexParser.constantArrayInitializer_return constantArrayInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.constantArrayInitializer_return retval = new PsimulexParser.constantArrayInitializer_return();
        retval.Start = input.LT(1);
        int constantArrayInitializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken New165 = null;
        IToken char_literal167 = null;
        IToken char_literal169 = null;
        IToken char_literal171 = null;
        PsimulexParser.dataType_return dataType166 = default(PsimulexParser.dataType_return);

        PsimulexParser.constantData_return constantData168 = default(PsimulexParser.constantData_return);

        PsimulexParser.constantData_return constantData170 = default(PsimulexParser.constantData_return);


        CommonTree New165_tree=null;
        CommonTree char_literal167_tree=null;
        CommonTree char_literal169_tree=null;
        CommonTree char_literal171_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_New = new RewriteRuleTokenStream(adaptor,"token New");
        RewriteRuleSubtreeStream stream_constantData = new RewriteRuleSubtreeStream(adaptor,"rule constantData");
        RewriteRuleSubtreeStream stream_dataType = new RewriteRuleSubtreeStream(adaptor,"rule dataType");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:2: ( New dataType '[' constantData ( ',' constantData )* ']' -> ^( ARRAY_INITIALIZER dataType constantData ( constantData )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:4: New dataType '[' constantData ( ',' constantData )* ']'
            {
            	New165=(IToken)Match(input,New,FOLLOW_New_in_constantArrayInitializer2329); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_New.Add(New165);

            	PushFollow(FOLLOW_dataType_in_constantArrayInitializer2331);
            	dataType166 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_dataType.Add(dataType166.Tree);
            	char_literal167=(IToken)Match(input,146,FOLLOW_146_in_constantArrayInitializer2333); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_146.Add(char_literal167);

            	PushFollow(FOLLOW_constantData_in_constantArrayInitializer2335);
            	constantData168 = constantData();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_constantData.Add(constantData168.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:34: ( ',' constantData )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == 147) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:36: ',' constantData
            			    {
            			    	char_literal169=(IToken)Match(input,147,FOLLOW_147_in_constantArrayInitializer2339); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_147.Add(char_literal169);

            			    	PushFollow(FOLLOW_constantData_in_constantArrayInitializer2341);
            			    	constantData170 = constantData();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_constantData.Add(constantData170.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	char_literal171=(IToken)Match(input,148,FOLLOW_148_in_constantArrayInitializer2346); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_148.Add(char_literal171);



            	// AST REWRITE
            	// elements:          constantData, constantData, dataType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 454:60: -> ^( ARRAY_INITIALIZER dataType constantData ( constantData )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:63: ^( ARRAY_INITIALIZER dataType constantData ( constantData )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ARRAY_INITIALIZER, "ARRAY_INITIALIZER"), root_1);

            	    adaptor.AddChild(root_1, stream_dataType.NextTree());
            	    adaptor.AddChild(root_1, stream_constantData.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:106: ( constantData )*
            	    while ( stream_constantData.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_constantData.NextTree());

            	    }
            	    stream_constantData.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 62, constantArrayInitializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "constantArrayInitializer"

    public class block_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "block"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:496:1: block : '{' ( statement )* '}' -> ^( BLOCK ( ^( STATEMENT statement ) )* ) ;
    public PsimulexParser.block_return block() // throws RecognitionException [1]
    {   
        PsimulexParser.block_return retval = new PsimulexParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal172 = null;
        IToken char_literal174 = null;
        PsimulexParser.statement_return statement173 = default(PsimulexParser.statement_return);


        CommonTree char_literal172_tree=null;
        CommonTree char_literal174_tree=null;
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:5: ( '{' ( statement )* '}' -> ^( BLOCK ( ^( STATEMENT statement ) )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:9: '{' ( statement )* '}'
            {
            	char_literal172=(IToken)Match(input,144,FOLLOW_144_in_block2398); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_144.Add(char_literal172);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:13: ( statement )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == StringLiteral || LA42_0 == Identifier || (LA42_0 >= Reference && LA42_0 <= Iterator) || LA42_0 == Minus || (LA42_0 >= LogicalNot && LA42_0 <= If) || (LA42_0 >= For && LA42_0 <= ForEach) || LA42_0 == Loop || LA42_0 == 143 || LA42_0 == 149) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block2400);
            			    	statement173 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement173.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements

            	char_literal174=(IToken)Match(input,145,FOLLOW_145_in_block2403); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_145.Add(char_literal174);



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 497:28: -> ^( BLOCK ( ^( STATEMENT statement ) )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:31: ^( BLOCK ( ^( STATEMENT statement ) )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:40: ( ^( STATEMENT statement ) )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:40: ^( STATEMENT statement )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(STATEMENT, "STATEMENT"), root_2);

            	        adaptor.AddChild(root_2, stream_statement.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 63, block_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "block"

    public class branch_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "branch"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:500:1: branch : ( block | statement );
    public PsimulexParser.branch_return branch() // throws RecognitionException [1]
    {   
        PsimulexParser.branch_return retval = new PsimulexParser.branch_return();
        retval.Start = input.LT(1);
        int branch_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.block_return block175 = default(PsimulexParser.block_return);

        PsimulexParser.statement_return statement176 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:501:5: ( block | statement )
            int alt43 = 2;
            int LA43_0 = input.LA(1);

            if ( (LA43_0 == 144) )
            {
                alt43 = 1;
            }
            else if ( (LA43_0 == StringLiteral || LA43_0 == Identifier || (LA43_0 >= Reference && LA43_0 <= Iterator) || LA43_0 == Minus || (LA43_0 >= LogicalNot && LA43_0 <= If) || (LA43_0 >= For && LA43_0 <= ForEach) || LA43_0 == Loop || LA43_0 == 143 || LA43_0 == 149) )
            {
                alt43 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d43s0 =
                    new NoViableAltException("", 43, 0, input);

                throw nvae_d43s0;
            }
            switch (alt43) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:501:7: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch2445);
                    	block175 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block175.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:501:15: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_branch2449);
                    	statement176 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement176.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 64, branch_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "branch"

    public class statement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:504:1: statement : ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN_STATEMENT Return ( expression )? ) | Break ';' | ';' | expression ';' -> ^( EXPRESSION_STATEMENT expression ) | localVariableDeclaration ';' -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration ) );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PDo185 = null;
        IToken Async187 = null;
        IToken Lock189 = null;
        IToken char_literal190 = null;
        IToken Identifier191 = null;
        IToken char_literal192 = null;
        IToken Return194 = null;
        IToken char_literal196 = null;
        IToken Break197 = null;
        IToken char_literal198 = null;
        IToken char_literal199 = null;
        IToken char_literal201 = null;
        IToken char_literal203 = null;
        PsimulexParser.ifStatement_return ifStatement177 = default(PsimulexParser.ifStatement_return);

        PsimulexParser.forStatement_return forStatement178 = default(PsimulexParser.forStatement_return);

        PsimulexParser.pForStatement_return pForStatement179 = default(PsimulexParser.pForStatement_return);

        PsimulexParser.forEachStatement_return forEachStatement180 = default(PsimulexParser.forEachStatement_return);

        PsimulexParser.pForEachStatement_return pForEachStatement181 = default(PsimulexParser.pForEachStatement_return);

        PsimulexParser.loopStatement_return loopStatement182 = default(PsimulexParser.loopStatement_return);

        PsimulexParser.whileStatement_return whileStatement183 = default(PsimulexParser.whileStatement_return);

        PsimulexParser.doStatement_return doStatement184 = default(PsimulexParser.doStatement_return);

        PsimulexParser.block_return block186 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block188 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block193 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression195 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression200 = default(PsimulexParser.expression_return);

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration202 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree PDo185_tree=null;
        CommonTree Async187_tree=null;
        CommonTree Lock189_tree=null;
        CommonTree char_literal190_tree=null;
        CommonTree Identifier191_tree=null;
        CommonTree char_literal192_tree=null;
        CommonTree Return194_tree=null;
        CommonTree char_literal196_tree=null;
        CommonTree Break197_tree=null;
        CommonTree char_literal198_tree=null;
        CommonTree char_literal199_tree=null;
        CommonTree char_literal201_tree=null;
        CommonTree char_literal203_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_Async = new RewriteRuleTokenStream(adaptor,"token Async");
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_Return = new RewriteRuleTokenStream(adaptor,"token Return");
        RewriteRuleTokenStream stream_Lock = new RewriteRuleTokenStream(adaptor,"token Lock");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_PDo = new RewriteRuleTokenStream(adaptor,"token PDo");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_localVariableDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule localVariableDeclaration");
        RewriteRuleSubtreeStream stream_ifStatement = new RewriteRuleSubtreeStream(adaptor,"rule ifStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:5: ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN_STATEMENT Return ( expression )? ) | Break ';' | ';' | expression ';' -> ^( EXPRESSION_STATEMENT expression ) | localVariableDeclaration ';' -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration ) )
            int alt47 = 14;
            alt47 = dfa47.Predict(input);
            switch (alt47) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:7: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement2466);
                    	ifStatement177 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ifStatement.Add(ifStatement177.Tree);


                    	// AST REWRITE
                    	// elements:          ifStatement
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 505:19: -> ^( IFSTATEMENT ifStatement )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:22: ^( IFSTATEMENT ifStatement )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IFSTATEMENT, "IFSTATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_ifStatement.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:7: ( forStatement | pForStatement )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:7: ( forStatement | pForStatement )
                    	int alt44 = 2;
                    	int LA44_0 = input.LA(1);

                    	if ( (LA44_0 == For) )
                    	{
                    	    alt44 = 1;
                    	}
                    	else if ( (LA44_0 == PFor) )
                    	{
                    	    alt44 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d44s0 =
                    	        new NoViableAltException("", 44, 0, input);

                    	    throw nvae_d44s0;
                    	}
                    	switch (alt44) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:9: forStatement
                    	        {
                    	        	PushFollow(FOLLOW_forStatement_in_statement2486);
                    	        	forStatement178 = forStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatement178.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:24: pForStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForStatement_in_statement2490);
                    	        	pForStatement179 = pForStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForStatement179.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:9: ( forEachStatement | pForEachStatement )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:9: ( forEachStatement | pForEachStatement )
                    	int alt45 = 2;
                    	int LA45_0 = input.LA(1);

                    	if ( (LA45_0 == ForEach) )
                    	{
                    	    alt45 = 1;
                    	}
                    	else if ( (LA45_0 == PForEach) )
                    	{
                    	    alt45 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d45s0 =
                    	        new NoViableAltException("", 45, 0, input);

                    	    throw nvae_d45s0;
                    	}
                    	switch (alt45) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:11: forEachStatement
                    	        {
                    	        	PushFollow(FOLLOW_forEachStatement_in_statement2504);
                    	        	forEachStatement180 = forEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachStatement180.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:30: pForEachStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForEachStatement_in_statement2508);
                    	        	pForEachStatement181 = pForEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForEachStatement181.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:9: loopStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_loopStatement_in_statement2520);
                    	loopStatement182 = loopStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopStatement182.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:9: whileStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileStatement_in_statement2530);
                    	whileStatement183 = whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileStatement183.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:9: doStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doStatement_in_statement2540);
                    	doStatement184 = doStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, doStatement184.Tree);

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:511:9: PDo block
                    {
                    	PDo185=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement2553); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PDo.Add(PDo185);

                    	PushFollow(FOLLOW_block_in_statement2555);
                    	block186 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_block.Add(block186.Tree);


                    	// AST REWRITE
                    	// elements:          block
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 511:19: -> ^( PDOSTATEMENT block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:511:22: ^( PDOSTATEMENT block )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PDOSTATEMENT, "PDOSTATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_block.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 8 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:9: Async block
                    {
                    	Async187=(IToken)Match(input,Async,FOLLOW_Async_in_statement2584); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Async.Add(Async187);

                    	PushFollow(FOLLOW_block_in_statement2586);
                    	block188 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_block.Add(block188.Tree);


                    	// AST REWRITE
                    	// elements:          block
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 512:21: -> ^( ASYNCSTATEMENT block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:24: ^( ASYNCSTATEMENT block )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ASYNCSTATEMENT, "ASYNCSTATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_block.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 9 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:9: Lock '(' Identifier ')' block
                    {
                    	Lock189=(IToken)Match(input,Lock,FOLLOW_Lock_in_statement2614); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Lock.Add(Lock189);

                    	char_literal190=(IToken)Match(input,149,FOLLOW_149_in_statement2616); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_149.Add(char_literal190);

                    	Identifier191=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_statement2618); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier191);

                    	char_literal192=(IToken)Match(input,150,FOLLOW_150_in_statement2620); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_150.Add(char_literal192);

                    	PushFollow(FOLLOW_block_in_statement2622);
                    	block193 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_block.Add(block193.Tree);


                    	// AST REWRITE
                    	// elements:          Identifier, block
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 513:39: -> ^( LOCKSTATEMENT Identifier block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:42: ^( LOCKSTATEMENT Identifier block )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LOCKSTATEMENT, "LOCKSTATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    adaptor.AddChild(root_1, stream_block.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 10 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:9: Return ( expression )? ';'
                    {
                    	Return194=(IToken)Match(input,Return,FOLLOW_Return_in_statement2645); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Return.Add(Return194);

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:16: ( expression )?
                    	int alt46 = 2;
                    	int LA46_0 = input.LA(1);

                    	if ( (LA46_0 == StringLiteral || LA46_0 == Identifier || LA46_0 == Reference || LA46_0 == Minus || (LA46_0 >= LogicalNot && LA46_0 <= New) || LA46_0 == 149) )
                    	{
                    	    alt46 = 1;
                    	}
                    	switch (alt46) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement2647);
                    	        	expression195 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_expression.Add(expression195.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal196=(IToken)Match(input,143,FOLLOW_143_in_statement2650); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_143.Add(char_literal196);



                    	// AST REWRITE
                    	// elements:          expression, Return
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 514:32: -> ^( RETURN_STATEMENT Return ( expression )? )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:35: ^( RETURN_STATEMENT Return ( expression )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RETURN_STATEMENT, "RETURN_STATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_Return.NextNode());
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:62: ( expression )?
                    	    if ( stream_expression.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    }
                    	    stream_expression.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 11 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:9: Break ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Break197=(IToken)Match(input,Break,FOLLOW_Break_in_statement2673); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break197_tree = (CommonTree)adaptor.Create(Break197);
                    		adaptor.AddChild(root_0, Break197_tree);
                    	}
                    	char_literal198=(IToken)Match(input,143,FOLLOW_143_in_statement2675); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal199=(IToken)Match(input,143,FOLLOW_143_in_statement2687); if (state.failed) return retval;

                    }
                    break;
                case 13 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:518:9: expression ';'
                    {
                    	PushFollow(FOLLOW_expression_in_statement2698);
                    	expression200 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression200.Tree);
                    	char_literal201=(IToken)Match(input,143,FOLLOW_143_in_statement2700); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_143.Add(char_literal201);



                    	// AST REWRITE
                    	// elements:          expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 518:24: -> ^( EXPRESSION_STATEMENT expression )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:518:27: ^( EXPRESSION_STATEMENT expression )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPRESSION_STATEMENT, "EXPRESSION_STATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 14 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:7: localVariableDeclaration ';'
                    {
                    	PushFollow(FOLLOW_localVariableDeclaration_in_statement2718);
                    	localVariableDeclaration202 = localVariableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_localVariableDeclaration.Add(localVariableDeclaration202.Tree);
                    	char_literal203=(IToken)Match(input,143,FOLLOW_143_in_statement2720); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_143.Add(char_literal203);



                    	// AST REWRITE
                    	// elements:          localVariableDeclaration
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 519:36: -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:39: ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VARIABLE_DECLARATION_STATEMENT, "VARIABLE_DECLARATION_STATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_localVariableDeclaration.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 65, statement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class localVariableDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "localVariableDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:522:1: localVariableDeclaration options {k=5; } : ( type Identifier -> ^( VARDECLARE type Identifier ) | type ( Reference )? Identifier Assign expression -> ^( VARINIT type ( Reference )? Identifier expression ) );
    public PsimulexParser.localVariableDeclaration_return localVariableDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.localVariableDeclaration_return retval = new PsimulexParser.localVariableDeclaration_return();
        retval.Start = input.LT(1);
        int localVariableDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier205 = null;
        IToken Reference207 = null;
        IToken Identifier208 = null;
        IToken Assign209 = null;
        PsimulexParser.type_return type204 = default(PsimulexParser.type_return);

        PsimulexParser.type_return type206 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression210 = default(PsimulexParser.expression_return);


        CommonTree Identifier205_tree=null;
        CommonTree Reference207_tree=null;
        CommonTree Identifier208_tree=null;
        CommonTree Assign209_tree=null;
        RewriteRuleTokenStream stream_Assign = new RewriteRuleTokenStream(adaptor,"token Assign");
        RewriteRuleTokenStream stream_Reference = new RewriteRuleTokenStream(adaptor,"token Reference");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 66) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:2: ( type Identifier -> ^( VARDECLARE type Identifier ) | type ( Reference )? Identifier Assign expression -> ^( VARINIT type ( Reference )? Identifier expression ) )
            int alt49 = 2;
            alt49 = dfa49.Predict(input);
            switch (alt49) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:6: type Identifier
                    {
                    	PushFollow(FOLLOW_type_in_localVariableDeclaration2753);
                    	type204 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_type.Add(type204.Tree);
                    	Identifier205=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_localVariableDeclaration2755); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier205);



                    	// AST REWRITE
                    	// elements:          type, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 524:22: -> ^( VARDECLARE type Identifier )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:25: ^( VARDECLARE type Identifier )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VARDECLARE, "VARDECLARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:526:6: type ( Reference )? Identifier Assign expression
                    {
                    	PushFollow(FOLLOW_type_in_localVariableDeclaration2779);
                    	type206 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_type.Add(type206.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:526:11: ( Reference )?
                    	int alt48 = 2;
                    	int LA48_0 = input.LA(1);

                    	if ( (LA48_0 == Reference) )
                    	{
                    	    alt48 = 1;
                    	}
                    	switch (alt48) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: Reference
                    	        {
                    	        	Reference207=(IToken)Match(input,Reference,FOLLOW_Reference_in_localVariableDeclaration2781); if (state.failed) return retval; 
                    	        	if ( (state.backtracking==0) ) stream_Reference.Add(Reference207);


                    	        }
                    	        break;

                    	}

                    	Identifier208=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_localVariableDeclaration2784); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier208);

                    	Assign209=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration2786); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Assign.Add(Assign209);

                    	PushFollow(FOLLOW_expression_in_localVariableDeclaration2788);
                    	expression210 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression210.Tree);


                    	// AST REWRITE
                    	// elements:          type, Identifier, expression, Reference
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 526:51: -> ^( VARINIT type ( Reference )? Identifier expression )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:526:54: ^( VARINIT type ( Reference )? Identifier expression )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VARINIT, "VARINIT"), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:526:70: ( Reference )?
                    	    if ( stream_Reference.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_Reference.NextNode());

                    	    }
                    	    stream_Reference.Reset();
                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 66, localVariableDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "localVariableDeclaration"

    public class ifStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ifStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:1: ifStatement : ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? ) ;
    public PsimulexParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.ifStatement_return retval = new PsimulexParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.ifBranch_return ifBranch211 = default(PsimulexParser.ifBranch_return);

        PsimulexParser.elseIfBranches_return elseIfBranches212 = default(PsimulexParser.elseIfBranches_return);

        PsimulexParser.elseBranch_return elseBranch213 = default(PsimulexParser.elseBranch_return);

        PsimulexParser.elseBranch_return elseBranch214 = default(PsimulexParser.elseBranch_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 67) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:15: ( ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:17: ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_ifBranch_in_ifStatement2824);
            	ifBranch211 = ifBranch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifBranch211.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:26: ( ( elseIfBranches elseBranch ) | ( elseBranch )? )
            	int alt51 = 2;
            	switch ( input.LA(1) ) 
            	{
            	case ElseIf:
            		{
            	    int LA51_1 = input.LA(2);

            	    if ( (synpred107_Psimulex()) )
            	    {
            	        alt51 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt51 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d51s1 =
            	            new NoViableAltException("", 51, 1, input);

            	        throw nvae_d51s1;
            	    }
            	    }
            	    break;
            	case Else:
            		{
            	    int LA51_2 = input.LA(2);

            	    if ( (synpred107_Psimulex()) )
            	    {
            	        alt51 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt51 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d51s2 =
            	            new NoViableAltException("", 51, 2, input);

            	        throw nvae_d51s2;
            	    }
            	    }
            	    break;
            	case EOF:
            	case StringLiteral:
            	case Identifier:
            	case Reference:
            	case Bool:
            	case Char:
            	case Int:
            	case Decimal:
            	case String:
            	case Void:
            	case Tree:
            	case BinTree:
            	case Set:
            	case List:
            	case Stack:
            	case Queue:
            	case PQueue:
            	case Graph:
            	case Node:
            	case Edge:
            	case Thread:
            	case Iterator:
            	case Minus:
            	case LogicalNot:
            	case PlusPlus:
            	case MinusMinus:
            	case IntegerLiteral:
            	case DecimalLiteral:
            	case CharacterLiteral:
            	case BooleanLiteral:
            	case NullLiteral:
            	case InfinityLiteral:
            	case New:
            	case PDo:
            	case Async:
            	case Lock:
            	case Return:
            	case Break:
            	case If:
            	case For:
            	case PFor:
            	case While:
            	case Do:
            	case PForEach:
            	case ForEach:
            	case Loop:
            	case 143:
            	case 145:
            	case 149:
            		{
            	    alt51 = 2;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d51s0 =
            		        new NoViableAltException("", 51, 0, input);

            		    throw nvae_d51s0;
            	}

            	switch (alt51) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( elseIfBranches elseBranch )
            	        {
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( elseIfBranches elseBranch )
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:30: elseIfBranches elseBranch
            	        	{
            	        		PushFollow(FOLLOW_elseIfBranches_in_ifStatement2830);
            	        		elseIfBranches212 = elseIfBranches();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseIfBranches212.Tree);
            	        		PushFollow(FOLLOW_elseBranch_in_ifStatement2832);
            	        		elseBranch213 = elseBranch();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch213.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:60: ( elseBranch )?
            	        {
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:60: ( elseBranch )?
            	        	int alt50 = 2;
            	        	int LA50_0 = input.LA(1);

            	        	if ( (LA50_0 == Else) )
            	        	{
            	        	    int LA50_1 = input.LA(2);

            	        	    if ( (synpred108_Psimulex()) )
            	        	    {
            	        	        alt50 = 1;
            	        	    }
            	        	}
            	        	switch (alt50) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: elseBranch
            	        	        {
            	        	        	PushFollow(FOLLOW_elseBranch_in_ifStatement2838);
            	        	        	elseBranch214 = elseBranch();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch214.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 67, ifStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ifStatement"

    public class ifBranch_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ifBranch"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:1: ifBranch : If condition core -> ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) ) ;
    public PsimulexParser.ifBranch_return ifBranch() // throws RecognitionException [1]
    {   
        PsimulexParser.ifBranch_return retval = new PsimulexParser.ifBranch_return();
        retval.Start = input.LT(1);
        int ifBranch_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken If215 = null;
        PsimulexParser.condition_return condition216 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core217 = default(PsimulexParser.core_return);


        CommonTree If215_tree=null;
        RewriteRuleTokenStream stream_If = new RewriteRuleTokenStream(adaptor,"token If");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 68) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:12: ( If condition core -> ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:14: If condition core
            {
            	If215=(IToken)Match(input,If,FOLLOW_If_in_ifBranch2850); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_If.Add(If215);

            	PushFollow(FOLLOW_condition_in_ifBranch2852);
            	condition216 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_condition.Add(condition216.Tree);
            	PushFollow(FOLLOW_core_in_ifBranch2854);
            	core217 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_core.Add(core217.Tree);


            	// AST REWRITE
            	// elements:          condition, core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 530:32: -> ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:35: ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IFBRANCH, "IFBRANCH"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:47: ^( CONDITIONALBRANCH condition core )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CONDITIONALBRANCH, "CONDITIONALBRANCH"), root_2);

            	    adaptor.AddChild(root_2, stream_condition.NextTree());
            	    adaptor.AddChild(root_2, stream_core.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 68, ifBranch_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ifBranch"

    public class elseIfBranches_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elseIfBranches"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:1: elseIfBranches : ( ElseIf condition core )* -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* ) ;
    public PsimulexParser.elseIfBranches_return elseIfBranches() // throws RecognitionException [1]
    {   
        PsimulexParser.elseIfBranches_return retval = new PsimulexParser.elseIfBranches_return();
        retval.Start = input.LT(1);
        int elseIfBranches_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken ElseIf218 = null;
        PsimulexParser.condition_return condition219 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core220 = default(PsimulexParser.core_return);


        CommonTree ElseIf218_tree=null;
        RewriteRuleTokenStream stream_ElseIf = new RewriteRuleTokenStream(adaptor,"token ElseIf");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 69) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:17: ( ( ElseIf condition core )* -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:19: ( ElseIf condition core )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:19: ( ElseIf condition core )*
            	do 
            	{
            	    int alt52 = 2;
            	    int LA52_0 = input.LA(1);

            	    if ( (LA52_0 == ElseIf) )
            	    {
            	        alt52 = 1;
            	    }


            	    switch (alt52) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:21: ElseIf condition core
            			    {
            			    	ElseIf218=(IToken)Match(input,ElseIf,FOLLOW_ElseIf_in_elseIfBranches2882); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_ElseIf.Add(ElseIf218);

            			    	PushFollow(FOLLOW_condition_in_elseIfBranches2884);
            			    	condition219 = condition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_condition.Add(condition219.Tree);
            			    	PushFollow(FOLLOW_core_in_elseIfBranches2886);
            			    	core220 = core();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_core.Add(core220.Tree);

            			    }
            			    break;

            			default:
            			    goto loop52;
            	    }
            	} while (true);

            	loop52:
            		;	// Stops C# compiler whining that label 'loop52' has no statements



            	// AST REWRITE
            	// elements:          core, condition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 531:46: -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:49: ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ELSEIFBRANCHES, "ELSEIFBRANCHES"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:67: ( ^( CONDITIONALBRANCH condition core ) )*
            	    while ( stream_core.HasNext() || stream_condition.HasNext() )
            	    {
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:69: ^( CONDITIONALBRANCH condition core )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CONDITIONALBRANCH, "CONDITIONALBRANCH"), root_2);

            	        adaptor.AddChild(root_2, stream_condition.NextTree());
            	        adaptor.AddChild(root_2, stream_core.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_core.Reset();
            	    stream_condition.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 69, elseIfBranches_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "elseIfBranches"

    public class elseBranch_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elseBranch"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:532:1: elseBranch : Else core -> ^( ELSEBRANCH core ) ;
    public PsimulexParser.elseBranch_return elseBranch() // throws RecognitionException [1]
    {   
        PsimulexParser.elseBranch_return retval = new PsimulexParser.elseBranch_return();
        retval.Start = input.LT(1);
        int elseBranch_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Else221 = null;
        PsimulexParser.core_return core222 = default(PsimulexParser.core_return);


        CommonTree Else221_tree=null;
        RewriteRuleTokenStream stream_Else = new RewriteRuleTokenStream(adaptor,"token Else");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 70) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:532:14: ( Else core -> ^( ELSEBRANCH core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:532:16: Else core
            {
            	Else221=(IToken)Match(input,Else,FOLLOW_Else_in_elseBranch2921); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Else.Add(Else221);

            	PushFollow(FOLLOW_core_in_elseBranch2923);
            	core222 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_core.Add(core222.Tree);


            	// AST REWRITE
            	// elements:          core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 532:26: -> ^( ELSEBRANCH core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:532:29: ^( ELSEBRANCH core )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ELSEBRANCH, "ELSEBRANCH"), root_1);

            	    adaptor.AddChild(root_1, stream_core.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 70, elseBranch_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "elseBranch"

    public class forStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:1: forStatement : For '(' forControl ')' core -> ^( FORSTATEMENT forControl core ) ;
    public PsimulexParser.forStatement_return forStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.forStatement_return retval = new PsimulexParser.forStatement_return();
        retval.Start = input.LT(1);
        int forStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken For223 = null;
        IToken char_literal224 = null;
        IToken char_literal226 = null;
        PsimulexParser.forControl_return forControl225 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core227 = default(PsimulexParser.core_return);


        CommonTree For223_tree=null;
        CommonTree char_literal224_tree=null;
        CommonTree char_literal226_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_For = new RewriteRuleTokenStream(adaptor,"token For");
        RewriteRuleSubtreeStream stream_forControl = new RewriteRuleSubtreeStream(adaptor,"rule forControl");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 71) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:15: ( For '(' forControl ')' core -> ^( FORSTATEMENT forControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:17: For '(' forControl ')' core
            {
            	For223=(IToken)Match(input,For,FOLLOW_For_in_forStatement2941); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_For.Add(For223);

            	char_literal224=(IToken)Match(input,149,FOLLOW_149_in_forStatement2943); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_149.Add(char_literal224);

            	PushFollow(FOLLOW_forControl_in_forStatement2945);
            	forControl225 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_forControl.Add(forControl225.Tree);
            	char_literal226=(IToken)Match(input,150,FOLLOW_150_in_forStatement2947); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_150.Add(char_literal226);

            	PushFollow(FOLLOW_core_in_forStatement2949);
            	core227 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_core.Add(core227.Tree);


            	// AST REWRITE
            	// elements:          core, forControl
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 534:45: -> ^( FORSTATEMENT forControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:48: ^( FORSTATEMENT forControl core )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORSTATEMENT, "FORSTATEMENT"), root_1);

            	    adaptor.AddChild(root_1, stream_forControl.NextTree());
            	    adaptor.AddChild(root_1, stream_core.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 71, forStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forStatement"

    public class pForStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "pForStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:535:1: pForStatement : PFor '(' forControl ')' core -> ^( PFORSTATEMENT forControl core ) ;
    public PsimulexParser.pForStatement_return pForStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.pForStatement_return retval = new PsimulexParser.pForStatement_return();
        retval.Start = input.LT(1);
        int pForStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PFor228 = null;
        IToken char_literal229 = null;
        IToken char_literal231 = null;
        PsimulexParser.forControl_return forControl230 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core232 = default(PsimulexParser.core_return);


        CommonTree PFor228_tree=null;
        CommonTree char_literal229_tree=null;
        CommonTree char_literal231_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_PFor = new RewriteRuleTokenStream(adaptor,"token PFor");
        RewriteRuleSubtreeStream stream_forControl = new RewriteRuleSubtreeStream(adaptor,"rule forControl");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 72) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:535:16: ( PFor '(' forControl ')' core -> ^( PFORSTATEMENT forControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:535:18: PFor '(' forControl ')' core
            {
            	PFor228=(IToken)Match(input,PFor,FOLLOW_PFor_in_pForStatement2969); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PFor.Add(PFor228);

            	char_literal229=(IToken)Match(input,149,FOLLOW_149_in_pForStatement2971); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_149.Add(char_literal229);

            	PushFollow(FOLLOW_forControl_in_pForStatement2973);
            	forControl230 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_forControl.Add(forControl230.Tree);
            	char_literal231=(IToken)Match(input,150,FOLLOW_150_in_pForStatement2975); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_150.Add(char_literal231);

            	PushFollow(FOLLOW_core_in_pForStatement2977);
            	core232 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_core.Add(core232.Tree);


            	// AST REWRITE
            	// elements:          core, forControl
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 535:47: -> ^( PFORSTATEMENT forControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:535:50: ^( PFORSTATEMENT forControl core )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PFORSTATEMENT, "PFORSTATEMENT"), root_1);

            	    adaptor.AddChild(root_1, stream_forControl.NextTree());
            	    adaptor.AddChild(root_1, stream_core.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 72, pForStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "pForStatement"

    public class forControl_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forControl"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:1: forControl : ( forInit )? ';' ( forCondition )? ';' ( forUpdate )? -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? ) ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal234 = null;
        IToken char_literal236 = null;
        PsimulexParser.forInit_return forInit233 = default(PsimulexParser.forInit_return);

        PsimulexParser.forCondition_return forCondition235 = default(PsimulexParser.forCondition_return);

        PsimulexParser.forUpdate_return forUpdate237 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal234_tree=null;
        CommonTree char_literal236_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleSubtreeStream stream_forCondition = new RewriteRuleSubtreeStream(adaptor,"rule forCondition");
        RewriteRuleSubtreeStream stream_forInit = new RewriteRuleSubtreeStream(adaptor,"rule forInit");
        RewriteRuleSubtreeStream stream_forUpdate = new RewriteRuleSubtreeStream(adaptor,"rule forUpdate");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 73) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:14: ( ( forInit )? ';' ( forCondition )? ';' ( forUpdate )? -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:16: ( forInit )? ';' ( forCondition )? ';' ( forUpdate )?
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:16: ( forInit )?
            	int alt53 = 2;
            	int LA53_0 = input.LA(1);

            	if ( (LA53_0 == Identifier || (LA53_0 >= Bool && LA53_0 <= Iterator)) )
            	{
            	    alt53 = 1;
            	}
            	switch (alt53) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl2998);
            	        	forInit233 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_forInit.Add(forInit233.Tree);

            	        }
            	        break;

            	}

            	char_literal234=(IToken)Match(input,143,FOLLOW_143_in_forControl3001); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_143.Add(char_literal234);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:29: ( forCondition )?
            	int alt54 = 2;
            	int LA54_0 = input.LA(1);

            	if ( (LA54_0 == StringLiteral || LA54_0 == Identifier || LA54_0 == Reference || LA54_0 == Minus || (LA54_0 >= LogicalNot && LA54_0 <= New) || LA54_0 == 149) )
            	{
            	    alt54 = 1;
            	}
            	switch (alt54) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forCondition
            	        {
            	        	PushFollow(FOLLOW_forCondition_in_forControl3003);
            	        	forCondition235 = forCondition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_forCondition.Add(forCondition235.Tree);

            	        }
            	        break;

            	}

            	char_literal236=(IToken)Match(input,143,FOLLOW_143_in_forControl3006); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_143.Add(char_literal236);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:47: ( forUpdate )?
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == StringLiteral || LA55_0 == Identifier || LA55_0 == Reference || LA55_0 == Minus || (LA55_0 >= LogicalNot && LA55_0 <= New) || LA55_0 == 149) )
            	{
            	    alt55 = 1;
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl3008);
            	        	forUpdate237 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_forUpdate.Add(forUpdate237.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          forUpdate, forCondition, forInit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 536:58: -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:61: ^( FORINIT ( forInit )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORINIT, "FORINIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:72: ( forInit )?
            	    if ( stream_forInit.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_forInit.NextTree());

            	    }
            	    stream_forInit.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:83: ^( FORCONDITION ( forCondition )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORCONDITION, "FORCONDITION"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:99: ( forCondition )?
            	    if ( stream_forCondition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_forCondition.NextTree());

            	    }
            	    stream_forCondition.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:115: ^( FORUPDATE ( forUpdate )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORUPDATE, "FORUPDATE"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:128: ( forUpdate )?
            	    if ( stream_forUpdate.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_forUpdate.NextTree());

            	    }
            	    stream_forUpdate.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 73, forControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forControl"

    public class forInit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forInit"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:537:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration238 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 74) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:537:12: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:537:16: localVariableDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit3050);
            	localVariableDeclaration238 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration238.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 74, forInit_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forInit"

    public class forCondition_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forCondition"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:538:1: forCondition : expression ;
    public PsimulexParser.forCondition_return forCondition() // throws RecognitionException [1]
    {   
        PsimulexParser.forCondition_return retval = new PsimulexParser.forCondition_return();
        retval.Start = input.LT(1);
        int forCondition_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression239 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 75) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:538:15: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:538:19: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forCondition3060);
            	expression239 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression239.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 75, forCondition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forCondition"

    public class forUpdate_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forUpdate"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:539:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression240 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 76) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:539:13: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:539:17: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate3071);
            	expression240 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression240.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 76, forUpdate_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forUpdate"

    public class whileStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "whileStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:541:1: whileStatement : While condition core -> ^( WHILESTATEMENT condition core ) ;
    public PsimulexParser.whileStatement_return whileStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.whileStatement_return retval = new PsimulexParser.whileStatement_return();
        retval.Start = input.LT(1);
        int whileStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken While241 = null;
        PsimulexParser.condition_return condition242 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core243 = default(PsimulexParser.core_return);


        CommonTree While241_tree=null;
        RewriteRuleTokenStream stream_While = new RewriteRuleTokenStream(adaptor,"token While");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 77) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:541:17: ( While condition core -> ^( WHILESTATEMENT condition core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:541:19: While condition core
            {
            	While241=(IToken)Match(input,While,FOLLOW_While_in_whileStatement3080); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_While.Add(While241);

            	PushFollow(FOLLOW_condition_in_whileStatement3082);
            	condition242 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_condition.Add(condition242.Tree);
            	PushFollow(FOLLOW_core_in_whileStatement3084);
            	core243 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_core.Add(core243.Tree);


            	// AST REWRITE
            	// elements:          core, condition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 541:40: -> ^( WHILESTATEMENT condition core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:541:43: ^( WHILESTATEMENT condition core )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(WHILESTATEMENT, "WHILESTATEMENT"), root_1);

            	    adaptor.AddChild(root_1, stream_condition.NextTree());
            	    adaptor.AddChild(root_1, stream_core.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 77, whileStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "whileStatement"

    public class doStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "doStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:543:1: doStatement : Do core While condition ';' -> ^( DOSTATEMENT core condition ) ;
    public PsimulexParser.doStatement_return doStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.doStatement_return retval = new PsimulexParser.doStatement_return();
        retval.Start = input.LT(1);
        int doStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Do244 = null;
        IToken While246 = null;
        IToken char_literal248 = null;
        PsimulexParser.core_return core245 = default(PsimulexParser.core_return);

        PsimulexParser.condition_return condition247 = default(PsimulexParser.condition_return);


        CommonTree Do244_tree=null;
        CommonTree While246_tree=null;
        CommonTree char_literal248_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_Do = new RewriteRuleTokenStream(adaptor,"token Do");
        RewriteRuleTokenStream stream_While = new RewriteRuleTokenStream(adaptor,"token While");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 78) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:543:15: ( Do core While condition ';' -> ^( DOSTATEMENT core condition ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:543:17: Do core While condition ';'
            {
            	Do244=(IToken)Match(input,Do,FOLLOW_Do_in_doStatement3106); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Do.Add(Do244);

            	PushFollow(FOLLOW_core_in_doStatement3108);
            	core245 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_core.Add(core245.Tree);
            	While246=(IToken)Match(input,While,FOLLOW_While_in_doStatement3110); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_While.Add(While246);

            	PushFollow(FOLLOW_condition_in_doStatement3112);
            	condition247 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_condition.Add(condition247.Tree);
            	char_literal248=(IToken)Match(input,143,FOLLOW_143_in_doStatement3114); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_143.Add(char_literal248);



            	// AST REWRITE
            	// elements:          core, condition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 543:45: -> ^( DOSTATEMENT core condition )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:543:48: ^( DOSTATEMENT core condition )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DOSTATEMENT, "DOSTATEMENT"), root_1);

            	    adaptor.AddChild(root_1, stream_core.NextTree());
            	    adaptor.AddChild(root_1, stream_condition.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 78, doStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "doStatement"

    public class pForEachStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "pForEachStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:545:1: pForEachStatement : PForEach forEachTrailer -> ^( PFOREACHSTATEMENT forEachTrailer ) ;
    public PsimulexParser.pForEachStatement_return pForEachStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.pForEachStatement_return retval = new PsimulexParser.pForEachStatement_return();
        retval.Start = input.LT(1);
        int pForEachStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PForEach249 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer250 = default(PsimulexParser.forEachTrailer_return);


        CommonTree PForEach249_tree=null;
        RewriteRuleTokenStream stream_PForEach = new RewriteRuleTokenStream(adaptor,"token PForEach");
        RewriteRuleSubtreeStream stream_forEachTrailer = new RewriteRuleSubtreeStream(adaptor,"rule forEachTrailer");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 79) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:545:19: ( PForEach forEachTrailer -> ^( PFOREACHSTATEMENT forEachTrailer ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:545:21: PForEach forEachTrailer
            {
            	PForEach249=(IToken)Match(input,PForEach,FOLLOW_PForEach_in_pForEachStatement3134); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PForEach.Add(PForEach249);

            	PushFollow(FOLLOW_forEachTrailer_in_pForEachStatement3136);
            	forEachTrailer250 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_forEachTrailer.Add(forEachTrailer250.Tree);


            	// AST REWRITE
            	// elements:          forEachTrailer
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 545:45: -> ^( PFOREACHSTATEMENT forEachTrailer )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:545:48: ^( PFOREACHSTATEMENT forEachTrailer )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PFOREACHSTATEMENT, "PFOREACHSTATEMENT"), root_1);

            	    adaptor.AddChild(root_1, stream_forEachTrailer.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 79, pForEachStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "pForEachStatement"

    public class forEachStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forEachStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:546:1: forEachStatement : ForEach forEachTrailer -> ^( FOREACHSTATEMENT forEachTrailer ) ;
    public PsimulexParser.forEachStatement_return forEachStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachStatement_return retval = new PsimulexParser.forEachStatement_return();
        retval.Start = input.LT(1);
        int forEachStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken ForEach251 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer252 = default(PsimulexParser.forEachTrailer_return);


        CommonTree ForEach251_tree=null;
        RewriteRuleTokenStream stream_ForEach = new RewriteRuleTokenStream(adaptor,"token ForEach");
        RewriteRuleSubtreeStream stream_forEachTrailer = new RewriteRuleSubtreeStream(adaptor,"rule forEachTrailer");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 80) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:546:18: ( ForEach forEachTrailer -> ^( FOREACHSTATEMENT forEachTrailer ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:546:20: ForEach forEachTrailer
            {
            	ForEach251=(IToken)Match(input,ForEach,FOLLOW_ForEach_in_forEachStatement3153); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ForEach.Add(ForEach251);

            	PushFollow(FOLLOW_forEachTrailer_in_forEachStatement3155);
            	forEachTrailer252 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_forEachTrailer.Add(forEachTrailer252.Tree);


            	// AST REWRITE
            	// elements:          forEachTrailer
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 546:43: -> ^( FOREACHSTATEMENT forEachTrailer )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:546:46: ^( FOREACHSTATEMENT forEachTrailer )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FOREACHSTATEMENT, "FOREACHSTATEMENT"), root_1);

            	    adaptor.AddChild(root_1, stream_forEachTrailer.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 80, forEachStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forEachStatement"

    public class forEachTrailer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forEachTrailer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:547:1: forEachTrailer : '(' forEachControl ')' core ;
    public PsimulexParser.forEachTrailer_return forEachTrailer() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachTrailer_return retval = new PsimulexParser.forEachTrailer_return();
        retval.Start = input.LT(1);
        int forEachTrailer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal253 = null;
        IToken char_literal255 = null;
        PsimulexParser.forEachControl_return forEachControl254 = default(PsimulexParser.forEachControl_return);

        PsimulexParser.core_return core256 = default(PsimulexParser.core_return);


        CommonTree char_literal253_tree=null;
        CommonTree char_literal255_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 81) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:547:17: ( '(' forEachControl ')' core )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:547:19: '(' forEachControl ')' core
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal253=(IToken)Match(input,149,FOLLOW_149_in_forEachTrailer3173); if (state.failed) return retval;
            	PushFollow(FOLLOW_forEachControl_in_forEachTrailer3176);
            	forEachControl254 = forEachControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachControl254.Tree);
            	char_literal255=(IToken)Match(input,150,FOLLOW_150_in_forEachTrailer3178); if (state.failed) return retval;
            	PushFollow(FOLLOW_core_in_forEachTrailer3181);
            	core256 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, core256.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 81, forEachTrailer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forEachTrailer"

    public class forEachControl_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forEachControl"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:548:1: forEachControl options {k=3; } : type Identifier In expression -> ^( FOREACHINIT type Identifier ) ^( FOREACHCOLLECTION expression ) ;
    public PsimulexParser.forEachControl_return forEachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachControl_return retval = new PsimulexParser.forEachControl_return();
        retval.Start = input.LT(1);
        int forEachControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier258 = null;
        IToken In259 = null;
        PsimulexParser.type_return type257 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression260 = default(PsimulexParser.expression_return);


        CommonTree Identifier258_tree=null;
        CommonTree In259_tree=null;
        RewriteRuleTokenStream stream_In = new RewriteRuleTokenStream(adaptor,"token In");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 82) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:549:9: ( type Identifier In expression -> ^( FOREACHINIT type Identifier ) ^( FOREACHCOLLECTION expression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:549:13: type Identifier In expression
            {
            	PushFollow(FOLLOW_type_in_forEachControl3210);
            	type257 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type257.Tree);
            	Identifier258=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_forEachControl3212); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier258);

            	In259=(IToken)Match(input,In,FOLLOW_In_in_forEachControl3214); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_In.Add(In259);

            	PushFollow(FOLLOW_expression_in_forEachControl3216);
            	expression260 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression260.Tree);


            	// AST REWRITE
            	// elements:          type, Identifier, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 549:43: -> ^( FOREACHINIT type Identifier ) ^( FOREACHCOLLECTION expression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:549:46: ^( FOREACHINIT type Identifier )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FOREACHINIT, "FOREACHINIT"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:549:80: ^( FOREACHCOLLECTION expression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FOREACHCOLLECTION, "FOREACHCOLLECTION"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 82, forEachControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forEachControl"

    public class loopStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "loopStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:551:1: loopStatement : Loop '(' loopControl ')' core -> ^( LOOPSTATEMENT loopControl core ) ;
    public PsimulexParser.loopStatement_return loopStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.loopStatement_return retval = new PsimulexParser.loopStatement_return();
        retval.Start = input.LT(1);
        int loopStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Loop261 = null;
        IToken char_literal262 = null;
        IToken char_literal264 = null;
        PsimulexParser.loopControl_return loopControl263 = default(PsimulexParser.loopControl_return);

        PsimulexParser.core_return core265 = default(PsimulexParser.core_return);


        CommonTree Loop261_tree=null;
        CommonTree char_literal262_tree=null;
        CommonTree char_literal264_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_Loop = new RewriteRuleTokenStream(adaptor,"token Loop");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        RewriteRuleSubtreeStream stream_loopControl = new RewriteRuleSubtreeStream(adaptor,"rule loopControl");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 83) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:551:16: ( Loop '(' loopControl ')' core -> ^( LOOPSTATEMENT loopControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:551:18: Loop '(' loopControl ')' core
            {
            	Loop261=(IToken)Match(input,Loop,FOLLOW_Loop_in_loopStatement3246); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Loop.Add(Loop261);

            	char_literal262=(IToken)Match(input,149,FOLLOW_149_in_loopStatement3248); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_149.Add(char_literal262);

            	PushFollow(FOLLOW_loopControl_in_loopStatement3250);
            	loopControl263 = loopControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_loopControl.Add(loopControl263.Tree);
            	char_literal264=(IToken)Match(input,150,FOLLOW_150_in_loopStatement3252); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_150.Add(char_literal264);

            	PushFollow(FOLLOW_core_in_loopStatement3254);
            	core265 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_core.Add(core265.Tree);


            	// AST REWRITE
            	// elements:          loopControl, core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 551:48: -> ^( LOOPSTATEMENT loopControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:551:51: ^( LOOPSTATEMENT loopControl core )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LOOPSTATEMENT, "LOOPSTATEMENT"), root_1);

            	    adaptor.AddChild(root_1, stream_loopControl.NextTree());
            	    adaptor.AddChild(root_1, stream_core.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 83, loopStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "loopStatement"

    public class loopControl_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "loopControl"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:552:1: loopControl options {k=3; } : localVariableDeclaration To expression -> ^( LOOPINIT localVariableDeclaration ) ^( LOOPLIMIT expression ) ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken To267 = null;
        PsimulexParser.localVariableDeclaration_return localVariableDeclaration266 = default(PsimulexParser.localVariableDeclaration_return);

        PsimulexParser.expression_return expression268 = default(PsimulexParser.expression_return);


        CommonTree To267_tree=null;
        RewriteRuleTokenStream stream_To = new RewriteRuleTokenStream(adaptor,"token To");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_localVariableDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule localVariableDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 84) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:553:9: ( localVariableDeclaration To expression -> ^( LOOPINIT localVariableDeclaration ) ^( LOOPLIMIT expression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:553:13: localVariableDeclaration To expression
            {
            	PushFollow(FOLLOW_localVariableDeclaration_in_loopControl3295);
            	localVariableDeclaration266 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_localVariableDeclaration.Add(localVariableDeclaration266.Tree);
            	To267=(IToken)Match(input,To,FOLLOW_To_in_loopControl3297); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_To.Add(To267);

            	PushFollow(FOLLOW_expression_in_loopControl3299);
            	expression268 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression268.Tree);


            	// AST REWRITE
            	// elements:          localVariableDeclaration, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 553:52: -> ^( LOOPINIT localVariableDeclaration ) ^( LOOPLIMIT expression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:553:55: ^( LOOPINIT localVariableDeclaration )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LOOPINIT, "LOOPINIT"), root_1);

            	    adaptor.AddChild(root_1, stream_localVariableDeclaration.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:553:94: ^( LOOPLIMIT expression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LOOPLIMIT, "LOOPLIMIT"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 84, loopControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "loopControl"

    public class core_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "core"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:555:1: core : branch -> ^( CORE branch ) ;
    public PsimulexParser.core_return core() // throws RecognitionException [1]
    {   
        PsimulexParser.core_return retval = new PsimulexParser.core_return();
        retval.Start = input.LT(1);
        int core_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.branch_return branch269 = default(PsimulexParser.branch_return);


        RewriteRuleSubtreeStream stream_branch = new RewriteRuleSubtreeStream(adaptor,"rule branch");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 85) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:555:9: ( branch -> ^( CORE branch ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:555:11: branch
            {
            	PushFollow(FOLLOW_branch_in_core3328);
            	branch269 = branch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_branch.Add(branch269.Tree);


            	// AST REWRITE
            	// elements:          branch
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 555:18: -> ^( CORE branch )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:555:21: ^( CORE branch )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CORE, "CORE"), root_1);

            	    adaptor.AddChild(root_1, stream_branch.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 85, core_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "core"

    public class condition_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "condition"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:556:1: condition : parExpression -> ^( CONDITION parExpression ) ;
    public PsimulexParser.condition_return condition() // throws RecognitionException [1]
    {   
        PsimulexParser.condition_return retval = new PsimulexParser.condition_return();
        retval.Start = input.LT(1);
        int condition_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression270 = default(PsimulexParser.parExpression_return);


        RewriteRuleSubtreeStream stream_parExpression = new RewriteRuleSubtreeStream(adaptor,"rule parExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 86) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:556:13: ( parExpression -> ^( CONDITION parExpression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:556:15: parExpression
            {
            	PushFollow(FOLLOW_parExpression_in_condition3347);
            	parExpression270 = parExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_parExpression.Add(parExpression270.Tree);


            	// AST REWRITE
            	// elements:          parExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 556:29: -> ^( CONDITION parExpression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:556:32: ^( CONDITION parExpression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CONDITION, "CONDITION"), root_1);

            	    adaptor.AddChild(root_1, stream_parExpression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 86, condition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "condition"

    // $ANTLR start "synpred1_Psimulex"
    public void synpred1_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:29: ( multiFunctionalProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:29: multiFunctionalProgram
        {
        	PushFollow(FOLLOW_multiFunctionalProgram_in_synpred1_Psimulex352);
        	multiFunctionalProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred7_Psimulex"
    public void synpred7_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:9: ( type Identifier ';' )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:9: type Identifier ';'
        {
        	PushFollow(FOLLOW_type_in_synpred7_Psimulex618);
        	type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Identifier,FOLLOW_Identifier_in_synpred7_Psimulex620); if (state.failed) return ;
        	Match(input,143,FOLLOW_143_in_synpred7_Psimulex622); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_Psimulex"

    // $ANTLR start "synpred33_Psimulex"
    public void synpred33_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred33_Psimulex1177);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_Psimulex"

    // $ANTLR start "synpred53_Psimulex"
    public void synpred53_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:7: ( unaryPostfixExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:7: unaryPostfixExpression
        {
        	PushFollow(FOLLOW_unaryPostfixExpression_in_synpred53_Psimulex1492);
        	unaryPostfixExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred53_Psimulex"

    // $ANTLR start "synpred55_Psimulex"
    public void synpred55_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:4: ( leftValueExpression ( unaryPostfixOp )? )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:4: leftValueExpression ( unaryPostfixOp )?
        {
        	PushFollow(FOLLOW_leftValueExpression_in_synpred55_Psimulex1543);
        	leftValueExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:24: ( unaryPostfixOp )?
        	int alt57 = 2;
        	int LA57_0 = input.LA(1);

        	if ( ((LA57_0 >= PlusPlus && LA57_0 <= MinusMinus)) )
        	{
        	    alt57 = 1;
        	}
        	switch (alt57) 
        	{
        	    case 1 :
        	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:25: unaryPostfixOp
        	        {
        	        	PushFollow(FOLLOW_unaryPostfixOp_in_synpred55_Psimulex1546);
        	        	unaryPostfixOp();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred55_Psimulex"

    // $ANTLR start "synpred60_Psimulex"
    public void synpred60_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred60_Psimulex1678);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred60_Psimulex"

    // $ANTLR start "synpred61_Psimulex"
    public void synpred61_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred61_Psimulex1686);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred61_Psimulex"

    // $ANTLR start "synpred63_Psimulex"
    public void synpred63_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:7: ( functionCall )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:7: functionCall
        {
        	PushFollow(FOLLOW_functionCall_in_synpred63_Psimulex1704);
        	functionCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred63_Psimulex"

    // $ANTLR start "synpred105_Psimulex"
    public void synpred105_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:6: ( type Identifier )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:6: type Identifier
        {
        	PushFollow(FOLLOW_type_in_synpred105_Psimulex2753);
        	type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Identifier,FOLLOW_Identifier_in_synpred105_Psimulex2755); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred105_Psimulex"

    // $ANTLR start "synpred107_Psimulex"
    public void synpred107_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( ( elseIfBranches elseBranch ) )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( elseIfBranches elseBranch )
        {
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( elseIfBranches elseBranch )
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:30: elseIfBranches elseBranch
        	{
        		PushFollow(FOLLOW_elseIfBranches_in_synpred107_Psimulex2830);
        		elseIfBranches();
        		state.followingStackPointer--;
        		if (state.failed) return ;
        		PushFollow(FOLLOW_elseBranch_in_synpred107_Psimulex2832);
        		elseBranch();
        		state.followingStackPointer--;
        		if (state.failed) return ;

        	}


        }
    }
    // $ANTLR end "synpred107_Psimulex"

    // $ANTLR start "synpred108_Psimulex"
    public void synpred108_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:60: ( elseBranch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:60: elseBranch
        {
        	PushFollow(FOLLOW_elseBranch_in_synpred108_Psimulex2838);
        	elseBranch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred108_Psimulex"

    // Delegated rules

   	public bool synpred7_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred53_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred53_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred105_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred105_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred1_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred107_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred107_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred108_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred108_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred63_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred63_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred61_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred61_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred55_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred55_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred33_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred33_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred60_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred60_Psimulex_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA3 dfa3;
   	protected DFA7 dfa7;
   	protected DFA47 dfa47;
   	protected DFA49 dfa49;
	private void InitializeCyclicDFAs()
	{
    	this.dfa3 = new DFA3(this);
    	this.dfa7 = new DFA7(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa49 = new DFA49(this);

	    this.dfa7.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA7_SpecialStateTransition);

	    this.dfa49.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA49_SpecialStateTransition);
	}

    const string DFA3_eotS =
        "\x0a\uffff";
    const string DFA3_eofS =
        "\x01\x04\x09\uffff";
    const string DFA3_minS =
        "\x04\x42\x01\uffff\x01\u0093\x01\x43\x01\u0093\x01\x42\x01\uffff";
    const string DFA3_maxS =
        "\x01\x56\x03\u0092\x01\uffff\x01\u0094\x01\u0095\x01\u0094\x01"+
        "\x44\x01\uffff";
    const string DFA3_acceptS =
        "\x04\uffff\x01\x02\x04\uffff\x01\x01";
    const string DFA3_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x01\x03\x02\uffff\x06\x01\x0c\x02",
            "\x01\x06\x01\uffff\x01\x04\x4d\uffff\x01\x05",
            "\x01\x06\x01\uffff\x01\x04\x4d\uffff\x01\x05",
            "\x01\x06\x01\uffff\x01\x04\x4d\uffff\x01\x05",
            "",
            "\x01\x07\x01\x08",
            "\x01\x09\x4b\uffff\x01\x09\x05\uffff\x01\x04",
            "\x01\x07\x01\x08",
            "\x01\x06\x01\uffff\x01\x04",
            ""
    };

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 112:4: ( memberDeclaration )*"; }
        }

    }

    const string DFA7_eotS =
        "\x16\uffff";
    const string DFA7_eofS =
        "\x16\uffff";
    const string DFA7_minS =
        "\x04\x42\x01\u0093\x01\x43\x01\u0093\x01\x43\x01\u0093\x01\x43"+
        "\x02\x00\x02\uffff\x02\x00\x02\uffff\x02\x00\x02\uffff";
    const string DFA7_maxS =
        "\x01\x56\x03\u0092\x01\u0094\x01\u008f\x01\u0094\x01\u008f\x01"+
        "\u0094\x01\u008f\x02\x00\x02\uffff\x02\x00\x02\uffff\x02\x00\x02"+
        "\uffff";
    const string DFA7_acceptS =
        "\x0c\uffff\x01\x01\x01\x02\x08\uffff";
    const string DFA7_specialS =
        "\x0a\uffff\x01\x00\x01\x01\x02\uffff\x01\x02\x01\x03\x02\uffff"+
        "\x01\x04\x01\x05\x02\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x03\x02\uffff\x06\x01\x0c\x02",
            "\x01\x05\x4f\uffff\x01\x04",
            "\x01\x07\x4f\uffff\x01\x06",
            "\x01\x09\x4f\uffff\x01\x08",
            "\x01\x0a\x01\x0b",
            "\x01\x0d\x4b\uffff\x01\x0c",
            "\x01\x0e\x01\x0f",
            "\x01\x0d\x4b\uffff\x01\x0c",
            "\x01\x12\x01\x13",
            "\x01\x0d\x4b\uffff\x01\x0c",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "144:1: memberDeclaration options {k=3; } : ( type Identifier ';' -> ^( MEMBERDEC type Identifier ) | type Identifier Assign constantData ';' -> ^( MEMBERDEC type Identifier constantData ) );"; }
        }

    }


    protected internal int DFA7_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA7_10 = input.LA(1);

                   	 
                   	int index7_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA7_11 = input.LA(1);

                   	 
                   	int index7_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA7_14 = input.LA(1);

                   	 
                   	int index7_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA7_15 = input.LA(1);

                   	 
                   	int index7_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA7_18 = input.LA(1);

                   	 
                   	int index7_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA7_19 = input.LA(1);

                   	 
                   	int index7_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_19);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae7 =
            new NoViableAltException(dfa.Description, 7, _s, input);
        dfa.Error(nvae7);
        throw nvae7;
    }
    const string DFA47_eotS =
        "\x11\uffff";
    const string DFA47_eofS =
        "\x11\uffff";
    const string DFA47_minS =
        "\x01\x40\x0d\uffff\x01\x42\x01\uffff\x01\x40";
    const string DFA47_maxS =
        "\x01\u0095\x0d\uffff\x01\u0097\x01\uffff\x01\u0095";
    const string DFA47_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\uffff\x01"+
        "\x0e\x01\uffff";
    const string DFA47_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA47_transitionS = {
            "\x01\x0d\x01\uffff\x01\x0e\x01\uffff\x01\x0d\x12\x0f\x0e\uffff"+
            "\x01\x0d\x03\uffff\x0a\x0d\x01\x07\x01\x08\x01\x09\x01\x0a\x01"+
            "\x0b\x01\x01\x02\uffff\x02\x02\x01\x05\x01\x06\x02\x03\x01\uffff"+
            "\x01\x04\x0c\uffff\x01\x0c\x05\uffff\x01\x0d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0f\x01\x0d\x01\x0f\x12\uffff\x12\x0d\x01\uffff\x02\x0d"+
            "\x23\uffff\x01\x0d\x02\uffff\x01\x10\x02\uffff\x01\x0d\x01\uffff"+
            "\x01\x0d",
            "",
            "\x01\x0d\x01\uffff\x01\x0d\x01\uffff\x01\x0d\x20\uffff\x01"+
            "\x0d\x03\uffff\x0a\x0d\x20\uffff\x02\x0f\x01\x0d"
    };

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "504:1: statement : ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN_STATEMENT Return ( expression )? ) | Break ';' | ';' | expression ';' -> ^( EXPRESSION_STATEMENT expression ) | localVariableDeclaration ';' -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration ) );"; }
        }

    }

    const string DFA49_eotS =
        "\x43\uffff";
    const string DFA49_eofS =
        "\x06\uffff\x01\x10\x02\uffff\x01\x10\x02\uffff\x01\x10\x14\uffff"+
        "\x01\x10\x03\uffff\x01\x10\x03\uffff\x01\x10\x19\uffff";
    const string DFA49_minS =
        "\x04\x42\x01\u0093\x01\uffff\x01\x43\x01\u0093\x01\uffff\x01\x43"+
        "\x01\u0093\x01\uffff\x01\x43\x01\u0093\x01\x42\x04\uffff\x01\u0093"+
        "\x01\x42\x04\uffff\x01\u0093\x01\x42\x04\uffff\x01\x42\x01\u0093"+
        "\x01\x43\x01\uffff\x01\x42\x01\u0093\x01\x43\x01\uffff\x01\x42\x01"+
        "\u0093\x01\x43\x01\uffff\x01\x00\x01\uffff\x02\x00\x04\uffff\x01"+
        "\x00\x01\uffff\x02\x00\x04\uffff\x01\x00\x01\uffff\x02\x00\x04\uffff";
    const string DFA49_maxS =
        "\x01\x56\x03\u0092\x01\u0094\x01\uffff\x01\u008f\x01\u0094\x01"+
        "\uffff\x01\u008f\x01\u0094\x01\uffff\x01\u008f\x01\u0094\x01\x44"+
        "\x04\uffff\x01\u0094\x01\x44\x04\uffff\x01\u0094\x01\x44\x04\uffff"+
        "\x01\x44\x01\u0094\x01\u008f\x01\uffff\x01\x44\x01\u0094\x01\u008f"+
        "\x01\uffff\x01\x44\x01\u0094\x01\u008f\x01\uffff\x01\x00\x01\uffff"+
        "\x02\x00\x04\uffff\x01\x00\x01\uffff\x02\x00\x04\uffff\x01\x00\x01"+
        "\uffff\x02\x00\x04\uffff";
    const string DFA49_acceptS =
        "\x05\uffff\x01\x02\x0a\uffff\x01\x01\x32\uffff";
    const string DFA49_specialS =
        "\x2b\uffff\x01\x00\x01\uffff\x01\x01\x01\x02\x04\uffff\x01\x03"+
        "\x01\uffff\x01\x04\x01\x05\x04\uffff\x01\x06\x01\uffff\x01\x07\x01"+
        "\x08\x04\uffff}>";
    static readonly string[] DFA49_transitionS = {
            "\x01\x03\x02\uffff\x06\x01\x0c\x02",
            "\x01\x06\x01\uffff\x01\x05\x4d\uffff\x01\x04",
            "\x01\x09\x01\uffff\x01\x05\x4d\uffff\x01\x07",
            "\x01\x0c\x01\uffff\x01\x05\x4d\uffff\x01\x0a",
            "\x01\x0d\x01\x0e",
            "",
            "\x01\x05\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "\x01\x13\x01\x14",
            "",
            "\x01\x05\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "\x01\x19\x01\x1a",
            "",
            "\x01\x05\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "\x01\x20\x01\x1f",
            "\x01\x21\x01\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "\x01\x24\x01\x23",
            "\x01\x25\x01\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "\x01\x28\x01\x27",
            "\x01\x29\x01\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "\x01\x2b\x01\uffff\x01\x05",
            "\x01\x2e\x01\x2d",
            "\x01\x05\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "",
            "\x01\x33\x01\uffff\x01\x05",
            "\x01\x36\x01\x35",
            "\x01\x05\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "",
            "\x01\x3b\x01\uffff\x01\x05",
            "\x01\x3e\x01\x3d",
            "\x01\x05\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "522:1: localVariableDeclaration options {k=5; } : ( type Identifier -> ^( VARDECLARE type Identifier ) | type ( Reference )? Identifier Assign expression -> ^( VARINIT type ( Reference )? Identifier expression ) );"; }
        }

    }


    protected internal int DFA49_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA49_43 = input.LA(1);

                   	 
                   	int index49_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA49_45 = input.LA(1);

                   	 
                   	int index49_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA49_46 = input.LA(1);

                   	 
                   	int index49_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA49_51 = input.LA(1);

                   	 
                   	int index49_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA49_53 = input.LA(1);

                   	 
                   	int index49_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA49_54 = input.LA(1);

                   	 
                   	int index49_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA49_59 = input.LA(1);

                   	 
                   	int index49_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA49_61 = input.LA(1);

                   	 
                   	int index49_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA49_62 = input.LA(1);

                   	 
                   	int index49_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred105_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index49_62);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae49 =
            new NoViableAltException(dfa.Description, 49, _s, input);
        dfa.Error(nvae49);
        throw nvae49;
    }
 

    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit352 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_simpleProgram372 = new BitSet(new ulong[]{0x0000000000000002UL,0xF9FFFE20007FFFF5UL,0x0000000000208005UL});
    public static readonly BitSet FOLLOW_importDeclarations_in_multiFunctionalProgram401 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE6UL});
    public static readonly BitSet FOLLOW_typeDeclarations_in_multiFunctionalProgram403 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram405 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_functionDeclarations_in_multiFunctionalProgram407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclarations442 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_Import_in_importDeclarations482 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclarations484 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_importDeclarations486 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclarations519 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration550 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration552 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_144_in_structBody584 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBody587 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_structBody590 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_memberDeclaration618 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberDeclaration620 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_memberDeclaration622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_memberDeclaration644 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberDeclaration646 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Assign_in_memberDeclaration648 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007F00000000001UL});
    public static readonly BitSet FOLLOW_constantData_in_memberDeclaration650 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_memberDeclaration652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_146_in_arrayType688 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_147_in_arrayType692 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_148_in_arrayType697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_functionDeclarations736 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_type_in_functionDeclaration769 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000014UL});
    public static readonly BitSet FOLLOW_Reference_in_functionDeclaration771 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration774 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclaration776 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration779 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_149_in_formalParameterList818 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList822 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000480000UL});
    public static readonly BitSet FOLLOW_147_in_formalParameterList825 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList827 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000480000UL});
    public static readonly BitSet FOLLOW_150_in_formalParameterList834 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_formalParameter871 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000014UL});
    public static readonly BitSet FOLLOW_Reference_in_formalParameter873 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameter876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_type922 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_arrayType_in_type924 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataTypeName_in_dataType957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataTypeName978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataTypeName982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedTypes_in_dataTypeName986 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_userDefinedTypes998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exp_in_expression1155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_exp1177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_exp1181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment1194 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000F800008UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment1196 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_exp_in_assignment1199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1240 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression1244 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1247 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1269 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression1273 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1276 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1298 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression1302 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1305 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1340 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000F00000000UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression1344 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1347 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000F00000000UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1400 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000003000000000UL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression1404 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1407 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000003000000000UL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1442 = new BitSet(new ulong[]{0x0000000000000002UL,0x000001C000000000UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression1446 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1449 = new BitSet(new ulong[]{0x0000000000000002UL,0x000001C000000000UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixExpression_in_unaryExpression1484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_unaryExpression1492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpression1497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1511 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryPrefixExpression1513 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_unaryPostfixExpression1543 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryPostfixExpression1554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_leftValueExpression1565 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1570 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000C0000000014UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_leftValueExpression1572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_149_in_castExpression1603 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_dataType_in_castExpression1605 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_150_in_castExpression1607 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixAssignerOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1678 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1696 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_primaryExpression1704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_initializer_in_primaryExpression1712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_149_in_parExpression1731 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1734 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_150_in_parExpression1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Reference_in_variable1767 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1770 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selector1820 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000840000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selector1824 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000840000UL});
    public static readonly BitSet FOLLOW_functionCall_in_selector1828 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000840000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector1839 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000840000UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector1843 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000840000UL});
    public static readonly BitSet FOLLOW_indexing_in_selector1847 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000840000UL});
    public static readonly BitSet FOLLOW_151_in_memberSelect1864 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect1866 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_memberFunctionCall1887 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall1889 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall1891 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall1914 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_arguments_in_functionCall1916 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_146_in_indexing1939 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing1941 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_147_in_indexing1945 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing1947 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_148_in_indexing1952 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_149_in_arguments1986 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments1990 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000480000UL});
    public static readonly BitSet FOLLOW_147_in_arguments1993 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments1995 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000480000UL});
    public static readonly BitSet FOLLOW_150_in_arguments2002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_constantData2113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantInitializer_in_constantData2117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_collectionType2139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_collectionInitializer_in_initializer2151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInitializer_in_initializer2155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_collectionInitializer2167 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_collectionType_in_collectionInitializer2169 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_collectionInitializer2171 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_collectionInitializer2173 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000A0000UL});
    public static readonly BitSet FOLLOW_147_in_collectionInitializer2177 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_collectionInitializer2179 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000A0000UL});
    public static readonly BitSet FOLLOW_145_in_collectionInitializer2184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_arrayInitializer2214 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_dataType_in_arrayInitializer2216 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_146_in_arrayInitializer2218 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayInitializer2220 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_147_in_arrayInitializer2224 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayInitializer2226 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_148_in_arrayInitializer2231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantCollectionInitializer_in_constantInitializer2266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantArrayInitializer_in_constantInitializer2270 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_constantCollectionInitializer2282 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_collectionType_in_constantCollectionInitializer2284 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_constantCollectionInitializer2286 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007F00000000001UL});
    public static readonly BitSet FOLLOW_constantData_in_constantCollectionInitializer2288 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000A0000UL});
    public static readonly BitSet FOLLOW_147_in_constantCollectionInitializer2292 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007F00000000001UL});
    public static readonly BitSet FOLLOW_constantData_in_constantCollectionInitializer2294 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000A0000UL});
    public static readonly BitSet FOLLOW_145_in_constantCollectionInitializer2299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_constantArrayInitializer2329 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_dataType_in_constantArrayInitializer2331 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_146_in_constantArrayInitializer2333 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007F00000000001UL});
    public static readonly BitSet FOLLOW_constantData_in_constantArrayInitializer2335 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_147_in_constantArrayInitializer2339 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007F00000000001UL});
    public static readonly BitSet FOLLOW_constantData_in_constantArrayInitializer2341 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_148_in_constantArrayInitializer2346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_144_in_block2398 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000228005UL});
    public static readonly BitSet FOLLOW_statement_in_block2400 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000228005UL});
    public static readonly BitSet FOLLOW_145_in_block2403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch2445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_branch2449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement2466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_statement2486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForStatement_in_statement2490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forEachStatement_in_statement2504 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForEachStatement_in_statement2508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_loopStatement_in_statement2520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_statement2530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doStatement_in_statement2540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement2553 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_block_in_statement2555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Async_in_statement2584 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_block_in_statement2586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Lock_in_statement2614 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_statement2616 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_statement2618 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_150_in_statement2620 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_block_in_statement2622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement2645 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_statement2647 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_statement2650 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement2673 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_statement2675 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_statement2687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement2698 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_statement2700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_statement2718 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_statement2720 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_localVariableDeclaration2753 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_localVariableDeclaration2755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_localVariableDeclaration2779 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000014UL});
    public static readonly BitSet FOLLOW_Reference_in_localVariableDeclaration2781 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_localVariableDeclaration2784 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration2786 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclaration2788 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifBranch_in_ifStatement2824 = new BitSet(new ulong[]{0x0000000000000002UL,0x0600000000000000UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_ifStatement2830 = new BitSet(new ulong[]{0x0000000000000000UL,0x0600000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_ifBranch2850 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_condition_in_ifBranch2852 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_ifBranch2854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ElseIf_in_elseIfBranches2882 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_condition_in_elseIfBranches2884 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_elseIfBranches2886 = new BitSet(new ulong[]{0x0000000000000002UL,0x0200000000000000UL});
    public static readonly BitSet FOLLOW_Else_in_elseBranch2921 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_elseBranch2923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_For_in_forStatement2941 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_forStatement2943 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000208005UL});
    public static readonly BitSet FOLLOW_forControl_in_forStatement2945 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_150_in_forStatement2947 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_forStatement2949 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PFor_in_pForStatement2969 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_pForStatement2971 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000208005UL});
    public static readonly BitSet FOLLOW_forControl_in_pForStatement2973 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_150_in_pForStatement2975 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_pForStatement2977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl2998 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_forControl3001 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_forCondition_in_forControl3003 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_forControl3006 = new BitSet(new ulong[]{0x0000000000000002UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl3008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit3050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forCondition3060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate3071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_whileStatement3080 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_condition_in_whileStatement3082 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_whileStatement3084 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_doStatement3106 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_doStatement3108 = new BitSet(new ulong[]{0x0000000000000000UL,0x2000000000000000UL});
    public static readonly BitSet FOLLOW_While_in_doStatement3110 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_condition_in_doStatement3112 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_doStatement3114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PForEach_in_pForEachStatement3134 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_pForEachStatement3136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ForEach_in_forEachStatement3153 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_forEachStatement3155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_149_in_forEachTrailer3173 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000007FFFE4UL});
    public static readonly BitSet FOLLOW_forEachControl_in_forEachTrailer3176 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_150_in_forEachTrailer3178 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_forEachTrailer3181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_forEachControl3210 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_forEachControl3212 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_In_in_forEachControl3214 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_forEachControl3216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_loopStatement3246 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_loopStatement3248 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x000000000020800DUL});
    public static readonly BitSet FOLLOW_loopControl_in_loopStatement3250 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_150_in_loopStatement3252 = new BitSet(new ulong[]{0x0000000000000000UL,0xF9FFFE20007FFFF5UL,0x0000000000218005UL});
    public static readonly BitSet FOLLOW_core_in_loopStatement3254 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_loopControl3295 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_To_in_loopControl3297 = new BitSet(new ulong[]{0x0000000000000000UL,0x0007FE2000000015UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_expression_in_loopControl3299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_branch_in_core3328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_condition3347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_synpred1_Psimulex352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_synpred7_Psimulex618 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred7_Psimulex620 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_synpred7_Psimulex622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred33_Psimulex1177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_synpred53_Psimulex1492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_synpred55_Psimulex1543 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000C0000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_synpred55_Psimulex1546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred60_Psimulex1678 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred61_Psimulex1686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_synpred63_Psimulex1704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_synpred105_Psimulex2753 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred105_Psimulex2755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_synpred107_Psimulex2830 = new BitSet(new ulong[]{0x0000000000000000UL,0x0600000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred107_Psimulex2832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred108_Psimulex2838 = new BitSet(new ulong[]{0x0000000000000002UL});

}
