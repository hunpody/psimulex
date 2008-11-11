// $ANTLR 3.1.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-11-11 15:45:07

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
    public const int Iterator = 88;
    public const int CONDITIONALBRANCH = 21;
    public const int RelEqual = 96;
    public const int FORMAL_PARAMETER_LIST = 14;
    public const int TYPE_DECLARATIONS = 8;
    public const int VARINIT = 45;
    public const int AssignAndDivide = 92;
    public const int FORSTATEMENT = 24;
    public const int AssignAndMultiply = 91;
    public const int PFORSTATEMENT = 23;
    public const int CONDITION = 38;
    public const int Decimal = 74;
    public const int Modulo = 106;
    public const int PDOSTATEMENT = 39;
    public const int IDLetter = 137;
    public const int EOF = -1;
    public const int STATEMENT = 17;
    public const int INDEXING = 59;
    public const int Identifier = 68;
    public const int Int = 73;
    public const int Thread = 87;
    public const int TYPE = 47;
    public const int CONSTANT_DIMS = 61;
    public const int BinTree = 78;
    public const int PFOREACHSTATEMENT = 30;
    public const int T__148 = 148;
    public const int T__147 = 147;
    public const int To = 133;
    public const int T__149 = 149;
    public const int ForEach = 130;
    public const int Char = 72;
    public const int Edge = 86;
    public const int COMPILATION_UNIT = 4;
    public const int LOCKSTATEMENT = 41;
    public const int Do = 128;
    public const int RelGreaterThan = 100;
    public const int FORMAL_PARAMETER = 15;
    public const int Node = 85;
    public const int AssignAndModulo = 93;
    public const int LOOPLIMIT = 36;
    public const int FOREACHINIT = 32;
    public const int T__150 = 150;
    public const int T__151 = 151;
    public const int T__152 = 152;
    public const int WHILESTATEMENT = 29;
    public const int T__153 = 153;
    public const int FORUPDATE = 27;
    public const int Bool = 71;
    public const int FORINIT = 26;
    public const int ARGUMENTS = 57;
    public const int MEMBER_SELECT = 58;
    public const int LogicalOr = 94;
    public const int LogicalAnd = 95;
    public const int CORE = 37;
    public const int Tree = 77;
    public const int T__145 = 145;
    public const int T__146 = 146;
    public const int POSTFIXOP = 53;
    public const int Minus = 103;
    public const int WS = 142;
    public const int Break = 121;
    public const int GLOBAL_VARIABLE_DECLARATIONS = 10;
    public const int Async = 118;
    public const int MEMBER_FUNCTION_CALL = 55;
    public const int MULTY_FUNCTIONAL_PROGRAM = 6;
    public const int SIMPLE_PROGRAM = 5;
    public const int DATATYPE = 48;
    public const int EXPRESSION_STATEMENT = 43;
    public const int NotNullDigit = 139;
    public const int RelLessThan = 98;
    public const int Star = 104;
    public const int Else = 124;
    public const int FUNCTION_CALL = 56;
    public const int EscapeSequence = 141;
    public const int Letter = 136;
    public const int Loop = 132;
    public const int VARIABLE_DECLARATION_STATEMENT = 44;
    public const int BooleanLiteral = 113;
    public const int LOOPSTATEMENT = 34;
    public const int DIMMARKER = 62;
    public const int AssignAndAdd = 89;
    public const int Stack = 81;
    public const int NullLiteral = 114;
    public const int RelGreaterThanOrEqual = 101;
    public const int IFSTATEMENT = 18;
    public const int PQueue = 83;
    public const int SingleLineComment = 143;
    public const int DIMS = 60;
    public const int CharacterLiteral = 112;
    public const int COLLECTION_INITIALIZER = 63;
    public const int AssignAndSubstract = 90;
    public const int FOREACHCOLLECTION = 33;
    public const int While = 127;
    public const int Graph = 84;
    public const int Queue = 82;
    public const int Set = 79;
    public const int SELECTOR = 54;
    public const int Assign = 69;
    public const int RETURN_STATEMENT = 42;
    public const int PForEach = 129;
    public const int RelNotEqual = 97;
    public const int FOREACHSTATEMENT = 31;
    public const int IFBRANCH = 19;
    public const int String = 75;
    public const int Return = 120;
    public const int Struct = 67;
    public const int Reference = 70;
    public const int EXPRESSION = 50;
    public const int MultiLineComment = 144;
    public const int If = 122;
    public const int FUNCTIONPOINTERTYPE = 49;
    public const int In = 131;
    public const int Import = 65;
    public const int VARDECLARE = 46;
    public const int FUNCTION_DECLARATIONS = 12;
    public const int Continue = 134;
    public const int ELSEBRANCH = 22;
    public const int Void = 76;
    public const int ASYNCSTATEMENT = 40;
    public const int Lock = 119;
    public const int PDo = 117;
    public const int ElseIf = 123;
    public const int IMPORT_DECLARATIONS = 7;
    public const int DOSTATEMENT = 28;
    public const int Digit = 138;
    public const int DecimalLiteral = 111;
    public const int STRUCTDEC = 9;
    public const int For = 125;
    public const int Divide = 105;
    public const int List = 80;
    public const int FORCONDITION = 25;
    public const int StringLiteral = 66;
    public const int LogicalNot = 107;
    public const int Plus = 102;
    public const int Atomic = 135;
    public const int RelLessThanOrEqual = 99;
    public const int New = 116;
    public const int MinusMinus = 109;
    public const int DecimalTypeSuffix = 140;
    public const int PFor = 126;
    public const int BLOCK = 16;
    public const int PREFIXOP = 52;
    public const int MEMBERDEC = 11;
    public const int ELSEIFBRANCHES = 20;
    public const int IntegerLiteral = 110;
    public const int LOOPINIT = 35;
    public const int FUNCDEC = 13;
    public const int ARRAY_INITIALIZER = 64;
    public const int InfinityLiteral = 115;
    public const int PlusPlus = 108;

    // delegates
    // delegators



        public PsimulexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PsimulexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[199+1];
             
             
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:98:1: compilationUnit : ( simpleProgram | multiFunctionalProgram )? EOF ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:5: ( ( simpleProgram | multiFunctionalProgram )? EOF )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:7: ( simpleProgram | multiFunctionalProgram )? EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:7: ( simpleProgram | multiFunctionalProgram )?
            	int alt1 = 3;
            	alt1 = dfa1.Predict(input);
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:9: simpleProgram
            	        {
            	        	PushFollow(FOLLOW_simpleProgram_in_compilationUnit355);
            	        	simpleProgram1 = simpleProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:25: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit359);
            	        	multiFunctionalProgram2 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit364); if (state.failed) return retval;

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:1: simpleProgram : ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:2: ( ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:4: ( statement )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || (LA2_0 >= Reference && LA2_0 <= Iterator) || LA2_0 == Minus || (LA2_0 >= LogicalNot && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= ForEach) || LA2_0 == Loop || LA2_0 == 145 || LA2_0 == 151) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_simpleProgram379);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:1: multiFunctionalProgram : importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:107:2: ( importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:107:4: importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations
            {
            	PushFollow(FOLLOW_importDeclarations_in_multiFunctionalProgram408);
            	importDeclarations5 = importDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_importDeclarations.Add(importDeclarations5.Tree);
            	PushFollow(FOLLOW_typeDeclarations_in_multiFunctionalProgram410);
            	typeDeclarations6 = typeDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typeDeclarations.Add(typeDeclarations6.Tree);
            	PushFollow(FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram412);
            	globalVariableDeclarations7 = globalVariableDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_globalVariableDeclarations.Add(globalVariableDeclarations7.Tree);
            	PushFollow(FOLLOW_functionDeclarations_in_multiFunctionalProgram414);
            	functionDeclarations8 = functionDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_functionDeclarations.Add(functionDeclarations8.Tree);


            	// AST REWRITE
            	// elements:          importDeclarations, globalVariableDeclarations, typeDeclarations, functionDeclarations
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:111:1: globalVariableDeclarations : ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) ;
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
            			    	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclarations449);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:1: importDeclarations : ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) ;
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
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
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
            			    	Import10=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclarations489); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_Import.Add(Import10);

            			    	StringLiteral11=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclarations491); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_StringLiteral.Add(StringLiteral11);

            			    	char_literal12=(IToken)Match(input,145,FOLLOW_145_in_importDeclarations493); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_145.Add(char_literal12);


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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:1: typeDeclarations : ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) ;
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
            			    	PushFollow(FOLLOW_structDeclaration_in_typeDeclarations526);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:136:1: structDeclaration : Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:137:5: ( Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:137:9: Struct Identifier structBody
            {
            	Struct14=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration557); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Struct.Add(Struct14);

            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration559); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier15);

            	PushFollow(FOLLOW_structBody_in_structDeclaration561);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:140:1: structBody : '{' ( memberDeclaration )+ '}' ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:141:5: ( '{' ( memberDeclaration )+ '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:141:9: '{' ( memberDeclaration )+ '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,146,FOLLOW_146_in_structBody591); if (state.failed) return retval;
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
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBody594);
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

            	char_literal19=(IToken)Match(input,147,FOLLOW_147_in_structBody597); if (state.failed) return retval;

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:1: memberDeclaration options {k=3; } : ( type Identifier ';' -> ^( MEMBERDEC type Identifier ) | type Identifier Assign constantData ';' -> ^( MEMBERDEC type Identifier constantData ) );
    public PsimulexParser.memberDeclaration_return memberDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.memberDeclaration_return retval = new PsimulexParser.memberDeclaration_return();
        retval.Start = input.LT(1);
        int memberDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier21 = null;
        IToken char_literal22 = null;
        IToken Identifier24 = null;
        IToken Assign25 = null;
        IToken char_literal27 = null;
        PsimulexParser.type_return type20 = default(PsimulexParser.type_return);

        PsimulexParser.type_return type23 = default(PsimulexParser.type_return);

        PsimulexParser.constantData_return constantData26 = default(PsimulexParser.constantData_return);


        CommonTree Identifier21_tree=null;
        CommonTree char_literal22_tree=null;
        CommonTree Identifier24_tree=null;
        CommonTree Assign25_tree=null;
        CommonTree char_literal27_tree=null;
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
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
                    	PushFollow(FOLLOW_type_in_memberDeclaration625);
                    	type20 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_type.Add(type20.Tree);
                    	Identifier21=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberDeclaration627); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier21);

                    	char_literal22=(IToken)Match(input,145,FOLLOW_145_in_memberDeclaration629); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_145.Add(char_literal22);



                    	// AST REWRITE
                    	// elements:          Identifier, type
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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
                    	PushFollow(FOLLOW_type_in_memberDeclaration651);
                    	type23 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_type.Add(type23.Tree);
                    	Identifier24=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberDeclaration653); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier24);

                    	Assign25=(IToken)Match(input,Assign,FOLLOW_Assign_in_memberDeclaration655); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign25);

                    	PushFollow(FOLLOW_constantData_in_memberDeclaration657);
                    	constantData26 = constantData();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_constantData.Add(constantData26.Tree);
                    	char_literal27=(IToken)Match(input,145,FOLLOW_145_in_memberDeclaration659); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_145.Add(char_literal27);



                    	// AST REWRITE
                    	// elements:          constantData, Identifier, type
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken char_literal30 = null;

        CommonTree char_literal28_tree=null;
        CommonTree char_literal29_tree=null;
        CommonTree char_literal30_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:2: ( '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:4: '[' ( ',' )* ']'
            {
            	char_literal28=(IToken)Match(input,148,FOLLOW_148_in_arrayType695); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal28);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:8: ( ',' )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 149) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:10: ','
            			    {
            			    	char_literal29=(IToken)Match(input,149,FOLLOW_149_in_arrayType699); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_149.Add(char_literal29);


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	char_literal30=(IToken)Match(input,150,FOLLOW_150_in_arrayType704); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_150.Add(char_literal30);



            	// AST REWRITE
            	// elements:          149, 150, 148
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 157:21: -> ^( DIMMARKER '[' ( ',' )* ']' )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:24: ^( DIMMARKER '[' ( ',' )* ']' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMMARKER, "DIMMARKER"), root_1);

            	    adaptor.AddChild(root_1, stream_148.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:41: ( ',' )*
            	    while ( stream_149.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_149.NextNode());

            	    }
            	    stream_149.Reset();
            	    adaptor.AddChild(root_1, stream_150.NextNode());

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

        PsimulexParser.functionDeclaration_return functionDeclaration31 = default(PsimulexParser.functionDeclaration_return);


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
            			    	PushFollow(FOLLOW_functionDeclaration_in_functionDeclarations743);
            			    	functionDeclaration31 = functionDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_functionDeclaration.Add(functionDeclaration31.Tree);

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
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        IToken Reference33 = null;
        IToken Identifier34 = null;
        PsimulexParser.type_return type32 = default(PsimulexParser.type_return);

        PsimulexParser.formalParameterList_return formalParameterList35 = default(PsimulexParser.formalParameterList_return);

        PsimulexParser.block_return block36 = default(PsimulexParser.block_return);


        CommonTree Reference33_tree=null;
        CommonTree Identifier34_tree=null;
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
            	PushFollow(FOLLOW_type_in_functionDeclaration776);
            	type32 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type32.Tree);
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
            	        	Reference33=(IToken)Match(input,Reference,FOLLOW_Reference_in_functionDeclaration778); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Reference.Add(Reference33);


            	        }
            	        break;

            	}

            	Identifier34=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration781); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier34);

            	PushFollow(FOLLOW_formalParameterList_in_functionDeclaration783);
            	formalParameterList35 = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_formalParameterList.Add(formalParameterList35.Tree);
            	PushFollow(FOLLOW_block_in_functionDeclaration786);
            	block36 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_block.Add(block36.Tree);


            	// AST REWRITE
            	// elements:          type, formalParameterList, block, Identifier, Reference
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        IToken char_literal37 = null;
        IToken char_literal39 = null;
        IToken char_literal41 = null;
        PsimulexParser.formalParameter_return formalParameter38 = default(PsimulexParser.formalParameter_return);

        PsimulexParser.formalParameter_return formalParameter40 = default(PsimulexParser.formalParameter_return);


        CommonTree char_literal37_tree=null;
        CommonTree char_literal39_tree=null;
        CommonTree char_literal41_tree=null;
        RewriteRuleTokenStream stream_152 = new RewriteRuleTokenStream(adaptor,"token 152");
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
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
            	char_literal37=(IToken)Match(input,151,FOLLOW_151_in_formalParameterList825); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_151.Add(char_literal37);

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
            	        	PushFollow(FOLLOW_formalParameter_in_formalParameterList829);
            	        	formalParameter38 = formalParameter();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_formalParameter.Add(formalParameter38.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:31: ( ',' formalParameter )*
            	        	do 
            	        	{
            	        	    int alt11 = 2;
            	        	    int LA11_0 = input.LA(1);

            	        	    if ( (LA11_0 == 149) )
            	        	    {
            	        	        alt11 = 1;
            	        	    }


            	        	    switch (alt11) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:32: ',' formalParameter
            	        			    {
            	        			    	char_literal39=(IToken)Match(input,149,FOLLOW_149_in_formalParameterList832); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_149.Add(char_literal39);

            	        			    	PushFollow(FOLLOW_formalParameter_in_formalParameterList834);
            	        			    	formalParameter40 = formalParameter();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_formalParameter.Add(formalParameter40.Tree);

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

            	char_literal41=(IToken)Match(input,152,FOLLOW_152_in_formalParameterList841); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_152.Add(char_literal41);



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

        IToken Reference43 = null;
        IToken Identifier44 = null;
        PsimulexParser.type_return type42 = default(PsimulexParser.type_return);


        CommonTree Reference43_tree=null;
        CommonTree Identifier44_tree=null;
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
            	PushFollow(FOLLOW_type_in_formalParameter878);
            	type42 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type42.Tree);
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
            	        	Reference43=(IToken)Match(input,Reference,FOLLOW_Reference_in_formalParameter880); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Reference.Add(Reference43);


            	        }
            	        break;

            	}

            	Identifier44=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_formalParameter883); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier44);



            	// AST REWRITE
            	// elements:          Reference, Identifier, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        PsimulexParser.dataType_return dataType45 = default(PsimulexParser.dataType_return);

        PsimulexParser.arrayType_return arrayType46 = default(PsimulexParser.arrayType_return);


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
            	PushFollow(FOLLOW_dataType_in_type929);
            	dataType45 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataType.Add(dataType45.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:16: ( arrayType )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 148) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: arrayType
            	        {
            	        	PushFollow(FOLLOW_arrayType_in_type931);
            	        	arrayType46 = arrayType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_arrayType.Add(arrayType46.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          arrayType, dataType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        PsimulexParser.dataTypeName_return dataTypeName47 = default(PsimulexParser.dataTypeName_return);


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
            	PushFollow(FOLLOW_dataTypeName_in_dataType964);
            	dataTypeName47 = dataTypeName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataTypeName.Add(dataTypeName47.Tree);


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

        PsimulexParser.primitiveType_return primitiveType48 = default(PsimulexParser.primitiveType_return);

        PsimulexParser.builtInType_return builtInType49 = default(PsimulexParser.builtInType_return);

        PsimulexParser.userDefinedTypes_return userDefinedTypes50 = default(PsimulexParser.userDefinedTypes_return);



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

                    	PushFollow(FOLLOW_primitiveType_in_dataTypeName985);
                    	primitiveType48 = primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType48.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:20: builtInType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtInType_in_dataTypeName989);
                    	builtInType49 = builtInType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType49.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:34: userDefinedTypes
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_userDefinedTypes_in_dataTypeName993);
                    	userDefinedTypes50 = userDefinedTypes();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, userDefinedTypes50.Tree);

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

        IToken Identifier51 = null;

        CommonTree Identifier51_tree=null;

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

            	Identifier51=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_userDefinedTypes1005); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier51_tree = (CommonTree)adaptor.Create(Identifier51);
            		adaptor.AddChild(root_0, Identifier51_tree);
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

        IToken set52 = null;

        CommonTree set52_tree=null;

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

            	set52 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Bool && input.LA(1) <= Void) ) 
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

        IToken set53 = null;

        CommonTree set53_tree=null;

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

            	set53 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= Iterator) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set53));
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

        PsimulexParser.exp_return exp54 = default(PsimulexParser.exp_return);


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
            	PushFollow(FOLLOW_exp_in_expression1162);
            	exp54 = exp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_exp.Add(exp54.Tree);


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

        PsimulexParser.assignment_return assignment55 = default(PsimulexParser.assignment_return);

        PsimulexParser.conditionalOrExpression_return conditionalOrExpression56 = default(PsimulexParser.conditionalOrExpression_return);



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

                if ( (synpred34_Psimulex()) )
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

                if ( (synpred34_Psimulex()) )
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
            case 151:
            	{
                int LA16_3 = input.LA(2);

                if ( (synpred34_Psimulex()) )
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

                    	PushFollow(FOLLOW_assignment_in_exp1184);
                    	assignment55 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment55.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:17: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_exp1188);
                    	conditionalOrExpression56 = conditionalOrExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression56.Tree);

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

        PsimulexParser.leftValue_return leftValue57 = default(PsimulexParser.leftValue_return);

        PsimulexParser.assignmentOperator_return assignmentOperator58 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.exp_return exp59 = default(PsimulexParser.exp_return);



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

            	PushFollow(FOLLOW_leftValue_in_assignment1201);
            	leftValue57 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue57.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment1203);
            	assignmentOperator58 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assignmentOperator58.Tree, root_0);
            	PushFollow(FOLLOW_exp_in_assignment1206);
            	exp59 = exp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exp59.Tree);

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

        IToken set60 = null;

        CommonTree set60_tree=null;

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

            	set60 = (IToken)input.LT(1);
            	if ( input.LA(1) == Assign || (input.LA(1) >= AssignAndAdd && input.LA(1) <= AssignAndModulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set60));
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

        IToken LogicalOr62 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression61 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression63 = default(PsimulexParser.conditionalAndExpression_return);


        CommonTree LogicalOr62_tree=null;

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

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1247);
            	conditionalAndExpression61 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression61.Tree);
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
            			    	LogicalOr62=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression1251); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalOr62_tree = (CommonTree)adaptor.Create(LogicalOr62);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalOr62_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1254);
            			    	conditionalAndExpression63 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression63.Tree);

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

        IToken LogicalAnd65 = null;
        PsimulexParser.equalityExpression_return equalityExpression64 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression66 = default(PsimulexParser.equalityExpression_return);


        CommonTree LogicalAnd65_tree=null;

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

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1276);
            	equalityExpression64 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression64.Tree);
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
            			    	LogicalAnd65=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression1280); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd65_tree = (CommonTree)adaptor.Create(LogicalAnd65);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd65_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1283);
            			    	equalityExpression66 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression66.Tree);

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

        PsimulexParser.relationalExpression_return relationalExpression67 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.equalityOp_return equalityOp68 = default(PsimulexParser.equalityOp_return);

        PsimulexParser.relationalExpression_return relationalExpression69 = default(PsimulexParser.relationalExpression_return);



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

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1305);
            	relationalExpression67 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression67.Tree);
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
            			    	PushFollow(FOLLOW_equalityOp_in_equalityExpression1309);
            			    	equalityOp68 = equalityOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp68.Tree, root_0);
            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1312);
            			    	relationalExpression69 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression69.Tree);

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

        IToken set70 = null;

        CommonTree set70_tree=null;

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

            	set70 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelEqual && input.LA(1) <= RelNotEqual) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set70));
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

        PsimulexParser.additiveExpression_return additiveExpression71 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp72 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression73 = default(PsimulexParser.additiveExpression_return);



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

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1347);
            	additiveExpression71 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression71.Tree);
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
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression1351);
            			    	relationalOp72 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp72.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1354);
            			    	additiveExpression73 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression73.Tree);

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

        IToken set74 = null;

        CommonTree set74_tree=null;

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

            	set74 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelLessThan && input.LA(1) <= RelGreaterThanOrEqual) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set74));
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

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression75 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.additiveOp_return additiveOp76 = default(PsimulexParser.additiveOp_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression77 = default(PsimulexParser.multiplicativeExpression_return);



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

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1407);
            	multiplicativeExpression75 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression75.Tree);
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
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression1411);
            			    	additiveOp76 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp76.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1414);
            			    	multiplicativeExpression77 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression77.Tree);

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

        IToken set78 = null;

        CommonTree set78_tree=null;

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

            	set78 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) ) 
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

        PsimulexParser.unaryExpression_return unaryExpression79 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.multiplicativeOp_return multiplicativeOp80 = default(PsimulexParser.multiplicativeOp_return);

        PsimulexParser.unaryExpression_return unaryExpression81 = default(PsimulexParser.unaryExpression_return);



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

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1449);
            	unaryExpression79 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression79.Tree);
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
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression1453);
            			    	multiplicativeOp80 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp80.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1456);
            			    	unaryExpression81 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression81.Tree);

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

        IToken set82 = null;

        CommonTree set82_tree=null;

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

            	set82 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Star && input.LA(1) <= Modulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set82));
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

        PsimulexParser.unaryPrefixExpression_return unaryPrefixExpression83 = default(PsimulexParser.unaryPrefixExpression_return);

        PsimulexParser.unaryPostfixExpression_return unaryPostfixExpression84 = default(PsimulexParser.unaryPostfixExpression_return);

        PsimulexParser.castExpression_return castExpression85 = default(PsimulexParser.castExpression_return);



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
            case 151:
            	{
                int LA23_4 = input.LA(2);

                if ( (synpred54_Psimulex()) )
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

                    	PushFollow(FOLLOW_unaryPrefixExpression_in_unaryExpression1491);
                    	unaryPrefixExpression83 = unaryPrefixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPrefixExpression83.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:7: unaryPostfixExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPostfixExpression_in_unaryExpression1499);
                    	unaryPostfixExpression84 = unaryPostfixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryPostfixExpression84.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:4: castExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpression1504);
                    	castExpression85 = castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, castExpression85.Tree);

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

        PsimulexParser.unaryPrefixOp_return unaryPrefixOp86 = default(PsimulexParser.unaryPrefixOp_return);

        PsimulexParser.unaryExpression_return unaryExpression87 = default(PsimulexParser.unaryExpression_return);


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
            	PushFollow(FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1518);
            	unaryPrefixOp86 = unaryPrefixOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryPrefixOp.Add(unaryPrefixOp86.Tree);
            	PushFollow(FOLLOW_unaryExpression_in_unaryPrefixExpression1520);
            	unaryExpression87 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryExpression.Add(unaryExpression87.Tree);


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

        PsimulexParser.leftValueExpression_return leftValueExpression88 = default(PsimulexParser.leftValueExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp89 = default(PsimulexParser.unaryPostfixOp_return);

        PsimulexParser.primaryExpression_return primaryExpression90 = default(PsimulexParser.primaryExpression_return);



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

                if ( (synpred56_Psimulex()) )
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

                if ( (synpred56_Psimulex()) )
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
            case 151:
            	{
                int LA25_3 = input.LA(2);

                if ( (synpred56_Psimulex()) )
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

                    	PushFollow(FOLLOW_leftValueExpression_in_unaryPostfixExpression1550);
                    	leftValueExpression88 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValueExpression88.Tree);
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
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1553);
                    	        	unaryPostfixOp89 = unaryPostfixOp();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp89.Tree, root_0);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:332:4: primaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryPostfixExpression1561);
                    	primaryExpression90 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression90.Tree);

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

        PsimulexParser.leftValue_return leftValue91 = default(PsimulexParser.leftValue_return);

        PsimulexParser.unaryPrefixAssignerOp_return unaryPrefixAssignerOp92 = default(PsimulexParser.unaryPrefixAssignerOp_return);

        PsimulexParser.leftValueExpression_return leftValueExpression93 = default(PsimulexParser.leftValueExpression_return);


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

            if ( (LA26_0 == Identifier || LA26_0 == Reference || LA26_0 == 151) )
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

                    	PushFollow(FOLLOW_leftValue_in_leftValueExpression1572);
                    	leftValue91 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue91.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:4: unaryPrefixAssignerOp leftValueExpression
                    {
                    	PushFollow(FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1577);
                    	unaryPrefixAssignerOp92 = unaryPrefixAssignerOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_unaryPrefixAssignerOp.Add(unaryPrefixAssignerOp92.Tree);
                    	PushFollow(FOLLOW_leftValueExpression_in_leftValueExpression1579);
                    	leftValueExpression93 = leftValueExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_leftValueExpression.Add(leftValueExpression93.Tree);


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

        IToken char_literal94 = null;
        IToken char_literal96 = null;
        PsimulexParser.dataType_return dataType95 = default(PsimulexParser.dataType_return);

        PsimulexParser.unaryExpression_return unaryExpression97 = default(PsimulexParser.unaryExpression_return);


        CommonTree char_literal94_tree=null;
        CommonTree char_literal96_tree=null;
        RewriteRuleTokenStream stream_152 = new RewriteRuleTokenStream(adaptor,"token 152");
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
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
            	char_literal94=(IToken)Match(input,151,FOLLOW_151_in_castExpression1610); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_151.Add(char_literal94);

            	PushFollow(FOLLOW_dataType_in_castExpression1612);
            	dataType95 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataType.Add(dataType95.Tree);
            	char_literal96=(IToken)Match(input,152,FOLLOW_152_in_castExpression1614); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_152.Add(char_literal96);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1616);
            	unaryExpression97 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_unaryExpression.Add(unaryExpression97.Tree);


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

        IToken set98 = null;

        CommonTree set98_tree=null;

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

            	set98 = (IToken)input.LT(1);
            	if ( input.LA(1) == Minus || input.LA(1) == LogicalNot ) 
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

        IToken set99 = null;

        CommonTree set99_tree=null;

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

        IToken set100 = null;

        CommonTree set100_tree=null;

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

            	set100 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
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

        PsimulexParser.parExpression_return parExpression101 = default(PsimulexParser.parExpression_return);

        PsimulexParser.leftValue_return leftValue102 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal103 = default(PsimulexParser.literal_return);

        PsimulexParser.functionCall_return functionCall104 = default(PsimulexParser.functionCall_return);

        PsimulexParser.initializer_return initializer105 = default(PsimulexParser.initializer_return);



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
            case 151:
            	{
                int LA27_1 = input.LA(2);

                if ( (synpred61_Psimulex()) )
                {
                    alt27 = 1;
                }
                else if ( (synpred62_Psimulex()) )
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

                if ( (synpred62_Psimulex()) )
                {
                    alt27 = 2;
                }
                else if ( (synpred64_Psimulex()) )
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

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1685);
                    	parExpression101 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression101.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1693);
                    	leftValue102 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue102.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1703);
                    	literal103 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal103.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:7: functionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionCall_in_primaryExpression1711);
                    	functionCall104 = functionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall104.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:361:7: initializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_initializer_in_primaryExpression1719);
                    	initializer105 = initializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, initializer105.Tree);

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

        IToken char_literal106 = null;
        IToken char_literal108 = null;
        PsimulexParser.expression_return expression107 = default(PsimulexParser.expression_return);


        CommonTree char_literal106_tree=null;
        CommonTree char_literal108_tree=null;

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

            	char_literal106=(IToken)Match(input,151,FOLLOW_151_in_parExpression1738); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1741);
            	expression107 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression107.Tree);
            	char_literal108=(IToken)Match(input,152,FOLLOW_152_in_parExpression1743); if (state.failed) return retval;

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

        PsimulexParser.variable_return variable109 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting110 = default(PsimulexParser.selecting_return);



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

                if ( (LA28_2 == 148 || LA28_2 == 151 || LA28_2 == 153) )
                {
                    alt28 = 2;
                }
                else if ( (LA28_2 == EOF || LA28_2 == Assign || (LA28_2 >= AssignAndAdd && LA28_2 <= Modulo) || (LA28_2 >= PlusPlus && LA28_2 <= MinusMinus) || LA28_2 == To || LA28_2 == 145 || LA28_2 == 147 || (LA28_2 >= 149 && LA28_2 <= 150) || LA28_2 == 152) )
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
            case 151:
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

                    	PushFollow(FOLLOW_variable_in_leftValue1758);
                    	variable109 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable109.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:370:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1763);
                    	selecting110 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting110.Tree);

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

        IToken Reference111 = null;
        IToken Identifier112 = null;

        CommonTree Reference111_tree=null;
        CommonTree Identifier112_tree=null;
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
            	        	Reference111=(IToken)Match(input,Reference,FOLLOW_Reference_in_variable1774); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Reference.Add(Reference111);


            	        }
            	        break;

            	}

            	Identifier112=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1777); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier112);



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

        PsimulexParser.selector_return selector113 = default(PsimulexParser.selector_return);


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
            	PushFollow(FOLLOW_selector_in_selecting1799);
            	selector113 = selector();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_selector.Add(selector113.Tree);


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

        IToken Identifier114 = null;
        PsimulexParser.parExpression_return parExpression115 = default(PsimulexParser.parExpression_return);

        PsimulexParser.functionCall_return functionCall116 = default(PsimulexParser.functionCall_return);

        PsimulexParser.memberSelect_return memberSelect117 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall118 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing119 = default(PsimulexParser.indexing_return);


        CommonTree Identifier114_tree=null;

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

            	    if ( (LA30_1 == 151) )
            	    {
            	        alt30 = 3;
            	    }
            	    else if ( (LA30_1 == 148 || LA30_1 == 153) )
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
            	else if ( (LA30_0 == 151) )
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
            	        	Identifier114=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selector1827); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier114_tree = (CommonTree)adaptor.Create(Identifier114);
            	        		adaptor.AddChild(root_0, Identifier114_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:24: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selector1831);
            	        	parExpression115 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression115.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:40: functionCall
            	        {
            	        	PushFollow(FOLLOW_functionCall_in_selector1835);
            	        	functionCall116 = functionCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall116.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:6: ( memberSelect | memberFunctionCall | indexing )+
            	int cnt31 = 0;
            	do 
            	{
            	    int alt31 = 4;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == 153) )
            	    {
            	        int LA31_2 = input.LA(2);

            	        if ( (LA31_2 == Identifier) )
            	        {
            	            int LA31_4 = input.LA(3);

            	            if ( (LA31_4 == 151) )
            	            {
            	                alt31 = 2;
            	            }
            	            else if ( (LA31_4 == EOF || LA31_4 == Assign || (LA31_4 >= AssignAndAdd && LA31_4 <= Modulo) || (LA31_4 >= PlusPlus && LA31_4 <= MinusMinus) || LA31_4 == To || LA31_4 == 145 || (LA31_4 >= 147 && LA31_4 <= 150) || (LA31_4 >= 152 && LA31_4 <= 153)) )
            	            {
            	                alt31 = 1;
            	            }


            	        }


            	    }
            	    else if ( (LA31_0 == 148) )
            	    {
            	        alt31 = 3;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:8: memberSelect
            			    {
            			    	PushFollow(FOLLOW_memberSelect_in_selector1846);
            			    	memberSelect117 = memberSelect();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect117.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:23: memberFunctionCall
            			    {
            			    	PushFollow(FOLLOW_memberFunctionCall_in_selector1850);
            			    	memberFunctionCall118 = memberFunctionCall();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall118.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:44: indexing
            			    {
            			    	PushFollow(FOLLOW_indexing_in_selector1854);
            			    	indexing119 = indexing();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing119.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt31 >= 1 ) goto loop31;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(31, input);
            		            throw eee;
            	    }
            	    cnt31++;
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whinging that label 'loop31' has no statements


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

        IToken char_literal120 = null;
        IToken Identifier121 = null;

        CommonTree char_literal120_tree=null;
        CommonTree Identifier121_tree=null;
        RewriteRuleTokenStream stream_153 = new RewriteRuleTokenStream(adaptor,"token 153");
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
            	char_literal120=(IToken)Match(input,153,FOLLOW_153_in_memberSelect1871); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_153.Add(char_literal120);

            	Identifier121=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect1873); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier121);



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

        IToken char_literal122 = null;
        IToken Identifier123 = null;
        PsimulexParser.arguments_return arguments124 = default(PsimulexParser.arguments_return);


        CommonTree char_literal122_tree=null;
        CommonTree Identifier123_tree=null;
        RewriteRuleTokenStream stream_153 = new RewriteRuleTokenStream(adaptor,"token 153");
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
            	char_literal122=(IToken)Match(input,153,FOLLOW_153_in_memberFunctionCall1894); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_153.Add(char_literal122);

            	Identifier123=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall1896); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier123);

            	PushFollow(FOLLOW_arguments_in_memberFunctionCall1898);
            	arguments124 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments124.Tree);


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

        IToken Identifier125 = null;
        PsimulexParser.arguments_return arguments126 = default(PsimulexParser.arguments_return);


        CommonTree Identifier125_tree=null;
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
            	Identifier125=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionCall1921); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier125);

            	PushFollow(FOLLOW_arguments_in_functionCall1923);
            	arguments126 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments126.Tree);


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

        IToken char_literal127 = null;
        IToken char_literal129 = null;
        IToken char_literal131 = null;
        PsimulexParser.expression_return expression128 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression130 = default(PsimulexParser.expression_return);


        CommonTree char_literal127_tree=null;
        CommonTree char_literal129_tree=null;
        CommonTree char_literal131_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
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
            	char_literal127=(IToken)Match(input,148,FOLLOW_148_in_indexing1946); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal127);

            	PushFollow(FOLLOW_expression_in_indexing1948);
            	expression128 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression128.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:19: ( ',' expression )*
            	do 
            	{
            	    int alt32 = 2;
            	    int LA32_0 = input.LA(1);

            	    if ( (LA32_0 == 149) )
            	    {
            	        alt32 = 1;
            	    }


            	    switch (alt32) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:21: ',' expression
            			    {
            			    	char_literal129=(IToken)Match(input,149,FOLLOW_149_in_indexing1952); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_149.Add(char_literal129);

            			    	PushFollow(FOLLOW_expression_in_indexing1954);
            			    	expression130 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_expression.Add(expression130.Tree);

            			    }
            			    break;

            			default:
            			    goto loop32;
            	    }
            	} while (true);

            	loop32:
            		;	// Stops C# compiler whining that label 'loop32' has no statements

            	char_literal131=(IToken)Match(input,150,FOLLOW_150_in_indexing1959); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_150.Add(char_literal131);



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

        IToken char_literal132 = null;
        IToken char_literal134 = null;
        IToken char_literal136 = null;
        PsimulexParser.expression_return expression133 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression135 = default(PsimulexParser.expression_return);


        CommonTree char_literal132_tree=null;
        CommonTree char_literal134_tree=null;
        CommonTree char_literal136_tree=null;
        RewriteRuleTokenStream stream_152 = new RewriteRuleTokenStream(adaptor,"token 152");
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
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
            	char_literal132=(IToken)Match(input,151,FOLLOW_151_in_arguments1993); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_151.Add(char_literal132);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:13: ( expression ( ',' expression )* )?
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == StringLiteral || LA34_0 == Identifier || LA34_0 == Reference || LA34_0 == Minus || (LA34_0 >= LogicalNot && LA34_0 <= New) || LA34_0 == 151) )
            	{
            	    alt34 = 1;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:15: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_arguments1997);
            	        	expression133 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_expression.Add(expression133.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:26: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt33 = 2;
            	        	    int LA33_0 = input.LA(1);

            	        	    if ( (LA33_0 == 149) )
            	        	    {
            	        	        alt33 = 1;
            	        	    }


            	        	    switch (alt33) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:27: ',' expression
            	        			    {
            	        			    	char_literal134=(IToken)Match(input,149,FOLLOW_149_in_arguments2000); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_149.Add(char_literal134);

            	        			    	PushFollow(FOLLOW_expression_in_arguments2002);
            	        			    	expression135 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_expression.Add(expression135.Tree);

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

            	char_literal136=(IToken)Match(input,152,FOLLOW_152_in_arguments2009); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_152.Add(char_literal136);



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

        IToken set137 = null;

        CommonTree set137_tree=null;

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

            	set137 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || (input.LA(1) >= IntegerLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set137));
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

        PsimulexParser.literal_return literal138 = default(PsimulexParser.literal_return);

        PsimulexParser.constantInitializer_return constantInitializer139 = default(PsimulexParser.constantInitializer_return);



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

                    	PushFollow(FOLLOW_literal_in_constantData2120);
                    	literal138 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal138.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:14: constantInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantInitializer_in_constantData2124);
                    	constantInitializer139 = constantInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantInitializer139.Tree);

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

        PsimulexParser.type_return type140 = default(PsimulexParser.type_return);



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

            	PushFollow(FOLLOW_type_in_collectionType2146);
            	type140 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type140.Tree);

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

        PsimulexParser.collectionInitializer_return collectionInitializer141 = default(PsimulexParser.collectionInitializer_return);

        PsimulexParser.arrayInitializer_return arrayInitializer142 = default(PsimulexParser.arrayInitializer_return);



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

                    if ( (LA36_2 == 148) )
                    {
                        int LA36_5 = input.LA(4);

                        if ( ((LA36_5 >= 149 && LA36_5 <= 150)) )
                        {
                            alt36 = 1;
                        }
                        else if ( (LA36_5 == StringLiteral || LA36_5 == Identifier || LA36_5 == Reference || LA36_5 == Minus || (LA36_5 >= LogicalNot && LA36_5 <= New) || LA36_5 == 151) )
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
                    else if ( (LA36_2 == 146) )
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

                    if ( (LA36_3 == 148) )
                    {
                        int LA36_5 = input.LA(4);

                        if ( ((LA36_5 >= 149 && LA36_5 <= 150)) )
                        {
                            alt36 = 1;
                        }
                        else if ( (LA36_5 == StringLiteral || LA36_5 == Identifier || LA36_5 == Reference || LA36_5 == Minus || (LA36_5 >= LogicalNot && LA36_5 <= New) || LA36_5 == 151) )
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
                    else if ( (LA36_3 == 146) )
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

                    if ( (LA36_4 == 148) )
                    {
                        int LA36_5 = input.LA(4);

                        if ( ((LA36_5 >= 149 && LA36_5 <= 150)) )
                        {
                            alt36 = 1;
                        }
                        else if ( (LA36_5 == StringLiteral || LA36_5 == Identifier || LA36_5 == Reference || LA36_5 == Minus || (LA36_5 >= LogicalNot && LA36_5 <= New) || LA36_5 == 151) )
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
                    else if ( (LA36_4 == 146) )
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

                    	PushFollow(FOLLOW_collectionInitializer_in_initializer2158);
                    	collectionInitializer141 = collectionInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, collectionInitializer141.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:28: arrayInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInitializer_in_initializer2162);
                    	arrayInitializer142 = arrayInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInitializer142.Tree);

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

        IToken New143 = null;
        IToken char_literal145 = null;
        IToken char_literal147 = null;
        IToken char_literal149 = null;
        PsimulexParser.collectionType_return collectionType144 = default(PsimulexParser.collectionType_return);

        PsimulexParser.expression_return expression146 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression148 = default(PsimulexParser.expression_return);


        CommonTree New143_tree=null;
        CommonTree char_literal145_tree=null;
        CommonTree char_literal147_tree=null;
        CommonTree char_literal149_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
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
            	New143=(IToken)Match(input,New,FOLLOW_New_in_collectionInitializer2174); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_New.Add(New143);

            	PushFollow(FOLLOW_collectionType_in_collectionInitializer2176);
            	collectionType144 = collectionType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_collectionType.Add(collectionType144.Tree);
            	char_literal145=(IToken)Match(input,146,FOLLOW_146_in_collectionInitializer2178); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_146.Add(char_literal145);

            	PushFollow(FOLLOW_expression_in_collectionInitializer2180);
            	expression146 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression146.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:38: ( ',' expression )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == 149) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:436:40: ',' expression
            			    {
            			    	char_literal147=(IToken)Match(input,149,FOLLOW_149_in_collectionInitializer2184); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_149.Add(char_literal147);

            			    	PushFollow(FOLLOW_expression_in_collectionInitializer2186);
            			    	expression148 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_expression.Add(expression148.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements

            	char_literal149=(IToken)Match(input,147,FOLLOW_147_in_collectionInitializer2191); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_147.Add(char_literal149);



            	// AST REWRITE
            	// elements:          collectionType, expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        IToken New150 = null;
        IToken char_literal152 = null;
        IToken char_literal154 = null;
        IToken char_literal156 = null;
        PsimulexParser.dataType_return dataType151 = default(PsimulexParser.dataType_return);

        PsimulexParser.expression_return expression153 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression155 = default(PsimulexParser.expression_return);


        CommonTree New150_tree=null;
        CommonTree char_literal152_tree=null;
        CommonTree char_literal154_tree=null;
        CommonTree char_literal156_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
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
            	New150=(IToken)Match(input,New,FOLLOW_New_in_arrayInitializer2221); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_New.Add(New150);

            	PushFollow(FOLLOW_dataType_in_arrayInitializer2223);
            	dataType151 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataType.Add(dataType151.Tree);
            	char_literal152=(IToken)Match(input,148,FOLLOW_148_in_arrayInitializer2225); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal152);

            	PushFollow(FOLLOW_expression_in_arrayInitializer2227);
            	expression153 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression153.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:32: ( ',' expression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 149) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:440:34: ',' expression
            			    {
            			    	char_literal154=(IToken)Match(input,149,FOLLOW_149_in_arrayInitializer2231); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_149.Add(char_literal154);

            			    	PushFollow(FOLLOW_expression_in_arrayInitializer2233);
            			    	expression155 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_expression.Add(expression155.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements

            	char_literal156=(IToken)Match(input,150,FOLLOW_150_in_arrayInitializer2238); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_150.Add(char_literal156);



            	// AST REWRITE
            	// elements:          dataType, expression, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        PsimulexParser.constantCollectionInitializer_return constantCollectionInitializer157 = default(PsimulexParser.constantCollectionInitializer_return);

        PsimulexParser.constantArrayInitializer_return constantArrayInitializer158 = default(PsimulexParser.constantArrayInitializer_return);



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

                    if ( (LA39_2 == 148) )
                    {
                        int LA39_5 = input.LA(4);

                        if ( (LA39_5 == StringLiteral || (LA39_5 >= IntegerLiteral && LA39_5 <= New)) )
                        {
                            alt39 = 2;
                        }
                        else if ( ((LA39_5 >= 149 && LA39_5 <= 150)) )
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
                    else if ( (LA39_2 == 146) )
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

                    if ( (LA39_3 == 148) )
                    {
                        int LA39_5 = input.LA(4);

                        if ( (LA39_5 == StringLiteral || (LA39_5 >= IntegerLiteral && LA39_5 <= New)) )
                        {
                            alt39 = 2;
                        }
                        else if ( ((LA39_5 >= 149 && LA39_5 <= 150)) )
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
                    else if ( (LA39_3 == 146) )
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

                    if ( (LA39_4 == 148) )
                    {
                        int LA39_5 = input.LA(4);

                        if ( (LA39_5 == StringLiteral || (LA39_5 >= IntegerLiteral && LA39_5 <= New)) )
                        {
                            alt39 = 2;
                        }
                        else if ( ((LA39_5 >= 149 && LA39_5 <= 150)) )
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
                    else if ( (LA39_4 == 146) )
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

                    	PushFollow(FOLLOW_constantCollectionInitializer_in_constantInitializer2273);
                    	constantCollectionInitializer157 = constantCollectionInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantCollectionInitializer157.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:36: constantArrayInitializer
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_constantArrayInitializer_in_constantInitializer2277);
                    	constantArrayInitializer158 = constantArrayInitializer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constantArrayInitializer158.Tree);

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

        IToken New159 = null;
        IToken char_literal161 = null;
        IToken char_literal163 = null;
        IToken char_literal165 = null;
        PsimulexParser.collectionType_return collectionType160 = default(PsimulexParser.collectionType_return);

        PsimulexParser.constantData_return constantData162 = default(PsimulexParser.constantData_return);

        PsimulexParser.constantData_return constantData164 = default(PsimulexParser.constantData_return);


        CommonTree New159_tree=null;
        CommonTree char_literal161_tree=null;
        CommonTree char_literal163_tree=null;
        CommonTree char_literal165_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
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
            	New159=(IToken)Match(input,New,FOLLOW_New_in_constantCollectionInitializer2289); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_New.Add(New159);

            	PushFollow(FOLLOW_collectionType_in_constantCollectionInitializer2291);
            	collectionType160 = collectionType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_collectionType.Add(collectionType160.Tree);
            	char_literal161=(IToken)Match(input,146,FOLLOW_146_in_constantCollectionInitializer2293); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_146.Add(char_literal161);

            	PushFollow(FOLLOW_constantData_in_constantCollectionInitializer2295);
            	constantData162 = constantData();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_constantData.Add(constantData162.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:40: ( ',' constantData )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == 149) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:42: ',' constantData
            			    {
            			    	char_literal163=(IToken)Match(input,149,FOLLOW_149_in_constantCollectionInitializer2299); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_149.Add(char_literal163);

            			    	PushFollow(FOLLOW_constantData_in_constantCollectionInitializer2301);
            			    	constantData164 = constantData();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_constantData.Add(constantData164.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	char_literal165=(IToken)Match(input,147,FOLLOW_147_in_constantCollectionInitializer2306); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_147.Add(char_literal165);



            	// AST REWRITE
            	// elements:          constantData, constantData, collectionType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        IToken New166 = null;
        IToken char_literal168 = null;
        IToken char_literal170 = null;
        IToken char_literal172 = null;
        PsimulexParser.dataType_return dataType167 = default(PsimulexParser.dataType_return);

        PsimulexParser.constantData_return constantData169 = default(PsimulexParser.constantData_return);

        PsimulexParser.constantData_return constantData171 = default(PsimulexParser.constantData_return);


        CommonTree New166_tree=null;
        CommonTree char_literal168_tree=null;
        CommonTree char_literal170_tree=null;
        CommonTree char_literal172_tree=null;
        RewriteRuleTokenStream stream_150 = new RewriteRuleTokenStream(adaptor,"token 150");
        RewriteRuleTokenStream stream_148 = new RewriteRuleTokenStream(adaptor,"token 148");
        RewriteRuleTokenStream stream_149 = new RewriteRuleTokenStream(adaptor,"token 149");
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
            	New166=(IToken)Match(input,New,FOLLOW_New_in_constantArrayInitializer2336); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_New.Add(New166);

            	PushFollow(FOLLOW_dataType_in_constantArrayInitializer2338);
            	dataType167 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataType.Add(dataType167.Tree);
            	char_literal168=(IToken)Match(input,148,FOLLOW_148_in_constantArrayInitializer2340); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_148.Add(char_literal168);

            	PushFollow(FOLLOW_constantData_in_constantArrayInitializer2342);
            	constantData169 = constantData();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_constantData.Add(constantData169.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:34: ( ',' constantData )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == 149) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:454:36: ',' constantData
            			    {
            			    	char_literal170=(IToken)Match(input,149,FOLLOW_149_in_constantArrayInitializer2346); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_149.Add(char_literal170);

            			    	PushFollow(FOLLOW_constantData_in_constantArrayInitializer2348);
            			    	constantData171 = constantData();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_constantData.Add(constantData171.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	char_literal172=(IToken)Match(input,150,FOLLOW_150_in_constantArrayInitializer2353); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_150.Add(char_literal172);



            	// AST REWRITE
            	// elements:          constantData, constantData, dataType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        IToken char_literal173 = null;
        IToken char_literal175 = null;
        PsimulexParser.statement_return statement174 = default(PsimulexParser.statement_return);


        CommonTree char_literal173_tree=null;
        CommonTree char_literal175_tree=null;
        RewriteRuleTokenStream stream_146 = new RewriteRuleTokenStream(adaptor,"token 146");
        RewriteRuleTokenStream stream_147 = new RewriteRuleTokenStream(adaptor,"token 147");
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
            	char_literal173=(IToken)Match(input,146,FOLLOW_146_in_block2405); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_146.Add(char_literal173);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:497:13: ( statement )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == StringLiteral || LA42_0 == Identifier || (LA42_0 >= Reference && LA42_0 <= Iterator) || LA42_0 == Minus || (LA42_0 >= LogicalNot && LA42_0 <= If) || (LA42_0 >= For && LA42_0 <= ForEach) || LA42_0 == Loop || LA42_0 == 145 || LA42_0 == 151) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block2407);
            			    	statement174 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_statement.Add(statement174.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements

            	char_literal175=(IToken)Match(input,147,FOLLOW_147_in_block2410); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_147.Add(char_literal175);



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

        PsimulexParser.block_return block176 = default(PsimulexParser.block_return);

        PsimulexParser.statement_return statement177 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:501:5: ( block | statement )
            int alt43 = 2;
            int LA43_0 = input.LA(1);

            if ( (LA43_0 == 146) )
            {
                alt43 = 1;
            }
            else if ( (LA43_0 == StringLiteral || LA43_0 == Identifier || (LA43_0 >= Reference && LA43_0 <= Iterator) || LA43_0 == Minus || (LA43_0 >= LogicalNot && LA43_0 <= If) || (LA43_0 >= For && LA43_0 <= ForEach) || LA43_0 == Loop || LA43_0 == 145 || LA43_0 == 151) )
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

                    	PushFollow(FOLLOW_block_in_branch2452);
                    	block176 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block176.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:501:15: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_branch2456);
                    	statement177 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement177.Tree);

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

        IToken PDo186 = null;
        IToken Async188 = null;
        IToken Lock190 = null;
        IToken char_literal191 = null;
        IToken Identifier192 = null;
        IToken char_literal193 = null;
        IToken Return195 = null;
        IToken char_literal197 = null;
        IToken Break198 = null;
        IToken char_literal199 = null;
        IToken char_literal200 = null;
        IToken char_literal202 = null;
        IToken char_literal204 = null;
        PsimulexParser.ifStatement_return ifStatement178 = default(PsimulexParser.ifStatement_return);

        PsimulexParser.forStatement_return forStatement179 = default(PsimulexParser.forStatement_return);

        PsimulexParser.pForStatement_return pForStatement180 = default(PsimulexParser.pForStatement_return);

        PsimulexParser.forEachStatement_return forEachStatement181 = default(PsimulexParser.forEachStatement_return);

        PsimulexParser.pForEachStatement_return pForEachStatement182 = default(PsimulexParser.pForEachStatement_return);

        PsimulexParser.loopStatement_return loopStatement183 = default(PsimulexParser.loopStatement_return);

        PsimulexParser.whileStatement_return whileStatement184 = default(PsimulexParser.whileStatement_return);

        PsimulexParser.doStatement_return doStatement185 = default(PsimulexParser.doStatement_return);

        PsimulexParser.block_return block187 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block189 = default(PsimulexParser.block_return);

        PsimulexParser.block_return block194 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression196 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression201 = default(PsimulexParser.expression_return);

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration203 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree PDo186_tree=null;
        CommonTree Async188_tree=null;
        CommonTree Lock190_tree=null;
        CommonTree char_literal191_tree=null;
        CommonTree Identifier192_tree=null;
        CommonTree char_literal193_tree=null;
        CommonTree Return195_tree=null;
        CommonTree char_literal197_tree=null;
        CommonTree Break198_tree=null;
        CommonTree char_literal199_tree=null;
        CommonTree char_literal200_tree=null;
        CommonTree char_literal202_tree=null;
        CommonTree char_literal204_tree=null;
        RewriteRuleTokenStream stream_152 = new RewriteRuleTokenStream(adaptor,"token 152");
        RewriteRuleTokenStream stream_Async = new RewriteRuleTokenStream(adaptor,"token Async");
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
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
                    	PushFollow(FOLLOW_ifStatement_in_statement2473);
                    	ifStatement178 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_ifStatement.Add(ifStatement178.Tree);


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
                    	        	PushFollow(FOLLOW_forStatement_in_statement2493);
                    	        	forStatement179 = forStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatement179.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:506:24: pForStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForStatement_in_statement2497);
                    	        	pForStatement180 = pForStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForStatement180.Tree);

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
                    	        	PushFollow(FOLLOW_forEachStatement_in_statement2511);
                    	        	forEachStatement181 = forEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachStatement181.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:507:30: pForEachStatement
                    	        {
                    	        	PushFollow(FOLLOW_pForEachStatement_in_statement2515);
                    	        	pForEachStatement182 = pForEachStatement();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, pForEachStatement182.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:508:9: loopStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_loopStatement_in_statement2527);
                    	loopStatement183 = loopStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopStatement183.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:509:9: whileStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileStatement_in_statement2537);
                    	whileStatement184 = whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileStatement184.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:510:9: doStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doStatement_in_statement2547);
                    	doStatement185 = doStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, doStatement185.Tree);

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:511:9: PDo block
                    {
                    	PDo186=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement2560); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_PDo.Add(PDo186);

                    	PushFollow(FOLLOW_block_in_statement2562);
                    	block187 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block187.Tree);


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
                    	Async188=(IToken)Match(input,Async,FOLLOW_Async_in_statement2591); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Async.Add(Async188);

                    	PushFollow(FOLLOW_block_in_statement2593);
                    	block189 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block189.Tree);


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
                    	Lock190=(IToken)Match(input,Lock,FOLLOW_Lock_in_statement2621); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Lock.Add(Lock190);

                    	char_literal191=(IToken)Match(input,151,FOLLOW_151_in_statement2623); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_151.Add(char_literal191);

                    	Identifier192=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_statement2625); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier192);

                    	char_literal193=(IToken)Match(input,152,FOLLOW_152_in_statement2627); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_152.Add(char_literal193);

                    	PushFollow(FOLLOW_block_in_statement2629);
                    	block194 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_block.Add(block194.Tree);


                    	// AST REWRITE
                    	// elements:          block, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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
                    	Return195=(IToken)Match(input,Return,FOLLOW_Return_in_statement2652); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Return.Add(Return195);

                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:514:16: ( expression )?
                    	int alt46 = 2;
                    	int LA46_0 = input.LA(1);

                    	if ( (LA46_0 == StringLiteral || LA46_0 == Identifier || LA46_0 == Reference || LA46_0 == Minus || (LA46_0 >= LogicalNot && LA46_0 <= New) || LA46_0 == 151) )
                    	{
                    	    alt46 = 1;
                    	}
                    	switch (alt46) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement2654);
                    	        	expression196 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking==0 ) stream_expression.Add(expression196.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal197=(IToken)Match(input,145,FOLLOW_145_in_statement2657); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_145.Add(char_literal197);



                    	// AST REWRITE
                    	// elements:          Return, expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

                    	Break198=(IToken)Match(input,Break,FOLLOW_Break_in_statement2680); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break198_tree = (CommonTree)adaptor.Create(Break198);
                    		adaptor.AddChild(root_0, Break198_tree);
                    	}
                    	char_literal199=(IToken)Match(input,145,FOLLOW_145_in_statement2682); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:517:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal200=(IToken)Match(input,145,FOLLOW_145_in_statement2694); if (state.failed) return retval;

                    }
                    break;
                case 13 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:518:9: expression ';'
                    {
                    	PushFollow(FOLLOW_expression_in_statement2705);
                    	expression201 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_expression.Add(expression201.Tree);
                    	char_literal202=(IToken)Match(input,145,FOLLOW_145_in_statement2707); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_145.Add(char_literal202);



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
                    	PushFollow(FOLLOW_localVariableDeclaration_in_statement2725);
                    	localVariableDeclaration203 = localVariableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_localVariableDeclaration.Add(localVariableDeclaration203.Tree);
                    	char_literal204=(IToken)Match(input,145,FOLLOW_145_in_statement2727); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_145.Add(char_literal204);



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

        IToken Identifier206 = null;
        IToken Reference208 = null;
        IToken Identifier209 = null;
        IToken Assign210 = null;
        PsimulexParser.type_return type205 = default(PsimulexParser.type_return);

        PsimulexParser.type_return type207 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression211 = default(PsimulexParser.expression_return);


        CommonTree Identifier206_tree=null;
        CommonTree Reference208_tree=null;
        CommonTree Identifier209_tree=null;
        CommonTree Assign210_tree=null;
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
                    	PushFollow(FOLLOW_type_in_localVariableDeclaration2760);
                    	type205 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_type.Add(type205.Tree);
                    	Identifier206=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_localVariableDeclaration2762); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier206);



                    	// AST REWRITE
                    	// elements:          type, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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
                    	PushFollow(FOLLOW_type_in_localVariableDeclaration2786);
                    	type207 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_type.Add(type207.Tree);
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
                    	        	Reference208=(IToken)Match(input,Reference,FOLLOW_Reference_in_localVariableDeclaration2788); if (state.failed) return retval; 
                    	        	if ( state.backtracking==0 ) stream_Reference.Add(Reference208);


                    	        }
                    	        break;

                    	}

                    	Identifier209=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_localVariableDeclaration2791); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier209);

                    	Assign210=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration2793); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign210);

                    	PushFollow(FOLLOW_expression_in_localVariableDeclaration2795);
                    	expression211 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_expression.Add(expression211.Tree);


                    	// AST REWRITE
                    	// elements:          expression, type, Reference, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	if ( state.backtracking==0 ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        PsimulexParser.ifBranch_return ifBranch212 = default(PsimulexParser.ifBranch_return);

        PsimulexParser.elseIfBranches_return elseIfBranches213 = default(PsimulexParser.elseIfBranches_return);

        PsimulexParser.elseBranch_return elseBranch214 = default(PsimulexParser.elseBranch_return);

        PsimulexParser.elseBranch_return elseBranch215 = default(PsimulexParser.elseBranch_return);



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

            	PushFollow(FOLLOW_ifBranch_in_ifStatement2831);
            	ifBranch212 = ifBranch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifBranch212.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:26: ( ( elseIfBranches elseBranch ) | ( elseBranch )? )
            	int alt51 = 2;
            	switch ( input.LA(1) ) 
            	{
            	case ElseIf:
            		{
            	    int LA51_1 = input.LA(2);

            	    if ( (synpred108_Psimulex()) )
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

            	    if ( (synpred108_Psimulex()) )
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
            	case 145:
            	case 147:
            	case 151:
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
            	        		PushFollow(FOLLOW_elseIfBranches_in_ifStatement2837);
            	        		elseIfBranches213 = elseIfBranches();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseIfBranches213.Tree);
            	        		PushFollow(FOLLOW_elseBranch_in_ifStatement2839);
            	        		elseBranch214 = elseBranch();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch214.Tree);

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

            	        	    if ( (synpred109_Psimulex()) )
            	        	    {
            	        	        alt50 = 1;
            	        	    }
            	        	}
            	        	switch (alt50) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: elseBranch
            	        	        {
            	        	        	PushFollow(FOLLOW_elseBranch_in_ifStatement2845);
            	        	        	elseBranch215 = elseBranch();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elseBranch215.Tree);

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

        IToken If216 = null;
        PsimulexParser.condition_return condition217 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core218 = default(PsimulexParser.core_return);


        CommonTree If216_tree=null;
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
            	If216=(IToken)Match(input,If,FOLLOW_If_in_ifBranch2857); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_If.Add(If216);

            	PushFollow(FOLLOW_condition_in_ifBranch2859);
            	condition217 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition217.Tree);
            	PushFollow(FOLLOW_core_in_ifBranch2861);
            	core218 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core218.Tree);


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

        IToken ElseIf219 = null;
        PsimulexParser.condition_return condition220 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core221 = default(PsimulexParser.core_return);


        CommonTree ElseIf219_tree=null;
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
            			    	ElseIf219=(IToken)Match(input,ElseIf,FOLLOW_ElseIf_in_elseIfBranches2889); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_ElseIf.Add(ElseIf219);

            			    	PushFollow(FOLLOW_condition_in_elseIfBranches2891);
            			    	condition220 = condition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_condition.Add(condition220.Tree);
            			    	PushFollow(FOLLOW_core_in_elseIfBranches2893);
            			    	core221 = core();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_core.Add(core221.Tree);

            			    }
            			    break;

            			default:
            			    goto loop52;
            	    }
            	} while (true);

            	loop52:
            		;	// Stops C# compiler whining that label 'loop52' has no statements



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
            	// 531:46: -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:49: ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ELSEIFBRANCHES, "ELSEIFBRANCHES"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:531:67: ( ^( CONDITIONALBRANCH condition core ) )*
            	    while ( stream_condition.HasNext() || stream_core.HasNext() )
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

        IToken Else222 = null;
        PsimulexParser.core_return core223 = default(PsimulexParser.core_return);


        CommonTree Else222_tree=null;
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
            	Else222=(IToken)Match(input,Else,FOLLOW_Else_in_elseBranch2928); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Else.Add(Else222);

            	PushFollow(FOLLOW_core_in_elseBranch2930);
            	core223 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core223.Tree);


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

        IToken For224 = null;
        IToken char_literal225 = null;
        IToken char_literal227 = null;
        PsimulexParser.forControl_return forControl226 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core228 = default(PsimulexParser.core_return);


        CommonTree For224_tree=null;
        CommonTree char_literal225_tree=null;
        CommonTree char_literal227_tree=null;
        RewriteRuleTokenStream stream_152 = new RewriteRuleTokenStream(adaptor,"token 152");
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
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
            	For224=(IToken)Match(input,For,FOLLOW_For_in_forStatement2948); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_For.Add(For224);

            	char_literal225=(IToken)Match(input,151,FOLLOW_151_in_forStatement2950); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_151.Add(char_literal225);

            	PushFollow(FOLLOW_forControl_in_forStatement2952);
            	forControl226 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forControl.Add(forControl226.Tree);
            	char_literal227=(IToken)Match(input,152,FOLLOW_152_in_forStatement2954); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_152.Add(char_literal227);

            	PushFollow(FOLLOW_core_in_forStatement2956);
            	core228 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core228.Tree);


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

        IToken PFor229 = null;
        IToken char_literal230 = null;
        IToken char_literal232 = null;
        PsimulexParser.forControl_return forControl231 = default(PsimulexParser.forControl_return);

        PsimulexParser.core_return core233 = default(PsimulexParser.core_return);


        CommonTree PFor229_tree=null;
        CommonTree char_literal230_tree=null;
        CommonTree char_literal232_tree=null;
        RewriteRuleTokenStream stream_152 = new RewriteRuleTokenStream(adaptor,"token 152");
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
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
            	PFor229=(IToken)Match(input,PFor,FOLLOW_PFor_in_pForStatement2976); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_PFor.Add(PFor229);

            	char_literal230=(IToken)Match(input,151,FOLLOW_151_in_pForStatement2978); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_151.Add(char_literal230);

            	PushFollow(FOLLOW_forControl_in_pForStatement2980);
            	forControl231 = forControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forControl.Add(forControl231.Tree);
            	char_literal232=(IToken)Match(input,152,FOLLOW_152_in_pForStatement2982); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_152.Add(char_literal232);

            	PushFollow(FOLLOW_core_in_pForStatement2984);
            	core233 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core233.Tree);


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

        IToken char_literal235 = null;
        IToken char_literal237 = null;
        PsimulexParser.forInit_return forInit234 = default(PsimulexParser.forInit_return);

        PsimulexParser.forCondition_return forCondition236 = default(PsimulexParser.forCondition_return);

        PsimulexParser.forUpdate_return forUpdate238 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal235_tree=null;
        CommonTree char_literal237_tree=null;
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
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
            	        	PushFollow(FOLLOW_forInit_in_forControl3005);
            	        	forInit234 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forInit.Add(forInit234.Tree);

            	        }
            	        break;

            	}

            	char_literal235=(IToken)Match(input,145,FOLLOW_145_in_forControl3008); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal235);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:29: ( forCondition )?
            	int alt54 = 2;
            	int LA54_0 = input.LA(1);

            	if ( (LA54_0 == StringLiteral || LA54_0 == Identifier || LA54_0 == Reference || LA54_0 == Minus || (LA54_0 >= LogicalNot && LA54_0 <= New) || LA54_0 == 151) )
            	{
            	    alt54 = 1;
            	}
            	switch (alt54) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forCondition
            	        {
            	        	PushFollow(FOLLOW_forCondition_in_forControl3010);
            	        	forCondition236 = forCondition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forCondition.Add(forCondition236.Tree);

            	        }
            	        break;

            	}

            	char_literal237=(IToken)Match(input,145,FOLLOW_145_in_forControl3013); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal237);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:536:47: ( forUpdate )?
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == StringLiteral || LA55_0 == Identifier || LA55_0 == Reference || LA55_0 == Minus || (LA55_0 >= LogicalNot && LA55_0 <= New) || LA55_0 == 151) )
            	{
            	    alt55 = 1;
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl3015);
            	        	forUpdate238 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_forUpdate.Add(forUpdate238.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          forUpdate, forCondition, forInit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration239 = default(PsimulexParser.localVariableDeclaration_return);



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

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit3057);
            	localVariableDeclaration239 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration239.Tree);

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

        PsimulexParser.expression_return expression240 = default(PsimulexParser.expression_return);



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

            	PushFollow(FOLLOW_expression_in_forCondition3067);
            	expression240 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression240.Tree);

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

        PsimulexParser.expression_return expression241 = default(PsimulexParser.expression_return);



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

            	PushFollow(FOLLOW_expression_in_forUpdate3078);
            	expression241 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression241.Tree);

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

        IToken While242 = null;
        PsimulexParser.condition_return condition243 = default(PsimulexParser.condition_return);

        PsimulexParser.core_return core244 = default(PsimulexParser.core_return);


        CommonTree While242_tree=null;
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
            	While242=(IToken)Match(input,While,FOLLOW_While_in_whileStatement3087); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_While.Add(While242);

            	PushFollow(FOLLOW_condition_in_whileStatement3089);
            	condition243 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition243.Tree);
            	PushFollow(FOLLOW_core_in_whileStatement3091);
            	core244 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core244.Tree);


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

        IToken Do245 = null;
        IToken While247 = null;
        IToken char_literal249 = null;
        PsimulexParser.core_return core246 = default(PsimulexParser.core_return);

        PsimulexParser.condition_return condition248 = default(PsimulexParser.condition_return);


        CommonTree Do245_tree=null;
        CommonTree While247_tree=null;
        CommonTree char_literal249_tree=null;
        RewriteRuleTokenStream stream_Do = new RewriteRuleTokenStream(adaptor,"token Do");
        RewriteRuleTokenStream stream_145 = new RewriteRuleTokenStream(adaptor,"token 145");
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
            	Do245=(IToken)Match(input,Do,FOLLOW_Do_in_doStatement3113); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Do.Add(Do245);

            	PushFollow(FOLLOW_core_in_doStatement3115);
            	core246 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core246.Tree);
            	While247=(IToken)Match(input,While,FOLLOW_While_in_doStatement3117); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_While.Add(While247);

            	PushFollow(FOLLOW_condition_in_doStatement3119);
            	condition248 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_condition.Add(condition248.Tree);
            	char_literal249=(IToken)Match(input,145,FOLLOW_145_in_doStatement3121); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_145.Add(char_literal249);



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

        IToken PForEach250 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer251 = default(PsimulexParser.forEachTrailer_return);


        CommonTree PForEach250_tree=null;
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
            	PForEach250=(IToken)Match(input,PForEach,FOLLOW_PForEach_in_pForEachStatement3141); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_PForEach.Add(PForEach250);

            	PushFollow(FOLLOW_forEachTrailer_in_pForEachStatement3143);
            	forEachTrailer251 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forEachTrailer.Add(forEachTrailer251.Tree);


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

        IToken ForEach252 = null;
        PsimulexParser.forEachTrailer_return forEachTrailer253 = default(PsimulexParser.forEachTrailer_return);


        CommonTree ForEach252_tree=null;
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
            	ForEach252=(IToken)Match(input,ForEach,FOLLOW_ForEach_in_forEachStatement3160); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_ForEach.Add(ForEach252);

            	PushFollow(FOLLOW_forEachTrailer_in_forEachStatement3162);
            	forEachTrailer253 = forEachTrailer();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_forEachTrailer.Add(forEachTrailer253.Tree);


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

        IToken char_literal254 = null;
        IToken char_literal256 = null;
        PsimulexParser.forEachControl_return forEachControl255 = default(PsimulexParser.forEachControl_return);

        PsimulexParser.core_return core257 = default(PsimulexParser.core_return);


        CommonTree char_literal254_tree=null;
        CommonTree char_literal256_tree=null;

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

            	char_literal254=(IToken)Match(input,151,FOLLOW_151_in_forEachTrailer3180); if (state.failed) return retval;
            	PushFollow(FOLLOW_forEachControl_in_forEachTrailer3183);
            	forEachControl255 = forEachControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forEachControl255.Tree);
            	char_literal256=(IToken)Match(input,152,FOLLOW_152_in_forEachTrailer3185); if (state.failed) return retval;
            	PushFollow(FOLLOW_core_in_forEachTrailer3188);
            	core257 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, core257.Tree);

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

        IToken Identifier259 = null;
        IToken In260 = null;
        PsimulexParser.type_return type258 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression261 = default(PsimulexParser.expression_return);


        CommonTree Identifier259_tree=null;
        CommonTree In260_tree=null;
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
            	PushFollow(FOLLOW_type_in_forEachControl3217);
            	type258 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type258.Tree);
            	Identifier259=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_forEachControl3219); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier259);

            	In260=(IToken)Match(input,In,FOLLOW_In_in_forEachControl3221); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_In.Add(In260);

            	PushFollow(FOLLOW_expression_in_forEachControl3223);
            	expression261 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression261.Tree);


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

        IToken Loop262 = null;
        IToken char_literal263 = null;
        IToken char_literal265 = null;
        PsimulexParser.loopControl_return loopControl264 = default(PsimulexParser.loopControl_return);

        PsimulexParser.core_return core266 = default(PsimulexParser.core_return);


        CommonTree Loop262_tree=null;
        CommonTree char_literal263_tree=null;
        CommonTree char_literal265_tree=null;
        RewriteRuleTokenStream stream_152 = new RewriteRuleTokenStream(adaptor,"token 152");
        RewriteRuleTokenStream stream_151 = new RewriteRuleTokenStream(adaptor,"token 151");
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
            	Loop262=(IToken)Match(input,Loop,FOLLOW_Loop_in_loopStatement3253); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Loop.Add(Loop262);

            	char_literal263=(IToken)Match(input,151,FOLLOW_151_in_loopStatement3255); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_151.Add(char_literal263);

            	PushFollow(FOLLOW_loopControl_in_loopStatement3257);
            	loopControl264 = loopControl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_loopControl.Add(loopControl264.Tree);
            	char_literal265=(IToken)Match(input,152,FOLLOW_152_in_loopStatement3259); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_152.Add(char_literal265);

            	PushFollow(FOLLOW_core_in_loopStatement3261);
            	core266 = core();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_core.Add(core266.Tree);


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

        IToken To268 = null;
        PsimulexParser.localVariableDeclaration_return localVariableDeclaration267 = default(PsimulexParser.localVariableDeclaration_return);

        PsimulexParser.expression_return expression269 = default(PsimulexParser.expression_return);


        CommonTree To268_tree=null;
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
            	PushFollow(FOLLOW_localVariableDeclaration_in_loopControl3302);
            	localVariableDeclaration267 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_localVariableDeclaration.Add(localVariableDeclaration267.Tree);
            	To268=(IToken)Match(input,To,FOLLOW_To_in_loopControl3304); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_To.Add(To268);

            	PushFollow(FOLLOW_expression_in_loopControl3306);
            	expression269 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression269.Tree);


            	// AST REWRITE
            	// elements:          expression, localVariableDeclaration
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

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

        PsimulexParser.branch_return branch270 = default(PsimulexParser.branch_return);


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
            	PushFollow(FOLLOW_branch_in_core3335);
            	branch270 = branch();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_branch.Add(branch270.Tree);


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

        PsimulexParser.parExpression_return parExpression271 = default(PsimulexParser.parExpression_return);


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
            	PushFollow(FOLLOW_parExpression_in_condition3354);
            	parExpression271 = parExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_parExpression.Add(parExpression271.Tree);


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
            	Memoize(input, 86, condition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "condition"

    // $ANTLR start "synpred1_Psimulex"
    public void synpred1_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:9: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:9: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex355);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred2_Psimulex"
    public void synpred2_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:25: ( multiFunctionalProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:25: multiFunctionalProgram
        {
        	PushFollow(FOLLOW_multiFunctionalProgram_in_synpred2_Psimulex359);
        	multiFunctionalProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_Psimulex"

    // $ANTLR start "synpred8_Psimulex"
    public void synpred8_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:9: ( type Identifier ';' )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:9: type Identifier ';'
        {
        	PushFollow(FOLLOW_type_in_synpred8_Psimulex625);
        	type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Identifier,FOLLOW_Identifier_in_synpred8_Psimulex627); if (state.failed) return ;
        	Match(input,145,FOLLOW_145_in_synpred8_Psimulex629); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_Psimulex"

    // $ANTLR start "synpred34_Psimulex"
    public void synpred34_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred34_Psimulex1184);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_Psimulex"

    // $ANTLR start "synpred54_Psimulex"
    public void synpred54_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:7: ( unaryPostfixExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:7: unaryPostfixExpression
        {
        	PushFollow(FOLLOW_unaryPostfixExpression_in_synpred54_Psimulex1499);
        	unaryPostfixExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred54_Psimulex"

    // $ANTLR start "synpred56_Psimulex"
    public void synpred56_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:4: ( leftValueExpression ( unaryPostfixOp )? )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:4: leftValueExpression ( unaryPostfixOp )?
        {
        	PushFollow(FOLLOW_leftValueExpression_in_synpred56_Psimulex1550);
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
        	        	PushFollow(FOLLOW_unaryPostfixOp_in_synpred56_Psimulex1553);
        	        	unaryPostfixOp();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred56_Psimulex"

    // $ANTLR start "synpred61_Psimulex"
    public void synpred61_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred61_Psimulex1685);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred61_Psimulex"

    // $ANTLR start "synpred62_Psimulex"
    public void synpred62_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred62_Psimulex1693);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred62_Psimulex"

    // $ANTLR start "synpred64_Psimulex"
    public void synpred64_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:7: ( functionCall )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:7: functionCall
        {
        	PushFollow(FOLLOW_functionCall_in_synpred64_Psimulex1711);
        	functionCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred64_Psimulex"

    // $ANTLR start "synpred106_Psimulex"
    public void synpred106_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:6: ( type Identifier )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:524:6: type Identifier
        {
        	PushFollow(FOLLOW_type_in_synpred106_Psimulex2760);
        	type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Identifier,FOLLOW_Identifier_in_synpred106_Psimulex2762); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred106_Psimulex"

    // $ANTLR start "synpred108_Psimulex"
    public void synpred108_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( ( elseIfBranches elseBranch ) )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( elseIfBranches elseBranch )
        {
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:28: ( elseIfBranches elseBranch )
        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:30: elseIfBranches elseBranch
        	{
        		PushFollow(FOLLOW_elseIfBranches_in_synpred108_Psimulex2837);
        		elseIfBranches();
        		state.followingStackPointer--;
        		if (state.failed) return ;
        		PushFollow(FOLLOW_elseBranch_in_synpred108_Psimulex2839);
        		elseBranch();
        		state.followingStackPointer--;
        		if (state.failed) return ;

        	}


        }
    }
    // $ANTLR end "synpred108_Psimulex"

    // $ANTLR start "synpred109_Psimulex"
    public void synpred109_Psimulex_fragment() {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:60: ( elseBranch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:529:60: elseBranch
        {
        	PushFollow(FOLLOW_elseBranch_in_synpred109_Psimulex2845);
        	elseBranch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred109_Psimulex"

    // Delegated rules

   	public bool synpred54_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred54_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred106_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred106_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred56_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred56_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred8_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred34_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred109_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred109_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred62_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred62_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred64_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred64_Psimulex_fragment(); // can never throw exception
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
   	protected DFA7 dfa7;
   	protected DFA47 dfa47;
   	protected DFA49 dfa49;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa3 = new DFA3(this);
    	this.dfa7 = new DFA7(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa49 = new DFA49(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);

	    this.dfa7.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA7_SpecialStateTransition);

	    this.dfa49.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA49_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x1c\uffff";
    const string DFA1_eofS =
        "\x01\x18\x1b\uffff";
    const string DFA1_minS =
        "\x01\x41\x0f\uffff\x01\x00\x05\uffff\x03\x00\x03\uffff";
    const string DFA1_maxS =
        "\x01\u0097\x0f\uffff\x01\x00\x05\uffff\x03\x00\x03\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x17\uffff\x01\x02\x01\uffff\x01\x03";
    const string DFA1_specialS =
        "\x10\uffff\x01\x00\x05\uffff\x01\x01\x01\x02\x01\x03\x03\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x19\x01\x01\x01\x19\x01\x10\x01\uffff\x01\x01\x06\x16"+
            "\x0c\x17\x0e\uffff\x01\x01\x03\uffff\x10\x01\x02\uffff\x06\x01"+
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
            get { return "99:7: ( simpleProgram | multiFunctionalProgram )?"; }
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

                   	else if ( (synpred2_Psimulex()) ) { s = 25; }

                   	 
                   	input.Seek(index1_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_22 = input.LA(1);

                   	 
                   	int index1_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 25; }

                   	 
                   	input.Seek(index1_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_23 = input.LA(1);

                   	 
                   	int index1_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 25; }

                   	 
                   	input.Seek(index1_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA1_24 = input.LA(1);

                   	 
                   	int index1_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (synpred2_Psimulex()) ) { s = 25; }

                   	else if ( (true) ) { s = 27; }

                   	 
                   	input.Seek(index1_24);
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
        "\x0a\uffff";
    const string DFA3_eofS =
        "\x01\x04\x09\uffff";
    const string DFA3_minS =
        "\x04\x44\x01\uffff\x01\u0095\x01\x45\x01\u0095\x01\x44\x01\uffff";
    const string DFA3_maxS =
        "\x01\x58\x03\u0094\x01\uffff\x01\u0096\x01\u0097\x01\u0096\x01"+
        "\x46\x01\uffff";
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
        "\x04\x44\x01\u0095\x01\x45\x01\u0095\x01\x45\x01\u0095\x01\x45"+
        "\x02\x00\x02\uffff\x02\x00\x02\uffff\x02\x00\x02\uffff";
    const string DFA7_maxS =
        "\x01\x58\x03\u0094\x01\u0096\x01\u0091\x01\u0096\x01\u0091\x01"+
        "\u0096\x01\u0091\x02\x00\x02\uffff\x02\x00\x02\uffff\x02\x00\x02"+
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
                   	if ( (synpred8_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA7_11 = input.LA(1);

                   	 
                   	int index7_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA7_14 = input.LA(1);

                   	 
                   	int index7_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA7_15 = input.LA(1);

                   	 
                   	int index7_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA7_18 = input.LA(1);

                   	 
                   	int index7_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA7_19 = input.LA(1);

                   	 
                   	int index7_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index7_19);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 7, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA47_eotS =
        "\x11\uffff";
    const string DFA47_eofS =
        "\x11\uffff";
    const string DFA47_minS =
        "\x01\x42\x0d\uffff\x01\x44\x01\uffff\x01\x42";
    const string DFA47_maxS =
        "\x01\u0097\x0d\uffff\x01\u0099\x01\uffff\x01\u0097";
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
        "\x05\uffff\x01\x10\x03\uffff\x01\x10\x02\uffff\x01\x10\x14\uffff"+
        "\x01\x10\x03\uffff\x01\x10\x03\uffff\x01\x10\x19\uffff";
    const string DFA49_minS =
        "\x04\x44\x01\u0095\x01\x45\x01\uffff\x01\u0095\x01\uffff\x01\x45"+
        "\x01\u0095\x01\uffff\x01\x45\x01\u0095\x01\x44\x04\uffff\x01\u0095"+
        "\x01\x44\x04\uffff\x01\u0095\x01\x44\x04\uffff\x01\x44\x01\u0095"+
        "\x01\x45\x01\uffff\x01\x44\x01\u0095\x01\x45\x01\uffff\x01\x44\x01"+
        "\u0095\x01\x45\x01\uffff\x01\x00\x01\uffff\x02\x00\x04\uffff\x01"+
        "\x00\x01\uffff\x02\x00\x04\uffff\x01\x00\x01\uffff\x02\x00\x04\uffff";
    const string DFA49_maxS =
        "\x01\x58\x03\u0094\x01\u0096\x01\u0091\x01\uffff\x01\u0096\x01"+
        "\uffff\x01\u0091\x01\u0096\x01\uffff\x01\u0091\x01\u0096\x01\x46"+
        "\x04\uffff\x01\u0096\x01\x46\x04\uffff\x01\u0096\x01\x46\x04\uffff"+
        "\x01\x46\x01\u0096\x01\u0091\x01\uffff\x01\x46\x01\u0096\x01\u0091"+
        "\x01\uffff\x01\x46\x01\u0096\x01\u0091\x01\uffff\x01\x00\x01\uffff"+
        "\x02\x00\x04\uffff\x01\x00\x01\uffff\x02\x00\x04\uffff\x01\x00\x01"+
        "\uffff\x02\x00\x04\uffff";
    const string DFA49_acceptS =
        "\x06\uffff\x01\x02\x09\uffff\x01\x01\x32\uffff";
    const string DFA49_specialS =
        "\x2b\uffff\x01\x00\x01\uffff\x01\x01\x01\x02\x04\uffff\x01\x03"+
        "\x01\uffff\x01\x04\x01\x05\x04\uffff\x01\x06\x01\uffff\x01\x07\x01"+
        "\x08\x04\uffff}>";
    static readonly string[] DFA49_transitionS = {
            "\x01\x03\x02\uffff\x06\x01\x0c\x02",
            "\x01\x05\x01\uffff\x01\x06\x4d\uffff\x01\x04",
            "\x01\x09\x01\uffff\x01\x06\x4d\uffff\x01\x07",
            "\x01\x0c\x01\uffff\x01\x06\x4d\uffff\x01\x0a",
            "\x01\x0d\x01\x0e",
            "\x01\x06\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "",
            "\x01\x13\x01\x14",
            "",
            "\x01\x06\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "\x01\x19\x01\x1a",
            "",
            "\x01\x06\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "\x01\x20\x01\x1f",
            "\x01\x21\x01\uffff\x01\x06",
            "",
            "",
            "",
            "",
            "\x01\x24\x01\x23",
            "\x01\x25\x01\uffff\x01\x06",
            "",
            "",
            "",
            "",
            "\x01\x28\x01\x27",
            "\x01\x29\x01\uffff\x01\x06",
            "",
            "",
            "",
            "",
            "\x01\x2b\x01\uffff\x01\x06",
            "\x01\x2e\x01\x2d",
            "\x01\x06\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "",
            "\x01\x33\x01\uffff\x01\x06",
            "\x01\x36\x01\x35",
            "\x01\x06\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
            "",
            "\x01\x3b\x01\uffff\x01\x06",
            "\x01\x3e\x01\x3d",
            "\x01\x06\x3f\uffff\x01\x10\x0b\uffff\x01\x10",
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
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA49_45 = input.LA(1);

                   	 
                   	int index49_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA49_46 = input.LA(1);

                   	 
                   	int index49_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA49_51 = input.LA(1);

                   	 
                   	int index49_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA49_53 = input.LA(1);

                   	 
                   	int index49_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA49_54 = input.LA(1);

                   	 
                   	int index49_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA49_59 = input.LA(1);

                   	 
                   	int index49_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA49_61 = input.LA(1);

                   	 
                   	int index49_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA49_62 = input.LA(1);

                   	 
                   	int index49_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred106_Psimulex()) ) { s = 16; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index49_62);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 49, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit355 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit359 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit364 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_simpleProgram379 = new BitSet(new ulong[]{0x0000000000000002UL,0xE7FFF88001FFFFD4UL,0x0000000000820017UL});
    public static readonly BitSet FOLLOW_importDeclarations_in_multiFunctionalProgram408 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF98UL});
    public static readonly BitSet FOLLOW_typeDeclarations_in_multiFunctionalProgram410 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram412 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_functionDeclarations_in_multiFunctionalProgram414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclarations449 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_Import_in_importDeclarations489 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclarations491 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_importDeclarations493 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclarations526 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration557 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration559 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_146_in_structBody591 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBody594 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_147_in_structBody597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_memberDeclaration625 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberDeclaration627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_memberDeclaration629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_memberDeclaration651 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberDeclaration653 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Assign_in_memberDeclaration655 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FC00000000004UL});
    public static readonly BitSet FOLLOW_constantData_in_memberDeclaration657 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_memberDeclaration659 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_arrayType695 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_149_in_arrayType699 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_150_in_arrayType704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_functionDeclarations743 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_type_in_functionDeclaration776 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000050UL});
    public static readonly BitSet FOLLOW_Reference_in_functionDeclaration778 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration781 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclaration783 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration786 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_formalParameterList825 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList829 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001200000UL});
    public static readonly BitSet FOLLOW_149_in_formalParameterList832 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameterList834 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001200000UL});
    public static readonly BitSet FOLLOW_152_in_formalParameterList841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_formalParameter878 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000050UL});
    public static readonly BitSet FOLLOW_Reference_in_formalParameter880 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameter883 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_type929 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_arrayType_in_type931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataTypeName_in_dataType964 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataTypeName985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataTypeName989 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedTypes_in_dataTypeName993 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_userDefinedTypes1005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exp_in_expression1162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_exp1184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_exp1188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment1201 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000003E000020UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment1203 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_exp_in_assignment1206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1247 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression1251 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1254 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1276 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression1280 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1283 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000080000000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1305 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000300000000UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression1309 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1312 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000300000000UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1347 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000003C00000000UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression1351 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1354 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000003C00000000UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1407 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000C000000000UL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression1411 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1414 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000C000000000UL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1449 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000070000000000UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression1453 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1456 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000070000000000UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixExpression_in_unaryExpression1491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_unaryExpression1499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpression1504 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryPrefixExpression1518 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryPrefixExpression1520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_unaryPostfixExpression1550 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000300000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryPostfixExpression1553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryPostfixExpression1561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_leftValueExpression1572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixAssignerOp_in_leftValueExpression1577 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000300000000050UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_leftValueExpression1579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_castExpression1610 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_dataType_in_castExpression1612 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_castExpression1614 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixAssignerOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_primaryExpression1711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_initializer_in_primaryExpression1719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_parExpression1738 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1741 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_parExpression1743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Reference_in_variable1774 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1777 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selector1827 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002100000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selector1831 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002100000UL});
    public static readonly BitSet FOLLOW_functionCall_in_selector1835 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002100000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector1846 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000002100000UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector1850 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000002100000UL});
    public static readonly BitSet FOLLOW_indexing_in_selector1854 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000002100000UL});
    public static readonly BitSet FOLLOW_153_in_memberSelect1871 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect1873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_153_in_memberFunctionCall1894 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall1896 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall1898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall1921 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_arguments_in_functionCall1923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_indexing1946 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing1948 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_149_in_indexing1952 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_indexing1954 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_150_in_indexing1959 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_arguments1993 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000001800000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments1997 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001200000UL});
    public static readonly BitSet FOLLOW_149_in_arguments2000 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_arguments2002 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001200000UL});
    public static readonly BitSet FOLLOW_152_in_arguments2009 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_constantData2120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantInitializer_in_constantData2124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_collectionType2146 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_collectionInitializer_in_initializer2158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInitializer_in_initializer2162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_collectionInitializer2174 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_collectionType_in_collectionInitializer2176 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_146_in_collectionInitializer2178 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_collectionInitializer2180 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000280000UL});
    public static readonly BitSet FOLLOW_149_in_collectionInitializer2184 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_collectionInitializer2186 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000280000UL});
    public static readonly BitSet FOLLOW_147_in_collectionInitializer2191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_arrayInitializer2221 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_dataType_in_arrayInitializer2223 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_148_in_arrayInitializer2225 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayInitializer2227 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_149_in_arrayInitializer2231 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayInitializer2233 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_150_in_arrayInitializer2238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantCollectionInitializer_in_constantInitializer2273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constantArrayInitializer_in_constantInitializer2277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_constantCollectionInitializer2289 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_collectionType_in_constantCollectionInitializer2291 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_146_in_constantCollectionInitializer2293 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FC00000000004UL});
    public static readonly BitSet FOLLOW_constantData_in_constantCollectionInitializer2295 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000280000UL});
    public static readonly BitSet FOLLOW_149_in_constantCollectionInitializer2299 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FC00000000004UL});
    public static readonly BitSet FOLLOW_constantData_in_constantCollectionInitializer2301 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000280000UL});
    public static readonly BitSet FOLLOW_147_in_constantCollectionInitializer2306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_New_in_constantArrayInitializer2336 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_dataType_in_constantArrayInitializer2338 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_148_in_constantArrayInitializer2340 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FC00000000004UL});
    public static readonly BitSet FOLLOW_constantData_in_constantArrayInitializer2342 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_149_in_constantArrayInitializer2346 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FC00000000004UL});
    public static readonly BitSet FOLLOW_constantData_in_constantArrayInitializer2348 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_150_in_constantArrayInitializer2353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_146_in_block2405 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x00000000008A0017UL});
    public static readonly BitSet FOLLOW_statement_in_block2407 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x00000000008A0017UL});
    public static readonly BitSet FOLLOW_147_in_block2410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch2452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_branch2456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement2473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_statement2493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForStatement_in_statement2497 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forEachStatement_in_statement2511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_pForEachStatement_in_statement2515 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_loopStatement_in_statement2527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_statement2537 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doStatement_in_statement2547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement2560 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_statement2562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Async_in_statement2591 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_statement2593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Lock_in_statement2621 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_151_in_statement2623 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_statement2625 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_statement2627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_statement2629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement2652 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000820000UL});
    public static readonly BitSet FOLLOW_expression_in_statement2654 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_statement2657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement2680 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_statement2682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_statement2694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement2705 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_statement2707 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_statement2725 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_statement2727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_localVariableDeclaration2760 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_localVariableDeclaration2762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_localVariableDeclaration2786 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000050UL});
    public static readonly BitSet FOLLOW_Reference_in_localVariableDeclaration2788 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_localVariableDeclaration2791 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration2793 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclaration2795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifBranch_in_ifStatement2831 = new BitSet(new ulong[]{0x0000000000000002UL,0x1800000000000000UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_ifStatement2837 = new BitSet(new ulong[]{0x0000000000000000UL,0x1800000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_ifStatement2845 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_ifBranch2857 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_condition_in_ifBranch2859 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_ifBranch2861 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ElseIf_in_elseIfBranches2889 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_condition_in_elseIfBranches2891 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_elseIfBranches2893 = new BitSet(new ulong[]{0x0000000000000002UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_Else_in_elseBranch2928 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_elseBranch2930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_For_in_forStatement2948 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_151_in_forStatement2950 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000820017UL});
    public static readonly BitSet FOLLOW_forControl_in_forStatement2952 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_forStatement2954 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_forStatement2956 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PFor_in_pForStatement2976 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_151_in_pForStatement2978 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000820017UL});
    public static readonly BitSet FOLLOW_forControl_in_pForStatement2980 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_pForStatement2982 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_pForStatement2984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl3005 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_forControl3008 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000820000UL});
    public static readonly BitSet FOLLOW_forCondition_in_forControl3010 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_forControl3013 = new BitSet(new ulong[]{0x0000000000000002UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl3015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit3057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forCondition3067 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate3078 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_whileStatement3087 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_condition_in_whileStatement3089 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_whileStatement3091 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_doStatement3113 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_doStatement3115 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL});
    public static readonly BitSet FOLLOW_While_in_doStatement3117 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_condition_in_doStatement3119 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_doStatement3121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PForEach_in_pForEachStatement3141 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_pForEachStatement3143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ForEach_in_forEachStatement3160 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_forEachTrailer_in_forEachStatement3162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_forEachTrailer3180 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001FFFF90UL});
    public static readonly BitSet FOLLOW_forEachControl_in_forEachTrailer3183 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_forEachTrailer3185 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_forEachTrailer3188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_forEachControl3217 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_forEachControl3219 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_In_in_forEachControl3221 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_forEachControl3223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_loopStatement3253 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_151_in_loopStatement3255 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000820037UL});
    public static readonly BitSet FOLLOW_loopControl_in_loopStatement3257 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_loopStatement3259 = new BitSet(new ulong[]{0x0000000000000000UL,0xE7FFF88001FFFFD4UL,0x0000000000860017UL});
    public static readonly BitSet FOLLOW_core_in_loopStatement3261 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_loopControl3302 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_To_in_loopControl3304 = new BitSet(new ulong[]{0x0000000000000000UL,0x001FF88000000054UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_expression_in_loopControl3306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_branch_in_core3335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_condition3354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_synpred2_Psimulex359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_synpred8_Psimulex625 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred8_Psimulex627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_145_in_synpred8_Psimulex629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred34_Psimulex1184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixExpression_in_synpred54_Psimulex1499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValueExpression_in_synpred56_Psimulex1550 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000300000000000UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_synpred56_Psimulex1553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred61_Psimulex1685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred62_Psimulex1693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_synpred64_Psimulex1711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_synpred106_Psimulex2760 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred106_Psimulex2762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseIfBranches_in_synpred108_Psimulex2837 = new BitSet(new ulong[]{0x0000000000000000UL,0x1800000000000000UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred108_Psimulex2839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elseBranch_in_synpred109_Psimulex2845 = new BitSet(new ulong[]{0x0000000000000002UL});

}
