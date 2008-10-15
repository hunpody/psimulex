// $ANTLR 3.1.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-10-14 20:06:21

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

    public const int CAST = 51;
    public const int Iterator = 87;
    public const int CONDITIONALBRANCH = 21;
    public const int RelEqual = 95;
    public const int FORMAL_PARAMETER_LIST = 14;
    public const int TYPE_DECLARATIONS = 8;
    public const int VARINIT = 45;
    public const int AssignAndDivide = 91;
    public const int FORSTATEMENT = 24;
    public const int AssignAndMultiply = 90;
    public const int PFORSTATEMENT = 23;
    public const int CONDITION = 38;
    public const int Decimal = 73;
    public const int Modulo = 105;
    public const int PDOSTATEMENT = 39;
    public const int IDLetter = 134;
    public const int EOF = -1;
    public const int STATEMENT = 17;
    public const int INDEXING = 59;
    public const int Identifier = 66;
    public const int Int = 72;
    public const int Thread = 86;
    public const int TYPE = 47;
    public const int CONSTANT_DIMS = 61;
    public const int BinTree = 77;
    public const int PFOREACHSTATEMENT = 30;
    public const int T__148 = 148;
    public const int T__147 = 147;
    public const int To = 130;
    public const int T__149 = 149;
    public const int ForEach = 127;
    public const int Char = 71;
    public const int Edge = 85;
    public const int COMPILATION_UNIT = 4;
    public const int LOCKSTATEMENT = 41;
    public const int Do = 125;
    public const int RelGreaterThan = 99;
    public const int FORMAL_PARAMETER = 15;
    public const int Node = 84;
    public const int AssignAndModulo = 92;
    public const int LOOPLIMIT = 36;
    public const int FOREACHINIT = 32;
    public const int T__150 = 150;
    public const int WHILESTATEMENT = 29;
    public const int FORUPDATE = 27;
    public const int Bool = 70;
    public const int FORINIT = 26;
    public const int ARGUMENTS = 57;
    public const int MEMBER_SELECT = 58;
    public const int LogicalOr = 93;
    public const int LogicalAnd = 94;
    public const int CORE = 37;
    public const int Tree = 76;
    public const int T__142 = 142;
    public const int T__145 = 145;
    public const int T__146 = 146;
    public const int T__143 = 143;
    public const int T__144 = 144;
    public const int POSTFIXOP = 53;
    public const int Minus = 102;
    public const int WS = 139;
    public const int Break = 118;
    public const int GLOBAL_VARIABLE_DECLARATIONS = 10;
    public const int Async = 115;
    public const int MEMBER_FUNCTION_CALL = 55;
    public const int MULTY_FUNCTIONAL_PROGRAM = 6;
    public const int SIMPLE_PROGRAM = 5;
    public const int DATATYPE = 48;
    public const int EXPRESSION_STATEMENT = 43;
    public const int NotNullDigit = 136;
    public const int RelLessThan = 97;
    public const int Star = 103;
    public const int Else = 121;
    public const int FUNCTION_CALL = 56;
    public const int EscapeSequence = 138;
    public const int Letter = 133;
    public const int Loop = 129;
    public const int VARIABLE_DECLARATION_STATEMENT = 44;
    public const int BooleanLiteral = 111;
    public const int LOOPSTATEMENT = 34;
    public const int DIMMARKER = 62;
    public const int AssignAndAdd = 88;
    public const int Stack = 80;
    public const int NullLiteral = 112;
    public const int RelGreaterThanOrEqual = 100;
    public const int IFSTATEMENT = 18;
    public const int PQueue = 82;
    public const int SingleLineComment = 140;
    public const int DIMS = 60;
    public const int CharacterLiteral = 110;
    public const int AssignAndSubstract = 89;
    public const int FOREACHCOLLECTION = 33;
    public const int While = 124;
    public const int Graph = 83;
    public const int Queue = 81;
    public const int Set = 78;
    public const int SELECTOR = 54;
    public const int Assign = 67;
    public const int RETURN_STATEMENT = 42;
    public const int PForEach = 126;
    public const int RelNotEqual = 96;
    public const int FOREACHSTATEMENT = 31;
    public const int IFBRANCH = 19;
    public const int String = 74;
    public const int Return = 117;
    public const int Struct = 65;
    public const int Reference = 69;
    public const int EXPRESSION = 50;
    public const int MultiLineComment = 141;
    public const int If = 119;
    public const int FUNCTIONPOINTERTYPE = 49;
    public const int In = 128;
    public const int Import = 63;
    public const int VARDECLARE = 46;
    public const int FUNCTION_DECLARATIONS = 12;
    public const int Continue = 131;
    public const int ELSEBRANCH = 22;
    public const int Void = 75;
    public const int ASYNCSTATEMENT = 40;
    public const int Lock = 116;
    public const int PDo = 114;
    public const int ElseIf = 120;
    public const int IMPORT_DECLARATIONS = 7;
    public const int DOSTATEMENT = 28;
    public const int Digit = 135;
    public const int DecimalLiteral = 109;
    public const int STRUCTDEC = 9;
    public const int For = 122;
    public const int Divide = 104;
    public const int List = 79;
    public const int FORCONDITION = 25;
    public const int StringLiteral = 64;
    public const int LogicalNot = 106;
    public const int Plus = 101;
    public const int Atomic = 132;
    public const int RelLessThanOrEqual = 98;
    public const int MinusMinus = 108;
    public const int DecimalTypeSuffix = 137;
    public const int PFor = 123;
    public const int BLOCK = 16;
    public const int PREFIXOP = 52;
    public const int MEMBERDEC = 11;
    public const int ELSEIFBRANCHES = 20;
    public const int IntegerLiteral = 68;
    public const int LOOPINIT = 35;
    public const int FUNCDEC = 13;
    public const int InfinityLiteral = 113;
    public const int PlusPlus = 107;

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:96:1: compilationUnit : ( simpleProgram | multiFunctionalProgram )? EOF ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:5: ( ( simpleProgram | multiFunctionalProgram )? EOF )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:7: ( simpleProgram | multiFunctionalProgram )? EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:7: ( simpleProgram | multiFunctionalProgram )?
            	int alt1 = 3;
            	alt1 = dfa1.Predict(input);
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:9: simpleProgram
            	        {
            	        	PushFollow(FOLLOW_simpleProgram_in_compilationUnit347);
            	        	simpleProgram1 = simpleProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:25: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit351);
            	        	multiFunctionalProgram2 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit356); if (state.failed) return retval;

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:1: simpleProgram : ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:2: ( ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:4: ( statement )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || (LA2_0 >= IntegerLiteral && LA2_0 <= Iterator) || LA2_0 == Minus || (LA2_0 >= LogicalNot && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= ForEach) || LA2_0 == Loop || LA2_0 == 142 || LA2_0 == 148) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_simpleProgram371);
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
            	// 101:15: -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:18: ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:38: ^( SIMPLE_PROGRAM ( statement )* )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SIMPLE_PROGRAM, "SIMPLE_PROGRAM"), root_2);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:56: ( statement )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:1: multiFunctionalProgram : importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:2: ( importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:4: importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations
            {
            	PushFollow(FOLLOW_importDeclarations_in_multiFunctionalProgram400);
            	importDeclarations5 = importDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_importDeclarations.Add(importDeclarations5.Tree);
            	PushFollow(FOLLOW_typeDeclarations_in_multiFunctionalProgram402);
            	typeDeclarations6 = typeDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typeDeclarations.Add(typeDeclarations6.Tree);
            	PushFollow(FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram404);
            	globalVariableDeclarations7 = globalVariableDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_globalVariableDeclarations.Add(globalVariableDeclarations7.Tree);
            	PushFollow(FOLLOW_functionDeclarations_in_multiFunctionalProgram406);
            	functionDeclarations8 = functionDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_functionDeclarations.Add(functionDeclarations8.Tree);


            	// AST REWRITE
            	// elements:          typeDeclarations, globalVariableDeclarations, functionDeclarations, importDeclarations
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 106:3: -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:6: ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:26: ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:109:1: globalVariableDeclarations : ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:110:2: ( ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:110:4: ( memberDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:110:4: ( memberDeclaration )*
            	do 
            	{
            	    int alt3 = 2;
            	    alt3 = dfa3.Predict(input);
            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclarations441);
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
            	// 110:23: -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:110:26: ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GLOBAL_VARIABLE_DECLARATIONS, "GLOBAL_VARIABLE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:110:58: ( memberDeclaration )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:126:1: importDeclarations : ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) ;
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
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:5: ( ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:9: ( Import StringLiteral ';' )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:9: ( Import StringLiteral ';' )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:11: Import StringLiteral ';'
            			    {
            			    	Import10=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclarations481); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_Import.Add(Import10);

            			    	StringLiteral11=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclarations483); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_StringLiteral.Add(StringLiteral11);

            			    	char_literal12=(IToken)Match(input,142,FOLLOW_142_in_importDeclarations485); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_142.Add(char_literal12);


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
            	// 127:39: -> ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:42: ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IMPORT_DECLARATIONS, "IMPORT_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:65: ( StringLiteral )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:130:1: typeDeclarations : ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:5: ( ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:9: ( structDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:9: ( structDeclaration )*
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
            			    	PushFollow(FOLLOW_structDeclaration_in_typeDeclarations518);
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
            	// 131:28: -> ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:31: ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE_DECLARATIONS, "TYPE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:52: ( structDeclaration )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:134:1: structDeclaration : Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:5: ( Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:9: Struct Identifier structBody
            {
            	Struct14=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration549); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Struct.Add(Struct14);

            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration551); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier15);

            	PushFollow(FOLLOW_structBody_in_structDeclaration553);
            	structBody16 = structBody();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_structBody.Add(structBody16.Tree);


            	// AST REWRITE
            	// elements:          structBody, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 135:38: -> ^( STRUCTDEC Identifier structBody )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:41: ^( STRUCTDEC Identifier structBody )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:138:1: structBody : '{' ( memberDeclaration )+ '}' ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:5: ( '{' ( memberDeclaration )+ '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:9: '{' ( memberDeclaration )+ '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,143,FOLLOW_143_in_structBody583); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:14: ( memberDeclaration )+
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
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBody586);
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

            	char_literal19=(IToken)Match(input,144,FOLLOW_144_in_structBody589); if (state.failed) return retval;

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:142:1: memberDeclaration : memberTypedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? ) ;
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
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleSubtreeStream stream_memberTypedIdentifierNonRef = new RewriteRuleSubtreeStream(adaptor,"rule memberTypedIdentifierNonRef");
        RewriteRuleSubtreeStream stream_literal = new RewriteRuleSubtreeStream(adaptor,"rule literal");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:5: ( memberTypedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:9: memberTypedIdentifierNonRef ( Assign literal )? ';'
            {
            	PushFollow(FOLLOW_memberTypedIdentifierNonRef_in_memberDeclaration610);
            	memberTypedIdentifierNonRef20 = memberTypedIdentifierNonRef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_memberTypedIdentifierNonRef.Add(memberTypedIdentifierNonRef20.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:37: ( Assign literal )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == Assign) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:39: Assign literal
            	        {
            	        	Assign21=(IToken)Match(input,Assign,FOLLOW_Assign_in_memberDeclaration614); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Assign.Add(Assign21);

            	        	PushFollow(FOLLOW_literal_in_memberDeclaration616);
            	        	literal22 = literal();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_literal.Add(literal22.Tree);

            	        }
            	        break;

            	}

            	char_literal23=(IToken)Match(input,142,FOLLOW_142_in_memberDeclaration621); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal23);



            	// AST REWRITE
            	// elements:          memberTypedIdentifierNonRef, literal
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 143:61: -> ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:64: ^( MEMBERDEC memberTypedIdentifierNonRef ( literal )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBERDEC, "MEMBERDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_memberTypedIdentifierNonRef.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:105: ( literal )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:5: ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) )
            int alt8 = 3;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:9: typedIdentifierNonRef
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration660);
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
                    	// 148:31: -> ^( VARDECLARE typedIdentifierNonRef )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:34: ^( VARDECLARE typedIdentifierNonRef )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:9: typedIdentifierNonRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration678);
                    	typedIdentifierNonRef25 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierNonRef.Add(typedIdentifierNonRef25.Tree);
                    	Assign26=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration680); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign26);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration682);
                    	variableInitializer27 = variableInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_variableInitializer.Add(variableInitializer27.Tree);


                    	// AST REWRITE
                    	// elements:          variableInitializer, typedIdentifierNonRef
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 149:58: -> ^( VARINIT typedIdentifierNonRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:61: ^( VARINIT typedIdentifierNonRef variableInitializer )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:150:4: typedIdentifierRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierRef_in_localVariableDeclaration697);
                    	typedIdentifierRef28 = typedIdentifierRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierRef.Add(typedIdentifierRef28.Tree);
                    	Assign29=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration699); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign29);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration701);
                    	variableInitializer30 = variableInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_variableInitializer.Add(variableInitializer30.Tree);


                    	// AST REWRITE
                    	// elements:          variableInitializer, typedIdentifierRef
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 150:50: -> ^( VARINIT typedIdentifierRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:150:53: ^( VARINIT typedIdentifierRef variableInitializer )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:1: variableInitializer : expression ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_variableInitializer734);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:1: scalarOrArrayType : type ( staticArrayType )? -> ^( TYPE type ( staticArrayType )? ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:2: ( type ( staticArrayType )? -> ^( TYPE type ( staticArrayType )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:4: type ( staticArrayType )?
            {
            	PushFollow(FOLLOW_type_in_scalarOrArrayType754);
            	type32 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type32.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:9: ( staticArrayType )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 145) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: staticArrayType
            	        {
            	        	PushFollow(FOLLOW_staticArrayType_in_scalarOrArrayType756);
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
            	// 158:26: -> ^( TYPE type ( staticArrayType )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:29: ^( TYPE type ( staticArrayType )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE, "TYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:42: ( staticArrayType )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:1: arrayType : ( staticArrayType | dynamicArrayType );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:2: ( staticArrayType | dynamicArrayType )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == 145) )
            {
                int LA10_1 = input.LA(2);

                if ( ((LA10_1 >= 146 && LA10_1 <= 147)) )
                {
                    alt10 = 2;
                }
                else if ( (LA10_1 == StringLiteral || LA10_1 == Identifier || (LA10_1 >= IntegerLiteral && LA10_1 <= Reference) || LA10_1 == Minus || (LA10_1 >= LogicalNot && LA10_1 <= InfinityLiteral) || LA10_1 == 148) )
                {
                    alt10 = 1;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:4: staticArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_staticArrayType_in_arrayType781);
                    	staticArrayType34 = staticArrayType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, staticArrayType34.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:22: dynamicArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dynamicArrayType_in_arrayType785);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:1: staticArrayType : '[' expression ( ',' expression )* ']' -> ^( DIMS expression ( expression )* ) ;
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
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:2: ( '[' expression ( ',' expression )* ']' -> ^( DIMS expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:4: '[' expression ( ',' expression )* ']'
            {
            	char_literal36=(IToken)Match(input,145,FOLLOW_145_in_staticArrayType797); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal36);

            	PushFollow(FOLLOW_expression_in_staticArrayType799);
            	expression37 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression37.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:19: ( ',' expression )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 146) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:20: ',' expression
            			    {
            			    	char_literal38=(IToken)Match(input,146,FOLLOW_146_in_staticArrayType802); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_146.Add(char_literal38);

            			    	PushFollow(FOLLOW_expression_in_staticArrayType804);
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

            	char_literal40=(IToken)Match(input,147,FOLLOW_147_in_staticArrayType808); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_147.Add(char_literal40);



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
            	// 166:41: -> ^( DIMS expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:44: ^( DIMS expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMS, "DIMS"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:63: ( expression )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:169:1: dynamicArrayType : '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) ;
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
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:2: ( '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:4: '[' ( ',' )* ']'
            {
            	char_literal41=(IToken)Match(input,145,FOLLOW_145_in_dynamicArrayType836); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal41);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:8: ( ',' )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 146) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:10: ','
            			    {
            			    	char_literal42=(IToken)Match(input,146,FOLLOW_146_in_dynamicArrayType840); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_146.Add(char_literal42);


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal43=(IToken)Match(input,147,FOLLOW_147_in_dynamicArrayType845); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_147.Add(char_literal43);



            	// AST REWRITE
            	// elements:          147, 145, 146
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 170:21: -> ^( DIMMARKER '[' ( ',' )* ']' )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:24: ^( DIMMARKER '[' ( ',' )* ']' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMMARKER, "DIMMARKER"), root_1);

            	    adaptor.AddChild(root_1, stream_145.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:41: ( ',' )*
            	    while ( stream_146.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_146.NextNode());

            	    }
            	    stream_146.Reset();
            	    adaptor.AddChild(root_1, stream_147.NextNode());

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:1: memberScalarOrArrayType : type ( memberArrayType )? -> ^( TYPE type ( memberArrayType )? ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:2: ( type ( memberArrayType )? -> ^( TYPE type ( memberArrayType )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:4: type ( memberArrayType )?
            {
            	PushFollow(FOLLOW_type_in_memberScalarOrArrayType875);
            	type44 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type44.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:9: ( memberArrayType )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 145) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberArrayType
            	        {
            	        	PushFollow(FOLLOW_memberArrayType_in_memberScalarOrArrayType877);
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
            	// 174:26: -> ^( TYPE type ( memberArrayType )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:29: ^( TYPE type ( memberArrayType )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE, "TYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:42: ( memberArrayType )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:177:1: memberArrayType : ( memberStaticArrayType | dynamicArrayType );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:2: ( memberStaticArrayType | dynamicArrayType )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == 145) )
            {
                int LA14_1 = input.LA(2);

                if ( (LA14_1 == IntegerLiteral) )
                {
                    alt14 = 1;
                }
                else if ( ((LA14_1 >= 146 && LA14_1 <= 147)) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:4: memberStaticArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberStaticArrayType_in_memberArrayType902);
                    	memberStaticArrayType46 = memberStaticArrayType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberStaticArrayType46.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:28: dynamicArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dynamicArrayType_in_memberArrayType906);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:1: memberStaticArrayType : '[' IntegerLiteral ( ',' IntegerLiteral )* ']' -> ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* ) ;
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
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_IntegerLiteral = new RewriteRuleTokenStream(adaptor,"token IntegerLiteral");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:2: ( '[' IntegerLiteral ( ',' IntegerLiteral )* ']' -> ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:4: '[' IntegerLiteral ( ',' IntegerLiteral )* ']'
            {
            	char_literal48=(IToken)Match(input,145,FOLLOW_145_in_memberStaticArrayType917); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal48);

            	IntegerLiteral49=(IToken)Match(input,IntegerLiteral,FOLLOW_IntegerLiteral_in_memberStaticArrayType919); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_IntegerLiteral.Add(IntegerLiteral49);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:23: ( ',' IntegerLiteral )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == 146) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:24: ',' IntegerLiteral
            			    {
            			    	char_literal50=(IToken)Match(input,146,FOLLOW_146_in_memberStaticArrayType922); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_146.Add(char_literal50);

            			    	IntegerLiteral51=(IToken)Match(input,IntegerLiteral,FOLLOW_IntegerLiteral_in_memberStaticArrayType924); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_IntegerLiteral.Add(IntegerLiteral51);


            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	char_literal52=(IToken)Match(input,147,FOLLOW_147_in_memberStaticArrayType928); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_147.Add(char_literal52);



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
            	// 182:49: -> ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:52: ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CONSTANT_DIMS, "CONSTANT_DIMS"), root_1);

            	    adaptor.AddChild(root_1, stream_IntegerLiteral.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:84: ( IntegerLiteral )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:1: memberTypedIdentifierNonRef : memberScalarOrArrayType Identifier ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:2: ( memberScalarOrArrayType Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:4: memberScalarOrArrayType Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_memberScalarOrArrayType_in_memberTypedIdentifierNonRef957);
            	memberScalarOrArrayType53 = memberScalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberScalarOrArrayType53.Tree);
            	Identifier54=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberTypedIdentifierNonRef959); if (state.failed) return retval;
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:1: typedIdentifierNonRef : scalarOrArrayType Identifier ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:2: ( scalarOrArrayType Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:4: scalarOrArrayType Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef970);
            	scalarOrArrayType55 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType55.Tree);
            	Identifier56=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierNonRef972); if (state.failed) return retval;
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:1: typedIdentifierRef : scalarOrArrayType ( Reference )? Identifier ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:2: ( scalarOrArrayType ( Reference )? Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:4: scalarOrArrayType ( Reference )? Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierRef983);
            	scalarOrArrayType57 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType57.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:22: ( Reference )?
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
            	        	Reference58=(IToken)Match(input,Reference,FOLLOW_Reference_in_typedIdentifierRef985); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Reference58_tree = (CommonTree)adaptor.Create(Reference58);
            	        		adaptor.AddChild(root_0, Reference58_tree);
            	        	}

            	        }
            	        break;

            	}

            	Identifier59=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierRef988); if (state.failed) return retval;
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:1: typedIdentifier : ( typedIdentifierNonRef | typedIdentifierRef );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:2: ( typedIdentifierNonRef | typedIdentifierRef )
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
            case Graph:
            case Node:
            case Edge:
            case Thread:
            case Iterator:
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:4: typedIdentifierNonRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_typedIdentifier1001);
                    	typedIdentifierNonRef60 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierNonRef60.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:28: typedIdentifierRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierRef_in_typedIdentifier1005);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:1: functionDeclarations : ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:5: ( ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:7: ( functionDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:7: ( functionDeclaration )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == Identifier || (LA18_0 >= Bool && LA18_0 <= Iterator)) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: functionDeclaration
            			    {
            			    	PushFollow(FOLLOW_functionDeclaration_in_functionDeclarations1022);
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
            	// 202:28: -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:31: ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION_DECLARATIONS, "FUNCTION_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:56: ( functionDeclaration )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:205:1: functionDeclaration : typedIdentifier formalParameterList block -> ^( FUNCDEC typedIdentifier ( formalParameterList )? block ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:5: ( typedIdentifier formalParameterList block -> ^( FUNCDEC typedIdentifier ( formalParameterList )? block ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:7: typedIdentifier formalParameterList block
            {
            	PushFollow(FOLLOW_typedIdentifier_in_functionDeclaration1055);
            	typedIdentifier63 = typedIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier63.Tree);
            	PushFollow(FOLLOW_formalParameterList_in_functionDeclaration1057);
            	formalParameterList64 = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_formalParameterList.Add(formalParameterList64.Tree);
            	PushFollow(FOLLOW_block_in_functionDeclaration1060);
            	block65 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_block.Add(block65.Tree);


            	// AST REWRITE
            	// elements:          typedIdentifier, formalParameterList, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 206:50: -> ^( FUNCDEC typedIdentifier ( formalParameterList )? block )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:53: ^( FUNCDEC typedIdentifier ( formalParameterList )? block )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCDEC, "FUNCDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifier.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:80: ( formalParameterList )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:1: formalParameterList : '(' ( formalParameter ( ',' formalParameter )* )? ')' -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? ) ;
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
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleSubtreeStream stream_formalParameter = new RewriteRuleSubtreeStream(adaptor,"rule formalParameter");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:5: ( '(' ( formalParameter ( ',' formalParameter )* )? ')' -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:9: '(' ( formalParameter ( ',' formalParameter )* )? ')'
            {
            	char_literal66=(IToken)Match(input,148,FOLLOW_148_in_formalParameterList1094); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal66);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:13: ( formalParameter ( ',' formalParameter )* )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == Identifier || (LA20_0 >= Bool && LA20_0 <= Iterator)) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:15: formalParameter ( ',' formalParameter )*
            	        {
            	        	PushFollow(FOLLOW_formalParameter_in_formalParameterList1098);
            	        	formalParameter67 = formalParameter();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_formalParameter.Add(formalParameter67.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:31: ( ',' formalParameter )*
            	        	do 
            	        	{
            	        	    int alt19 = 2;
            	        	    int LA19_0 = input.LA(1);

            	        	    if ( (LA19_0 == 146) )
            	        	    {
            	        	        alt19 = 1;
            	        	    }


            	        	    switch (alt19) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:32: ',' formalParameter
            	        			    {
            	        			    	char_literal68=(IToken)Match(input,146,FOLLOW_146_in_formalParameterList1101); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_146.Add(char_literal68);

            	        			    	PushFollow(FOLLOW_formalParameter_in_formalParameterList1103);
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

            	char_literal70=(IToken)Match(input,149,FOLLOW_149_in_formalParameterList1110); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_149.Add(char_literal70);



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
            	// 210:61: -> ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:64: ^( FORMAL_PARAMETER_LIST ( formalParameter ( formalParameter )* )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORMAL_PARAMETER_LIST, "FORMAL_PARAMETER_LIST"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:89: ( formalParameter ( formalParameter )* )?
            	    if ( stream_formalParameter.HasNext() || stream_formalParameter.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_formalParameter.NextTree());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:107: ( formalParameter )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:1: formalParameter : typedIdentifier -> ^( FORMAL_PARAMETER typedIdentifier ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:5: ( typedIdentifier -> ^( FORMAL_PARAMETER typedIdentifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:9: typedIdentifier
            {
            	PushFollow(FOLLOW_typedIdentifier_in_formalParameter1147);
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
            	// 214:25: -> ^( FORMAL_PARAMETER typedIdentifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:28: ^( FORMAL_PARAMETER typedIdentifier )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:222:1: type : dataType ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:223:5: ( dataType )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:223:7: dataType
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dataType_in_type1183);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:232:1: dataType : dataTypeName -> ^( DATATYPE dataTypeName ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:2: ( dataTypeName -> ^( DATATYPE dataTypeName ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:4: dataTypeName
            {
            	PushFollow(FOLLOW_dataTypeName_in_dataType1202);
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
            	// 233:17: -> ^( DATATYPE dataTypeName )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:20: ^( DATATYPE dataTypeName )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:236:1: dataTypeName : ( primitiveType | builtInType | userDefinedTypes );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:2: ( primitiveType | builtInType | userDefinedTypes )
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
            case Graph:
            case Node:
            case Edge:
            case Thread:
            case Iterator:
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:4: primitiveType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primitiveType_in_dataTypeName1223);
                    	primitiveType74 = primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType74.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:20: builtInType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtInType_in_dataTypeName1227);
                    	builtInType75 = builtInType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType75.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:34: userDefinedTypes
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_userDefinedTypes_in_dataTypeName1231);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:240:1: userDefinedTypes : Identifier ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:241:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:241:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier77=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_userDefinedTypes1243); if (state.failed) return retval;
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:244:1: primitiveType : ( Bool | Char | Int | Decimal | String | Void );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:245:5: ( Bool | Char | Int | Decimal | String | Void )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:254:1: builtInType : ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Graph | Node | Edge | Thread | Iterator );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:255:5: ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Graph | Node | Edge | Thread | Iterator )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set79 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= Iterator) ) 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:292:1: expression : exp -> ^( EXPRESSION exp ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:2: ( exp -> ^( EXPRESSION exp ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:4: exp
            {
            	PushFollow(FOLLOW_exp_in_expression1400);
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
            	// 293:8: -> ^( EXPRESSION exp )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:11: ^( EXPRESSION exp )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:296:1: exp : ( assignment | conditionalOrExpression );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:2: ( assignment | conditionalOrExpression )
            int alt22 = 2;
            switch ( input.LA(1) ) 
            {
            case Reference:
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
            case Identifier:
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
            case 148:
            	{
                int LA22_3 = input.LA(2);

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
                    NoViableAltException nvae_d22s3 =
                        new NoViableAltException("", 22, 3, input);

                    throw nvae_d22s3;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_exp1422);
                    	assignment81 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment81.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:17: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_exp1426);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:300:1: assignment : leftValue assignmentOperator exp ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:2: ( leftValue assignmentOperator exp )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:4: leftValue assignmentOperator exp
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_leftValue_in_assignment1439);
            	leftValue83 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue83.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment1441);
            	assignmentOperator84 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assignmentOperator84.Tree, root_0);
            	PushFollow(FOLLOW_exp_in_assignment1444);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:304:1: assignmentOperator : ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:2: ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:308:1: conditionalOrExpression : conditionalAndExpression ( LogicalOr conditionalAndExpression )* ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:5: ( conditionalAndExpression ( LogicalOr conditionalAndExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:9: conditionalAndExpression ( LogicalOr conditionalAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1485);
            	conditionalAndExpression87 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression87.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:34: ( LogicalOr conditionalAndExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:36: LogicalOr conditionalAndExpression
            			    {
            			    	LogicalOr88=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression1489); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalOr88_tree = (CommonTree)adaptor.Create(LogicalOr88);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalOr88_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1492);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:312:1: conditionalAndExpression : equalityExpression ( LogicalAnd equalityExpression )* ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:5: ( equalityExpression ( LogicalAnd equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:9: equalityExpression ( LogicalAnd equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1514);
            	equalityExpression90 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression90.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:28: ( LogicalAnd equalityExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:30: LogicalAnd equalityExpression
            			    {
            			    	LogicalAnd91=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression1518); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd91_tree = (CommonTree)adaptor.Create(LogicalAnd91);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd91_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1521);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:316:1: equalityExpression : relationalExpression ( equalityOp relationalExpression )* ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:5: ( relationalExpression ( equalityOp relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:9: relationalExpression ( equalityOp relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1543);
            	relationalExpression93 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression93.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:30: ( equalityOp relationalExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:32: equalityOp relationalExpression
            			    {
            			    	PushFollow(FOLLOW_equalityOp_in_equalityExpression1547);
            			    	equalityOp94 = equalityOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp94.Tree, root_0);
            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1550);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:320:1: equalityOp : ( RelEqual | RelNotEqual );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:2: ( RelEqual | RelNotEqual )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:324:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1585);
            	additiveExpression97 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression97.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:28: ( relationalOp additiveExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression1589);
            			    	relationalOp98 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp98.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1592);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:328:1: relationalOp : ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:5: ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:332:1: additiveExpression : multiplicativeExpression ( additiveOp multiplicativeExpression )* ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:5: ( multiplicativeExpression ( additiveOp multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:9: multiplicativeExpression ( additiveOp multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1645);
            	multiplicativeExpression101 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression101.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:34: ( additiveOp multiplicativeExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:36: additiveOp multiplicativeExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression1649);
            			    	additiveOp102 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp102.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1652);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:336:1: additiveOp : ( Plus | Minus );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:2: ( Plus | Minus )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:340:1: multiplicativeExpression : unaryExpression ( multiplicativeOp unaryExpression )* ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:5: ( unaryExpression ( multiplicativeOp unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:9: unaryExpression ( multiplicativeOp unaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1687);
            	unaryExpression105 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression105.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:25: ( multiplicativeOp unaryExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:27: multiplicativeOp unaryExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression1691);
            			    	multiplicativeOp106 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp106.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1694);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:344:1: multiplicativeOp : ( Star | Divide | Modulo );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:345:2: ( Star | Divide | Modulo )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:348:1: unaryExpression : ( unaryPrefixExpression | unaryPostfixExpression | castExpression );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:349:5: ( unaryPrefixExpression | unaryPostfixExpression | castExpression )
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
            case Reference:
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
            case 148:
            	{
                int LA29_4 = input.LA(2);

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
                    NoViableAltException nvae_d29s4 =
                        new NoViableAltException("", 29, 4, input);

                    throw nvae_d29s4;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:349:7: unaryPrefixExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPrefixExpression_in_unaryExpression1729);
                    	unaryPrefixExpression109 = unaryPrefixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPrefixExpression109.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:7: unaryPostfixExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPostfixExpression_in_unaryExpression1737);
                    	unaryPostfixExpression110 = unaryPostfixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPostfixExpression110.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:4: castExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpression1742);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:354:1: unaryPrefixExpression : unaryPrefixOp unaryExpression -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:2: ( unaryPrefixOp unaryExpression -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:4: unaryPrefixOp unaryExpression
            {
            	PushFollow(FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1756);
            	unaryPrefixOp112 = unaryPrefixOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryPrefixOp.Add(unaryPrefixOp112.Tree);
            	PushFollow(FOLLOW_unaryExpression_in_unaryPrefixExpression1758);
            	unaryExpression113 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryExpression.Add(unaryExpression113.Tree);


            	// AST REWRITE
            	// elements:          unaryExpression, unaryPrefixOp
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 355:34: -> ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:37: ^( PREFIXOP ^( unaryPrefixOp unaryExpression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PREFIXOP, "PREFIXOP"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:49: ^( unaryPrefixOp unaryExpression )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:1: unaryPostfixExpression : ( leftValueExpression ( unaryPostfixOp )? | primaryExpression );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:2: ( leftValueExpression ( unaryPostfixOp )? | primaryExpression )
            int alt31 = 2;
            switch ( input.LA(1) ) 
            {
            case Reference:
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
            case Identifier:
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
            case 148:
            	{
                int LA31_3 = input.LA(2);

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
                    NoViableAltException nvae_d31s3 =
                        new NoViableAltException("", 31, 3, input);

                    throw nvae_d31s3;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:4: leftValueExpression ( unaryPostfixOp )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValueExpression_in_unaryPostfixExpression1788);
                    	leftValueExpression114 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValueExpression114.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:24: ( unaryPostfixOp )?
                    	int alt30 = 2;
                    	int LA30_0 = input.LA(1);

                    	if ( ((LA30_0 >= PlusPlus && LA30_0 <= MinusMinus)) )
                    	{
                    	    alt30 = 1;
                    	}
                    	switch (alt30) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:25: unaryPostfixOp
                    	        {
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1791);
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:4: primaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryPostfixExpression1799);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:363:1: leftValueExpression : ( leftValue | unaryPrefixAssignerOp leftValueExpression -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) ) );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:364:2: ( leftValue | unaryPrefixAssignerOp leftValueExpression -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) ) )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == Identifier || LA32_0 == Reference || LA32_0 == 148) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:364:4: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_leftValueExpression1810);
                    	leftValue117 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue117.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:4: unaryPrefixAssignerOp leftValueExpression
                    {
                    	PushFollow(FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1815);
                    	unaryPrefixAssignerOp118 = unaryPrefixAssignerOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_unaryPrefixAssignerOp.Add(unaryPrefixAssignerOp118.Tree);
                    	PushFollow(FOLLOW_leftValueExpression_in_leftValueExpression1817);
                    	leftValueExpression119 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_leftValueExpression.Add(leftValueExpression119.Tree);


                    	// AST REWRITE
                    	// elements:          leftValueExpression, unaryPrefixAssignerOp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 365:46: -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:49: ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression ) )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PREFIXOP, "PREFIXOP"), root_1);

                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:61: ^( unaryPrefixAssignerOp leftValueExpression )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:368:1: castExpression : '(' dataType ')' unaryExpression -> ^( CAST dataType unaryExpression ) ;
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
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleSubtreeStream stream_dataType = new RewriteRuleSubtreeStream(adaptor,"rule dataType");
        RewriteRuleSubtreeStream stream_unaryExpression = new RewriteRuleSubtreeStream(adaptor,"rule unaryExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:2: ( '(' dataType ')' unaryExpression -> ^( CAST dataType unaryExpression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:4: '(' dataType ')' unaryExpression
            {
            	char_literal120=(IToken)Match(input,148,FOLLOW_148_in_castExpression1848); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal120);

            	PushFollow(FOLLOW_dataType_in_castExpression1850);
            	dataType121 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataType.Add(dataType121.Tree);
            	char_literal122=(IToken)Match(input,149,FOLLOW_149_in_castExpression1852); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_149.Add(char_literal122);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1854);
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
            	// 369:37: -> ^( CAST dataType unaryExpression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:40: ^( CAST dataType unaryExpression )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:372:1: unaryPrefixOp : ( Minus | LogicalNot );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:2: ( Minus | LogicalNot )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:376:1: unaryPrefixAssignerOp : ( PlusPlus | MinusMinus );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:2: ( PlusPlus | MinusMinus )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:380:1: unaryPostfixOp : ( PlusPlus | MinusMinus );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:381:2: ( PlusPlus | MinusMinus )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:384:1: primaryExpression : ( parExpression | leftValue | literal | functionCall );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:385:5: ( parExpression | leftValue | literal | functionCall )
            int alt33 = 4;
            switch ( input.LA(1) ) 
            {
            case 148:
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
            case Reference:
            	{
                alt33 = 2;
                }
                break;
            case Identifier:
            	{
                int LA33_3 = input.LA(2);

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
                    NoViableAltException nvae_d33s3 =
                        new NoViableAltException("", 33, 3, input);

                    throw nvae_d33s3;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:385:9: parExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1923);
                    	parExpression127 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression127.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:386:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1931);
                    	leftValue128 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue128.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:387:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1941);
                    	literal129 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal129.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:388:7: functionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionCall_in_primaryExpression1949);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:391:1: parExpression : '(' expression ')' ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:392:5: ( '(' expression ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:392:9: '(' expression ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal131=(IToken)Match(input,148,FOLLOW_148_in_parExpression1968); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1971);
            	expression132 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression132.Tree);
            	char_literal133=(IToken)Match(input,149,FOLLOW_149_in_parExpression1973); if (state.failed) return retval;

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:395:1: leftValue : ( variable | selecting );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:396:2: ( variable | selecting )
            int alt34 = 2;
            switch ( input.LA(1) ) 
            {
            case Reference:
            	{
                alt34 = 1;
                }
                break;
            case Identifier:
            	{
                int LA34_2 = input.LA(2);

                if ( (LA34_2 == 145 || LA34_2 == 150) )
                {
                    alt34 = 2;
                }
                else if ( (LA34_2 == EOF || LA34_2 == Assign || (LA34_2 >= AssignAndAdd && LA34_2 <= Modulo) || (LA34_2 >= PlusPlus && LA34_2 <= MinusMinus) || LA34_2 == To || LA34_2 == 142 || (LA34_2 >= 146 && LA34_2 <= 147) || LA34_2 == 149) )
                {
                    alt34 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d34s2 =
                        new NoViableAltException("", 34, 2, input);

                    throw nvae_d34s2;
                }
                }
                break;
            case 148:
            	{
                alt34 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d34s0 =
            	        new NoViableAltException("", 34, 0, input);

            	    throw nvae_d34s0;
            }

            switch (alt34) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:396:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1988);
                    	variable134 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable134.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1993);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:400:1: variable : ( Reference )? Identifier -> ^( Identifier ( Reference )? ) ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference136 = null;
        IToken Identifier137 = null;

        CommonTree Reference136_tree=null;
        CommonTree Identifier137_tree=null;
        RewriteRuleTokenStream stream_Reference = new RewriteRuleTokenStream(adaptor,"token Reference");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:2: ( ( Reference )? Identifier -> ^( Identifier ( Reference )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:4: ( Reference )? Identifier
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:4: ( Reference )?
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == Reference) )
            	{
            	    alt35 = 1;
            	}
            	switch (alt35) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: Reference
            	        {
            	        	Reference136=(IToken)Match(input,Reference,FOLLOW_Reference_in_variable2004); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Reference.Add(Reference136);


            	        }
            	        break;

            	}

            	Identifier137=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable2007); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier137);



            	// AST REWRITE
            	// elements:          Identifier, Reference
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 401:26: -> ^( Identifier ( Reference )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:29: ^( Identifier ( Reference )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_Identifier.NextNode(), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:43: ( Reference )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:404:1: selecting : selector -> ^( SELECTOR selector ) ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.selector_return selector138 = default(PsimulexParser.selector_return);


        RewriteRuleSubtreeStream stream_selector = new RewriteRuleSubtreeStream(adaptor,"rule selector");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:2: ( selector -> ^( SELECTOR selector ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:4: selector
            {
            	PushFollow(FOLLOW_selector_in_selecting2029);
            	selector138 = selector();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_selector.Add(selector138.Tree);


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
            	// 405:13: -> ^( SELECTOR selector )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:16: ^( SELECTOR selector )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:408:1: selector : ( Identifier | parExpression ) ( memberSelect | memberFunctionCall | indexing )+ ;
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier139 = null;
        PsimulexParser.parExpression_return parExpression140 = default(PsimulexParser.parExpression_return);

        PsimulexParser.memberSelect_return memberSelect141 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall142 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing143 = default(PsimulexParser.indexing_return);


        CommonTree Identifier139_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:5: ( ( Identifier | parExpression ) ( memberSelect | memberFunctionCall | indexing )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:9: ( Identifier | parExpression ) ( memberSelect | memberFunctionCall | indexing )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:9: ( Identifier | parExpression )
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == Identifier) )
            	{
            	    alt36 = 1;
            	}
            	else if ( (LA36_0 == 148) )
            	{
            	    alt36 = 2;
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:11: Identifier
            	        {
            	        	Identifier139=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selector2057); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier139_tree = (CommonTree)adaptor.Create(Identifier139);
            	        		adaptor.AddChild(root_0, Identifier139_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:24: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selector2061);
            	        	parExpression140 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression140.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:40: ( memberSelect | memberFunctionCall | indexing )+
            	int cnt37 = 0;
            	do 
            	{
            	    int alt37 = 4;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == 150) )
            	    {
            	        int LA37_2 = input.LA(2);

            	        if ( (LA37_2 == Identifier) )
            	        {
            	            int LA37_4 = input.LA(3);

            	            if ( (LA37_4 == EOF || LA37_4 == Assign || (LA37_4 >= AssignAndAdd && LA37_4 <= Modulo) || (LA37_4 >= PlusPlus && LA37_4 <= MinusMinus) || LA37_4 == To || LA37_4 == 142 || (LA37_4 >= 145 && LA37_4 <= 147) || (LA37_4 >= 149 && LA37_4 <= 150)) )
            	            {
            	                alt37 = 1;
            	            }
            	            else if ( (LA37_4 == 148) )
            	            {
            	                alt37 = 2;
            	            }


            	        }


            	    }
            	    else if ( (LA37_0 == 145) )
            	    {
            	        alt37 = 3;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:41: memberSelect
            			    {
            			    	PushFollow(FOLLOW_memberSelect_in_selector2066);
            			    	memberSelect141 = memberSelect();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect141.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:56: memberFunctionCall
            			    {
            			    	PushFollow(FOLLOW_memberFunctionCall_in_selector2070);
            			    	memberFunctionCall142 = memberFunctionCall();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall142.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:77: indexing
            			    {
            			    	PushFollow(FOLLOW_indexing_in_selector2074);
            			    	indexing143 = indexing();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing143.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt37 >= 1 ) goto loop37;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(37, input);
            		            throw eee;
            	    }
            	    cnt37++;
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whinging that label 'loop37' has no statements


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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:412:1: memberSelect : '.' Identifier -> ^( MEMBER_SELECT Identifier ) ;
    public PsimulexParser.memberSelect_return memberSelect() // throws RecognitionException [1]
    {   
        PsimulexParser.memberSelect_return retval = new PsimulexParser.memberSelect_return();
        retval.Start = input.LT(1);
        int memberSelect_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal144 = null;
        IToken Identifier145 = null;

        CommonTree char_literal144_tree=null;
        CommonTree Identifier145_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:2: ( '.' Identifier -> ^( MEMBER_SELECT Identifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:4: '.' Identifier
            {
            	char_literal144=(IToken)Match(input,150,FOLLOW_150_in_memberSelect2090); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_150.Add(char_literal144);

            	Identifier145=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect2092); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier145);



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
            	// 413:19: -> ^( MEMBER_SELECT Identifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:22: ^( MEMBER_SELECT Identifier )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:416:1: memberFunctionCall : '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal146 = null;
        IToken Identifier147 = null;
        PsimulexParser.arguments_return arguments148 = default(PsimulexParser.arguments_return);


        CommonTree char_literal146_tree=null;
        CommonTree Identifier147_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:2: ( '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:4: '.' Identifier arguments
            {
            	char_literal146=(IToken)Match(input,150,FOLLOW_150_in_memberFunctionCall2113); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_150.Add(char_literal146);

            	Identifier147=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall2115); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier147);

            	PushFollow(FOLLOW_arguments_in_memberFunctionCall2117);
            	arguments148 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments148.Tree);


            	// AST REWRITE
            	// elements:          Identifier, arguments
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 417:29: -> ^( MEMBER_FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:32: ^( MEMBER_FUNCTION_CALL Identifier arguments )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:420:1: functionCall : Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.functionCall_return functionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.functionCall_return retval = new PsimulexParser.functionCall_return();
        retval.Start = input.LT(1);
        int functionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier149 = null;
        PsimulexParser.arguments_return arguments150 = default(PsimulexParser.arguments_return);


        CommonTree Identifier149_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:421:2: ( Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:421:4: Identifier arguments
            {
            	Identifier149=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionCall2140); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier149);

            	PushFollow(FOLLOW_arguments_in_functionCall2142);
            	arguments150 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments150.Tree);


            	// AST REWRITE
            	// elements:          Identifier, arguments
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 421:25: -> ^( FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:421:28: ^( FUNCTION_CALL Identifier arguments )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:1: indexing : '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) ;
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal151 = null;
        IToken char_literal153 = null;
        IToken char_literal155 = null;
        PsimulexParser.expression_return expression152 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression154 = default(PsimulexParser.expression_return);


        CommonTree char_literal151_tree=null;
        CommonTree char_literal153_tree=null;
        CommonTree char_literal155_tree=null;
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:2: ( '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:4: '[' expression ( ',' expression )* ']'
            {
            	char_literal151=(IToken)Match(input,145,FOLLOW_145_in_indexing2166); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal151);

            	PushFollow(FOLLOW_expression_in_indexing2168);
            	expression152 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression152.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:19: ( ',' expression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 146) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:21: ',' expression
            			    {
            			    	char_literal153=(IToken)Match(input,146,FOLLOW_146_in_indexing2172); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_146.Add(char_literal153);

            			    	PushFollow(FOLLOW_expression_in_indexing2174);
            			    	expression154 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_expression.Add(expression154.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements

            	char_literal155=(IToken)Match(input,147,FOLLOW_147_in_indexing2179); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_147.Add(char_literal155);



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
            	// 426:43: -> ^( INDEXING expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:46: ^( INDEXING expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(INDEXING, "INDEXING"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:69: ( expression )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:429:1: arguments : '(' ( expression ( ',' expression )* )? ')' -> ^( ARGUMENTS ( expression ( expression )* )? ) ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal156 = null;
        IToken char_literal158 = null;
        IToken char_literal160 = null;
        PsimulexParser.expression_return expression157 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression159 = default(PsimulexParser.expression_return);


        CommonTree char_literal156_tree=null;
        CommonTree char_literal158_tree=null;
        CommonTree char_literal160_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:5: ( '(' ( expression ( ',' expression )* )? ')' -> ^( ARGUMENTS ( expression ( expression )* )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:9: '(' ( expression ( ',' expression )* )? ')'
            {
            	char_literal156=(IToken)Match(input,148,FOLLOW_148_in_arguments2213); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal156);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:13: ( expression ( ',' expression )* )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == StringLiteral || LA40_0 == Identifier || (LA40_0 >= IntegerLiteral && LA40_0 <= Reference) || LA40_0 == Minus || (LA40_0 >= LogicalNot && LA40_0 <= InfinityLiteral) || LA40_0 == 148) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:15: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_arguments2217);
            	        	expression157 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_expression.Add(expression157.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:26: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt39 = 2;
            	        	    int LA39_0 = input.LA(1);

            	        	    if ( (LA39_0 == 146) )
            	        	    {
            	        	        alt39 = 1;
            	        	    }


            	        	    switch (alt39) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:27: ',' expression
            	        			    {
            	        			    	char_literal158=(IToken)Match(input,146,FOLLOW_146_in_arguments2220); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_146.Add(char_literal158);

            	        			    	PushFollow(FOLLOW_expression_in_arguments2222);
            	        			    	expression159 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_expression.Add(expression159.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop39;
            	        	    }
            	        	} while (true);

            	        	loop39:
            	        		;	// Stops C# compiler whining that label 'loop39' has no statements


            	        }
            	        break;

            	}

            	char_literal160=(IToken)Match(input,149,FOLLOW_149_in_arguments2229); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_149.Add(char_literal160);



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
            	// 430:51: -> ^( ARGUMENTS ( expression ( expression )* )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:54: ^( ARGUMENTS ( expression ( expression )* )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ARGUMENTS, "ARGUMENTS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:67: ( expression ( expression )* )?
            	    if ( stream_expression.HasNext() || stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:80: ( expression )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:433:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
    public PsimulexParser.literal_return literal() // throws RecognitionException [1]
    {   
        PsimulexParser.literal_return retval = new PsimulexParser.literal_return();
        retval.Start = input.LT(1);
        int literal_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set161 = null;

        CommonTree set161_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 66) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:434:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set161 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || input.LA(1) == IntegerLiteral || (input.LA(1) >= DecimalLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set161));
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:481:1: block : '{' ( statement )* '}' -> ^( BLOCK ( ^( STATEMENT statement ) )* ) ;
    public PsimulexParser.block_return block() // throws RecognitionException [1]
    {   
        PsimulexParser.block_return retval = new PsimulexParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal162 = null;
        IToken char_literal164 = null;
        PsimulexParser.statement_return statement163 = default(PsimulexParser.statement_return);


        CommonTree char_literal162_tree=null;
        CommonTree char_literal164_tree=null;
        RewriteRuleTokenStream stream_143 = new RewriteRuleTokenStream(adaptor,"token 143");
        RewriteRuleTokenStream stream_144 = new RewriteRuleTokenStream(adaptor,"token 144");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 67) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:5: ( '{' ( statement )* '}' -> ^( BLOCK ( ^( STATEMENT statement ) )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:9: '{' ( statement )* '}'
            {
            	char_literal162=(IToken)Match(input,143,FOLLOW_143_in_block2362); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_143.Add(char_literal162);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:13: ( statement )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == StringLiteral || LA41_0 == Identifier || (LA41_0 >= IntegerLiteral && LA41_0 <= Iterator) || LA41_0 == Minus || (LA41_0 >= LogicalNot && LA41_0 <= If) || (LA41_0 >= For && LA41_0 <= ForEach) || LA41_0 == Loop || LA41_0 == 142 || LA41_0 == 148) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block2364);
            			    	statement163 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_statement.Add(statement163.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	char_literal164=(IToken)Match(input,144,FOLLOW_144_in_block2367); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_144.Add(char_literal164);



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
            	// 482:28: -> ^( BLOCK ( ^( STATEMENT statement ) )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:31: ^( BLOCK ( ^( STATEMENT statement ) )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:40: ( ^( STATEMENT statement ) )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:482:40: ^( STATEMENT statement )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:485:1: branch : ( block | statement );
    public PsimulexParser.branch_return branch() // throws RecognitionException [1]
    {   
        PsimulexParser.branch_return retval = new PsimulexParser.branch_return();
        retval.Start = input.LT(1);
        int branch_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.block_return block165 = default(PsimulexParser.block_return);

        PsimulexParser.statement_return statement166 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 68) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:486:5: ( block | statement )
            int alt42 = 2;
            int LA42_0 = input.LA(1);

            if ( (LA42_0 == 143) )
            {
                alt42 = 1;
            }
            else if ( (LA42_0 == StringLiteral || LA42_0 == Identifier || (LA42_0 >= IntegerLiteral && LA42_0 <= Iterator) || LA42_0 == Minus || (LA42_0 >= LogicalNot && LA42_0 <= If) || (LA42_0 >= For && LA42_0 <= ForEach) || LA42_0 == Loop || LA42_0 == 142 || LA42_0 == 148) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:486:7: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch2409);
                    	block165 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block165.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:486:15: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_branch2413);
                    	statement166 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement166.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:489:1: statement : ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN_STATEMENT Return ( expression )? ) | Break ';' | ';' | expression ';' -> ^( EXPRESSION_STATEMENT expression ) | localVariableDeclaration ';' -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration ) );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PDo175 = null;
        IToken Async177 = null;
        IToken Lock179 = null;
        IToken char_literal180 = null;
        IToken Identifier181 = null;
        IToken char_literal182 = null;
        IToken Return184 = null;
        IToken char_literal186 = null;
        IToken Break187 = null;
        IToken char_literal188 = null;
        IToken char_literal189 = null;
        IToken char_literal191 = null;
        IToken char_literal193 = null;
        PsimulexParser.ifStatement_return ifStatement167 = default(PsimulexParser.ifStatement_return);

        PsimulexParser.forStatement_return forStatement168 = default(PsimulexParser.forStatement_return);

        PsimulexParser.pForStatement_return pForStatement169 = default(PsimulexParser.pForStatement_return);

        PsimulexParser.forEachStatement_return forEachStatement170 = default(PsimulexParser.forEachStatement_return);

        PsimulexParser.pForEachStatement_return pForEachStatement171 = default(PsimulexParser.pForEachStatement_return);

        PsimulexParser.loopStatement_return loopStatement172 = default(PsimulexParser.loopStatement_return);

        PsimulexParser.whileStatement_return whileStatement173 = default(PsimulexParser.whileStatement_return);

        PsimulexParser.doStatement_return doStatement174 = default(PsimulexParser.doStatement_return);

        PsimulexParser.block_return block176 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block178 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block183 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression185 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression190 = default(PsimulexParser.expression_return);

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration192 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree PDo175_tree=null;
        CommonTree Async177_tree=null;
        CommonTree Lock179_tree=null;
        CommonTree char_literal180_tree=null;
        CommonTree Identifier181_tree=null;
        CommonTree char_literal182_tree=null;
        CommonTree Return184_tree=null;
        CommonTree char_literal186_tree=null;
        CommonTree Break187_tree=null;
        CommonTree char_literal188_tree=null;
        CommonTree char_literal189_tree=null;
        CommonTree char_literal191_tree=null;
        CommonTree char_literal193_tree=null;
        RewriteRuleTokenStream stream_Async = new RewriteRuleTokenStream(adaptor,"token Async");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_Return = new RewriteRuleTokenStream(adaptor,"token Return");
        RewriteRuleTokenStream stream_Lock = new RewriteRuleTokenStream(adaptor,"token Lock");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleTokenStream stream_PDo = new RewriteRuleTokenStream(adaptor,"token PDo");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_localVariableDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule localVariableDeclaration");
        RewriteRuleSubtreeStream stream_ifStatement = new RewriteRuleSubtreeStream(adaptor,"rule ifStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 69) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:490:5: ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN_STATEMENT Return ( expression )? ) | Break ';' | ';' | expression ';' -> ^( EXPRESSION_STATEMENT expression ) | localVariableDeclaration ';' -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration ) )
            int alt46 = 14;
            alt46 = dfa46.Predict(input);
            switch (alt46) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:490:7: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement2430);
                    	ifStatement167 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_ifStatement.Add(ifStatement167.Tree);


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
                    	// 490:19: -> ^( IFSTATEMENT ifStatement )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:490:22: ^( IFSTATEMENT ifStatement )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:491:7: ( forStatement | pForStatement )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:491:7: ( forStatement | pForStatement )
                    	int alt43 = 2;
                    	int LA43_0 = input.LA(1);

                    	if ( (LA43_0 == For) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == PFor) )
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
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:491:9: forStatement
                    	        {
                    	        	PushFollow(FOLLOW_forStatement_in_statement2450);
                    	        	forStatement168 = forStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatement168.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:491:24: pForStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForStatement_in_statement2454);
                    	        	pForStatement169 = pForStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForStatement169.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:492:9: ( forEachStatement | pForEachStatement )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:492:9: ( forEachStatement | pForEachStatement )
                    	int alt44 = 2;
                    	int LA44_0 = input.LA(1);

                    	if ( (LA44_0 == ForEach) )
                    	{
                    	    alt44 = 1;
                    	}
                    	else if ( (LA44_0 == PForEach) )
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
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:492:11: forEachStatement
                    	        {
                    	        	PushFollow(FOLLOW_forEachStatement_in_statement2468);
                    	        	forEachStatement170 = forEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachStatement170.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:492:30: pForEachStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForEachStatement_in_statement2472);
                    	        	pForEachStatement171 = pForEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForEachStatement171.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:493:9: loopStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_loopStatement_in_statement2484);
                    	loopStatement172 = loopStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopStatement172.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:494:9: whileStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileStatement_in_statement2494);
                    	whileStatement173 = whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileStatement173.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:495:9: doStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doStatement_in_statement2504);
                    	doStatement174 = doStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, doStatement174.Tree);

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:496:9: PDo block
                    {
                    	PDo175=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement2517); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_PDo.Add(PDo175);

                    	PushFollow(FOLLOW_block_in_statement2519);
                    	block176 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block176.Tree);


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
                    	// 496:19: -> ^( PDOSTATEMENT block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:496:22: ^( PDOSTATEMENT block )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:9: Async block
                    {
                    	Async177=(IToken)Match(input,Async,FOLLOW_Async_in_statement2548); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Async.Add(Async177);

                    	PushFollow(FOLLOW_block_in_statement2550);
                    	block178 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block178.Tree);


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
                    	// 497:21: -> ^( ASYNCSTATEMENT block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:24: ^( ASYNCSTATEMENT block )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:498:9: Lock '(' Identifier ')' block
                    {
                    	Lock179=(IToken)Match(input,Lock,FOLLOW_Lock_in_statement2578); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Lock.Add(Lock179);

                    	char_literal180=(IToken)Match(input,148,FOLLOW_148_in_statement2580); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_148.Add(char_literal180);

                    	Identifier181=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_statement2582); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier181);

                    	char_literal182=(IToken)Match(input,149,FOLLOW_149_in_statement2584); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_149.Add(char_literal182);

                    	PushFollow(FOLLOW_block_in_statement2586);
                    	block183 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block183.Tree);


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
                    	// 498:39: -> ^( LOCKSTATEMENT Identifier block )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:498:42: ^( LOCKSTATEMENT Identifier block )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:499:9: Return ( expression )? ';'
                    {
                    	Return184=(IToken)Match(input,Return,FOLLOW_Return_in_statement2609); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Return.Add(Return184);

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:499:16: ( expression )?
                    	int alt45 = 2;
                    	int LA45_0 = input.LA(1);

                    	if ( (LA45_0 == StringLiteral || LA45_0 == Identifier || (LA45_0 >= IntegerLiteral && LA45_0 <= Reference) || LA45_0 == Minus || (LA45_0 >= LogicalNot && LA45_0 <= InfinityLiteral) || LA45_0 == 148) )
                    	{
                    	    alt45 = 1;
                    	}
                    	switch (alt45) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement2611);
                    	        	expression185 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) stream_expression.Add(expression185.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal186=(IToken)Match(input,142,FOLLOW_142_in_statement2614); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_142.Add(char_literal186);



                    	// AST REWRITE
                    	// elements:          expression, Return
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 499:32: -> ^( RETURN_STATEMENT Return ( expression )? )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:499:35: ^( RETURN_STATEMENT Return ( expression )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RETURN_STATEMENT, "RETURN_STATEMENT"), root_1);

                    	    adaptor.AddChild(root_1, stream_Return.NextNode());
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:499:62: ( expression )?
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:500:9: Break ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Break187=(IToken)Match(input,Break,FOLLOW_Break_in_statement2637); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break187_tree = (CommonTree)adaptor.Create(Break187);
                    		adaptor.AddChild(root_0, Break187_tree);
                    	}
                    	char_literal188=(IToken)Match(input,142,FOLLOW_142_in_statement2639); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:502:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal189=(IToken)Match(input,142,FOLLOW_142_in_statement2651); if (state.failed) return retval;

                    }
                    break;
                case 13 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:9: expression ';'
                    {
                    	PushFollow(FOLLOW_expression_in_statement2662);
                    	expression190 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_expression.Add(expression190.Tree);
                    	char_literal191=(IToken)Match(input,142,FOLLOW_142_in_statement2664); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_142.Add(char_literal191);



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
                    	// 503:24: -> ^( EXPRESSION_STATEMENT expression )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:27: ^( EXPRESSION_STATEMENT expression )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:504:7: localVariableDeclaration ';'
                    {
                    	PushFollow(FOLLOW_localVariableDeclaration_in_statement2682);
                    	localVariableDeclaration192 = localVariableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_localVariableDeclaration.Add(localVariableDeclaration192.Tree);
                    	char_literal193=(IToken)Match(input,142,FOLLOW_142_in_statement2684); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_142.Add(char_literal193);



                    	// AST REWRITE
                    	// elements:          localVariableDeclaration
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 504:36: -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:504:39: ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:1: ifStatement : ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? ) ;
    public PsimulexParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.ifStatement_return retval = new PsimulexParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.ifBranch_return ifBranch194 = default(PsimulexParser.ifBranch_return);

        PsimulexParser.elseIfBranches_return elseIfBranches195 = default(PsimulexParser.elseIfBranches_return);

        PsimulexParser.elseBranch_return elseBranch196 = default(PsimulexParser.elseBranch_return);

        PsimulexParser.elseBranch_return elseBranch197 = default(PsimulexParser.elseBranch_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 70) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:15: ( ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:17: ifBranch ( ( elseIfBranches elseBranch ) | ( elseBranch )? )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_ifBranch_in_ifStatement2713);
            	ifBranch194 = ifBranch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifBranch194.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:26: ( ( elseIfBranches elseBranch ) | ( elseBranch )? )
            	int alt48 = 2;
            	switch ( input.LA(1) ) 
            	{
            	case ElseIf:
            		{
            	    int LA48_1 = input.LA(2);

            	    if ( (synpred104_Psimulex()) )
            	    {
            	        alt48 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt48 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d48s1 =
            	            new NoViableAltException("", 48, 1, input);

            	        throw nvae_d48s1;
            	    }
            	    }
            	    break;
            	case Else:
            		{
            	    int LA48_2 = input.LA(2);

            	    if ( (synpred104_Psimulex()) )
            	    {
            	        alt48 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt48 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d48s2 =
            	            new NoViableAltException("", 48, 2, input);

            	        throw nvae_d48s2;
            	    }
            	    }
            	    break;
            	case EOF:
            	case StringLiteral:
            	case Identifier:
            	case IntegerLiteral:
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
            	case 142:
            	case 144:
            	case 148:
            		{
            	    alt48 = 2;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d48s0 =
            		        new NoViableAltException("", 48, 0, input);

            		    throw nvae_d48s0;
            	}

            	switch (alt48) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:28: ( elseIfBranches elseBranch )
            	        {
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:28: ( elseIfBranches elseBranch )
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:30: elseIfBranches elseBranch
            	        	{
            	        		PushFollow(FOLLOW_elseIfBranches_in_ifStatement2719);
            	        		elseIfBranches195 = elseIfBranches();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseIfBranches195.Tree);
            	        		PushFollow(FOLLOW_elseBranch_in_ifStatement2721);
            	        		elseBranch196 = elseBranch();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch196.Tree);

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:60: ( elseBranch )?
            	        {
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:60: ( elseBranch )?
            	        	int alt47 = 2;
            	        	int LA47_0 = input.LA(1);

            	        	if ( (LA47_0 == Else) )
            	        	{
            	        	    int LA47_1 = input.LA(2);

            	        	    if ( (synpred105_Psimulex()) )
            	        	    {
            	        	        alt47 = 1;
            	        	    }
            	        	}
            	        	switch (alt47) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: elseBranch
            	        	        {
            	        	        	PushFollow(FOLLOW_elseBranch_in_ifStatement2727);
            	        	        	elseBranch197 = elseBranch();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch197.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:1: ifBranch : If condition core -> ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) ) ;
    public PsimulexParser.ifBranch_return ifBranch() // throws RecognitionException [1]
    {   
        PsimulexParser.ifBranch_return retval = new PsimulexParser.ifBranch_return();
        retval.Start = input.LT(1);
        int ifBranch_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken If198 = null;
        PsimulexParser.condition_return condition199 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core200 = default(PsimulexParser.core_return);


        CommonTree If198_tree=null;
        RewriteRuleTokenStream stream_If = new RewriteRuleTokenStream(adaptor,"token If");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 71) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:12: ( If condition core -> ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:14: If condition core
            {
            	If198=(IToken)Match(input,If,FOLLOW_If_in_ifBranch2739); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_If.Add(If198);

            	PushFollow(FOLLOW_condition_in_ifBranch2741);
            	condition199 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition199.Tree);
            	PushFollow(FOLLOW_core_in_ifBranch2743);
            	core200 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core200.Tree);


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
            	// 508:32: -> ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:35: ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IFBRANCH, "IFBRANCH"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:47: ^( CONDITIONALBRANCH condition core )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:1: elseIfBranches : ( ElseIf condition core )* -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* ) ;
    public PsimulexParser.elseIfBranches_return elseIfBranches() // throws RecognitionException [1]
    {   
        PsimulexParser.elseIfBranches_return retval = new PsimulexParser.elseIfBranches_return();
        retval.Start = input.LT(1);
        int elseIfBranches_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken ElseIf201 = null;
        PsimulexParser.condition_return condition202 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core203 = default(PsimulexParser.core_return);


        CommonTree ElseIf201_tree=null;
        RewriteRuleTokenStream stream_ElseIf = new RewriteRuleTokenStream(adaptor,"token ElseIf");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 72) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:17: ( ( ElseIf condition core )* -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:19: ( ElseIf condition core )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:19: ( ElseIf condition core )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( (LA49_0 == ElseIf) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:21: ElseIf condition core
            			    {
            			    	ElseIf201=(IToken)Match(input,ElseIf,FOLLOW_ElseIf_in_elseIfBranches2771); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_ElseIf.Add(ElseIf201);

            			    	PushFollow(FOLLOW_condition_in_elseIfBranches2773);
            			    	condition202 = condition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_condition.Add(condition202.Tree);
            			    	PushFollow(FOLLOW_core_in_elseIfBranches2775);
            			    	core203 = core();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_core.Add(core203.Tree);

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements



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
            	// 509:46: -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:49: ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ELSEIFBRANCHES, "ELSEIFBRANCHES"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:67: ( ^( CONDITIONALBRANCH condition core ) )*
            	    while ( stream_condition.HasNext() || stream_core.HasNext() )
            	    {
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:69: ^( CONDITIONALBRANCH condition core )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CONDITIONALBRANCH, "CONDITIONALBRANCH"), root_2);

            	        adaptor.AddChild(root_2, stream_condition.NextTree());
            	        adaptor.AddChild(root_2, stream_core.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_condition.Reset();
            	    stream_core.Reset();

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:1: elseBranch : Else core -> ^( ELSEBRANCH core ) ;
    public PsimulexParser.elseBranch_return elseBranch() // throws RecognitionException [1]
    {   
        PsimulexParser.elseBranch_return retval = new PsimulexParser.elseBranch_return();
        retval.Start = input.LT(1);
        int elseBranch_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Else204 = null;
        PsimulexParser.core_return core205 = default(PsimulexParser.core_return);


        CommonTree Else204_tree=null;
        RewriteRuleTokenStream stream_Else = new RewriteRuleTokenStream(adaptor,"token Else");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 73) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:14: ( Else core -> ^( ELSEBRANCH core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:16: Else core
            {
            	Else204=(IToken)Match(input,Else,FOLLOW_Else_in_elseBranch2810); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Else.Add(Else204);

            	PushFollow(FOLLOW_core_in_elseBranch2812);
            	core205 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core205.Tree);


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
            	// 510:26: -> ^( ELSEBRANCH core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:29: ^( ELSEBRANCH core )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:1: forStatement : For '(' forControl ')' core -> ^( FORSTATEMENT forControl core ) ;
    public PsimulexParser.forStatement_return forStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.forStatement_return retval = new PsimulexParser.forStatement_return();
        retval.Start = input.LT(1);
        int forStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken For206 = null;
        IToken char_literal207 = null;
        IToken char_literal209 = null;
        PsimulexParser.forControl_return forControl208 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core210 = default(PsimulexParser.core_return);


        CommonTree For206_tree=null;
        CommonTree char_literal207_tree=null;
        CommonTree char_literal209_tree=null;
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_For = new RewriteRuleTokenStream(adaptor,"token For");
        RewriteRuleSubtreeStream stream_forControl = new RewriteRuleSubtreeStream(adaptor,"rule forControl");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 74) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:15: ( For '(' forControl ')' core -> ^( FORSTATEMENT forControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:17: For '(' forControl ')' core
            {
            	For206=(IToken)Match(input,For,FOLLOW_For_in_forStatement2830); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_For.Add(For206);

            	char_literal207=(IToken)Match(input,148,FOLLOW_148_in_forStatement2832); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal207);

            	PushFollow(FOLLOW_forControl_in_forStatement2834);
            	forControl208 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forControl.Add(forControl208.Tree);
            	char_literal209=(IToken)Match(input,149,FOLLOW_149_in_forStatement2836); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_149.Add(char_literal209);

            	PushFollow(FOLLOW_core_in_forStatement2838);
            	core210 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core210.Tree);


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
            	// 512:45: -> ^( FORSTATEMENT forControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:512:48: ^( FORSTATEMENT forControl core )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:1: pForStatement : PFor '(' forControl ')' core -> ^( PFORSTATEMENT forControl core ) ;
    public PsimulexParser.pForStatement_return pForStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.pForStatement_return retval = new PsimulexParser.pForStatement_return();
        retval.Start = input.LT(1);
        int pForStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PFor211 = null;
        IToken char_literal212 = null;
        IToken char_literal214 = null;
        PsimulexParser.forControl_return forControl213 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core215 = default(PsimulexParser.core_return);


        CommonTree PFor211_tree=null;
        CommonTree char_literal212_tree=null;
        CommonTree char_literal214_tree=null;
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_PFor = new RewriteRuleTokenStream(adaptor,"token PFor");
        RewriteRuleSubtreeStream stream_forControl = new RewriteRuleSubtreeStream(adaptor,"rule forControl");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 75) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:16: ( PFor '(' forControl ')' core -> ^( PFORSTATEMENT forControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:18: PFor '(' forControl ')' core
            {
            	PFor211=(IToken)Match(input,PFor,FOLLOW_PFor_in_pForStatement2858); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_PFor.Add(PFor211);

            	char_literal212=(IToken)Match(input,148,FOLLOW_148_in_pForStatement2860); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal212);

            	PushFollow(FOLLOW_forControl_in_pForStatement2862);
            	forControl213 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forControl.Add(forControl213.Tree);
            	char_literal214=(IToken)Match(input,149,FOLLOW_149_in_pForStatement2864); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_149.Add(char_literal214);

            	PushFollow(FOLLOW_core_in_pForStatement2866);
            	core215 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core215.Tree);


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
            	// 513:47: -> ^( PFORSTATEMENT forControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:513:50: ^( PFORSTATEMENT forControl core )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:1: forControl : ( forInit )? ';' ( forCondition )? ';' ( forUpdate )? -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? ) ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal217 = null;
        IToken char_literal219 = null;
        PsimulexParser.forInit_return forInit216 = default(PsimulexParser.forInit_return);

        PsimulexParser.forCondition_return forCondition218 = default(PsimulexParser.forCondition_return);

        PsimulexParser.forUpdate_return forUpdate220 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal217_tree=null;
        CommonTree char_literal219_tree=null;
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleSubtreeStream stream_forCondition = new RewriteRuleSubtreeStream(adaptor,"rule forCondition");
        RewriteRuleSubtreeStream stream_forInit = new RewriteRuleSubtreeStream(adaptor,"rule forInit");
        RewriteRuleSubtreeStream stream_forUpdate = new RewriteRuleSubtreeStream(adaptor,"rule forUpdate");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 76) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:14: ( ( forInit )? ';' ( forCondition )? ';' ( forUpdate )? -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:16: ( forInit )? ';' ( forCondition )? ';' ( forUpdate )?
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:16: ( forInit )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == Identifier || (LA50_0 >= Bool && LA50_0 <= Iterator)) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl2887);
            	        	forInit216 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forInit.Add(forInit216.Tree);

            	        }
            	        break;

            	}

            	char_literal217=(IToken)Match(input,142,FOLLOW_142_in_forControl2890); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal217);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:29: ( forCondition )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == StringLiteral || LA51_0 == Identifier || (LA51_0 >= IntegerLiteral && LA51_0 <= Reference) || LA51_0 == Minus || (LA51_0 >= LogicalNot && LA51_0 <= InfinityLiteral) || LA51_0 == 148) )
            	{
            	    alt51 = 1;
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forCondition
            	        {
            	        	PushFollow(FOLLOW_forCondition_in_forControl2892);
            	        	forCondition218 = forCondition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forCondition.Add(forCondition218.Tree);

            	        }
            	        break;

            	}

            	char_literal219=(IToken)Match(input,142,FOLLOW_142_in_forControl2895); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal219);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:47: ( forUpdate )?
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( (LA52_0 == StringLiteral || LA52_0 == Identifier || (LA52_0 >= IntegerLiteral && LA52_0 <= Reference) || LA52_0 == Minus || (LA52_0 >= LogicalNot && LA52_0 <= InfinityLiteral) || LA52_0 == 148) )
            	{
            	    alt52 = 1;
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl2897);
            	        	forUpdate220 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forUpdate.Add(forUpdate220.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          forInit, forUpdate, forCondition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 514:58: -> ^( FORINIT ( forInit )? ) ^( FORCONDITION ( forCondition )? ) ^( FORUPDATE ( forUpdate )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:61: ^( FORINIT ( forInit )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORINIT, "FORINIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:72: ( forInit )?
            	    if ( stream_forInit.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_forInit.NextTree());

            	    }
            	    stream_forInit.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:83: ^( FORCONDITION ( forCondition )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORCONDITION, "FORCONDITION"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:99: ( forCondition )?
            	    if ( stream_forCondition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_forCondition.NextTree());

            	    }
            	    stream_forCondition.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:115: ^( FORUPDATE ( forUpdate )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORUPDATE, "FORUPDATE"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:128: ( forUpdate )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration221 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 77) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:12: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:515:16: localVariableDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit2939);
            	localVariableDeclaration221 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration221.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:516:1: forCondition : expression ;
    public PsimulexParser.forCondition_return forCondition() // throws RecognitionException [1]
    {   
        PsimulexParser.forCondition_return retval = new PsimulexParser.forCondition_return();
        retval.Start = input.LT(1);
        int forCondition_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression222 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 78) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:516:15: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:516:19: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forCondition2949);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression223 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 79) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:13: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:17: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate2960);
            	expression223 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression223.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:1: whileStatement : While condition core -> ^( WHILESTATEMENT condition core ) ;
    public PsimulexParser.whileStatement_return whileStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.whileStatement_return retval = new PsimulexParser.whileStatement_return();
        retval.Start = input.LT(1);
        int whileStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken While224 = null;
        PsimulexParser.condition_return condition225 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core226 = default(PsimulexParser.core_return);


        CommonTree While224_tree=null;
        RewriteRuleTokenStream stream_While = new RewriteRuleTokenStream(adaptor,"token While");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 80) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:17: ( While condition core -> ^( WHILESTATEMENT condition core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:19: While condition core
            {
            	While224=(IToken)Match(input,While,FOLLOW_While_in_whileStatement2969); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_While.Add(While224);

            	PushFollow(FOLLOW_condition_in_whileStatement2971);
            	condition225 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition225.Tree);
            	PushFollow(FOLLOW_core_in_whileStatement2973);
            	core226 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core226.Tree);


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
            	// 519:40: -> ^( WHILESTATEMENT condition core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:519:43: ^( WHILESTATEMENT condition core )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:521:1: doStatement : Do core While condition ';' -> ^( DOSTATEMENT core condition ) ;
    public PsimulexParser.doStatement_return doStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.doStatement_return retval = new PsimulexParser.doStatement_return();
        retval.Start = input.LT(1);
        int doStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Do227 = null;
        IToken While229 = null;
        IToken char_literal231 = null;
        PsimulexParser.core_return core228 = default(PsimulexParser.core_return);

        PsimulexParser.condition_return condition230 = default(PsimulexParser.condition_return);


        CommonTree Do227_tree=null;
        CommonTree While229_tree=null;
        CommonTree char_literal231_tree=null;
        RewriteRuleTokenStream stream_Do = new RewriteRuleTokenStream(adaptor,"token Do");
        RewriteRuleTokenStream stream_While = new RewriteRuleTokenStream(adaptor,"token While");
        RewriteRuleTokenStream stream_142 = new RewriteRuleTokenStream(adaptor,"token 142");
        RewriteRuleSubtreeStream stream_condition = new RewriteRuleSubtreeStream(adaptor,"rule condition");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 81) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:521:15: ( Do core While condition ';' -> ^( DOSTATEMENT core condition ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:521:17: Do core While condition ';'
            {
            	Do227=(IToken)Match(input,Do,FOLLOW_Do_in_doStatement2995); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Do.Add(Do227);

            	PushFollow(FOLLOW_core_in_doStatement2997);
            	core228 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core228.Tree);
            	While229=(IToken)Match(input,While,FOLLOW_While_in_doStatement2999); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_While.Add(While229);

            	PushFollow(FOLLOW_condition_in_doStatement3001);
            	condition230 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition230.Tree);
            	char_literal231=(IToken)Match(input,142,FOLLOW_142_in_doStatement3003); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_142.Add(char_literal231);



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
            	// 521:45: -> ^( DOSTATEMENT core condition )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:521:48: ^( DOSTATEMENT core condition )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:523:1: pForEachStatement : PForEach forEachTrailer -> ^( PFOREACHSTATEMENT forEachTrailer ) ;
    public PsimulexParser.pForEachStatement_return pForEachStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.pForEachStatement_return retval = new PsimulexParser.pForEachStatement_return();
        retval.Start = input.LT(1);
        int pForEachStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken PForEach232 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer233 = default(PsimulexParser.forEachTrailer_return);


        CommonTree PForEach232_tree=null;
        RewriteRuleTokenStream stream_PForEach = new RewriteRuleTokenStream(adaptor,"token PForEach");
        RewriteRuleSubtreeStream stream_forEachTrailer = new RewriteRuleSubtreeStream(adaptor,"rule forEachTrailer");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 82) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:523:19: ( PForEach forEachTrailer -> ^( PFOREACHSTATEMENT forEachTrailer ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:523:21: PForEach forEachTrailer
            {
            	PForEach232=(IToken)Match(input,PForEach,FOLLOW_PForEach_in_pForEachStatement3023); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_PForEach.Add(PForEach232);

            	PushFollow(FOLLOW_forEachTrailer_in_pForEachStatement3025);
            	forEachTrailer233 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forEachTrailer.Add(forEachTrailer233.Tree);


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
            	// 523:45: -> ^( PFOREACHSTATEMENT forEachTrailer )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:523:48: ^( PFOREACHSTATEMENT forEachTrailer )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:1: forEachStatement : ForEach forEachTrailer -> ^( FOREACHSTATEMENT forEachTrailer ) ;
    public PsimulexParser.forEachStatement_return forEachStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachStatement_return retval = new PsimulexParser.forEachStatement_return();
        retval.Start = input.LT(1);
        int forEachStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken ForEach234 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer235 = default(PsimulexParser.forEachTrailer_return);


        CommonTree ForEach234_tree=null;
        RewriteRuleTokenStream stream_ForEach = new RewriteRuleTokenStream(adaptor,"token ForEach");
        RewriteRuleSubtreeStream stream_forEachTrailer = new RewriteRuleSubtreeStream(adaptor,"rule forEachTrailer");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 83) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:18: ( ForEach forEachTrailer -> ^( FOREACHSTATEMENT forEachTrailer ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:20: ForEach forEachTrailer
            {
            	ForEach234=(IToken)Match(input,ForEach,FOLLOW_ForEach_in_forEachStatement3042); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_ForEach.Add(ForEach234);

            	PushFollow(FOLLOW_forEachTrailer_in_forEachStatement3044);
            	forEachTrailer235 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forEachTrailer.Add(forEachTrailer235.Tree);


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
            	// 524:43: -> ^( FOREACHSTATEMENT forEachTrailer )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:46: ^( FOREACHSTATEMENT forEachTrailer )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:525:1: forEachTrailer : '(' forEachControl ')' core ;
    public PsimulexParser.forEachTrailer_return forEachTrailer() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachTrailer_return retval = new PsimulexParser.forEachTrailer_return();
        retval.Start = input.LT(1);
        int forEachTrailer_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal236 = null;
        IToken char_literal238 = null;
        PsimulexParser.forEachControl_return forEachControl237 = default(PsimulexParser.forEachControl_return);

        PsimulexParser.core_return core239 = default(PsimulexParser.core_return);


        CommonTree char_literal236_tree=null;
        CommonTree char_literal238_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 84) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:525:17: ( '(' forEachControl ')' core )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:525:19: '(' forEachControl ')' core
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal236=(IToken)Match(input,148,FOLLOW_148_in_forEachTrailer3062); if (state.failed) return retval;
            	PushFollow(FOLLOW_forEachControl_in_forEachTrailer3065);
            	forEachControl237 = forEachControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachControl237.Tree);
            	char_literal238=(IToken)Match(input,149,FOLLOW_149_in_forEachTrailer3067); if (state.failed) return retval;
            	PushFollow(FOLLOW_core_in_forEachTrailer3070);
            	core239 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, core239.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:526:1: forEachControl options {k=3; } : type Identifier In expression -> ^( FOREACHINIT type Identifier ) ^( FOREACHCOLLECTION expression ) ;
    public PsimulexParser.forEachControl_return forEachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forEachControl_return retval = new PsimulexParser.forEachControl_return();
        retval.Start = input.LT(1);
        int forEachControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier241 = null;
        IToken In242 = null;
        PsimulexParser.type_return type240 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression243 = default(PsimulexParser.expression_return);


        CommonTree Identifier241_tree=null;
        CommonTree In242_tree=null;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:527:9: ( type Identifier In expression -> ^( FOREACHINIT type Identifier ) ^( FOREACHCOLLECTION expression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:527:13: type Identifier In expression
            {
            	PushFollow(FOLLOW_type_in_forEachControl3099);
            	type240 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type240.Tree);
            	Identifier241=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_forEachControl3101); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier241);

            	In242=(IToken)Match(input,In,FOLLOW_In_in_forEachControl3103); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_In.Add(In242);

            	PushFollow(FOLLOW_expression_in_forEachControl3105);
            	expression243 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression243.Tree);


            	// AST REWRITE
            	// elements:          Identifier, expression, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 527:43: -> ^( FOREACHINIT type Identifier ) ^( FOREACHCOLLECTION expression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:527:46: ^( FOREACHINIT type Identifier )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FOREACHINIT, "FOREACHINIT"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:527:80: ^( FOREACHCOLLECTION expression )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:1: loopStatement : Loop '(' loopControl ')' core -> ^( LOOPSTATEMENT loopControl core ) ;
    public PsimulexParser.loopStatement_return loopStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.loopStatement_return retval = new PsimulexParser.loopStatement_return();
        retval.Start = input.LT(1);
        int loopStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Loop244 = null;
        IToken char_literal245 = null;
        IToken char_literal247 = null;
        PsimulexParser.loopControl_return loopControl246 = default(PsimulexParser.loopControl_return);

        PsimulexParser.core_return core248 = default(PsimulexParser.core_return);


        CommonTree Loop244_tree=null;
        CommonTree char_literal245_tree=null;
        CommonTree char_literal247_tree=null;
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
        RewriteRuleTokenStream stream_Loop = new RewriteRuleTokenStream(adaptor,"token Loop");
        RewriteRuleSubtreeStream stream_core = new RewriteRuleSubtreeStream(adaptor,"rule core");
        RewriteRuleSubtreeStream stream_loopControl = new RewriteRuleSubtreeStream(adaptor,"rule loopControl");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 86) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:16: ( Loop '(' loopControl ')' core -> ^( LOOPSTATEMENT loopControl core ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:18: Loop '(' loopControl ')' core
            {
            	Loop244=(IToken)Match(input,Loop,FOLLOW_Loop_in_loopStatement3135); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Loop.Add(Loop244);

            	char_literal245=(IToken)Match(input,148,FOLLOW_148_in_loopStatement3137); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal245);

            	PushFollow(FOLLOW_loopControl_in_loopStatement3139);
            	loopControl246 = loopControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_loopControl.Add(loopControl246.Tree);
            	char_literal247=(IToken)Match(input,149,FOLLOW_149_in_loopStatement3141); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_149.Add(char_literal247);

            	PushFollow(FOLLOW_core_in_loopStatement3143);
            	core248 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core248.Tree);


            	// AST REWRITE
            	// elements:          loopControl, core
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 529:48: -> ^( LOOPSTATEMENT loopControl core )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:51: ^( LOOPSTATEMENT loopControl core )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:530:1: loopControl options {k=3; } : localVariableDeclaration To expression -> ^( LOOPINIT localVariableDeclaration ) ^( LOOPLIMIT expression ) ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken To250 = null;
        PsimulexParser.localVariableDeclaration_return localVariableDeclaration249 = default(PsimulexParser.localVariableDeclaration_return);

        PsimulexParser.expression_return expression251 = default(PsimulexParser.expression_return);


        CommonTree To250_tree=null;
        RewriteRuleTokenStream stream_To = new RewriteRuleTokenStream(adaptor,"token To");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_localVariableDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule localVariableDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 87) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:9: ( localVariableDeclaration To expression -> ^( LOOPINIT localVariableDeclaration ) ^( LOOPLIMIT expression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:13: localVariableDeclaration To expression
            {
            	PushFollow(FOLLOW_localVariableDeclaration_in_loopControl3184);
            	localVariableDeclaration249 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_localVariableDeclaration.Add(localVariableDeclaration249.Tree);
            	To250=(IToken)Match(input,To,FOLLOW_To_in_loopControl3186); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_To.Add(To250);

            	PushFollow(FOLLOW_expression_in_loopControl3188);
            	expression251 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression251.Tree);


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
            	// 531:52: -> ^( LOOPINIT localVariableDeclaration ) ^( LOOPLIMIT expression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:55: ^( LOOPINIT localVariableDeclaration )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LOOPINIT, "LOOPINIT"), root_1);

            	    adaptor.AddChild(root_1, stream_localVariableDeclaration.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:94: ^( LOOPLIMIT expression )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:533:1: core : branch -> ^( CORE branch ) ;
    public PsimulexParser.core_return core() // throws RecognitionException [1]
    {   
        PsimulexParser.core_return retval = new PsimulexParser.core_return();
        retval.Start = input.LT(1);
        int core_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.branch_return branch252 = default(PsimulexParser.branch_return);


        RewriteRuleSubtreeStream stream_branch = new RewriteRuleSubtreeStream(adaptor,"rule branch");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 88) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:533:9: ( branch -> ^( CORE branch ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:533:11: branch
            {
            	PushFollow(FOLLOW_branch_in_core3217);
            	branch252 = branch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_branch.Add(branch252.Tree);


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
            	// 533:18: -> ^( CORE branch )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:533:21: ^( CORE branch )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:1: condition : parExpression -> ^( CONDITION parExpression ) ;
    public PsimulexParser.condition_return condition() // throws RecognitionException [1]
    {   
        PsimulexParser.condition_return retval = new PsimulexParser.condition_return();
        retval.Start = input.LT(1);
        int condition_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression253 = default(PsimulexParser.parExpression_return);


        RewriteRuleSubtreeStream stream_parExpression = new RewriteRuleSubtreeStream(adaptor,"rule parExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 89) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:13: ( parExpression -> ^( CONDITION parExpression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:15: parExpression
            {
            	PushFollow(FOLLOW_parExpression_in_condition3236);
            	parExpression253 = parExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_parExpression.Add(parExpression253.Tree);


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
            	// 534:29: -> ^( CONDITION parExpression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:534:32: ^( CONDITION parExpression )
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
    public void synpred1_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:9: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:9: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex347);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred2_Psimulex"
    public void synpred2_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:25: ( multiFunctionalProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:25: multiFunctionalProgram
        {
        	PushFollow(FOLLOW_multiFunctionalProgram_in_synpred2_Psimulex351);
        	multiFunctionalProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_Psimulex"

    // $ANTLR start "synpred9_Psimulex"
    public void synpred9_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:9: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:9: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex660);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Psimulex"

    // $ANTLR start "synpred10_Psimulex"
    public void synpred10_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:9: ( typedIdentifierNonRef Assign variableInitializer )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:9: typedIdentifierNonRef Assign variableInitializer
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred10_Psimulex678);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Assign,FOLLOW_Assign_in_synpred10_Psimulex680); if (state.failed) return ;
        	PushFollow(FOLLOW_variableInitializer_in_synpred10_Psimulex682);
        	variableInitializer();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_Psimulex"

    // $ANTLR start "synpred19_Psimulex"
    public void synpred19_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:4: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:4: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred19_Psimulex1001);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_Psimulex"

    // $ANTLR start "synpred41_Psimulex"
    public void synpred41_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred41_Psimulex1422);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred41_Psimulex"

    // $ANTLR start "synpred61_Psimulex"
    public void synpred61_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:7: ( unaryPostfixExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:7: unaryPostfixExpression
        {
        	PushFollow(FOLLOW_unaryPostfixExpression_in_synpred61_Psimulex1737);
        	unaryPostfixExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred61_Psimulex"

    // $ANTLR start "synpred63_Psimulex"
    public void synpred63_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:4: ( leftValueExpression ( unaryPostfixOp )? )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:4: leftValueExpression ( unaryPostfixOp )?
        {
        	PushFollow(FOLLOW_leftValueExpression_in_synpred63_Psimulex1788);
        	leftValueExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:24: ( unaryPostfixOp )?
        	int alt54 = 2;
        	int LA54_0 = input.LA(1);

        	if ( ((LA54_0 >= PlusPlus && LA54_0 <= MinusMinus)) )
        	{
        	    alt54 = 1;
        	}
        	switch (alt54) 
        	{
        	    case 1 :
        	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:25: unaryPostfixOp
        	        {
        	        	PushFollow(FOLLOW_unaryPostfixOp_in_synpred63_Psimulex1791);
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
    public void synpred68_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:385:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:385:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred68_Psimulex1923);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred68_Psimulex"

    // $ANTLR start "synpred69_Psimulex"
    public void synpred69_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:386:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:386:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred69_Psimulex1931);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred69_Psimulex"

    // $ANTLR start "synpred103_Psimulex"
    public void synpred103_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:9: ( expression ';' )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:503:9: expression ';'
        {
        	PushFollow(FOLLOW_expression_in_synpred103_Psimulex2662);
        	expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,142,FOLLOW_142_in_synpred103_Psimulex2664); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred103_Psimulex"

    // $ANTLR start "synpred104_Psimulex"
    public void synpred104_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:28: ( ( elseIfBranches elseBranch ) )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:28: ( elseIfBranches elseBranch )
        {
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:28: ( elseIfBranches elseBranch )
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:30: elseIfBranches elseBranch
        	{
        		PushFollow(FOLLOW_elseIfBranches_in_synpred104_Psimulex2719);
        		elseIfBranches();
        		state.followingStackPointer--;
        		if (state.failed) return ;
        		PushFollow(FOLLOW_elseBranch_in_synpred104_Psimulex2721);
        		elseBranch();
        		state.followingStackPointer--;
        		if (state.failed) return ;

        	}


        }
    }
    // $ANTLR end "synpred104_Psimulex"

    // $ANTLR start "synpred105_Psimulex"
    public void synpred105_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:60: ( elseBranch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:60: elseBranch
        {
        	PushFollow(FOLLOW_elseBranch_in_synpred105_Psimulex2727);
        	elseBranch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred105_Psimulex"

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
   	protected DFA46 dfa46;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa3 = new DFA3(this);
    	this.dfa8 = new DFA8(this);
    	this.dfa46 = new DFA46(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);

	    this.dfa8.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA8_SpecialStateTransition);
	    this.dfa46.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA46_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x1b\uffff";
    const string DFA1_eofS =
        "\x01\x17\x1a\uffff";
    const string DFA1_minS =
        "\x01\x3f\x0f\uffff\x01\x00\x04\uffff\x03\x00\x03\uffff";
    const string DFA1_maxS =
        "\x01\u0094\x0f\uffff\x01\x00\x04\uffff\x03\x00\x03\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x16\uffff\x01\x02\x01\uffff\x01\x03";
    const string DFA1_specialS =
        "\x10\uffff\x01\x00\x04\uffff\x01\x01\x01\x02\x01\x03\x03\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x18\x01\x01\x01\x18\x01\x10\x01\uffff\x02\x01\x06\x15"+
            "\x0c\x16\x0e\uffff\x01\x01\x03\uffff\x0e\x01\x02\uffff\x06\x01"+
            "\x01\uffff\x01\x01\x0c\uffff\x01\x01\x05\uffff\x01\x01",
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
            get { return "97:7: ( simpleProgram | multiFunctionalProgram )?"; }
        }

    }


    protected internal int DFA1_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA1_16 = input.LA(1);

                   	 
                   	int index1_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 24; }

                   	 
                   	input.Seek(index1_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_21 = input.LA(1);

                   	 
                   	int index1_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 24; }

                   	 
                   	input.Seek(index1_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_22 = input.LA(1);

                   	 
                   	int index1_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 24; }

                   	 
                   	input.Seek(index1_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA1_23 = input.LA(1);

                   	 
                   	int index1_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 24; }

                   	else if ( (true) ) { s = 26; }

                   	 
                   	input.Seek(index1_23);
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
        "\x04\x42\x01\uffff\x01\x40\x01\x43\x01\x5d\x01\uffff\x01\x40\x01"+
        "\x42\x01\x5d";
    const string DFA3_maxS =
        "\x01\x57\x03\u0091\x01\uffff\x02\u0094\x01\u0093\x01\uffff\x01"+
        "\u0094\x01\x45\x01\u0093";
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
            "\x01\x04\x01\uffff\x01\x04\x01\uffff\x01\x07\x01\x04\x20\uffff"+
            "\x01\x04\x03\uffff\x08\x04\x20\uffff\x02\x08\x01\x04",
            "\x01\x08\x4a\uffff\x01\x08\x05\uffff\x01\x04",
            "\x0d\x04\x28\uffff\x01\x09\x01\x0a",
            "",
            "\x01\x04\x01\uffff\x01\x04\x01\uffff\x01\x0b\x01\x04\x20\uffff"+
            "\x01\x04\x03\uffff\x08\x04\x22\uffff\x01\x04",
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
            get { return "()* loopback of 110:4: ( memberDeclaration )*"; }
        }

    }

    const string DFA8_eotS =
        "\x2c\uffff";
    const string DFA8_eofS =
        "\x06\uffff\x01\x13\x01\uffff\x01\x13\x02\uffff\x01\x13\x20\uffff";
    const string DFA8_minS =
        "\x04\x42\x01\x40\x01\uffff\x01\x43\x01\x40\x01\x43\x01\uffff\x01"+
        "\x40\x01\x43\x01\uffff\x06\x00\x03\uffff\x07\x00\x03\uffff\x07\x00"+
        "\x03\uffff\x01\x00\x01\uffff";
    const string DFA8_maxS =
        "\x01\x57\x03\u0091\x01\u0094\x01\uffff\x01\u008e\x01\u0094\x01"+
        "\u008e\x01\uffff\x01\u0094\x01\u008e\x01\uffff\x06\x00\x03\uffff"+
        "\x07\x00\x03\uffff\x07\x00\x03\uffff\x01\x00\x01\uffff";
    const string DFA8_acceptS =
        "\x05\uffff\x01\x03\x0d\uffff\x01\x01\x17\uffff\x01\x02";
    const string DFA8_specialS =
        "\x0d\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x03"+
        "\uffff\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x03"+
        "\uffff\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x03"+
        "\uffff\x01\x14\x01\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x03\x03\uffff\x06\x01\x0c\x02",
            "\x01\x06\x02\uffff\x01\x05\x4b\uffff\x01\x04",
            "\x01\x08\x02\uffff\x01\x05\x4b\uffff\x01\x07",
            "\x01\x0b\x02\uffff\x01\x05\x4b\uffff\x01\x0a",
            "\x01\x12\x01\uffff\x01\x0e\x01\uffff\x01\x12\x01\x0d\x20\uffff"+
            "\x01\x10\x03\uffff\x01\x10\x02\x11\x05\x12\x22\uffff\x01\x0f",
            "",
            "\x01\x16\x3e\uffff\x01\x13\x0b\uffff\x01\x13",
            "\x01\x1c\x01\uffff\x01\x18\x01\uffff\x01\x1c\x01\x17\x20\uffff"+
            "\x01\x1a\x03\uffff\x01\x1a\x02\x1b\x05\x1c\x22\uffff\x01\x19",
            "\x01\x20\x3e\uffff\x01\x13\x0b\uffff\x01\x13",
            "",
            "\x01\x26\x01\uffff\x01\x22\x01\uffff\x01\x26\x01\x21\x20\uffff"+
            "\x01\x24\x03\uffff\x01\x24\x02\x25\x05\x26\x22\uffff\x01\x23",
            "\x01\x2a\x3e\uffff\x01\x13\x0b\uffff\x01\x13",
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
            "\x01\uffff",
            "",
            "",
            "",
            "\x01\uffff",
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
            get { return "146:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );"; }
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

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA8_14 = input.LA(1);

                   	 
                   	int index8_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA8_15 = input.LA(1);

                   	 
                   	int index8_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA8_16 = input.LA(1);

                   	 
                   	int index8_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA8_17 = input.LA(1);

                   	 
                   	int index8_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA8_18 = input.LA(1);

                   	 
                   	int index8_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA8_22 = input.LA(1);

                   	 
                   	int index8_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA8_23 = input.LA(1);

                   	 
                   	int index8_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA8_24 = input.LA(1);

                   	 
                   	int index8_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA8_25 = input.LA(1);

                   	 
                   	int index8_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA8_26 = input.LA(1);

                   	 
                   	int index8_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA8_27 = input.LA(1);

                   	 
                   	int index8_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA8_28 = input.LA(1);

                   	 
                   	int index8_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA8_32 = input.LA(1);

                   	 
                   	int index8_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA8_33 = input.LA(1);

                   	 
                   	int index8_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA8_34 = input.LA(1);

                   	 
                   	int index8_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA8_35 = input.LA(1);

                   	 
                   	int index8_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA8_36 = input.LA(1);

                   	 
                   	int index8_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA8_37 = input.LA(1);

                   	 
                   	int index8_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA8_38 = input.LA(1);

                   	 
                   	int index8_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 19; }

                   	else if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA8_42 = input.LA(1);

                   	 
                   	int index8_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Psimulex()) ) { s = 43; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_42);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 8, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA46_eotS =
        "\x17\uffff";
    const string DFA46_eofS =
        "\x17\uffff";
    const string DFA46_minS =
        "\x01\x40\x0f\uffff\x01\x00\x06\uffff";
    const string DFA46_maxS =
        "\x01\u0094\x0f\uffff\x01\x00\x06\uffff";
    const string DFA46_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x03\x01\uffff\x01\x04"+
        "\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c"+
        "\x01\x0d\x05\uffff\x01\x0e\x01\uffff";
    const string DFA46_specialS =
        "\x10\uffff\x01\x00\x06\uffff}>";
    static readonly string[] DFA46_transitionS = {
            "\x01\x0f\x01\uffff\x01\x10\x01\uffff\x02\x0f\x12\x15\x0e\uffff"+
            "\x01\x0f\x03\uffff\x08\x0f\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01"+
            "\x0d\x01\x01\x02\uffff\x02\x02\x01\x07\x01\x08\x02\x04\x01\uffff"+
            "\x01\x06\x0c\uffff\x01\x0e\x05\uffff\x01\x0f",
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
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA46_eot = DFA.UnpackEncodedString(DFA46_eotS);
    static readonly short[] DFA46_eof = DFA.UnpackEncodedString(DFA46_eofS);
    static readonly char[] DFA46_min = DFA.UnpackEncodedStringToUnsignedChars(DFA46_minS);
    static readonly char[] DFA46_max = DFA.UnpackEncodedStringToUnsignedChars(DFA46_maxS);
    static readonly short[] DFA46_accept = DFA.UnpackEncodedString(DFA46_acceptS);
    static readonly short[] DFA46_special = DFA.UnpackEncodedString(DFA46_specialS);
    static readonly short[][] DFA46_transition = DFA.UnpackEncodedStringArray(DFA46_transitionS);

    protected class DFA46 : DFA
    {
        public DFA46(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 46;
            this.eot = DFA46_eot;
            this.eof = DFA46_eof;
            this.min = DFA46_min;
            this.max = DFA46_max;
            this.accept = DFA46_accept;
            this.special = DFA46_special;
            this.transition = DFA46_transition;

        }

        override public string Description
        {
            get { return "489:1: statement : ( ifStatement -> ^( IFSTATEMENT ifStatement ) | ( forStatement | pForStatement ) | ( forEachStatement | pForEachStatement ) | loopStatement | whileStatement | doStatement | PDo block -> ^( PDOSTATEMENT block ) | Async block -> ^( ASYNCSTATEMENT block ) | Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block ) | Return ( expression )? ';' -> ^( RETURN_STATEMENT Return ( expression )? ) | Break ';' | ';' | expression ';' -> ^( EXPRESSION_STATEMENT expression ) | localVariableDeclaration ';' -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration ) );"; }
        }

    }


    protected internal int DFA46_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA46_16 = input.LA(1);

                   	 
                   	int index46_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred103_Psimulex()) ) { s = 15; }

                   	else if ( (true) ) { s = 21; }

                   	 
                   	input.Seek(index46_16);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 46, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit347 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit351 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_simpleProgram371 = new BitSet(new ulong[]{0x0000000000000002UL,0xFCFFFC4000FFFFF5UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_importDeclarations_in_multiFunctionalProgram400 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF7UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_typeDeclarations_in_multiFunctionalProgram402 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram404 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_functionDeclarations_in_multiFunctionalProgram406 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclarations441 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000FFFFC4UL});
    public static readonly BitSet FOLLOW_Import_in_importDeclarations481 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclarations483 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_importDeclarations485 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclarations518 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration549 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration551 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_structBody583 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000FFFFC4UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBody586 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000FFFFC4UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_structBody589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberTypedIdentifierNonRef_in_memberDeclaration610 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_Assign_in_memberDeclaration614 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003E00000000011UL});
    public static readonly BitSet FOLLOW_literal_in_memberDeclaration616 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_memberDeclaration621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration678 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration680 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_localVariableDeclaration697 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration699 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration701 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInitializer734 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_scalarOrArrayType754 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_staticArrayType_in_scalarOrArrayType756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_staticArrayType_in_arrayType781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dynamicArrayType_in_arrayType785 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_staticArrayType797 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_staticArrayType799 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_146_in_staticArrayType802 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_staticArrayType804 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_147_in_staticArrayType808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_dynamicArrayType836 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_146_in_dynamicArrayType840 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_147_in_dynamicArrayType845 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_memberScalarOrArrayType875 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_memberArrayType_in_memberScalarOrArrayType877 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberStaticArrayType_in_memberArrayType902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dynamicArrayType_in_memberArrayType906 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_memberStaticArrayType917 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_IntegerLiteral_in_memberStaticArrayType919 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_146_in_memberStaticArrayType922 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_IntegerLiteral_in_memberStaticArrayType924 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_147_in_memberStaticArrayType928 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberScalarOrArrayType_in_memberTypedIdentifierNonRef957 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberTypedIdentifierNonRef959 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef970 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierNonRef972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierRef983 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000024UL});
    public static readonly BitSet FOLLOW_Reference_in_typedIdentifierRef985 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierRef988 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_typedIdentifier1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_typedIdentifier1005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_functionDeclarations1022 = new BitSet(new ulong[]{0x0000000000000002UL,0xFCFFFC4000FFFFF5UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_functionDeclaration1055 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclaration1057 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration1060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_formalParameterList1094 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000304002UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList1098 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000240000UL});
    public static readonly BitSet FOLLOW_146_in_formalParameterList1101 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList1103 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000240000UL});
    public static readonly BitSet FOLLOW_149_in_formalParameterList1110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_formalParameter1147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_type1183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataTypeName_in_dataType1202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataTypeName1223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataTypeName1227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedTypes_in_dataTypeName1231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_userDefinedTypes1243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exp_in_expression1400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_exp1422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_exp1426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment1439 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000001F000008UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment1441 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_exp_in_assignment1444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1485 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression1489 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1492 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1514 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression1518 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1521 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1543 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000180000000UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression1547 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1550 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000180000000UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1585 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001E00000000UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression1589 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1592 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001E00000000UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1645 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000006000000000UL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression1649 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1652 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000006000000000UL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1687 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000038000000000UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression1691 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1694 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000038000000000UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixExpression_in_unaryExpression1729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_unaryExpression1737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpression1742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1756 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryPrefixExpression1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_unaryPostfixExpression1788 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000180000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryPostfixExpression1799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_leftValueExpression1810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1815 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000180000000024UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_leftValueExpression1817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_castExpression1848 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000FFFFC4UL});
    public static readonly BitSet FOLLOW_dataType_in_castExpression1850 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_castExpression1852 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixAssignerOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_primaryExpression1949 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_parExpression1968 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1971 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_parExpression1973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1988 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1993 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Reference_in_variable2004 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable2007 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selector_in_selecting2029 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selector2057 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000420000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selector2061 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000420000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector2066 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000420000UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector2070 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000420000UL});
    public static readonly BitSet FOLLOW_indexing_in_selector2074 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000420000UL});
    public static readonly BitSet FOLLOW_150_in_memberSelect2090 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect2092 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_150_in_memberFunctionCall2113 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall2115 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall2117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall2140 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_arguments_in_functionCall2142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_indexing2166 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing2168 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_146_in_indexing2172 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing2174 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_147_in_indexing2179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_arguments2213 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments2217 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000240000UL});
    public static readonly BitSet FOLLOW_146_in_arguments2220 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments2222 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000240000UL});
    public static readonly BitSet FOLLOW_149_in_arguments2229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_block2362 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000114002UL});
    public static readonly BitSet FOLLOW_statement_in_block2364 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000114002UL});
    public static readonly BitSet FOLLOW_144_in_block2367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch2409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_branch2413 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement2430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_statement2450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForStatement_in_statement2454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forEachStatement_in_statement2468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForEachStatement_in_statement2472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_loopStatement_in_statement2484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_statement2494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doStatement_in_statement2504 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement2517 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_block_in_statement2519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Async_in_statement2548 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_block_in_statement2550 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Lock_in_statement2578 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_148_in_statement2580 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_statement2582 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_statement2584 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_block_in_statement2586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement2609 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000104000UL});
    public static readonly BitSet FOLLOW_expression_in_statement2611 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_statement2614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement2637 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_statement2639 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_142_in_statement2651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement2662 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_statement2664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_statement2682 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_statement2684 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifBranch_in_ifStatement2713 = new BitSet(new ulong[]{0x0000000000000002UL,0x0300000000000000UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_ifStatement2719 = new BitSet(new ulong[]{0x0000000000000000UL,0x0300000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_ifBranch2739 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000024UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_condition_in_ifBranch2741 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_ifBranch2743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ElseIf_in_elseIfBranches2771 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000024UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_condition_in_elseIfBranches2773 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_elseIfBranches2775 = new BitSet(new ulong[]{0x0000000000000002UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_Else_in_elseBranch2810 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_elseBranch2812 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_For_in_forStatement2830 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_148_in_forStatement2832 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_forControl_in_forStatement2834 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_forStatement2836 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_forStatement2838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PFor_in_pForStatement2858 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_148_in_pForStatement2860 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000104002UL});
    public static readonly BitSet FOLLOW_forControl_in_pForStatement2862 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_pForStatement2864 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_pForStatement2866 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl2887 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_forControl2890 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000104000UL});
    public static readonly BitSet FOLLOW_forCondition_in_forControl2892 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_forControl2895 = new BitSet(new ulong[]{0x0000000000000002UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl2897 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit2939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forCondition2949 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate2960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_whileStatement2969 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000024UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_condition_in_whileStatement2971 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_whileStatement2973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_doStatement2995 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_doStatement2997 = new BitSet(new ulong[]{0x0000000000000000UL,0x1000000000000000UL});
    public static readonly BitSet FOLLOW_While_in_doStatement2999 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000024UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_condition_in_doStatement3001 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_doStatement3003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PForEach_in_pForEachStatement3023 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_pForEachStatement3025 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ForEach_in_forEachStatement3042 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_forEachStatement3044 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_forEachTrailer3062 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000FFFFC4UL});
    public static readonly BitSet FOLLOW_forEachControl_in_forEachTrailer3065 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_forEachTrailer3067 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_forEachTrailer3070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_forEachControl3099 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_forEachControl3101 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_In_in_forEachControl3103 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_forEachControl3105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_loopStatement3135 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_148_in_loopStatement3137 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x0000000000104006UL});
    public static readonly BitSet FOLLOW_loopControl_in_loopStatement3139 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_loopStatement3141 = new BitSet(new ulong[]{0x0000000000000000UL,0xFCFFFC4000FFFFF5UL,0x000000000010C002UL});
    public static readonly BitSet FOLLOW_core_in_loopStatement3143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_loopControl3184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_To_in_loopControl3186 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_expression_in_loopControl3188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_branch_in_core3217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_condition3236 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_synpred2_Psimulex351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred10_Psimulex678 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Assign_in_synpred10_Psimulex680 = new BitSet(new ulong[]{0x0000000000000000UL,0x0003FC4000000035UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_synpred10_Psimulex682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred19_Psimulex1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred41_Psimulex1422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_synpred61_Psimulex1737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_synpred63_Psimulex1788 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000180000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_synpred63_Psimulex1791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred68_Psimulex1923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred69_Psimulex1931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_synpred103_Psimulex2662 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_142_in_synpred103_Psimulex2664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_synpred104_Psimulex2719 = new BitSet(new ulong[]{0x0000000000000000UL,0x0300000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred104_Psimulex2721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred105_Psimulex2727 = new BitSet(new ulong[]{0x0000000000000002UL});

}
