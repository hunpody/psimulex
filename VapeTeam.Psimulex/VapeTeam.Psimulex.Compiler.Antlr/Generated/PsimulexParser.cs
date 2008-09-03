// $ANTLR 3.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-09-03 14:17:28

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
		"Import", 
		"StringLiteral", 
		"Struct", 
		"Identifier", 
		"Assign", 
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
		"Reference", 
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
		"']'", 
		"','", 
		"'('", 
		"')'", 
		"'.'", 
		"'=>'"
    };

    public const int Stack = 19;
    public const int AssignAndAdd = 23;
    public const int NullLiteral = 48;
    public const int RelGreaterThanOrEqual = 35;
    public const int RelEqual = 30;
    public const int PQueue = 21;
    public const int SingleLineComment = 73;
    public const int CharacterLiteral = 46;
    public const int AssignAndSubstract = 24;
    public const int AssignAndDivide = 26;
    public const int AssignAndMultiply = 25;
    public const int While = 57;
    public const int Decimal = 12;
    public const int Modulo = 40;
    public const int IDLetter = 67;
    public const int EOF = -1;
    public const int Queue = 20;
    public const int Set = 17;
    public const int Identifier = 7;
    public const int Int = 11;
    public const int BinTree = 16;
    public const int Assign = 8;
    public const int To = 64;
    public const int PForEach = 55;
    public const int ForEach = 54;
    public const int Char = 10;
    public const int RelNotEqual = 31;
    public const int Do = 58;
    public const int RelGreaterThan = 34;
    public const int String = 13;
    public const int Return = 60;
    public const int Struct = 6;
    public const int Reference = 22;
    public const int AssignAndModulo = 27;
    public const int MultiLineComment = 74;
    public const int If = 50;
    public const int In = 63;
    public const int Bool = 9;
    public const int Import = 4;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int Continue = 62;
    public const int T__83 = 83;
    public const int Void = 14;
    public const int LogicalOr = 28;
    public const int LogicalAnd = 29;
    public const int PDo = 59;
    public const int ElseIf = 65;
    public const int Tree = 15;
    public const int Digit = 68;
    public const int DecimalLiteral = 45;
    public const int T__84 = 84;
    public const int For = 52;
    public const int Divide = 39;
    public const int List = 18;
    public const int StringLiteral = 5;
    public const int LogicalNot = 43;
    public const int Plus = 36;
    public const int Minus = 37;
    public const int WS = 72;
    public const int Break = 61;
    public const int RelLessThanOrEqual = 33;
    public const int MinusMinus = 42;
    public const int DecimalTypeSuffix = 70;
    public const int PFor = 53;
    public const int NotNullDigit = 69;
    public const int IntegerLiteral = 44;
    public const int RelLessThan = 32;
    public const int Star = 38;
    public const int T__76 = 76;
    public const int Else = 51;
    public const int T__75 = 75;
    public const int EscapeSequence = 71;
    public const int Letter = 66;
    public const int Loop = 56;
    public const int BooleanLiteral = 47;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int InfinityLiteral = 49;
    public const int PlusPlus = 41;
    public const int T__77 = 77;

    // delegates
    // delegators



        public PsimulexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PsimulexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
    		InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[174+1];
             
             
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:11:1: compilationUnit : ( simpleProgram | multiFunctionalProgram ) EOF ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:5: ( ( simpleProgram | multiFunctionalProgram ) EOF )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:7: ( simpleProgram | multiFunctionalProgram ) EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:7: ( simpleProgram | multiFunctionalProgram )
            	int alt1 = 2;
            	alt1 = dfa1.Predict(input);
            	switch (alt1) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:8: simpleProgram
            	        {
            	        	PushFollow(FOLLOW_simpleProgram_in_compilationUnit65);
            	        	simpleProgram1 = simpleProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:24: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit69);
            	        	multiFunctionalProgram2 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit72); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EOF3_tree = (CommonTree)adaptor.Create(EOF3);
            		adaptor.AddChild(root_0, EOF3_tree);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:15:1: simpleProgram : ( blockStatement )* ;
    public PsimulexParser.simpleProgram_return simpleProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.simpleProgram_return retval = new PsimulexParser.simpleProgram_return();
        retval.Start = input.LT(1);
        int simpleProgram_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.blockStatement_return blockStatement4 = default(PsimulexParser.blockStatement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:2: ( ( blockStatement )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:4: ( blockStatement )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:4: ( blockStatement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || (LA2_0 >= Bool && LA2_0 <= PQueue) || (LA2_0 >= Plus && LA2_0 <= Minus) || (LA2_0 >= PlusPlus && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= Continue) || LA2_0 == 75 || LA2_0 == 81) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: blockStatement
            			    {
            			    	PushFollow(FOLLOW_blockStatement_in_simpleProgram86);
            			    	blockStatement4 = blockStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement4.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:19:1: multiFunctionalProgram : ( importDeclaration )* ( typeDeclaration )* ( globalVariableDeclaration )* ( functionDeclaration )* ;
    public PsimulexParser.multiFunctionalProgram_return multiFunctionalProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.multiFunctionalProgram_return retval = new PsimulexParser.multiFunctionalProgram_return();
        retval.Start = input.LT(1);
        int multiFunctionalProgram_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.importDeclaration_return importDeclaration5 = default(PsimulexParser.importDeclaration_return);

        PsimulexParser.typeDeclaration_return typeDeclaration6 = default(PsimulexParser.typeDeclaration_return);

        PsimulexParser.globalVariableDeclaration_return globalVariableDeclaration7 = default(PsimulexParser.globalVariableDeclaration_return);

        PsimulexParser.functionDeclaration_return functionDeclaration8 = default(PsimulexParser.functionDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:2: ( ( importDeclaration )* ( typeDeclaration )* ( globalVariableDeclaration )* ( functionDeclaration )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:4: ( importDeclaration )* ( typeDeclaration )* ( globalVariableDeclaration )* ( functionDeclaration )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:4: ( importDeclaration )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == Import) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: importDeclaration
            			    {
            			    	PushFollow(FOLLOW_importDeclaration_in_multiFunctionalProgram98);
            			    	importDeclaration5 = importDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, importDeclaration5.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:21:6: ( typeDeclaration )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == Struct) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: typeDeclaration
            			    {
            			    	PushFollow(FOLLOW_typeDeclaration_in_multiFunctionalProgram106);
            			    	typeDeclaration6 = typeDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeDeclaration6.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:22:6: ( globalVariableDeclaration )*
            	do 
            	{
            	    int alt5 = 2;
            	    alt5 = dfa5.Predict(input);
            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: globalVariableDeclaration
            			    {
            			    	PushFollow(FOLLOW_globalVariableDeclaration_in_multiFunctionalProgram114);
            			    	globalVariableDeclaration7 = globalVariableDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalVariableDeclaration7.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:23:3: ( functionDeclaration )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == Identifier || (LA6_0 >= Bool && LA6_0 <= PQueue)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: functionDeclaration
            			    {
            			    	PushFollow(FOLLOW_functionDeclaration_in_multiFunctionalProgram119);
            			    	functionDeclaration8 = functionDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionDeclaration8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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

    public class globalVariableDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "globalVariableDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:26:1: globalVariableDeclaration : memberDeclaration ;
    public PsimulexParser.globalVariableDeclaration_return globalVariableDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.globalVariableDeclaration_return retval = new PsimulexParser.globalVariableDeclaration_return();
        retval.Start = input.LT(1);
        int globalVariableDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberDeclaration_return memberDeclaration9 = default(PsimulexParser.memberDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:27:2: ( memberDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:27:4: memberDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclaration131);
            	memberDeclaration9 = memberDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberDeclaration9.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, globalVariableDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "globalVariableDeclaration"

    public class importDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "importDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:1: importDeclaration : Import StringLiteral ';' ;
    public PsimulexParser.importDeclaration_return importDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.importDeclaration_return retval = new PsimulexParser.importDeclaration_return();
        retval.Start = input.LT(1);
        int importDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Import10 = null;
        IToken StringLiteral11 = null;
        IToken char_literal12 = null;

        CommonTree Import10_tree=null;
        CommonTree StringLiteral11_tree=null;
        CommonTree char_literal12_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:44:5: ( Import StringLiteral ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:44:9: Import StringLiteral ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Import10=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclaration160); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Import10_tree = (CommonTree)adaptor.Create(Import10);
            		adaptor.AddChild(root_0, Import10_tree);
            	}
            	StringLiteral11=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclaration162); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{StringLiteral11_tree = (CommonTree)adaptor.Create(StringLiteral11);
            		adaptor.AddChild(root_0, StringLiteral11_tree);
            	}
            	char_literal12=(IToken)Match(input,75,FOLLOW_75_in_importDeclaration164); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, importDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "importDeclaration"

    public class typeDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typeDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:1: typeDeclaration : structDeclaration ;
    public PsimulexParser.typeDeclaration_return typeDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.typeDeclaration_return retval = new PsimulexParser.typeDeclaration_return();
        retval.Start = input.LT(1);
        int typeDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.structDeclaration_return structDeclaration13 = default(PsimulexParser.structDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:48:5: ( structDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:48:9: structDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_structDeclaration_in_typeDeclaration184);
            	structDeclaration13 = structDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, structDeclaration13.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, typeDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typeDeclaration"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:51:1: structDeclaration : Struct Identifier structBody ;
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

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:52:5: ( Struct Identifier structBody )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:52:9: Struct Identifier structBody
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Struct14=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration203); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Struct14_tree = (CommonTree)adaptor.Create(Struct14);
            		adaptor.AddChild(root_0, Struct14_tree);
            	}
            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration205); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier15_tree = (CommonTree)adaptor.Create(Identifier15);
            		adaptor.AddChild(root_0, Identifier15_tree);
            	}
            	PushFollow(FOLLOW_structBody_in_structDeclaration207);
            	structBody16 = structBody();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, structBody16.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:55:1: structBody : '{' structBodyDeclaration '}' ;
    public PsimulexParser.structBody_return structBody() // throws RecognitionException [1]
    {   
        PsimulexParser.structBody_return retval = new PsimulexParser.structBody_return();
        retval.Start = input.LT(1);
        int structBody_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal17 = null;
        IToken char_literal19 = null;
        PsimulexParser.structBodyDeclaration_return structBodyDeclaration18 = default(PsimulexParser.structBodyDeclaration_return);


        CommonTree char_literal17_tree=null;
        CommonTree char_literal19_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:5: ( '{' structBodyDeclaration '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:9: '{' structBodyDeclaration '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,76,FOLLOW_76_in_structBody226); if (state.failed) return retval;
            	PushFollow(FOLLOW_structBodyDeclaration_in_structBody229);
            	structBodyDeclaration18 = structBodyDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, structBodyDeclaration18.Tree);
            	char_literal19=(IToken)Match(input,77,FOLLOW_77_in_structBody231); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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

    public class structBodyDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "structBodyDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:59:1: structBodyDeclaration : ( memberDeclaration )+ ;
    public PsimulexParser.structBodyDeclaration_return structBodyDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.structBodyDeclaration_return retval = new PsimulexParser.structBodyDeclaration_return();
        retval.Start = input.LT(1);
        int structBodyDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberDeclaration_return memberDeclaration20 = default(PsimulexParser.memberDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:5: ( ( memberDeclaration )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:9: ( memberDeclaration )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:9: ( memberDeclaration )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == Identifier || (LA7_0 >= Bool && LA7_0 <= PQueue)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBodyDeclaration251);
            			    	memberDeclaration20 = memberDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberDeclaration20.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(7, input);
            		            throw eee;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, structBodyDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "structBodyDeclaration"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:1: memberDeclaration : type fieldDeclaration ;
    public PsimulexParser.memberDeclaration_return memberDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.memberDeclaration_return retval = new PsimulexParser.memberDeclaration_return();
        retval.Start = input.LT(1);
        int memberDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.type_return type21 = default(PsimulexParser.type_return);

        PsimulexParser.fieldDeclaration_return fieldDeclaration22 = default(PsimulexParser.fieldDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:5: ( type fieldDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:9: type fieldDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_memberDeclaration271);
            	type21 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type21.Tree);
            	PushFollow(FOLLOW_fieldDeclaration_in_memberDeclaration273);
            	fieldDeclaration22 = fieldDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fieldDeclaration22.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, memberDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberDeclaration"

    public class fieldDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "fieldDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:1: fieldDeclaration : variableDeclaratorId ( Assign literal )? ';' ;
    public PsimulexParser.fieldDeclaration_return fieldDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.fieldDeclaration_return retval = new PsimulexParser.fieldDeclaration_return();
        retval.Start = input.LT(1);
        int fieldDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Assign24 = null;
        IToken char_literal26 = null;
        PsimulexParser.variableDeclaratorId_return variableDeclaratorId23 = default(PsimulexParser.variableDeclaratorId_return);

        PsimulexParser.literal_return literal25 = default(PsimulexParser.literal_return);


        CommonTree Assign24_tree=null;
        CommonTree char_literal26_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:68:5: ( variableDeclaratorId ( Assign literal )? ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:68:9: variableDeclaratorId ( Assign literal )? ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaratorId_in_fieldDeclaration292);
            	variableDeclaratorId23 = variableDeclaratorId();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaratorId23.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:68:30: ( Assign literal )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == Assign) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:68:31: Assign literal
            	        {
            	        	Assign24=(IToken)Match(input,Assign,FOLLOW_Assign_in_fieldDeclaration295); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Assign24_tree = (CommonTree)adaptor.Create(Assign24);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(Assign24_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_literal_in_fieldDeclaration298);
            	        	literal25 = literal();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal25.Tree);

            	        }
            	        break;

            	}

            	char_literal26=(IToken)Match(input,75,FOLLOW_75_in_fieldDeclaration303); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, fieldDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "fieldDeclaration"

    public class variableDeclarator_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variableDeclarator"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:71:1: variableDeclarator : variableDeclaratorId ( Assign variableInitializer )? ;
    public PsimulexParser.variableDeclarator_return variableDeclarator() // throws RecognitionException [1]
    {   
        PsimulexParser.variableDeclarator_return retval = new PsimulexParser.variableDeclarator_return();
        retval.Start = input.LT(1);
        int variableDeclarator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Assign28 = null;
        PsimulexParser.variableDeclaratorId_return variableDeclaratorId27 = default(PsimulexParser.variableDeclaratorId_return);

        PsimulexParser.variableInitializer_return variableInitializer29 = default(PsimulexParser.variableInitializer_return);


        CommonTree Assign28_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:5: ( variableDeclaratorId ( Assign variableInitializer )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:9: variableDeclaratorId ( Assign variableInitializer )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaratorId_in_variableDeclarator323);
            	variableDeclaratorId27 = variableDeclaratorId();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaratorId27.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:30: ( Assign variableInitializer )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == Assign) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:31: Assign variableInitializer
            	        {
            	        	Assign28=(IToken)Match(input,Assign,FOLLOW_Assign_in_variableDeclarator326); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Assign28_tree = (CommonTree)adaptor.Create(Assign28);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(Assign28_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_variableInitializer_in_variableDeclarator329);
            	        	variableInitializer29 = variableInitializer();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableInitializer29.Tree);

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
            	Memoize(input, 12, variableDeclarator_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableDeclarator"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:75:1: functionDeclaration : type Identifier formalParameters block ;
    public PsimulexParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclaration_return retval = new PsimulexParser.functionDeclaration_return();
        retval.Start = input.LT(1);
        int functionDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier31 = null;
        PsimulexParser.type_return type30 = default(PsimulexParser.type_return);

        PsimulexParser.formalParameters_return formalParameters32 = default(PsimulexParser.formalParameters_return);

        PsimulexParser.block_return block33 = default(PsimulexParser.block_return);


        CommonTree Identifier31_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:76:5: ( type Identifier formalParameters block )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:76:7: type Identifier formalParameters block
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_functionDeclaration348);
            	type30 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type30.Tree);
            	Identifier31=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration350); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier31_tree = (CommonTree)adaptor.Create(Identifier31);
            		adaptor.AddChild(root_0, Identifier31_tree);
            	}
            	PushFollow(FOLLOW_formalParameters_in_functionDeclaration352);
            	formalParameters32 = formalParameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameters32.Tree);
            	PushFollow(FOLLOW_block_in_functionDeclaration354);
            	block33 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block33.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, functionDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionDeclaration"

    public class variableDeclaratorId_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "variableDeclaratorId"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:79:1: variableDeclaratorId : Identifier ( '[' ']' | '[' ',' ']' )? ;
    public PsimulexParser.variableDeclaratorId_return variableDeclaratorId() // throws RecognitionException [1]
    {   
        PsimulexParser.variableDeclaratorId_return retval = new PsimulexParser.variableDeclaratorId_return();
        retval.Start = input.LT(1);
        int variableDeclaratorId_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier34 = null;
        IToken char_literal35 = null;
        IToken char_literal36 = null;
        IToken char_literal37 = null;
        IToken char_literal38 = null;
        IToken char_literal39 = null;

        CommonTree Identifier34_tree=null;
        CommonTree char_literal35_tree=null;
        CommonTree char_literal36_tree=null;
        CommonTree char_literal37_tree=null;
        CommonTree char_literal38_tree=null;
        CommonTree char_literal39_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:5: ( Identifier ( '[' ']' | '[' ',' ']' )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:9: Identifier ( '[' ']' | '[' ',' ']' )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier34=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableDeclaratorId381); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier34_tree = (CommonTree)adaptor.Create(Identifier34);
            		adaptor.AddChild(root_0, Identifier34_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:20: ( '[' ']' | '[' ',' ']' )?
            	int alt10 = 3;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 78) )
            	{
            	    int LA10_1 = input.LA(2);

            	    if ( (LA10_1 == 79) )
            	    {
            	        alt10 = 1;
            	    }
            	    else if ( (LA10_1 == 80) )
            	    {
            	        alt10 = 2;
            	    }
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:21: '[' ']'
            	        {
            	        	char_literal35=(IToken)Match(input,78,FOLLOW_78_in_variableDeclaratorId384); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal35_tree = (CommonTree)adaptor.Create(char_literal35);
            	        		adaptor.AddChild(root_0, char_literal35_tree);
            	        	}
            	        	char_literal36=(IToken)Match(input,79,FOLLOW_79_in_variableDeclaratorId386); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal36_tree = (CommonTree)adaptor.Create(char_literal36);
            	        		adaptor.AddChild(root_0, char_literal36_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:29: '[' ',' ']'
            	        {
            	        	char_literal37=(IToken)Match(input,78,FOLLOW_78_in_variableDeclaratorId388); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal37_tree = (CommonTree)adaptor.Create(char_literal37);
            	        		adaptor.AddChild(root_0, char_literal37_tree);
            	        	}
            	        	char_literal38=(IToken)Match(input,80,FOLLOW_80_in_variableDeclaratorId390); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal38_tree = (CommonTree)adaptor.Create(char_literal38);
            	        		adaptor.AddChild(root_0, char_literal38_tree);
            	        	}
            	        	char_literal39=(IToken)Match(input,79,FOLLOW_79_in_variableDeclaratorId392); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal39_tree = (CommonTree)adaptor.Create(char_literal39);
            	        		adaptor.AddChild(root_0, char_literal39_tree);
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
            	Memoize(input, 14, variableDeclaratorId_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableDeclaratorId"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:83:1: variableInitializer : expression ;
    public PsimulexParser.variableInitializer_return variableInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.variableInitializer_return retval = new PsimulexParser.variableInitializer_return();
        retval.Start = input.LT(1);
        int variableInitializer_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression40 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_variableInitializer413);
            	expression40 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression40.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, variableInitializer_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableInitializer"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:1: type : ( dataType | functionPointerType );
    public PsimulexParser.type_return type() // throws RecognitionException [1]
    {   
        PsimulexParser.type_return retval = new PsimulexParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataType_return dataType41 = default(PsimulexParser.dataType_return);

        PsimulexParser.functionPointerType_return functionPointerType42 = default(PsimulexParser.functionPointerType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:5: ( dataType | functionPointerType )
            int alt11 = 2;
            alt11 = dfa11.Predict(input);
            switch (alt11) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:7: dataType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dataType_in_type443);
                    	dataType41 = dataType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType41.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:95:7: functionPointerType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionPointerType_in_type451);
                    	functionPointerType42 = functionPointerType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionPointerType42.Tree);

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
            	Memoize(input, 16, type_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:98:1: dataType : ( primitiveType | builtInType ) ( '[' ']' | '[' ',' ']' )? ;
    public PsimulexParser.dataType_return dataType() // throws RecognitionException [1]
    {   
        PsimulexParser.dataType_return retval = new PsimulexParser.dataType_return();
        retval.Start = input.LT(1);
        int dataType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal46 = null;
        IToken char_literal47 = null;
        IToken char_literal48 = null;
        IToken char_literal49 = null;
        PsimulexParser.primitiveType_return primitiveType43 = default(PsimulexParser.primitiveType_return);

        PsimulexParser.builtInType_return builtInType44 = default(PsimulexParser.builtInType_return);


        CommonTree char_literal45_tree=null;
        CommonTree char_literal46_tree=null;
        CommonTree char_literal47_tree=null;
        CommonTree char_literal48_tree=null;
        CommonTree char_literal49_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:2: ( ( primitiveType | builtInType ) ( '[' ']' | '[' ',' ']' )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:4: ( primitiveType | builtInType ) ( '[' ']' | '[' ',' ']' )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:4: ( primitiveType | builtInType )
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( ((LA12_0 >= Bool && LA12_0 <= Void)) )
            	{
            	    alt12 = 1;
            	}
            	else if ( ((LA12_0 >= Tree && LA12_0 <= PQueue)) )
            	{
            	    alt12 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("", 12, 0, input);

            	    throw nvae_d12s0;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:6: primitiveType
            	        {
            	        	PushFollow(FOLLOW_primitiveType_in_dataType467);
            	        	primitiveType43 = primitiveType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType43.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:22: builtInType
            	        {
            	        	PushFollow(FOLLOW_builtInType_in_dataType471);
            	        	builtInType44 = builtInType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType44.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:36: ( '[' ']' | '[' ',' ']' )?
            	int alt13 = 3;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 78) )
            	{
            	    int LA13_1 = input.LA(2);

            	    if ( (LA13_1 == 79) )
            	    {
            	        alt13 = 1;
            	    }
            	    else if ( (LA13_1 == 80) )
            	    {
            	        alt13 = 2;
            	    }
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:38: '[' ']'
            	        {
            	        	char_literal45=(IToken)Match(input,78,FOLLOW_78_in_dataType477); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal45_tree = (CommonTree)adaptor.Create(char_literal45);
            	        		adaptor.AddChild(root_0, char_literal45_tree);
            	        	}
            	        	char_literal46=(IToken)Match(input,79,FOLLOW_79_in_dataType479); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal46_tree = (CommonTree)adaptor.Create(char_literal46);
            	        		adaptor.AddChild(root_0, char_literal46_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:48: '[' ',' ']'
            	        {
            	        	char_literal47=(IToken)Match(input,78,FOLLOW_78_in_dataType483); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal47_tree = (CommonTree)adaptor.Create(char_literal47);
            	        		adaptor.AddChild(root_0, char_literal47_tree);
            	        	}
            	        	char_literal48=(IToken)Match(input,80,FOLLOW_80_in_dataType485); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal48_tree = (CommonTree)adaptor.Create(char_literal48);
            	        		adaptor.AddChild(root_0, char_literal48_tree);
            	        	}
            	        	char_literal49=(IToken)Match(input,79,FOLLOW_79_in_dataType487); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal49_tree = (CommonTree)adaptor.Create(char_literal49);
            	        		adaptor.AddChild(root_0, char_literal49_tree);
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
            	Memoize(input, 17, dataType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "dataType"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:1: primitiveType : ( Bool | Char | Int | Decimal | String | Void );
    public PsimulexParser.primitiveType_return primitiveType() // throws RecognitionException [1]
    {   
        PsimulexParser.primitiveType_return retval = new PsimulexParser.primitiveType_return();
        retval.Start = input.LT(1);
        int primitiveType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set50 = null;

        CommonTree set50_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:5: ( Bool | Char | Int | Decimal | String | Void )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set50 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Bool && input.LA(1) <= Void) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set50));
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
            	Memoize(input, 18, primitiveType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:1: builtInType : ( Tree | BinTree | Set | List | Stack | Queue | PQueue );
    public PsimulexParser.builtInType_return builtInType() // throws RecognitionException [1]
    {   
        PsimulexParser.builtInType_return retval = new PsimulexParser.builtInType_return();
        retval.Start = input.LT(1);
        int builtInType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set51 = null;

        CommonTree set51_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:113:5: ( Tree | BinTree | Set | List | Stack | Queue | PQueue )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set51 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= PQueue) ) 
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

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, builtInType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "builtInType"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:1: formalParameters : '(' ( formalParameterDecls )? ')' ;
    public PsimulexParser.formalParameters_return formalParameters() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameters_return retval = new PsimulexParser.formalParameters_return();
        retval.Start = input.LT(1);
        int formalParameters_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal52 = null;
        IToken char_literal54 = null;
        PsimulexParser.formalParameterDecls_return formalParameterDecls53 = default(PsimulexParser.formalParameterDecls_return);


        CommonTree char_literal52_tree=null;
        CommonTree char_literal54_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:5: ( '(' ( formalParameterDecls )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:9: '(' ( formalParameterDecls )? ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal52=(IToken)Match(input,81,FOLLOW_81_in_formalParameters615); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:14: ( formalParameterDecls )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == Identifier || (LA14_0 >= Bool && LA14_0 <= PQueue)) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: formalParameterDecls
            	        {
            	        	PushFollow(FOLLOW_formalParameterDecls_in_formalParameters618);
            	        	formalParameterDecls53 = formalParameterDecls();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDecls53.Tree);

            	        }
            	        break;

            	}

            	char_literal54=(IToken)Match(input,82,FOLLOW_82_in_formalParameters621); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, formalParameters_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameters"

    public class formalParameterDecls_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "formalParameterDecls"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:1: formalParameterDecls : type ( Reference )? formalParameterDeclsRest ;
    public PsimulexParser.formalParameterDecls_return formalParameterDecls() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameterDecls_return retval = new PsimulexParser.formalParameterDecls_return();
        retval.Start = input.LT(1);
        int formalParameterDecls_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference56 = null;
        PsimulexParser.type_return type55 = default(PsimulexParser.type_return);

        PsimulexParser.formalParameterDeclsRest_return formalParameterDeclsRest57 = default(PsimulexParser.formalParameterDeclsRest_return);


        CommonTree Reference56_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:5: ( type ( Reference )? formalParameterDeclsRest )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:9: type ( Reference )? formalParameterDeclsRest
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_formalParameterDecls645);
            	type55 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type55.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:14: ( Reference )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == Reference) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:15: Reference
            	        {
            	        	Reference56=(IToken)Match(input,Reference,FOLLOW_Reference_in_formalParameterDecls648); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Reference56_tree = (CommonTree)adaptor.Create(Reference56);
            	        		adaptor.AddChild(root_0, Reference56_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_formalParameterDeclsRest_in_formalParameterDecls652);
            	formalParameterDeclsRest57 = formalParameterDeclsRest();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDeclsRest57.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, formalParameterDecls_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameterDecls"

    public class formalParameterDeclsRest_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "formalParameterDeclsRest"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:1: formalParameterDeclsRest : variableDeclaratorId ( ',' formalParameterDecls )? ;
    public PsimulexParser.formalParameterDeclsRest_return formalParameterDeclsRest() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameterDeclsRest_return retval = new PsimulexParser.formalParameterDeclsRest_return();
        retval.Start = input.LT(1);
        int formalParameterDeclsRest_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal59 = null;
        PsimulexParser.variableDeclaratorId_return variableDeclaratorId58 = default(PsimulexParser.variableDeclaratorId_return);

        PsimulexParser.formalParameterDecls_return formalParameterDecls60 = default(PsimulexParser.formalParameterDecls_return);


        CommonTree char_literal59_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:5: ( variableDeclaratorId ( ',' formalParameterDecls )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:9: variableDeclaratorId ( ',' formalParameterDecls )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaratorId_in_formalParameterDeclsRest675);
            	variableDeclaratorId58 = variableDeclaratorId();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaratorId58.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:30: ( ',' formalParameterDecls )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 80) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:31: ',' formalParameterDecls
            	        {
            	        	char_literal59=(IToken)Match(input,80,FOLLOW_80_in_formalParameterDeclsRest678); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_formalParameterDecls_in_formalParameterDeclsRest681);
            	        	formalParameterDecls60 = formalParameterDecls();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDecls60.Tree);

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
            	Memoize(input, 22, formalParameterDeclsRest_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameterDeclsRest"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:143:1: expression : ( assignment | conditionalOrExpression | lambdaExpression );
    public PsimulexParser.expression_return expression() // throws RecognitionException [1]
    {   
        PsimulexParser.expression_return retval = new PsimulexParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.assignment_return assignment61 = default(PsimulexParser.assignment_return);

        PsimulexParser.conditionalOrExpression_return conditionalOrExpression62 = default(PsimulexParser.conditionalOrExpression_return);

        PsimulexParser.lambdaExpression_return lambdaExpression63 = default(PsimulexParser.lambdaExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:2: ( assignment | conditionalOrExpression | lambdaExpression )
            int alt17 = 3;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                int LA17_1 = input.LA(2);

                if ( (synpred30_Psimulex()) )
                {
                    alt17 = 1;
                }
                else if ( (synpred31_Psimulex()) )
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
            case 81:
            	{
                int LA17_2 = input.LA(2);

                if ( (synpred30_Psimulex()) )
                {
                    alt17 = 1;
                }
                else if ( (synpred31_Psimulex()) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expression705);
                    	assignment61 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment61.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:4: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_expression710);
                    	conditionalOrExpression62 = conditionalOrExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression62.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:146:4: lambdaExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lambdaExpression_in_expression715);
                    	lambdaExpression63 = lambdaExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaExpression63.Tree);

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
            	Memoize(input, 23, expression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:1: assignment : leftValue assignmentOperator expression ;
    public PsimulexParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        PsimulexParser.assignment_return retval = new PsimulexParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue64 = default(PsimulexParser.leftValue_return);

        PsimulexParser.assignmentOperator_return assignmentOperator65 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.expression_return expression66 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:150:2: ( leftValue assignmentOperator expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:150:4: leftValue assignmentOperator expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_leftValue_in_assignment727);
            	leftValue64 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue64.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment729);
            	assignmentOperator65 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assignmentOperator65.Tree, root_0);
            	PushFollow(FOLLOW_expression_in_assignment732);
            	expression66 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression66.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, assignment_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:1: assignmentOperator : ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo );
    public PsimulexParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        PsimulexParser.assignmentOperator_return retval = new PsimulexParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set67 = null;

        CommonTree set67_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:154:2: ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set67 = (IToken)input.LT(1);
            	if ( input.LA(1) == Assign || (input.LA(1) >= AssignAndAdd && input.LA(1) <= AssignAndModulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set67));
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
            	Memoize(input, 25, assignmentOperator_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:1: conditionalOrExpression : conditionalAndExpression ( LogicalOr conditionalAndExpression )* ;
    public PsimulexParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalOrExpression_return retval = new PsimulexParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalOr69 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression68 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression70 = default(PsimulexParser.conditionalAndExpression_return);


        CommonTree LogicalOr69_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:5: ( conditionalAndExpression ( LogicalOr conditionalAndExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:9: conditionalAndExpression ( LogicalOr conditionalAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression773);
            	conditionalAndExpression68 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression68.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:34: ( LogicalOr conditionalAndExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:158:36: LogicalOr conditionalAndExpression
            			    {
            			    	LogicalOr69=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression777); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalOr69_tree = (CommonTree)adaptor.Create(LogicalOr69);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalOr69_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression780);
            			    	conditionalAndExpression70 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression70.Tree);

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
            	Memoize(input, 26, conditionalOrExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:1: conditionalAndExpression : equalityExpression ( LogicalAnd equalityExpression )* ;
    public PsimulexParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalAndExpression_return retval = new PsimulexParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalAnd72 = null;
        PsimulexParser.equalityExpression_return equalityExpression71 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression73 = default(PsimulexParser.equalityExpression_return);


        CommonTree LogicalAnd72_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:5: ( equalityExpression ( LogicalAnd equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:9: equalityExpression ( LogicalAnd equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression802);
            	equalityExpression71 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression71.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:28: ( LogicalAnd equalityExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:30: LogicalAnd equalityExpression
            			    {
            			    	LogicalAnd72=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression806); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd72_tree = (CommonTree)adaptor.Create(LogicalAnd72);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd72_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression809);
            			    	equalityExpression73 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression73.Tree);

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
            	Memoize(input, 27, conditionalAndExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:1: equalityExpression : relationalExpression ( ( equalityOp ) relationalExpression )* ;
    public PsimulexParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityExpression_return retval = new PsimulexParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.relationalExpression_return relationalExpression74 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.equalityOp_return equalityOp75 = default(PsimulexParser.equalityOp_return);

        PsimulexParser.relationalExpression_return relationalExpression76 = default(PsimulexParser.relationalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:5: ( relationalExpression ( ( equalityOp ) relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:9: relationalExpression ( ( equalityOp ) relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression831);
            	relationalExpression74 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression74.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:30: ( ( equalityOp ) relationalExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:32: ( equalityOp ) relationalExpression
            			    {
            			    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:32: ( equalityOp )
            			    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:34: equalityOp
            			    	{
            			    		PushFollow(FOLLOW_equalityOp_in_equalityExpression837);
            			    		equalityOp75 = equalityOp();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp75.Tree, root_0);

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression842);
            			    	relationalExpression76 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression76.Tree);

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
            	Memoize(input, 28, equalityExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:169:1: equalityOp : ( RelEqual | RelNotEqual );
    public PsimulexParser.equalityOp_return equalityOp() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityOp_return retval = new PsimulexParser.equalityOp_return();
        retval.Start = input.LT(1);
        int equalityOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set77 = null;

        CommonTree set77_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:2: ( RelEqual | RelNotEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set77 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelEqual && input.LA(1) <= RelNotEqual) ) 
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

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 29, equalityOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
    public PsimulexParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalExpression_return retval = new PsimulexParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.additiveExpression_return additiveExpression78 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp79 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression80 = default(PsimulexParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression877);
            	additiveExpression78 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression78.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:28: ( relationalOp additiveExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression881);
            			    	relationalOp79 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp79.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression884);
            			    	additiveExpression80 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression80.Tree);

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
            	Memoize(input, 30, relationalExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:177:1: relationalOp : ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual );
    public PsimulexParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalOp_return retval = new PsimulexParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set81 = null;

        CommonTree set81_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:5: ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set81 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelLessThan && input.LA(1) <= RelGreaterThanOrEqual) ) 
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

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 31, relationalOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:1: additiveExpression : multiplicativeExpression ( additiveOp multiplicativeExpression )* ;
    public PsimulexParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveExpression_return retval = new PsimulexParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression82 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.additiveOp_return additiveOp83 = default(PsimulexParser.additiveOp_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression84 = default(PsimulexParser.multiplicativeExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:5: ( multiplicativeExpression ( additiveOp multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:9: multiplicativeExpression ( additiveOp multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression938);
            	multiplicativeExpression82 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression82.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:34: ( additiveOp multiplicativeExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:36: additiveOp multiplicativeExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression942);
            			    	additiveOp83 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp83.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression945);
            			    	multiplicativeExpression84 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression84.Tree);

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
            	Memoize(input, 32, additiveExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:1: additiveOp : ( Plus | Minus );
    public PsimulexParser.additiveOp_return additiveOp() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveOp_return retval = new PsimulexParser.additiveOp_return();
        retval.Start = input.LT(1);
        int additiveOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set85 = null;

        CommonTree set85_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:186:2: ( Plus | Minus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set85 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set85));
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
            	Memoize(input, 33, additiveOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:1: multiplicativeExpression : unaryExpression ( multiplicativeOp unaryExpression )* ;
    public PsimulexParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeExpression_return retval = new PsimulexParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryExpression_return unaryExpression86 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.multiplicativeOp_return multiplicativeOp87 = default(PsimulexParser.multiplicativeOp_return);

        PsimulexParser.unaryExpression_return unaryExpression88 = default(PsimulexParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:5: ( unaryExpression ( multiplicativeOp unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:9: unaryExpression ( multiplicativeOp unaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression980);
            	unaryExpression86 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression86.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:25: ( multiplicativeOp unaryExpression )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:27: multiplicativeOp unaryExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression984);
            			    	multiplicativeOp87 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp87.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression987);
            			    	unaryExpression88 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression88.Tree);

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
            	Memoize(input, 34, multiplicativeExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:1: multiplicativeOp : ( Star | Divide | Modulo );
    public PsimulexParser.multiplicativeOp_return multiplicativeOp() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeOp_return retval = new PsimulexParser.multiplicativeOp_return();
        retval.Start = input.LT(1);
        int multiplicativeOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set89 = null;

        CommonTree set89_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:2: ( Star | Divide | Modulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set89 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Star && input.LA(1) <= Modulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set89));
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
            	Memoize(input, 35, multiplicativeOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:1: unaryExpression : ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? );
    public PsimulexParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpression_return retval = new PsimulexParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixOp_return unaryPrefixOp90 = default(PsimulexParser.unaryPrefixOp_return);

        PsimulexParser.unaryExpression_return unaryExpression91 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.primaryExpression_return primaryExpression92 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp93 = default(PsimulexParser.unaryPostfixOp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:5: ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? )
            int alt25 = 2;
            int LA25_0 = input.LA(1);

            if ( ((LA25_0 >= Plus && LA25_0 <= Minus) || (LA25_0 >= PlusPlus && LA25_0 <= LogicalNot)) )
            {
                alt25 = 1;
            }
            else if ( (LA25_0 == StringLiteral || LA25_0 == Identifier || (LA25_0 >= IntegerLiteral && LA25_0 <= InfinityLiteral) || LA25_0 == 81) )
            {
                alt25 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d25s0 =
                    new NoViableAltException("", 25, 0, input);

                throw nvae_d25s0;
            }
            switch (alt25) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:7: unaryPrefixOp unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPrefixOp_in_unaryExpression1022);
                    	unaryPrefixOp90 = unaryPrefixOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPrefixOp90.Tree, root_0);
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1025);
                    	unaryExpression91 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression91.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:199:7: primaryExpression ( unaryPostfixOp )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression1033);
                    	primaryExpression92 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression92.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:199:25: ( unaryPostfixOp )?
                    	int alt24 = 2;
                    	int LA24_0 = input.LA(1);

                    	if ( ((LA24_0 >= PlusPlus && LA24_0 <= MinusMinus)) )
                    	{
                    	    alt24 = 1;
                    	}
                    	switch (alt24) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:199:26: unaryPostfixOp
                    	        {
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpression1036);
                    	        	unaryPostfixOp93 = unaryPostfixOp();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp93.Tree, root_0);

                    	        }
                    	        break;

                    	}


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
            	Memoize(input, 36, unaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:1: unaryPrefixOp : ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot );
    public PsimulexParser.unaryPrefixOp_return unaryPrefixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixOp_return retval = new PsimulexParser.unaryPrefixOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set94 = null;

        CommonTree set94_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:203:2: ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set94 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) || (input.LA(1) >= PlusPlus && input.LA(1) <= LogicalNot) ) 
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
            	Memoize(input, 37, unaryPrefixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:1: unaryPostfixOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPostfixOp_return unaryPostfixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixOp_return retval = new PsimulexParser.unaryPostfixOp_return();
        retval.Start = input.LT(1);
        int unaryPostfixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set95 = null;

        CommonTree set95_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:207:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set95 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set95));
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
            	Memoize(input, 38, unaryPostfixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:1: unaryExpressionPostPlusPlusMinusMinus : primaryExpression ( unaryPostfixOp )* ;
    public PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return unaryExpressionPostPlusPlusMinusMinus() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return retval = new PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return();
        retval.Start = input.LT(1);
        int unaryExpressionPostPlusPlusMinusMinus_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primaryExpression_return primaryExpression96 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp97 = default(PsimulexParser.unaryPostfixOp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:5: ( primaryExpression ( unaryPostfixOp )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:9: primaryExpression ( unaryPostfixOp )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1091);
            	primaryExpression96 = primaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression96.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:27: ( unaryPostfixOp )*
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
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:28: unaryPostfixOp
            			    {
            			    	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1094);
            			    	unaryPostfixOp97 = unaryPostfixOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp97.Tree, root_0);

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
            	Memoize(input, 39, unaryExpressionPostPlusPlusMinusMinus_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:1: primaryExpression : ( parExpression | leftValue | literal );
    public PsimulexParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.primaryExpression_return retval = new PsimulexParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression98 = default(PsimulexParser.parExpression_return);

        PsimulexParser.leftValue_return leftValue99 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal100 = default(PsimulexParser.literal_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:215:5: ( parExpression | leftValue | literal )
            int alt27 = 3;
            switch ( input.LA(1) ) 
            {
            case 81:
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
                alt27 = 2;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:215:9: parExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1116);
                    	parExpression98 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression98.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:216:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1124);
                    	leftValue99 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue99.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1134);
                    	literal100 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal100.Tree);

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
            	Memoize(input, 40, primaryExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:220:1: parExpression : '(' expression ')' ;
    public PsimulexParser.parExpression_return parExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.parExpression_return retval = new PsimulexParser.parExpression_return();
        retval.Start = input.LT(1);
        int parExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal101 = null;
        IToken char_literal103 = null;
        PsimulexParser.expression_return expression102 = default(PsimulexParser.expression_return);


        CommonTree char_literal101_tree=null;
        CommonTree char_literal103_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:5: ( '(' expression ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:9: '(' expression ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal101=(IToken)Match(input,81,FOLLOW_81_in_parExpression1153); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1156);
            	expression102 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression102.Tree);
            	char_literal103=(IToken)Match(input,82,FOLLOW_82_in_parExpression1158); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 41, parExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:224:1: leftValue : ( variable | selecting );
    public PsimulexParser.leftValue_return leftValue() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValue_return retval = new PsimulexParser.leftValue_return();
        retval.Start = input.LT(1);
        int leftValue_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.variable_return variable104 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting105 = default(PsimulexParser.selecting_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:2: ( variable | selecting )
            int alt28 = 2;
            int LA28_0 = input.LA(1);

            if ( (LA28_0 == Identifier) )
            {
                int LA28_1 = input.LA(2);

                if ( (LA28_1 == 78 || LA28_1 == 83) )
                {
                    alt28 = 2;
                }
                else if ( (LA28_1 == EOF || LA28_1 == Assign || (LA28_1 >= AssignAndAdd && LA28_1 <= MinusMinus) || LA28_1 == 75 || (LA28_1 >= 79 && LA28_1 <= 80) || LA28_1 == 82) )
                {
                    alt28 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d28s1 =
                        new NoViableAltException("", 28, 1, input);

                    throw nvae_d28s1;
                }
            }
            else if ( (LA28_0 == 81) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1173);
                    	variable104 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable104.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:226:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1178);
                    	selecting105 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting105.Tree);

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
            	Memoize(input, 42, leftValue_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:1: variable : Identifier ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier106 = null;

        CommonTree Identifier106_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier106=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1189); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier106_tree = (CommonTree)adaptor.Create(Identifier106);
            		adaptor.AddChild(root_0, Identifier106_tree);
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
            	Memoize(input, 43, variable_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:1: selecting : ( Identifier | parExpression ) ( selector )+ ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier107 = null;
        PsimulexParser.parExpression_return parExpression108 = default(PsimulexParser.parExpression_return);

        PsimulexParser.selector_return selector109 = default(PsimulexParser.selector_return);


        CommonTree Identifier107_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:2: ( ( Identifier | parExpression ) ( selector )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:4: ( Identifier | parExpression ) ( selector )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:4: ( Identifier | parExpression )
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == Identifier) )
            	{
            	    alt29 = 1;
            	}
            	else if ( (LA29_0 == 81) )
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:5: Identifier
            	        {
            	        	Identifier107=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selecting1201); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier107_tree = (CommonTree)adaptor.Create(Identifier107);
            	        		adaptor.AddChild(root_0, Identifier107_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:16: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selecting1203);
            	        	parExpression108 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression108.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:31: ( selector )+
            	int cnt30 = 0;
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == 78 || LA30_0 == 83) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: selector
            			    {
            			    	PushFollow(FOLLOW_selector_in_selecting1206);
            			    	selector109 = selector();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selector109.Tree);

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
            	Memoize(input, 44, selecting_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:1: selector : ( memberSelect | memberFunctionCall | indexing );
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberSelect_return memberSelect110 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall111 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing112 = default(PsimulexParser.indexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:238:5: ( memberSelect | memberFunctionCall | indexing )
            int alt31 = 3;
            int LA31_0 = input.LA(1);

            if ( (LA31_0 == 83) )
            {
                int LA31_1 = input.LA(2);

                if ( (LA31_1 == Identifier) )
                {
                    int LA31_3 = input.LA(3);

                    if ( (LA31_3 == 81) )
                    {
                        alt31 = 2;
                    }
                    else if ( (LA31_3 == EOF || LA31_3 == Assign || (LA31_3 >= AssignAndAdd && LA31_3 <= MinusMinus) || LA31_3 == 75 || (LA31_3 >= 78 && LA31_3 <= 80) || (LA31_3 >= 82 && LA31_3 <= 83)) )
                    {
                        alt31 = 1;
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
            else if ( (LA31_0 == 78) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:238:9: memberSelect
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberSelect_in_selector1223);
                    	memberSelect110 = memberSelect();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect110.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:239:9: memberFunctionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberFunctionCall_in_selector1233);
                    	memberFunctionCall111 = memberFunctionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall111.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:240:9: indexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_indexing_in_selector1243);
                    	indexing112 = indexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing112.Tree);

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
            	Memoize(input, 45, selector_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:243:1: memberSelect : '.' Identifier ;
    public PsimulexParser.memberSelect_return memberSelect() // throws RecognitionException [1]
    {   
        PsimulexParser.memberSelect_return retval = new PsimulexParser.memberSelect_return();
        retval.Start = input.LT(1);
        int memberSelect_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal113 = null;
        IToken Identifier114 = null;

        CommonTree char_literal113_tree=null;
        CommonTree Identifier114_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:244:2: ( '.' Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:244:4: '.' Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal113=(IToken)Match(input,83,FOLLOW_83_in_memberSelect1257); if (state.failed) return retval;
            	Identifier114=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect1260); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier114_tree = (CommonTree)adaptor.Create(Identifier114);
            		adaptor.AddChild(root_0, Identifier114_tree);
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
            	Memoize(input, 46, memberSelect_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:247:1: memberFunctionCall : '.' Identifier arguments ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal115 = null;
        IToken Identifier116 = null;
        PsimulexParser.arguments_return arguments117 = default(PsimulexParser.arguments_return);


        CommonTree char_literal115_tree=null;
        CommonTree Identifier116_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:248:2: ( '.' Identifier arguments )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:248:4: '.' Identifier arguments
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal115=(IToken)Match(input,83,FOLLOW_83_in_memberFunctionCall1271); if (state.failed) return retval;
            	Identifier116=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall1274); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier116_tree = (CommonTree)adaptor.Create(Identifier116);
            		adaptor.AddChild(root_0, Identifier116_tree);
            	}
            	PushFollow(FOLLOW_arguments_in_memberFunctionCall1276);
            	arguments117 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments117.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 47, memberFunctionCall_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberFunctionCall"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:251:1: indexing : ( arrayIndexing | matrixIndexing );
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.arrayIndexing_return arrayIndexing118 = default(PsimulexParser.arrayIndexing_return);

        PsimulexParser.matrixIndexing_return matrixIndexing119 = default(PsimulexParser.matrixIndexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:252:2: ( arrayIndexing | matrixIndexing )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == 78) )
            {
                int LA32_1 = input.LA(2);

                if ( (synpred65_Psimulex()) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:252:4: arrayIndexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayIndexing_in_indexing1287);
                    	arrayIndexing118 = arrayIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayIndexing118.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:253:4: matrixIndexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixIndexing_in_indexing1292);
                    	matrixIndexing119 = matrixIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, matrixIndexing119.Tree);

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
            	Memoize(input, 48, indexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:256:1: arrayIndexing : l= '[' expression r= ']' ;
    public PsimulexParser.arrayIndexing_return arrayIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayIndexing_return retval = new PsimulexParser.arrayIndexing_return();
        retval.Start = input.LT(1);
        int arrayIndexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken l = null;
        IToken r = null;
        PsimulexParser.expression_return expression120 = default(PsimulexParser.expression_return);


        CommonTree l_tree=null;
        CommonTree r_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:257:2: (l= '[' expression r= ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:257:4: l= '[' expression r= ']'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,78,FOLLOW_78_in_arrayIndexing1306); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_arrayIndexing1309);
            	expression120 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression120.Tree);
            	r=(IToken)Match(input,79,FOLLOW_79_in_arrayIndexing1313); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 49, arrayIndexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:261:1: matrixIndexing : '[' expression ',' expression ']' ;
    public PsimulexParser.matrixIndexing_return matrixIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.matrixIndexing_return retval = new PsimulexParser.matrixIndexing_return();
        retval.Start = input.LT(1);
        int matrixIndexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal121 = null;
        IToken char_literal123 = null;
        IToken char_literal125 = null;
        PsimulexParser.expression_return expression122 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression124 = default(PsimulexParser.expression_return);


        CommonTree char_literal121_tree=null;
        CommonTree char_literal123_tree=null;
        CommonTree char_literal125_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:262:2: ( '[' expression ',' expression ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:262:4: '[' expression ',' expression ']'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal121=(IToken)Match(input,78,FOLLOW_78_in_matrixIndexing1327); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_matrixIndexing1330);
            	expression122 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression122.Tree);
            	char_literal123=(IToken)Match(input,80,FOLLOW_80_in_matrixIndexing1332); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_matrixIndexing1335);
            	expression124 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression124.Tree);
            	char_literal125=(IToken)Match(input,79,FOLLOW_79_in_matrixIndexing1337); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 50, matrixIndexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:265:1: arguments : '(' ( expressionList )? ')' ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal126 = null;
        IToken char_literal128 = null;
        PsimulexParser.expressionList_return expressionList127 = default(PsimulexParser.expressionList_return);


        CommonTree char_literal126_tree=null;
        CommonTree char_literal128_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:5: ( '(' ( expressionList )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:9: '(' ( expressionList )? ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal126=(IToken)Match(input,81,FOLLOW_81_in_arguments1355); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:14: ( expressionList )?
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == StringLiteral || LA33_0 == Identifier || (LA33_0 >= Plus && LA33_0 <= Minus) || (LA33_0 >= PlusPlus && LA33_0 <= InfinityLiteral) || LA33_0 == 81) )
            	{
            	    alt33 = 1;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1358);
            	        	expressionList127 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionList127.Tree);

            	        }
            	        break;

            	}

            	char_literal128=(IToken)Match(input,82,FOLLOW_82_in_arguments1361); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 51, arguments_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:1: expressionList : expression ( ',' expression )* ;
    public PsimulexParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        PsimulexParser.expressionList_return retval = new PsimulexParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal130 = null;
        PsimulexParser.expression_return expression129 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression131 = default(PsimulexParser.expression_return);


        CommonTree char_literal130_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:5: ( expression ( ',' expression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:7: expression ( ',' expression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1379);
            	expression129 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression129.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:18: ( ',' expression )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == 80) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:19: ',' expression
            			    {
            			    	char_literal130=(IToken)Match(input,80,FOLLOW_80_in_expressionList1382); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_expression_in_expressionList1385);
            			    	expression131 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression131.Tree);

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
            	Memoize(input, 52, expressionList_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:273:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
    public PsimulexParser.literal_return literal() // throws RecognitionException [1]
    {   
        PsimulexParser.literal_return retval = new PsimulexParser.literal_return();
        retval.Start = input.LT(1);
        int literal_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set132 = null;

        CommonTree set132_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:274:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set132 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || (input.LA(1) >= IntegerLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set132));
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
            	Memoize(input, 53, literal_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:1: lambdaExpression : ( simpleLambdaParameter | typedLambdaParameter ) '=>' lambdaStatement ;
    public PsimulexParser.lambdaExpression_return lambdaExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.lambdaExpression_return retval = new PsimulexParser.lambdaExpression_return();
        retval.Start = input.LT(1);
        int lambdaExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken string_literal135 = null;
        PsimulexParser.simpleLambdaParameter_return simpleLambdaParameter133 = default(PsimulexParser.simpleLambdaParameter_return);

        PsimulexParser.typedLambdaParameter_return typedLambdaParameter134 = default(PsimulexParser.typedLambdaParameter_return);

        PsimulexParser.lambdaStatement_return lambdaStatement136 = default(PsimulexParser.lambdaStatement_return);


        CommonTree string_literal135_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:2: ( ( simpleLambdaParameter | typedLambdaParameter ) '=>' lambdaStatement )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:4: ( simpleLambdaParameter | typedLambdaParameter ) '=>' lambdaStatement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:4: ( simpleLambdaParameter | typedLambdaParameter )
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == Identifier) )
            	{
            	    alt35 = 1;
            	}
            	else if ( (LA35_0 == 81) )
            	{
            	    int LA35_2 = input.LA(2);

            	    if ( ((LA35_2 >= Bool && LA35_2 <= PQueue)) )
            	    {
            	        alt35 = 2;
            	    }
            	    else if ( (LA35_2 == Identifier || LA35_2 == 82) )
            	    {
            	        alt35 = 1;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d35s2 =
            	            new NoViableAltException("", 35, 2, input);

            	        throw nvae_d35s2;
            	    }
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:6: simpleLambdaParameter
            	        {
            	        	PushFollow(FOLLOW_simpleLambdaParameter_in_lambdaExpression1496);
            	        	simpleLambdaParameter133 = simpleLambdaParameter();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleLambdaParameter133.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:30: typedLambdaParameter
            	        {
            	        	PushFollow(FOLLOW_typedLambdaParameter_in_lambdaExpression1500);
            	        	typedLambdaParameter134 = typedLambdaParameter();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedLambdaParameter134.Tree);

            	        }
            	        break;

            	}

            	string_literal135=(IToken)Match(input,84,FOLLOW_84_in_lambdaExpression1504); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal135_tree = (CommonTree)adaptor.Create(string_literal135);
            		adaptor.AddChild(root_0, string_literal135_tree);
            	}
            	PushFollow(FOLLOW_lambdaStatement_in_lambdaExpression1506);
            	lambdaStatement136 = lambdaStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaStatement136.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 54, lambdaExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lambdaExpression"

    public class simpleLambdaParameter_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "simpleLambdaParameter"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:1: simpleLambdaParameter : ( Identifier | '(' ( identifierList )? ')' );
    public PsimulexParser.simpleLambdaParameter_return simpleLambdaParameter() // throws RecognitionException [1]
    {   
        PsimulexParser.simpleLambdaParameter_return retval = new PsimulexParser.simpleLambdaParameter_return();
        retval.Start = input.LT(1);
        int simpleLambdaParameter_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier137 = null;
        IToken char_literal138 = null;
        IToken char_literal140 = null;
        PsimulexParser.identifierList_return identifierList139 = default(PsimulexParser.identifierList_return);


        CommonTree Identifier137_tree=null;
        CommonTree char_literal138_tree=null;
        CommonTree char_literal140_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:2: ( Identifier | '(' ( identifierList )? ')' )
            int alt37 = 2;
            int LA37_0 = input.LA(1);

            if ( (LA37_0 == Identifier) )
            {
                alt37 = 1;
            }
            else if ( (LA37_0 == 81) )
            {
                alt37 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d37s0 =
                    new NoViableAltException("", 37, 0, input);

                throw nvae_d37s0;
            }
            switch (alt37) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:4: Identifier
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Identifier137=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_simpleLambdaParameter1518); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Identifier137_tree = (CommonTree)adaptor.Create(Identifier137);
                    		adaptor.AddChild(root_0, Identifier137_tree);
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:17: '(' ( identifierList )? ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal138=(IToken)Match(input,81,FOLLOW_81_in_simpleLambdaParameter1522); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal138_tree = (CommonTree)adaptor.Create(char_literal138);
                    		adaptor.AddChild(root_0, char_literal138_tree);
                    	}
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:21: ( identifierList )?
                    	int alt36 = 2;
                    	int LA36_0 = input.LA(1);

                    	if ( (LA36_0 == Identifier) )
                    	{
                    	    alt36 = 1;
                    	}
                    	switch (alt36) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: identifierList
                    	        {
                    	        	PushFollow(FOLLOW_identifierList_in_simpleLambdaParameter1524);
                    	        	identifierList139 = identifierList();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, identifierList139.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal140=(IToken)Match(input,82,FOLLOW_82_in_simpleLambdaParameter1527); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal140_tree = (CommonTree)adaptor.Create(char_literal140);
                    		adaptor.AddChild(root_0, char_literal140_tree);
                    	}

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
            	Memoize(input, 55, simpleLambdaParameter_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "simpleLambdaParameter"

    public class identifierList_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "identifierList"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:1: identifierList : Identifier ( ',' Identifier )* ;
    public PsimulexParser.identifierList_return identifierList() // throws RecognitionException [1]
    {   
        PsimulexParser.identifierList_return retval = new PsimulexParser.identifierList_return();
        retval.Start = input.LT(1);
        int identifierList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier141 = null;
        IToken char_literal142 = null;
        IToken Identifier143 = null;

        CommonTree Identifier141_tree=null;
        CommonTree char_literal142_tree=null;
        CommonTree Identifier143_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:5: ( Identifier ( ',' Identifier )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:9: Identifier ( ',' Identifier )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier141=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_identifierList1543); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier141_tree = (CommonTree)adaptor.Create(Identifier141);
            		adaptor.AddChild(root_0, Identifier141_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:20: ( ',' Identifier )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 80) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:22: ',' Identifier
            			    {
            			    	char_literal142=(IToken)Match(input,80,FOLLOW_80_in_identifierList1547); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal142_tree = (CommonTree)adaptor.Create(char_literal142);
            			    		adaptor.AddChild(root_0, char_literal142_tree);
            			    	}
            			    	Identifier143=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_identifierList1549); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{Identifier143_tree = (CommonTree)adaptor.Create(Identifier143);
            			    		adaptor.AddChild(root_0, Identifier143_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 56, identifierList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "identifierList"

    public class typedLambdaParameter_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typedLambdaParameter"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:1: typedLambdaParameter : '(' typedIdentifierList ')' ;
    public PsimulexParser.typedLambdaParameter_return typedLambdaParameter() // throws RecognitionException [1]
    {   
        PsimulexParser.typedLambdaParameter_return retval = new PsimulexParser.typedLambdaParameter_return();
        retval.Start = input.LT(1);
        int typedLambdaParameter_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal144 = null;
        IToken char_literal146 = null;
        PsimulexParser.typedIdentifierList_return typedIdentifierList145 = default(PsimulexParser.typedIdentifierList_return);


        CommonTree char_literal144_tree=null;
        CommonTree char_literal146_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:2: ( '(' typedIdentifierList ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:4: '(' typedIdentifierList ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal144=(IToken)Match(input,81,FOLLOW_81_in_typedLambdaParameter1568); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal144_tree = (CommonTree)adaptor.Create(char_literal144);
            		adaptor.AddChild(root_0, char_literal144_tree);
            	}
            	PushFollow(FOLLOW_typedIdentifierList_in_typedLambdaParameter1570);
            	typedIdentifierList145 = typedIdentifierList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typedIdentifierList145.Tree);
            	char_literal146=(IToken)Match(input,82,FOLLOW_82_in_typedLambdaParameter1572); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal146_tree = (CommonTree)adaptor.Create(char_literal146);
            		adaptor.AddChild(root_0, char_literal146_tree);
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
            	Memoize(input, 57, typedLambdaParameter_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typedLambdaParameter"

    public class typedIdentifierList_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typedIdentifierList"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:305:1: typedIdentifierList : dataType Identifier ( ',' dataType Identifier )* ;
    public PsimulexParser.typedIdentifierList_return typedIdentifierList() // throws RecognitionException [1]
    {   
        PsimulexParser.typedIdentifierList_return retval = new PsimulexParser.typedIdentifierList_return();
        retval.Start = input.LT(1);
        int typedIdentifierList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier148 = null;
        IToken char_literal149 = null;
        IToken Identifier151 = null;
        PsimulexParser.dataType_return dataType147 = default(PsimulexParser.dataType_return);

        PsimulexParser.dataType_return dataType150 = default(PsimulexParser.dataType_return);


        CommonTree Identifier148_tree=null;
        CommonTree char_literal149_tree=null;
        CommonTree Identifier151_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:306:2: ( dataType Identifier ( ',' dataType Identifier )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:306:4: dataType Identifier ( ',' dataType Identifier )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dataType_in_typedIdentifierList1583);
            	dataType147 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType147.Tree);
            	Identifier148=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierList1585); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier148_tree = (CommonTree)adaptor.Create(Identifier148);
            		adaptor.AddChild(root_0, Identifier148_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:306:24: ( ',' dataType Identifier )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == 80) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:306:26: ',' dataType Identifier
            			    {
            			    	char_literal149=(IToken)Match(input,80,FOLLOW_80_in_typedIdentifierList1589); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal149_tree = (CommonTree)adaptor.Create(char_literal149);
            			    		adaptor.AddChild(root_0, char_literal149_tree);
            			    	}
            			    	PushFollow(FOLLOW_dataType_in_typedIdentifierList1591);
            			    	dataType150 = dataType();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType150.Tree);
            			    	Identifier151=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_typedIdentifierList1593); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{Identifier151_tree = (CommonTree)adaptor.Create(Identifier151);
            			    		adaptor.AddChild(root_0, Identifier151_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 58, typedIdentifierList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typedIdentifierList"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:1: lambdaStatement : ( expression | block );
    public PsimulexParser.lambdaStatement_return lambdaStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.lambdaStatement_return retval = new PsimulexParser.lambdaStatement_return();
        retval.Start = input.LT(1);
        int lambdaStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression152 = default(PsimulexParser.expression_return);

        PsimulexParser.block_return block153 = default(PsimulexParser.block_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:2: ( expression | block )
            int alt40 = 2;
            int LA40_0 = input.LA(1);

            if ( (LA40_0 == StringLiteral || LA40_0 == Identifier || (LA40_0 >= Plus && LA40_0 <= Minus) || (LA40_0 >= PlusPlus && LA40_0 <= InfinityLiteral) || LA40_0 == 81) )
            {
                alt40 = 1;
            }
            else if ( (LA40_0 == 76) )
            {
                alt40 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d40s0 =
                    new NoViableAltException("", 40, 0, input);

                throw nvae_d40s0;
            }
            switch (alt40) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:4: expression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_lambdaStatement1608);
                    	expression152 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression152.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:17: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_lambdaStatement1612);
                    	block153 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block153.Tree);

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
            	Memoize(input, 59, lambdaStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:1: functionPointerType : ( dataType )? Identifier '(' typeList ')' ;
    public PsimulexParser.functionPointerType_return functionPointerType() // throws RecognitionException [1]
    {   
        PsimulexParser.functionPointerType_return retval = new PsimulexParser.functionPointerType_return();
        retval.Start = input.LT(1);
        int functionPointerType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier155 = null;
        IToken char_literal156 = null;
        IToken char_literal158 = null;
        PsimulexParser.dataType_return dataType154 = default(PsimulexParser.dataType_return);

        PsimulexParser.typeList_return typeList157 = default(PsimulexParser.typeList_return);


        CommonTree Identifier155_tree=null;
        CommonTree char_literal156_tree=null;
        CommonTree char_literal158_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:2: ( ( dataType )? Identifier '(' typeList ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:4: ( dataType )? Identifier '(' typeList ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:4: ( dataType )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( ((LA41_0 >= Bool && LA41_0 <= PQueue)) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: dataType
            	        {
            	        	PushFollow(FOLLOW_dataType_in_functionPointerType1625);
            	        	dataType154 = dataType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType154.Tree);

            	        }
            	        break;

            	}

            	Identifier155=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionPointerType1628); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier155_tree = (CommonTree)adaptor.Create(Identifier155);
            		adaptor.AddChild(root_0, Identifier155_tree);
            	}
            	char_literal156=(IToken)Match(input,81,FOLLOW_81_in_functionPointerType1630); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal156_tree = (CommonTree)adaptor.Create(char_literal156);
            		adaptor.AddChild(root_0, char_literal156_tree);
            	}
            	PushFollow(FOLLOW_typeList_in_functionPointerType1632);
            	typeList157 = typeList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeList157.Tree);
            	char_literal158=(IToken)Match(input,82,FOLLOW_82_in_functionPointerType1634); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal158_tree = (CommonTree)adaptor.Create(char_literal158);
            		adaptor.AddChild(root_0, char_literal158_tree);
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
            	Memoize(input, 60, functionPointerType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionPointerType"

    public class typeList_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typeList"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:317:1: typeList : dataType ( ',' dataType )* ;
    public PsimulexParser.typeList_return typeList() // throws RecognitionException [1]
    {   
        PsimulexParser.typeList_return retval = new PsimulexParser.typeList_return();
        retval.Start = input.LT(1);
        int typeList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal160 = null;
        PsimulexParser.dataType_return dataType159 = default(PsimulexParser.dataType_return);

        PsimulexParser.dataType_return dataType161 = default(PsimulexParser.dataType_return);


        CommonTree char_literal160_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:318:2: ( dataType ( ',' dataType )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:318:4: dataType ( ',' dataType )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_dataType_in_typeList1645);
            	dataType159 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType159.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:318:13: ( ',' dataType )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == 80) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:318:15: ',' dataType
            			    {
            			    	char_literal160=(IToken)Match(input,80,FOLLOW_80_in_typeList1649); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal160_tree = (CommonTree)adaptor.Create(char_literal160);
            			    		adaptor.AddChild(root_0, char_literal160_tree);
            			    	}
            			    	PushFollow(FOLLOW_dataType_in_typeList1651);
            			    	dataType161 = dataType();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType161.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 61, typeList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "typeList"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:1: block : '{' ( blockStatement )* '}' ;
    public PsimulexParser.block_return block() // throws RecognitionException [1]
    {   
        PsimulexParser.block_return retval = new PsimulexParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal162 = null;
        IToken char_literal164 = null;
        PsimulexParser.blockStatement_return blockStatement163 = default(PsimulexParser.blockStatement_return);


        CommonTree char_literal162_tree=null;
        CommonTree char_literal164_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:330:5: ( '{' ( blockStatement )* '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:330:9: '{' ( blockStatement )* '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal162=(IToken)Match(input,76,FOLLOW_76_in_block1684); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:330:14: ( blockStatement )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == StringLiteral || LA43_0 == Identifier || (LA43_0 >= Bool && LA43_0 <= PQueue) || (LA43_0 >= Plus && LA43_0 <= Minus) || (LA43_0 >= PlusPlus && LA43_0 <= If) || (LA43_0 >= For && LA43_0 <= Continue) || LA43_0 == 75 || LA43_0 == 81) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: blockStatement
            			    {
            			    	PushFollow(FOLLOW_blockStatement_in_block1687);
            			    	blockStatement163 = blockStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement163.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements

            	char_literal164=(IToken)Match(input,77,FOLLOW_77_in_block1690); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 62, block_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "block"

    public class blockStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "blockStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:1: blockStatement : ( localVariableDeclarationStatement | statement );
    public PsimulexParser.blockStatement_return blockStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.blockStatement_return retval = new PsimulexParser.blockStatement_return();
        retval.Start = input.LT(1);
        int blockStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclarationStatement_return localVariableDeclarationStatement165 = default(PsimulexParser.localVariableDeclarationStatement_return);

        PsimulexParser.statement_return statement166 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:334:5: ( localVariableDeclarationStatement | statement )
            int alt44 = 2;
            switch ( input.LA(1) ) 
            {
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
            	{
                alt44 = 1;
                }
                break;
            case Identifier:
            	{
                int LA44_2 = input.LA(2);

                if ( (LA44_2 == 81) )
                {
                    alt44 = 1;
                }
                else if ( (LA44_2 == Assign || (LA44_2 >= AssignAndAdd && LA44_2 <= MinusMinus) || LA44_2 == 75 || LA44_2 == 78 || (LA44_2 >= 83 && LA44_2 <= 84)) )
                {
                    alt44 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d44s2 =
                        new NoViableAltException("", 44, 2, input);

                    throw nvae_d44s2;
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
            case If:
            case For:
            case PFor:
            case ForEach:
            case PForEach:
            case Loop:
            case While:
            case Do:
            case PDo:
            case Return:
            case Break:
            case Continue:
            case 75:
            case 81:
            	{
                alt44 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d44s0 =
            	        new NoViableAltException("", 44, 0, input);

            	    throw nvae_d44s0;
            }

            switch (alt44) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:334:9: localVariableDeclarationStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_localVariableDeclarationStatement_in_blockStatement1714);
                    	localVariableDeclarationStatement165 = localVariableDeclarationStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclarationStatement165.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:334:45: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_blockStatement1718);
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
            	Memoize(input, 63, blockStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "blockStatement"

    public class localVariableDeclarationStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "localVariableDeclarationStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:1: localVariableDeclarationStatement : localVariableDeclaration ';' ;
    public PsimulexParser.localVariableDeclarationStatement_return localVariableDeclarationStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.localVariableDeclarationStatement_return retval = new PsimulexParser.localVariableDeclarationStatement_return();
        retval.Start = input.LT(1);
        int localVariableDeclarationStatement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal168 = null;
        PsimulexParser.localVariableDeclaration_return localVariableDeclaration167 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree char_literal168_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:338:5: ( localVariableDeclaration ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:338:10: localVariableDeclaration ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_localVariableDeclarationStatement1742);
            	localVariableDeclaration167 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration167.Tree);
            	char_literal168=(IToken)Match(input,75,FOLLOW_75_in_localVariableDeclarationStatement1744); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 64, localVariableDeclarationStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "localVariableDeclarationStatement"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:1: localVariableDeclaration : type variableDeclarator ;
    public PsimulexParser.localVariableDeclaration_return localVariableDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.localVariableDeclaration_return retval = new PsimulexParser.localVariableDeclaration_return();
        retval.Start = input.LT(1);
        int localVariableDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.type_return type169 = default(PsimulexParser.type_return);

        PsimulexParser.variableDeclarator_return variableDeclarator170 = default(PsimulexParser.variableDeclarator_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:342:5: ( type variableDeclarator )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:342:9: type variableDeclarator
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_localVariableDeclaration1764);
            	type169 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type169.Tree);
            	PushFollow(FOLLOW_variableDeclarator_in_localVariableDeclaration1766);
            	variableDeclarator170 = variableDeclarator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarator170.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 65, localVariableDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "localVariableDeclaration"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:345:1: branch : ( block | blockStatement );
    public PsimulexParser.branch_return branch() // throws RecognitionException [1]
    {   
        PsimulexParser.branch_return retval = new PsimulexParser.branch_return();
        retval.Start = input.LT(1);
        int branch_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.block_return block171 = default(PsimulexParser.block_return);

        PsimulexParser.blockStatement_return blockStatement172 = default(PsimulexParser.blockStatement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 66) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:5: ( block | blockStatement )
            int alt45 = 2;
            int LA45_0 = input.LA(1);

            if ( (LA45_0 == 76) )
            {
                alt45 = 1;
            }
            else if ( (LA45_0 == StringLiteral || LA45_0 == Identifier || (LA45_0 >= Bool && LA45_0 <= PQueue) || (LA45_0 >= Plus && LA45_0 <= Minus) || (LA45_0 >= PlusPlus && LA45_0 <= If) || (LA45_0 >= For && LA45_0 <= Continue) || LA45_0 == 75 || LA45_0 == 81) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:7: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch1787);
                    	block171 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block171.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:13: blockStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_blockStatement_in_branch1789);
                    	blockStatement172 = blockStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement172.Tree);

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
            	Memoize(input, 66, branch_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:349:1: statement : ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken If173 = null;
        IToken Else176 = null;
        IToken set178 = null;
        IToken char_literal179 = null;
        IToken char_literal181 = null;
        IToken set183 = null;
        IToken char_literal184 = null;
        IToken char_literal186 = null;
        IToken Loop188 = null;
        IToken char_literal189 = null;
        IToken char_literal191 = null;
        IToken While193 = null;
        IToken Do196 = null;
        IToken While198 = null;
        IToken char_literal200 = null;
        IToken PDo201 = null;
        IToken Return203 = null;
        IToken char_literal205 = null;
        IToken Break206 = null;
        IToken char_literal207 = null;
        IToken Continue208 = null;
        IToken char_literal209 = null;
        IToken char_literal210 = null;
        IToken char_literal212 = null;
        PsimulexParser.parExpression_return parExpression174 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch175 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch177 = default(PsimulexParser.branch_return);

        PsimulexParser.forControl_return forControl180 = default(PsimulexParser.forControl_return);

        PsimulexParser.branch_return branch182 = default(PsimulexParser.branch_return);

        PsimulexParser.foreachControl_return foreachControl185 = default(PsimulexParser.foreachControl_return);

        PsimulexParser.branch_return branch187 = default(PsimulexParser.branch_return);

        PsimulexParser.loopControl_return loopControl190 = default(PsimulexParser.loopControl_return);

        PsimulexParser.branch_return branch192 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression194 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch195 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch197 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression199 = default(PsimulexParser.parExpression_return);

        PsimulexParser.block_return block202 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression204 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression211 = default(PsimulexParser.expression_return);


        CommonTree If173_tree=null;
        CommonTree Else176_tree=null;
        CommonTree set178_tree=null;
        CommonTree char_literal179_tree=null;
        CommonTree char_literal181_tree=null;
        CommonTree set183_tree=null;
        CommonTree char_literal184_tree=null;
        CommonTree char_literal186_tree=null;
        CommonTree Loop188_tree=null;
        CommonTree char_literal189_tree=null;
        CommonTree char_literal191_tree=null;
        CommonTree While193_tree=null;
        CommonTree Do196_tree=null;
        CommonTree While198_tree=null;
        CommonTree char_literal200_tree=null;
        CommonTree PDo201_tree=null;
        CommonTree Return203_tree=null;
        CommonTree char_literal205_tree=null;
        CommonTree Break206_tree=null;
        CommonTree char_literal207_tree=null;
        CommonTree Continue208_tree=null;
        CommonTree char_literal209_tree=null;
        CommonTree char_literal210_tree=null;
        CommonTree char_literal212_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 67) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:5: ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' )
            int alt48 = 12;
            switch ( input.LA(1) ) 
            {
            case If:
            	{
                alt48 = 1;
                }
                break;
            case For:
            case PFor:
            	{
                alt48 = 2;
                }
                break;
            case ForEach:
            case PForEach:
            	{
                alt48 = 3;
                }
                break;
            case Loop:
            	{
                alt48 = 4;
                }
                break;
            case While:
            	{
                alt48 = 5;
                }
                break;
            case Do:
            	{
                alt48 = 6;
                }
                break;
            case PDo:
            	{
                alt48 = 7;
                }
                break;
            case Return:
            	{
                alt48 = 8;
                }
                break;
            case Break:
            	{
                alt48 = 9;
                }
                break;
            case Continue:
            	{
                alt48 = 10;
                }
                break;
            case 75:
            	{
                alt48 = 11;
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
            case 81:
            	{
                alt48 = 12;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:7: If parExpression branch ( options {k=1; } : Else branch )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	If173=(IToken)Match(input,If,FOLLOW_If_in_statement1807); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{If173_tree = (CommonTree)adaptor.Create(If173);
                    		adaptor.AddChild(root_0, If173_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1809);
                    	parExpression174 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression174.Tree);
                    	PushFollow(FOLLOW_branch_in_statement1811);
                    	branch175 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch175.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:31: ( options {k=1; } : Else branch )?
                    	int alt46 = 2;
                    	int LA46_0 = input.LA(1);

                    	if ( (LA46_0 == Else) )
                    	{
                    	    int LA46_1 = input.LA(2);

                    	    if ( (synpred85_Psimulex()) )
                    	    {
                    	        alt46 = 1;
                    	    }
                    	}
                    	switch (alt46) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:47: Else branch
                    	        {
                    	        	Else176=(IToken)Match(input,Else,FOLLOW_Else_in_statement1821); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{Else176_tree = (CommonTree)adaptor.Create(Else176);
                    	        		adaptor.AddChild(root_0, Else176_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_branch_in_statement1823);
                    	        	branch177 = branch();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch177.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:9: ( For | PFor ) '(' forControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set178 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= For && input.LA(1) <= PFor) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set178));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal179=(IToken)Match(input,81,FOLLOW_81_in_statement1841); if (state.failed) return retval;
                    	PushFollow(FOLLOW_forControl_in_statement1844);
                    	forControl180 = forControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forControl180.Tree);
                    	char_literal181=(IToken)Match(input,82,FOLLOW_82_in_statement1846); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement1849);
                    	branch182 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch182.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:352:9: ( ForEach | PForEach ) '(' foreachControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set183 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= ForEach && input.LA(1) <= PForEach) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set183));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal184=(IToken)Match(input,81,FOLLOW_81_in_statement1865); if (state.failed) return retval;
                    	PushFollow(FOLLOW_foreachControl_in_statement1868);
                    	foreachControl185 = foreachControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, foreachControl185.Tree);
                    	char_literal186=(IToken)Match(input,82,FOLLOW_82_in_statement1870); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement1873);
                    	branch187 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch187.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:353:9: Loop '(' loopControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Loop188=(IToken)Match(input,Loop,FOLLOW_Loop_in_statement1883); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Loop188_tree = (CommonTree)adaptor.Create(Loop188);
                    		adaptor.AddChild(root_0, Loop188_tree);
                    	}
                    	char_literal189=(IToken)Match(input,81,FOLLOW_81_in_statement1885); if (state.failed) return retval;
                    	PushFollow(FOLLOW_loopControl_in_statement1888);
                    	loopControl190 = loopControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopControl190.Tree);
                    	char_literal191=(IToken)Match(input,82,FOLLOW_82_in_statement1890); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement1893);
                    	branch192 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch192.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:354:9: While parExpression branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	While193=(IToken)Match(input,While,FOLLOW_While_in_statement1903); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While193_tree = (CommonTree)adaptor.Create(While193);
                    		adaptor.AddChild(root_0, While193_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1905);
                    	parExpression194 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression194.Tree);
                    	PushFollow(FOLLOW_branch_in_statement1907);
                    	branch195 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch195.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:9: Do branch While parExpression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Do196=(IToken)Match(input,Do,FOLLOW_Do_in_statement1917); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Do196_tree = (CommonTree)adaptor.Create(Do196);
                    		adaptor.AddChild(root_0, Do196_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement1919);
                    	branch197 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch197.Tree);
                    	While198=(IToken)Match(input,While,FOLLOW_While_in_statement1921); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While198_tree = (CommonTree)adaptor.Create(While198);
                    		adaptor.AddChild(root_0, While198_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1923);
                    	parExpression199 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression199.Tree);
                    	char_literal200=(IToken)Match(input,75,FOLLOW_75_in_statement1925); if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:356:9: PDo block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PDo201=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement1936); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PDo201_tree = (CommonTree)adaptor.Create(PDo201);
                    		adaptor.AddChild(root_0, PDo201_tree);
                    	}
                    	PushFollow(FOLLOW_block_in_statement1938);
                    	block202 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block202.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:9: Return ( expression )? ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Return203=(IToken)Match(input,Return,FOLLOW_Return_in_statement1948); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Return203_tree = (CommonTree)adaptor.Create(Return203);
                    		adaptor.AddChild(root_0, Return203_tree);
                    	}
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:357:16: ( expression )?
                    	int alt47 = 2;
                    	int LA47_0 = input.LA(1);

                    	if ( (LA47_0 == StringLiteral || LA47_0 == Identifier || (LA47_0 >= Plus && LA47_0 <= Minus) || (LA47_0 >= PlusPlus && LA47_0 <= InfinityLiteral) || LA47_0 == 81) )
                    	{
                    	    alt47 = 1;
                    	}
                    	switch (alt47) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement1950);
                    	        	expression204 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression204.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal205=(IToken)Match(input,75,FOLLOW_75_in_statement1953); if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:9: Break ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Break206=(IToken)Match(input,Break,FOLLOW_Break_in_statement1964); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break206_tree = (CommonTree)adaptor.Create(Break206);
                    		adaptor.AddChild(root_0, Break206_tree);
                    	}
                    	char_literal207=(IToken)Match(input,75,FOLLOW_75_in_statement1966); if (state.failed) return retval;

                    }
                    break;
                case 10 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:359:9: Continue ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Continue208=(IToken)Match(input,Continue,FOLLOW_Continue_in_statement1977); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Continue208_tree = (CommonTree)adaptor.Create(Continue208);
                    		adaptor.AddChild(root_0, Continue208_tree);
                    	}
                    	char_literal209=(IToken)Match(input,75,FOLLOW_75_in_statement1979); if (state.failed) return retval;

                    }
                    break;
                case 11 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal210=(IToken)Match(input,75,FOLLOW_75_in_statement1990); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:361:9: expression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_statement2001);
                    	expression211 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression211.Tree);
                    	char_literal212=(IToken)Match(input,75,FOLLOW_75_in_statement2003); if (state.failed) return retval;

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
            	Memoize(input, 67, statement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:364:1: forControl : ( forInit )? ';' ( expression )? ';' ( forUpdate )? ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal214 = null;
        IToken char_literal216 = null;
        PsimulexParser.forInit_return forInit213 = default(PsimulexParser.forInit_return);

        PsimulexParser.expression_return expression215 = default(PsimulexParser.expression_return);

        PsimulexParser.forUpdate_return forUpdate217 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal214_tree=null;
        CommonTree char_literal216_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 68) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:5: ( ( forInit )? ';' ( expression )? ';' ( forUpdate )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:10: ( forInit )? ';' ( expression )? ';' ( forUpdate )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:10: ( forInit )?
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == Identifier || (LA49_0 >= Bool && LA49_0 <= PQueue)) )
            	{
            	    alt49 = 1;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl2028);
            	        	forInit213 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInit213.Tree);

            	        }
            	        break;

            	}

            	char_literal214=(IToken)Match(input,75,FOLLOW_75_in_forControl2031); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:24: ( expression )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == StringLiteral || LA50_0 == Identifier || (LA50_0 >= Plus && LA50_0 <= Minus) || (LA50_0 >= PlusPlus && LA50_0 <= InfinityLiteral) || LA50_0 == 81) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forControl2034);
            	        	expression215 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression215.Tree);

            	        }
            	        break;

            	}

            	char_literal216=(IToken)Match(input,75,FOLLOW_75_in_forControl2037); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:365:41: ( forUpdate )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == StringLiteral || LA51_0 == Identifier || (LA51_0 >= Plus && LA51_0 <= Minus) || (LA51_0 >= PlusPlus && LA51_0 <= InfinityLiteral) || LA51_0 == 81) )
            	{
            	    alt51 = 1;
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl2040);
            	        	forUpdate217 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forUpdate217.Tree);

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
            	Memoize(input, 68, forControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:368:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration218 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 69) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:5: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:369:9: localVariableDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit2060);
            	localVariableDeclaration218 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration218.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 69, forInit_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:372:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression219 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 70) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:373:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate2079);
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
            	Memoize(input, 70, forUpdate_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:376:1: foreachControl options {k=3; } : type Identifier In expression ;
    public PsimulexParser.foreachControl_return foreachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.foreachControl_return retval = new PsimulexParser.foreachControl_return();
        retval.Start = input.LT(1);
        int foreachControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier221 = null;
        IToken In222 = null;
        PsimulexParser.type_return type220 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression223 = default(PsimulexParser.expression_return);


        CommonTree Identifier221_tree=null;
        CommonTree In222_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 71) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:378:5: ( type Identifier In expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:378:9: type Identifier In expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_foreachControl2110);
            	type220 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type220.Tree);
            	Identifier221=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_foreachControl2112); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier221_tree = (CommonTree)adaptor.Create(Identifier221);
            		adaptor.AddChild(root_0, Identifier221_tree);
            	}
            	In222=(IToken)Match(input,In,FOLLOW_In_in_foreachControl2114); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{In222_tree = (CommonTree)adaptor.Create(In222);
            		adaptor.AddChild(root_0, In222_tree);
            	}
            	PushFollow(FOLLOW_expression_in_foreachControl2116);
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
            	Memoize(input, 71, foreachControl_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:382:1: loopControl options {k=3; } : type Identifier To expression ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier225 = null;
        IToken To226 = null;
        PsimulexParser.type_return type224 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression227 = default(PsimulexParser.expression_return);


        CommonTree Identifier225_tree=null;
        CommonTree To226_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 72) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:384:5: ( type Identifier To expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:384:9: type Identifier To expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_loopControl2148);
            	type224 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type224.Tree);
            	Identifier225=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_loopControl2150); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier225_tree = (CommonTree)adaptor.Create(Identifier225);
            		adaptor.AddChild(root_0, Identifier225_tree);
            	}
            	To226=(IToken)Match(input,To,FOLLOW_To_in_loopControl2152); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{To226_tree = (CommonTree)adaptor.Create(To226);
            		adaptor.AddChild(root_0, To226_tree);
            	}
            	PushFollow(FOLLOW_expression_in_loopControl2154);
            	expression227 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression227.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 72, loopControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "loopControl"

    // $ANTLR start "synpred1_Psimulex"
    public void synpred1_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:8: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:8: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex65);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred30_Psimulex"
    public void synpred30_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred30_Psimulex705);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_Psimulex"

    // $ANTLR start "synpred31_Psimulex"
    public void synpred31_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:4: ( conditionalOrExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:4: conditionalOrExpression
        {
        	PushFollow(FOLLOW_conditionalOrExpression_in_synpred31_Psimulex710);
        	conditionalOrExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_Psimulex"

    // $ANTLR start "synpred58_Psimulex"
    public void synpred58_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:215:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:215:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred58_Psimulex1116);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred58_Psimulex"

    // $ANTLR start "synpred59_Psimulex"
    public void synpred59_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:216:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:216:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred59_Psimulex1124);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred59_Psimulex"

    // $ANTLR start "synpred65_Psimulex"
    public void synpred65_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:252:4: ( arrayIndexing )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:252:4: arrayIndexing
        {
        	PushFollow(FOLLOW_arrayIndexing_in_synpred65_Psimulex1287);
        	arrayIndexing();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred65_Psimulex"

    // $ANTLR start "synpred85_Psimulex"
    public void synpred85_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:47: ( Else branch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:47: Else branch
        {
        	Match(input,Else,FOLLOW_Else_in_synpred85_Psimulex1821); if (state.failed) return ;
        	PushFollow(FOLLOW_branch_in_synpred85_Psimulex1823);
        	branch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred85_Psimulex"

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
   	public bool synpred85_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred85_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred31_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_Psimulex_fragment(); // can never throw exception
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


   	protected DFA1 dfa1;
   	protected DFA5 dfa5;
   	protected DFA11 dfa11;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa5 = new DFA5(this);
    	this.dfa11 = new DFA11(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);


	}

    const string DFA1_eotS =
        "\x2a\uffff";
    const string DFA1_eofS =
        "\x01\x05\x29\uffff";
    const string DFA1_minS =
        "\x01\x04\x02\x07\x01\x08\x01\uffff\x01\x00\x01\uffff\x01\x4f\x01"+
        "\x08\x01\x09\x01\x07\x01\x4f\x01\x07\x01\x4f\x01\x05\x01\x00\x02"+
        "\x4e\x03\x07\x01\x08\x01\x4f\x01\x1c\x01\x4f\x01\x09\x01\x07\x01"+
        "\x4f\x01\x08\x01\x50\x01\x4f\x02\x4e\x01\x08\x01\x07\x01\x4f\x01"+
        "\x50\x01\x4f\x01\x07\x01\x50\x01\x4f\x01\x50";
    const string DFA1_maxS =
        "\x01\x51\x02\x4e\x01\x54\x01\uffff\x01\x00\x01\uffff\x01\x50\x01"+
        "\x51\x01\x15\x01\x07\x01\x4f\x01\x52\x01\x50\x01\x51\x01\x00\x02"+
        "\x52\x01\x07\x02\x52\x01\x4b\x01\x4f\x01\x4b\x01\x50\x01\x15\x01"+
        "\x07\x01\x50\x01\x4b\x01\x52\x01\x4f\x02\x52\x01\x51\x01\x52\x01"+
        "\x4f\x01\x52\x01\x50\x02\x52\x01\x4f\x01\x52";
    const string DFA1_acceptS =
        "\x04\uffff\x01\x01\x01\uffff\x01\x02\x23\uffff";
    const string DFA1_specialS =
        "\x05\uffff\x01\x01\x09\uffff\x01\x00\x1a\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x06\x01\x04\x01\x06\x01\x03\x01\uffff\x06\x01\x07\x02"+
            "\x0e\uffff\x02\x04\x03\uffff\x0a\x04\x01\uffff\x0b\x04\x0c\uffff"+
            "\x01\x04\x05\uffff\x01\x04",
            "\x01\x08\x46\uffff\x01\x07",
            "\x01\x08\x46\uffff\x01\x07",
            "\x01\x04\x0e\uffff\x14\x04\x20\uffff\x01\x04\x02\uffff\x01"+
            "\x04\x02\uffff\x01\x09\x01\uffff\x02\x04",
            "",
            "\x01\uffff",
            "",
            "\x01\x0a\x01\x0b",
            "\x01\x0e\x42\uffff\x01\x0f\x02\uffff\x01\x0d\x02\uffff\x01"+
            "\x0c",
            "\x06\x10\x07\x11",
            "\x01\x08",
            "\x01\x12",
            "\x01\x06\x01\uffff\x06\x13\x07\x14\x3c\uffff\x01\x06",
            "\x01\x15\x01\x16",
            "\x01\x17\x01\uffff\x01\x04\x1c\uffff\x02\x04\x03\uffff\x03"+
            "\x04\x06\x17\x1f\uffff\x01\x04",
            "\x01\uffff",
            "\x01\x18\x01\uffff\x01\x19\x01\uffff\x01\x1a",
            "\x01\x18\x01\uffff\x01\x19\x01\uffff\x01\x1a",
            "\x01\x08",
            "\x01\x06\x0e\uffff\x01\x06\x37\uffff\x01\x1b\x01\uffff\x01"+
            "\x19\x01\uffff\x01\x1a",
            "\x01\x06\x0e\uffff\x01\x06\x37\uffff\x01\x1b\x01\uffff\x01"+
            "\x19\x01\uffff\x01\x1a",
            "\x01\x0e\x42\uffff\x01\x0f",
            "\x01\x1c",
            "\x0f\x04\x20\uffff\x01\x0f",
            "\x01\x1d\x01\x1e",
            "\x06\x1f\x07\x20",
            "\x01\x21",
            "\x01\x22\x01\x23",
            "\x01\x0e\x42\uffff\x01\x0f",
            "\x01\x19\x01\uffff\x01\x1a",
            "\x01\x24",
            "\x01\x25\x01\uffff\x01\x19\x01\uffff\x01\x1a",
            "\x01\x25\x01\uffff\x01\x19\x01\uffff\x01\x1a",
            "\x01\x0e\x42\uffff\x01\x0f\x02\uffff\x01\x0d\x02\uffff\x01"+
            "\x06",
            "\x01\x06\x0e\uffff\x01\x06\x39\uffff\x01\x19\x01\uffff\x01"+
            "\x1a",
            "\x01\x26",
            "\x01\x19\x01\uffff\x01\x1a",
            "\x01\x27\x01\x28",
            "\x01\x06\x0e\uffff\x01\x06\x39\uffff\x01\x19\x01\uffff\x01"+
            "\x1a",
            "\x01\x19\x01\uffff\x01\x1a",
            "\x01\x29",
            "\x01\x19\x01\uffff\x01\x1a"
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
            get { return "12:7: ( simpleProgram | multiFunctionalProgram )"; }
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
                   	if ( (synpred1_Psimulex()) ) { s = 4; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index1_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_5 = input.LA(1);

                   	 
                   	int index1_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 4; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index1_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
    const string DFA5_eotS =
        "\x22\uffff";
    const string DFA5_eofS =
        "\x01\x04\x21\uffff";
    const string DFA5_minS =
        "\x03\x07\x01\x51\x01\uffff\x01\x4f\x01\x08\x01\x09\x01\x07\x01"+
        "\x4f\x01\x07\x01\uffff\x02\x4e\x03\x07\x01\x4f\x01\x09\x01\x07\x01"+
        "\x4f\x01\x50\x01\x4f\x02\x4e\x01\x08\x01\x07\x01\x4f\x01\x50\x01"+
        "\x4f\x01\x07\x01\x50\x01\x4f\x01\x50";
    const string DFA5_maxS =
        "\x01\x15\x02\x4e\x01\x51\x01\uffff\x01\x50\x01\x51\x01\x15\x01"+
        "\x07\x01\x4f\x01\x52\x01\uffff\x02\x52\x01\x07\x02\x52\x01\x50\x01"+
        "\x15\x01\x07\x01\x50\x01\x52\x01\x4f\x02\x52\x01\x51\x01\x52\x01"+
        "\x4f\x01\x52\x01\x50\x02\x52\x01\x4f\x01\x52";
    const string DFA5_acceptS =
        "\x04\uffff\x01\x02\x06\uffff\x01\x01\x16\uffff";
    const string DFA5_specialS =
        "\x22\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x03\x01\uffff\x06\x01\x07\x02",
            "\x01\x06\x46\uffff\x01\x05",
            "\x01\x06\x46\uffff\x01\x05",
            "\x01\x07",
            "",
            "\x01\x08\x01\x09",
            "\x01\x0b\x42\uffff\x01\x0b\x02\uffff\x01\x0b\x02\uffff\x01"+
            "\x0a",
            "\x06\x0c\x07\x0d",
            "\x01\x06",
            "\x01\x0e",
            "\x01\x04\x01\uffff\x06\x0f\x07\x10\x3c\uffff\x01\x04",
            "",
            "\x01\x11\x01\uffff\x01\x12\x01\uffff\x01\x13",
            "\x01\x11\x01\uffff\x01\x12\x01\uffff\x01\x13",
            "\x01\x06",
            "\x01\x04\x0e\uffff\x01\x04\x37\uffff\x01\x14\x01\uffff\x01"+
            "\x12\x01\uffff\x01\x13",
            "\x01\x04\x0e\uffff\x01\x04\x37\uffff\x01\x14\x01\uffff\x01"+
            "\x12\x01\uffff\x01\x13",
            "\x01\x15\x01\x16",
            "\x06\x17\x07\x18",
            "\x01\x19",
            "\x01\x1a\x01\x1b",
            "\x01\x12\x01\uffff\x01\x13",
            "\x01\x1c",
            "\x01\x1d\x01\uffff\x01\x12\x01\uffff\x01\x13",
            "\x01\x1d\x01\uffff\x01\x12\x01\uffff\x01\x13",
            "\x01\x0b\x42\uffff\x01\x0b\x02\uffff\x01\x0b\x02\uffff\x01"+
            "\x04",
            "\x01\x04\x0e\uffff\x01\x04\x39\uffff\x01\x12\x01\uffff\x01"+
            "\x13",
            "\x01\x1e",
            "\x01\x12\x01\uffff\x01\x13",
            "\x01\x1f\x01\x20",
            "\x01\x04\x0e\uffff\x01\x04\x39\uffff\x01\x12\x01\uffff\x01"+
            "\x13",
            "\x01\x12\x01\uffff\x01\x13",
            "\x01\x21",
            "\x01\x12\x01\uffff\x01\x13"
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 22:6: ( globalVariableDeclaration )*"; }
        }

    }

    const string DFA11_eotS =
        "\x11\uffff";
    const string DFA11_eofS =
        "\x05\uffff\x01\x06\x0b\uffff";
    const string DFA11_minS =
        "\x03\x07\x01\uffff\x01\x4f\x01\x08\x01\uffff\x01\x07\x01\x4f\x04"+
        "\x07\x01\x4f\x01\x07\x01\x4f\x01\x07";
    const string DFA11_maxS =
        "\x01\x15\x02\x4e\x01\uffff\x01\x50\x01\x52\x01\uffff\x01\x16\x01"+
        "\x4f\x01\x52\x01\x16\x02\x52\x01\x50\x01\x52\x01\x4f\x01\x52";
    const string DFA11_acceptS =
        "\x03\uffff\x01\x02\x02\uffff\x01\x01\x0a\uffff";
    const string DFA11_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x03\x01\uffff\x06\x01\x07\x02",
            "\x01\x05\x0e\uffff\x01\x06\x37\uffff\x01\x04",
            "\x01\x05\x0e\uffff\x01\x06\x37\uffff\x01\x04",
            "",
            "\x01\x07\x01\x08",
            "\x01\x06\x36\uffff\x02\x06\x0a\uffff\x01\x06\x02\uffff\x01"+
            "\x06\x01\uffff\x01\x06\x01\x09\x01\x06",
            "",
            "\x01\x05\x0e\uffff\x01\x06",
            "\x01\x0a",
            "\x01\x06\x01\uffff\x06\x0b\x07\x0c\x3c\uffff\x01\x06",
            "\x01\x05\x0e\uffff\x01\x06",
            "\x01\x06\x0e\uffff\x01\x06\x37\uffff\x01\x0d\x01\uffff\x01"+
            "\x03\x01\uffff\x01\x03",
            "\x01\x06\x0e\uffff\x01\x06\x37\uffff\x01\x0d\x01\uffff\x01"+
            "\x03\x01\uffff\x01\x03",
            "\x01\x0e\x01\x0f",
            "\x01\x06\x0e\uffff\x01\x06\x39\uffff\x01\x03\x01\uffff\x01"+
            "\x03",
            "\x01\x10",
            "\x01\x06\x0e\uffff\x01\x06\x39\uffff\x01\x03\x01\uffff\x01"+
            "\x03"
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "93:1: type : ( dataType | functionPointerType );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit65 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit69 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit72 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_blockStatement_in_simpleProgram86 = new BitSet(new ulong[]{0x7FF7FE30003FFEA2UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_importDeclaration_in_multiFunctionalProgram98 = new BitSet(new ulong[]{0x00000000003FFED2UL});
    public static readonly BitSet FOLLOW_typeDeclaration_in_multiFunctionalProgram106 = new BitSet(new ulong[]{0x00000000003FFEC2UL});
    public static readonly BitSet FOLLOW_globalVariableDeclaration_in_multiFunctionalProgram114 = new BitSet(new ulong[]{0x00000000003FFE82UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_multiFunctionalProgram119 = new BitSet(new ulong[]{0x00000000003FFE82UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclaration131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Import_in_importDeclaration160 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclaration162 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_importDeclaration164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclaration184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration203 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration205 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_structBody226 = new BitSet(new ulong[]{0x00000000003FFE80UL});
    public static readonly BitSet FOLLOW_structBodyDeclaration_in_structBody229 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_structBody231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBodyDeclaration251 = new BitSet(new ulong[]{0x00000000003FFE82UL});
    public static readonly BitSet FOLLOW_type_in_memberDeclaration271 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_fieldDeclaration_in_memberDeclaration273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaratorId_in_fieldDeclaration292 = new BitSet(new ulong[]{0x0000000000000100UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_Assign_in_fieldDeclaration295 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_literal_in_fieldDeclaration298 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_fieldDeclaration303 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaratorId_in_variableDeclarator323 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_Assign_in_variableDeclarator326 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_variableDeclarator329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_functionDeclaration348 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration350 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_formalParameters_in_functionDeclaration352 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableDeclaratorId381 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_variableDeclaratorId384 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_variableDeclaratorId386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_variableDeclaratorId388 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_variableDeclaratorId390 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_variableDeclaratorId392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInitializer413 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_type443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionPointerType_in_type451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataType467 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataType471 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_dataType477 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_dataType479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_dataType483 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_dataType485 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_dataType487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_formalParameters615 = new BitSet(new ulong[]{0x00000000007FFE80UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_formalParameterDecls_in_formalParameters618 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_formalParameters621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_formalParameterDecls645 = new BitSet(new ulong[]{0x00000000007FFE80UL});
    public static readonly BitSet FOLLOW_Reference_in_formalParameterDecls648 = new BitSet(new ulong[]{0x00000000007FFE80UL});
    public static readonly BitSet FOLLOW_formalParameterDeclsRest_in_formalParameterDecls652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaratorId_in_formalParameterDeclsRest675 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_formalParameterDeclsRest678 = new BitSet(new ulong[]{0x00000000007FFE80UL});
    public static readonly BitSet FOLLOW_formalParameterDecls_in_formalParameterDeclsRest681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expression705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_expression710 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lambdaExpression_in_expression715 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment727 = new BitSet(new ulong[]{0x000000000F800100UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment729 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_expression_in_assignment732 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression773 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression777 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression780 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression802 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression806 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression809 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression831 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression837 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression842 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression877 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression881 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression884 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression938 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression942 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression945 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression980 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression984 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression987 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryExpression1022 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1025 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression1033 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpression1036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1091 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1094 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_parExpression1153 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000060800UL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1156 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_parExpression1158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selecting1201 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000084000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selecting1203 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000084000UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1206 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000084000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector1223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector1233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_indexing_in_selector1243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_memberSelect1257 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect1260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_memberFunctionCall1271 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall1274 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall1276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_indexing1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixIndexing_in_indexing1292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_arrayIndexing1306 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000028800UL});
    public static readonly BitSet FOLLOW_expression_in_arrayIndexing1309 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_arrayIndexing1313 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_matrixIndexing1327 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000030800UL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1330 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_matrixIndexing1332 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000028800UL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1335 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_matrixIndexing1337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_arguments1355 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000070800UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1358 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_arguments1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1379 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_expressionList1382 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000030800UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1385 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleLambdaParameter_in_lambdaExpression1496 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_typedLambdaParameter_in_lambdaExpression1500 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_lambdaExpression1504 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_lambdaStatement_in_lambdaExpression1506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_simpleLambdaParameter1518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_simpleLambdaParameter1522 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_identifierList_in_simpleLambdaParameter1524 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_simpleLambdaParameter1527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_identifierList1543 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_identifierList1547 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_identifierList1549 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_81_in_typedLambdaParameter1568 = new BitSet(new ulong[]{0x00000000003FFE00UL});
    public static readonly BitSet FOLLOW_typedIdentifierList_in_typedLambdaParameter1570 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_typedLambdaParameter1572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_typedIdentifierList1583 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierList1585 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_typedIdentifierList1589 = new BitSet(new ulong[]{0x00000000003FFE00UL});
    public static readonly BitSet FOLLOW_dataType_in_typedIdentifierList1591 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_typedIdentifierList1593 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_expression_in_lambdaStatement1608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_lambdaStatement1612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_functionPointerType1625 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionPointerType1628 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_functionPointerType1630 = new BitSet(new ulong[]{0x00000000003FFE00UL});
    public static readonly BitSet FOLLOW_typeList_in_functionPointerType1632 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_functionPointerType1634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_typeList1645 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_typeList1649 = new BitSet(new ulong[]{0x00000000003FFE00UL});
    public static readonly BitSet FOLLOW_dataType_in_typeList1651 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_76_in_block1684 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000022800UL});
    public static readonly BitSet FOLLOW_blockStatement_in_block1687 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000022800UL});
    public static readonly BitSet FOLLOW_77_in_block1690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclarationStatement_in_blockStatement1714 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_blockStatement1718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_localVariableDeclarationStatement1742 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_localVariableDeclarationStatement1744 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_localVariableDeclaration1764 = new BitSet(new ulong[]{0x00000000007FFE80UL});
    public static readonly BitSet FOLLOW_variableDeclarator_in_localVariableDeclaration1766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch1787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_blockStatement_in_branch1789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_statement1807 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1809 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_statement1811 = new BitSet(new ulong[]{0x0008000000000002UL});
    public static readonly BitSet FOLLOW_Else_in_statement1821 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_statement1823 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement1835 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_statement1841 = new BitSet(new ulong[]{0x00000000003FFE80UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_forControl_in_statement1844 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_statement1846 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_statement1849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement1859 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_statement1865 = new BitSet(new ulong[]{0x00000000003FFE80UL});
    public static readonly BitSet FOLLOW_foreachControl_in_statement1868 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_statement1870 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_statement1873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_statement1883 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_statement1885 = new BitSet(new ulong[]{0x00000000003FFE80UL});
    public static readonly BitSet FOLLOW_loopControl_in_statement1888 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_statement1890 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_statement1893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_statement1903 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1905 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_statement1907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_statement1917 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_statement1919 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_While_in_statement1921 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1923 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_statement1925 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement1936 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_block_in_statement1938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement1948 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_expression_in_statement1950 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_statement1953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement1964 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_statement1966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Continue_in_statement1977 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_statement1979 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_statement1990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement2001 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_statement2003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl2028 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_forControl2031 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_expression_in_forControl2034 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_forControl2037 = new BitSet(new ulong[]{0x7FF7FE30003FFEA2UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl2040 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit2060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate2079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_foreachControl2110 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_foreachControl2112 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_In_in_foreachControl2114 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_expression_in_foreachControl2116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_loopControl2148 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_loopControl2150 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_To_in_loopControl2152 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000020800UL});
    public static readonly BitSet FOLLOW_expression_in_loopControl2154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex65 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred30_Psimulex705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_synpred31_Psimulex710 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred58_Psimulex1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred59_Psimulex1124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_synpred65_Psimulex1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Else_in_synpred85_Psimulex1821 = new BitSet(new ulong[]{0x7FF7FE30003FFEA0UL,0x0000000000021800UL});
    public static readonly BitSet FOLLOW_branch_in_synpred85_Psimulex1823 = new BitSet(new ulong[]{0x0000000000000002UL});

}
