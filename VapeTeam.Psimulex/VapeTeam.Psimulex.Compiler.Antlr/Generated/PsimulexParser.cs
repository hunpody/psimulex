// $ANTLR 3.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-09-27 01:03:45

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
		"ELSEIFBRANCH", 
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
		"FOREACHCONTROL", 
		"LOOPSTATEMENT", 
		"LOOPCONTROL", 
		"CORE", 
		"CONDITION", 
		"PDOSTATEMENT", 
		"ASYNCSTATEMENT", 
		"LOCKSTATEMENT", 
		"RETURN", 
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
		"DIMS", 
		"CONSTANT_DIMS", 
		"DIMMARKER", 
		"Import", 
		"StringLiteral", 
		"Struct", 
		"Identifier", 
		"Assign", 
		"IntegerLiteral", 
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
		"Thread", 
		"Timer", 
		"Graph", 
		"Node", 
		"Edge", 
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
		"DecimalLiteral", 
		"CharacterLiteral", 
		"BooleanLiteral", 
		"NullLiteral", 
		"InfinityLiteral", 
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

    public const int CAST = 46;
    public const int RelEqual = 90;
    public const int FORMAL_PARAMETER_LIST = 14;
    public const int TYPE_DECLARATIONS = 8;
    public const int VARINIT = 40;
    public const int AssignAndDivide = 86;
    public const int FORSTATEMENT = 23;
    public const int AssignAndMultiply = 85;
    public const int PFORSTATEMENT = 22;
    public const int CONDITION = 35;
    public const int Decimal = 68;
    public const int Modulo = 100;
    public const int PDOSTATEMENT = 36;
    public const int IDLetter = 129;
    public const int EOF = -1;
    public const int STATEMENT = 17;
    public const int INDEXING = 54;
    public const int Identifier = 61;
    public const int Int = 67;
    public const int Thread = 78;
    public const int TYPE = 42;
    public const int CONSTANT_DIMS = 56;
    public const int BinTree = 72;
    public const int PFOREACHSTATEMENT = 29;
    public const int To = 125;
    public const int ForEach = 122;
    public const int Char = 66;
    public const int Edge = 82;
    public const int COMPILATION_UNIT = 4;
    public const int LOCKSTATEMENT = 38;
    public const int LOOPCONTROL = 33;
    public const int RETURN = 39;
    public const int Do = 120;
    public const int RelGreaterThan = 94;
    public const int FORMAL_PARAMETER = 15;
    public const int Node = 81;
    public const int AssignAndModulo = 87;
    public const int WHILESTATEMENT = 28;
    public const int FORUPDATE = 26;
    public const int T__139 = 139;
    public const int T__138 = 138;
    public const int T__137 = 137;
    public const int Bool = 65;
    public const int FORINIT = 25;
    public const int ARGUMENTS = 52;
    public const int MEMBER_SELECT = 53;
    public const int LogicalOr = 88;
    public const int LogicalAnd = 89;
    public const int CORE = 34;
    public const int Tree = 71;
    public const int T__141 = 141;
    public const int T__142 = 142;
    public const int ELSEIFBRANCH = 20;
    public const int T__140 = 140;
    public const int T__145 = 145;
    public const int T__143 = 143;
    public const int T__144 = 144;
    public const int POSTFIXOP = 48;
    public const int Minus = 97;
    public const int WS = 134;
    public const int Break = 113;
    public const int GLOBAL_VARIABLE_DECLARATIONS = 10;
    public const int Timer = 79;
    public const int Async = 110;
    public const int MEMBER_FUNCTION_CALL = 50;
    public const int MULTY_FUNCTIONAL_PROGRAM = 6;
    public const int SIMPLE_PROGRAM = 5;
    public const int DATATYPE = 43;
    public const int NotNullDigit = 131;
    public const int RelLessThan = 92;
    public const int Star = 98;
    public const int Else = 116;
    public const int FUNCTION_CALL = 51;
    public const int EscapeSequence = 133;
    public const int Letter = 128;
    public const int Loop = 124;
    public const int BooleanLiteral = 106;
    public const int LOOPSTATEMENT = 32;
    public const int DIMMARKER = 57;
    public const int AssignAndAdd = 83;
    public const int Stack = 75;
    public const int NullLiteral = 107;
    public const int RelGreaterThanOrEqual = 95;
    public const int IFSTATEMENT = 18;
    public const int PQueue = 77;
    public const int SingleLineComment = 135;
    public const int DIMS = 55;
    public const int CharacterLiteral = 105;
    public const int AssignAndSubstract = 84;
    public const int While = 119;
    public const int Graph = 80;
    public const int Queue = 76;
    public const int Set = 73;
    public const int SELECTOR = 49;
    public const int Assign = 62;
    public const int PForEach = 121;
    public const int RelNotEqual = 91;
    public const int FOREACHSTATEMENT = 30;
    public const int IFBRANCH = 19;
    public const int String = 69;
    public const int Return = 112;
    public const int Struct = 60;
    public const int Reference = 64;
    public const int EXPRESSION = 45;
    public const int MultiLineComment = 136;
    public const int If = 114;
    public const int FUNCTIONPOINTERTYPE = 44;
    public const int In = 123;
    public const int Import = 58;
    public const int VARDECLARE = 41;
    public const int FUNCTION_DECLARATIONS = 12;
    public const int Continue = 126;
    public const int ELSEBRANCH = 21;
    public const int Void = 70;
    public const int ASYNCSTATEMENT = 37;
    public const int Lock = 111;
    public const int PDo = 109;
    public const int ElseIf = 115;
    public const int IMPORT_DECLARATIONS = 7;
    public const int DOSTATEMENT = 27;
    public const int FOREACHCONTROL = 31;
    public const int Digit = 130;
    public const int DecimalLiteral = 104;
    public const int STRUCTDEC = 9;
    public const int For = 117;
    public const int Divide = 99;
    public const int List = 74;
    public const int FORCONDITION = 24;
    public const int StringLiteral = 59;
    public const int LogicalNot = 101;
    public const int Plus = 96;
    public const int Atomic = 127;
    public const int RelLessThanOrEqual = 93;
    public const int MinusMinus = 103;
    public const int DecimalTypeSuffix = 132;
    public const int PFor = 118;
    public const int BLOCK = 16;
    public const int PREFIXOP = 47;
    public const int MEMBERDEC = 11;
    public const int IntegerLiteral = 63;
    public const int FUNCDEC = 13;
    public const int InfinityLiteral = 108;
    public const int PlusPlus = 102;

    // delegates
    // delegators



        public PsimulexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PsimulexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
    		InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[197+1];
             
             
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:92:1: compilationUnit : ( simpleProgram | multiFunctionalProgram )? EOF ;
    public PsimulexParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        PsimulexParser.compilationUnit_return retval = new PsimulexParser.compilationUnit_return();
        retval.Start = input.LT(1);
        int compilationUnit_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken EOF3 = null;
        PsimulexParser.simpleProgram_return simpleProgram1 = default(PsimulexParser.simpleProgram_return);

        PsimulexParser.multiFunctionalProgram_return multiFunctionalProgram2 = default(PsimulexParser.multiFunctionalProgram_return);


        CommonTree EOF3_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:5: ( ( simpleProgram | multiFunctionalProgram )? EOF )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:7: ( simpleProgram | multiFunctionalProgram )? EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:7: ( simpleProgram | multiFunctionalProgram )?
            	int alt1 = 3;
            	alt1 = dfa1.Predict(input);
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:9: simpleProgram
            	        {
            	        	PushFollow(FOLLOW_simpleProgram_in_compilationUnit329);
            	        	simpleProgram1 = simpleProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:25: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit333);
            	        	multiFunctionalProgram2 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit338); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:96:1: simpleProgram : ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) ;
    public PsimulexParser.simpleProgram_return simpleProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.simpleProgram_return retval = new PsimulexParser.simpleProgram_return();
        retval.Start = input.LT(1);
        int simpleProgram_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.statement_return statement4 = default(PsimulexParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:2: ( ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:4: ( statement )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || LA2_0 == IntegerLiteral || (LA2_0 >= Bool && LA2_0 <= Edge) || LA2_0 == Minus || (LA2_0 >= LogicalNot && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= ForEach) || LA2_0 == Loop || LA2_0 == 137 || LA2_0 == 143) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_simpleProgram353);
            			    	statement4 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_statement.Add(statement4.Tree);

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
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 97:15: -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:18: ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:38: ^( SIMPLE_PROGRAM ( statement )* )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SIMPLE_PROGRAM, "SIMPLE_PROGRAM"), root_2);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:56: ( statement )*
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

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:1: multiFunctionalProgram : importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) ;
    public PsimulexParser.multiFunctionalProgram_return multiFunctionalProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.multiFunctionalProgram_return retval = new PsimulexParser.multiFunctionalProgram_return();
        retval.Start = input.LT(1);
        int multiFunctionalProgram_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.importDeclarations_return importDeclarations5 = default(PsimulexParser.importDeclarations_return);

        PsimulexParser.typeDeclarations_return typeDeclarations6 = default(PsimulexParser.typeDeclarations_return);

        PsimulexParser.globalVariableDeclarations_return globalVariableDeclarations7 = default(PsimulexParser.globalVariableDeclarations_return);

        PsimulexParser.functionDeclarations_return functionDeclarations8 = default(PsimulexParser.functionDeclarations_return);


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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:2: ( importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:4: importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations
            {
            	PushFollow(FOLLOW_importDeclarations_in_multiFunctionalProgram382);
            	importDeclarations5 = importDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_importDeclarations.Add(importDeclarations5.Tree);
            	PushFollow(FOLLOW_typeDeclarations_in_multiFunctionalProgram384);
            	typeDeclarations6 = typeDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typeDeclarations.Add(typeDeclarations6.Tree);
            	PushFollow(FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram386);
            	globalVariableDeclarations7 = globalVariableDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_globalVariableDeclarations.Add(globalVariableDeclarations7.Tree);
            	PushFollow(FOLLOW_functionDeclarations_in_multiFunctionalProgram388);
            	functionDeclarations8 = functionDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_functionDeclarations.Add(functionDeclarations8.Tree);


            	// AST REWRITE
            	// elements:          importDeclarations, globalVariableDeclarations, functionDeclarations, typeDeclarations
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 102:3: -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:6: ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:26: ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations )
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

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:1: globalVariableDeclarations : ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) ;
    public PsimulexParser.globalVariableDeclarations_return globalVariableDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.globalVariableDeclarations_return retval = new PsimulexParser.globalVariableDeclarations_return();
        retval.Start = input.LT(1);
        int globalVariableDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberDeclaration_return memberDeclaration9 = default(PsimulexParser.memberDeclaration_return);


        RewriteRuleSubtreeStream stream_memberDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule memberDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:2: ( ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:4: ( memberDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:4: ( memberDeclaration )*
            	do 
            	{
            	    int alt3 = 2;
            	    alt3 = dfa3.Predict(input);
            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclarations423);
            			    	memberDeclaration9 = memberDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_memberDeclaration.Add(memberDeclaration9.Tree);

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
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 106:23: -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:26: ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GLOBAL_VARIABLE_DECLARATIONS, "GLOBAL_VARIABLE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:58: ( memberDeclaration )*
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

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:122:1: importDeclarations : ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) ;
    public PsimulexParser.importDeclarations_return importDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.importDeclarations_return retval = new PsimulexParser.importDeclarations_return();
        retval.Start = input.LT(1);
        int importDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Import10 = null;
        IToken StringLiteral11 = null;
        IToken char_literal12 = null;

        CommonTree Import10_tree=null;
        CommonTree StringLiteral11_tree=null;
        CommonTree char_literal12_tree=null;
        RewriteRuleTokenStream stream_StringLiteral = new RewriteRuleTokenStream(adaptor,"token StringLiteral");
        RewriteRuleTokenStream stream_Import = new RewriteRuleTokenStream(adaptor,"token Import");
        RewriteRuleTokenStream stream_137 = new RewriteRuleTokenStream(adaptor,"token 137");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:5: ( ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:9: ( Import StringLiteral ';' )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:9: ( Import StringLiteral ';' )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:11: Import StringLiteral ';'
            			    {
            			    	Import10=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclarations463); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_Import.Add(Import10);

            			    	StringLiteral11=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclarations465); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_StringLiteral.Add(StringLiteral11);

            			    	char_literal12=(IToken)Match(input,137,FOLLOW_137_in_importDeclarations467); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_137.Add(char_literal12);


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
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 123:39: -> ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:42: ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IMPORT_DECLARATIONS, "IMPORT_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:65: ( StringLiteral )*
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

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:126:1: typeDeclarations : ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) ;
    public PsimulexParser.typeDeclarations_return typeDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.typeDeclarations_return retval = new PsimulexParser.typeDeclarations_return();
        retval.Start = input.LT(1);
        int typeDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.structDeclaration_return structDeclaration13 = default(PsimulexParser.structDeclaration_return);


        RewriteRuleSubtreeStream stream_structDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule structDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:5: ( ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:9: ( structDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:9: ( structDeclaration )*
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
            			    	PushFollow(FOLLOW_structDeclaration_in_typeDeclarations500);
            			    	structDeclaration13 = structDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_structDeclaration.Add(structDeclaration13.Tree);

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
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 127:28: -> ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:31: ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE_DECLARATIONS, "TYPE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:52: ( structDeclaration )*
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

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:130:1: structDeclaration : Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) ;
    public PsimulexParser.structDeclaration_return structDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.structDeclaration_return retval = new PsimulexParser.structDeclaration_return();
        retval.Start = input.LT(1);
        int structDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Struct14 = null;
        IToken Identifier15 = null;
        PsimulexParser.structBody_return structBody16 = default(PsimulexParser.structBody_return);


        CommonTree Struct14_tree=null;
        CommonTree Identifier15_tree=null;
        RewriteRuleTokenStream stream_Struct = new RewriteRuleTokenStream(adaptor,"token Struct");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_structBody = new RewriteRuleSubtreeStream(adaptor,"rule structBody");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:5: ( Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:9: Struct Identifier structBody
            {
            	Struct14=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration531); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Struct.Add(Struct14);

            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration533); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier15);

            	PushFollow(FOLLOW_structBody_in_structDeclaration535);
            	structBody16 = structBody();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_structBody.Add(structBody16.Tree);


            	// AST REWRITE
            	// elements:          Identifier, structBody
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 131:38: -> ^( STRUCTDEC Identifier structBody )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:41: ^( STRUCTDEC Identifier structBody )
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

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:134:1: structBody : '{' ( memberDeclaration )+ '}' ;
    public PsimulexParser.structBody_return structBody() // throws RecognitionException [1]
    {   
        PsimulexParser.structBody_return retval = new PsimulexParser.structBody_return();
        retval.Start = input.LT(1);
        int structBody_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal17 = null;
        IToken char_literal19 = null;
        PsimulexParser.memberDeclaration_return memberDeclaration18 = default(PsimulexParser.memberDeclaration_return);


        CommonTree char_literal17_tree=null;
        CommonTree char_literal19_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:5: ( '{' ( memberDeclaration )+ '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:9: '{' ( memberDeclaration )+ '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,138,FOLLOW_138_in_structBody565); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:14: ( memberDeclaration )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == Identifier || (LA6_0 >= Bool && LA6_0 <= Edge)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBody568);
            			    	memberDeclaration18 = memberDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberDeclaration18.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(6, input);
            		            throw eee;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements

            	char_literal19=(IToken)Match(input,139,FOLLOW_139_in_structBody571); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:138:1: memberDeclaration : memberTypedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? ) ;
    public PsimulexParser.memberDeclaration_return memberDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.memberDeclaration_return retval = new PsimulexParser.memberDeclaration_return();
        retval.Start = input.LT(1);
        int memberDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Assign21 = null;
        IToken char_literal23 = null;
        PsimulexParser.memberTypedIdentifierNonRef_return memberTypedIdentifierNonRef20 = default(PsimulexParser.memberTypedIdentifierNonRef_return);

        PsimulexParser.literal_return literal22 = default(PsimulexParser.literal_return);


        CommonTree Assign21_tree=null;
        CommonTree char_literal23_tree=null;
        RewriteRuleTokenStream stream_Assign = new RewriteRuleTokenStream(adaptor,"token Assign");
        RewriteRuleTokenStream stream_137 = new RewriteRuleTokenStream(adaptor,"token 137");
        RewriteRuleSubtreeStream stream_memberTypedIdentifierNonRef = new RewriteRuleSubtreeStream(adaptor,"rule memberTypedIdentifierNonRef");
        RewriteRuleSubtreeStream stream_literal = new RewriteRuleSubtreeStream(adaptor,"rule literal");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:5: ( memberTypedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:9: memberTypedIdentifierNonRef ( Assign literal )? ';'
            {
            	PushFollow(FOLLOW_memberTypedIdentifierNonRef_in_memberDeclaration592);
            	memberTypedIdentifierNonRef20 = memberTypedIdentifierNonRef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_memberTypedIdentifierNonRef.Add(memberTypedIdentifierNonRef20.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:37: ( Assign literal )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == Assign) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:39: Assign literal
            	        {
            	        	Assign21=(IToken)Match(input,Assign,FOLLOW_Assign_in_memberDeclaration596); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Assign.Add(Assign21);

            	        	PushFollow(FOLLOW_literal_in_memberDeclaration598);
            	        	literal22 = literal();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_literal.Add(literal22.Tree);

            	        }
            	        break;

            	}

            	char_literal23=(IToken)Match(input,137,FOLLOW_137_in_memberDeclaration603); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_137.Add(char_literal23);



            	// AST REWRITE
            	// elements:          literal, memberTypedIdentifierNonRef
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 139:61: -> ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:64: ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBERDEC, "MEMBERDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_memberTypedIdentifierNonRef.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:105: ( literal )?
            	    if ( stream_literal.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_literal.NextTree());

            	    }
            	    stream_literal.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:142:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );
    public PsimulexParser.localVariableDeclaration_return localVariableDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.localVariableDeclaration_return retval = new PsimulexParser.localVariableDeclaration_return();
        retval.Start = input.LT(1);
        int localVariableDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Assign26 = null;
        IToken Assign29 = null;
        PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef24 = default(PsimulexParser.typedIdentifierNonRef_return);

        PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef25 = default(PsimulexParser.typedIdentifierNonRef_return);

        PsimulexParser.variableInitializer_return variableInitializer27 = default(PsimulexParser.variableInitializer_return);

        PsimulexParser.typedIdentifierRef_return typedIdentifierRef28 = default(PsimulexParser.typedIdentifierRef_return);

        PsimulexParser.variableInitializer_return variableInitializer30 = default(PsimulexParser.variableInitializer_return);


        CommonTree Assign26_tree=null;
        CommonTree Assign29_tree=null;
        RewriteRuleTokenStream stream_Assign = new RewriteRuleTokenStream(adaptor,"token Assign");
        RewriteRuleSubtreeStream stream_typedIdentifierNonRef = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifierNonRef");
        RewriteRuleSubtreeStream stream_variableInitializer = new RewriteRuleSubtreeStream(adaptor,"rule variableInitializer");
        RewriteRuleSubtreeStream stream_typedIdentifierRef = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifierRef");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:5: ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) )
            int alt8 = 3;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:9: typedIdentifierNonRef
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration642);
                    	typedIdentifierNonRef24 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierNonRef.Add(typedIdentifierNonRef24.Tree);


                    	// AST REWRITE
                    	// elements:          typedIdentifierNonRef
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 144:31: -> ^( VARDECLARE typedIdentifierNonRef )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:34: ^( VARDECLARE typedIdentifierNonRef )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VARDECLARE, "VARDECLARE"), root_1);

                    	    adaptor.AddChild(root_1, stream_typedIdentifierNonRef.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:9: typedIdentifierNonRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration660);
                    	typedIdentifierNonRef25 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierNonRef.Add(typedIdentifierNonRef25.Tree);
                    	Assign26=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration662); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign26);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration664);
                    	variableInitializer27 = variableInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_variableInitializer.Add(variableInitializer27.Tree);


                    	// AST REWRITE
                    	// elements:          typedIdentifierNonRef, variableInitializer
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 145:58: -> ^( VARINIT typedIdentifierNonRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:61: ^( VARINIT typedIdentifierNonRef variableInitializer )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VARINIT, "VARINIT"), root_1);

                    	    adaptor.AddChild(root_1, stream_typedIdentifierNonRef.NextTree());
                    	    adaptor.AddChild(root_1, stream_variableInitializer.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:4: typedIdentifierRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierRef_in_localVariableDeclaration679);
                    	typedIdentifierRef28 = typedIdentifierRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierRef.Add(typedIdentifierRef28.Tree);
                    	Assign29=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration681); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign29);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration683);
                    	variableInitializer30 = variableInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_variableInitializer.Add(variableInitializer30.Tree);


                    	// AST REWRITE
                    	// elements:          typedIdentifierRef, variableInitializer
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 146:50: -> ^( VARINIT typedIdentifierRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:53: ^( VARINIT typedIdentifierRef variableInitializer )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(VARINIT, "VARINIT"), root_1);

                    	    adaptor.AddChild(root_1, stream_typedIdentifierRef.NextTree());
                    	    adaptor.AddChild(root_1, stream_variableInitializer.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 10, localVariableDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "localVariableDeclaration"

    public class variableInitializer_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variableInitializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:1: variableInitializer : expression ;
    public PsimulexParser.variableInitializer_return variableInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.variableInitializer_return retval = new PsimulexParser.variableInitializer_return();
        retval.Start = input.LT(1);
        int variableInitializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression31 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:150:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:150:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_variableInitializer716);
            	expression31 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression31.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 11, variableInitializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableInitializer"

    public class scalarOrArrayType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "scalarOrArrayType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:1: scalarOrArrayType : type ( staticArrayType )? -> ^( TYPE type ( staticArrayType )? ) ;
    public PsimulexParser.scalarOrArrayType_return scalarOrArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.scalarOrArrayType_return retval = new PsimulexParser.scalarOrArrayType_return();
        retval.Start = input.LT(1);
        int scalarOrArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.type_return type32 = default(PsimulexParser.type_return);

        PsimulexParser.staticArrayType_return staticArrayType33 = default(PsimulexParser.staticArrayType_return);


        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_staticArrayType = new RewriteRuleSubtreeStream(adaptor,"rule staticArrayType");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:2: ( type ( staticArrayType )? -> ^( TYPE type ( staticArrayType )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:4: type ( staticArrayType )?
            {
            	PushFollow(FOLLOW_type_in_scalarOrArrayType736);
            	type32 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type32.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:9: ( staticArrayType )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 140) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: staticArrayType
            	        {
            	        	PushFollow(FOLLOW_staticArrayType_in_scalarOrArrayType738);
            	        	staticArrayType33 = staticArrayType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_staticArrayType.Add(staticArrayType33.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          type, staticArrayType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 154:26: -> ^( TYPE type ( staticArrayType )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:29: ^( TYPE type ( staticArrayType )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE, "TYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:42: ( staticArrayType )?
            	    if ( stream_staticArrayType.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_staticArrayType.NextTree());

            	    }
            	    stream_staticArrayType.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 12, scalarOrArrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "scalarOrArrayType"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:1: arrayType : ( staticArrayType | dynamicArrayType );
    public PsimulexParser.arrayType_return arrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayType_return retval = new PsimulexParser.arrayType_return();
        retval.Start = input.LT(1);
        int arrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.staticArrayType_return staticArrayType34 = default(PsimulexParser.staticArrayType_return);

        PsimulexParser.dynamicArrayType_return dynamicArrayType35 = default(PsimulexParser.dynamicArrayType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:2: ( staticArrayType | dynamicArrayType )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == 140) )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == StringLiteral || LA10_1 == Identifier || LA10_1 == IntegerLiteral || LA10_1 == Minus || (LA10_1 >= LogicalNot && LA10_1 <= InfinityLiteral) || LA10_1 == 143) )
                {
                    alt10 = 1;
                }
                else if ( ((LA10_1 >= 141 && LA10_1 <= 142)) )
                {
                    alt10 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("", 10, 1, input);

                    throw nvae_d10s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:4: staticArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_staticArrayType_in_arrayType763);
                    	staticArrayType34 = staticArrayType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, staticArrayType34.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:22: dynamicArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dynamicArrayType_in_arrayType767);
                    	dynamicArrayType35 = dynamicArrayType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dynamicArrayType35.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 13, arrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayType"

    public class staticArrayType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "staticArrayType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:1: staticArrayType : '[' expression ( ',' expression )* ']' -> ^( DIMS expression ( expression )* ) ;
    public PsimulexParser.staticArrayType_return staticArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.staticArrayType_return retval = new PsimulexParser.staticArrayType_return();
        retval.Start = input.LT(1);
        int staticArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal36 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        PsimulexParser.expression_return expression37 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression39 = default(PsimulexParser.expression_return);


        CommonTree char_literal36_tree=null;
        CommonTree char_literal38_tree=null;
        CommonTree char_literal40_tree=null;
        RewriteRuleTokenStream stream_140 = new RewriteRuleTokenStream(adaptor,"token 140");
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleTokenStream stream_141 = new RewriteRuleTokenStream(adaptor,"token 141");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:2: ( '[' expression ( ',' expression )* ']' -> ^( DIMS expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:4: '[' expression ( ',' expression )* ']'
            {
            	char_literal36=(IToken)Match(input,140,FOLLOW_140_in_staticArrayType779); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_140.Add(char_literal36);

            	PushFollow(FOLLOW_expression_in_staticArrayType781);
            	expression37 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression37.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:19: ( ',' expression )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 141) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:20: ',' expression
            			    {
            			    	char_literal38=(IToken)Match(input,141,FOLLOW_141_in_staticArrayType784); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_141.Add(char_literal38);

            			    	PushFollow(FOLLOW_expression_in_staticArrayType786);
            			    	expression39 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_expression.Add(expression39.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal40=(IToken)Match(input,142,FOLLOW_142_in_staticArrayType790); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal40);



            	// AST REWRITE
            	// elements:          expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 162:41: -> ^( DIMS expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:44: ^( DIMS expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMS, "DIMS"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:63: ( expression )*
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 14, staticArrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "staticArrayType"

    public class dynamicArrayType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "dynamicArrayType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:1: dynamicArrayType : '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) ;
    public PsimulexParser.dynamicArrayType_return dynamicArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.dynamicArrayType_return retval = new PsimulexParser.dynamicArrayType_return();
        retval.Start = input.LT(1);
        int dynamicArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal41 = null;
        IToken char_literal42 = null;
        IToken char_literal43 = null;

        CommonTree char_literal41_tree=null;
        CommonTree char_literal42_tree=null;
        CommonTree char_literal43_tree=null;
        RewriteRuleTokenStream stream_140 = new RewriteRuleTokenStream(adaptor,"token 140");
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleTokenStream stream_141 = new RewriteRuleTokenStream(adaptor,"token 141");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:2: ( '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:4: '[' ( ',' )* ']'
            {
            	char_literal41=(IToken)Match(input,140,FOLLOW_140_in_dynamicArrayType818); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_140.Add(char_literal41);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:8: ( ',' )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 141) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:10: ','
            			    {
            			    	char_literal42=(IToken)Match(input,141,FOLLOW_141_in_dynamicArrayType822); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_141.Add(char_literal42);


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal43=(IToken)Match(input,142,FOLLOW_142_in_dynamicArrayType827); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal43);



            	// AST REWRITE
            	// elements:          142, 141, 140
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 166:21: -> ^( DIMMARKER '[' ( ',' )* ']' )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:24: ^( DIMMARKER '[' ( ',' )* ']' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMMARKER, "DIMMARKER"), root_1);

            	    adaptor.AddChild(root_1, stream_140.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:41: ( ',' )*
            	    while ( stream_141.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_141.NextNode());

            	    }
            	    stream_141.Reset();
            	    adaptor.AddChild(root_1, stream_142.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 15, dynamicArrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "dynamicArrayType"

    public class memberScalarOrArrayType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "memberScalarOrArrayType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:169:1: memberScalarOrArrayType : type ( memberArrayType )? -> ^( TYPE type ( memberArrayType )? ) ;
    public PsimulexParser.memberScalarOrArrayType_return memberScalarOrArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.memberScalarOrArrayType_return retval = new PsimulexParser.memberScalarOrArrayType_return();
        retval.Start = input.LT(1);
        int memberScalarOrArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.type_return type44 = default(PsimulexParser.type_return);

        PsimulexParser.memberArrayType_return memberArrayType45 = default(PsimulexParser.memberArrayType_return);


        RewriteRuleSubtreeStream stream_memberArrayType = new RewriteRuleSubtreeStream(adaptor,"rule memberArrayType");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:2: ( type ( memberArrayType )? -> ^( TYPE type ( memberArrayType )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:4: type ( memberArrayType )?
            {
            	PushFollow(FOLLOW_type_in_memberScalarOrArrayType857);
            	type44 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type44.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:9: ( memberArrayType )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 140) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberArrayType
            	        {
            	        	PushFollow(FOLLOW_memberArrayType_in_memberScalarOrArrayType859);
            	        	memberArrayType45 = memberArrayType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_memberArrayType.Add(memberArrayType45.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          type, memberArrayType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 170:26: -> ^( TYPE type ( memberArrayType )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:29: ^( TYPE type ( memberArrayType )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE, "TYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:42: ( memberArrayType )?
            	    if ( stream_memberArrayType.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_memberArrayType.NextTree());

            	    }
            	    stream_memberArrayType.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 16, memberScalarOrArrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberScalarOrArrayType"

    public class memberArrayType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "memberArrayType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:1: memberArrayType : ( memberStaticArrayType | dynamicArrayType );
    public PsimulexParser.memberArrayType_return memberArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.memberArrayType_return retval = new PsimulexParser.memberArrayType_return();
        retval.Start = input.LT(1);
        int memberArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberStaticArrayType_return memberStaticArrayType46 = default(PsimulexParser.memberStaticArrayType_return);

        PsimulexParser.dynamicArrayType_return dynamicArrayType47 = default(PsimulexParser.dynamicArrayType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:2: ( memberStaticArrayType | dynamicArrayType )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == 140) )
            {
                int LA14_1 = input.LA(2);

                if ( (LA14_1 == IntegerLiteral) )
                {
                    alt14 = 1;
                }
                else if ( ((LA14_1 >= 141 && LA14_1 <= 142)) )
                {
                    alt14 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d14s1 =
                        new NoViableAltException("", 14, 1, input);

                    throw nvae_d14s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:4: memberStaticArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberStaticArrayType_in_memberArrayType884);
                    	memberStaticArrayType46 = memberStaticArrayType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberStaticArrayType46.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:28: dynamicArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dynamicArrayType_in_memberArrayType888);
                    	dynamicArrayType47 = dynamicArrayType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dynamicArrayType47.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 17, memberArrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberArrayType"

    public class memberStaticArrayType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "memberStaticArrayType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:177:1: memberStaticArrayType : '[' IntegerLiteral ( ',' IntegerLiteral )* ']' -> ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* ) ;
    public PsimulexParser.memberStaticArrayType_return memberStaticArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.memberStaticArrayType_return retval = new PsimulexParser.memberStaticArrayType_return();
        retval.Start = input.LT(1);
        int memberStaticArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal48 = null;
        IToken IntegerLiteral49 = null;
        IToken char_literal50 = null;
        IToken IntegerLiteral51 = null;
        IToken char_literal52 = null;

        CommonTree char_literal48_tree=null;
        CommonTree IntegerLiteral49_tree=null;
        CommonTree char_literal50_tree=null;
        CommonTree IntegerLiteral51_tree=null;
        CommonTree char_literal52_tree=null;
        RewriteRuleTokenStream stream_IntegerLiteral = new RewriteRuleTokenStream(adaptor,"token IntegerLiteral");
        RewriteRuleTokenStream stream_140 = new RewriteRuleTokenStream(adaptor,"token 140");
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleTokenStream stream_141 = new RewriteRuleTokenStream(adaptor,"token 141");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:2: ( '[' IntegerLiteral ( ',' IntegerLiteral )* ']' -> ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:4: '[' IntegerLiteral ( ',' IntegerLiteral )* ']'
            {
            	char_literal48=(IToken)Match(input,140,FOLLOW_140_in_memberStaticArrayType899); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_140.Add(char_literal48);

            	IntegerLiteral49=(IToken)Match(input,IntegerLiteral,FOLLOW_IntegerLiteral_in_memberStaticArrayType901); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_IntegerLiteral.Add(IntegerLiteral49);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:23: ( ',' IntegerLiteral )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == 141) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:24: ',' IntegerLiteral
            			    {
            			    	char_literal50=(IToken)Match(input,141,FOLLOW_141_in_memberStaticArrayType904); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_141.Add(char_literal50);

            			    	IntegerLiteral51=(IToken)Match(input,IntegerLiteral,FOLLOW_IntegerLiteral_in_memberStaticArrayType906); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_IntegerLiteral.Add(IntegerLiteral51);


            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	char_literal52=(IToken)Match(input,142,FOLLOW_142_in_memberStaticArrayType910); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal52);



            	// AST REWRITE
            	// elements:          IntegerLiteral, IntegerLiteral
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 178:49: -> ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:52: ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CONSTANT_DIMS, "CONSTANT_DIMS"), root_1);

            	    adaptor.AddChild(root_1, stream_IntegerLiteral.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:84: ( IntegerLiteral )*
            	    while ( stream_IntegerLiteral.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_IntegerLiteral.NextNode());

            	    }
            	    stream_IntegerLiteral.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 18, memberStaticArrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberStaticArrayType"

    public class memberTypedIdentifierNonRef_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "memberTypedIdentifierNonRef"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:1: memberTypedIdentifierNonRef : memberScalarOrArrayType Identifier ;
    public PsimulexParser.memberTypedIdentifierNonRef_return memberTypedIdentifierNonRef() // throws RecognitionException [1]
    {   
        PsimulexParser.memberTypedIdentifierNonRef_return retval = new PsimulexParser.memberTypedIdentifierNonRef_return();
        retval.Start = input.LT(1);
        int memberTypedIdentifierNonRef_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier54 = null;
        PsimulexParser.memberScalarOrArrayType_return memberScalarOrArrayType53 = default(PsimulexParser.memberScalarOrArrayType_return);


        CommonTree Identifier54_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:2: ( memberScalarOrArrayType Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:4: memberScalarOrArrayType Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_memberScalarOrArrayType_in_memberTypedIdentifierNonRef939);
            	memberScalarOrArrayType53 = memberScalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberScalarOrArrayType53.Tree);
            	Identifier54=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberTypedIdentifierNonRef941); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier54_tree = (CommonTree)adaptor.Create(Identifier54);
            		adaptor.AddChild(root_0, Identifier54_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 19, memberTypedIdentifierNonRef_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberTypedIdentifierNonRef"

    public class typedIdentifierNonRef_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typedIdentifierNonRef"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:1: typedIdentifierNonRef : scalarOrArrayType Identifier ;
    public PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifierNonRef_return retval = new PsimulexParser.typedIdentifierNonRef_return();
        retval.Start = input.LT(1);
        int typedIdentifierNonRef_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier56 = null;
        PsimulexParser.scalarOrArrayType_return scalarOrArrayType55 = default(PsimulexParser.scalarOrArrayType_return);


        CommonTree Identifier56_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:2: ( scalarOrArrayType Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:4: scalarOrArrayType Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef952);
            	scalarOrArrayType55 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType55.Tree);
            	Identifier56=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierNonRef954); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier56_tree = (CommonTree)adaptor.Create(Identifier56);
            		adaptor.AddChild(root_0, Identifier56_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 20, typedIdentifierNonRef_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typedIdentifierNonRef"

    public class typedIdentifierRef_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typedIdentifierRef"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:1: typedIdentifierRef : scalarOrArrayType ( Reference )? Identifier ;
    public PsimulexParser.typedIdentifierRef_return typedIdentifierRef() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifierRef_return retval = new PsimulexParser.typedIdentifierRef_return();
        retval.Start = input.LT(1);
        int typedIdentifierRef_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference58 = null;
        IToken Identifier59 = null;
        PsimulexParser.scalarOrArrayType_return scalarOrArrayType57 = default(PsimulexParser.scalarOrArrayType_return);


        CommonTree Reference58_tree=null;
        CommonTree Identifier59_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:2: ( scalarOrArrayType ( Reference )? Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:4: scalarOrArrayType ( Reference )? Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierRef965);
            	scalarOrArrayType57 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType57.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:22: ( Reference )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == Reference) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: Reference
            	        {
            	        	Reference58=(IToken)Match(input,Reference,FOLLOW_Reference_in_typedIdentifierRef967); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Reference58_tree = (CommonTree)adaptor.Create(Reference58);
            	        		adaptor.AddChild(root_0, Reference58_tree);
            	        	}

            	        }
            	        break;

            	}

            	Identifier59=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierRef970); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier59_tree = (CommonTree)adaptor.Create(Identifier59);
            		adaptor.AddChild(root_0, Identifier59_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 21, typedIdentifierRef_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typedIdentifierRef"

    public class typedIdentifier_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typedIdentifier"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:1: typedIdentifier : ( typedIdentifierNonRef | typedIdentifierRef );
    public PsimulexParser.typedIdentifier_return typedIdentifier() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifier_return retval = new PsimulexParser.typedIdentifier_return();
        retval.Start = input.LT(1);
        int typedIdentifier_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef60 = default(PsimulexParser.typedIdentifierNonRef_return);

        PsimulexParser.typedIdentifierRef_return typedIdentifierRef61 = default(PsimulexParser.typedIdentifierRef_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:2: ( typedIdentifierNonRef | typedIdentifierRef )
            int alt17 = 2;
            switch ( input.LA(1) ) 
            {
            case Bool:
            case Char:
            case Int:
            case Decimal:
            case String:
            case Void:
            	{
                int LA17_1 = input.LA(2);

                if ( (synpred19_Psimulex()) )
                {
                    alt17 = 1;
                }
                else if ( (true) )
                {
                    alt17 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d17s1 =
                        new NoViableAltException("", 17, 1, input);

                    throw nvae_d17s1;
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
            case Thread:
            case Timer:
            case Graph:
            case Node:
            case Edge:
            	{
                int LA17_2 = input.LA(2);

                if ( (synpred19_Psimulex()) )
                {
                    alt17 = 1;
                }
                else if ( (true) )
                {
                    alt17 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d17s2 =
                        new NoViableAltException("", 17, 2, input);

                    throw nvae_d17s2;
                }
                }
                break;
            case Identifier:
            	{
                int LA17_3 = input.LA(2);

                if ( (synpred19_Psimulex()) )
                {
                    alt17 = 1;
                }
                else if ( (true) )
                {
                    alt17 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d17s3 =
                        new NoViableAltException("", 17, 3, input);

                    throw nvae_d17s3;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            }

            switch (alt17) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:4: typedIdentifierNonRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_typedIdentifier983);
                    	typedIdentifierNonRef60 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierNonRef60.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:28: typedIdentifierRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierRef_in_typedIdentifier987);
                    	typedIdentifierRef61 = typedIdentifierRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierRef61.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 22, typedIdentifier_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typedIdentifier"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:1: functionDeclarations : ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) ;
    public PsimulexParser.functionDeclarations_return functionDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclarations_return retval = new PsimulexParser.functionDeclarations_return();
        retval.Start = input.LT(1);
        int functionDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.functionDeclaration_return functionDeclaration62 = default(PsimulexParser.functionDeclaration_return);


        RewriteRuleSubtreeStream stream_functionDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule functionDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:5: ( ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:7: ( functionDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:7: ( functionDeclaration )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == Identifier || (LA18_0 >= Bool && LA18_0 <= Edge)) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: functionDeclaration
            			    {
            			    	PushFollow(FOLLOW_functionDeclaration_in_functionDeclarations1004);
            			    	functionDeclaration62 = functionDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_functionDeclaration.Add(functionDeclaration62.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements



            	// AST REWRITE
            	// elements:          functionDeclaration
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 198:28: -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:31: ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION_DECLARATIONS, "FUNCTION_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:56: ( functionDeclaration )*
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 23, functionDeclarations_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:1: functionDeclaration : typedIdentifier formalParameterList block -> ^( FUNCDEC typedIdentifier ( formalParameterList )? block ) ;
    public PsimulexParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclaration_return retval = new PsimulexParser.functionDeclaration_return();
        retval.Start = input.LT(1);
        int functionDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.typedIdentifier_return typedIdentifier63 = default(PsimulexParser.typedIdentifier_return);

        PsimulexParser.formalParameterList_return formalParameterList64 = default(PsimulexParser.formalParameterList_return);

        PsimulexParser.block_return block65 = default(PsimulexParser.block_return);


        RewriteRuleSubtreeStream stream_typedIdentifier = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifier");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_formalParameterList = new RewriteRuleSubtreeStream(adaptor,"rule formalParameterList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:5: ( typedIdentifier formalParameterList block -> ^( FUNCDEC typedIdentifier ( formalParameterList )? block ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:7: typedIdentifier formalParameterList block
            {
            	PushFollow(FOLLOW_typedIdentifier_in_functionDeclaration1037);
            	typedIdentifier63 = typedIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier63.Tree);
            	PushFollow(FOLLOW_formalParameterList_in_functionDeclaration1039);
            	formalParameterList64 = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_formalParameterList.Add(formalParameterList64.Tree);
            	PushFollow(FOLLOW_block_in_functionDeclaration1042);
            	block65 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_block.Add(block65.Tree);


            	// AST REWRITE
            	// elements:          formalParameterList, block, typedIdentifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 202:50: -> ^( FUNCDEC typedIdentifier ( formalParameterList )? block )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:53: ^( FUNCDEC typedIdentifier ( formalParameterList )? block )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCDEC, "FUNCDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifier.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:80: ( formalParameterList )?
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 24, functionDeclaration_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:205:1: formalParameterList : '(' ( formalParameter ( ',' formalParameter )* )? ')' -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? ) ;
    public PsimulexParser.formalParameterList_return formalParameterList() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameterList_return retval = new PsimulexParser.formalParameterList_return();
        retval.Start = input.LT(1);
        int formalParameterList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal66 = null;
        IToken char_literal68 = null;
        IToken char_literal70 = null;
        PsimulexParser.formalParameter_return formalParameter67 = default(PsimulexParser.formalParameter_return);

        PsimulexParser.formalParameter_return formalParameter69 = default(PsimulexParser.formalParameter_return);


        CommonTree char_literal66_tree=null;
        CommonTree char_literal68_tree=null;
        CommonTree char_literal70_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_141 = new RewriteRuleTokenStream(adaptor,"token 141");
        RewriteRuleSubtreeStream stream_formalParameter = new RewriteRuleSubtreeStream(adaptor,"rule formalParameter");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:5: ( '(' ( formalParameter ( ',' formalParameter )* )? ')' -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:9: '(' ( formalParameter ( ',' formalParameter )* )? ')'
            {
            	char_literal66=(IToken)Match(input,143,FOLLOW_143_in_formalParameterList1076); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_143.Add(char_literal66);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:13: ( formalParameter ( ',' formalParameter )* )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == Identifier || (LA20_0 >= Bool && LA20_0 <= Edge)) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:15: formalParameter ( ',' formalParameter )*
            	        {
            	        	PushFollow(FOLLOW_formalParameter_in_formalParameterList1080);
            	        	formalParameter67 = formalParameter();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_formalParameter.Add(formalParameter67.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:31: ( ',' formalParameter )*
            	        	do 
            	        	{
            	        	    int alt19 = 2;
            	        	    int LA19_0 = input.LA(1);

            	        	    if ( (LA19_0 == 141) )
            	        	    {
            	        	        alt19 = 1;
            	        	    }


            	        	    switch (alt19) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:32: ',' formalParameter
            	        			    {
            	        			    	char_literal68=(IToken)Match(input,141,FOLLOW_141_in_formalParameterList1083); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_141.Add(char_literal68);

            	        			    	PushFollow(FOLLOW_formalParameter_in_formalParameterList1085);
            	        			    	formalParameter69 = formalParameter();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_formalParameter.Add(formalParameter69.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop19;
            	        	    }
            	        	} while (true);

            	        	loop19:
            	        		;	// Stops C# compiler whining that label 'loop19' has no statements


            	        }
            	        break;

            	}

            	char_literal70=(IToken)Match(input,144,FOLLOW_144_in_formalParameterList1092); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_144.Add(char_literal70);



            	// AST REWRITE
            	// elements:          formalParameter, formalParameter
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 206:61: -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:64: ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORMAL_PARAMETER_LIST, "FORMAL_PARAMETER_LIST"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:89: ( formalParameter ( formalParameter )* )?
            	    if ( stream_formalParameter.HasNext() || stream_formalParameter.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_formalParameter.NextTree());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:107: ( formalParameter )*
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 25, formalParameterList_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:1: formalParameter : typedIdentifier -> ^( FORMAL_PARAMETER typedIdentifier ) ;
    public PsimulexParser.formalParameter_return formalParameter() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameter_return retval = new PsimulexParser.formalParameter_return();
        retval.Start = input.LT(1);
        int formalParameter_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.typedIdentifier_return typedIdentifier71 = default(PsimulexParser.typedIdentifier_return);


        RewriteRuleSubtreeStream stream_typedIdentifier = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifier");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:5: ( typedIdentifier -> ^( FORMAL_PARAMETER typedIdentifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:9: typedIdentifier
            {
            	PushFollow(FOLLOW_typedIdentifier_in_formalParameter1129);
            	typedIdentifier71 = typedIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier71.Tree);


            	// AST REWRITE
            	// elements:          typedIdentifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 210:25: -> ^( FORMAL_PARAMETER typedIdentifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:28: ^( FORMAL_PARAMETER typedIdentifier )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORMAL_PARAMETER, "FORMAL_PARAMETER"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifier.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 26, formalParameter_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:218:1: type : dataType ;
    public PsimulexParser.type_return type() // throws RecognitionException [1]
    {   
        PsimulexParser.type_return retval = new PsimulexParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataType_return dataType72 = default(PsimulexParser.dataType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:219:5: ( dataType )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:219:7: dataType
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dataType_in_type1165);
            	dataType72 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType72.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 27, type_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:1: dataType : dataTypeName -> ^( DATATYPE dataTypeName ) ;
    public PsimulexParser.dataType_return dataType() // throws RecognitionException [1]
    {   
        PsimulexParser.dataType_return retval = new PsimulexParser.dataType_return();
        retval.Start = input.LT(1);
        int dataType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataTypeName_return dataTypeName73 = default(PsimulexParser.dataTypeName_return);


        RewriteRuleSubtreeStream stream_dataTypeName = new RewriteRuleSubtreeStream(adaptor,"rule dataTypeName");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:2: ( dataTypeName -> ^( DATATYPE dataTypeName ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:4: dataTypeName
            {
            	PushFollow(FOLLOW_dataTypeName_in_dataType1184);
            	dataTypeName73 = dataTypeName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataTypeName.Add(dataTypeName73.Tree);


            	// AST REWRITE
            	// elements:          dataTypeName
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 229:17: -> ^( DATATYPE dataTypeName )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:20: ^( DATATYPE dataTypeName )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 28, dataType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:232:1: dataTypeName : ( primitiveType | builtInType | userDefinedTypes );
    public PsimulexParser.dataTypeName_return dataTypeName() // throws RecognitionException [1]
    {   
        PsimulexParser.dataTypeName_return retval = new PsimulexParser.dataTypeName_return();
        retval.Start = input.LT(1);
        int dataTypeName_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primitiveType_return primitiveType74 = default(PsimulexParser.primitiveType_return);

        PsimulexParser.builtInType_return builtInType75 = default(PsimulexParser.builtInType_return);

        PsimulexParser.userDefinedTypes_return userDefinedTypes76 = default(PsimulexParser.userDefinedTypes_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:2: ( primitiveType | builtInType | userDefinedTypes )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case Bool:
            case Char:
            case Int:
            case Decimal:
            case String:
            case Void:
            	{
                alt21 = 1;
                }
                break;
            case Tree:
            case BinTree:
            case Set:
            case List:
            case Stack:
            case Queue:
            case PQueue:
            case Thread:
            case Timer:
            case Graph:
            case Node:
            case Edge:
            	{
                alt21 = 2;
                }
                break;
            case Identifier:
            	{
                alt21 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:4: primitiveType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primitiveType_in_dataTypeName1205);
                    	primitiveType74 = primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType74.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:20: builtInType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtInType_in_dataTypeName1209);
                    	builtInType75 = builtInType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType75.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:34: userDefinedTypes
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_userDefinedTypes_in_dataTypeName1213);
                    	userDefinedTypes76 = userDefinedTypes();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, userDefinedTypes76.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 29, dataTypeName_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:236:1: userDefinedTypes : Identifier ;
    public PsimulexParser.userDefinedTypes_return userDefinedTypes() // throws RecognitionException [1]
    {   
        PsimulexParser.userDefinedTypes_return retval = new PsimulexParser.userDefinedTypes_return();
        retval.Start = input.LT(1);
        int userDefinedTypes_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier77 = null;

        CommonTree Identifier77_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier77=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_userDefinedTypes1225); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier77_tree = (CommonTree)adaptor.Create(Identifier77);
            		adaptor.AddChild(root_0, Identifier77_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 30, userDefinedTypes_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:240:1: primitiveType : ( Bool | Char | Int | Decimal | String | Void );
    public PsimulexParser.primitiveType_return primitiveType() // throws RecognitionException [1]
    {   
        PsimulexParser.primitiveType_return retval = new PsimulexParser.primitiveType_return();
        retval.Start = input.LT(1);
        int primitiveType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set78 = null;

        CommonTree set78_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:241:5: ( Bool | Char | Int | Decimal | String | Void )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set78 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Bool && input.LA(1) <= Void) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set78));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 31, primitiveType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:250:1: builtInType : ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Thread | Timer | Graph | Node | Edge );
    public PsimulexParser.builtInType_return builtInType() // throws RecognitionException [1]
    {   
        PsimulexParser.builtInType_return retval = new PsimulexParser.builtInType_return();
        retval.Start = input.LT(1);
        int builtInType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set79 = null;

        CommonTree set79_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:251:5: ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Thread | Timer | Graph | Node | Edge )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set79 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= Edge) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set79));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 32, builtInType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:288:1: expression : exp -> ^( EXPRESSION exp ) ;
    public PsimulexParser.expression_return expression() // throws RecognitionException [1]
    {   
        PsimulexParser.expression_return retval = new PsimulexParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.exp_return exp80 = default(PsimulexParser.exp_return);


        RewriteRuleSubtreeStream stream_exp = new RewriteRuleSubtreeStream(adaptor,"rule exp");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:2: ( exp -> ^( EXPRESSION exp ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:4: exp
            {
            	PushFollow(FOLLOW_exp_in_expression1382);
            	exp80 = exp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_exp.Add(exp80.Tree);


            	// AST REWRITE
            	// elements:          exp
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 289:8: -> ^( EXPRESSION exp )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:11: ^( EXPRESSION exp )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 33, expression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:292:1: exp : ( assignment | conditionalOrExpression );
    public PsimulexParser.exp_return exp() // throws RecognitionException [1]
    {   
        PsimulexParser.exp_return retval = new PsimulexParser.exp_return();
        retval.Start = input.LT(1);
        int exp_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.assignment_return assignment81 = default(PsimulexParser.assignment_return);

        PsimulexParser.conditionalOrExpression_return conditionalOrExpression82 = default(PsimulexParser.conditionalOrExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:2: ( assignment | conditionalOrExpression )
            int alt22 = 2;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                int LA22_1 = input.LA(2);

                if ( (synpred41_Psimulex()) )
                {
                    alt22 = 1;
                }
                else if ( (true) )
                {
                    alt22 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d22s1 =
                        new NoViableAltException("", 22, 1, input);

                    throw nvae_d22s1;
                }
                }
                break;
            case 143:
            	{
                int LA22_2 = input.LA(2);

                if ( (synpred41_Psimulex()) )
                {
                    alt22 = 1;
                }
                else if ( (true) )
                {
                    alt22 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d22s2 =
                        new NoViableAltException("", 22, 2, input);

                    throw nvae_d22s2;
                }
                }
                break;
            case StringLiteral:
            case IntegerLiteral:
            case Minus:
            case LogicalNot:
            case PlusPlus:
            case MinusMinus:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            	{
                alt22 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("", 22, 0, input);

            	    throw nvae_d22s0;
            }

            switch (alt22) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_exp1404);
                    	assignment81 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment81.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:17: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_exp1408);
                    	conditionalOrExpression82 = conditionalOrExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression82.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 34, exp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:296:1: assignment : leftValue assignmentOperator exp ;
    public PsimulexParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        PsimulexParser.assignment_return retval = new PsimulexParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue83 = default(PsimulexParser.leftValue_return);

        PsimulexParser.assignmentOperator_return assignmentOperator84 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.exp_return exp85 = default(PsimulexParser.exp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:2: ( leftValue assignmentOperator exp )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:4: leftValue assignmentOperator exp
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_leftValue_in_assignment1421);
            	leftValue83 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue83.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment1423);
            	assignmentOperator84 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assignmentOperator84.Tree, root_0);
            	PushFollow(FOLLOW_exp_in_assignment1426);
            	exp85 = exp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exp85.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 35, assignment_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:300:1: assignmentOperator : ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo );
    public PsimulexParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        PsimulexParser.assignmentOperator_return retval = new PsimulexParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set86 = null;

        CommonTree set86_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:2: ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set86 = (IToken)input.LT(1);
            	if ( input.LA(1) == Assign || (input.LA(1) >= AssignAndAdd && input.LA(1) <= AssignAndModulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set86));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 36, assignmentOperator_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:304:1: conditionalOrExpression : conditionalAndExpression ( LogicalOr conditionalAndExpression )* ;
    public PsimulexParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalOrExpression_return retval = new PsimulexParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalOr88 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression87 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression89 = default(PsimulexParser.conditionalAndExpression_return);


        CommonTree LogicalOr88_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:5: ( conditionalAndExpression ( LogicalOr conditionalAndExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:9: conditionalAndExpression ( LogicalOr conditionalAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1467);
            	conditionalAndExpression87 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression87.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:34: ( LogicalOr conditionalAndExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == LogicalOr) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:36: LogicalOr conditionalAndExpression
            			    {
            			    	LogicalOr88=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression1471); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalOr88_tree = (CommonTree)adaptor.Create(LogicalOr88);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalOr88_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1474);
            			    	conditionalAndExpression89 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression89.Tree);

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 37, conditionalOrExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:308:1: conditionalAndExpression : equalityExpression ( LogicalAnd equalityExpression )* ;
    public PsimulexParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalAndExpression_return retval = new PsimulexParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalAnd91 = null;
        PsimulexParser.equalityExpression_return equalityExpression90 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression92 = default(PsimulexParser.equalityExpression_return);


        CommonTree LogicalAnd91_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:5: ( equalityExpression ( LogicalAnd equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:9: equalityExpression ( LogicalAnd equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1496);
            	equalityExpression90 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression90.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:28: ( LogicalAnd equalityExpression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == LogicalAnd) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:30: LogicalAnd equalityExpression
            			    {
            			    	LogicalAnd91=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression1500); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd91_tree = (CommonTree)adaptor.Create(LogicalAnd91);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd91_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1503);
            			    	equalityExpression92 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression92.Tree);

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 38, conditionalAndExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:312:1: equalityExpression : relationalExpression ( equalityOp relationalExpression )* ;
    public PsimulexParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityExpression_return retval = new PsimulexParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.relationalExpression_return relationalExpression93 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.equalityOp_return equalityOp94 = default(PsimulexParser.equalityOp_return);

        PsimulexParser.relationalExpression_return relationalExpression95 = default(PsimulexParser.relationalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:5: ( relationalExpression ( equalityOp relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:9: relationalExpression ( equalityOp relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1525);
            	relationalExpression93 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression93.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:30: ( equalityOp relationalExpression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( ((LA25_0 >= RelEqual && LA25_0 <= RelNotEqual)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:32: equalityOp relationalExpression
            			    {
            			    	PushFollow(FOLLOW_equalityOp_in_equalityExpression1529);
            			    	equalityOp94 = equalityOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp94.Tree, root_0);
            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1532);
            			    	relationalExpression95 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression95.Tree);

            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 39, equalityExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:316:1: equalityOp : ( RelEqual | RelNotEqual );
    public PsimulexParser.equalityOp_return equalityOp() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityOp_return retval = new PsimulexParser.equalityOp_return();
        retval.Start = input.LT(1);
        int equalityOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set96 = null;

        CommonTree set96_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:2: ( RelEqual | RelNotEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set96 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelEqual && input.LA(1) <= RelNotEqual) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set96));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 40, equalityOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:320:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
    public PsimulexParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalExpression_return retval = new PsimulexParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.additiveExpression_return additiveExpression97 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp98 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression99 = default(PsimulexParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1567);
            	additiveExpression97 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression97.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:28: ( relationalOp additiveExpression )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= RelLessThan && LA26_0 <= RelGreaterThanOrEqual)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression1571);
            			    	relationalOp98 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp98.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1574);
            			    	additiveExpression99 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression99.Tree);

            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 41, relationalExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:324:1: relationalOp : ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual );
    public PsimulexParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalOp_return retval = new PsimulexParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set100 = null;

        CommonTree set100_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:5: ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set100 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelLessThan && input.LA(1) <= RelGreaterThanOrEqual) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set100));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 42, relationalOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:328:1: additiveExpression : multiplicativeExpression ( additiveOp multiplicativeExpression )* ;
    public PsimulexParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveExpression_return retval = new PsimulexParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression101 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.additiveOp_return additiveOp102 = default(PsimulexParser.additiveOp_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression103 = default(PsimulexParser.multiplicativeExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:5: ( multiplicativeExpression ( additiveOp multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:9: multiplicativeExpression ( additiveOp multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1627);
            	multiplicativeExpression101 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression101.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:34: ( additiveOp multiplicativeExpression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= Plus && LA27_0 <= Minus)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:36: additiveOp multiplicativeExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression1631);
            			    	additiveOp102 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp102.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1634);
            			    	multiplicativeExpression103 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression103.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 43, additiveExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:332:1: additiveOp : ( Plus | Minus );
    public PsimulexParser.additiveOp_return additiveOp() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveOp_return retval = new PsimulexParser.additiveOp_return();
        retval.Start = input.LT(1);
        int additiveOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set104 = null;

        CommonTree set104_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:2: ( Plus | Minus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set104 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set104));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 44, additiveOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:336:1: multiplicativeExpression : unaryExpression ( multiplicativeOp unaryExpression )* ;
    public PsimulexParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeExpression_return retval = new PsimulexParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryExpression_return unaryExpression105 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.multiplicativeOp_return multiplicativeOp106 = default(PsimulexParser.multiplicativeOp_return);

        PsimulexParser.unaryExpression_return unaryExpression107 = default(PsimulexParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:5: ( unaryExpression ( multiplicativeOp unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:9: unaryExpression ( multiplicativeOp unaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1669);
            	unaryExpression105 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression105.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:25: ( multiplicativeOp unaryExpression )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( ((LA28_0 >= Star && LA28_0 <= Modulo)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:27: multiplicativeOp unaryExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression1673);
            			    	multiplicativeOp106 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp106.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1676);
            			    	unaryExpression107 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression107.Tree);

            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 45, multiplicativeExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:340:1: multiplicativeOp : ( Star | Divide | Modulo );
    public PsimulexParser.multiplicativeOp_return multiplicativeOp() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeOp_return retval = new PsimulexParser.multiplicativeOp_return();
        retval.Start = input.LT(1);
        int multiplicativeOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set108 = null;

        CommonTree set108_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:2: ( Star | Divide | Modulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set108 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Star && input.LA(1) <= Modulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set108));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 46, multiplicativeOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:344:1: unaryExpression : ( unaryPrefixExpression | unaryPostfixExpression | castExpression );
    public PsimulexParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpression_return retval = new PsimulexParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixExpression_return unaryPrefixExpression109 = default(PsimulexParser.unaryPrefixExpression_return);

        PsimulexParser.unaryPostfixExpression_return unaryPostfixExpression110 = default(PsimulexParser.unaryPostfixExpression_return);

        PsimulexParser.castExpression_return castExpression111 = default(PsimulexParser.castExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:345:5: ( unaryPrefixExpression | unaryPostfixExpression | castExpression )
            int alt29 = 3;
            switch ( input.LA(1) ) 
            {
            case Minus:
            case LogicalNot:
            	{
                alt29 = 1;
                }
                break;
            case StringLiteral:
            case Identifier:
            case IntegerLiteral:
            case PlusPlus:
            case MinusMinus:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            	{
                alt29 = 2;
                }
                break;
            case 143:
            	{
                int LA29_3 = input.LA(2);

                if ( (synpred61_Psimulex()) )
                {
                    alt29 = 2;
                }
                else if ( (true) )
                {
                    alt29 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d29s3 =
                        new NoViableAltException("", 29, 3, input);

                    throw nvae_d29s3;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d29s0 =
            	        new NoViableAltException("", 29, 0, input);

            	    throw nvae_d29s0;
            }

            switch (alt29) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:345:7: unaryPrefixExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPrefixExpression_in_unaryExpression1711);
                    	unaryPrefixExpression109 = unaryPrefixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPrefixExpression109.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:7: unaryPostfixExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPostfixExpression_in_unaryExpression1719);
                    	unaryPostfixExpression110 = unaryPostfixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPostfixExpression110.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:4: castExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpression1724);
                    	castExpression111 = castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, castExpression111.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 47, unaryExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:1: unaryPrefixExpression : unaryPrefixOp unaryExpression -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) ) ;
    public PsimulexParser.unaryPrefixExpression_return unaryPrefixExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixExpression_return retval = new PsimulexParser.unaryPrefixExpression_return();
        retval.Start = input.LT(1);
        int unaryPrefixExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixOp_return unaryPrefixOp112 = default(PsimulexParser.unaryPrefixOp_return);

        PsimulexParser.unaryExpression_return unaryExpression113 = default(PsimulexParser.unaryExpression_return);


        RewriteRuleSubtreeStream stream_unaryPrefixOp = new RewriteRuleSubtreeStream(adaptor,"rule unaryPrefixOp");
        RewriteRuleSubtreeStream stream_unaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule unaryExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:2: ( unaryPrefixOp unaryExpression -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:4: unaryPrefixOp unaryExpression
            {
            	PushFollow(FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1738);
            	unaryPrefixOp112 = unaryPrefixOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryPrefixOp.Add(unaryPrefixOp112.Tree);
            	PushFollow(FOLLOW_unaryExpression_in_unaryPrefixExpression1740);
            	unaryExpression113 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryExpression.Add(unaryExpression113.Tree);


            	// AST REWRITE
            	// elements:          unaryPrefixOp, unaryExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 351:34: -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:37: ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PREFIXOP, "PREFIXOP"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:49: ^( unaryPrefixOp unaryExpression )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 48, unaryPrefixExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:354:1: unaryPostfixExpression : ( leftValueExpression ( unaryPostfixOp )? | primaryExpression );
    public PsimulexParser.unaryPostfixExpression_return unaryPostfixExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixExpression_return retval = new PsimulexParser.unaryPostfixExpression_return();
        retval.Start = input.LT(1);
        int unaryPostfixExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValueExpression_return leftValueExpression114 = default(PsimulexParser.leftValueExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp115 = default(PsimulexParser.unaryPostfixOp_return);

        PsimulexParser.primaryExpression_return primaryExpression116 = default(PsimulexParser.primaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:2: ( leftValueExpression ( unaryPostfixOp )? | primaryExpression )
            int alt31 = 2;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                int LA31_1 = input.LA(2);

                if ( (synpred63_Psimulex()) )
                {
                    alt31 = 1;
                }
                else if ( (true) )
                {
                    alt31 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d31s1 =
                        new NoViableAltException("", 31, 1, input);

                    throw nvae_d31s1;
                }
                }
                break;
            case 143:
            	{
                int LA31_2 = input.LA(2);

                if ( (synpred63_Psimulex()) )
                {
                    alt31 = 1;
                }
                else if ( (true) )
                {
                    alt31 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d31s2 =
                        new NoViableAltException("", 31, 2, input);

                    throw nvae_d31s2;
                }
                }
                break;
            case PlusPlus:
            case MinusMinus:
            	{
                alt31 = 1;
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
                alt31 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d31s0 =
            	        new NoViableAltException("", 31, 0, input);

            	    throw nvae_d31s0;
            }

            switch (alt31) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:4: leftValueExpression ( unaryPostfixOp )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValueExpression_in_unaryPostfixExpression1770);
                    	leftValueExpression114 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValueExpression114.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:24: ( unaryPostfixOp )?
                    	int alt30 = 2;
                    	int LA30_0 = input.LA(1);

                    	if ( ((LA30_0 >= PlusPlus && LA30_0 <= MinusMinus)) )
                    	{
                    	    alt30 = 1;
                    	}
                    	switch (alt30) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:25: unaryPostfixOp
                    	        {
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1773);
                    	        	unaryPostfixOp115 = unaryPostfixOp();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp115.Tree, root_0);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:356:4: primaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryPostfixExpression1781);
                    	primaryExpression116 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression116.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 49, unaryPostfixExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:1: leftValueExpression : ( leftValue | unaryPrefixAssignerOp leftValueExpression -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) ) );
    public PsimulexParser.leftValueExpression_return leftValueExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValueExpression_return retval = new PsimulexParser.leftValueExpression_return();
        retval.Start = input.LT(1);
        int leftValueExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue117 = default(PsimulexParser.leftValue_return);

        PsimulexParser.unaryPrefixAssignerOp_return unaryPrefixAssignerOp118 = default(PsimulexParser.unaryPrefixAssignerOp_return);

        PsimulexParser.leftValueExpression_return leftValueExpression119 = default(PsimulexParser.leftValueExpression_return);


        RewriteRuleSubtreeStream stream_leftValueExpression = new RewriteRuleSubtreeStream(adaptor,"rule leftValueExpression");
        RewriteRuleSubtreeStream stream_unaryPrefixAssignerOp = new RewriteRuleSubtreeStream(adaptor,"rule unaryPrefixAssignerOp");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:2: ( leftValue | unaryPrefixAssignerOp leftValueExpression -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) ) )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == Identifier || LA32_0 == 143) )
            {
                alt32 = 1;
            }
            else if ( ((LA32_0 >= PlusPlus && LA32_0 <= MinusMinus)) )
            {
                alt32 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d32s0 =
                    new NoViableAltException("", 32, 0, input);

                throw nvae_d32s0;
            }
            switch (alt32) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:4: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_leftValueExpression1792);
                    	leftValue117 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue117.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:361:4: unaryPrefixAssignerOp leftValueExpression
                    {
                    	PushFollow(FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1797);
                    	unaryPrefixAssignerOp118 = unaryPrefixAssignerOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_unaryPrefixAssignerOp.Add(unaryPrefixAssignerOp118.Tree);
                    	PushFollow(FOLLOW_leftValueExpression_in_leftValueExpression1799);
                    	leftValueExpression119 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_leftValueExpression.Add(leftValueExpression119.Tree);


                    	// AST REWRITE
                    	// elements:          unaryPrefixAssignerOp, leftValueExpression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 361:46: -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:361:49: ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PREFIXOP, "PREFIXOP"), root_1);

                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:361:61: ^( unaryPrefixAssignerOp leftValueExpression )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 50, leftValueExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:364:1: castExpression : '(' dataType ')' unaryExpression -> ^( CAST dataType unaryExpression ) ;
    public PsimulexParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.castExpression_return retval = new PsimulexParser.castExpression_return();
        retval.Start = input.LT(1);
        int castExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal120 = null;
        IToken char_literal122 = null;
        PsimulexParser.dataType_return dataType121 = default(PsimulexParser.dataType_return);

        PsimulexParser.unaryExpression_return unaryExpression123 = default(PsimulexParser.unaryExpression_return);


        CommonTree char_literal120_tree=null;
        CommonTree char_literal122_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleSubtreeStream stream_dataType = new RewriteRuleSubtreeStream(adaptor,"rule dataType");
        RewriteRuleSubtreeStream stream_unaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule unaryExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:2: ( '(' dataType ')' unaryExpression -> ^( CAST dataType unaryExpression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:4: '(' dataType ')' unaryExpression
            {
            	char_literal120=(IToken)Match(input,143,FOLLOW_143_in_castExpression1830); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_143.Add(char_literal120);

            	PushFollow(FOLLOW_dataType_in_castExpression1832);
            	dataType121 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataType.Add(dataType121.Tree);
            	char_literal122=(IToken)Match(input,144,FOLLOW_144_in_castExpression1834); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_144.Add(char_literal122);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1836);
            	unaryExpression123 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryExpression.Add(unaryExpression123.Tree);


            	// AST REWRITE
            	// elements:          dataType, unaryExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 365:37: -> ^( CAST dataType unaryExpression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:40: ^( CAST dataType unaryExpression )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 51, castExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:368:1: unaryPrefixOp : ( Minus | LogicalNot );
    public PsimulexParser.unaryPrefixOp_return unaryPrefixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixOp_return retval = new PsimulexParser.unaryPrefixOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set124 = null;

        CommonTree set124_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:2: ( Minus | LogicalNot )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set124 = (IToken)input.LT(1);
            	if ( input.LA(1) == Minus || input.LA(1) == LogicalNot ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set124));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 52, unaryPrefixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:372:1: unaryPrefixAssignerOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPrefixAssignerOp_return unaryPrefixAssignerOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixAssignerOp_return retval = new PsimulexParser.unaryPrefixAssignerOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixAssignerOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set125 = null;

        CommonTree set125_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set125 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set125));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 53, unaryPrefixAssignerOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:376:1: unaryPostfixOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPostfixOp_return unaryPostfixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixOp_return retval = new PsimulexParser.unaryPostfixOp_return();
        retval.Start = input.LT(1);
        int unaryPostfixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set126 = null;

        CommonTree set126_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set126 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set126));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 54, unaryPostfixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:380:1: primaryExpression : ( parExpression | leftValue | literal | functionCall );
    public PsimulexParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.primaryExpression_return retval = new PsimulexParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression127 = default(PsimulexParser.parExpression_return);

        PsimulexParser.leftValue_return leftValue128 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal129 = default(PsimulexParser.literal_return);

        PsimulexParser.functionCall_return functionCall130 = default(PsimulexParser.functionCall_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:381:5: ( parExpression | leftValue | literal | functionCall )
            int alt33 = 4;
            switch ( input.LA(1) ) 
            {
            case 143:
            	{
                int LA33_1 = input.LA(2);

                if ( (synpred68_Psimulex()) )
                {
                    alt33 = 1;
                }
                else if ( (synpred69_Psimulex()) )
                {
                    alt33 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d33s1 =
                        new NoViableAltException("", 33, 1, input);

                    throw nvae_d33s1;
                }
                }
                break;
            case Identifier:
            	{
                int LA33_2 = input.LA(2);

                if ( (synpred69_Psimulex()) )
                {
                    alt33 = 2;
                }
                else if ( (true) )
                {
                    alt33 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d33s2 =
                        new NoViableAltException("", 33, 2, input);

                    throw nvae_d33s2;
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
                alt33 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d33s0 =
            	        new NoViableAltException("", 33, 0, input);

            	    throw nvae_d33s0;
            }

            switch (alt33) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:381:9: parExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1905);
                    	parExpression127 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression127.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1913);
                    	leftValue128 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue128.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1923);
                    	literal129 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal129.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:384:7: functionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionCall_in_primaryExpression1931);
                    	functionCall130 = functionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall130.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 55, primaryExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:387:1: parExpression : '(' expression ')' ;
    public PsimulexParser.parExpression_return parExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.parExpression_return retval = new PsimulexParser.parExpression_return();
        retval.Start = input.LT(1);
        int parExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal131 = null;
        IToken char_literal133 = null;
        PsimulexParser.expression_return expression132 = default(PsimulexParser.expression_return);


        CommonTree char_literal131_tree=null;
        CommonTree char_literal133_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:388:5: ( '(' expression ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:388:9: '(' expression ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal131=(IToken)Match(input,143,FOLLOW_143_in_parExpression1950); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1953);
            	expression132 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression132.Tree);
            	char_literal133=(IToken)Match(input,144,FOLLOW_144_in_parExpression1955); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 56, parExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:391:1: leftValue : ( variable | selecting );
    public PsimulexParser.leftValue_return leftValue() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValue_return retval = new PsimulexParser.leftValue_return();
        retval.Start = input.LT(1);
        int leftValue_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.variable_return variable134 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting135 = default(PsimulexParser.selecting_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:392:2: ( variable | selecting )
            int alt34 = 2;
            int LA34_0 = input.LA(1);

            if ( (LA34_0 == Identifier) )
            {
                int LA34_1 = input.LA(2);

                if ( (LA34_1 == 140 || LA34_1 == 145) )
                {
                    alt34 = 2;
                }
                else if ( (LA34_1 == EOF || LA34_1 == Assign || (LA34_1 >= AssignAndAdd && LA34_1 <= Modulo) || (LA34_1 >= PlusPlus && LA34_1 <= MinusMinus) || LA34_1 == To || LA34_1 == 137 || (LA34_1 >= 141 && LA34_1 <= 142) || LA34_1 == 144) )
                {
                    alt34 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d34s1 =
                        new NoViableAltException("", 34, 1, input);

                    throw nvae_d34s1;
                }
            }
            else if ( (LA34_0 == 143) )
            {
                alt34 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d34s0 =
                    new NoViableAltException("", 34, 0, input);

                throw nvae_d34s0;
            }
            switch (alt34) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:392:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1970);
                    	variable134 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable134.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1975);
                    	selecting135 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting135.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 57, leftValue_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:396:1: variable : Identifier ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier136 = null;

        CommonTree Identifier136_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier136=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1986); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier136_tree = (CommonTree)adaptor.Create(Identifier136);
            		adaptor.AddChild(root_0, Identifier136_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 58, variable_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:400:1: selecting : selector -> ^( SELECTOR selector ) ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.selector_return selector137 = default(PsimulexParser.selector_return);


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:2: ( selector -> ^( SELECTOR selector ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:4: selector
            {
            	PushFollow(FOLLOW_selector_in_selecting1997);
            	selector137 = selector();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_selector.Add(selector137.Tree);


            	// AST REWRITE
            	// elements:          selector
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 401:13: -> ^( SELECTOR selector )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:16: ^( SELECTOR selector )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 59, selecting_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:404:1: selector : ( Identifier | parExpression ) ( memberSelect | memberFunctionCall | indexing )+ ;
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier138 = null;
        PsimulexParser.parExpression_return parExpression139 = default(PsimulexParser.parExpression_return);

        PsimulexParser.memberSelect_return memberSelect140 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall141 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing142 = default(PsimulexParser.indexing_return);


        CommonTree Identifier138_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:5: ( ( Identifier | parExpression ) ( memberSelect | memberFunctionCall | indexing )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:9: ( Identifier | parExpression ) ( memberSelect | memberFunctionCall | indexing )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:9: ( Identifier | parExpression )
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == Identifier) )
            	{
            	    alt35 = 1;
            	}
            	else if ( (LA35_0 == 143) )
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:11: Identifier
            	        {
            	        	Identifier138=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selector2025); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier138_tree = (CommonTree)adaptor.Create(Identifier138);
            	        		adaptor.AddChild(root_0, Identifier138_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:24: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selector2029);
            	        	parExpression139 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression139.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:40: ( memberSelect | memberFunctionCall | indexing )+
            	int cnt36 = 0;
            	do 
            	{
            	    int alt36 = 4;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == 145) )
            	    {
            	        int LA36_2 = input.LA(2);

            	        if ( (LA36_2 == Identifier) )
            	        {
            	            int LA36_4 = input.LA(3);

            	            if ( (LA36_4 == EOF || LA36_4 == Assign || (LA36_4 >= AssignAndAdd && LA36_4 <= Modulo) || (LA36_4 >= PlusPlus && LA36_4 <= MinusMinus) || LA36_4 == To || LA36_4 == 137 || (LA36_4 >= 140 && LA36_4 <= 142) || (LA36_4 >= 144 && LA36_4 <= 145)) )
            	            {
            	                alt36 = 1;
            	            }
            	            else if ( (LA36_4 == 143) )
            	            {
            	                alt36 = 2;
            	            }


            	        }


            	    }
            	    else if ( (LA36_0 == 140) )
            	    {
            	        alt36 = 3;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:41: memberSelect
            			    {
            			    	PushFollow(FOLLOW_memberSelect_in_selector2034);
            			    	memberSelect140 = memberSelect();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect140.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:56: memberFunctionCall
            			    {
            			    	PushFollow(FOLLOW_memberFunctionCall_in_selector2038);
            			    	memberFunctionCall141 = memberFunctionCall();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall141.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:77: indexing
            			    {
            			    	PushFollow(FOLLOW_indexing_in_selector2042);
            			    	indexing142 = indexing();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing142.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt36 >= 1 ) goto loop36;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(36, input);
            		            throw eee;
            	    }
            	    cnt36++;
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whinging that label 'loop36' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 60, selector_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:408:1: memberSelect : '.' Identifier -> ^( MEMBER_SELECT Identifier ) ;
    public PsimulexParser.memberSelect_return memberSelect() // throws RecognitionException [1]
    {   
        PsimulexParser.memberSelect_return retval = new PsimulexParser.memberSelect_return();
        retval.Start = input.LT(1);
        int memberSelect_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal143 = null;
        IToken Identifier144 = null;

        CommonTree char_literal143_tree=null;
        CommonTree Identifier144_tree=null;
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:2: ( '.' Identifier -> ^( MEMBER_SELECT Identifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:4: '.' Identifier
            {
            	char_literal143=(IToken)Match(input,145,FOLLOW_145_in_memberSelect2058); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal143);

            	Identifier144=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect2060); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier144);



            	// AST REWRITE
            	// elements:          Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 409:19: -> ^( MEMBER_SELECT Identifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:22: ^( MEMBER_SELECT Identifier )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 61, memberSelect_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:412:1: memberFunctionCall : '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal145 = null;
        IToken Identifier146 = null;
        PsimulexParser.arguments_return arguments147 = default(PsimulexParser.arguments_return);


        CommonTree char_literal145_tree=null;
        CommonTree Identifier146_tree=null;
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:2: ( '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:4: '.' Identifier arguments
            {
            	char_literal145=(IToken)Match(input,145,FOLLOW_145_in_memberFunctionCall2081); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal145);

            	Identifier146=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall2083); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier146);

            	PushFollow(FOLLOW_arguments_in_memberFunctionCall2085);
            	arguments147 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments147.Tree);


            	// AST REWRITE
            	// elements:          arguments, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 413:29: -> ^( MEMBER_FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:32: ^( MEMBER_FUNCTION_CALL Identifier arguments )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 62, memberFunctionCall_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:416:1: functionCall : Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.functionCall_return functionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.functionCall_return retval = new PsimulexParser.functionCall_return();
        retval.Start = input.LT(1);
        int functionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier148 = null;
        PsimulexParser.arguments_return arguments149 = default(PsimulexParser.arguments_return);


        CommonTree Identifier148_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:2: ( Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:4: Identifier arguments
            {
            	Identifier148=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionCall2108); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier148);

            	PushFollow(FOLLOW_arguments_in_functionCall2110);
            	arguments149 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments149.Tree);


            	// AST REWRITE
            	// elements:          arguments, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 417:25: -> ^( FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:28: ^( FUNCTION_CALL Identifier arguments )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 63, functionCall_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:421:1: indexing : '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) ;
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal150 = null;
        IToken char_literal152 = null;
        IToken char_literal154 = null;
        PsimulexParser.expression_return expression151 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression153 = default(PsimulexParser.expression_return);


        CommonTree char_literal150_tree=null;
        CommonTree char_literal152_tree=null;
        CommonTree char_literal154_tree=null;
        RewriteRuleTokenStream stream_140 = new RewriteRuleTokenStream(adaptor,"token 140");
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleTokenStream stream_141 = new RewriteRuleTokenStream(adaptor,"token 141");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:2: ( '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:4: '[' expression ( ',' expression )* ']'
            {
            	char_literal150=(IToken)Match(input,140,FOLLOW_140_in_indexing2134); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_140.Add(char_literal150);

            	PushFollow(FOLLOW_expression_in_indexing2136);
            	expression151 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression151.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:19: ( ',' expression )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == 141) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:21: ',' expression
            			    {
            			    	char_literal152=(IToken)Match(input,141,FOLLOW_141_in_indexing2140); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_141.Add(char_literal152);

            			    	PushFollow(FOLLOW_expression_in_indexing2142);
            			    	expression153 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_expression.Add(expression153.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements

            	char_literal154=(IToken)Match(input,142,FOLLOW_142_in_indexing2147); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal154);



            	// AST REWRITE
            	// elements:          expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 422:43: -> ^( INDEXING expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:46: ^( INDEXING expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(INDEXING, "INDEXING"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:69: ( expression )*
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 64, indexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:1: arguments : '(' ( expression ( ',' expression )* )? ')' -> ^( ARGUMENTS ( expression ( expression )* )? ) ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal155 = null;
        IToken char_literal157 = null;
        IToken char_literal159 = null;
        PsimulexParser.expression_return expression156 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression158 = default(PsimulexParser.expression_return);


        CommonTree char_literal155_tree=null;
        CommonTree char_literal157_tree=null;
        CommonTree char_literal159_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_141 = new RewriteRuleTokenStream(adaptor,"token 141");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:5: ( '(' ( expression ( ',' expression )* )? ')' -> ^( ARGUMENTS ( expression ( expression )* )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:9: '(' ( expression ( ',' expression )* )? ')'
            {
            	char_literal155=(IToken)Match(input,143,FOLLOW_143_in_arguments2181); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_143.Add(char_literal155);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:13: ( expression ( ',' expression )* )?
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == StringLiteral || LA39_0 == Identifier || LA39_0 == IntegerLiteral || LA39_0 == Minus || (LA39_0 >= LogicalNot && LA39_0 <= InfinityLiteral) || LA39_0 == 143) )
            	{
            	    alt39 = 1;
            	}
            	switch (alt39) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:15: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_arguments2185);
            	        	expression156 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_expression.Add(expression156.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:26: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt38 = 2;
            	        	    int LA38_0 = input.LA(1);

            	        	    if ( (LA38_0 == 141) )
            	        	    {
            	        	        alt38 = 1;
            	        	    }


            	        	    switch (alt38) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:27: ',' expression
            	        			    {
            	        			    	char_literal157=(IToken)Match(input,141,FOLLOW_141_in_arguments2188); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_141.Add(char_literal157);

            	        			    	PushFollow(FOLLOW_expression_in_arguments2190);
            	        			    	expression158 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_expression.Add(expression158.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop38;
            	        	    }
            	        	} while (true);

            	        	loop38:
            	        		;	// Stops C# compiler whining that label 'loop38' has no statements


            	        }
            	        break;

            	}

            	char_literal159=(IToken)Match(input,144,FOLLOW_144_in_arguments2197); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_144.Add(char_literal159);



            	// AST REWRITE
            	// elements:          expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 426:51: -> ^( ARGUMENTS ( expression ( expression )* )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:54: ^( ARGUMENTS ( expression ( expression )* )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ARGUMENTS, "ARGUMENTS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:67: ( expression ( expression )* )?
            	    if ( stream_expression.HasNext() || stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:80: ( expression )*
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 65, arguments_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:429:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
    public PsimulexParser.literal_return literal() // throws RecognitionException [1]
    {   
        PsimulexParser.literal_return retval = new PsimulexParser.literal_return();
        retval.Start = input.LT(1);
        int literal_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set160 = null;

        CommonTree set160_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 66) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set160 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || input.LA(1) == IntegerLiteral || (input.LA(1) >= DecimalLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set160));
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 66, literal_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "literal"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:477:1: block : '{' ( statement )* '}' -> ^( BLOCK ( ^( STATEMENT statement ) )* ) ;
    public PsimulexParser.block_return block() // throws RecognitionException [1]
    {   
        PsimulexParser.block_return retval = new PsimulexParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal161 = null;
        IToken char_literal163 = null;
        PsimulexParser.statement_return statement162 = default(PsimulexParser.statement_return);


        CommonTree char_literal161_tree=null;
        CommonTree char_literal163_tree=null;
        RewriteRuleTokenStream stream_138 = new RewriteRuleTokenStream(adaptor,"token 138");
        RewriteRuleTokenStream stream_139 = new RewriteRuleTokenStream(adaptor,"token 139");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 67) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:478:5: ( '{' ( statement )* '}' -> ^( BLOCK ( ^( STATEMENT statement ) )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:478:9: '{' ( statement )* '}'
            {
            	char_literal161=(IToken)Match(input,138,FOLLOW_138_in_block2330); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_138.Add(char_literal161);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:478:13: ( statement )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == StringLiteral || LA40_0 == Identifier || LA40_0 == IntegerLiteral || (LA40_0 >= Bool && LA40_0 <= Edge) || LA40_0 == Minus || (LA40_0 >= LogicalNot && LA40_0 <= If) || (LA40_0 >= For && LA40_0 <= ForEach) || LA40_0 == Loop || LA40_0 == 137 || LA40_0 == 143) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block2332);
            			    	statement162 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_statement.Add(statement162.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	char_literal163=(IToken)Match(input,139,FOLLOW_139_in_block2335); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_139.Add(char_literal163);



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 478:28: -> ^( BLOCK ( ^( STATEMENT statement ) )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:478:31: ^( BLOCK ( ^( STATEMENT statement ) )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:478:40: ( ^( STATEMENT statement ) )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:478:40: ^( STATEMENT statement )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 67, block_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:481:1: branch : ( block | statement );
    public PsimulexParser.branch_return branch() // throws RecognitionException [1]
    {   
        PsimulexParser.branch_return retval = new PsimulexParser.branch_return();
        retval.Start = input.LT(1);
        int branch_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.block_return block164 = default(PsimulexParser.block_return);

        PsimulexParser.statement_return statement165 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 68) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:5: ( block | statement )
            int alt41 = 2;
            int LA41_0 = input.LA(1);

            if ( (LA41_0 == 138) )
            {
                alt41 = 1;
            }
            else if ( (LA41_0 == StringLiteral || LA41_0 == Identifier || LA41_0 == IntegerLiteral || (LA41_0 >= Bool && LA41_0 <= Edge) || LA41_0 == Minus || (LA41_0 >= LogicalNot && LA41_0 <= If) || (LA41_0 >= For && LA41_0 <= ForEach) || LA41_0 == Loop || LA41_0 == 137 || LA41_0 == 143) )
            {
                alt41 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d41s0 =
                    new NoViableAltException("", 41, 0, input);

                throw nvae_d41s0;
            }
            switch (alt41) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:7: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch2377);
                    	block164 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block164.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:15: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_branch2381);
                    	statement165 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement165.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 68, branch_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:485:1: statement : ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN ( expression )? ) | Break ';' | ';' | expression ';' | localVariableDeclaration ';' );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PDo174 = null;
        IToken Async176 = null;
        IToken Lock178 = null;
        IToken char_literal179 = null;
        IToken Identifier180 = null;
        IToken char_literal181 = null;
        IToken Return183 = null;
        IToken char_literal185 = null;
        IToken Break186 = null;
        IToken char_literal187 = null;
        IToken char_literal188 = null;
        IToken char_literal190 = null;
        IToken char_literal192 = null;
        PsimulexParser.ifStatement_return ifStatement166 = default(PsimulexParser.ifStatement_return);

        PsimulexParser.forStatement_return forStatement167 = default(PsimulexParser.forStatement_return);

        PsimulexParser.pForStatement_return pForStatement168 = default(PsimulexParser.pForStatement_return);

        PsimulexParser.forEachStatement_return forEachStatement169 = default(PsimulexParser.forEachStatement_return);

        PsimulexParser.pForEachStatement_return pForEachStatement170 = default(PsimulexParser.pForEachStatement_return);

        PsimulexParser.loopStatement_return loopStatement171 = default(PsimulexParser.loopStatement_return);

        PsimulexParser.whileStatement_return whileStatement172 = default(PsimulexParser.whileStatement_return);

        PsimulexParser.doStatement_return doStatement173 = default(PsimulexParser.doStatement_return);

        PsimulexParser.block_return block175 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block177 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block182 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression184 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression189 = default(PsimulexParser.expression_return);

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration191 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree PDo174_tree=null;
        CommonTree Async176_tree=null;
        CommonTree Lock178_tree=null;
        CommonTree char_literal179_tree=null;
        CommonTree Identifier180_tree=null;
        CommonTree char_literal181_tree=null;
        CommonTree Return183_tree=null;
        CommonTree char_literal185_tree=null;
        CommonTree Break186_tree=null;
        CommonTree char_literal187_tree=null;
        CommonTree char_literal188_tree=null;
        CommonTree char_literal190_tree=null;
        CommonTree char_literal192_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_Async = new RewriteRuleTokenStream(adaptor,"token Async");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_137 = new RewriteRuleTokenStream(adaptor,"token 137");
        RewriteRuleTokenStream stream_Return = new RewriteRuleTokenStream(adaptor,"token Return");
        RewriteRuleTokenStream stream_Lock = new RewriteRuleTokenStream(adaptor,"token Lock");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_PDo = new RewriteRuleTokenStream(adaptor,"token PDo");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_ifStatement = new RewriteRuleSubtreeStream(adaptor,"rule ifStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 69) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:486:5: ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN ( expression )? ) | Break ';' | ';' | expression ';' | localVariableDeclaration ';' )
            int alt45 = 14;
            alt45 = dfa45.Predict(input);
            switch (alt45) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:486:7: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement2398);
                    	ifStatement166 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_ifStatement.Add(ifStatement166.Tree);


                    	// AST REWRITE
                    	// elements:          ifStatement
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 486:19: -> ^( IFSTATEMENT ifStatement )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:486:22: ^( IFSTATEMENT ifStatement )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:487:7: ( forStatement | pForStatement )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:487:7: ( forStatement | pForStatement )
                    	int alt42 = 2;
                    	int LA42_0 = input.LA(1);

                    	if ( (LA42_0 == For) )
                    	{
                    	    alt42 = 1;
                    	}
                    	else if ( (LA42_0 == PFor) )
                    	{
                    	    alt42 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d42s0 =
                    	        new NoViableAltException("", 42, 0, input);

                    	    throw nvae_d42s0;
                    	}
                    	switch (alt42) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:487:9: forStatement
                    	        {
                    	        	PushFollow(FOLLOW_forStatement_in_statement2418);
                    	        	forStatement167 = forStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatement167.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:487:24: pForStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForStatement_in_statement2422);
                    	        	pForStatement168 = pForStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForStatement168.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:488:9: ( forEachStatement | pForEachStatement )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:488:9: ( forEachStatement | pForEachStatement )
                    	int alt43 = 2;
                    	int LA43_0 = input.LA(1);

                    	if ( (LA43_0 == ForEach) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == PForEach) )
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
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:488:11: forEachStatement
                    	        {
                    	        	PushFollow(FOLLOW_forEachStatement_in_statement2436);
                    	        	forEachStatement169 = forEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachStatement169.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:488:30: pForEachStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForEachStatement_in_statement2440);
                    	        	pForEachStatement170 = pForEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForEachStatement170.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:489:9: loopStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_loopStatement_in_statement2452);
                    	loopStatement171 = loopStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopStatement171.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:490:9: whileStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileStatement_in_statement2462);
                    	whileStatement172 = whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileStatement172.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:491:9: doStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doStatement_in_statement2472);
                    	doStatement173 = doStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, doStatement173.Tree);

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:492:9: PDo block
                    {
                    	PDo174=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement2485); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_PDo.Add(PDo174);

                    	PushFollow(FOLLOW_block_in_statement2487);
                    	block175 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block175.Tree);


                    	// AST REWRITE
                    	// elements:          block
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 492:19: -> ^( PDOSTATEMENT block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:492:22: ^( PDOSTATEMENT block )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:493:9: Async block
                    {
                    	Async176=(IToken)Match(input,Async,FOLLOW_Async_in_statement2516); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Async.Add(Async176);

                    	PushFollow(FOLLOW_block_in_statement2518);
                    	block177 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block177.Tree);


                    	// AST REWRITE
                    	// elements:          block
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 493:21: -> ^( ASYNCSTATEMENT block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:493:24: ^( ASYNCSTATEMENT block )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:494:9: Lock '(' Identifier ')' block
                    {
                    	Lock178=(IToken)Match(input,Lock,FOLLOW_Lock_in_statement2546); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Lock.Add(Lock178);

                    	char_literal179=(IToken)Match(input,143,FOLLOW_143_in_statement2548); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_143.Add(char_literal179);

                    	Identifier180=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_statement2550); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier180);

                    	char_literal181=(IToken)Match(input,144,FOLLOW_144_in_statement2552); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_144.Add(char_literal181);

                    	PushFollow(FOLLOW_block_in_statement2554);
                    	block182 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block182.Tree);


                    	// AST REWRITE
                    	// elements:          Identifier, block
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 494:39: -> ^( LOCKSTATEMENT Identifier block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:494:42: ^( LOCKSTATEMENT Identifier block )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:495:9: Return ( expression )? ';'
                    {
                    	Return183=(IToken)Match(input,Return,FOLLOW_Return_in_statement2577); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Return.Add(Return183);

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:495:16: ( expression )?
                    	int alt44 = 2;
                    	int LA44_0 = input.LA(1);

                    	if ( (LA44_0 == StringLiteral || LA44_0 == Identifier || LA44_0 == IntegerLiteral || LA44_0 == Minus || (LA44_0 >= LogicalNot && LA44_0 <= InfinityLiteral) || LA44_0 == 143) )
                    	{
                    	    alt44 = 1;
                    	}
                    	switch (alt44) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement2579);
                    	        	expression184 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) stream_expression.Add(expression184.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal185=(IToken)Match(input,137,FOLLOW_137_in_statement2582); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_137.Add(char_literal185);



                    	// AST REWRITE
                    	// elements:          expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 495:32: -> ^( RETURN ( expression )? )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:495:35: ^( RETURN ( expression )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RETURN, "RETURN"), root_1);

                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:495:45: ( expression )?
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:496:9: Break ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Break186=(IToken)Match(input,Break,FOLLOW_Break_in_statement2603); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break186_tree = (CommonTree)adaptor.Create(Break186);
                    		adaptor.AddChild(root_0, Break186_tree);
                    	}
                    	char_literal187=(IToken)Match(input,137,FOLLOW_137_in_statement2605); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:498:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal188=(IToken)Match(input,137,FOLLOW_137_in_statement2617); if (state.failed) return retval;

                    }
                    break;
                case 13 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:499:9: expression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_statement2628);
                    	expression189 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression189.Tree);
                    	char_literal190=(IToken)Match(input,137,FOLLOW_137_in_statement2630); if (state.failed) return retval;

                    }
                    break;
                case 14 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:500:7: localVariableDeclaration ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_localVariableDeclaration_in_statement2639);
                    	localVariableDeclaration191 = localVariableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration191.Tree);
                    	char_literal192=(IToken)Match(input,137,FOLLOW_137_in_statement2641); if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 69, statement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statement"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:1: ifStatement : ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? ) ;
    public PsimulexParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.ifStatement_return retval = new PsimulexParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.ifBranch_return ifBranch193 = default(PsimulexParser.ifBranch_return);

        PsimulexParser.elseIfBranches_return elseIfBranches194 = default(PsimulexParser.elseIfBranches_return);

        PsimulexParser.elseBranch_return elseBranch195 = default(PsimulexParser.elseBranch_return);

        PsimulexParser.elseBranch_return elseBranch196 = default(PsimulexParser.elseBranch_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 70) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:15: ( ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:17: ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_ifBranch_in_ifStatement2661);
            	ifBranch193 = ifBranch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifBranch193.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:26: ( ( elseIfBranches elseBranch ) | ( elseBranch )? )
            	int alt47 = 2;
            	switch ( input.LA(1) ) 
            	{
            	case ElseIf:
            		{
            	    int LA47_1 = input.LA(2);

            	    if ( (synpred103_Psimulex()) )
            	    {
            	        alt47 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt47 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d47s1 =
            	            new NoViableAltException("", 47, 1, input);

            	        throw nvae_d47s1;
            	    }
            	    }
            	    break;
            	case Else:
            		{
            	    int LA47_2 = input.LA(2);

            	    if ( (synpred103_Psimulex()) )
            	    {
            	        alt47 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt47 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d47s2 =
            	            new NoViableAltException("", 47, 2, input);

            	        throw nvae_d47s2;
            	    }
            	    }
            	    break;
            	case EOF:
            	case StringLiteral:
            	case Identifier:
            	case IntegerLiteral:
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
            	case Thread:
            	case Timer:
            	case Graph:
            	case Node:
            	case Edge:
            	case Minus:
            	case LogicalNot:
            	case PlusPlus:
            	case MinusMinus:
            	case DecimalLiteral:
            	case CharacterLiteral:
            	case BooleanLiteral:
            	case NullLiteral:
            	case InfinityLiteral:
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
            	case 137:
            	case 139:
            	case 143:
            		{
            	    alt47 = 2;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d47s0 =
            		        new NoViableAltException("", 47, 0, input);

            		    throw nvae_d47s0;
            	}

            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:28: ( elseIfBranches elseBranch )
            	        {
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:28: ( elseIfBranches elseBranch )
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:30: elseIfBranches elseBranch
            	        	{
            	        		PushFollow(FOLLOW_elseIfBranches_in_ifStatement2667);
            	        		elseIfBranches194 = elseIfBranches();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseIfBranches194.Tree);
            	        		PushFollow(FOLLOW_elseBranch_in_ifStatement2669);
            	        		elseBranch195 = elseBranch();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch195.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:60: ( elseBranch )?
            	        {
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:60: ( elseBranch )?
            	        	int alt46 = 2;
            	        	int LA46_0 = input.LA(1);

            	        	if ( (LA46_0 == Else) )
            	        	{
            	        	    int LA46_1 = input.LA(2);

            	        	    if ( (synpred104_Psimulex()) )
            	        	    {
            	        	        alt46 = 1;
            	        	    }
            	        	}
            	        	switch (alt46) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: elseBranch
            	        	        {
            	        	        	PushFollow(FOLLOW_elseBranch_in_ifStatement2675);
            	        	        	elseBranch196 = elseBranch();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch196.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 70, ifStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:504:1: ifBranch : If condition core -> ^( IFBRANCH condition core ) ;
    public PsimulexParser.ifBranch_return ifBranch() // throws RecognitionException [1]
    {   
        PsimulexParser.ifBranch_return retval = new PsimulexParser.ifBranch_return();
        retval.Start = input.LT(1);
        int ifBranch_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken If197 = null;
        PsimulexParser.condition_return condition198 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core199 = default(PsimulexParser.core_return);


        CommonTree If197_tree=null;
        RewriteRuleTokenStream stream_If = new RewriteRuleTokenStream(adaptor,"token If");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 71) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:504:12: ( If condition core -> ^( IFBRANCH condition core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:504:14: If condition core
            {
            	If197=(IToken)Match(input,If,FOLLOW_If_in_ifBranch2687); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_If.Add(If197);

            	PushFollow(FOLLOW_condition_in_ifBranch2689);
            	condition198 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition198.Tree);
            	PushFollow(FOLLOW_core_in_ifBranch2691);
            	core199 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core199.Tree);


            	// AST REWRITE
            	// elements:          condition, core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 504:32: -> ^( IFBRANCH condition core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:504:35: ^( IFBRANCH condition core )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IFBRANCH, "IFBRANCH"), root_1);

            	    adaptor.AddChild(root_1, stream_condition.NextTree());
            	    adaptor.AddChild(root_1, stream_core.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 71, ifBranch_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:1: elseIfBranches : ( ElseIf condition core )* -> ^( ELSEIFBRANCH ( condition core )* ) ;
    public PsimulexParser.elseIfBranches_return elseIfBranches() // throws RecognitionException [1]
    {   
        PsimulexParser.elseIfBranches_return retval = new PsimulexParser.elseIfBranches_return();
        retval.Start = input.LT(1);
        int elseIfBranches_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken ElseIf200 = null;
        PsimulexParser.condition_return condition201 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core202 = default(PsimulexParser.core_return);


        CommonTree ElseIf200_tree=null;
        RewriteRuleTokenStream stream_ElseIf = new RewriteRuleTokenStream(adaptor,"token ElseIf");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 72) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:17: ( ( ElseIf condition core )* -> ^( ELSEIFBRANCH ( condition core )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:19: ( ElseIf condition core )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:19: ( ElseIf condition core )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( (LA48_0 == ElseIf) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:21: ElseIf condition core
            			    {
            			    	ElseIf200=(IToken)Match(input,ElseIf,FOLLOW_ElseIf_in_elseIfBranches2712); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_ElseIf.Add(ElseIf200);

            			    	PushFollow(FOLLOW_condition_in_elseIfBranches2714);
            			    	condition201 = condition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_condition.Add(condition201.Tree);
            			    	PushFollow(FOLLOW_core_in_elseIfBranches2716);
            			    	core202 = core();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_core.Add(core202.Tree);

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements



            	// AST REWRITE
            	// elements:          core, condition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 505:46: -> ^( ELSEIFBRANCH ( condition core )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:49: ^( ELSEIFBRANCH ( condition core )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ELSEIFBRANCH, "ELSEIFBRANCH"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:505:65: ( condition core )*
            	    while ( stream_core.HasNext() || stream_condition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_condition.NextTree());
            	        adaptor.AddChild(root_1, stream_core.NextTree());

            	    }
            	    stream_core.Reset();
            	    stream_condition.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 72, elseIfBranches_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:1: elseBranch : Else core -> ^( ELSEBRANCH core ) ;
    public PsimulexParser.elseBranch_return elseBranch() // throws RecognitionException [1]
    {   
        PsimulexParser.elseBranch_return retval = new PsimulexParser.elseBranch_return();
        retval.Start = input.LT(1);
        int elseBranch_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Else203 = null;
        PsimulexParser.core_return core204 = default(PsimulexParser.core_return);


        CommonTree Else203_tree=null;
        RewriteRuleTokenStream stream_Else = new RewriteRuleTokenStream(adaptor,"token Else");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 73) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:14: ( Else core -> ^( ELSEBRANCH core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:16: Else core
            {
            	Else203=(IToken)Match(input,Else,FOLLOW_Else_in_elseBranch2745); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Else.Add(Else203);

            	PushFollow(FOLLOW_core_in_elseBranch2747);
            	core204 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core204.Tree);


            	// AST REWRITE
            	// elements:          core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 506:26: -> ^( ELSEBRANCH core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:29: ^( ELSEBRANCH core )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 73, elseBranch_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:1: forStatement : For '(' forControl ')' core -> ^( FORSTATEMENT forControl core ) ;
    public PsimulexParser.forStatement_return forStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.forStatement_return retval = new PsimulexParser.forStatement_return();
        retval.Start = input.LT(1);
        int forStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken For205 = null;
        IToken char_literal206 = null;
        IToken char_literal208 = null;
        PsimulexParser.forControl_return forControl207 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core209 = default(PsimulexParser.core_return);


        CommonTree For205_tree=null;
        CommonTree char_literal206_tree=null;
        CommonTree char_literal208_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_For = new RewriteRuleTokenStream(adaptor,"token For");
        RewriteRuleSubtreeStream stream_forControl = new RewriteRuleSubtreeStream(adaptor,"rule forControl");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 74) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:15: ( For '(' forControl ')' core -> ^( FORSTATEMENT forControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:17: For '(' forControl ')' core
            {
            	For205=(IToken)Match(input,For,FOLLOW_For_in_forStatement2765); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_For.Add(For205);

            	char_literal206=(IToken)Match(input,143,FOLLOW_143_in_forStatement2767); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_143.Add(char_literal206);

            	PushFollow(FOLLOW_forControl_in_forStatement2769);
            	forControl207 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forControl.Add(forControl207.Tree);
            	char_literal208=(IToken)Match(input,144,FOLLOW_144_in_forStatement2771); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_144.Add(char_literal208);

            	PushFollow(FOLLOW_core_in_forStatement2773);
            	core209 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core209.Tree);


            	// AST REWRITE
            	// elements:          core, forControl
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 508:45: -> ^( FORSTATEMENT forControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:48: ^( FORSTATEMENT forControl core )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 74, forStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:1: pForStatement : PFor '(' forControl ')' core -> ^( PFORSTATEMENT forControl core ) ;
    public PsimulexParser.pForStatement_return pForStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.pForStatement_return retval = new PsimulexParser.pForStatement_return();
        retval.Start = input.LT(1);
        int pForStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PFor210 = null;
        IToken char_literal211 = null;
        IToken char_literal213 = null;
        PsimulexParser.forControl_return forControl212 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core214 = default(PsimulexParser.core_return);


        CommonTree PFor210_tree=null;
        CommonTree char_literal211_tree=null;
        CommonTree char_literal213_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_PFor = new RewriteRuleTokenStream(adaptor,"token PFor");
        RewriteRuleSubtreeStream stream_forControl = new RewriteRuleSubtreeStream(adaptor,"rule forControl");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 75) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:16: ( PFor '(' forControl ')' core -> ^( PFORSTATEMENT forControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:18: PFor '(' forControl ')' core
            {
            	PFor210=(IToken)Match(input,PFor,FOLLOW_PFor_in_pForStatement2793); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_PFor.Add(PFor210);

            	char_literal211=(IToken)Match(input,143,FOLLOW_143_in_pForStatement2795); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_143.Add(char_literal211);

            	PushFollow(FOLLOW_forControl_in_pForStatement2797);
            	forControl212 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forControl.Add(forControl212.Tree);
            	char_literal213=(IToken)Match(input,144,FOLLOW_144_in_pForStatement2799); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_144.Add(char_literal213);

            	PushFollow(FOLLOW_core_in_pForStatement2801);
            	core214 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core214.Tree);


            	// AST REWRITE
            	// elements:          forControl, core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 509:47: -> ^( PFORSTATEMENT forControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:50: ^( PFORSTATEMENT forControl core )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 75, pForStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:1: forControl : ( forInit )? ';' ( forCondition )? ';' ( forUpdate )? -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? ) ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal216 = null;
        IToken char_literal218 = null;
        PsimulexParser.forInit_return forInit215 = default(PsimulexParser.forInit_return);

        PsimulexParser.forCondition_return forCondition217 = default(PsimulexParser.forCondition_return);

        PsimulexParser.forUpdate_return forUpdate219 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal216_tree=null;
        CommonTree char_literal218_tree=null;
        RewriteRuleTokenStream stream_137 = new RewriteRuleTokenStream(adaptor,"token 137");
        RewriteRuleSubtreeStream stream_forCondition = new RewriteRuleSubtreeStream(adaptor,"rule forCondition");
        RewriteRuleSubtreeStream stream_forInit = new RewriteRuleSubtreeStream(adaptor,"rule forInit");
        RewriteRuleSubtreeStream stream_forUpdate = new RewriteRuleSubtreeStream(adaptor,"rule forUpdate");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 76) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:14: ( ( forInit )? ';' ( forCondition )? ';' ( forUpdate )? -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:16: ( forInit )? ';' ( forCondition )? ';' ( forUpdate )?
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:16: ( forInit )?
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == Identifier || (LA49_0 >= Bool && LA49_0 <= Edge)) )
            	{
            	    alt49 = 1;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl2822);
            	        	forInit215 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forInit.Add(forInit215.Tree);

            	        }
            	        break;

            	}

            	char_literal216=(IToken)Match(input,137,FOLLOW_137_in_forControl2825); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_137.Add(char_literal216);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:29: ( forCondition )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == StringLiteral || LA50_0 == Identifier || LA50_0 == IntegerLiteral || LA50_0 == Minus || (LA50_0 >= LogicalNot && LA50_0 <= InfinityLiteral) || LA50_0 == 143) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forCondition
            	        {
            	        	PushFollow(FOLLOW_forCondition_in_forControl2827);
            	        	forCondition217 = forCondition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forCondition.Add(forCondition217.Tree);

            	        }
            	        break;

            	}

            	char_literal218=(IToken)Match(input,137,FOLLOW_137_in_forControl2830); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_137.Add(char_literal218);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:47: ( forUpdate )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == StringLiteral || LA51_0 == Identifier || LA51_0 == IntegerLiteral || LA51_0 == Minus || (LA51_0 >= LogicalNot && LA51_0 <= InfinityLiteral) || LA51_0 == 143) )
            	{
            	    alt51 = 1;
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl2832);
            	        	forUpdate219 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forUpdate.Add(forUpdate219.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          forUpdate, forInit, forCondition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 510:58: -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:61: ^( FORINIT ( forInit )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORINIT, "FORINIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:72: ( forInit )?
            	    if ( stream_forInit.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_forInit.NextTree());

            	    }
            	    stream_forInit.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:83: ^( FORCONDITION ( forCondition )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORCONDITION, "FORCONDITION"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:99: ( forCondition )?
            	    if ( stream_forCondition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_forCondition.NextTree());

            	    }
            	    stream_forCondition.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:115: ^( FORUPDATE ( forUpdate )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORUPDATE, "FORUPDATE"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:128: ( forUpdate )?
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 76, forControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:511:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration220 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 77) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:511:12: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:511:16: localVariableDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit2874);
            	localVariableDeclaration220 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration220.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 77, forInit_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:1: forCondition : expression ;
    public PsimulexParser.forCondition_return forCondition() // throws RecognitionException [1]
    {   
        PsimulexParser.forCondition_return retval = new PsimulexParser.forCondition_return();
        retval.Start = input.LT(1);
        int forCondition_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression221 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 78) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:15: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:19: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forCondition2884);
            	expression221 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression221.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 78, forCondition_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression222 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 79) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:13: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:17: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate2895);
            	expression222 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression222.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 79, forUpdate_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:1: whileStatement : While condition core -> ^( WHILESTATEMENT condition core ) ;
    public PsimulexParser.whileStatement_return whileStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.whileStatement_return retval = new PsimulexParser.whileStatement_return();
        retval.Start = input.LT(1);
        int whileStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken While223 = null;
        PsimulexParser.condition_return condition224 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core225 = default(PsimulexParser.core_return);


        CommonTree While223_tree=null;
        RewriteRuleTokenStream stream_While = new RewriteRuleTokenStream(adaptor,"token While");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 80) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:17: ( While condition core -> ^( WHILESTATEMENT condition core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:19: While condition core
            {
            	While223=(IToken)Match(input,While,FOLLOW_While_in_whileStatement2904); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_While.Add(While223);

            	PushFollow(FOLLOW_condition_in_whileStatement2906);
            	condition224 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition224.Tree);
            	PushFollow(FOLLOW_core_in_whileStatement2908);
            	core225 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core225.Tree);


            	// AST REWRITE
            	// elements:          core, condition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 515:40: -> ^( WHILESTATEMENT condition core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:43: ^( WHILESTATEMENT condition core )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 80, whileStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:1: doStatement : Do core While condition ';' -> ^( DOSTATEMENT core condition ) ;
    public PsimulexParser.doStatement_return doStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.doStatement_return retval = new PsimulexParser.doStatement_return();
        retval.Start = input.LT(1);
        int doStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Do226 = null;
        IToken While228 = null;
        IToken char_literal230 = null;
        PsimulexParser.core_return core227 = default(PsimulexParser.core_return);

        PsimulexParser.condition_return condition229 = default(PsimulexParser.condition_return);


        CommonTree Do226_tree=null;
        CommonTree While228_tree=null;
        CommonTree char_literal230_tree=null;
        RewriteRuleTokenStream stream_Do = new RewriteRuleTokenStream(adaptor,"token Do");
        RewriteRuleTokenStream stream_While = new RewriteRuleTokenStream(adaptor,"token While");
        RewriteRuleTokenStream stream_137 = new RewriteRuleTokenStream(adaptor,"token 137");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 81) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:15: ( Do core While condition ';' -> ^( DOSTATEMENT core condition ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:17: Do core While condition ';'
            {
            	Do226=(IToken)Match(input,Do,FOLLOW_Do_in_doStatement2930); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Do.Add(Do226);

            	PushFollow(FOLLOW_core_in_doStatement2932);
            	core227 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core227.Tree);
            	While228=(IToken)Match(input,While,FOLLOW_While_in_doStatement2934); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_While.Add(While228);

            	PushFollow(FOLLOW_condition_in_doStatement2936);
            	condition229 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition229.Tree);
            	char_literal230=(IToken)Match(input,137,FOLLOW_137_in_doStatement2938); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_137.Add(char_literal230);



            	// AST REWRITE
            	// elements:          core, condition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 517:45: -> ^( DOSTATEMENT core condition )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:48: ^( DOSTATEMENT core condition )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 81, doStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:1: pForEachStatement : PForEach forEachTrailer -> ^( PFOREACHSTATEMENT forEachTrailer ) ;
    public PsimulexParser.pForEachStatement_return pForEachStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.pForEachStatement_return retval = new PsimulexParser.pForEachStatement_return();
        retval.Start = input.LT(1);
        int pForEachStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PForEach231 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer232 = default(PsimulexParser.forEachTrailer_return);


        CommonTree PForEach231_tree=null;
        RewriteRuleTokenStream stream_PForEach = new RewriteRuleTokenStream(adaptor,"token PForEach");
        RewriteRuleSubtreeStream stream_forEachTrailer = new RewriteRuleSubtreeStream(adaptor,"rule forEachTrailer");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 82) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:19: ( PForEach forEachTrailer -> ^( PFOREACHSTATEMENT forEachTrailer ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:21: PForEach forEachTrailer
            {
            	PForEach231=(IToken)Match(input,PForEach,FOLLOW_PForEach_in_pForEachStatement2958); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_PForEach.Add(PForEach231);

            	PushFollow(FOLLOW_forEachTrailer_in_pForEachStatement2960);
            	forEachTrailer232 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forEachTrailer.Add(forEachTrailer232.Tree);


            	// AST REWRITE
            	// elements:          forEachTrailer
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 519:45: -> ^( PFOREACHSTATEMENT forEachTrailer )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:48: ^( PFOREACHSTATEMENT forEachTrailer )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 82, pForEachStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:520:1: forEachStatement : ForEach forEachTrailer -> ^( FOREACHSTATEMENT forEachTrailer ) ;
    public PsimulexParser.forEachStatement_return forEachStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachStatement_return retval = new PsimulexParser.forEachStatement_return();
        retval.Start = input.LT(1);
        int forEachStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken ForEach233 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer234 = default(PsimulexParser.forEachTrailer_return);


        CommonTree ForEach233_tree=null;
        RewriteRuleTokenStream stream_ForEach = new RewriteRuleTokenStream(adaptor,"token ForEach");
        RewriteRuleSubtreeStream stream_forEachTrailer = new RewriteRuleSubtreeStream(adaptor,"rule forEachTrailer");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 83) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:520:18: ( ForEach forEachTrailer -> ^( FOREACHSTATEMENT forEachTrailer ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:520:20: ForEach forEachTrailer
            {
            	ForEach233=(IToken)Match(input,ForEach,FOLLOW_ForEach_in_forEachStatement2977); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_ForEach.Add(ForEach233);

            	PushFollow(FOLLOW_forEachTrailer_in_forEachStatement2979);
            	forEachTrailer234 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forEachTrailer.Add(forEachTrailer234.Tree);


            	// AST REWRITE
            	// elements:          forEachTrailer
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 520:43: -> ^( FOREACHSTATEMENT forEachTrailer )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:520:46: ^( FOREACHSTATEMENT forEachTrailer )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 83, forEachStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:521:1: forEachTrailer : '(' forEachControl ')' core ;
    public PsimulexParser.forEachTrailer_return forEachTrailer() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachTrailer_return retval = new PsimulexParser.forEachTrailer_return();
        retval.Start = input.LT(1);
        int forEachTrailer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal235 = null;
        IToken char_literal237 = null;
        PsimulexParser.forEachControl_return forEachControl236 = default(PsimulexParser.forEachControl_return);

        PsimulexParser.core_return core238 = default(PsimulexParser.core_return);


        CommonTree char_literal235_tree=null;
        CommonTree char_literal237_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 84) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:521:17: ( '(' forEachControl ')' core )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:521:19: '(' forEachControl ')' core
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal235=(IToken)Match(input,143,FOLLOW_143_in_forEachTrailer2997); if (state.failed) return retval;
            	PushFollow(FOLLOW_forEachControl_in_forEachTrailer3000);
            	forEachControl236 = forEachControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachControl236.Tree);
            	char_literal237=(IToken)Match(input,144,FOLLOW_144_in_forEachTrailer3002); if (state.failed) return retval;
            	PushFollow(FOLLOW_core_in_forEachTrailer3005);
            	core238 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, core238.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 84, forEachTrailer_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:522:1: forEachControl options {k=3; } : type Identifier In expression -> ^( FOREACHCONTROL type expression ) ;
    public PsimulexParser.forEachControl_return forEachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachControl_return retval = new PsimulexParser.forEachControl_return();
        retval.Start = input.LT(1);
        int forEachControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier240 = null;
        IToken In241 = null;
        PsimulexParser.type_return type239 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression242 = default(PsimulexParser.expression_return);


        CommonTree Identifier240_tree=null;
        CommonTree In241_tree=null;
        RewriteRuleTokenStream stream_In = new RewriteRuleTokenStream(adaptor,"token In");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 85) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:523:9: ( type Identifier In expression -> ^( FOREACHCONTROL type expression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:523:13: type Identifier In expression
            {
            	PushFollow(FOLLOW_type_in_forEachControl3034);
            	type239 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type239.Tree);
            	Identifier240=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_forEachControl3036); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier240);

            	In241=(IToken)Match(input,In,FOLLOW_In_in_forEachControl3038); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_In.Add(In241);

            	PushFollow(FOLLOW_expression_in_forEachControl3040);
            	expression242 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression242.Tree);


            	// AST REWRITE
            	// elements:          expression, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 523:43: -> ^( FOREACHCONTROL type expression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:523:46: ^( FOREACHCONTROL type expression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FOREACHCONTROL, "FOREACHCONTROL"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 85, forEachControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:525:1: loopStatement : Loop '(' loopControl ')' core -> ^( LOOPSTATEMENT loopControl core ) ;
    public PsimulexParser.loopStatement_return loopStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.loopStatement_return retval = new PsimulexParser.loopStatement_return();
        retval.Start = input.LT(1);
        int loopStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Loop243 = null;
        IToken char_literal244 = null;
        IToken char_literal246 = null;
        PsimulexParser.loopControl_return loopControl245 = default(PsimulexParser.loopControl_return);

        PsimulexParser.core_return core247 = default(PsimulexParser.core_return);


        CommonTree Loop243_tree=null;
        CommonTree char_literal244_tree=null;
        CommonTree char_literal246_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleTokenStream stream_Loop = new RewriteRuleTokenStream(adaptor,"token Loop");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        RewriteRuleSubtreeStream stream_loopControl = new RewriteRuleSubtreeStream(adaptor,"rule loopControl");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 86) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:525:16: ( Loop '(' loopControl ')' core -> ^( LOOPSTATEMENT loopControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:525:18: Loop '(' loopControl ')' core
            {
            	Loop243=(IToken)Match(input,Loop,FOLLOW_Loop_in_loopStatement3061); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Loop.Add(Loop243);

            	char_literal244=(IToken)Match(input,143,FOLLOW_143_in_loopStatement3063); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_143.Add(char_literal244);

            	PushFollow(FOLLOW_loopControl_in_loopStatement3065);
            	loopControl245 = loopControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_loopControl.Add(loopControl245.Tree);
            	char_literal246=(IToken)Match(input,144,FOLLOW_144_in_loopStatement3067); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_144.Add(char_literal246);

            	PushFollow(FOLLOW_core_in_loopStatement3069);
            	core247 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core247.Tree);


            	// AST REWRITE
            	// elements:          core, loopControl
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 525:48: -> ^( LOOPSTATEMENT loopControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:525:51: ^( LOOPSTATEMENT loopControl core )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 86, loopStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:526:1: loopControl options {k=3; } : localVariableDeclaration To expression -> ^( LOOPCONTROL localVariableDeclaration expression ) ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken To249 = null;
        PsimulexParser.localVariableDeclaration_return localVariableDeclaration248 = default(PsimulexParser.localVariableDeclaration_return);

        PsimulexParser.expression_return expression250 = default(PsimulexParser.expression_return);


        CommonTree To249_tree=null;
        RewriteRuleTokenStream stream_To = new RewriteRuleTokenStream(adaptor,"token To");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_localVariableDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule localVariableDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 87) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:527:9: ( localVariableDeclaration To expression -> ^( LOOPCONTROL localVariableDeclaration expression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:527:13: localVariableDeclaration To expression
            {
            	PushFollow(FOLLOW_localVariableDeclaration_in_loopControl3110);
            	localVariableDeclaration248 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_localVariableDeclaration.Add(localVariableDeclaration248.Tree);
            	To249=(IToken)Match(input,To,FOLLOW_To_in_loopControl3112); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_To.Add(To249);

            	PushFollow(FOLLOW_expression_in_loopControl3114);
            	expression250 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression250.Tree);


            	// AST REWRITE
            	// elements:          localVariableDeclaration, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 527:52: -> ^( LOOPCONTROL localVariableDeclaration expression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:527:55: ^( LOOPCONTROL localVariableDeclaration expression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LOOPCONTROL, "LOOPCONTROL"), root_1);

            	    adaptor.AddChild(root_1, stream_localVariableDeclaration.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
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
            	Memoize(input, 87, loopControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:1: core : branch -> ^( CORE branch ) ;
    public PsimulexParser.core_return core() // throws RecognitionException [1]
    {   
        PsimulexParser.core_return retval = new PsimulexParser.core_return();
        retval.Start = input.LT(1);
        int core_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.branch_return branch251 = default(PsimulexParser.branch_return);


        RewriteRuleSubtreeStream stream_branch = new RewriteRuleSubtreeStream(adaptor,"rule branch");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 88) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:9: ( branch -> ^( CORE branch ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:11: branch
            {
            	PushFollow(FOLLOW_branch_in_core3137);
            	branch251 = branch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_branch.Add(branch251.Tree);


            	// AST REWRITE
            	// elements:          branch
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 529:18: -> ^( CORE branch )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:21: ^( CORE branch )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 88, core_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:1: condition : parExpression -> ^( CONDITION parExpression ) ;
    public PsimulexParser.condition_return condition() // throws RecognitionException [1]
    {   
        PsimulexParser.condition_return retval = new PsimulexParser.condition_return();
        retval.Start = input.LT(1);
        int condition_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression252 = default(PsimulexParser.parExpression_return);


        RewriteRuleSubtreeStream stream_parExpression = new RewriteRuleSubtreeStream(adaptor,"rule parExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 89) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:13: ( parExpression -> ^( CONDITION parExpression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:15: parExpression
            {
            	PushFollow(FOLLOW_parExpression_in_condition3156);
            	parExpression252 = parExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_parExpression.Add(parExpression252.Tree);


            	// AST REWRITE
            	// elements:          parExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 530:29: -> ^( CONDITION parExpression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:32: ^( CONDITION parExpression )
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

            if ( state.backtracking==0 )
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
            	Memoize(input, 89, condition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "condition"

    // $ANTLR start "synpred1_Psimulex"
    public void synpred1_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:9: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:9: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex329);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred2_Psimulex"
    public void synpred2_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:25: ( multiFunctionalProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:25: multiFunctionalProgram
        {
        	PushFollow(FOLLOW_multiFunctionalProgram_in_synpred2_Psimulex333);
        	multiFunctionalProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_Psimulex"

    // $ANTLR start "synpred9_Psimulex"
    public void synpred9_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:9: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:9: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex642);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Psimulex"

    // $ANTLR start "synpred10_Psimulex"
    public void synpred10_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:9: ( typedIdentifierNonRef Assign variableInitializer )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:9: typedIdentifierNonRef Assign variableInitializer
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred10_Psimulex660);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Assign,FOLLOW_Assign_in_synpred10_Psimulex662); if (state.failed) return ;
        	PushFollow(FOLLOW_variableInitializer_in_synpred10_Psimulex664);
        	variableInitializer();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_Psimulex"

    // $ANTLR start "synpred19_Psimulex"
    public void synpred19_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:4: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:4: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred19_Psimulex983);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_Psimulex"

    // $ANTLR start "synpred41_Psimulex"
    public void synpred41_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred41_Psimulex1404);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred41_Psimulex"

    // $ANTLR start "synpred61_Psimulex"
    public void synpred61_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:7: ( unaryPostfixExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:7: unaryPostfixExpression
        {
        	PushFollow(FOLLOW_unaryPostfixExpression_in_synpred61_Psimulex1719);
        	unaryPostfixExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred61_Psimulex"

    // $ANTLR start "synpred63_Psimulex"
    public void synpred63_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:4: ( leftValueExpression ( unaryPostfixOp )? )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:4: leftValueExpression ( unaryPostfixOp )?
        {
        	PushFollow(FOLLOW_leftValueExpression_in_synpred63_Psimulex1770);
        	leftValueExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:24: ( unaryPostfixOp )?
        	int alt53 = 2;
        	int LA53_0 = input.LA(1);

        	if ( ((LA53_0 >= PlusPlus && LA53_0 <= MinusMinus)) )
        	{
        	    alt53 = 1;
        	}
        	switch (alt53) 
        	{
        	    case 1 :
        	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:25: unaryPostfixOp
        	        {
        	        	PushFollow(FOLLOW_unaryPostfixOp_in_synpred63_Psimulex1773);
        	        	unaryPostfixOp();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred63_Psimulex"

    // $ANTLR start "synpred68_Psimulex"
    public void synpred68_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:381:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:381:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred68_Psimulex1905);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred68_Psimulex"

    // $ANTLR start "synpred69_Psimulex"
    public void synpred69_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred69_Psimulex1913);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred69_Psimulex"

    // $ANTLR start "synpred102_Psimulex"
    public void synpred102_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:499:9: ( expression ';' )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:499:9: expression ';'
        {
        	PushFollow(FOLLOW_expression_in_synpred102_Psimulex2628);
        	expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,137,FOLLOW_137_in_synpred102_Psimulex2630); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred102_Psimulex"

    // $ANTLR start "synpred103_Psimulex"
    public void synpred103_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:28: ( ( elseIfBranches elseBranch ) )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:28: ( elseIfBranches elseBranch )
        {
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:28: ( elseIfBranches elseBranch )
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:30: elseIfBranches elseBranch
        	{
        		PushFollow(FOLLOW_elseIfBranches_in_synpred103_Psimulex2667);
        		elseIfBranches();
        		state.followingStackPointer--;
        		if (state.failed) return ;
        		PushFollow(FOLLOW_elseBranch_in_synpred103_Psimulex2669);
        		elseBranch();
        		state.followingStackPointer--;
        		if (state.failed) return ;

        	}


        }
    }
    // $ANTLR end "synpred103_Psimulex"

    // $ANTLR start "synpred104_Psimulex"
    public void synpred104_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:60: ( elseBranch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:60: elseBranch
        {
        	PushFollow(FOLLOW_elseBranch_in_synpred104_Psimulex2675);
        	elseBranch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred104_Psimulex"

    // Delegated rules

   	public bool synpred9_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred41_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred41_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred2_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred102_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred102_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred68_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred68_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred19_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred19_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred69_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred69_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred103_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred103_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred104_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred104_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred10_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_Psimulex_fragment(); // can never throw exception
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


   	protected DFA1 dfa1;
   	protected DFA3 dfa3;
   	protected DFA8 dfa8;
   	protected DFA45 dfa45;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa3 = new DFA3(this);
    	this.dfa8 = new DFA8(this);
    	this.dfa45 = new DFA45(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);

	    this.dfa8.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA8_SpecialStateTransition);
	    this.dfa45.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA45_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x1a\uffff";
    const string DFA1_eofS =
        "\x01\x16\x19\uffff";
    const string DFA1_minS =
        "\x01\x3a\x0e\uffff\x01\x00\x04\uffff\x03\x00\x03\uffff";
    const string DFA1_maxS =
        "\x01\u008f\x0e\uffff\x01\x00\x04\uffff\x03\x00\x03\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x15\uffff\x01\x02\x01\uffff\x01\x03";
    const string DFA1_specialS =
        "\x0f\uffff\x01\x00\x04\uffff\x01\x01\x01\x02\x01\x03\x03\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x17\x01\x01\x01\x17\x01\x0f\x01\uffff\x01\x01\x01\uffff"+
            "\x06\x14\x0c\x15\x0e\uffff\x01\x01\x03\uffff\x0e\x01\x02\uffff"+
            "\x06\x01\x01\uffff\x01\x01\x0c\uffff\x01\x01\x05\uffff\x01\x01",
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
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            ""
    };

    static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
    static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
    static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
    static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
    static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
    static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
    static readonly short[][] DFA1_transition = DFA.UnpackEncodedStringArray(DFA1_transitionS);

    protected class DFA1 : DFA
    {
        public DFA1(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 1;
            this.eot = DFA1_eot;
            this.eof = DFA1_eof;
            this.min = DFA1_min;
            this.max = DFA1_max;
            this.accept = DFA1_accept;
            this.special = DFA1_special;
            this.transition = DFA1_transition;

        }

        override public string Description
        {
            get { return "93:7: ( simpleProgram | multiFunctionalProgram )?"; }
        }

    }


    protected internal int DFA1_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA1_15 = input.LA(1);

                   	 
                   	int index1_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 23; }

                   	 
                   	input.Seek(index1_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_20 = input.LA(1);

                   	 
                   	int index1_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 23; }

                   	 
                   	input.Seek(index1_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_21 = input.LA(1);

                   	 
                   	int index1_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 23; }

                   	 
                   	input.Seek(index1_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA1_22 = input.LA(1);

                   	 
                   	int index1_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 23; }

                   	else if ( (true) ) { s = 25; }

                   	 
                   	input.Seek(index1_22);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA3_eotS =
        "\x0c\uffff";
    const string DFA3_eofS =
        "\x01\x04\x0b\uffff";
    const string DFA3_minS =
        "\x04\x3d\x01\uffff\x01\x3b\x01\x3e\x01\x58\x01\uffff\x01\x3b\x01"+
        "\x3d\x01\x58";
    const string DFA3_maxS =
        "\x01\x52\x03\u008c\x01\uffff\x02\u008f\x01\u008e\x01\uffff\x01"+
        "\u008f\x01\x40\x01\u008e";
    const string DFA3_acceptS =
        "\x04\uffff\x01\x02\x03\uffff\x01\x01\x03\uffff";
    const string DFA3_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x01\x03\x03\uffff\x06\x01\x0c\x02",
            "\x01\x06\x02\uffff\x01\x04\x4b\uffff\x01\x05",
            "\x01\x06\x02\uffff\x01\x04\x4b\uffff\x01\x05",
            "\x01\x06\x02\uffff\x01\x04\x4b\uffff\x01\x05",
            "",
            "\x01\x04\x01\uffff\x01\x04\x01\uffff\x01\x07\x21\uffff\x01"+
            "\x04\x03\uffff\x08\x04\x20\uffff\x02\x08\x01\x04",
            "\x01\x08\x4a\uffff\x01\x08\x05\uffff\x01\x04",
            "\x0d\x04\x28\uffff\x01\x09\x01\x0a",
            "",
            "\x01\x04\x01\uffff\x01\x04\x01\uffff\x01\x0b\x21\uffff\x01"+
            "\x04\x03\uffff\x08\x04\x22\uffff\x01\x04",
            "\x01\x06\x02\uffff\x01\x04",
            "\x0d\x04\x28\uffff\x01\x09\x01\x0a"
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
            get { return "()* loopback of 106:4: ( memberDeclaration )*"; }
        }

    }

    const string DFA8_eotS =
        "\x29\uffff";
    const string DFA8_eofS =
        "\x05\uffff\x01\x13\x02\uffff\x01\x13\x02\uffff\x01\x13\x1d\uffff";
    const string DFA8_minS =
        "\x04\x3d\x01\x3b\x01\x3e\x01\uffff\x01\x3b\x01\x3e\x01\uffff\x01"+
        "\x3b\x01\x3e\x01\uffff\x06\x00\x03\uffff\x06\x00\x03\uffff\x06\x00"+
        "\x04\uffff";
    const string DFA8_maxS =
        "\x01\x52\x03\u008c\x01\u008f\x01\u0089\x01\uffff\x01\u008f\x01"+
        "\u0089\x01\uffff\x01\u008f\x01\u0089\x01\uffff\x06\x00\x03\uffff"+
        "\x06\x00\x03\uffff\x06\x00\x04\uffff";
    const string DFA8_acceptS =
        "\x06\uffff\x01\x03\x0c\uffff\x01\x01\x14\uffff\x01\x02";
    const string DFA8_specialS =
        "\x0d\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x03"+
        "\uffff\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x03\uffff"+
        "\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x03\x03\uffff\x06\x01\x0c\x02",
            "\x01\x05\x02\uffff\x01\x06\x4b\uffff\x01\x04",
            "\x01\x08\x02\uffff\x01\x06\x4b\uffff\x01\x07",
            "\x01\x0b\x02\uffff\x01\x06\x4b\uffff\x01\x0a",
            "\x01\x11\x01\uffff\x01\x0d\x01\uffff\x01\x11\x21\uffff\x01"+
            "\x0f\x03\uffff\x01\x0f\x02\x10\x05\x11\x22\uffff\x01\x0e",
            "\x01\x12\x3e\uffff\x01\x13\x0b\uffff\x01\x13",
            "",
            "\x01\x1a\x01\uffff\x01\x16\x01\uffff\x01\x1a\x21\uffff\x01"+
            "\x18\x03\uffff\x01\x18\x02\x19\x05\x1a\x22\uffff\x01\x17",
            "\x01\x1b\x3e\uffff\x01\x13\x0b\uffff\x01\x13",
            "",
            "\x01\x23\x01\uffff\x01\x1f\x01\uffff\x01\x23\x21\uffff\x01"+
            "\x21\x03\uffff\x01\x21\x02\x22\x05\x23\x22\uffff\x01\x20",
            "\x01\x24\x3e\uffff\x01\x13\x0b\uffff\x01\x13",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "142:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );"; }
        }

    }


    protected internal int DFA8_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA8_13 = input.LA(1);

                   	 
                   	int index8_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA8_14 = input.LA(1);

                   	 
                   	int index8_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA8_15 = input.LA(1);

                   	 
                   	int index8_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA8_16 = input.LA(1);

                   	 
                   	int index8_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA8_17 = input.LA(1);

                   	 
                   	int index8_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA8_18 = input.LA(1);

                   	 
                   	int index8_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA8_22 = input.LA(1);

                   	 
                   	int index8_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA8_23 = input.LA(1);

                   	 
                   	int index8_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA8_24 = input.LA(1);

                   	 
                   	int index8_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA8_25 = input.LA(1);

                   	 
                   	int index8_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA8_26 = input.LA(1);

                   	 
                   	int index8_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA8_27 = input.LA(1);

                   	 
                   	int index8_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA8_31 = input.LA(1);

                   	 
                   	int index8_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA8_32 = input.LA(1);

                   	 
                   	int index8_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA8_33 = input.LA(1);

                   	 
                   	int index8_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA8_34 = input.LA(1);

                   	 
                   	int index8_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA8_35 = input.LA(1);

                   	 
                   	int index8_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA8_36 = input.LA(1);

                   	 
                   	int index8_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Psimulex()) ) { s = 40; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index8_36);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 8, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA45_eotS =
        "\x16\uffff";
    const string DFA45_eofS =
        "\x16\uffff";
    const string DFA45_minS =
        "\x01\x3b\x0e\uffff\x01\x00\x06\uffff";
    const string DFA45_maxS =
        "\x01\u008f\x0e\uffff\x01\x00\x06\uffff";
    const string DFA45_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x03\x01\uffff\x01\x04"+
        "\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c"+
        "\x01\uffff\x01\x0d\x03\uffff\x01\x0e\x01\uffff";
    const string DFA45_specialS =
        "\x0f\uffff\x01\x00\x06\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x10\x01\uffff\x01\x0f\x01\uffff\x01\x10\x01\uffff\x12"+
            "\x14\x0e\uffff\x01\x10\x03\uffff\x08\x10\x01\x09\x01\x0a\x01"+
            "\x0b\x01\x0c\x01\x0d\x01\x01\x02\uffff\x02\x02\x01\x07\x01\x08"+
            "\x02\x04\x01\uffff\x01\x06\x0c\uffff\x01\x0e\x05\uffff\x01\x10",
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
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
    static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
    static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
    static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
    static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
    static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
    static readonly short[][] DFA45_transition = DFA.UnpackEncodedStringArray(DFA45_transitionS);

    protected class DFA45 : DFA
    {
        public DFA45(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 45;
            this.eot = DFA45_eot;
            this.eof = DFA45_eof;
            this.min = DFA45_min;
            this.max = DFA45_max;
            this.accept = DFA45_accept;
            this.special = DFA45_special;
            this.transition = DFA45_transition;

        }

        override public string Description
        {
            get { return "485:1: statement : ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN ( expression )? ) | Break ';' | ';' | expression ';' | localVariableDeclaration ';' );"; }
        }

    }


    protected internal int DFA45_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA45_15 = input.LA(1);

                   	 
                   	int index45_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred102_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 20; }

                   	 
                   	input.Seek(index45_15);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 45, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit329 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit333 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_simpleProgram353 = new BitSet(new ulong[]{0xA800000000000002UL,0x17E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_importDeclarations_in_multiFunctionalProgram382 = new BitSet(new ulong[]{0xB800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000009200UL});
    public static readonly BitSet FOLLOW_typeDeclarations_in_multiFunctionalProgram384 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000009200UL});
    public static readonly BitSet FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram386 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_functionDeclarations_in_multiFunctionalProgram388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclarations423 = new BitSet(new ulong[]{0xA800000000000002UL,0x17E7FFE20007FFFEUL,0x0000000000009200UL});
    public static readonly BitSet FOLLOW_Import_in_importDeclarations463 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclarations465 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_importDeclarations467 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclarations500 = new BitSet(new ulong[]{0x1000000000000002UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration531 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration533 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration535 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_138_in_structBody565 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000009A00UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBody568 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000009A00UL});
    public static readonly BitSet FOLLOW_139_in_structBody571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberTypedIdentifierNonRef_in_memberDeclaration592 = new BitSet(new ulong[]{0x4000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_Assign_in_memberDeclaration596 = new BitSet(new ulong[]{0x8800000000000000UL,0x00001F0000000000UL});
    public static readonly BitSet FOLLOW_literal_in_memberDeclaration598 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_memberDeclaration603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration660 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration662 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_localVariableDeclaration679 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration681 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInitializer716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_scalarOrArrayType736 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_staticArrayType_in_scalarOrArrayType738 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_staticArrayType_in_arrayType763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dynamicArrayType_in_arrayType767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_140_in_staticArrayType779 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_staticArrayType781 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_141_in_staticArrayType784 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_staticArrayType786 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_142_in_staticArrayType790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_140_in_dynamicArrayType818 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_141_in_dynamicArrayType822 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_142_in_dynamicArrayType827 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_memberScalarOrArrayType857 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_memberArrayType_in_memberScalarOrArrayType859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberStaticArrayType_in_memberArrayType884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dynamicArrayType_in_memberArrayType888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_140_in_memberStaticArrayType899 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_IntegerLiteral_in_memberStaticArrayType901 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_141_in_memberStaticArrayType904 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_IntegerLiteral_in_memberStaticArrayType906 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_142_in_memberStaticArrayType910 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberScalarOrArrayType_in_memberTypedIdentifierNonRef939 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberTypedIdentifierNonRef941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef952 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierNonRef954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierRef965 = new BitSet(new ulong[]{0x2000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_Reference_in_typedIdentifierRef967 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierRef970 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_typedIdentifier983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_typedIdentifier987 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_functionDeclarations1004 = new BitSet(new ulong[]{0xA800000000000002UL,0x17E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_functionDeclaration1037 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclaration1039 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration1042 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_formalParameterList1076 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000018200UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList1080 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_141_in_formalParameterList1083 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList1085 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_144_in_formalParameterList1092 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_formalParameter1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_type1165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataTypeName_in_dataType1184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataTypeName1205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataTypeName1209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedTypes_in_dataTypeName1213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_userDefinedTypes1225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exp_in_expression1382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_exp1404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_exp1408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment1421 = new BitSet(new ulong[]{0x4000000000000000UL,0x0000000000F80000UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment1423 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_exp_in_assignment1426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1467 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression1471 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1474 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1496 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression1500 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1503 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1525 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression1529 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1532 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000C000000UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1567 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000F0000000UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression1571 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1574 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000F0000000UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1627 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000300000000UL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression1631 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1634 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000300000000UL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1669 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001C00000000UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression1673 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1676 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001C00000000UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixExpression_in_unaryExpression1711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_unaryExpression1719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpression1724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1738 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryPrefixExpression1740 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_unaryPostfixExpression1770 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000C000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryPostfixExpression1781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_leftValueExpression1792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1797 = new BitSet(new ulong[]{0x2000000000000000UL,0x000000C000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_leftValueExpression1799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_castExpression1830 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000018200UL});
    public static readonly BitSet FOLLOW_dataType_in_castExpression1832 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_castExpression1834 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1836 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixAssignerOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1913 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_primaryExpression1931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_parExpression1950 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1953 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_parExpression1955 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1970 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1975 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1986 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selector2025 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000021000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selector2029 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000021000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector2034 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000021000UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector2038 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000021000UL});
    public static readonly BitSet FOLLOW_indexing_in_selector2042 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000021000UL});
    public static readonly BitSet FOLLOW_145_in_memberSelect2058 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect2060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_memberFunctionCall2081 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall2083 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall2085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall2108 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_arguments_in_functionCall2110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_140_in_indexing2134 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing2136 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_141_in_indexing2140 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing2142 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000006000UL});
    public static readonly BitSet FOLLOW_142_in_indexing2147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_arguments2181 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000018000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments2185 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_141_in_arguments2188 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments2190 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_144_in_arguments2197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_138_in_block2330 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008A00UL});
    public static readonly BitSet FOLLOW_statement_in_block2332 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008A00UL});
    public static readonly BitSet FOLLOW_139_in_block2335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch2377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_branch2381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement2398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_statement2418 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForStatement_in_statement2422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forEachStatement_in_statement2436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForEachStatement_in_statement2440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_loopStatement_in_statement2452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_statement2462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doStatement_in_statement2472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement2485 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_block_in_statement2487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Async_in_statement2516 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_block_in_statement2518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Lock_in_statement2546 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_statement2548 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_statement2550 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_statement2552 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_block_in_statement2554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement2577 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_expression_in_statement2579 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_statement2582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement2603 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_statement2605 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_137_in_statement2617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement2628 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_statement2630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_statement2639 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_statement2641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifBranch_in_ifStatement2661 = new BitSet(new ulong[]{0x0000000000000002UL,0x0018000000000000UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_ifStatement2667 = new BitSet(new ulong[]{0x0000000000000000UL,0x0018000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2669 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2675 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_ifBranch2687 = new BitSet(new ulong[]{0x2000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_condition_in_ifBranch2689 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_ifBranch2691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ElseIf_in_elseIfBranches2712 = new BitSet(new ulong[]{0x2000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_condition_in_elseIfBranches2714 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_elseIfBranches2716 = new BitSet(new ulong[]{0x0000000000000002UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_Else_in_elseBranch2745 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_elseBranch2747 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_For_in_forStatement2765 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_forStatement2767 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_forControl_in_forStatement2769 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_forStatement2771 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_forStatement2773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PFor_in_pForStatement2793 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_pForStatement2795 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_forControl_in_pForStatement2797 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_pForStatement2799 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_pForStatement2801 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl2822 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_forControl2825 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_forCondition_in_forControl2827 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_forControl2830 = new BitSet(new ulong[]{0xA800000000000002UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl2832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit2874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forCondition2884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate2895 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_whileStatement2904 = new BitSet(new ulong[]{0x2000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_condition_in_whileStatement2906 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_whileStatement2908 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_doStatement2930 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_doStatement2932 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_While_in_doStatement2934 = new BitSet(new ulong[]{0x2000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_condition_in_doStatement2936 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_doStatement2938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PForEach_in_pForEachStatement2958 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_pForEachStatement2960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ForEach_in_forEachStatement2977 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_forEachStatement2979 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_forEachTrailer2997 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_forEachControl_in_forEachTrailer3000 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_forEachTrailer3002 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_forEachTrailer3005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_forEachControl3034 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_forEachControl3036 = new BitSet(new ulong[]{0x0000000000000000UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_In_in_forEachControl3038 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_forEachControl3040 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_loopStatement3061 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_143_in_loopStatement3063 = new BitSet(new ulong[]{0xA800000000000000UL,0x37E7FFE20007FFFEUL,0x0000000000008200UL});
    public static readonly BitSet FOLLOW_loopControl_in_loopStatement3065 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_loopStatement3067 = new BitSet(new ulong[]{0xA800000000000000UL,0x17E7FFE20007FFFEUL,0x0000000000008600UL});
    public static readonly BitSet FOLLOW_core_in_loopStatement3069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_loopControl3110 = new BitSet(new ulong[]{0x0000000000000000UL,0x2000000000000000UL});
    public static readonly BitSet FOLLOW_To_in_loopControl3112 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_expression_in_loopControl3114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_branch_in_core3137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_condition3156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_synpred2_Psimulex333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred10_Psimulex660 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_Assign_in_synpred10_Psimulex662 = new BitSet(new ulong[]{0xA800000000000000UL,0x00001FE200000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_synpred10_Psimulex664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred19_Psimulex983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred41_Psimulex1404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_synpred61_Psimulex1719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_synpred63_Psimulex1770 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000C000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_synpred63_Psimulex1773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred68_Psimulex1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred69_Psimulex1913 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_synpred102_Psimulex2628 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_137_in_synpred102_Psimulex2630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_synpred103_Psimulex2667 = new BitSet(new ulong[]{0x0000000000000000UL,0x0018000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred103_Psimulex2669 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred104_Psimulex2675 = new BitSet(new ulong[]{0x0000000000000002UL});

}
