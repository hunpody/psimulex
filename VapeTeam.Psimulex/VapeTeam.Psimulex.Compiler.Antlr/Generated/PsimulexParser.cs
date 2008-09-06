// $ANTLR 3.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-09-06 22:53:18

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
		"SIMPLE_PROGRAM", 
		"MULTY_FUNCTIONAL_PROGRAM", 
		"IMPORT_DECLARATIONS", 
		"TYPE_DECLARATIONS", 
		"STRUCTDEC", 
		"GLOBAL_VARIABLE_DECLARATIONS", 
		"MEMBERDEC", 
		"FUNCTION_DECLARATIONS", 
		"FUNCDEC", 
		"FORMAL_PARAMETER", 
		"BLOCK", 
		"VARINIT", 
		"VARDECLARE", 
		"TYPE", 
		"DATATYPE", 
		"FUNCTIONPOINTERTYPE", 
		"EXPRESSION", 
		"ASSIGNMENT", 
		"LAMBDA_EXPRESSION", 
		"DIM", 
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
		"Func", 
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
		"'.'", 
		"'=>'"
    };

    public const int RelEqual = 50;
    public const int TYPE_DECLARATIONS = 7;
    public const int VARINIT = 15;
    public const int AssignAndDivide = 46;
    public const int AssignAndMultiply = 45;
    public const int Decimal = 33;
    public const int Modulo = 60;
    public const int IDLetter = 88;
    public const int EOF = -1;
    public const int Int = 32;
    public const int Identifier = 27;
    public const int TYPE = 17;
    public const int BinTree = 37;
    public const int To = 85;
    public const int ForEach = 75;
    public const int Char = 31;
    public const int Do = 79;
    public const int RelGreaterThan = 54;
    public const int FORMAL_PARAMETER = 13;
    public const int AssignAndModulo = 47;
    public const int T__99 = 99;
    public const int T__98 = 98;
    public const int T__97 = 97;
    public const int T__96 = 96;
    public const int Bool = 30;
    public const int LogicalOr = 48;
    public const int LogicalAnd = 49;
    public const int Tree = 36;
    public const int Minus = 57;
    public const int WS = 93;
    public const int Break = 82;
    public const int GLOBAL_VARIABLE_DECLARATIONS = 9;
    public const int MULTY_FUNCTIONAL_PROGRAM = 5;
    public const int SIMPLE_PROGRAM = 4;
    public const int DATATYPE = 18;
    public const int NotNullDigit = 90;
    public const int RelLessThan = 52;
    public const int Star = 58;
    public const int Else = 72;
    public const int LAMBDA_EXPRESSION = 22;
    public const int EscapeSequence = 92;
    public const int Letter = 87;
    public const int Loop = 77;
    public const int BooleanLiteral = 67;
    public const int Stack = 40;
    public const int AssignAndAdd = 43;
    public const int RelGreaterThanOrEqual = 55;
    public const int NullLiteral = 68;
    public const int PQueue = 42;
    public const int SingleLineComment = 94;
    public const int CharacterLiteral = 66;
    public const int AssignAndSubstract = 44;
    public const int While = 78;
    public const int Func = 70;
    public const int Queue = 41;
    public const int Set = 38;
    public const int Assign = 28;
    public const int PForEach = 76;
    public const int RelNotEqual = 51;
    public const int T__103 = 103;
    public const int T__104 = 104;
    public const int T__105 = 105;
    public const int String = 34;
    public const int Return = 81;
    public const int Reference = 29;
    public const int Struct = 26;
    public const int EXPRESSION = 20;
    public const int MultiLineComment = 95;
    public const int If = 71;
    public const int FUNCTIONPOINTERTYPE = 19;
    public const int In = 84;
    public const int Import = 24;
    public const int VARDECLARE = 16;
    public const int FUNCTION_DECLARATIONS = 11;
    public const int Continue = 83;
    public const int Void = 35;
    public const int PDo = 80;
    public const int ElseIf = 86;
    public const int IMPORT_DECLARATIONS = 6;
    public const int T__102 = 102;
    public const int T__101 = 101;
    public const int T__100 = 100;
    public const int Digit = 89;
    public const int STRUCTDEC = 8;
    public const int DecimalLiteral = 65;
    public const int For = 73;
    public const int Divide = 59;
    public const int List = 39;
    public const int StringLiteral = 25;
    public const int Plus = 56;
    public const int LogicalNot = 63;
    public const int RelLessThanOrEqual = 53;
    public const int MinusMinus = 62;
    public const int DecimalTypeSuffix = 91;
    public const int PFor = 74;
    public const int BLOCK = 14;
    public const int DIM = 23;
    public const int MEMBERDEC = 10;
    public const int ASSIGNMENT = 21;
    public const int IntegerLiteral = 64;
    public const int FUNCDEC = 12;
    public const int PlusPlus = 61;
    public const int InfinityLiteral = 69;

    // delegates
    // delegators



        public PsimulexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PsimulexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
    		InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[172+1];
             
             
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:42:1: compilationUnit : ( simpleProgram | multiFunctionalProgram ) EOF ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:5: ( ( simpleProgram | multiFunctionalProgram ) EOF )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:7: ( simpleProgram | multiFunctionalProgram ) EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:7: ( simpleProgram | multiFunctionalProgram )
            	int alt1 = 2;
            	alt1 = dfa1.Predict(input);
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:9: simpleProgram
            	        {
            	        	PushFollow(FOLLOW_simpleProgram_in_compilationUnit169);
            	        	simpleProgram1 = simpleProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:25: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit173);
            	        	multiFunctionalProgram2 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit177); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:46:1: simpleProgram : ( statement )* -> ^( SIMPLE_PROGRAM ( statement )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:2: ( ( statement )* -> ^( SIMPLE_PROGRAM ( statement )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:4: ( statement )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || (LA2_0 >= Bool && LA2_0 <= PQueue) || (LA2_0 >= Plus && LA2_0 <= Minus) || (LA2_0 >= PlusPlus && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= Continue) || LA2_0 == 96 || LA2_0 == 102) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_simpleProgram192);
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
            	// 47:15: -> ^( SIMPLE_PROGRAM ( statement )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:18: ^( SIMPLE_PROGRAM ( statement )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SIMPLE_PROGRAM, "SIMPLE_PROGRAM"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:36: ( statement )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:50:1: multiFunctionalProgram : importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:51:2: ( importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations -> ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:51:4: importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations
            {
            	PushFollow(FOLLOW_importDeclarations_in_multiFunctionalProgram215);
            	importDeclarations5 = importDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_importDeclarations.Add(importDeclarations5.Tree);
            	PushFollow(FOLLOW_typeDeclarations_in_multiFunctionalProgram217);
            	typeDeclarations6 = typeDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typeDeclarations.Add(typeDeclarations6.Tree);
            	PushFollow(FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram219);
            	globalVariableDeclarations7 = globalVariableDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_globalVariableDeclarations.Add(globalVariableDeclarations7.Tree);
            	PushFollow(FOLLOW_functionDeclarations_in_multiFunctionalProgram221);
            	functionDeclarations8 = functionDeclarations();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_functionDeclarations.Add(functionDeclarations8.Tree);


            	// AST REWRITE
            	// elements:          typeDeclarations, functionDeclarations, importDeclarations, globalVariableDeclarations
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 52:3: -> ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:52:6: ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MULTY_FUNCTIONAL_PROGRAM, "MULTY_FUNCTIONAL_PROGRAM"), root_1);

            	    adaptor.AddChild(root_1, stream_importDeclarations.NextTree());
            	    adaptor.AddChild(root_1, stream_typeDeclarations.NextTree());
            	    adaptor.AddChild(root_1, stream_globalVariableDeclarations.NextTree());
            	    adaptor.AddChild(root_1, stream_functionDeclarations.NextTree());

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:55:1: globalVariableDeclarations : ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:2: ( ( memberDeclaration )* -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:4: ( memberDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:4: ( memberDeclaration )*
            	do 
            	{
            	    int alt3 = 2;
            	    switch ( input.LA(1) ) 
            	    {
            	    case Bool:
            	    case Char:
            	    case Int:
            	    case Decimal:
            	    case String:
            	    case Void:
            	    	{
            	        int LA3_1 = input.LA(2);

            	        if ( (synpred3_Psimulex()) )
            	        {
            	            alt3 = 1;
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
            	    	{
            	        int LA3_2 = input.LA(2);

            	        if ( (synpred3_Psimulex()) )
            	        {
            	            alt3 = 1;
            	        }


            	        }
            	        break;
            	    case Func:
            	    	{
            	        int LA3_3 = input.LA(2);

            	        if ( (synpred3_Psimulex()) )
            	        {
            	            alt3 = 1;
            	        }


            	        }
            	        break;

            	    }

            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclarations250);
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
            	// 56:23: -> ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:26: ^( GLOBAL_VARIABLE_DECLARATIONS ( memberDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GLOBAL_VARIABLE_DECLARATIONS, "GLOBAL_VARIABLE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:58: ( memberDeclaration )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:1: importDeclarations : ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) ;
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
        RewriteRuleTokenStream stream_96 = new RewriteRuleTokenStream(adaptor,"token 96");
        RewriteRuleTokenStream stream_Import = new RewriteRuleTokenStream(adaptor,"token Import");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:73:5: ( ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS ( StringLiteral )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:73:9: ( Import StringLiteral ';' )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:73:9: ( Import StringLiteral ';' )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:73:11: Import StringLiteral ';'
            			    {
            			    	Import10=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclarations290); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_Import.Add(Import10);

            			    	StringLiteral11=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclarations292); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_StringLiteral.Add(StringLiteral11);

            			    	char_literal12=(IToken)Match(input,96,FOLLOW_96_in_importDeclarations294); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_96.Add(char_literal12);


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
            	// 73:39: -> ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:73:42: ^( IMPORT_DECLARATIONS ( StringLiteral )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IMPORT_DECLARATIONS, "IMPORT_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:73:65: ( StringLiteral )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:76:1: typeDeclarations : ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:77:5: ( ( structDeclaration )* -> ^( TYPE_DECLARATIONS ( structDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:77:9: ( structDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:77:9: ( structDeclaration )*
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
            			    	PushFollow(FOLLOW_structDeclaration_in_typeDeclarations327);
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
            	// 77:28: -> ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:77:31: ^( TYPE_DECLARATIONS ( structDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE_DECLARATIONS, "TYPE_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:77:52: ( structDeclaration )*
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:1: structDeclaration : Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:81:5: ( Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:81:9: Struct Identifier structBody
            {
            	Struct14=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration358); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Struct.Add(Struct14);

            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration360); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Identifier.Add(Identifier15);

            	PushFollow(FOLLOW_structBody_in_structDeclaration362);
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
            	// 81:38: -> ^( STRUCTDEC Identifier structBody )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:81:41: ^( STRUCTDEC Identifier structBody )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:1: structBody : '{' ( memberDeclaration )+ '}' ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:5: ( '{' ( memberDeclaration )+ '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:9: '{' ( memberDeclaration )+ '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,97,FOLLOW_97_in_structBody392); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:14: ( memberDeclaration )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= Bool && LA6_0 <= PQueue) || LA6_0 == Func) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBody395);
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

            	char_literal19=(IToken)Match(input,98,FOLLOW_98_in_structBody398); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:88:1: memberDeclaration : typedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC typedIdentifierNonRef ( literal )? ) ;
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
        RewriteRuleTokenStream stream_96 = new RewriteRuleTokenStream(adaptor,"token 96");
        RewriteRuleTokenStream stream_Assign = new RewriteRuleTokenStream(adaptor,"token Assign");
        RewriteRuleSubtreeStream stream_typedIdentifierNonRef = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifierNonRef");
        RewriteRuleSubtreeStream stream_literal = new RewriteRuleSubtreeStream(adaptor,"rule literal");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:89:5: ( typedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC typedIdentifierNonRef ( literal )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:89:9: typedIdentifierNonRef ( Assign literal )? ';'
            {
            	PushFollow(FOLLOW_typedIdentifierNonRef_in_memberDeclaration419);
            	typedIdentifierNonRef20 = typedIdentifierNonRef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifierNonRef.Add(typedIdentifierNonRef20.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:89:31: ( Assign literal )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == Assign) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:89:33: Assign literal
            	        {
            	        	Assign21=(IToken)Match(input,Assign,FOLLOW_Assign_in_memberDeclaration423); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_Assign.Add(Assign21);

            	        	PushFollow(FOLLOW_literal_in_memberDeclaration425);
            	        	literal22 = literal();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_literal.Add(literal22.Tree);

            	        }
            	        break;

            	}

            	char_literal23=(IToken)Match(input,96,FOLLOW_96_in_memberDeclaration430); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_96.Add(char_literal23);



            	// AST REWRITE
            	// elements:          typedIdentifierNonRef, literal
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 89:55: -> ^( MEMBERDEC typedIdentifierNonRef ( literal )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:89:58: ^( MEMBERDEC typedIdentifierNonRef ( literal )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MEMBERDEC, "MEMBERDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifierNonRef.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:89:93: ( literal )?
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:92:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:5: ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) )
            int alt8 = 3;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:9: typedIdentifierNonRef
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration469);
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
                    	// 94:31: -> ^( VARDECLARE typedIdentifierNonRef )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:34: ^( VARDECLARE typedIdentifierNonRef )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:95:9: typedIdentifierNonRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration487);
                    	typedIdentifierNonRef25 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierNonRef.Add(typedIdentifierNonRef25.Tree);
                    	Assign26=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration489); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign26);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration491);
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
                    	// 95:58: -> ^( VARINIT typedIdentifierNonRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:95:61: ^( VARINIT typedIdentifierNonRef variableInitializer )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:96:4: typedIdentifierRef Assign variableInitializer
                    {
                    	PushFollow(FOLLOW_typedIdentifierRef_in_localVariableDeclaration506);
                    	typedIdentifierRef28 = typedIdentifierRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking==0 ) stream_typedIdentifierRef.Add(typedIdentifierRef28.Tree);
                    	Assign29=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration508); if (state.failed) return retval; 
                    	if ( state.backtracking==0 ) stream_Assign.Add(Assign29);

                    	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration510);
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
                    	// 96:50: -> ^( VARINIT typedIdentifierRef variableInitializer )
                    	{
                    	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:96:53: ^( VARINIT typedIdentifierRef variableInitializer )
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:1: variableInitializer : expression ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_variableInitializer543);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:1: scalarOrArrayType : type ( '[' expression ( ',' expression )* ']' )? -> ^( TYPE type ( ^( DIM expression ( expression )* ) )? ) ;
    public PsimulexParser.scalarOrArrayType_return scalarOrArrayType() // throws RecognitionException [1]
    {   
        PsimulexParser.scalarOrArrayType_return retval = new PsimulexParser.scalarOrArrayType_return();
        retval.Start = input.LT(1);
        int scalarOrArrayType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal33 = null;
        IToken char_literal35 = null;
        IToken char_literal37 = null;
        PsimulexParser.type_return type32 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression34 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression36 = default(PsimulexParser.expression_return);


        CommonTree char_literal33_tree=null;
        CommonTree char_literal35_tree=null;
        CommonTree char_literal37_tree=null;
        RewriteRuleTokenStream stream_99 = new RewriteRuleTokenStream(adaptor,"token 99");
        RewriteRuleTokenStream stream_101 = new RewriteRuleTokenStream(adaptor,"token 101");
        RewriteRuleTokenStream stream_100 = new RewriteRuleTokenStream(adaptor,"token 100");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:2: ( type ( '[' expression ( ',' expression )* ']' )? -> ^( TYPE type ( ^( DIM expression ( expression )* ) )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:4: type ( '[' expression ( ',' expression )* ']' )?
            {
            	PushFollow(FOLLOW_type_in_scalarOrArrayType563);
            	type32 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_type.Add(type32.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:9: ( '[' expression ( ',' expression )* ']' )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 99) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:11: '[' expression ( ',' expression )* ']'
            	        {
            	        	char_literal33=(IToken)Match(input,99,FOLLOW_99_in_scalarOrArrayType567); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_99.Add(char_literal33);

            	        	PushFollow(FOLLOW_expression_in_scalarOrArrayType569);
            	        	expression34 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking==0 ) stream_expression.Add(expression34.Tree);
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:26: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt9 = 2;
            	        	    int LA9_0 = input.LA(1);

            	        	    if ( (LA9_0 == 100) )
            	        	    {
            	        	        alt9 = 1;
            	        	    }


            	        	    switch (alt9) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:27: ',' expression
            	        			    {
            	        			    	char_literal35=(IToken)Match(input,100,FOLLOW_100_in_scalarOrArrayType572); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_100.Add(char_literal35);

            	        			    	PushFollow(FOLLOW_expression_in_scalarOrArrayType574);
            	        			    	expression36 = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking==0 ) stream_expression.Add(expression36.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop9;
            	        	    }
            	        	} while (true);

            	        	loop9:
            	        		;	// Stops C# compiler whining that label 'loop9' has no statements

            	        	char_literal37=(IToken)Match(input,101,FOLLOW_101_in_scalarOrArrayType578); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_101.Add(char_literal37);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          expression, expression, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 104:51: -> ^( TYPE type ( ^( DIM expression ( expression )* ) )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:54: ^( TYPE type ( ^( DIM expression ( expression )* ) )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TYPE, "TYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:67: ( ^( DIM expression ( expression )* ) )?
            	    if ( stream_expression.HasNext() || stream_expression.HasNext() )
            	    {
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:67: ^( DIM expression ( expression )* )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DIM, "DIM"), root_2);

            	        adaptor.AddChild(root_2, stream_expression.NextTree());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:85: ( expression )*
            	        while ( stream_expression.HasNext() )
            	        {
            	            adaptor.AddChild(root_2, stream_expression.NextTree());

            	        }
            	        stream_expression.Reset();

            	        adaptor.AddChild(root_1, root_2);
            	        }

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
            	Memoize(input, 12, scalarOrArrayType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "scalarOrArrayType"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:107:1: typedIdentifierNonRef : scalarOrArrayType Identifier ;
    public PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifierNonRef_return retval = new PsimulexParser.typedIdentifierNonRef_return();
        retval.Start = input.LT(1);
        int typedIdentifierNonRef_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier39 = null;
        PsimulexParser.scalarOrArrayType_return scalarOrArrayType38 = default(PsimulexParser.scalarOrArrayType_return);


        CommonTree Identifier39_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:108:2: ( scalarOrArrayType Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:108:4: scalarOrArrayType Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef619);
            	scalarOrArrayType38 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType38.Tree);
            	Identifier39=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierNonRef621); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier39_tree = (CommonTree)adaptor.Create(Identifier39);
            		adaptor.AddChild(root_0, Identifier39_tree);
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
            	Memoize(input, 13, typedIdentifierNonRef_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:111:1: typedIdentifierRef : scalarOrArrayType ( Reference )? Identifier ;
    public PsimulexParser.typedIdentifierRef_return typedIdentifierRef() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifierRef_return retval = new PsimulexParser.typedIdentifierRef_return();
        retval.Start = input.LT(1);
        int typedIdentifierRef_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference41 = null;
        IToken Identifier42 = null;
        PsimulexParser.scalarOrArrayType_return scalarOrArrayType40 = default(PsimulexParser.scalarOrArrayType_return);


        CommonTree Reference41_tree=null;
        CommonTree Identifier42_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:2: ( scalarOrArrayType ( Reference )? Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:4: scalarOrArrayType ( Reference )? Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_scalarOrArrayType_in_typedIdentifierRef633);
            	scalarOrArrayType40 = scalarOrArrayType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, scalarOrArrayType40.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:22: ( Reference )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == Reference) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: Reference
            	        {
            	        	Reference41=(IToken)Match(input,Reference,FOLLOW_Reference_in_typedIdentifierRef635); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Reference41_tree = (CommonTree)adaptor.Create(Reference41);
            	        		adaptor.AddChild(root_0, Reference41_tree);
            	        	}

            	        }
            	        break;

            	}

            	Identifier42=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierRef638); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier42_tree = (CommonTree)adaptor.Create(Identifier42);
            		adaptor.AddChild(root_0, Identifier42_tree);
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
            	Memoize(input, 14, typedIdentifierRef_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:115:1: typedIdentifier : ( typedIdentifierNonRef | typedIdentifierRef );
    public PsimulexParser.typedIdentifier_return typedIdentifier() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifier_return retval = new PsimulexParser.typedIdentifier_return();
        retval.Start = input.LT(1);
        int typedIdentifier_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.typedIdentifierNonRef_return typedIdentifierNonRef43 = default(PsimulexParser.typedIdentifierNonRef_return);

        PsimulexParser.typedIdentifierRef_return typedIdentifierRef44 = default(PsimulexParser.typedIdentifierRef_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:116:2: ( typedIdentifierNonRef | typedIdentifierRef )
            int alt12 = 2;
            switch ( input.LA(1) ) 
            {
            case Bool:
            case Char:
            case Int:
            case Decimal:
            case String:
            case Void:
            	{
                int LA12_1 = input.LA(2);

                if ( (synpred13_Psimulex()) )
                {
                    alt12 = 1;
                }
                else if ( (true) )
                {
                    alt12 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d12s1 =
                        new NoViableAltException("", 12, 1, input);

                    throw nvae_d12s1;
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
            	{
                int LA12_2 = input.LA(2);

                if ( (synpred13_Psimulex()) )
                {
                    alt12 = 1;
                }
                else if ( (true) )
                {
                    alt12 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d12s2 =
                        new NoViableAltException("", 12, 2, input);

                    throw nvae_d12s2;
                }
                }
                break;
            case Func:
            	{
                int LA12_3 = input.LA(2);

                if ( (synpred13_Psimulex()) )
                {
                    alt12 = 1;
                }
                else if ( (true) )
                {
                    alt12 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d12s3 =
                        new NoViableAltException("", 12, 3, input);

                    throw nvae_d12s3;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("", 12, 0, input);

            	    throw nvae_d12s0;
            }

            switch (alt12) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:116:4: typedIdentifierNonRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierNonRef_in_typedIdentifier651);
                    	typedIdentifierNonRef43 = typedIdentifierNonRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierNonRef43.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:116:28: typedIdentifierRef
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_typedIdentifierRef_in_typedIdentifier655);
                    	typedIdentifierRef44 = typedIdentifierRef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierRef44.Tree);

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
            	Memoize(input, 15, typedIdentifier_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:119:1: functionDeclarations : ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) ;
    public PsimulexParser.functionDeclarations_return functionDeclarations() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclarations_return retval = new PsimulexParser.functionDeclarations_return();
        retval.Start = input.LT(1);
        int functionDeclarations_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.functionDeclaration_return functionDeclaration45 = default(PsimulexParser.functionDeclaration_return);


        RewriteRuleSubtreeStream stream_functionDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule functionDeclaration");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:120:5: ( ( functionDeclaration )* -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:120:7: ( functionDeclaration )*
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:120:7: ( functionDeclaration )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= Bool && LA13_0 <= PQueue) || LA13_0 == Func) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: functionDeclaration
            			    {
            			    	PushFollow(FOLLOW_functionDeclaration_in_functionDeclarations672);
            			    	functionDeclaration45 = functionDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_functionDeclaration.Add(functionDeclaration45.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements



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
            	// 120:28: -> ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:120:31: ^( FUNCTION_DECLARATIONS ( functionDeclaration )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION_DECLARATIONS, "FUNCTION_DECLARATIONS"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:120:56: ( functionDeclaration )*
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
            	Memoize(input, 16, functionDeclarations_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:1: functionDeclaration : typedIdentifier formalParameters block -> ^( FUNCDEC typedIdentifier formalParameters block ) ;
    public PsimulexParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclaration_return retval = new PsimulexParser.functionDeclaration_return();
        retval.Start = input.LT(1);
        int functionDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.typedIdentifier_return typedIdentifier46 = default(PsimulexParser.typedIdentifier_return);

        PsimulexParser.formalParameters_return formalParameters47 = default(PsimulexParser.formalParameters_return);

        PsimulexParser.block_return block48 = default(PsimulexParser.block_return);


        RewriteRuleSubtreeStream stream_typedIdentifier = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifier");
        RewriteRuleSubtreeStream stream_formalParameters = new RewriteRuleSubtreeStream(adaptor,"rule formalParameters");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:5: ( typedIdentifier formalParameters block -> ^( FUNCDEC typedIdentifier formalParameters block ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:7: typedIdentifier formalParameters block
            {
            	PushFollow(FOLLOW_typedIdentifier_in_functionDeclaration705);
            	typedIdentifier46 = typedIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier46.Tree);
            	PushFollow(FOLLOW_formalParameters_in_functionDeclaration707);
            	formalParameters47 = formalParameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_formalParameters.Add(formalParameters47.Tree);
            	PushFollow(FOLLOW_block_in_functionDeclaration709);
            	block48 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_block.Add(block48.Tree);


            	// AST REWRITE
            	// elements:          block, typedIdentifier, formalParameters
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 124:46: -> ^( FUNCDEC typedIdentifier formalParameters block )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:49: ^( FUNCDEC typedIdentifier formalParameters block )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCDEC, "FUNCDEC"), root_1);

            	    adaptor.AddChild(root_1, stream_typedIdentifier.NextTree());
            	    adaptor.AddChild(root_1, stream_formalParameters.NextTree());
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
            	Memoize(input, 17, functionDeclaration_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:1: formalParameters : '(' formalParameter ( ',' formalParameter )* ')' ;
    public PsimulexParser.formalParameters_return formalParameters() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameters_return retval = new PsimulexParser.formalParameters_return();
        retval.Start = input.LT(1);
        int formalParameters_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal49 = null;
        IToken char_literal51 = null;
        IToken char_literal53 = null;
        PsimulexParser.formalParameter_return formalParameter50 = default(PsimulexParser.formalParameter_return);

        PsimulexParser.formalParameter_return formalParameter52 = default(PsimulexParser.formalParameter_return);


        CommonTree char_literal49_tree=null;
        CommonTree char_literal51_tree=null;
        CommonTree char_literal53_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:5: ( '(' formalParameter ( ',' formalParameter )* ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:9: '(' formalParameter ( ',' formalParameter )* ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal49=(IToken)Match(input,102,FOLLOW_102_in_formalParameters742); if (state.failed) return retval;
            	PushFollow(FOLLOW_formalParameter_in_formalParameters745);
            	formalParameter50 = formalParameter();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameter50.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:30: ( ',' formalParameter )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 100) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:31: ',' formalParameter
            			    {
            			    	char_literal51=(IToken)Match(input,100,FOLLOW_100_in_formalParameters748); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_formalParameter_in_formalParameters751);
            			    	formalParameter52 = formalParameter();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameter52.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	char_literal53=(IToken)Match(input,103,FOLLOW_103_in_formalParameters755); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, formalParameters_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameters"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:1: formalParameter : typedIdentifier -> ^( FORMAL_PARAMETER typedIdentifier ) ;
    public PsimulexParser.formalParameter_return formalParameter() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameter_return retval = new PsimulexParser.formalParameter_return();
        retval.Start = input.LT(1);
        int formalParameter_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.typedIdentifier_return typedIdentifier54 = default(PsimulexParser.typedIdentifier_return);


        RewriteRuleSubtreeStream stream_typedIdentifier = new RewriteRuleSubtreeStream(adaptor,"rule typedIdentifier");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:2: ( typedIdentifier -> ^( FORMAL_PARAMETER typedIdentifier ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:4: typedIdentifier
            {
            	PushFollow(FOLLOW_typedIdentifier_in_formalParameter774);
            	typedIdentifier54 = typedIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_typedIdentifier.Add(typedIdentifier54.Tree);


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
            	// 132:20: -> ^( FORMAL_PARAMETER typedIdentifier )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:23: ^( FORMAL_PARAMETER typedIdentifier )
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
            	Memoize(input, 19, formalParameter_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:139:1: type : ( dataType | functionPointerType );
    public PsimulexParser.type_return type() // throws RecognitionException [1]
    {   
        PsimulexParser.type_return retval = new PsimulexParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataType_return dataType55 = default(PsimulexParser.dataType_return);

        PsimulexParser.functionPointerType_return functionPointerType56 = default(PsimulexParser.functionPointerType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:140:5: ( dataType | functionPointerType )
            int alt15 = 2;
            int LA15_0 = input.LA(1);

            if ( ((LA15_0 >= Bool && LA15_0 <= PQueue)) )
            {
                alt15 = 1;
            }
            else if ( (LA15_0 == Func) )
            {
                alt15 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("", 15, 0, input);

                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:140:7: dataType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dataType_in_type806);
                    	dataType55 = dataType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType55.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:140:18: functionPointerType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionPointerType_in_type810);
                    	functionPointerType56 = functionPointerType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionPointerType56.Tree);

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
            	Memoize(input, 20, type_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:1: dataType : dataTypeName -> ^( DATATYPE dataTypeName ) ;
    public PsimulexParser.dataType_return dataType() // throws RecognitionException [1]
    {   
        PsimulexParser.dataType_return retval = new PsimulexParser.dataType_return();
        retval.Start = input.LT(1);
        int dataType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataTypeName_return dataTypeName57 = default(PsimulexParser.dataTypeName_return);


        RewriteRuleSubtreeStream stream_dataTypeName = new RewriteRuleSubtreeStream(adaptor,"rule dataTypeName");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:2: ( dataTypeName -> ^( DATATYPE dataTypeName ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:4: dataTypeName
            {
            	PushFollow(FOLLOW_dataTypeName_in_dataType824);
            	dataTypeName57 = dataTypeName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataTypeName.Add(dataTypeName57.Tree);


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
            	// 144:17: -> ^( DATATYPE dataTypeName )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:20: ^( DATATYPE dataTypeName )
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
            	Memoize(input, 21, dataType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:147:1: dataTypeName : ( primitiveType | builtInType );
    public PsimulexParser.dataTypeName_return dataTypeName() // throws RecognitionException [1]
    {   
        PsimulexParser.dataTypeName_return retval = new PsimulexParser.dataTypeName_return();
        retval.Start = input.LT(1);
        int dataTypeName_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primitiveType_return primitiveType58 = default(PsimulexParser.primitiveType_return);

        PsimulexParser.builtInType_return builtInType59 = default(PsimulexParser.builtInType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:2: ( primitiveType | builtInType )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( ((LA16_0 >= Bool && LA16_0 <= Void)) )
            {
                alt16 = 1;
            }
            else if ( ((LA16_0 >= Tree && LA16_0 <= PQueue)) )
            {
                alt16 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:4: primitiveType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primitiveType_in_dataTypeName845);
                    	primitiveType58 = primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType58.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:20: builtInType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtInType_in_dataTypeName849);
                    	builtInType59 = builtInType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType59.Tree);

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
            	Memoize(input, 22, dataTypeName_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:151:1: primitiveType : ( Bool | Char | Int | Decimal | String | Void );
    public PsimulexParser.primitiveType_return primitiveType() // throws RecognitionException [1]
    {   
        PsimulexParser.primitiveType_return retval = new PsimulexParser.primitiveType_return();
        retval.Start = input.LT(1);
        int primitiveType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set60 = null;

        CommonTree set60_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:152:5: ( Bool | Char | Int | Decimal | String | Void )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set60 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Bool && input.LA(1) <= Void) ) 
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
            	Memoize(input, 23, primitiveType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:1: builtInType : ( Tree | BinTree | Set | List | Stack | Queue | PQueue );
    public PsimulexParser.builtInType_return builtInType() // throws RecognitionException [1]
    {   
        PsimulexParser.builtInType_return retval = new PsimulexParser.builtInType_return();
        retval.Start = input.LT(1);
        int builtInType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set61 = null;

        CommonTree set61_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:5: ( Tree | BinTree | Set | List | Stack | Queue | PQueue )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set61 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= PQueue) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set61));
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
            	Memoize(input, 24, builtInType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:180:1: expression : ( assignment | conditionalOrExpression | lambdaExpression );
    public PsimulexParser.expression_return expression() // throws RecognitionException [1]
    {   
        PsimulexParser.expression_return retval = new PsimulexParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.assignment_return assignment62 = default(PsimulexParser.assignment_return);

        PsimulexParser.conditionalOrExpression_return conditionalOrExpression63 = default(PsimulexParser.conditionalOrExpression_return);

        PsimulexParser.lambdaExpression_return lambdaExpression64 = default(PsimulexParser.lambdaExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:2: ( assignment | conditionalOrExpression | lambdaExpression )
            int alt17 = 3;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                int LA17_1 = input.LA(2);

                if ( (synpred29_Psimulex()) )
                {
                    alt17 = 1;
                }
                else if ( (synpred30_Psimulex()) )
                {
                    alt17 = 2;
                }
                else if ( (true) )
                {
                    alt17 = 3;
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
            case 102:
            	{
                int LA17_2 = input.LA(2);

                if ( (synpred29_Psimulex()) )
                {
                    alt17 = 1;
                }
                else if ( (synpred30_Psimulex()) )
                {
                    alt17 = 2;
                }
                else if ( (true) )
                {
                    alt17 = 3;
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
                alt17 = 2;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expression977);
                    	assignment62 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment62.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:17: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_expression981);
                    	conditionalOrExpression63 = conditionalOrExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression63.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:43: lambdaExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lambdaExpression_in_expression985);
                    	lambdaExpression64 = lambdaExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaExpression64.Tree);

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
            	Memoize(input, 25, expression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expression"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:184:1: assignment : leftValue assignmentOperator expression -> ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) ) ;
    public PsimulexParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        PsimulexParser.assignment_return retval = new PsimulexParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue65 = default(PsimulexParser.leftValue_return);

        PsimulexParser.assignmentOperator_return assignmentOperator66 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.expression_return expression67 = default(PsimulexParser.expression_return);


        RewriteRuleSubtreeStream stream_assignmentOperator = new RewriteRuleSubtreeStream(adaptor,"rule assignmentOperator");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_leftValue = new RewriteRuleSubtreeStream(adaptor,"rule leftValue");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:2: ( leftValue assignmentOperator expression -> ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:4: leftValue assignmentOperator expression
            {
            	PushFollow(FOLLOW_leftValue_in_assignment997);
            	leftValue65 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_leftValue.Add(leftValue65.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment999);
            	assignmentOperator66 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_assignmentOperator.Add(assignmentOperator66.Tree);
            	PushFollow(FOLLOW_expression_in_assignment1001);
            	expression67 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_expression.Add(expression67.Tree);


            	// AST REWRITE
            	// elements:          leftValue, assignmentOperator, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 185:44: -> ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:47: ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ASSIGNMENT, "ASSIGNMENT"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:61: ^( assignmentOperator leftValue expression )
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
            	Memoize(input, 26, assignment_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:188:1: assignmentOperator : ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo );
    public PsimulexParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        PsimulexParser.assignmentOperator_return retval = new PsimulexParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set68 = null;

        CommonTree set68_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:2: ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set68 = (IToken)input.LT(1);
            	if ( input.LA(1) == Assign || (input.LA(1) >= AssignAndAdd && input.LA(1) <= AssignAndModulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set68));
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
            	Memoize(input, 27, assignmentOperator_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:192:1: conditionalOrExpression : conditionalAndExpression ( LogicalOr conditionalAndExpression )* -> ^( EXPRESSION conditionalAndExpression ( ^( LogicalOr ) conditionalAndExpression )* ) ;
    public PsimulexParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalOrExpression_return retval = new PsimulexParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalOr70 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression69 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression71 = default(PsimulexParser.conditionalAndExpression_return);


        CommonTree LogicalOr70_tree=null;
        RewriteRuleTokenStream stream_LogicalOr = new RewriteRuleTokenStream(adaptor,"token LogicalOr");
        RewriteRuleSubtreeStream stream_conditionalAndExpression = new RewriteRuleSubtreeStream(adaptor,"rule conditionalAndExpression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:5: ( conditionalAndExpression ( LogicalOr conditionalAndExpression )* -> ^( EXPRESSION conditionalAndExpression ( ^( LogicalOr ) conditionalAndExpression )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:9: conditionalAndExpression ( LogicalOr conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1060);
            	conditionalAndExpression69 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_conditionalAndExpression.Add(conditionalAndExpression69.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:34: ( LogicalOr conditionalAndExpression )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == LogicalOr) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:36: LogicalOr conditionalAndExpression
            			    {
            			    	LogicalOr70=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression1064); if (state.failed) return retval; 
            			    	if ( state.backtracking==0 ) stream_LogicalOr.Add(LogicalOr70);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1066);
            			    	conditionalAndExpression71 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking==0 ) stream_conditionalAndExpression.Add(conditionalAndExpression71.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements



            	// AST REWRITE
            	// elements:          conditionalAndExpression, LogicalOr, conditionalAndExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 193:74: -> ^( EXPRESSION conditionalAndExpression ( ^( LogicalOr ) conditionalAndExpression )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:77: ^( EXPRESSION conditionalAndExpression ( ^( LogicalOr ) conditionalAndExpression )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPRESSION, "EXPRESSION"), root_1);

            	    adaptor.AddChild(root_1, stream_conditionalAndExpression.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:116: ( ^( LogicalOr ) conditionalAndExpression )*
            	    while ( stream_LogicalOr.HasNext() || stream_conditionalAndExpression.HasNext() )
            	    {
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:118: ^( LogicalOr )
            	        {
            	        CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	        root_2 = (CommonTree)adaptor.BecomeRoot(stream_LogicalOr.NextNode(), root_2);

            	        adaptor.AddChild(root_1, root_2);
            	        }
            	        adaptor.AddChild(root_1, stream_conditionalAndExpression.NextTree());

            	    }
            	    stream_LogicalOr.Reset();
            	    stream_conditionalAndExpression.Reset();

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
            	Memoize(input, 28, conditionalOrExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:1: conditionalAndExpression : equalityExpression ( LogicalAnd equalityExpression )* ;
    public PsimulexParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalAndExpression_return retval = new PsimulexParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalAnd73 = null;
        PsimulexParser.equalityExpression_return equalityExpression72 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression74 = default(PsimulexParser.equalityExpression_return);


        CommonTree LogicalAnd73_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:5: ( equalityExpression ( LogicalAnd equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:9: equalityExpression ( LogicalAnd equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1111);
            	equalityExpression72 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression72.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:28: ( LogicalAnd equalityExpression )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == LogicalAnd) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:30: LogicalAnd equalityExpression
            			    {
            			    	LogicalAnd73=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression1115); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd73_tree = (CommonTree)adaptor.Create(LogicalAnd73);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd73_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1118);
            			    	equalityExpression74 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression74.Tree);

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
            	Memoize(input, 29, conditionalAndExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:200:1: equalityExpression : relationalExpression ( ( equalityOp ) relationalExpression )* ;
    public PsimulexParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityExpression_return retval = new PsimulexParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.relationalExpression_return relationalExpression75 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.equalityOp_return equalityOp76 = default(PsimulexParser.equalityOp_return);

        PsimulexParser.relationalExpression_return relationalExpression77 = default(PsimulexParser.relationalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:5: ( relationalExpression ( ( equalityOp ) relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:9: relationalExpression ( ( equalityOp ) relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1140);
            	relationalExpression75 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression75.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:30: ( ( equalityOp ) relationalExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= RelEqual && LA20_0 <= RelNotEqual)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:32: ( equalityOp ) relationalExpression
            			    {
            			    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:32: ( equalityOp )
            			    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:34: equalityOp
            			    	{
            			    		PushFollow(FOLLOW_equalityOp_in_equalityExpression1146);
            			    		equalityOp76 = equalityOp();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp76.Tree, root_0);

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1151);
            			    	relationalExpression77 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression77.Tree);

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
            	Memoize(input, 30, equalityExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:204:1: equalityOp : ( RelEqual | RelNotEqual );
    public PsimulexParser.equalityOp_return equalityOp() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityOp_return retval = new PsimulexParser.equalityOp_return();
        retval.Start = input.LT(1);
        int equalityOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set78 = null;

        CommonTree set78_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:205:2: ( RelEqual | RelNotEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set78 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelEqual && input.LA(1) <= RelNotEqual) ) 
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
            	Memoize(input, 31, equalityOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:208:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
    public PsimulexParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalExpression_return retval = new PsimulexParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.additiveExpression_return additiveExpression79 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp80 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression81 = default(PsimulexParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1186);
            	additiveExpression79 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression79.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:28: ( relationalOp additiveExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( ((LA21_0 >= RelLessThan && LA21_0 <= RelGreaterThanOrEqual)) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression1190);
            			    	relationalOp80 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp80.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1193);
            			    	additiveExpression81 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression81.Tree);

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
            	Memoize(input, 32, relationalExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:212:1: relationalOp : ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual );
    public PsimulexParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalOp_return retval = new PsimulexParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set82 = null;

        CommonTree set82_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:5: ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set82 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelLessThan && input.LA(1) <= RelGreaterThanOrEqual) ) 
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
            	Memoize(input, 33, relationalOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:216:1: additiveExpression : multiplicativeExpression ( additiveOp multiplicativeExpression )* ;
    public PsimulexParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveExpression_return retval = new PsimulexParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression83 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.additiveOp_return additiveOp84 = default(PsimulexParser.additiveOp_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression85 = default(PsimulexParser.multiplicativeExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:5: ( multiplicativeExpression ( additiveOp multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:9: multiplicativeExpression ( additiveOp multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1247);
            	multiplicativeExpression83 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression83.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:34: ( additiveOp multiplicativeExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( ((LA22_0 >= Plus && LA22_0 <= Minus)) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:36: additiveOp multiplicativeExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression1251);
            			    	additiveOp84 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp84.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1254);
            			    	multiplicativeExpression85 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression85.Tree);

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
            	Memoize(input, 34, additiveExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:220:1: additiveOp : ( Plus | Minus );
    public PsimulexParser.additiveOp_return additiveOp() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveOp_return retval = new PsimulexParser.additiveOp_return();
        retval.Start = input.LT(1);
        int additiveOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set86 = null;

        CommonTree set86_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:2: ( Plus | Minus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set86 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) ) 
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
            	Memoize(input, 35, additiveOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:224:1: multiplicativeExpression : unaryExpression ( multiplicativeOp unaryExpression )* ;
    public PsimulexParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeExpression_return retval = new PsimulexParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryExpression_return unaryExpression87 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.multiplicativeOp_return multiplicativeOp88 = default(PsimulexParser.multiplicativeOp_return);

        PsimulexParser.unaryExpression_return unaryExpression89 = default(PsimulexParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:5: ( unaryExpression ( multiplicativeOp unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:9: unaryExpression ( multiplicativeOp unaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1289);
            	unaryExpression87 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression87.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:25: ( multiplicativeOp unaryExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( ((LA23_0 >= Star && LA23_0 <= Modulo)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:27: multiplicativeOp unaryExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression1293);
            			    	multiplicativeOp88 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp88.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1296);
            			    	unaryExpression89 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression89.Tree);

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
            	Memoize(input, 36, multiplicativeExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:1: multiplicativeOp : ( Star | Divide | Modulo );
    public PsimulexParser.multiplicativeOp_return multiplicativeOp() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeOp_return retval = new PsimulexParser.multiplicativeOp_return();
        retval.Start = input.LT(1);
        int multiplicativeOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set90 = null;

        CommonTree set90_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:2: ( Star | Divide | Modulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set90 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Star && input.LA(1) <= Modulo) ) 
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
            	Memoize(input, 37, multiplicativeOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:232:1: unaryExpression : ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? | castExpression );
    public PsimulexParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpression_return retval = new PsimulexParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixOp_return unaryPrefixOp91 = default(PsimulexParser.unaryPrefixOp_return);

        PsimulexParser.unaryExpression_return unaryExpression92 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.primaryExpression_return primaryExpression93 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp94 = default(PsimulexParser.unaryPostfixOp_return);

        PsimulexParser.castExpression_return castExpression95 = default(PsimulexParser.castExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:5: ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? | castExpression )
            int alt25 = 3;
            switch ( input.LA(1) ) 
            {
            case Plus:
            case Minus:
            case PlusPlus:
            case MinusMinus:
            case LogicalNot:
            	{
                alt25 = 1;
                }
                break;
            case 102:
            	{
                int LA25_2 = input.LA(2);

                if ( (LA25_2 == StringLiteral || LA25_2 == Identifier || (LA25_2 >= Plus && LA25_2 <= Minus) || (LA25_2 >= PlusPlus && LA25_2 <= InfinityLiteral) || LA25_2 == 102) )
                {
                    alt25 = 2;
                }
                else if ( ((LA25_2 >= Bool && LA25_2 <= PQueue)) )
                {
                    alt25 = 3;
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
            case StringLiteral:
            case Identifier:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:7: unaryPrefixOp unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPrefixOp_in_unaryExpression1331);
                    	unaryPrefixOp91 = unaryPrefixOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPrefixOp91.Tree, root_0);
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1334);
                    	unaryExpression92 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression92.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:7: primaryExpression ( unaryPostfixOp )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression1342);
                    	primaryExpression93 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression93.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:25: ( unaryPostfixOp )?
                    	int alt24 = 2;
                    	int LA24_0 = input.LA(1);

                    	if ( ((LA24_0 >= PlusPlus && LA24_0 <= MinusMinus)) )
                    	{
                    	    alt24 = 1;
                    	}
                    	switch (alt24) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:26: unaryPostfixOp
                    	        {
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpression1345);
                    	        	unaryPostfixOp94 = unaryPostfixOp();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp94.Tree, root_0);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:235:4: castExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpression1353);
                    	castExpression95 = castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, castExpression95.Tree);

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
            	Memoize(input, 38, unaryExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:238:1: castExpression : '(' dataType ')' unaryExpression ;
    public PsimulexParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.castExpression_return retval = new PsimulexParser.castExpression_return();
        retval.Start = input.LT(1);
        int castExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal96 = null;
        IToken char_literal98 = null;
        PsimulexParser.dataType_return dataType97 = default(PsimulexParser.dataType_return);

        PsimulexParser.unaryExpression_return unaryExpression99 = default(PsimulexParser.unaryExpression_return);


        CommonTree char_literal96_tree=null;
        CommonTree char_literal98_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:239:2: ( '(' dataType ')' unaryExpression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:239:4: '(' dataType ')' unaryExpression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal96=(IToken)Match(input,102,FOLLOW_102_in_castExpression1372); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal96_tree = (CommonTree)adaptor.Create(char_literal96);
            		adaptor.AddChild(root_0, char_literal96_tree);
            	}
            	PushFollow(FOLLOW_dataType_in_castExpression1374);
            	dataType97 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType97.Tree);
            	char_literal98=(IToken)Match(input,103,FOLLOW_103_in_castExpression1376); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal98_tree = (CommonTree)adaptor.Create(char_literal98);
            		adaptor.AddChild(root_0, char_literal98_tree);
            	}
            	PushFollow(FOLLOW_unaryExpression_in_castExpression1378);
            	unaryExpression99 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression99.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:242:1: unaryPrefixOp : ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot );
    public PsimulexParser.unaryPrefixOp_return unaryPrefixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixOp_return retval = new PsimulexParser.unaryPrefixOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set100 = null;

        CommonTree set100_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:243:2: ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set100 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) || (input.LA(1) >= PlusPlus && input.LA(1) <= LogicalNot) ) 
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
            	Memoize(input, 40, unaryPrefixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:246:1: unaryPostfixOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPostfixOp_return unaryPostfixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixOp_return retval = new PsimulexParser.unaryPostfixOp_return();
        retval.Start = input.LT(1);
        int unaryPostfixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set101 = null;

        CommonTree set101_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:247:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set101 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set101));
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
            	Memoize(input, 41, unaryPostfixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:250:1: unaryExpressionPostPlusPlusMinusMinus : primaryExpression ( unaryPostfixOp )* ;
    public PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return unaryExpressionPostPlusPlusMinusMinus() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return retval = new PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return();
        retval.Start = input.LT(1);
        int unaryExpressionPostPlusPlusMinusMinus_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primaryExpression_return primaryExpression102 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp103 = default(PsimulexParser.unaryPostfixOp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:251:5: ( primaryExpression ( unaryPostfixOp )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:251:9: primaryExpression ( unaryPostfixOp )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1427);
            	primaryExpression102 = primaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression102.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:251:27: ( unaryPostfixOp )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= PlusPlus && LA26_0 <= MinusMinus)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:251:28: unaryPostfixOp
            			    {
            			    	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1430);
            			    	unaryPostfixOp103 = unaryPostfixOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp103.Tree, root_0);

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
            	Memoize(input, 42, unaryExpressionPostPlusPlusMinusMinus_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:254:1: primaryExpression : ( parExpression | leftValue | literal | functionCall );
    public PsimulexParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.primaryExpression_return retval = new PsimulexParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression104 = default(PsimulexParser.parExpression_return);

        PsimulexParser.leftValue_return leftValue105 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal106 = default(PsimulexParser.literal_return);

        PsimulexParser.functionCall_return functionCall107 = default(PsimulexParser.functionCall_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:255:5: ( parExpression | leftValue | literal | functionCall )
            int alt27 = 4;
            switch ( input.LA(1) ) 
            {
            case 102:
            	{
                int LA27_1 = input.LA(2);

                if ( (synpred58_Psimulex()) )
                {
                    alt27 = 1;
                }
                else if ( (synpred59_Psimulex()) )
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
            case Identifier:
            	{
                int LA27_2 = input.LA(2);

                if ( (synpred59_Psimulex()) )
                {
                    alt27 = 2;
                }
                else if ( (true) )
                {
                    alt27 = 4;
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
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            }

            switch (alt27) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:255:9: parExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1452);
                    	parExpression104 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression104.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:256:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1460);
                    	leftValue105 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue105.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:257:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1470);
                    	literal106 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal106.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:258:7: functionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionCall_in_primaryExpression1478);
                    	functionCall107 = functionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall107.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:261:1: parExpression : '(' expression ')' ;
    public PsimulexParser.parExpression_return parExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.parExpression_return retval = new PsimulexParser.parExpression_return();
        retval.Start = input.LT(1);
        int parExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal108 = null;
        IToken char_literal110 = null;
        PsimulexParser.expression_return expression109 = default(PsimulexParser.expression_return);


        CommonTree char_literal108_tree=null;
        CommonTree char_literal110_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:262:5: ( '(' expression ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:262:9: '(' expression ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal108=(IToken)Match(input,102,FOLLOW_102_in_parExpression1497); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1500);
            	expression109 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression109.Tree);
            	char_literal110=(IToken)Match(input,103,FOLLOW_103_in_parExpression1502); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:265:1: leftValue : ( variable | selecting );
    public PsimulexParser.leftValue_return leftValue() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValue_return retval = new PsimulexParser.leftValue_return();
        retval.Start = input.LT(1);
        int leftValue_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.variable_return variable111 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting112 = default(PsimulexParser.selecting_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:2: ( variable | selecting )
            int alt28 = 2;
            int LA28_0 = input.LA(1);

            if ( (LA28_0 == Identifier) )
            {
                int LA28_1 = input.LA(2);

                if ( (LA28_1 == EOF || LA28_1 == Assign || (LA28_1 >= AssignAndAdd && LA28_1 <= MinusMinus) || LA28_1 == 96 || (LA28_1 >= 100 && LA28_1 <= 101) || LA28_1 == 103) )
                {
                    alt28 = 1;
                }
                else if ( (LA28_1 == 99 || LA28_1 == 104) )
                {
                    alt28 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d28s1 =
                        new NoViableAltException("", 28, 1, input);

                    throw nvae_d28s1;
                }
            }
            else if ( (LA28_0 == 102) )
            {
                alt28 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d28s0 =
                    new NoViableAltException("", 28, 0, input);

                throw nvae_d28s0;
            }
            switch (alt28) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1517);
                    	variable111 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable111.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:267:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1522);
                    	selecting112 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting112.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:1: variable : Identifier ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier113 = null;

        CommonTree Identifier113_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:271:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:271:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier113=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1533); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier113_tree = (CommonTree)adaptor.Create(Identifier113);
            		adaptor.AddChild(root_0, Identifier113_tree);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:274:1: selecting : ( Identifier | parExpression ) ( selector )+ ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier114 = null;
        PsimulexParser.parExpression_return parExpression115 = default(PsimulexParser.parExpression_return);

        PsimulexParser.selector_return selector116 = default(PsimulexParser.selector_return);


        CommonTree Identifier114_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:2: ( ( Identifier | parExpression ) ( selector )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:4: ( Identifier | parExpression ) ( selector )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:4: ( Identifier | parExpression )
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == Identifier) )
            	{
            	    alt29 = 1;
            	}
            	else if ( (LA29_0 == 102) )
            	{
            	    alt29 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d29s0 =
            	        new NoViableAltException("", 29, 0, input);

            	    throw nvae_d29s0;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:5: Identifier
            	        {
            	        	Identifier114=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selecting1545); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier114_tree = (CommonTree)adaptor.Create(Identifier114);
            	        		adaptor.AddChild(root_0, Identifier114_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:16: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selecting1547);
            	        	parExpression115 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression115.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:31: ( selector )+
            	int cnt30 = 0;
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == 99 || LA30_0 == 104) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: selector
            			    {
            			    	PushFollow(FOLLOW_selector_in_selecting1550);
            			    	selector116 = selector();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selector116.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt30 >= 1 ) goto loop30;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(30, input);
            		            throw eee;
            	    }
            	    cnt30++;
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whinging that label 'loop30' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:278:1: selector : ( memberSelect | memberFunctionCall | indexing );
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberSelect_return memberSelect117 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall118 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing119 = default(PsimulexParser.indexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:279:5: ( memberSelect | memberFunctionCall | indexing )
            int alt31 = 3;
            int LA31_0 = input.LA(1);

            if ( (LA31_0 == 104) )
            {
                int LA31_1 = input.LA(2);

                if ( (LA31_1 == Identifier) )
                {
                    int LA31_3 = input.LA(3);

                    if ( (LA31_3 == EOF || LA31_3 == Assign || (LA31_3 >= AssignAndAdd && LA31_3 <= MinusMinus) || LA31_3 == 96 || (LA31_3 >= 99 && LA31_3 <= 101) || (LA31_3 >= 103 && LA31_3 <= 104)) )
                    {
                        alt31 = 1;
                    }
                    else if ( (LA31_3 == 102) )
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
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d31s1 =
                        new NoViableAltException("", 31, 1, input);

                    throw nvae_d31s1;
                }
            }
            else if ( (LA31_0 == 99) )
            {
                alt31 = 3;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:279:9: memberSelect
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberSelect_in_selector1567);
                    	memberSelect117 = memberSelect();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect117.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:280:9: memberFunctionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberFunctionCall_in_selector1577);
                    	memberFunctionCall118 = memberFunctionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall118.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:281:9: indexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_indexing_in_selector1587);
                    	indexing119 = indexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing119.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:284:1: memberSelect : '.' Identifier ;
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

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:285:2: ( '.' Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:285:4: '.' Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal120=(IToken)Match(input,104,FOLLOW_104_in_memberSelect1601); if (state.failed) return retval;
            	Identifier121=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect1604); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier121_tree = (CommonTree)adaptor.Create(Identifier121);
            		adaptor.AddChild(root_0, Identifier121_tree);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:288:1: memberFunctionCall : '.' functionCall ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal122 = null;
        PsimulexParser.functionCall_return functionCall123 = default(PsimulexParser.functionCall_return);


        CommonTree char_literal122_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:2: ( '.' functionCall )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:4: '.' functionCall
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal122=(IToken)Match(input,104,FOLLOW_104_in_memberFunctionCall1615); if (state.failed) return retval;
            	PushFollow(FOLLOW_functionCall_in_memberFunctionCall1618);
            	functionCall123 = functionCall();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionCall123.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:292:1: functionCall : Identifier arguments ;
    public PsimulexParser.functionCall_return functionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.functionCall_return retval = new PsimulexParser.functionCall_return();
        retval.Start = input.LT(1);
        int functionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier124 = null;
        PsimulexParser.arguments_return arguments125 = default(PsimulexParser.arguments_return);


        CommonTree Identifier124_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:2: ( Identifier arguments )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:4: Identifier arguments
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier124=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionCall1629); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier124_tree = (CommonTree)adaptor.Create(Identifier124);
            		adaptor.AddChild(root_0, Identifier124_tree);
            	}
            	PushFollow(FOLLOW_arguments_in_functionCall1631);
            	arguments125 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments125.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:296:1: indexing : ( arrayIndexing | matrixIndexing );
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.arrayIndexing_return arrayIndexing126 = default(PsimulexParser.arrayIndexing_return);

        PsimulexParser.matrixIndexing_return matrixIndexing127 = default(PsimulexParser.matrixIndexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:2: ( arrayIndexing | matrixIndexing )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == 99) )
            {
                int LA32_1 = input.LA(2);

                if ( (synpred66_Psimulex()) )
                {
                    alt32 = 1;
                }
                else if ( (true) )
                {
                    alt32 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d32s1 =
                        new NoViableAltException("", 32, 1, input);

                    throw nvae_d32s1;
                }
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:4: arrayIndexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayIndexing_in_indexing1642);
                    	arrayIndexing126 = arrayIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayIndexing126.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:4: matrixIndexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixIndexing_in_indexing1647);
                    	matrixIndexing127 = matrixIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, matrixIndexing127.Tree);

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
            	Memoize(input, 52, indexing_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "indexing"

    public class arrayIndexing_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arrayIndexing"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:1: arrayIndexing : l= '[' expression r= ']' ;
    public PsimulexParser.arrayIndexing_return arrayIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayIndexing_return retval = new PsimulexParser.arrayIndexing_return();
        retval.Start = input.LT(1);
        int arrayIndexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken l = null;
        IToken r = null;
        PsimulexParser.expression_return expression128 = default(PsimulexParser.expression_return);


        CommonTree l_tree=null;
        CommonTree r_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:2: (l= '[' expression r= ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:4: l= '[' expression r= ']'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,99,FOLLOW_99_in_arrayIndexing1661); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_arrayIndexing1664);
            	expression128 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression128.Tree);
            	r=(IToken)Match(input,101,FOLLOW_101_in_arrayIndexing1668); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 53, arrayIndexing_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayIndexing"

    public class matrixIndexing_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "matrixIndexing"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:306:1: matrixIndexing : '[' expression ',' expression ']' ;
    public PsimulexParser.matrixIndexing_return matrixIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.matrixIndexing_return retval = new PsimulexParser.matrixIndexing_return();
        retval.Start = input.LT(1);
        int matrixIndexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal129 = null;
        IToken char_literal131 = null;
        IToken char_literal133 = null;
        PsimulexParser.expression_return expression130 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression132 = default(PsimulexParser.expression_return);


        CommonTree char_literal129_tree=null;
        CommonTree char_literal131_tree=null;
        CommonTree char_literal133_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:307:2: ( '[' expression ',' expression ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:307:4: '[' expression ',' expression ']'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal129=(IToken)Match(input,99,FOLLOW_99_in_matrixIndexing1682); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_matrixIndexing1685);
            	expression130 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression130.Tree);
            	char_literal131=(IToken)Match(input,100,FOLLOW_100_in_matrixIndexing1687); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_matrixIndexing1690);
            	expression132 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression132.Tree);
            	char_literal133=(IToken)Match(input,101,FOLLOW_101_in_matrixIndexing1692); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 54, matrixIndexing_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "matrixIndexing"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:1: arguments : '(' ( expressionList )? ')' ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal134 = null;
        IToken char_literal136 = null;
        PsimulexParser.expressionList_return expressionList135 = default(PsimulexParser.expressionList_return);


        CommonTree char_literal134_tree=null;
        CommonTree char_literal136_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:5: ( '(' ( expressionList )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:9: '(' ( expressionList )? ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal134=(IToken)Match(input,102,FOLLOW_102_in_arguments1710); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:311:14: ( expressionList )?
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == StringLiteral || LA33_0 == Identifier || (LA33_0 >= Plus && LA33_0 <= Minus) || (LA33_0 >= PlusPlus && LA33_0 <= InfinityLiteral) || LA33_0 == 102) )
            	{
            	    alt33 = 1;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1713);
            	        	expressionList135 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionList135.Tree);

            	        }
            	        break;

            	}

            	char_literal136=(IToken)Match(input,103,FOLLOW_103_in_arguments1716); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 55, arguments_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class expressionList_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expressionList"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:1: expressionList : expression ( ',' expression )* ;
    public PsimulexParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        PsimulexParser.expressionList_return retval = new PsimulexParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal138 = null;
        PsimulexParser.expression_return expression137 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression139 = default(PsimulexParser.expression_return);


        CommonTree char_literal138_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:5: ( expression ( ',' expression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:7: expression ( ',' expression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1734);
            	expression137 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression137.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:18: ( ',' expression )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == 100) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:19: ',' expression
            			    {
            			    	char_literal138=(IToken)Match(input,100,FOLLOW_100_in_expressionList1737); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_expression_in_expressionList1740);
            			    	expression139 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression139.Tree);

            			    }
            			    break;

            			default:
            			    goto loop34;
            	    }
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whining that label 'loop34' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 56, expressionList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expressionList"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:318:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
    public PsimulexParser.literal_return literal() // throws RecognitionException [1]
    {   
        PsimulexParser.literal_return retval = new PsimulexParser.literal_return();
        retval.Start = input.LT(1);
        int literal_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set140 = null;

        CommonTree set140_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:319:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set140 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || (input.LA(1) >= IntegerLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set140));
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

    public class lambdaExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lambdaExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:334:1: lambdaExpression : parameters '=>' lambdaStatement -> ^( LAMBDA_EXPRESSION parameters lambdaStatement ) ;
    public PsimulexParser.lambdaExpression_return lambdaExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.lambdaExpression_return retval = new PsimulexParser.lambdaExpression_return();
        retval.Start = input.LT(1);
        int lambdaExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal142 = null;
        PsimulexParser.parameters_return parameters141 = default(PsimulexParser.parameters_return);

        PsimulexParser.lambdaStatement_return lambdaStatement143 = default(PsimulexParser.lambdaStatement_return);


        CommonTree string_literal142_tree=null;
        RewriteRuleTokenStream stream_105 = new RewriteRuleTokenStream(adaptor,"token 105");
        RewriteRuleSubtreeStream stream_lambdaStatement = new RewriteRuleSubtreeStream(adaptor,"rule lambdaStatement");
        RewriteRuleSubtreeStream stream_parameters = new RewriteRuleSubtreeStream(adaptor,"rule parameters");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:335:2: ( parameters '=>' lambdaStatement -> ^( LAMBDA_EXPRESSION parameters lambdaStatement ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:335:4: parameters '=>' lambdaStatement
            {
            	PushFollow(FOLLOW_parameters_in_lambdaExpression1848);
            	parameters141 = parameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_parameters.Add(parameters141.Tree);
            	string_literal142=(IToken)Match(input,105,FOLLOW_105_in_lambdaExpression1850); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_105.Add(string_literal142);

            	PushFollow(FOLLOW_lambdaStatement_in_lambdaExpression1852);
            	lambdaStatement143 = lambdaStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_lambdaStatement.Add(lambdaStatement143.Tree);


            	// AST REWRITE
            	// elements:          lambdaStatement, parameters
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 335:36: -> ^( LAMBDA_EXPRESSION parameters lambdaStatement )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:335:39: ^( LAMBDA_EXPRESSION parameters lambdaStatement )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LAMBDA_EXPRESSION, "LAMBDA_EXPRESSION"), root_1);

            	    adaptor.AddChild(root_1, stream_parameters.NextTree());
            	    adaptor.AddChild(root_1, stream_lambdaStatement.NextTree());

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
            	Memoize(input, 58, lambdaExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lambdaExpression"

    public class parameters_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "parameters"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:338:1: parameters : ( Identifier | '(' lambdaParameterList ')' ) ;
    public PsimulexParser.parameters_return parameters() // throws RecognitionException [1]
    {   
        PsimulexParser.parameters_return retval = new PsimulexParser.parameters_return();
        retval.Start = input.LT(1);
        int parameters_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier144 = null;
        IToken char_literal145 = null;
        IToken char_literal147 = null;
        PsimulexParser.lambdaParameterList_return lambdaParameterList146 = default(PsimulexParser.lambdaParameterList_return);


        CommonTree Identifier144_tree=null;
        CommonTree char_literal145_tree=null;
        CommonTree char_literal147_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:2: ( ( Identifier | '(' lambdaParameterList ')' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:4: ( Identifier | '(' lambdaParameterList ')' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:4: ( Identifier | '(' lambdaParameterList ')' )
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == Identifier) )
            	{
            	    alt35 = 1;
            	}
            	else if ( (LA35_0 == 102) )
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:6: Identifier
            	        {
            	        	Identifier144=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_parameters1877); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier144_tree = (CommonTree)adaptor.Create(Identifier144);
            	        		adaptor.AddChild(root_0, Identifier144_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:19: '(' lambdaParameterList ')'
            	        {
            	        	char_literal145=(IToken)Match(input,102,FOLLOW_102_in_parameters1881); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_lambdaParameterList_in_parameters1884);
            	        	lambdaParameterList146 = lambdaParameterList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaParameterList146.Tree);
            	        	char_literal147=(IToken)Match(input,103,FOLLOW_103_in_parameters1886); if (state.failed) return retval;

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
            	Memoize(input, 59, parameters_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "parameters"

    public class lambdaParameterList_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lambdaParameterList"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:342:1: lambdaParameterList : lambdaParameter ( ',' lambdaParameter )* ;
    public PsimulexParser.lambdaParameterList_return lambdaParameterList() // throws RecognitionException [1]
    {   
        PsimulexParser.lambdaParameterList_return retval = new PsimulexParser.lambdaParameterList_return();
        retval.Start = input.LT(1);
        int lambdaParameterList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal149 = null;
        PsimulexParser.lambdaParameter_return lambdaParameter148 = default(PsimulexParser.lambdaParameter_return);

        PsimulexParser.lambdaParameter_return lambdaParameter150 = default(PsimulexParser.lambdaParameter_return);


        CommonTree char_literal149_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:343:2: ( lambdaParameter ( ',' lambdaParameter )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:343:4: lambdaParameter ( ',' lambdaParameter )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_lambdaParameter_in_lambdaParameterList1901);
            	lambdaParameter148 = lambdaParameter();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaParameter148.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:343:20: ( ',' lambdaParameter )*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == 100) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:343:22: ',' lambdaParameter
            			    {
            			    	char_literal149=(IToken)Match(input,100,FOLLOW_100_in_lambdaParameterList1905); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal149_tree = (CommonTree)adaptor.Create(char_literal149);
            			    		adaptor.AddChild(root_0, char_literal149_tree);
            			    	}
            			    	PushFollow(FOLLOW_lambdaParameter_in_lambdaParameterList1907);
            			    	lambdaParameter150 = lambdaParameter();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaParameter150.Tree);

            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 60, lambdaParameterList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lambdaParameterList"

    public class lambdaParameter_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lambdaParameter"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:1: lambdaParameter : ( dataType )? Identifier ;
    public PsimulexParser.lambdaParameter_return lambdaParameter() // throws RecognitionException [1]
    {   
        PsimulexParser.lambdaParameter_return retval = new PsimulexParser.lambdaParameter_return();
        retval.Start = input.LT(1);
        int lambdaParameter_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier152 = null;
        PsimulexParser.dataType_return dataType151 = default(PsimulexParser.dataType_return);


        CommonTree Identifier152_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:2: ( ( dataType )? Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:4: ( dataType )? Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:4: ( dataType )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( ((LA37_0 >= Bool && LA37_0 <= PQueue)) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: dataType
            	        {
            	        	PushFollow(FOLLOW_dataType_in_lambdaParameter1922);
            	        	dataType151 = dataType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType151.Tree);

            	        }
            	        break;

            	}

            	Identifier152=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_lambdaParameter1925); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier152_tree = (CommonTree)adaptor.Create(Identifier152);
            		root_0 = (CommonTree)adaptor.BecomeRoot(Identifier152_tree, root_0);
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
            	Memoize(input, 61, lambdaParameter_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lambdaParameter"

    public class lambdaStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lambdaStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:1: lambdaStatement : ( expression | block );
    public PsimulexParser.lambdaStatement_return lambdaStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.lambdaStatement_return retval = new PsimulexParser.lambdaStatement_return();
        retval.Start = input.LT(1);
        int lambdaStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression153 = default(PsimulexParser.expression_return);

        PsimulexParser.block_return block154 = default(PsimulexParser.block_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:2: ( expression | block )
            int alt38 = 2;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == StringLiteral || LA38_0 == Identifier || (LA38_0 >= Plus && LA38_0 <= Minus) || (LA38_0 >= PlusPlus && LA38_0 <= InfinityLiteral) || LA38_0 == 102) )
            {
                alt38 = 1;
            }
            else if ( (LA38_0 == 97) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:4: expression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_lambdaStatement1938);
                    	expression153 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression153.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:17: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_lambdaStatement1942);
                    	block154 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block154.Tree);

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
            	Memoize(input, 62, lambdaStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lambdaStatement"

    public class functionPointerType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "functionPointerType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:354:1: functionPointerType : Func '<' dataTypeName ( '[' ( ',' )* ']' )? '>' -> ^( FUNCTIONPOINTERTYPE dataTypeName ( '[' ( ',' )* ']' )? ) ;
    public PsimulexParser.functionPointerType_return functionPointerType() // throws RecognitionException [1]
    {   
        PsimulexParser.functionPointerType_return retval = new PsimulexParser.functionPointerType_return();
        retval.Start = input.LT(1);
        int functionPointerType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Func155 = null;
        IToken char_literal156 = null;
        IToken char_literal158 = null;
        IToken char_literal159 = null;
        IToken char_literal160 = null;
        IToken char_literal161 = null;
        PsimulexParser.dataTypeName_return dataTypeName157 = default(PsimulexParser.dataTypeName_return);


        CommonTree Func155_tree=null;
        CommonTree char_literal156_tree=null;
        CommonTree char_literal158_tree=null;
        CommonTree char_literal159_tree=null;
        CommonTree char_literal160_tree=null;
        CommonTree char_literal161_tree=null;
        RewriteRuleTokenStream stream_RelGreaterThan = new RewriteRuleTokenStream(adaptor,"token RelGreaterThan");
        RewriteRuleTokenStream stream_RelLessThan = new RewriteRuleTokenStream(adaptor,"token RelLessThan");
        RewriteRuleTokenStream stream_Func = new RewriteRuleTokenStream(adaptor,"token Func");
        RewriteRuleTokenStream stream_99 = new RewriteRuleTokenStream(adaptor,"token 99");
        RewriteRuleTokenStream stream_101 = new RewriteRuleTokenStream(adaptor,"token 101");
        RewriteRuleTokenStream stream_100 = new RewriteRuleTokenStream(adaptor,"token 100");
        RewriteRuleSubtreeStream stream_dataTypeName = new RewriteRuleSubtreeStream(adaptor,"rule dataTypeName");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:2: ( Func '<' dataTypeName ( '[' ( ',' )* ']' )? '>' -> ^( FUNCTIONPOINTERTYPE dataTypeName ( '[' ( ',' )* ']' )? ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:4: Func '<' dataTypeName ( '[' ( ',' )* ']' )? '>'
            {
            	Func155=(IToken)Match(input,Func,FOLLOW_Func_in_functionPointerType1954); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_Func.Add(Func155);

            	char_literal156=(IToken)Match(input,RelLessThan,FOLLOW_RelLessThan_in_functionPointerType1956); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_RelLessThan.Add(char_literal156);

            	PushFollow(FOLLOW_dataTypeName_in_functionPointerType1958);
            	dataTypeName157 = dataTypeName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking==0 ) stream_dataTypeName.Add(dataTypeName157.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:26: ( '[' ( ',' )* ']' )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == 99) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:28: '[' ( ',' )* ']'
            	        {
            	        	char_literal158=(IToken)Match(input,99,FOLLOW_99_in_functionPointerType1962); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_99.Add(char_literal158);

            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:32: ( ',' )*
            	        	do 
            	        	{
            	        	    int alt39 = 2;
            	        	    int LA39_0 = input.LA(1);

            	        	    if ( (LA39_0 == 100) )
            	        	    {
            	        	        alt39 = 1;
            	        	    }


            	        	    switch (alt39) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:34: ','
            	        			    {
            	        			    	char_literal159=(IToken)Match(input,100,FOLLOW_100_in_functionPointerType1966); if (state.failed) return retval; 
            	        			    	if ( state.backtracking==0 ) stream_100.Add(char_literal159);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop39;
            	        	    }
            	        	} while (true);

            	        	loop39:
            	        		;	// Stops C# compiler whining that label 'loop39' has no statements

            	        	char_literal160=(IToken)Match(input,101,FOLLOW_101_in_functionPointerType1971); if (state.failed) return retval; 
            	        	if ( state.backtracking==0 ) stream_101.Add(char_literal160);


            	        }
            	        break;

            	}

            	char_literal161=(IToken)Match(input,RelGreaterThan,FOLLOW_RelGreaterThan_in_functionPointerType1976); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_RelGreaterThan.Add(char_literal161);



            	// AST REWRITE
            	// elements:          dataTypeName, 99, 100, 101
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	if ( state.backtracking==0 ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 355:52: -> ^( FUNCTIONPOINTERTYPE dataTypeName ( '[' ( ',' )* ']' )? )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:55: ^( FUNCTIONPOINTERTYPE dataTypeName ( '[' ( ',' )* ']' )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTIONPOINTERTYPE, "FUNCTIONPOINTERTYPE"), root_1);

            	    adaptor.AddChild(root_1, stream_dataTypeName.NextTree());
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:91: ( '[' ( ',' )* ']' )?
            	    if ( stream_99.HasNext() || stream_100.HasNext() || stream_101.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_99.NextNode());
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:97: ( ',' )*
            	        while ( stream_100.HasNext() )
            	        {
            	            adaptor.AddChild(root_1, stream_100.NextNode());

            	        }
            	        stream_100.Reset();
            	        adaptor.AddChild(root_1, stream_101.NextNode());

            	    }
            	    stream_99.Reset();
            	    stream_100.Reset();
            	    stream_101.Reset();

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
            	Memoize(input, 63, functionPointerType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionPointerType"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:368:1: block : '{' ( statement )* '}' -> ^( BLOCK ( statement )* ) ;
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
        RewriteRuleTokenStream stream_98 = new RewriteRuleTokenStream(adaptor,"token 98");
        RewriteRuleTokenStream stream_97 = new RewriteRuleTokenStream(adaptor,"token 97");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:5: ( '{' ( statement )* '}' -> ^( BLOCK ( statement )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:9: '{' ( statement )* '}'
            {
            	char_literal162=(IToken)Match(input,97,FOLLOW_97_in_block2029); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_97.Add(char_literal162);

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:13: ( statement )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == StringLiteral || LA41_0 == Identifier || (LA41_0 >= Bool && LA41_0 <= PQueue) || (LA41_0 >= Plus && LA41_0 <= Minus) || (LA41_0 >= PlusPlus && LA41_0 <= If) || (LA41_0 >= For && LA41_0 <= Continue) || LA41_0 == 96 || LA41_0 == 102) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block2031);
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

            	char_literal164=(IToken)Match(input,98,FOLLOW_98_in_block2034); if (state.failed) return retval; 
            	if ( state.backtracking==0 ) stream_98.Add(char_literal164);



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
            	// 369:28: -> ^( BLOCK ( statement )* )
            	{
            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:31: ^( BLOCK ( statement )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:40: ( statement )*
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
            	Memoize(input, 64, block_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:372:1: branch : ( block | statement );
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
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:5: ( block | statement )
            int alt42 = 2;
            int LA42_0 = input.LA(1);

            if ( (LA42_0 == 97) )
            {
                alt42 = 1;
            }
            else if ( (LA42_0 == StringLiteral || LA42_0 == Identifier || (LA42_0 >= Bool && LA42_0 <= PQueue) || (LA42_0 >= Plus && LA42_0 <= Minus) || (LA42_0 >= PlusPlus && LA42_0 <= If) || (LA42_0 >= For && LA42_0 <= Continue) || LA42_0 == 96 || LA42_0 == 102) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:7: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch2070);
                    	block165 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block165.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:15: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_branch2074);
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
            	Memoize(input, 65, branch_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:376:1: statement : ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' | localVariableDeclaration ';' );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken If167 = null;
        IToken Else170 = null;
        IToken set172 = null;
        IToken char_literal173 = null;
        IToken char_literal175 = null;
        IToken set177 = null;
        IToken char_literal178 = null;
        IToken char_literal180 = null;
        IToken Loop182 = null;
        IToken char_literal183 = null;
        IToken char_literal185 = null;
        IToken While187 = null;
        IToken Do190 = null;
        IToken While192 = null;
        IToken char_literal194 = null;
        IToken PDo195 = null;
        IToken Return197 = null;
        IToken char_literal199 = null;
        IToken Break200 = null;
        IToken char_literal201 = null;
        IToken Continue202 = null;
        IToken char_literal203 = null;
        IToken char_literal204 = null;
        IToken char_literal206 = null;
        IToken char_literal208 = null;
        PsimulexParser.parExpression_return parExpression168 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch169 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch171 = default(PsimulexParser.branch_return);

        PsimulexParser.forControl_return forControl174 = default(PsimulexParser.forControl_return);

        PsimulexParser.branch_return branch176 = default(PsimulexParser.branch_return);

        PsimulexParser.foreachControl_return foreachControl179 = default(PsimulexParser.foreachControl_return);

        PsimulexParser.branch_return branch181 = default(PsimulexParser.branch_return);

        PsimulexParser.loopControl_return loopControl184 = default(PsimulexParser.loopControl_return);

        PsimulexParser.branch_return branch186 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression188 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch189 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch191 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression193 = default(PsimulexParser.parExpression_return);

        PsimulexParser.block_return block196 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression198 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression205 = default(PsimulexParser.expression_return);

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration207 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree If167_tree=null;
        CommonTree Else170_tree=null;
        CommonTree set172_tree=null;
        CommonTree char_literal173_tree=null;
        CommonTree char_literal175_tree=null;
        CommonTree set177_tree=null;
        CommonTree char_literal178_tree=null;
        CommonTree char_literal180_tree=null;
        CommonTree Loop182_tree=null;
        CommonTree char_literal183_tree=null;
        CommonTree char_literal185_tree=null;
        CommonTree While187_tree=null;
        CommonTree Do190_tree=null;
        CommonTree While192_tree=null;
        CommonTree char_literal194_tree=null;
        CommonTree PDo195_tree=null;
        CommonTree Return197_tree=null;
        CommonTree char_literal199_tree=null;
        CommonTree Break200_tree=null;
        CommonTree char_literal201_tree=null;
        CommonTree Continue202_tree=null;
        CommonTree char_literal203_tree=null;
        CommonTree char_literal204_tree=null;
        CommonTree char_literal206_tree=null;
        CommonTree char_literal208_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 66) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:5: ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' | localVariableDeclaration ';' )
            int alt45 = 13;
            switch ( input.LA(1) ) 
            {
            case If:
            	{
                alt45 = 1;
                }
                break;
            case For:
            case PFor:
            	{
                alt45 = 2;
                }
                break;
            case ForEach:
            case PForEach:
            	{
                alt45 = 3;
                }
                break;
            case Loop:
            	{
                alt45 = 4;
                }
                break;
            case While:
            	{
                alt45 = 5;
                }
                break;
            case Do:
            	{
                alt45 = 6;
                }
                break;
            case PDo:
            	{
                alt45 = 7;
                }
                break;
            case Return:
            	{
                alt45 = 8;
                }
                break;
            case Break:
            	{
                alt45 = 9;
                }
                break;
            case Continue:
            	{
                alt45 = 10;
                }
                break;
            case 96:
            	{
                alt45 = 11;
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
            case 102:
            	{
                alt45 = 12;
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
            case Func:
            	{
                alt45 = 13;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d45s0 =
            	        new NoViableAltException("", 45, 0, input);

            	    throw nvae_d45s0;
            }

            switch (alt45) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:7: If parExpression branch ( options {k=1; } : Else branch )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	If167=(IToken)Match(input,If,FOLLOW_If_in_statement2092); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{If167_tree = (CommonTree)adaptor.Create(If167);
                    		adaptor.AddChild(root_0, If167_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement2094);
                    	parExpression168 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression168.Tree);
                    	PushFollow(FOLLOW_branch_in_statement2096);
                    	branch169 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch169.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:31: ( options {k=1; } : Else branch )?
                    	int alt43 = 2;
                    	int LA43_0 = input.LA(1);

                    	if ( (LA43_0 == Else) )
                    	{
                    	    int LA43_2 = input.LA(2);

                    	    if ( (synpred83_Psimulex()) )
                    	    {
                    	        alt43 = 1;
                    	    }
                    	}
                    	switch (alt43) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:47: Else branch
                    	        {
                    	        	Else170=(IToken)Match(input,Else,FOLLOW_Else_in_statement2106); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{Else170_tree = (CommonTree)adaptor.Create(Else170);
                    	        		adaptor.AddChild(root_0, Else170_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_branch_in_statement2108);
                    	        	branch171 = branch();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch171.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:378:9: ( For | PFor ) '(' forControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set172 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= For && input.LA(1) <= PFor) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set172));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal173=(IToken)Match(input,102,FOLLOW_102_in_statement2126); if (state.failed) return retval;
                    	PushFollow(FOLLOW_forControl_in_statement2129);
                    	forControl174 = forControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forControl174.Tree);
                    	char_literal175=(IToken)Match(input,103,FOLLOW_103_in_statement2131); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement2134);
                    	branch176 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch176.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:379:9: ( ForEach | PForEach ) '(' foreachControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set177 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= ForEach && input.LA(1) <= PForEach) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set177));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal178=(IToken)Match(input,102,FOLLOW_102_in_statement2150); if (state.failed) return retval;
                    	PushFollow(FOLLOW_foreachControl_in_statement2153);
                    	foreachControl179 = foreachControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, foreachControl179.Tree);
                    	char_literal180=(IToken)Match(input,103,FOLLOW_103_in_statement2155); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement2158);
                    	branch181 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch181.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:380:9: Loop '(' loopControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Loop182=(IToken)Match(input,Loop,FOLLOW_Loop_in_statement2168); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Loop182_tree = (CommonTree)adaptor.Create(Loop182);
                    		adaptor.AddChild(root_0, Loop182_tree);
                    	}
                    	char_literal183=(IToken)Match(input,102,FOLLOW_102_in_statement2170); if (state.failed) return retval;
                    	PushFollow(FOLLOW_loopControl_in_statement2173);
                    	loopControl184 = loopControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopControl184.Tree);
                    	char_literal185=(IToken)Match(input,103,FOLLOW_103_in_statement2175); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement2178);
                    	branch186 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch186.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:381:9: While parExpression branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	While187=(IToken)Match(input,While,FOLLOW_While_in_statement2188); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While187_tree = (CommonTree)adaptor.Create(While187);
                    		adaptor.AddChild(root_0, While187_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement2190);
                    	parExpression188 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression188.Tree);
                    	PushFollow(FOLLOW_branch_in_statement2192);
                    	branch189 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch189.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:9: Do branch While parExpression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Do190=(IToken)Match(input,Do,FOLLOW_Do_in_statement2202); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Do190_tree = (CommonTree)adaptor.Create(Do190);
                    		adaptor.AddChild(root_0, Do190_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement2204);
                    	branch191 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch191.Tree);
                    	While192=(IToken)Match(input,While,FOLLOW_While_in_statement2206); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While192_tree = (CommonTree)adaptor.Create(While192);
                    		adaptor.AddChild(root_0, While192_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement2208);
                    	parExpression193 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression193.Tree);
                    	char_literal194=(IToken)Match(input,96,FOLLOW_96_in_statement2210); if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:383:9: PDo block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PDo195=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement2221); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PDo195_tree = (CommonTree)adaptor.Create(PDo195);
                    		adaptor.AddChild(root_0, PDo195_tree);
                    	}
                    	PushFollow(FOLLOW_block_in_statement2223);
                    	block196 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block196.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:384:9: Return ( expression )? ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Return197=(IToken)Match(input,Return,FOLLOW_Return_in_statement2233); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Return197_tree = (CommonTree)adaptor.Create(Return197);
                    		adaptor.AddChild(root_0, Return197_tree);
                    	}
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:384:16: ( expression )?
                    	int alt44 = 2;
                    	int LA44_0 = input.LA(1);

                    	if ( (LA44_0 == StringLiteral || LA44_0 == Identifier || (LA44_0 >= Plus && LA44_0 <= Minus) || (LA44_0 >= PlusPlus && LA44_0 <= InfinityLiteral) || LA44_0 == 102) )
                    	{
                    	    alt44 = 1;
                    	}
                    	switch (alt44) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement2235);
                    	        	expression198 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression198.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal199=(IToken)Match(input,96,FOLLOW_96_in_statement2238); if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:385:9: Break ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Break200=(IToken)Match(input,Break,FOLLOW_Break_in_statement2249); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break200_tree = (CommonTree)adaptor.Create(Break200);
                    		adaptor.AddChild(root_0, Break200_tree);
                    	}
                    	char_literal201=(IToken)Match(input,96,FOLLOW_96_in_statement2251); if (state.failed) return retval;

                    }
                    break;
                case 10 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:386:9: Continue ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Continue202=(IToken)Match(input,Continue,FOLLOW_Continue_in_statement2262); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Continue202_tree = (CommonTree)adaptor.Create(Continue202);
                    		adaptor.AddChild(root_0, Continue202_tree);
                    	}
                    	char_literal203=(IToken)Match(input,96,FOLLOW_96_in_statement2264); if (state.failed) return retval;

                    }
                    break;
                case 11 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:387:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal204=(IToken)Match(input,96,FOLLOW_96_in_statement2275); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:388:9: expression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_statement2286);
                    	expression205 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression205.Tree);
                    	char_literal206=(IToken)Match(input,96,FOLLOW_96_in_statement2288); if (state.failed) return retval;

                    }
                    break;
                case 13 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:389:7: localVariableDeclaration ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_localVariableDeclaration_in_statement2297);
                    	localVariableDeclaration207 = localVariableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration207.Tree);
                    	char_literal208=(IToken)Match(input,96,FOLLOW_96_in_statement2299); if (state.failed) return retval;

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
            	Memoize(input, 66, statement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:392:1: forControl : ( forInit )? ';' ( expression )? ';' ( forUpdate )? ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal210 = null;
        IToken char_literal212 = null;
        PsimulexParser.forInit_return forInit209 = default(PsimulexParser.forInit_return);

        PsimulexParser.expression_return expression211 = default(PsimulexParser.expression_return);

        PsimulexParser.forUpdate_return forUpdate213 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal210_tree=null;
        CommonTree char_literal212_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 67) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:5: ( ( forInit )? ';' ( expression )? ';' ( forUpdate )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:10: ( forInit )? ';' ( expression )? ';' ( forUpdate )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:10: ( forInit )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( ((LA46_0 >= Bool && LA46_0 <= PQueue) || LA46_0 == Func) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl2324);
            	        	forInit209 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInit209.Tree);

            	        }
            	        break;

            	}

            	char_literal210=(IToken)Match(input,96,FOLLOW_96_in_forControl2327); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:24: ( expression )?
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( (LA47_0 == StringLiteral || LA47_0 == Identifier || (LA47_0 >= Plus && LA47_0 <= Minus) || (LA47_0 >= PlusPlus && LA47_0 <= InfinityLiteral) || LA47_0 == 102) )
            	{
            	    alt47 = 1;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forControl2330);
            	        	expression211 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression211.Tree);

            	        }
            	        break;

            	}

            	char_literal212=(IToken)Match(input,96,FOLLOW_96_in_forControl2333); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:41: ( forUpdate )?
            	int alt48 = 2;
            	int LA48_0 = input.LA(1);

            	if ( (LA48_0 == StringLiteral || LA48_0 == Identifier || (LA48_0 >= Plus && LA48_0 <= Minus) || (LA48_0 >= PlusPlus && LA48_0 <= InfinityLiteral) || LA48_0 == 102) )
            	{
            	    alt48 = 1;
            	}
            	switch (alt48) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl2336);
            	        	forUpdate213 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forUpdate213.Tree);

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
            	Memoize(input, 67, forControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:396:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration214 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 68) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:5: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:397:9: localVariableDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit2356);
            	localVariableDeclaration214 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration214.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 68, forInit_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:400:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression215 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 69) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:401:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate2375);
            	expression215 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression215.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 69, forUpdate_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:404:1: foreachControl options {k=3; } : type Identifier In expression ;
    public PsimulexParser.foreachControl_return foreachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.foreachControl_return retval = new PsimulexParser.foreachControl_return();
        retval.Start = input.LT(1);
        int foreachControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier217 = null;
        IToken In218 = null;
        PsimulexParser.type_return type216 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression219 = default(PsimulexParser.expression_return);


        CommonTree Identifier217_tree=null;
        CommonTree In218_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 70) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:406:5: ( type Identifier In expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:406:9: type Identifier In expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_foreachControl2406);
            	type216 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type216.Tree);
            	Identifier217=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_foreachControl2408); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier217_tree = (CommonTree)adaptor.Create(Identifier217);
            		adaptor.AddChild(root_0, Identifier217_tree);
            	}
            	In218=(IToken)Match(input,In,FOLLOW_In_in_foreachControl2410); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{In218_tree = (CommonTree)adaptor.Create(In218);
            		adaptor.AddChild(root_0, In218_tree);
            	}
            	PushFollow(FOLLOW_expression_in_foreachControl2412);
            	expression219 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression219.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 70, foreachControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:410:1: loopControl options {k=3; } : type Identifier To expression ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier221 = null;
        IToken To222 = null;
        PsimulexParser.type_return type220 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression223 = default(PsimulexParser.expression_return);


        CommonTree Identifier221_tree=null;
        CommonTree To222_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 71) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:412:5: ( type Identifier To expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:412:9: type Identifier To expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_loopControl2444);
            	type220 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type220.Tree);
            	Identifier221=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_loopControl2446); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier221_tree = (CommonTree)adaptor.Create(Identifier221);
            		adaptor.AddChild(root_0, Identifier221_tree);
            	}
            	To222=(IToken)Match(input,To,FOLLOW_To_in_loopControl2448); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{To222_tree = (CommonTree)adaptor.Create(To222);
            		adaptor.AddChild(root_0, To222_tree);
            	}
            	PushFollow(FOLLOW_expression_in_loopControl2450);
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
            	Memoize(input, 71, loopControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "loopControl"

    // $ANTLR start "synpred1_Psimulex"
    public void synpred1_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:9: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:9: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex169);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred3_Psimulex"
    public void synpred3_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:4: ( memberDeclaration )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:4: memberDeclaration
        {
        	PushFollow(FOLLOW_memberDeclaration_in_synpred3_Psimulex250);
        	memberDeclaration();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_Psimulex"

    // $ANTLR start "synpred8_Psimulex"
    public void synpred8_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:9: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:9: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred8_Psimulex469);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_Psimulex"

    // $ANTLR start "synpred9_Psimulex"
    public void synpred9_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:95:9: ( typedIdentifierNonRef Assign variableInitializer )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:95:9: typedIdentifierNonRef Assign variableInitializer
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex487);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,Assign,FOLLOW_Assign_in_synpred9_Psimulex489); if (state.failed) return ;
        	PushFollow(FOLLOW_variableInitializer_in_synpred9_Psimulex491);
        	variableInitializer();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Psimulex"

    // $ANTLR start "synpred13_Psimulex"
    public void synpred13_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:116:4: ( typedIdentifierNonRef )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:116:4: typedIdentifierNonRef
        {
        	PushFollow(FOLLOW_typedIdentifierNonRef_in_synpred13_Psimulex651);
        	typedIdentifierNonRef();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred13_Psimulex"

    // $ANTLR start "synpred29_Psimulex"
    public void synpred29_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred29_Psimulex977);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred29_Psimulex"

    // $ANTLR start "synpred30_Psimulex"
    public void synpred30_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:17: ( conditionalOrExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:17: conditionalOrExpression
        {
        	PushFollow(FOLLOW_conditionalOrExpression_in_synpred30_Psimulex981);
        	conditionalOrExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_Psimulex"

    // $ANTLR start "synpred58_Psimulex"
    public void synpred58_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:255:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:255:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred58_Psimulex1452);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred58_Psimulex"

    // $ANTLR start "synpred59_Psimulex"
    public void synpred59_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:256:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:256:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred59_Psimulex1460);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred59_Psimulex"

    // $ANTLR start "synpred66_Psimulex"
    public void synpred66_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:4: ( arrayIndexing )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:4: arrayIndexing
        {
        	PushFollow(FOLLOW_arrayIndexing_in_synpred66_Psimulex1642);
        	arrayIndexing();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred66_Psimulex"

    // $ANTLR start "synpred83_Psimulex"
    public void synpred83_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:47: ( Else branch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:377:47: Else branch
        {
        	Match(input,Else,FOLLOW_Else_in_synpred83_Psimulex2106); if (state.failed) return ;
        	PushFollow(FOLLOW_branch_in_synpred83_Psimulex2108);
        	branch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred83_Psimulex"

    // Delegated rules

   	public bool synpred59_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred59_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred30_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred58_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred58_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred13_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred29_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred29_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred66_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred66_Psimulex_fragment(); // can never throw exception
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
        "\x16\uffff";
    const string DFA1_eofS =
        "\x01\x13\x15\uffff";
    const string DFA1_minS =
        "\x01\x18\x0f\uffff\x04\x00\x02\uffff";
    const string DFA1_maxS =
        "\x01\x66\x0f\uffff\x04\x00\x02\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x12\uffff\x01\x02\x01\uffff";
    const string DFA1_specialS =
        "\x10\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x02\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x14\x01\x01\x01\x14\x01\x01\x02\uffff\x06\x10\x07\x11"+
            "\x0d\uffff\x02\x01\x03\uffff\x09\x01\x01\x12\x01\x01\x01\uffff"+
            "\x0b\x01\x0c\uffff\x01\x01\x05\uffff\x01\x01",
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
            get { return "43:7: ( simpleProgram | multiFunctionalProgram )"; }
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

                   	else if ( (true) ) { s = 20; }

                   	 
                   	input.Seek(index1_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_17 = input.LA(1);

                   	 
                   	int index1_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (true) ) { s = 20; }

                   	 
                   	input.Seek(index1_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_18 = input.LA(1);

                   	 
                   	int index1_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (true) ) { s = 20; }

                   	 
                   	input.Seek(index1_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA1_19 = input.LA(1);

                   	 
                   	int index1_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 1; }

                   	else if ( (true) ) { s = 20; }

                   	 
                   	input.Seek(index1_19);
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
        "\x06\uffff\x01\x10\x02\uffff\x01\x10\x12\uffff";
    const string DFA8_minS =
        "\x01\x1e\x02\x1b\x01\x34\x01\x19\x01\uffff\x01\x1c\x01\x19\x01"+
        "\uffff\x01\x1c\x01\x1e\x05\x00\x02\uffff\x05\x00\x02\uffff\x02\x00"+
        "\x01\uffff";
    const string DFA8_maxS =
        "\x01\x46\x02\x63\x01\x34\x01\x66\x01\uffff\x01\x60\x01\x66\x01"+
        "\uffff\x01\x60\x01\x2a\x05\x00\x02\uffff\x05\x00\x02\uffff\x02\x00"+
        "\x01\uffff";
    const string DFA8_acceptS =
        "\x05\uffff\x01\x03\x0a\uffff\x01\x01\x0a\uffff\x01\x02";
    const string DFA8_specialS =
        "\x0b\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x02\uffff\x01"+
        "\x05\x01\x06\x01\x07\x01\x08\x01\x09\x02\uffff\x01\x0a\x01\x0b\x01"+
        "\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x06\x01\x07\x02\x1b\uffff\x01\x03",
            "\x01\x06\x01\uffff\x01\x05\x45\uffff\x01\x04",
            "\x01\x09\x01\uffff\x01\x05\x45\uffff\x01\x07",
            "\x01\x0a",
            "\x01\x0e\x01\uffff\x01\x0b\x1c\uffff\x02\x0d\x03\uffff\x03"+
            "\x0d\x06\x0e\x20\uffff\x01\x0c",
            "",
            "\x01\x0f\x43\uffff\x01\x10",
            "\x01\x15\x01\uffff\x01\x12\x1c\uffff\x02\x14\x03\uffff\x03"+
            "\x14\x06\x15\x20\uffff\x01\x13",
            "",
            "\x01\x16\x43\uffff\x01\x10",
            "\x06\x19\x07\x1a",
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
            "",
            "",
            "\x01\uffff",
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
            get { return "92:1: localVariableDeclaration options {k=3; } : ( typedIdentifierNonRef -> ^( VARDECLARE typedIdentifierNonRef ) | typedIdentifierNonRef Assign variableInitializer -> ^( VARINIT typedIdentifierNonRef variableInitializer ) | typedIdentifierRef Assign variableInitializer -> ^( VARINIT typedIdentifierRef variableInitializer ) );"; }
        }

    }


    protected internal int DFA8_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA8_11 = input.LA(1);

                   	 
                   	int index8_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA8_12 = input.LA(1);

                   	 
                   	int index8_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA8_13 = input.LA(1);

                   	 
                   	int index8_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA8_14 = input.LA(1);

                   	 
                   	int index8_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA8_15 = input.LA(1);

                   	 
                   	int index8_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA8_18 = input.LA(1);

                   	 
                   	int index8_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA8_19 = input.LA(1);

                   	 
                   	int index8_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA8_20 = input.LA(1);

                   	 
                   	int index8_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA8_21 = input.LA(1);

                   	 
                   	int index8_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA8_22 = input.LA(1);

                   	 
                   	int index8_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA8_25 = input.LA(1);

                   	 
                   	int index8_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index8_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA8_26 = input.LA(1);

                   	 
                   	int index8_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_Psimulex()) ) { s = 16; }

                   	else if ( (synpred9_Psimulex()) ) { s = 27; }

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
 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit169 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit173 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_simpleProgram192 = new BitSet(new ulong[]{0xE30007FFCA000002UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_importDeclarations_in_multiFunctionalProgram215 = new BitSet(new ulong[]{0xE30007FFDE000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_typeDeclarations_in_multiFunctionalProgram217 = new BitSet(new ulong[]{0xE30007FFDA000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_globalVariableDeclarations_in_multiFunctionalProgram219 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_functionDeclarations_in_multiFunctionalProgram221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclarations250 = new BitSet(new ulong[]{0xE30007FFDA000002UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_Import_in_importDeclarations290 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclarations292 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_importDeclarations294 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclarations327 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration358 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration360 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_97_in_structBody392 = new BitSet(new ulong[]{0xE30007FFDA000000UL,0x00000045000FFEFFUL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBody395 = new BitSet(new ulong[]{0xE30007FFDA000000UL,0x00000045000FFEFFUL});
    public static readonly BitSet FOLLOW_98_in_structBody398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_memberDeclaration419 = new BitSet(new ulong[]{0x0000000010000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_Assign_in_memberDeclaration423 = new BitSet(new ulong[]{0x0000000002000000UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_literal_in_memberDeclaration425 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_memberDeclaration430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_localVariableDeclaration487 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration489 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_localVariableDeclaration506 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration508 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInitializer543 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_scalarOrArrayType563 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_99_in_scalarOrArrayType567 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_scalarOrArrayType569 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000003000000000UL});
    public static readonly BitSet FOLLOW_100_in_scalarOrArrayType572 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_scalarOrArrayType574 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000003000000000UL});
    public static readonly BitSet FOLLOW_101_in_scalarOrArrayType578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierNonRef619 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierNonRef621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarOrArrayType_in_typedIdentifierRef633 = new BitSet(new ulong[]{0x0000000028000000UL});
    public static readonly BitSet FOLLOW_Reference_in_typedIdentifierRef635 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierRef638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_typedIdentifier651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierRef_in_typedIdentifier655 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_functionDeclarations672 = new BitSet(new ulong[]{0xE30007FFCA000002UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_functionDeclaration705 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_formalParameters_in_functionDeclaration707 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_102_in_formalParameters742 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameters745 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000009000000000UL});
    public static readonly BitSet FOLLOW_100_in_formalParameters748 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_formalParameter_in_formalParameters751 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000009000000000UL});
    public static readonly BitSet FOLLOW_103_in_formalParameters755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifier_in_formalParameter774 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_type806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionPointerType_in_type810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataTypeName_in_dataType824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataTypeName845 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataTypeName849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expression977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_expression981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lambdaExpression_in_expression985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment997 = new BitSet(new ulong[]{0x0000F80010000000UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment999 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_assignment1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1060 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression1064 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1066 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1111 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression1115 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1118 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1140 = new BitSet(new ulong[]{0x000C000000000002UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression1146 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1151 = new BitSet(new ulong[]{0x000C000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1186 = new BitSet(new ulong[]{0x00F0000000000002UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression1190 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1193 = new BitSet(new ulong[]{0x00F0000000000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1247 = new BitSet(new ulong[]{0x0300000000000002UL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression1251 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1254 = new BitSet(new ulong[]{0x0300000000000002UL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1289 = new BitSet(new ulong[]{0x1C00000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression1293 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1296 = new BitSet(new ulong[]{0x1C00000000000002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryExpression1331 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression1342 = new BitSet(new ulong[]{0x6000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpression1345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpression1353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_102_in_castExpression1372 = new BitSet(new ulong[]{0x000007FFC0000000UL});
    public static readonly BitSet FOLLOW_dataType_in_castExpression1374 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_castExpression1376 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1427 = new BitSet(new ulong[]{0x6000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1430 = new BitSet(new ulong[]{0x6000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1460 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1470 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_primaryExpression1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_102_in_parExpression1497 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1500 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_parExpression1502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selecting1545 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000010800000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selecting1547 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000010800000000UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1550 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000010800000000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector1567 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector1577 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_indexing_in_selector1587 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_104_in_memberSelect1601 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect1604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_104_in_memberFunctionCall1615 = new BitSet(new ulong[]{0x000000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_functionCall_in_memberFunctionCall1618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall1629 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_arguments_in_functionCall1631 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_indexing1642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixIndexing_in_indexing1647 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_99_in_arrayIndexing1661 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_arrayIndexing1664 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_101_in_arrayIndexing1668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_99_in_matrixIndexing1682 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1685 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_100_in_matrixIndexing1687 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1690 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_101_in_matrixIndexing1692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_102_in_arguments1710 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000C00000003FUL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1713 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_arguments1716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1734 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_100_in_expressionList1737 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1740 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parameters_in_lambdaExpression1848 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_105_in_lambdaExpression1850 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000420000003FUL});
    public static readonly BitSet FOLLOW_lambdaStatement_in_lambdaExpression1852 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_parameters1877 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_102_in_parameters1881 = new BitSet(new ulong[]{0x000007FFC8000000UL});
    public static readonly BitSet FOLLOW_lambdaParameterList_in_parameters1884 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_parameters1886 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lambdaParameter_in_lambdaParameterList1901 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_100_in_lambdaParameterList1905 = new BitSet(new ulong[]{0x000007FFC8000000UL});
    public static readonly BitSet FOLLOW_lambdaParameter_in_lambdaParameterList1907 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_dataType_in_lambdaParameter1922 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_lambdaParameter1925 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_lambdaStatement1938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_lambdaStatement1942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Func_in_functionPointerType1954 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_RelLessThan_in_functionPointerType1956 = new BitSet(new ulong[]{0x000007FFC0000000UL});
    public static readonly BitSet FOLLOW_dataTypeName_in_functionPointerType1958 = new BitSet(new ulong[]{0x0040000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_99_in_functionPointerType1962 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000003000000000UL});
    public static readonly BitSet FOLLOW_100_in_functionPointerType1966 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000003000000000UL});
    public static readonly BitSet FOLLOW_101_in_functionPointerType1971 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_RelGreaterThan_in_functionPointerType1976 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_97_in_block2029 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000045000FFEFFUL});
    public static readonly BitSet FOLLOW_statement_in_block2031 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000045000FFEFFUL});
    public static readonly BitSet FOLLOW_98_in_block2034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch2070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_branch2074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_statement2092 = new BitSet(new ulong[]{0x0000000008000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement2094 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_statement2096 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_Else_in_statement2106 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_statement2108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement2120 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_102_in_statement2126 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_forControl_in_statement2129 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_statement2131 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_statement2134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement2144 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_102_in_statement2150 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_foreachControl_in_statement2153 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_statement2155 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_statement2158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_statement2168 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_102_in_statement2170 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000041000FFEFFUL});
    public static readonly BitSet FOLLOW_loopControl_in_statement2173 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_103_in_statement2175 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_statement2178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_statement2188 = new BitSet(new ulong[]{0x0000000008000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement2190 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_statement2192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_statement2202 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_statement2204 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_While_in_statement2206 = new BitSet(new ulong[]{0x0000000008000000UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement2208 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_statement2210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement2221 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000420000003FUL});
    public static readonly BitSet FOLLOW_block_in_statement2223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement2233 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000410000003FUL});
    public static readonly BitSet FOLLOW_expression_in_statement2235 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_statement2238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement2249 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_statement2251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Continue_in_statement2262 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_statement2264 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_96_in_statement2275 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement2286 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_statement2288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_statement2297 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_statement2299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl2324 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_forControl2327 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000410000003FUL});
    public static readonly BitSet FOLLOW_expression_in_forControl2330 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000100000000UL});
    public static readonly BitSet FOLLOW_96_in_forControl2333 = new BitSet(new ulong[]{0xE30000000A000002UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl2336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit2356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate2375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_foreachControl2406 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_foreachControl2408 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_In_in_foreachControl2410 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_foreachControl2412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_loopControl2444 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_loopControl2446 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_To_in_loopControl2448 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_expression_in_loopControl2450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_synpred3_Psimulex250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred8_Psimulex469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred9_Psimulex487 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_Assign_in_synpred9_Psimulex489 = new BitSet(new ulong[]{0xE30000000A000000UL,0x000000400000003FUL});
    public static readonly BitSet FOLLOW_variableInitializer_in_synpred9_Psimulex491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typedIdentifierNonRef_in_synpred13_Psimulex651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred29_Psimulex977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_synpred30_Psimulex981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred58_Psimulex1452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred59_Psimulex1460 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_synpred66_Psimulex1642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Else_in_synpred83_Psimulex2106 = new BitSet(new ulong[]{0xE30007FFCA000000UL,0x00000043000FFEFFUL});
    public static readonly BitSet FOLLOW_branch_in_synpred83_Psimulex2108 = new BitSet(new ulong[]{0x0000000000000002UL});

}
