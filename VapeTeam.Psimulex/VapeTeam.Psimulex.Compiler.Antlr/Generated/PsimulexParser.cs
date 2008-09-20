// $ANTLR 3.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-09-20 16:12:10

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
		"FORMALPARAM", 
		"BLOCK", 
		"VARINIT", 
		"VARDECLARE", 
		"TYPE", 
		"DATATYPE", 
		"FUNCTIONPOINTERTYPE", 
		"EXPRESSION", 
		"ASSIGNMENT", 
		"MEMBER_FUNCTION_CALL", 
		"FUNCTION_CALL", 
		"MEMBER_SELECT", 
		"INDEXING", 
		"DIMS", 
		"DIMMARKER", 
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
		"PlusPlus", 
		"MinusMinus", 
		"LogicalNot", 
		"IntegerLiteral", 
		"DecimalLiteral", 
		"CharacterLiteral", 
		"BooleanLiteral", 
		"NullLiteral", 
		"InfinityLiteral", 
		"If", 
		"Else", 
		"For", 
		"PFor", 
		"ForEach", 
		"PForEach", 
		"Loop", 
		"While", 
		"Do", 
		"PDo", 
		"Return", 
		"Break", 
		"Continue", 
		"In", 
		"To", 
		"ElseIf", 
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

    public const int RelEqual = 60;
    public const int TYPE_DECLARATIONS = 8;
    public const int VARINIT = 16;
    public const int AssignAndDivide = 56;
    public const int AssignAndMultiply = 55;
    public const int Decimal = 38;
    public const int Modulo = 70;
    public const int IDLetter = 97;
    public const int EOF = -1;
    public const int Identifier = 32;
    public const int INDEXING = 26;
    public const int Int = 37;
    public const int Thread = 48;
    public const int TYPE = 18;
    public const int BinTree = 42;
    public const int To = 94;
    public const int ForEach = 84;
    public const int Char = 36;
    public const int Edge = 52;
    public const int COMPILATION_UNIT = 4;
    public const int Do = 88;
    public const int RelGreaterThan = 64;
    public const int Node = 51;
    public const int AssignAndModulo = 57;
    public const int Bool = 35;
    public const int MEMBER_SELECT = 25;
    public const int LogicalOr = 58;
    public const int LogicalAnd = 59;
    public const int Tree = 41;
    public const int Minus = 67;
    public const int WS = 102;
    public const int Break = 91;
    public const int GLOBAL_VARIABLE_DECLARATIONS = 10;
    public const int Timer = 49;
    public const int MEMBER_FUNCTION_CALL = 23;
    public const int MULTY_FUNCTIONAL_PROGRAM = 6;
    public const int SIMPLE_PROGRAM = 5;
    public const int DATATYPE = 19;
    public const int NotNullDigit = 99;
    public const int RelLessThan = 62;
    public const int Star = 68;
    public const int FUNCTION_CALL = 24;
    public const int Else = 81;
    public const int EscapeSequence = 101;
    public const int Letter = 96;
    public const int Loop = 86;
    public const int BooleanLiteral = 77;
    public const int DIMMARKER = 28;
    public const int Stack = 45;
    public const int AssignAndAdd = 53;
    public const int RelGreaterThanOrEqual = 65;
    public const int NullLiteral = 78;
    public const int PQueue = 47;
    public const int SingleLineComment = 103;
    public const int DIMS = 27;
    public const int FORMALPARAM = 14;
    public const int CharacterLiteral = 76;
    public const int AssignAndSubstract = 54;
    public const int While = 87;
    public const int Graph = 50;
    public const int Queue = 46;
    public const int Set = 43;
    public const int Assign = 33;
    public const int PForEach = 85;
    public const int T__107 = 107;
    public const int T__108 = 108;
    public const int RelNotEqual = 61;
    public const int T__109 = 109;
    public const int T__105 = 105;
    public const int T__106 = 106;
    public const int T__111 = 111;
    public const int T__110 = 110;
    public const int T__113 = 113;
    public const int T__112 = 112;
    public const int String = 39;
    public const int Return = 90;
    public const int Reference = 34;
    public const int Struct = 31;
    public const int EXPRESSION = 21;
    public const int MultiLineComment = 104;
    public const int If = 80;
    public const int FUNCTIONPOINTERTYPE = 20;
    public const int In = 93;
    public const int Import = 29;
    public const int VARDECLARE = 17;
    public const int FUNCTION_DECLARATIONS = 12;
    public const int Continue = 92;
    public const int Void = 40;
    public const int PDo = 89;
    public const int ElseIf = 95;
    public const int IMPORT_DECLARATIONS = 7;
    public const int Digit = 98;
    public const int STRUCTDEC = 9;
    public const int DecimalLiteral = 75;
    public const int For = 82;
    public const int Divide = 69;
    public const int List = 44;
    public const int StringLiteral = 30;
    public const int Plus = 66;
    public const int LogicalNot = 73;
    public const int RelLessThanOrEqual = 63;
    public const int MinusMinus = 72;
    public const int DecimalTypeSuffix = 100;
    public const int PFor = 83;
    public const int BLOCK = 15;
    public const int MEMBERDEC = 11;
    public const int ASSIGNMENT = 22;
    public const int IntegerLiteral = 74;
    public const int FUNCDEC = 13;
    public const int PlusPlus = 71;
    public const int InfinityLiteral = 79;

    // delegates
    // delegators



        public PsimulexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PsimulexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
    		InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[166+1];
             
             
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:53:1: compilationUnit : ( simpleProgram | multiFunctionalProgram ) EOF ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:5: ( ( simpleProgram | multiFunctionalProgram ) EOF )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:7: ( simpleProgram | multiFunctionalProgram ) EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:7: ( simpleProgram | multiFunctionalProgram )
            	int alt1 = 2;
            	alt1 = dfa1.Predict(input);
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:9: simpleProgram
            	        {
            	        	PushFollow(FOLLOW_simpleProgram_in_compilationUnit195);
            	        	simpleProgram1 = simpleProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:25: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit199);
            	        	multiFunctionalProgram2 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit203); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:57:1: simpleProgram : ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:2: ( ( statement )* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:4: ( statement )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || (LA2_0 >= Bool && LA2_0 <= Edge) || (LA2_0 >= Plus && LA2_0 <= Minus) || (LA2_0 >= PlusPlus && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= Continue) || LA2_0 == 105 || LA2_0 == 111) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_simpleProgram218);
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
            	// 58:15: -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:18: ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM ( statement )* ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:38: ^( SIMPLE_PROGRAM ( statement )* )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SIMPLE_PROGRAM, "SIMPLE_PROGRAM"), root_2);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:56: ( statement )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:61:1: multiFunctionalProgram : importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:62:2: ( importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:62:4: importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations
            {
            	PushFollow(FOLLOW_importDeclarations_in_multiFunctionalProgram247);
            	importDeclarations5 = importDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_importDeclarations.Add(importDeclarations5.Tree);
            	PushFollow(FOLLOW_typeDeclarations_in_multiFunctionalProgram249);
            	typeDeclarations6 = typeDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typeDeclarations.Add(typeDeclarations6.Tree);
            	PushFollow(FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram251);
            	globalVariableDeclarations7 = globalVariableDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_globalVariableDeclarations.Add(globalVariableDeclarations7.Tree);
            	PushFollow(FOLLOW_functionDeclarations_in_multiFunctionalProgram253);
            	functionDeclarations8 = functionDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_functionDeclarations.Add(functionDeclarations8.Tree);


            	// AST REWRITE
            	// elements:          functionDeclarations, importDeclarations, globalVariableDeclarations, typeDeclarations
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 63:3: -> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:6: ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMPILATION_UNIT, "COMPILATION_UNIT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:26: ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:66:1: globalVariableDeclarations : ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:2: ( ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:4: ( memberDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:4: ( memberDeclaration )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= Bool && LA3_0 <= Void)) )
            	    {
            	        int LA3_1 = input.LA(2);

            	        if ( (synpred3_Psimulex()) )
            	        {
            	            alt3 = 1;
            	        }


            	    }
            	    else if ( ((LA3_0 >= Tree && LA3_0 <= Edge)) )
            	    {
            	        int LA3_2 = input.LA(2);

            	        if ( (synpred3_Psimulex()) )
            	        {
            	            alt3 = 1;
            	        }


            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclarations288);
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
            	// 67:23: -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:26: ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GLOBAL_VARIABLE_DECLARATIONS, "GLOBAL_VARIABLE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:58: ( memberDeclaration )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:83:1: importDeclarations : ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) ;
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
        RewriteRuleTokenStream stream_105 = new RewriteRuleTokenStream(adaptor,"token 105");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:5: ( ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:9: ( Import StringLiteral ';' )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:9: ( Import StringLiteral ';' )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:11: Import StringLiteral ';'
            			    {
            			    	Import10=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclarations328); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_Import.Add(Import10);

            			    	StringLiteral11=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclarations330); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_StringLiteral.Add(StringLiteral11);

            			    	char_literal12=(IToken)Match(input,105,FOLLOW_105_in_importDeclarations332); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_105.Add(char_literal12);


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
            	// 84:39: -> ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:42: ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IMPORT_DECLARATIONS, "IMPORT_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:65: ( StringLiteral )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:87:1: typeDeclarations : ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:88:5: ( ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:88:9: ( structDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:88:9: ( structDeclaration )*
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
            			    	PushFollow(FOLLOW_structDeclaration_in_typeDeclarations365);
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
            	// 88:28: -> ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:88:31: ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE_DECLARATIONS, "TYPE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:88:52: ( structDeclaration )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:91:1: structDeclaration : Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:92:5: ( Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:92:9: Struct Identifier structBody
            {
            	Struct14=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration396); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Struct.Add(Struct14);

            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration398); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier15);

            	PushFollow(FOLLOW_structBody_in_structDeclaration400);
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
            	// 92:38: -> ^( STRUCTDEC Identifier structBody )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:92:41: ^( STRUCTDEC Identifier structBody )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:95:1: structBody : '{' ( memberDeclaration )+ '}' ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:96:5: ( '{' ( memberDeclaration )+ '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:96:9: '{' ( memberDeclaration )+ '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,106,FOLLOW_106_in_structBody430); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:96:14: ( memberDeclaration )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= Bool && LA6_0 <= Edge)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBody433);
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

            	char_literal19=(IToken)Match(input,107,FOLLOW_107_in_structBody436); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:1: memberDeclaration : typedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC typedIdentifierNonRef ( literal )? ) ;
    public PsimulexParser.memberDeclaration_return memberDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.memberDeclaration_return retval = new PsimulexParser.memberDeclaration_return();
        retval.Start = input.LT(1);
        int memberDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Assign21 = null;
        IToken char_literal23 = null;
        PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef20 = default(PsimulexParser.typedIdentifierNonRef_return);

        PsimulexParser.literal_return literal22 = default(PsimulexParser.literal_return);


        CommonTree Assign21_tree=null;
        CommonTree char_literal23_tree=null;
        RewriteRuleTokenStream stream_Assign = new RewriteRuleTokenStream(adaptor,"token Assign");
        RewriteRuleTokenStream stream_105 = new RewriteRuleTokenStream(adaptor,"token 105");
        RewriteRuleSubtreeStream stream_typedIdentifierNonRef = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifierNonRef");
        RewriteRuleSubtreeStream stream_literal = new RewriteRuleSubtreeStream(adaptor,"rule literal");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:5: ( typedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC typedIdentifierNonRef ( literal )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:9: typedIdentifierNonRef ( Assign literal )? ';'
            {
            	PushFollow(FOLLOW_typedIdentifierNonRef_in_memberDeclaration457);
            	typedIdentifierNonRef20 = typedIdentifierNonRef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifierNonRef.Add(typedIdentifierNonRef20.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:31: ( Assign literal )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == Assign) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:33: Assign literal
            	        {
            	        	Assign21=(IToken)Match(input,Assign,FOLLOW_Assign_in_memberDeclaration461); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Assign.Add(Assign21);

            	        	PushFollow(FOLLOW_literal_in_memberDeclaration463);
            	        	literal22 = literal();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_literal.Add(literal22.Tree);

            	        }
            	        break;

            	}

            	char_literal23=(IToken)Match(input,105,FOLLOW_105_in_memberDeclaration468); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_105.Add(char_literal23);



            	// AST REWRITE
            	// elements:          literal, typedIdentifierNonRef
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 100:55: -> ^( MEMBERDEC typedIdentifierNonRef ( literal )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:58: ^( MEMBERDEC typedIdentifierNonRef ( literal )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBERDEC, "MEMBERDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifierNonRef.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:93: ( literal )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:5: ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) )
            int alt8 = 3;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:9: typedIdentifierNonRef
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration507);
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
                    	// 105:31: -> ^( VARDECLARE typedIdentifierNonRef )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:34: ^( VARDECLARE typedIdentifierNonRef )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:9: typedIdentifierNonRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration525);
                    	typedIdentifierNonRef25 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierNonRef.Add(typedIdentifierNonRef25.Tree);
                    	Assign26=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration527); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign26);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration529);
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
                    	// 106:58: -> ^( VARINIT typedIdentifierNonRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:61: ^( VARINIT typedIdentifierNonRef variableInitializer )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:107:4: typedIdentifierRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierRef_in_localVariableDeclaration544);
                    	typedIdentifierRef28 = typedIdentifierRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierRef.Add(typedIdentifierRef28.Tree);
                    	Assign29=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration546); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign29);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration548);
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
                    	// 107:50: -> ^( VARINIT typedIdentifierRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:107:53: ^( VARINIT typedIdentifierRef variableInitializer )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:110:1: variableInitializer : expression ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:111:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:111:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_variableInitializer581);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:114:1: scalarOrArrayType : type ( arrayType )? -> ^( TYPE type ( arrayType )? ) ;
    public PsimulexParser.scalarOrArrayType_return scalarOrArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.scalarOrArrayType_return retval = new PsimulexParser.scalarOrArrayType_return();
        retval.Start = input.LT(1);
        int scalarOrArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.type_return type32 = default(PsimulexParser.type_return);

        PsimulexParser.arrayType_return arrayType33 = default(PsimulexParser.arrayType_return);


        RewriteRuleSubtreeStream stream_arrayType = new RewriteRuleSubtreeStream(adaptor,"rule arrayType");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:115:2: ( type ( arrayType )? -> ^( TYPE type ( arrayType )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:115:4: type ( arrayType )?
            {
            	PushFollow(FOLLOW_type_in_scalarOrArrayType601);
            	type32 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type32.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:115:9: ( arrayType )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 108) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: arrayType
            	        {
            	        	PushFollow(FOLLOW_arrayType_in_scalarOrArrayType603);
            	        	arrayType33 = arrayType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_arrayType.Add(arrayType33.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          type, arrayType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 115:20: -> ^( TYPE type ( arrayType )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:115:23: ^( TYPE type ( arrayType )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE, "TYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:115:36: ( arrayType )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:118:1: arrayType : ( staticArrayType | dynamicArrayType );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:119:2: ( staticArrayType | dynamicArrayType )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == 108) )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == StringLiteral || LA10_1 == Identifier || (LA10_1 >= Plus && LA10_1 <= Minus) || (LA10_1 >= PlusPlus && LA10_1 <= InfinityLiteral) || LA10_1 == 111) )
                {
                    alt10 = 1;
                }
                else if ( ((LA10_1 >= 109 && LA10_1 <= 110)) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:119:4: staticArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_staticArrayType_in_arrayType628);
                    	staticArrayType34 = staticArrayType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, staticArrayType34.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:119:22: dynamicArrayType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dynamicArrayType_in_arrayType632);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:122:1: staticArrayType : '[' expression ( ',' expression )* ']' -> ^( DIMS expression ( expression )* ) ;
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
        RewriteRuleTokenStream stream_109 = new RewriteRuleTokenStream(adaptor,"token 109");
        RewriteRuleTokenStream stream_110 = new RewriteRuleTokenStream(adaptor,"token 110");
        RewriteRuleTokenStream stream_108 = new RewriteRuleTokenStream(adaptor,"token 108");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:2: ( '[' expression ( ',' expression )* ']' -> ^( DIMS expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:4: '[' expression ( ',' expression )* ']'
            {
            	char_literal36=(IToken)Match(input,108,FOLLOW_108_in_staticArrayType644); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_108.Add(char_literal36);

            	PushFollow(FOLLOW_expression_in_staticArrayType646);
            	expression37 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression37.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:19: ( ',' expression )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 109) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:20: ',' expression
            			    {
            			    	char_literal38=(IToken)Match(input,109,FOLLOW_109_in_staticArrayType649); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_109.Add(char_literal38);

            			    	PushFollow(FOLLOW_expression_in_staticArrayType651);
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

            	char_literal40=(IToken)Match(input,110,FOLLOW_110_in_staticArrayType655); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_110.Add(char_literal40);



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
            	// 123:41: -> ^( DIMS expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:44: ^( DIMS expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMS, "DIMS"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:63: ( expression )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:126:1: dynamicArrayType : '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) ;
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
        RewriteRuleTokenStream stream_109 = new RewriteRuleTokenStream(adaptor,"token 109");
        RewriteRuleTokenStream stream_110 = new RewriteRuleTokenStream(adaptor,"token 110");
        RewriteRuleTokenStream stream_108 = new RewriteRuleTokenStream(adaptor,"token 108");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:2: ( '[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:4: '[' ( ',' )* ']'
            {
            	char_literal41=(IToken)Match(input,108,FOLLOW_108_in_dynamicArrayType683); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_108.Add(char_literal41);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:8: ( ',' )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 109) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:10: ','
            			    {
            			    	char_literal42=(IToken)Match(input,109,FOLLOW_109_in_dynamicArrayType687); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_109.Add(char_literal42);


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal43=(IToken)Match(input,110,FOLLOW_110_in_dynamicArrayType692); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_110.Add(char_literal43);



            	// AST REWRITE
            	// elements:          108, 109, 110
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 127:21: -> ^( DIMMARKER '[' ( ',' )* ']' )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:24: ^( DIMMARKER '[' ( ',' )* ']' )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIMMARKER, "DIMMARKER"), root_1);

            	    adaptor.AddChild(root_1, stream_108.NextNode());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:41: ( ',' )*
            	    while ( stream_109.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_109.NextNode());

            	    }
            	    stream_109.Reset();
            	    adaptor.AddChild(root_1, stream_110.NextNode());

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:130:1: typedIdentifierNonRef : scalarOrArrayType Identifier ;
    public PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifierNonRef_return retval = new PsimulexParser.typedIdentifierNonRef_return();
        retval.Start = input.LT(1);
        int typedIdentifierNonRef_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier45 = null;
        PsimulexParser.scalarOrArrayType_return scalarOrArrayType44 = default(PsimulexParser.scalarOrArrayType_return);


        CommonTree Identifier45_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:2: ( scalarOrArrayType Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:4: scalarOrArrayType Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef723);
            	scalarOrArrayType44 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType44.Tree);
            	Identifier45=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierNonRef725); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier45_tree = (CommonTree)adaptor.Create(Identifier45);
            		adaptor.AddChild(root_0, Identifier45_tree);
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
            	Memoize(input, 16, typedIdentifierNonRef_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:134:1: typedIdentifierRef : scalarOrArrayType ( Reference )? Identifier ;
    public PsimulexParser.typedIdentifierRef_return typedIdentifierRef() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifierRef_return retval = new PsimulexParser.typedIdentifierRef_return();
        retval.Start = input.LT(1);
        int typedIdentifierRef_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference47 = null;
        IToken Identifier48 = null;
        PsimulexParser.scalarOrArrayType_return scalarOrArrayType46 = default(PsimulexParser.scalarOrArrayType_return);


        CommonTree Reference47_tree=null;
        CommonTree Identifier48_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:2: ( scalarOrArrayType ( Reference )? Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:4: scalarOrArrayType ( Reference )? Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierRef737);
            	scalarOrArrayType46 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType46.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:22: ( Reference )?
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
            	        	Reference47=(IToken)Match(input,Reference,FOLLOW_Reference_in_typedIdentifierRef739); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Reference47_tree = (CommonTree)adaptor.Create(Reference47);
            	        		adaptor.AddChild(root_0, Reference47_tree);
            	        	}

            	        }
            	        break;

            	}

            	Identifier48=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierRef742); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier48_tree = (CommonTree)adaptor.Create(Identifier48);
            		adaptor.AddChild(root_0, Identifier48_tree);
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
            	Memoize(input, 17, typedIdentifierRef_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:138:1: typedIdentifier : ( typedIdentifierNonRef | typedIdentifierRef );
    public PsimulexParser.typedIdentifier_return typedIdentifier() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifier_return retval = new PsimulexParser.typedIdentifier_return();
        retval.Start = input.LT(1);
        int typedIdentifier_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef49 = default(PsimulexParser.typedIdentifierNonRef_return);

        PsimulexParser.typedIdentifierRef_return typedIdentifierRef50 = default(PsimulexParser.typedIdentifierRef_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:2: ( typedIdentifierNonRef | typedIdentifierRef )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( ((LA14_0 >= Bool && LA14_0 <= Void)) )
            {
                int LA14_1 = input.LA(2);

                if ( (synpred15_Psimulex()) )
                {
                    alt14 = 1;
                }
                else if ( (true) )
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
            else if ( ((LA14_0 >= Tree && LA14_0 <= Edge)) )
            {
                int LA14_2 = input.LA(2);

                if ( (synpred15_Psimulex()) )
                {
                    alt14 = 1;
                }
                else if ( (true) )
                {
                    alt14 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d14s2 =
                        new NoViableAltException("", 14, 2, input);

                    throw nvae_d14s2;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:4: typedIdentifierNonRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_typedIdentifier755);
                    	typedIdentifierNonRef49 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierNonRef49.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:28: typedIdentifierRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierRef_in_typedIdentifier759);
                    	typedIdentifierRef50 = typedIdentifierRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierRef50.Tree);

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
            	Memoize(input, 18, typedIdentifier_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:142:1: functionDeclarations : ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) ;
    public PsimulexParser.functionDeclarations_return functionDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclarations_return retval = new PsimulexParser.functionDeclarations_return();
        retval.Start = input.LT(1);
        int functionDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.functionDeclaration_return functionDeclaration51 = default(PsimulexParser.functionDeclaration_return);


        RewriteRuleSubtreeStream stream_functionDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule functionDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:5: ( ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:7: ( functionDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:7: ( functionDeclaration )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= Bool && LA15_0 <= Edge)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: functionDeclaration
            			    {
            			    	PushFollow(FOLLOW_functionDeclaration_in_functionDeclarations776);
            			    	functionDeclaration51 = functionDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_functionDeclaration.Add(functionDeclaration51.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements



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
            	// 143:28: -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:31: ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION_DECLARATIONS, "FUNCTION_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:56: ( functionDeclaration )*
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
            	Memoize(input, 19, functionDeclarations_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:1: functionDeclaration : typedIdentifier '(' ( formalParameters )? ')' block -> ^( FUNCDEC typedIdentifier ( formalParameters )? block ) ;
    public PsimulexParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclaration_return retval = new PsimulexParser.functionDeclaration_return();
        retval.Start = input.LT(1);
        int functionDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal53 = null;
        IToken char_literal55 = null;
        PsimulexParser.typedIdentifier_return typedIdentifier52 = default(PsimulexParser.typedIdentifier_return);

        PsimulexParser.formalParameters_return formalParameters54 = default(PsimulexParser.formalParameters_return);

        PsimulexParser.block_return block56 = default(PsimulexParser.block_return);


        CommonTree char_literal53_tree=null;
        CommonTree char_literal55_tree=null;
        RewriteRuleTokenStream stream_112 = new RewriteRuleTokenStream(adaptor,"token 112");
        RewriteRuleTokenStream stream_111 = new RewriteRuleTokenStream(adaptor,"token 111");
        RewriteRuleSubtreeStream stream_typedIdentifier = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifier");
        RewriteRuleSubtreeStream stream_formalParameters = new RewriteRuleSubtreeStream(adaptor,"rule formalParameters");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:5: ( typedIdentifier '(' ( formalParameters )? ')' block -> ^( FUNCDEC typedIdentifier ( formalParameters )? block ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:7: typedIdentifier '(' ( formalParameters )? ')' block
            {
            	PushFollow(FOLLOW_typedIdentifier_in_functionDeclaration809);
            	typedIdentifier52 = typedIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier52.Tree);
            	char_literal53=(IToken)Match(input,111,FOLLOW_111_in_functionDeclaration811); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_111.Add(char_literal53);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:27: ( formalParameters )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= Bool && LA16_0 <= Edge)) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: formalParameters
            	        {
            	        	PushFollow(FOLLOW_formalParameters_in_functionDeclaration813);
            	        	formalParameters54 = formalParameters();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_formalParameters.Add(formalParameters54.Tree);

            	        }
            	        break;

            	}

            	char_literal55=(IToken)Match(input,112,FOLLOW_112_in_functionDeclaration816); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_112.Add(char_literal55);

            	PushFollow(FOLLOW_block_in_functionDeclaration818);
            	block56 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_block.Add(block56.Tree);


            	// AST REWRITE
            	// elements:          typedIdentifier, formalParameters, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 147:55: -> ^( FUNCDEC typedIdentifier ( formalParameters )? block )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:58: ^( FUNCDEC typedIdentifier ( formalParameters )? block )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCDEC, "FUNCDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifier.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:85: ( formalParameters )?
            	    if ( stream_formalParameters.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_formalParameters.NextTree());

            	    }
            	    stream_formalParameters.Reset();
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
            	Memoize(input, 20, functionDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionDeclaration"

    public class formalParameters_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "formalParameters"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:150:1: formalParameters : typedIdentifier ( ',' typedIdentifier )* -> ^( FORMALPARAM typedIdentifier ( typedIdentifier )* ) ;
    public PsimulexParser.formalParameters_return formalParameters() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameters_return retval = new PsimulexParser.formalParameters_return();
        retval.Start = input.LT(1);
        int formalParameters_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal58 = null;
        PsimulexParser.typedIdentifier_return typedIdentifier57 = default(PsimulexParser.typedIdentifier_return);

        PsimulexParser.typedIdentifier_return typedIdentifier59 = default(PsimulexParser.typedIdentifier_return);


        CommonTree char_literal58_tree=null;
        RewriteRuleTokenStream stream_109 = new RewriteRuleTokenStream(adaptor,"token 109");
        RewriteRuleSubtreeStream stream_typedIdentifier = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifier");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:151:5: ( typedIdentifier ( ',' typedIdentifier )* -> ^( FORMALPARAM typedIdentifier ( typedIdentifier )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:151:9: typedIdentifier ( ',' typedIdentifier )*
            {
            	PushFollow(FOLLOW_typedIdentifier_in_formalParameters852);
            	typedIdentifier57 = typedIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier57.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:151:25: ( ',' typedIdentifier )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 109) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:151:26: ',' typedIdentifier
            			    {
            			    	char_literal58=(IToken)Match(input,109,FOLLOW_109_in_formalParameters855); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_109.Add(char_literal58);

            			    	PushFollow(FOLLOW_typedIdentifier_in_formalParameters857);
            			    	typedIdentifier59 = typedIdentifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier59.Tree);

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements



            	// AST REWRITE
            	// elements:          typedIdentifier, typedIdentifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 151:48: -> ^( FORMALPARAM typedIdentifier ( typedIdentifier )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:151:51: ^( FORMALPARAM typedIdentifier ( typedIdentifier )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORMALPARAM, "FORMALPARAM"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifier.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:151:82: ( typedIdentifier )*
            	    while ( stream_typedIdentifier.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_typedIdentifier.NextTree());

            	    }
            	    stream_typedIdentifier.Reset();

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
            	Memoize(input, 21, formalParameters_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameters"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:160:1: type : dataType ;
    public PsimulexParser.type_return type() // throws RecognitionException [1]
    {   
        PsimulexParser.type_return retval = new PsimulexParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataType_return dataType60 = default(PsimulexParser.dataType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:5: ( dataType )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:7: dataType
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dataType_in_type899);
            	dataType60 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType60.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, type_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:1: dataType : dataTypeName -> ^( DATATYPE dataTypeName ) ;
    public PsimulexParser.dataType_return dataType() // throws RecognitionException [1]
    {   
        PsimulexParser.dataType_return retval = new PsimulexParser.dataType_return();
        retval.Start = input.LT(1);
        int dataType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataTypeName_return dataTypeName61 = default(PsimulexParser.dataTypeName_return);


        RewriteRuleSubtreeStream stream_dataTypeName = new RewriteRuleSubtreeStream(adaptor,"rule dataTypeName");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:171:2: ( dataTypeName -> ^( DATATYPE dataTypeName ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:171:4: dataTypeName
            {
            	PushFollow(FOLLOW_dataTypeName_in_dataType918);
            	dataTypeName61 = dataTypeName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataTypeName.Add(dataTypeName61.Tree);


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
            	// 171:17: -> ^( DATATYPE dataTypeName )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:171:20: ^( DATATYPE dataTypeName )
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
            	Memoize(input, 23, dataType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:1: dataTypeName : ( primitiveType | builtInType );
    public PsimulexParser.dataTypeName_return dataTypeName() // throws RecognitionException [1]
    {   
        PsimulexParser.dataTypeName_return retval = new PsimulexParser.dataTypeName_return();
        retval.Start = input.LT(1);
        int dataTypeName_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primitiveType_return primitiveType62 = default(PsimulexParser.primitiveType_return);

        PsimulexParser.builtInType_return builtInType63 = default(PsimulexParser.builtInType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:175:2: ( primitiveType | builtInType )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( ((LA18_0 >= Bool && LA18_0 <= Void)) )
            {
                alt18 = 1;
            }
            else if ( ((LA18_0 >= Tree && LA18_0 <= Edge)) )
            {
                alt18 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:175:4: primitiveType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primitiveType_in_dataTypeName939);
                    	primitiveType62 = primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType62.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:175:20: builtInType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtInType_in_dataTypeName943);
                    	builtInType63 = builtInType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType63.Tree);

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
            	Memoize(input, 24, dataTypeName_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "dataTypeName"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:1: primitiveType : ( Bool | Char | Int | Decimal | String | Void );
    public PsimulexParser.primitiveType_return primitiveType() // throws RecognitionException [1]
    {   
        PsimulexParser.primitiveType_return retval = new PsimulexParser.primitiveType_return();
        retval.Start = input.LT(1);
        int primitiveType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set64 = null;

        CommonTree set64_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:179:5: ( Bool | Char | Int | Decimal | String | Void )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set64 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Bool && input.LA(1) <= Void) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set64));
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
            	Memoize(input, 25, primitiveType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:188:1: builtInType : ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Thread | Timer | Graph | Node | Edge );
    public PsimulexParser.builtInType_return builtInType() // throws RecognitionException [1]
    {   
        PsimulexParser.builtInType_return retval = new PsimulexParser.builtInType_return();
        retval.Start = input.LT(1);
        int builtInType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set65 = null;

        CommonTree set65_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:5: ( Tree | BinTree | Set | List | Stack | Queue | PQueue | Thread | Timer | Graph | Node | Edge )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set65 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= Edge) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set65));
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
            	Memoize(input, 26, builtInType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:212:1: expression : ( assignment | exp );
    public PsimulexParser.expression_return expression() // throws RecognitionException [1]
    {   
        PsimulexParser.expression_return retval = new PsimulexParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.assignment_return assignment66 = default(PsimulexParser.assignment_return);

        PsimulexParser.exp_return exp67 = default(PsimulexParser.exp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:2: ( assignment | exp )
            int alt19 = 2;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                int LA19_1 = input.LA(2);

                if ( (synpred36_Psimulex()) )
                {
                    alt19 = 1;
                }
                else if ( (true) )
                {
                    alt19 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d19s1 =
                        new NoViableAltException("", 19, 1, input);

                    throw nvae_d19s1;
                }
                }
                break;
            case 111:
            	{
                int LA19_2 = input.LA(2);

                if ( (synpred36_Psimulex()) )
                {
                    alt19 = 1;
                }
                else if ( (true) )
                {
                    alt19 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d19s2 =
                        new NoViableAltException("", 19, 2, input);

                    throw nvae_d19s2;
                }
                }
                break;
            case StringLiteral:
            case Plus:
            case Minus:
            case PlusPlus:
            case MinusMinus:
            case LogicalNot:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            	{
                alt19 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expression1096);
                    	assignment66 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment66.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:17: exp
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_exp_in_expression1100);
                    	exp67 = exp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exp67.Tree);

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
            	Memoize(input, 27, expression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:216:1: exp : conditionalOrExpression -> ^( EXPRESSION conditionalOrExpression ) ;
    public PsimulexParser.exp_return exp() // throws RecognitionException [1]
    {   
        PsimulexParser.exp_return retval = new PsimulexParser.exp_return();
        retval.Start = input.LT(1);
        int exp_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.conditionalOrExpression_return conditionalOrExpression68 = default(PsimulexParser.conditionalOrExpression_return);


        RewriteRuleSubtreeStream stream_conditionalOrExpression = new RewriteRuleSubtreeStream(adaptor,"rule conditionalOrExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:2: ( conditionalOrExpression -> ^( EXPRESSION conditionalOrExpression ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:4: conditionalOrExpression
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_exp1113);
            	conditionalOrExpression68 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_conditionalOrExpression.Add(conditionalOrExpression68.Tree);


            	// AST REWRITE
            	// elements:          conditionalOrExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 217:28: -> ^( EXPRESSION conditionalOrExpression )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:31: ^( EXPRESSION conditionalOrExpression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPRESSION, "EXPRESSION"), root_1);

            	    adaptor.AddChild(root_1, stream_conditionalOrExpression.NextTree());

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
            	Memoize(input, 28, exp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:220:1: assignment : leftValue assignmentOperator expression -> ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) ) ;
    public PsimulexParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        PsimulexParser.assignment_return retval = new PsimulexParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue69 = default(PsimulexParser.leftValue_return);

        PsimulexParser.assignmentOperator_return assignmentOperator70 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.expression_return expression71 = default(PsimulexParser.expression_return);


        RewriteRuleSubtreeStream stream_assignmentOperator = new RewriteRuleSubtreeStream(adaptor,"rule assignmentOperator");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_leftValue = new RewriteRuleSubtreeStream(adaptor,"rule leftValue");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:2: ( leftValue assignmentOperator expression -> ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:4: leftValue assignmentOperator expression
            {
            	PushFollow(FOLLOW_leftValue_in_assignment1135);
            	leftValue69 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_leftValue.Add(leftValue69.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment1137);
            	assignmentOperator70 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_assignmentOperator.Add(assignmentOperator70.Tree);
            	PushFollow(FOLLOW_expression_in_assignment1139);
            	expression71 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression71.Tree);


            	// AST REWRITE
            	// elements:          expression, assignmentOperator, leftValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 221:44: -> ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:47: ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ASSIGNMENT, "ASSIGNMENT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:61: ^( assignmentOperator leftValue expression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_assignmentOperator.NextNode(), root_2);

            	    adaptor.AddChild(root_2, stream_leftValue.NextTree());
            	    adaptor.AddChild(root_2, stream_expression.NextTree());

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
            	Memoize(input, 29, assignment_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:224:1: assignmentOperator : ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo );
    public PsimulexParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        PsimulexParser.assignmentOperator_return retval = new PsimulexParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set72 = null;

        CommonTree set72_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:2: ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set72 = (IToken)input.LT(1);
            	if ( input.LA(1) == Assign || (input.LA(1) >= AssignAndAdd && input.LA(1) <= AssignAndModulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set72));
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
            	Memoize(input, 30, assignmentOperator_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:1: conditionalOrExpression : conditionalAndExpression ( LogicalOr conditionalAndExpression )* ;
    public PsimulexParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalOrExpression_return retval = new PsimulexParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalOr74 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression73 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression75 = default(PsimulexParser.conditionalAndExpression_return);


        CommonTree LogicalOr74_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:5: ( conditionalAndExpression ( LogicalOr conditionalAndExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:9: conditionalAndExpression ( LogicalOr conditionalAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1198);
            	conditionalAndExpression73 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression73.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:34: ( LogicalOr conditionalAndExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == LogicalOr) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:36: LogicalOr conditionalAndExpression
            			    {
            			    	LogicalOr74=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression1202); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalOr74_tree = (CommonTree)adaptor.Create(LogicalOr74);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalOr74_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1205);
            			    	conditionalAndExpression75 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression75.Tree);

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
            	Memoize(input, 31, conditionalOrExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:232:1: conditionalAndExpression : equalityExpression ( LogicalAnd equalityExpression )* ;
    public PsimulexParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalAndExpression_return retval = new PsimulexParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalAnd77 = null;
        PsimulexParser.equalityExpression_return equalityExpression76 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression78 = default(PsimulexParser.equalityExpression_return);


        CommonTree LogicalAnd77_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:5: ( equalityExpression ( LogicalAnd equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:9: equalityExpression ( LogicalAnd equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1227);
            	equalityExpression76 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression76.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:28: ( LogicalAnd equalityExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == LogicalAnd) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:30: LogicalAnd equalityExpression
            			    {
            			    	LogicalAnd77=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression1231); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd77_tree = (CommonTree)adaptor.Create(LogicalAnd77);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd77_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1234);
            			    	equalityExpression78 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression78.Tree);

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
            	Memoize(input, 32, conditionalAndExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:236:1: equalityExpression : relationalExpression ( equalityOp relationalExpression )* ;
    public PsimulexParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityExpression_return retval = new PsimulexParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.relationalExpression_return relationalExpression79 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.equalityOp_return equalityOp80 = default(PsimulexParser.equalityOp_return);

        PsimulexParser.relationalExpression_return relationalExpression81 = default(PsimulexParser.relationalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:5: ( relationalExpression ( equalityOp relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:9: relationalExpression ( equalityOp relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1256);
            	relationalExpression79 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression79.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:30: ( equalityOp relationalExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( ((LA22_0 >= RelEqual && LA22_0 <= RelNotEqual)) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:32: equalityOp relationalExpression
            			    {
            			    	PushFollow(FOLLOW_equalityOp_in_equalityExpression1260);
            			    	equalityOp80 = equalityOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp80.Tree, root_0);
            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1263);
            			    	relationalExpression81 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression81.Tree);

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
            	Memoize(input, 33, equalityExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:240:1: equalityOp : ( RelEqual | RelNotEqual );
    public PsimulexParser.equalityOp_return equalityOp() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityOp_return retval = new PsimulexParser.equalityOp_return();
        retval.Start = input.LT(1);
        int equalityOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set82 = null;

        CommonTree set82_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:241:2: ( RelEqual | RelNotEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set82 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelEqual && input.LA(1) <= RelNotEqual) ) 
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
            	Memoize(input, 34, equalityOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:244:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
    public PsimulexParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalExpression_return retval = new PsimulexParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.additiveExpression_return additiveExpression83 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp84 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression85 = default(PsimulexParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:245:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:245:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1298);
            	additiveExpression83 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression83.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:245:28: ( relationalOp additiveExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( ((LA23_0 >= RelLessThan && LA23_0 <= RelGreaterThanOrEqual)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:245:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression1302);
            			    	relationalOp84 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp84.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1305);
            			    	additiveExpression85 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression85.Tree);

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
            	Memoize(input, 35, relationalExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:248:1: relationalOp : ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual );
    public PsimulexParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalOp_return retval = new PsimulexParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set86 = null;

        CommonTree set86_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:249:5: ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set86 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelLessThan && input.LA(1) <= RelGreaterThanOrEqual) ) 
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
            	Memoize(input, 36, relationalOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:252:1: additiveExpression : multiplicativeExpression ( additiveOp multiplicativeExpression )* ;
    public PsimulexParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveExpression_return retval = new PsimulexParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression87 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.additiveOp_return additiveOp88 = default(PsimulexParser.additiveOp_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression89 = default(PsimulexParser.multiplicativeExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:253:5: ( multiplicativeExpression ( additiveOp multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:253:9: multiplicativeExpression ( additiveOp multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1358);
            	multiplicativeExpression87 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression87.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:253:34: ( additiveOp multiplicativeExpression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= Plus && LA24_0 <= Minus)) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:253:36: additiveOp multiplicativeExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression1362);
            			    	additiveOp88 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp88.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1365);
            			    	multiplicativeExpression89 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression89.Tree);

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
            	Memoize(input, 37, additiveExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:256:1: additiveOp : ( Plus | Minus );
    public PsimulexParser.additiveOp_return additiveOp() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveOp_return retval = new PsimulexParser.additiveOp_return();
        retval.Start = input.LT(1);
        int additiveOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set90 = null;

        CommonTree set90_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:257:2: ( Plus | Minus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set90 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set90));
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
            	Memoize(input, 38, additiveOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:260:1: multiplicativeExpression : unaryExpression ( multiplicativeOp unaryExpression )* ;
    public PsimulexParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeExpression_return retval = new PsimulexParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryExpression_return unaryExpression91 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.multiplicativeOp_return multiplicativeOp92 = default(PsimulexParser.multiplicativeOp_return);

        PsimulexParser.unaryExpression_return unaryExpression93 = default(PsimulexParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:261:5: ( unaryExpression ( multiplicativeOp unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:261:9: unaryExpression ( multiplicativeOp unaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1400);
            	unaryExpression91 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression91.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:261:25: ( multiplicativeOp unaryExpression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( ((LA25_0 >= Star && LA25_0 <= Modulo)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:261:27: multiplicativeOp unaryExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression1404);
            			    	multiplicativeOp92 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp92.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1407);
            			    	unaryExpression93 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression93.Tree);

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
            	Memoize(input, 39, multiplicativeExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:264:1: multiplicativeOp : ( Star | Divide | Modulo );
    public PsimulexParser.multiplicativeOp_return multiplicativeOp() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeOp_return retval = new PsimulexParser.multiplicativeOp_return();
        retval.Start = input.LT(1);
        int multiplicativeOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set94 = null;

        CommonTree set94_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:265:2: ( Star | Divide | Modulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set94 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Star && input.LA(1) <= Modulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set94));
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
            	Memoize(input, 40, multiplicativeOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:268:1: unaryExpression : ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? | castExpression );
    public PsimulexParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpression_return retval = new PsimulexParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixOp_return unaryPrefixOp95 = default(PsimulexParser.unaryPrefixOp_return);

        PsimulexParser.unaryExpression_return unaryExpression96 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.primaryExpression_return primaryExpression97 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp98 = default(PsimulexParser.unaryPostfixOp_return);

        PsimulexParser.castExpression_return castExpression99 = default(PsimulexParser.castExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:5: ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? | castExpression )
            int alt27 = 3;
            switch ( input.LA(1) ) 
            {
            case Plus:
            case Minus:
            case PlusPlus:
            case MinusMinus:
            case LogicalNot:
            	{
                alt27 = 1;
                }
                break;
            case 111:
            	{
                int LA27_2 = input.LA(2);

                if ( (LA27_2 == StringLiteral || LA27_2 == Identifier || (LA27_2 >= Plus && LA27_2 <= Minus) || (LA27_2 >= PlusPlus && LA27_2 <= InfinityLiteral) || LA27_2 == 111) )
                {
                    alt27 = 2;
                }
                else if ( ((LA27_2 >= Bool && LA27_2 <= Edge)) )
                {
                    alt27 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d27s2 =
                        new NoViableAltException("", 27, 2, input);

                    throw nvae_d27s2;
                }
                }
                break;
            case StringLiteral:
            case Identifier:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            	{
                alt27 = 2;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:7: unaryPrefixOp unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPrefixOp_in_unaryExpression1442);
                    	unaryPrefixOp95 = unaryPrefixOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPrefixOp95.Tree, root_0);
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1445);
                    	unaryExpression96 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression96.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:7: primaryExpression ( unaryPostfixOp )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression1453);
                    	primaryExpression97 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression97.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:25: ( unaryPostfixOp )?
                    	int alt26 = 2;
                    	int LA26_0 = input.LA(1);

                    	if ( ((LA26_0 >= PlusPlus && LA26_0 <= MinusMinus)) )
                    	{
                    	    alt26 = 1;
                    	}
                    	switch (alt26) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:26: unaryPostfixOp
                    	        {
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpression1456);
                    	        	unaryPostfixOp98 = unaryPostfixOp();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp98.Tree, root_0);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:271:4: castExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpression1464);
                    	castExpression99 = castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, castExpression99.Tree);

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
            	Memoize(input, 41, unaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:274:1: castExpression : '(' dataType ')' unaryExpression ;
    public PsimulexParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.castExpression_return retval = new PsimulexParser.castExpression_return();
        retval.Start = input.LT(1);
        int castExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal100 = null;
        IToken char_literal102 = null;
        PsimulexParser.dataType_return dataType101 = default(PsimulexParser.dataType_return);

        PsimulexParser.unaryExpression_return unaryExpression103 = default(PsimulexParser.unaryExpression_return);


        CommonTree char_literal100_tree=null;
        CommonTree char_literal102_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:2: ( '(' dataType ')' unaryExpression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:4: '(' dataType ')' unaryExpression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal100=(IToken)Match(input,111,FOLLOW_111_in_castExpression1483); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal100_tree = (CommonTree)adaptor.Create(char_literal100);
            		adaptor.AddChild(root_0, char_literal100_tree);
            	}
            	PushFollow(FOLLOW_dataType_in_castExpression1485);
            	dataType101 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType101.Tree);
            	char_literal102=(IToken)Match(input,112,FOLLOW_112_in_castExpression1487); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal102_tree = (CommonTree)adaptor.Create(char_literal102);
            		adaptor.AddChild(root_0, char_literal102_tree);
            	}
            	PushFollow(FOLLOW_unaryExpression_in_castExpression1489);
            	unaryExpression103 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression103.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 42, castExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:278:1: unaryPrefixOp : ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot );
    public PsimulexParser.unaryPrefixOp_return unaryPrefixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixOp_return retval = new PsimulexParser.unaryPrefixOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set104 = null;

        CommonTree set104_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:279:2: ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set104 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) || (input.LA(1) >= PlusPlus && input.LA(1) <= LogicalNot) ) 
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
            	Memoize(input, 43, unaryPrefixOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryPrefixOp"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:282:1: unaryPostfixOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPostfixOp_return unaryPostfixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixOp_return retval = new PsimulexParser.unaryPostfixOp_return();
        retval.Start = input.LT(1);
        int unaryPostfixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set105 = null;

        CommonTree set105_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:283:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set105 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set105));
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
            	Memoize(input, 44, unaryPostfixOp_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryPostfixOp"

    public class unaryExpressionPostPlusPlusMinusMinus_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryExpressionPostPlusPlusMinusMinus"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:286:1: unaryExpressionPostPlusPlusMinusMinus : primaryExpression ( unaryPostfixOp )* ;
    public PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return unaryExpressionPostPlusPlusMinusMinus() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return retval = new PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return();
        retval.Start = input.LT(1);
        int unaryExpressionPostPlusPlusMinusMinus_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primaryExpression_return primaryExpression106 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp107 = default(PsimulexParser.unaryPostfixOp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:5: ( primaryExpression ( unaryPostfixOp )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:9: primaryExpression ( unaryPostfixOp )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1538);
            	primaryExpression106 = primaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression106.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:27: ( unaryPostfixOp )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( ((LA28_0 >= PlusPlus && LA28_0 <= MinusMinus)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:28: unaryPostfixOp
            			    {
            			    	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1541);
            			    	unaryPostfixOp107 = unaryPostfixOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp107.Tree, root_0);

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
            	Memoize(input, 45, unaryExpressionPostPlusPlusMinusMinus_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpressionPostPlusPlusMinusMinus"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:1: primaryExpression : ( parExpression | leftValue | literal | functionCall );
    public PsimulexParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.primaryExpression_return retval = new PsimulexParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression108 = default(PsimulexParser.parExpression_return);

        PsimulexParser.leftValue_return leftValue109 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal110 = default(PsimulexParser.literal_return);

        PsimulexParser.functionCall_return functionCall111 = default(PsimulexParser.functionCall_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:291:5: ( parExpression | leftValue | literal | functionCall )
            int alt29 = 4;
            switch ( input.LA(1) ) 
            {
            case 111:
            	{
                int LA29_1 = input.LA(2);

                if ( (synpred64_Psimulex()) )
                {
                    alt29 = 1;
                }
                else if ( (synpred65_Psimulex()) )
                {
                    alt29 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d29s1 =
                        new NoViableAltException("", 29, 1, input);

                    throw nvae_d29s1;
                }
                }
                break;
            case Identifier:
            	{
                int LA29_2 = input.LA(2);

                if ( (synpred65_Psimulex()) )
                {
                    alt29 = 2;
                }
                else if ( (true) )
                {
                    alt29 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d29s2 =
                        new NoViableAltException("", 29, 2, input);

                    throw nvae_d29s2;
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
                alt29 = 3;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:291:9: parExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1563);
                    	parExpression108 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression108.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:292:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1571);
                    	leftValue109 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue109.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1581);
                    	literal110 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal110.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:7: functionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionCall_in_primaryExpression1589);
                    	functionCall111 = functionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall111.Tree);

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
            	Memoize(input, 46, primaryExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:1: parExpression : '(' expression ')' ;
    public PsimulexParser.parExpression_return parExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.parExpression_return retval = new PsimulexParser.parExpression_return();
        retval.Start = input.LT(1);
        int parExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal112 = null;
        IToken char_literal114 = null;
        PsimulexParser.expression_return expression113 = default(PsimulexParser.expression_return);


        CommonTree char_literal112_tree=null;
        CommonTree char_literal114_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:5: ( '(' expression ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:9: '(' expression ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal112=(IToken)Match(input,111,FOLLOW_111_in_parExpression1608); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1611);
            	expression113 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression113.Tree);
            	char_literal114=(IToken)Match(input,112,FOLLOW_112_in_parExpression1613); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 47, parExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:1: leftValue : ( variable | selecting );
    public PsimulexParser.leftValue_return leftValue() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValue_return retval = new PsimulexParser.leftValue_return();
        retval.Start = input.LT(1);
        int leftValue_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.variable_return variable115 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting116 = default(PsimulexParser.selecting_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:2: ( variable | selecting )
            int alt30 = 2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0 == Identifier) )
            {
                int LA30_1 = input.LA(2);

                if ( (LA30_1 == EOF || LA30_1 == Assign || (LA30_1 >= AssignAndAdd && LA30_1 <= MinusMinus) || LA30_1 == 105 || (LA30_1 >= 109 && LA30_1 <= 110) || LA30_1 == 112) )
                {
                    alt30 = 1;
                }
                else if ( (LA30_1 == 108 || LA30_1 == 113) )
                {
                    alt30 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d30s1 =
                        new NoViableAltException("", 30, 1, input);

                    throw nvae_d30s1;
                }
            }
            else if ( (LA30_0 == 111) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1628);
                    	variable115 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable115.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:303:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1633);
                    	selecting116 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting116.Tree);

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
            	Memoize(input, 48, leftValue_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:306:1: variable : Identifier ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier117 = null;

        CommonTree Identifier117_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:307:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:307:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier117=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1644); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier117_tree = (CommonTree)adaptor.Create(Identifier117);
            		adaptor.AddChild(root_0, Identifier117_tree);
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
            	Memoize(input, 49, variable_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:1: selecting : ( Identifier | parExpression ) ( selector )+ ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier118 = null;
        PsimulexParser.parExpression_return parExpression119 = default(PsimulexParser.parExpression_return);

        PsimulexParser.selector_return selector120 = default(PsimulexParser.selector_return);


        CommonTree Identifier118_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:2: ( ( Identifier | parExpression ) ( selector )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:4: ( Identifier | parExpression ) ( selector )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:4: ( Identifier | parExpression )
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == Identifier) )
            	{
            	    alt31 = 1;
            	}
            	else if ( (LA31_0 == 111) )
            	{
            	    alt31 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d31s0 =
            	        new NoViableAltException("", 31, 0, input);

            	    throw nvae_d31s0;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:6: Identifier
            	        {
            	        	Identifier118=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selecting1657); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier118_tree = (CommonTree)adaptor.Create(Identifier118);
            	        		adaptor.AddChild(root_0, Identifier118_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:19: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selecting1661);
            	        	parExpression119 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression119.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:35: ( selector )+
            	int cnt32 = 0;
            	do 
            	{
            	    int alt32 = 2;
            	    int LA32_0 = input.LA(1);

            	    if ( (LA32_0 == 108 || LA32_0 == 113) )
            	    {
            	        alt32 = 1;
            	    }


            	    switch (alt32) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: selector
            			    {
            			    	PushFollow(FOLLOW_selector_in_selecting1665);
            			    	selector120 = selector();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selector120.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt32 >= 1 ) goto loop32;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(32, input);
            		            throw eee;
            	    }
            	    cnt32++;
            	} while (true);

            	loop32:
            		;	// Stops C# compiler whinging that label 'loop32' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 50, selecting_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:1: selector : ( memberSelect | memberFunctionCall | indexing );
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberSelect_return memberSelect121 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall122 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing123 = default(PsimulexParser.indexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:5: ( memberSelect | memberFunctionCall | indexing )
            int alt33 = 3;
            int LA33_0 = input.LA(1);

            if ( (LA33_0 == 113) )
            {
                int LA33_1 = input.LA(2);

                if ( (LA33_1 == Identifier) )
                {
                    int LA33_3 = input.LA(3);

                    if ( (LA33_3 == 111) )
                    {
                        alt33 = 2;
                    }
                    else if ( (LA33_3 == EOF || LA33_3 == Assign || (LA33_3 >= AssignAndAdd && LA33_3 <= MinusMinus) || LA33_3 == 105 || (LA33_3 >= 108 && LA33_3 <= 110) || (LA33_3 >= 112 && LA33_3 <= 113)) )
                    {
                        alt33 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d33s3 =
                            new NoViableAltException("", 33, 3, input);

                        throw nvae_d33s3;
                    }
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d33s1 =
                        new NoViableAltException("", 33, 1, input);

                    throw nvae_d33s1;
                }
            }
            else if ( (LA33_0 == 108) )
            {
                alt33 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d33s0 =
                    new NoViableAltException("", 33, 0, input);

                throw nvae_d33s0;
            }
            switch (alt33) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:9: memberSelect
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberSelect_in_selector1682);
                    	memberSelect121 = memberSelect();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect121.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:316:9: memberFunctionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberFunctionCall_in_selector1692);
                    	memberFunctionCall122 = memberFunctionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall122.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:9: indexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_indexing_in_selector1702);
                    	indexing123 = indexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing123.Tree);

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
            	Memoize(input, 51, selector_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:320:1: memberSelect : '.' Identifier -> ^( MEMBER_SELECT Identifier ) ;
    public PsimulexParser.memberSelect_return memberSelect() // throws RecognitionException [1]
    {   
        PsimulexParser.memberSelect_return retval = new PsimulexParser.memberSelect_return();
        retval.Start = input.LT(1);
        int memberSelect_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal124 = null;
        IToken Identifier125 = null;

        CommonTree char_literal124_tree=null;
        CommonTree Identifier125_tree=null;
        RewriteRuleTokenStream stream_113 = new RewriteRuleTokenStream(adaptor,"token 113");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:2: ( '.' Identifier -> ^( MEMBER_SELECT Identifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:4: '.' Identifier
            {
            	char_literal124=(IToken)Match(input,113,FOLLOW_113_in_memberSelect1716); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_113.Add(char_literal124);

            	Identifier125=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect1718); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier125);



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
            	// 321:19: -> ^( MEMBER_SELECT Identifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:321:22: ^( MEMBER_SELECT Identifier )
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
            	Memoize(input, 52, memberSelect_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:324:1: memberFunctionCall : '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal126 = null;
        IToken Identifier127 = null;
        PsimulexParser.arguments_return arguments128 = default(PsimulexParser.arguments_return);


        CommonTree char_literal126_tree=null;
        CommonTree Identifier127_tree=null;
        RewriteRuleTokenStream stream_113 = new RewriteRuleTokenStream(adaptor,"token 113");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:2: ( '.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:4: '.' Identifier arguments
            {
            	char_literal126=(IToken)Match(input,113,FOLLOW_113_in_memberFunctionCall1739); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_113.Add(char_literal126);

            	Identifier127=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall1741); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier127);

            	PushFollow(FOLLOW_arguments_in_memberFunctionCall1743);
            	arguments128 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments128.Tree);


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
            	// 325:29: -> ^( MEMBER_FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:32: ^( MEMBER_FUNCTION_CALL Identifier arguments )
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
            	Memoize(input, 53, memberFunctionCall_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:328:1: functionCall : Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) ;
    public PsimulexParser.functionCall_return functionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.functionCall_return retval = new PsimulexParser.functionCall_return();
        retval.Start = input.LT(1);
        int functionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier129 = null;
        PsimulexParser.arguments_return arguments130 = default(PsimulexParser.arguments_return);


        CommonTree Identifier129_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:2: ( Identifier arguments -> ^( FUNCTION_CALL Identifier arguments ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:4: Identifier arguments
            {
            	Identifier129=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionCall1766); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier129);

            	PushFollow(FOLLOW_arguments_in_functionCall1768);
            	arguments130 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_arguments.Add(arguments130.Tree);


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
            	// 329:25: -> ^( FUNCTION_CALL Identifier arguments )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:28: ^( FUNCTION_CALL Identifier arguments )
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
            	Memoize(input, 54, functionCall_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:332:1: indexing : '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) ;
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal131 = null;
        IToken char_literal133 = null;
        IToken char_literal135 = null;
        PsimulexParser.expression_return expression132 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression134 = default(PsimulexParser.expression_return);


        CommonTree char_literal131_tree=null;
        CommonTree char_literal133_tree=null;
        CommonTree char_literal135_tree=null;
        RewriteRuleTokenStream stream_109 = new RewriteRuleTokenStream(adaptor,"token 109");
        RewriteRuleTokenStream stream_110 = new RewriteRuleTokenStream(adaptor,"token 110");
        RewriteRuleTokenStream stream_108 = new RewriteRuleTokenStream(adaptor,"token 108");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:2: ( '[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:4: '[' expression ( ',' expression )* ']'
            {
            	char_literal131=(IToken)Match(input,108,FOLLOW_108_in_indexing1791); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_108.Add(char_literal131);

            	PushFollow(FOLLOW_expression_in_indexing1793);
            	expression132 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression132.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:19: ( ',' expression )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == 109) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:21: ',' expression
            			    {
            			    	char_literal133=(IToken)Match(input,109,FOLLOW_109_in_indexing1797); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_109.Add(char_literal133);

            			    	PushFollow(FOLLOW_expression_in_indexing1799);
            			    	expression134 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_expression.Add(expression134.Tree);

            			    }
            			    break;

            			default:
            			    goto loop34;
            	    }
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whining that label 'loop34' has no statements

            	char_literal135=(IToken)Match(input,110,FOLLOW_110_in_indexing1804); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_110.Add(char_literal135);



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
            	// 333:43: -> ^( INDEXING expression ( expression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:46: ^( INDEXING expression ( expression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(INDEXING, "INDEXING"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:69: ( expression )*
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
            	Memoize(input, 55, indexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:336:1: arguments : '(' ( expression ( ',' expression )* )? ')' ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal136 = null;
        IToken char_literal138 = null;
        IToken char_literal140 = null;
        PsimulexParser.expression_return expression137 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression139 = default(PsimulexParser.expression_return);


        CommonTree char_literal136_tree=null;
        CommonTree char_literal138_tree=null;
        CommonTree char_literal140_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:5: ( '(' ( expression ( ',' expression )* )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:9: '(' ( expression ( ',' expression )* )? ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal136=(IToken)Match(input,111,FOLLOW_111_in_arguments1838); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:14: ( expression ( ',' expression )* )?
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == StringLiteral || LA36_0 == Identifier || (LA36_0 >= Plus && LA36_0 <= Minus) || (LA36_0 >= PlusPlus && LA36_0 <= InfinityLiteral) || LA36_0 == 111) )
            	{
            	    alt36 = 1;
            	}
            	switch (alt36) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:16: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_arguments1843);
            	        	expression137 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression137.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:27: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt35 = 2;
            	        	    int LA35_0 = input.LA(1);

            	        	    if ( (LA35_0 == 109) )
            	        	    {
            	        	        alt35 = 1;
            	        	    }


            	        	    switch (alt35) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:28: ',' expression
            	        			    {
            	        			    	char_literal138=(IToken)Match(input,109,FOLLOW_109_in_arguments1846); if (state.failed) return retval;
            	        			    	PushFollow(FOLLOW_expression_in_arguments1849);
            	        			    	expression139 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression139.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop35;
            	        	    }
            	        	} while (true);

            	        	loop35:
            	        		;	// Stops C# compiler whining that label 'loop35' has no statements


            	        }
            	        break;

            	}

            	char_literal140=(IToken)Match(input,112,FOLLOW_112_in_arguments1856); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 56, arguments_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:340:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
    public PsimulexParser.literal_return literal() // throws RecognitionException [1]
    {   
        PsimulexParser.literal_return retval = new PsimulexParser.literal_return();
        retval.Start = input.LT(1);
        int literal_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set141 = null;

        CommonTree set141_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set141 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || (input.LA(1) >= IntegerLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set141));
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
            	Memoize(input, 57, literal_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:388:1: block : '{' ( statement )* '}' -> ^( BLOCK ( statement )* ) ;
    public PsimulexParser.block_return block() // throws RecognitionException [1]
    {   
        PsimulexParser.block_return retval = new PsimulexParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal142 = null;
        IToken char_literal144 = null;
        PsimulexParser.statement_return statement143 = default(PsimulexParser.statement_return);


        CommonTree char_literal142_tree=null;
        CommonTree char_literal144_tree=null;
        RewriteRuleTokenStream stream_107 = new RewriteRuleTokenStream(adaptor,"token 107");
        RewriteRuleTokenStream stream_106 = new RewriteRuleTokenStream(adaptor,"token 106");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:389:5: ( '{' ( statement )* '}' -> ^( BLOCK ( statement )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:389:9: '{' ( statement )* '}'
            {
            	char_literal142=(IToken)Match(input,106,FOLLOW_106_in_block1972); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_106.Add(char_literal142);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:389:13: ( statement )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == StringLiteral || LA37_0 == Identifier || (LA37_0 >= Bool && LA37_0 <= Edge) || (LA37_0 >= Plus && LA37_0 <= Minus) || (LA37_0 >= PlusPlus && LA37_0 <= If) || (LA37_0 >= For && LA37_0 <= Continue) || LA37_0 == 105 || LA37_0 == 111) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block1974);
            			    	statement143 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_statement.Add(statement143.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements

            	char_literal144=(IToken)Match(input,107,FOLLOW_107_in_block1977); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_107.Add(char_literal144);



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
            	// 389:28: -> ^( BLOCK ( statement )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:389:31: ^( BLOCK ( statement )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:389:40: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statement.NextTree());

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
            	Memoize(input, 58, block_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:392:1: branch : ( block | statement );
    public PsimulexParser.branch_return branch() // throws RecognitionException [1]
    {   
        PsimulexParser.branch_return retval = new PsimulexParser.branch_return();
        retval.Start = input.LT(1);
        int branch_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.block_return block145 = default(PsimulexParser.block_return);

        PsimulexParser.statement_return statement146 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:5: ( block | statement )
            int alt38 = 2;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == 106) )
            {
                alt38 = 1;
            }
            else if ( (LA38_0 == StringLiteral || LA38_0 == Identifier || (LA38_0 >= Bool && LA38_0 <= Edge) || (LA38_0 >= Plus && LA38_0 <= Minus) || (LA38_0 >= PlusPlus && LA38_0 <= If) || (LA38_0 >= For && LA38_0 <= Continue) || LA38_0 == 105 || LA38_0 == 111) )
            {
                alt38 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d38s0 =
                    new NoViableAltException("", 38, 0, input);

                throw nvae_d38s0;
            }
            switch (alt38) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:7: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch2013);
                    	block145 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block145.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:15: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_branch2017);
                    	statement146 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement146.Tree);

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
            	Memoize(input, 59, branch_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:396:1: statement : ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' | localVariableDeclaration ';' );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken If147 = null;
        IToken Else150 = null;
        IToken set152 = null;
        IToken char_literal153 = null;
        IToken char_literal155 = null;
        IToken set157 = null;
        IToken char_literal158 = null;
        IToken char_literal160 = null;
        IToken Loop162 = null;
        IToken char_literal163 = null;
        IToken char_literal165 = null;
        IToken While167 = null;
        IToken Do170 = null;
        IToken While172 = null;
        IToken char_literal174 = null;
        IToken PDo175 = null;
        IToken Return177 = null;
        IToken char_literal179 = null;
        IToken Break180 = null;
        IToken char_literal181 = null;
        IToken Continue182 = null;
        IToken char_literal183 = null;
        IToken char_literal184 = null;
        IToken char_literal186 = null;
        IToken char_literal188 = null;
        PsimulexParser.parExpression_return parExpression148 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch149 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch151 = default(PsimulexParser.branch_return);

        PsimulexParser.forControl_return forControl154 = default(PsimulexParser.forControl_return);

        PsimulexParser.branch_return branch156 = default(PsimulexParser.branch_return);

        PsimulexParser.foreachControl_return foreachControl159 = default(PsimulexParser.foreachControl_return);

        PsimulexParser.branch_return branch161 = default(PsimulexParser.branch_return);

        PsimulexParser.loopControl_return loopControl164 = default(PsimulexParser.loopControl_return);

        PsimulexParser.branch_return branch166 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression168 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch169 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch171 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression173 = default(PsimulexParser.parExpression_return);

        PsimulexParser.block_return block176 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression178 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression185 = default(PsimulexParser.expression_return);

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration187 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree If147_tree=null;
        CommonTree Else150_tree=null;
        CommonTree set152_tree=null;
        CommonTree char_literal153_tree=null;
        CommonTree char_literal155_tree=null;
        CommonTree set157_tree=null;
        CommonTree char_literal158_tree=null;
        CommonTree char_literal160_tree=null;
        CommonTree Loop162_tree=null;
        CommonTree char_literal163_tree=null;
        CommonTree char_literal165_tree=null;
        CommonTree While167_tree=null;
        CommonTree Do170_tree=null;
        CommonTree While172_tree=null;
        CommonTree char_literal174_tree=null;
        CommonTree PDo175_tree=null;
        CommonTree Return177_tree=null;
        CommonTree char_literal179_tree=null;
        CommonTree Break180_tree=null;
        CommonTree char_literal181_tree=null;
        CommonTree Continue182_tree=null;
        CommonTree char_literal183_tree=null;
        CommonTree char_literal184_tree=null;
        CommonTree char_literal186_tree=null;
        CommonTree char_literal188_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:5: ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' | localVariableDeclaration ';' )
            int alt41 = 13;
            switch ( input.LA(1) ) 
            {
            case If:
            	{
                alt41 = 1;
                }
                break;
            case For:
            case PFor:
            	{
                alt41 = 2;
                }
                break;
            case ForEach:
            case PForEach:
            	{
                alt41 = 3;
                }
                break;
            case Loop:
            	{
                alt41 = 4;
                }
                break;
            case While:
            	{
                alt41 = 5;
                }
                break;
            case Do:
            	{
                alt41 = 6;
                }
                break;
            case PDo:
            	{
                alt41 = 7;
                }
                break;
            case Return:
            	{
                alt41 = 8;
                }
                break;
            case Break:
            	{
                alt41 = 9;
                }
                break;
            case Continue:
            	{
                alt41 = 10;
                }
                break;
            case 105:
            	{
                alt41 = 11;
                }
                break;
            case StringLiteral:
            case Identifier:
            case Plus:
            case Minus:
            case PlusPlus:
            case MinusMinus:
            case LogicalNot:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            case 111:
            	{
                alt41 = 12;
                }
                break;
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
            	{
                alt41 = 13;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d41s0 =
            	        new NoViableAltException("", 41, 0, input);

            	    throw nvae_d41s0;
            }

            switch (alt41) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:7: If parExpression branch ( options {k=1; } : Else branch )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	If147=(IToken)Match(input,If,FOLLOW_If_in_statement2035); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{If147_tree = (CommonTree)adaptor.Create(If147);
                    		adaptor.AddChild(root_0, If147_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement2037);
                    	parExpression148 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression148.Tree);
                    	PushFollow(FOLLOW_branch_in_statement2039);
                    	branch149 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch149.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:31: ( options {k=1; } : Else branch )?
                    	int alt39 = 2;
                    	int LA39_0 = input.LA(1);

                    	if ( (LA39_0 == Else) )
                    	{
                    	    int LA39_1 = input.LA(2);

                    	    if ( (synpred83_Psimulex()) )
                    	    {
                    	        alt39 = 1;
                    	    }
                    	}
                    	switch (alt39) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:47: Else branch
                    	        {
                    	        	Else150=(IToken)Match(input,Else,FOLLOW_Else_in_statement2049); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{Else150_tree = (CommonTree)adaptor.Create(Else150);
                    	        		adaptor.AddChild(root_0, Else150_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_branch_in_statement2051);
                    	        	branch151 = branch();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch151.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:398:9: ( For | PFor ) '(' forControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set152 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= For && input.LA(1) <= PFor) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set152));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal153=(IToken)Match(input,111,FOLLOW_111_in_statement2069); if (state.failed) return retval;
                    	PushFollow(FOLLOW_forControl_in_statement2072);
                    	forControl154 = forControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forControl154.Tree);
                    	char_literal155=(IToken)Match(input,112,FOLLOW_112_in_statement2074); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement2077);
                    	branch156 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch156.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:399:9: ( ForEach | PForEach ) '(' foreachControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set157 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= ForEach && input.LA(1) <= PForEach) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set157));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal158=(IToken)Match(input,111,FOLLOW_111_in_statement2093); if (state.failed) return retval;
                    	PushFollow(FOLLOW_foreachControl_in_statement2096);
                    	foreachControl159 = foreachControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, foreachControl159.Tree);
                    	char_literal160=(IToken)Match(input,112,FOLLOW_112_in_statement2098); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement2101);
                    	branch161 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch161.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:400:9: Loop '(' loopControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Loop162=(IToken)Match(input,Loop,FOLLOW_Loop_in_statement2111); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Loop162_tree = (CommonTree)adaptor.Create(Loop162);
                    		adaptor.AddChild(root_0, Loop162_tree);
                    	}
                    	char_literal163=(IToken)Match(input,111,FOLLOW_111_in_statement2113); if (state.failed) return retval;
                    	PushFollow(FOLLOW_loopControl_in_statement2116);
                    	loopControl164 = loopControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopControl164.Tree);
                    	char_literal165=(IToken)Match(input,112,FOLLOW_112_in_statement2118); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement2121);
                    	branch166 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch166.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:9: While parExpression branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	While167=(IToken)Match(input,While,FOLLOW_While_in_statement2131); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While167_tree = (CommonTree)adaptor.Create(While167);
                    		adaptor.AddChild(root_0, While167_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement2133);
                    	parExpression168 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression168.Tree);
                    	PushFollow(FOLLOW_branch_in_statement2135);
                    	branch169 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch169.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:402:9: Do branch While parExpression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Do170=(IToken)Match(input,Do,FOLLOW_Do_in_statement2145); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Do170_tree = (CommonTree)adaptor.Create(Do170);
                    		adaptor.AddChild(root_0, Do170_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement2147);
                    	branch171 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch171.Tree);
                    	While172=(IToken)Match(input,While,FOLLOW_While_in_statement2149); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While172_tree = (CommonTree)adaptor.Create(While172);
                    		adaptor.AddChild(root_0, While172_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement2151);
                    	parExpression173 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression173.Tree);
                    	char_literal174=(IToken)Match(input,105,FOLLOW_105_in_statement2153); if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:403:9: PDo block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PDo175=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement2164); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PDo175_tree = (CommonTree)adaptor.Create(PDo175);
                    		adaptor.AddChild(root_0, PDo175_tree);
                    	}
                    	PushFollow(FOLLOW_block_in_statement2166);
                    	block176 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block176.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:404:9: Return ( expression )? ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Return177=(IToken)Match(input,Return,FOLLOW_Return_in_statement2176); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Return177_tree = (CommonTree)adaptor.Create(Return177);
                    		adaptor.AddChild(root_0, Return177_tree);
                    	}
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:404:16: ( expression )?
                    	int alt40 = 2;
                    	int LA40_0 = input.LA(1);

                    	if ( (LA40_0 == StringLiteral || LA40_0 == Identifier || (LA40_0 >= Plus && LA40_0 <= Minus) || (LA40_0 >= PlusPlus && LA40_0 <= InfinityLiteral) || LA40_0 == 111) )
                    	{
                    	    alt40 = 1;
                    	}
                    	switch (alt40) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement2178);
                    	        	expression178 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression178.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal179=(IToken)Match(input,105,FOLLOW_105_in_statement2181); if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:405:9: Break ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Break180=(IToken)Match(input,Break,FOLLOW_Break_in_statement2192); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break180_tree = (CommonTree)adaptor.Create(Break180);
                    		adaptor.AddChild(root_0, Break180_tree);
                    	}
                    	char_literal181=(IToken)Match(input,105,FOLLOW_105_in_statement2194); if (state.failed) return retval;

                    }
                    break;
                case 10 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:406:9: Continue ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Continue182=(IToken)Match(input,Continue,FOLLOW_Continue_in_statement2205); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Continue182_tree = (CommonTree)adaptor.Create(Continue182);
                    		adaptor.AddChild(root_0, Continue182_tree);
                    	}
                    	char_literal183=(IToken)Match(input,105,FOLLOW_105_in_statement2207); if (state.failed) return retval;

                    }
                    break;
                case 11 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:407:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal184=(IToken)Match(input,105,FOLLOW_105_in_statement2218); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:408:9: expression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_statement2229);
                    	expression185 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression185.Tree);
                    	char_literal186=(IToken)Match(input,105,FOLLOW_105_in_statement2231); if (state.failed) return retval;

                    }
                    break;
                case 13 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:409:7: localVariableDeclaration ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_localVariableDeclaration_in_statement2240);
                    	localVariableDeclaration187 = localVariableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration187.Tree);
                    	char_literal188=(IToken)Match(input,105,FOLLOW_105_in_statement2242); if (state.failed) return retval;

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
            	Memoize(input, 60, statement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statement"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:412:1: forControl : ( forInit )? ';' ( expression )? ';' ( forUpdate )? ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal190 = null;
        IToken char_literal192 = null;
        PsimulexParser.forInit_return forInit189 = default(PsimulexParser.forInit_return);

        PsimulexParser.expression_return expression191 = default(PsimulexParser.expression_return);

        PsimulexParser.forUpdate_return forUpdate193 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal190_tree=null;
        CommonTree char_literal192_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:5: ( ( forInit )? ';' ( expression )? ';' ( forUpdate )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:10: ( forInit )? ';' ( expression )? ';' ( forUpdate )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:10: ( forInit )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( ((LA42_0 >= Bool && LA42_0 <= Edge)) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl2267);
            	        	forInit189 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInit189.Tree);

            	        }
            	        break;

            	}

            	char_literal190=(IToken)Match(input,105,FOLLOW_105_in_forControl2270); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:24: ( expression )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == StringLiteral || LA43_0 == Identifier || (LA43_0 >= Plus && LA43_0 <= Minus) || (LA43_0 >= PlusPlus && LA43_0 <= InfinityLiteral) || LA43_0 == 111) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forControl2273);
            	        	expression191 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression191.Tree);

            	        }
            	        break;

            	}

            	char_literal192=(IToken)Match(input,105,FOLLOW_105_in_forControl2276); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:413:41: ( forUpdate )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( (LA44_0 == StringLiteral || LA44_0 == Identifier || (LA44_0 >= Plus && LA44_0 <= Minus) || (LA44_0 >= PlusPlus && LA44_0 <= InfinityLiteral) || LA44_0 == 111) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl2279);
            	        	forUpdate193 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forUpdate193.Tree);

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
            	Memoize(input, 61, forControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:416:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration194 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:5: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:9: localVariableDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit2299);
            	localVariableDeclaration194 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration194.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 62, forInit_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forInit"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:420:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression195 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:421:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:421:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate2318);
            	expression195 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression195.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 63, forUpdate_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forUpdate"

    public class foreachControl_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "foreachControl"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:424:1: foreachControl options {k=3; } : type Identifier In expression ;
    public PsimulexParser.foreachControl_return foreachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.foreachControl_return retval = new PsimulexParser.foreachControl_return();
        retval.Start = input.LT(1);
        int foreachControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier197 = null;
        IToken In198 = null;
        PsimulexParser.type_return type196 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression199 = default(PsimulexParser.expression_return);


        CommonTree Identifier197_tree=null;
        CommonTree In198_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:5: ( type Identifier In expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:426:9: type Identifier In expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_foreachControl2349);
            	type196 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type196.Tree);
            	Identifier197=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_foreachControl2351); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier197_tree = (CommonTree)adaptor.Create(Identifier197);
            		adaptor.AddChild(root_0, Identifier197_tree);
            	}
            	In198=(IToken)Match(input,In,FOLLOW_In_in_foreachControl2353); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{In198_tree = (CommonTree)adaptor.Create(In198);
            		adaptor.AddChild(root_0, In198_tree);
            	}
            	PushFollow(FOLLOW_expression_in_foreachControl2355);
            	expression199 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression199.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 64, foreachControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "foreachControl"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:430:1: loopControl options {k=3; } : type Identifier To expression ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier201 = null;
        IToken To202 = null;
        PsimulexParser.type_return type200 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression203 = default(PsimulexParser.expression_return);


        CommonTree Identifier201_tree=null;
        CommonTree To202_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:5: ( type Identifier To expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:9: type Identifier To expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_loopControl2387);
            	type200 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type200.Tree);
            	Identifier201=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_loopControl2389); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier201_tree = (CommonTree)adaptor.Create(Identifier201);
            		adaptor.AddChild(root_0, Identifier201_tree);
            	}
            	To202=(IToken)Match(input,To,FOLLOW_To_in_loopControl2391); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{To202_tree = (CommonTree)adaptor.Create(To202);
            		adaptor.AddChild(root_0, To202_tree);
            	}
            	PushFollow(FOLLOW_expression_in_loopControl2393);
            	expression203 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression203.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 65, loopControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "loopControl"

    // $ANTLR start "synpred1_Psimulex"
    public void synpred1_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:9: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:9: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex195);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred3_Psimulex"
    public void synpred3_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:4: ( memberDeclaration )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:4: memberDeclaration
        {
        	PushFollow(FOLLOW_memberDeclaration_in_synpred3_Psimulex288);
        	memberDeclaration();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_Psimulex"

    // $ANTLR start "synpred8_Psimulex"
    public void synpred8_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:9: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:9: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred8_Psimulex507);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_Psimulex"

    // $ANTLR start "synpred9_Psimulex"
    public void synpred9_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:9: ( typedIdentifierNonRef Assign variableInitializer )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:9: typedIdentifierNonRef Assign variableInitializer
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex525);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Assign,FOLLOW_Assign_in_synpred9_Psimulex527); if (state.failed) return ;
        	PushFollow(FOLLOW_variableInitializer_in_synpred9_Psimulex529);
        	variableInitializer();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Psimulex"

    // $ANTLR start "synpred15_Psimulex"
    public void synpred15_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:4: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:4: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred15_Psimulex755);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_Psimulex"

    // $ANTLR start "synpred36_Psimulex"
    public void synpred36_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred36_Psimulex1096);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred36_Psimulex"

    // $ANTLR start "synpred64_Psimulex"
    public void synpred64_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:291:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:291:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred64_Psimulex1563);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred64_Psimulex"

    // $ANTLR start "synpred65_Psimulex"
    public void synpred65_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:292:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:292:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred65_Psimulex1571);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred65_Psimulex"

    // $ANTLR start "synpred83_Psimulex"
    public void synpred83_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:47: ( Else branch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:47: Else branch
        {
        	Match(input,Else,FOLLOW_Else_in_synpred83_Psimulex2049); if (state.failed) return ;
        	PushFollow(FOLLOW_branch_in_synpred83_Psimulex2051);
        	branch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred83_Psimulex"

    // Delegated rules

   	public bool synpred15_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred3_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred36_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred36_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred65_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred65_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred83_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred83_Psimulex_fragment(); // can never throw exception
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
   	protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa8 = new DFA8(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	    this.dfa8.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA8_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x15\uffff";
    const string DFA1_eofS =
        "\x01\x12\x14\uffff";
    const string DFA1_minS =
        "\x01\x1d\x0f\uffff\x03\x00\x02\uffff";
    const string DFA1_maxS =
        "\x01\x6f\x0f\uffff\x03\x00\x02\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x11\uffff\x01\x02\x01\uffff";
    const string DFA1_specialS =
        "\x10\uffff\x01\x00\x01\x01\x01\x02\x02\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x13\x01\x01\x01\x13\x01\x01\x02\uffff\x06\x10\x0c\x11"+
            "\x0d\uffff\x02\x01\x03\uffff\x0a\x01\x01\uffff\x0b\x01\x0c\uffff"+
            "\x01\x01\x05\uffff\x01\x01",
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
            "\x01\uffff",
            "\x01\uffff",
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
            get { return "54:7: ( simpleProgram | multiFunctionalProgram )"; }
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

                   	else if ( (true) ) { s = 19; }

                   	 
                   	input.Seek(index1_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_17 = input.LA(1);

                   	 
                   	int index1_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (true) ) { s = 19; }

                   	 
                   	input.Seek(index1_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_18 = input.LA(1);

                   	 
                   	int index1_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (true) ) { s = 19; }

                   	 
                   	input.Seek(index1_18);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA8_eotS =
        "\x1c\uffff";
    const string DFA8_eofS =
        "\x04\uffff\x01\x0f\x02\uffff\x01\x0f\x14\uffff";
    const string DFA8_minS =
        "\x01\x23\x02\x20\x01\x1e\x01\x21\x01\uffff\x01\x1e\x01\x21\x01"+
        "\uffff\x06\x00\x02\uffff\x07\x00\x02\uffff\x01\x00\x01\uffff";
    const string DFA8_maxS =
        "\x01\x34\x02\x6c\x01\x6f\x01\x69\x01\uffff\x01\x6f\x01\x69\x01"+
        "\uffff\x06\x00\x02\uffff\x07\x00\x02\uffff\x01\x00\x01\uffff";
    const string DFA8_acceptS =
        "\x05\uffff\x01\x03\x09\uffff\x01\x01\x0b\uffff\x01\x02";
    const string DFA8_specialS =
        "\x09\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x02"+
        "\uffff\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x02"+
        "\uffff\x01\x0d\x01\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x06\x01\x0c\x02",
            "\x01\x04\x01\uffff\x01\x05\x49\uffff\x01\x03",
            "\x01\x07\x01\uffff\x01\x05\x49\uffff\x01\x06",
            "\x01\x0c\x01\uffff\x01\x09\x21\uffff\x02\x0b\x03\uffff\x03"+
            "\x0b\x06\x0c\x1d\uffff\x01\x0d\x01\x0e\x01\x0a",
            "\x01\x11\x47\uffff\x01\x0f",
            "",
            "\x01\x15\x01\uffff\x01\x12\x21\uffff\x02\x14\x03\uffff\x03"+
            "\x14\x06\x15\x1d\uffff\x01\x16\x01\x17\x01\x13",
            "\x01\x1a\x47\uffff\x01\x0f",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
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
            get { return "103:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );"; }
        }

    }


    protected internal int DFA8_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA8_9 = input.LA(1);

                   	 
                   	int index8_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA8_10 = input.LA(1);

                   	 
                   	int index8_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA8_11 = input.LA(1);

                   	 
                   	int index8_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA8_12 = input.LA(1);

                   	 
                   	int index8_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA8_13 = input.LA(1);

                   	 
                   	int index8_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA8_14 = input.LA(1);

                   	 
                   	int index8_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA8_17 = input.LA(1);

                   	 
                   	int index8_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA8_18 = input.LA(1);

                   	 
                   	int index8_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA8_19 = input.LA(1);

                   	 
                   	int index8_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA8_20 = input.LA(1);

                   	 
                   	int index8_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA8_21 = input.LA(1);

                   	 
                   	int index8_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA8_22 = input.LA(1);

                   	 
                   	int index8_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA8_23 = input.LA(1);

                   	 
                   	int index8_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 15; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA8_26 = input.LA(1);

                   	 
                   	int index8_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_26);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 8, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit195 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit199 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit203 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_simpleProgram218 = new BitSet(new ulong[]{0x001FFFF940000002UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_importDeclarations_in_multiFunctionalProgram247 = new BitSet(new ulong[]{0x001FFFFBC0000000UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_typeDeclarations_in_multiFunctionalProgram249 = new BitSet(new ulong[]{0x001FFFFB40000000UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram251 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_functionDeclarations_in_multiFunctionalProgram253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclarations288 = new BitSet(new ulong[]{0x001FFFFB40000002UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_Import_in_importDeclarations328 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclarations330 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_importDeclarations332 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclarations365 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration396 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration398 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000040000000000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_106_in_structBody430 = new BitSet(new ulong[]{0x001FFFFB40000000UL,0x00008A001FFDFF8CUL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBody433 = new BitSet(new ulong[]{0x001FFFFB40000000UL,0x00008A001FFDFF8CUL});
    public static readonly BitSet FOLLOW_107_in_structBody436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_memberDeclaration457 = new BitSet(new ulong[]{0x0000000200000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_Assign_in_memberDeclaration461 = new BitSet(new ulong[]{0x0000000040000000UL,0x000000000000FC00UL});
    public static readonly BitSet FOLLOW_literal_in_memberDeclaration463 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_memberDeclaration468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration525 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration527 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_localVariableDeclaration544 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration546 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInitializer581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_scalarOrArrayType601 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_arrayType_in_scalarOrArrayType603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_staticArrayType_in_arrayType628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dynamicArrayType_in_arrayType632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_108_in_staticArrayType644 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_staticArrayType646 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_109_in_staticArrayType649 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_staticArrayType651 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_110_in_staticArrayType655 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_108_in_dynamicArrayType683 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_109_in_dynamicArrayType687 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_110_in_dynamicArrayType692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef723 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierNonRef725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierRef737 = new BitSet(new ulong[]{0x0000000500000000UL});
    public static readonly BitSet FOLLOW_Reference_in_typedIdentifierRef739 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierRef742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_typedIdentifier755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_typedIdentifier759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_functionDeclarations776 = new BitSet(new ulong[]{0x001FFFF940000002UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_functionDeclaration809 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_111_in_functionDeclaration811 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x0001A2001FFDFF8CUL});
    public static readonly BitSet FOLLOW_formalParameters_in_functionDeclaration813 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_112_in_functionDeclaration816 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000040000000000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_formalParameters852 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_109_in_formalParameters855 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x0000A2001FFDFF8CUL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_formalParameters857 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_dataType_in_type899 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataTypeName_in_dataType918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataTypeName939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataTypeName943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expression1096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exp_in_expression1100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_exp1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment1135 = new BitSet(new ulong[]{0x03E0000200000000UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment1137 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_assignment1139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1198 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression1202 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1205 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1227 = new BitSet(new ulong[]{0x0800000000000002UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression1231 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1234 = new BitSet(new ulong[]{0x0800000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1256 = new BitSet(new ulong[]{0x3000000000000002UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression1260 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1263 = new BitSet(new ulong[]{0x3000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1298 = new BitSet(new ulong[]{0xC000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression1302 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1305 = new BitSet(new ulong[]{0xC000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1358 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression1362 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1365 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1400 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000070UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression1404 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1407 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000070UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryExpression1442 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression1453 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpression1456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpression1464 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_111_in_castExpression1483 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000182001FFDFF8CUL});
    public static readonly BitSet FOLLOW_dataType_in_castExpression1485 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_112_in_castExpression1487 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1538 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1541 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_primaryExpression1589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_111_in_parExpression1608 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1611 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_112_in_parExpression1613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1633 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selecting1657 = new BitSet(new ulong[]{0x0000000000000000UL,0x0002100000000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selecting1661 = new BitSet(new ulong[]{0x0000000000000000UL,0x0002100000000000UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1665 = new BitSet(new ulong[]{0x0000000000000002UL,0x0002100000000000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector1682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector1692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_indexing_in_selector1702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_113_in_memberSelect1716 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect1718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_113_in_memberFunctionCall1739 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall1741 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall1743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall1766 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_arguments_in_functionCall1768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_108_in_indexing1791 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_indexing1793 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_109_in_indexing1797 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_indexing1799 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000600000000000UL});
    public static readonly BitSet FOLLOW_110_in_indexing1804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_111_in_arguments1838 = new BitSet(new ulong[]{0x0000000140000000UL,0x000180000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_arguments1843 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001200000000000UL});
    public static readonly BitSet FOLLOW_109_in_arguments1846 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_arguments1849 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001200000000000UL});
    public static readonly BitSet FOLLOW_112_in_arguments1856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_106_in_block1972 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x00008A001FFDFF8CUL});
    public static readonly BitSet FOLLOW_statement_in_block1974 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x00008A001FFDFF8CUL});
    public static readonly BitSet FOLLOW_107_in_block1977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch2013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_branch2017 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_statement2035 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement2037 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_statement2039 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_Else_in_statement2049 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_statement2051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement2063 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_111_in_statement2069 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_forControl_in_statement2072 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_112_in_statement2074 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_statement2077 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement2087 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_111_in_statement2093 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_foreachControl_in_statement2096 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_112_in_statement2098 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_statement2101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_statement2111 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_111_in_statement2113 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000082001FFDFF8CUL});
    public static readonly BitSet FOLLOW_loopControl_in_statement2116 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_112_in_statement2118 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_statement2121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_statement2131 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement2133 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_statement2135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_statement2145 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_statement2147 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_While_in_statement2149 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement2151 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_statement2153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement2164 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000040000000000UL});
    public static readonly BitSet FOLLOW_block_in_statement2166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement2176 = new BitSet(new ulong[]{0x0000000140000000UL,0x000082000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_statement2178 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_statement2181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement2192 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_statement2194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Continue_in_statement2205 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_statement2207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_105_in_statement2218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement2229 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_statement2231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_statement2240 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_statement2242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl2267 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_forControl2270 = new BitSet(new ulong[]{0x0000000140000000UL,0x000082000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_forControl2273 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_forControl2276 = new BitSet(new ulong[]{0x0000000140000002UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl2279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit2299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate2318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_foreachControl2349 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_foreachControl2351 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_In_in_foreachControl2353 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_foreachControl2355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_loopControl2387 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_loopControl2389 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000000UL});
    public static readonly BitSet FOLLOW_To_in_loopControl2391 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_expression_in_loopControl2393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_synpred3_Psimulex288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred8_Psimulex507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex525 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_Assign_in_synpred9_Psimulex527 = new BitSet(new ulong[]{0x0000000140000000UL,0x000080000000FF8CUL});
    public static readonly BitSet FOLLOW_variableInitializer_in_synpred9_Psimulex529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred15_Psimulex755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred36_Psimulex1096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred64_Psimulex1563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred65_Psimulex1571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Else_in_synpred83_Psimulex2049 = new BitSet(new ulong[]{0x001FFFF940000000UL,0x000086001FFDFF8CUL});
    public static readonly BitSet FOLLOW_branch_in_synpred83_Psimulex2051 = new BitSet(new ulong[]{0x0000000000000002UL});

}
