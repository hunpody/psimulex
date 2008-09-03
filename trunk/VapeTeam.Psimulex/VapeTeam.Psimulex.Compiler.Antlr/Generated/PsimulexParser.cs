// $ANTLR 3.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-09-04 01:08:44

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
		"']'", 
		"','", 
		"'('", 
		"')'", 
		"'.'", 
		"'=>'"
    };

    public const int Stack = 20;
    public const int AssignAndAdd = 23;
    public const int NullLiteral = 48;
    public const int RelGreaterThanOrEqual = 35;
    public const int RelEqual = 30;
    public const int PQueue = 22;
    public const int SingleLineComment = 74;
    public const int CharacterLiteral = 46;
    public const int AssignAndSubstract = 24;
    public const int AssignAndDivide = 26;
    public const int AssignAndMultiply = 25;
    public const int While = 58;
    public const int Decimal = 13;
    public const int Modulo = 40;
    public const int IDLetter = 68;
    public const int Func = 50;
    public const int EOF = -1;
    public const int Queue = 21;
    public const int Set = 18;
    public const int Identifier = 7;
    public const int Int = 12;
    public const int BinTree = 17;
    public const int Assign = 8;
    public const int To = 65;
    public const int PForEach = 56;
    public const int ForEach = 55;
    public const int Char = 11;
    public const int RelNotEqual = 31;
    public const int Do = 59;
    public const int RelGreaterThan = 34;
    public const int String = 14;
    public const int Return = 61;
    public const int Reference = 9;
    public const int Struct = 6;
    public const int AssignAndModulo = 27;
    public const int MultiLineComment = 75;
    public const int If = 51;
    public const int In = 64;
    public const int Import = 4;
    public const int Bool = 10;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int Continue = 63;
    public const int T__83 = 83;
    public const int Void = 15;
    public const int LogicalOr = 28;
    public const int LogicalAnd = 29;
    public const int PDo = 60;
    public const int ElseIf = 66;
    public const int Tree = 16;
    public const int Digit = 69;
    public const int T__85 = 85;
    public const int DecimalLiteral = 45;
    public const int T__84 = 84;
    public const int For = 53;
    public const int Divide = 39;
    public const int List = 19;
    public const int StringLiteral = 5;
    public const int LogicalNot = 43;
    public const int Plus = 36;
    public const int Minus = 37;
    public const int WS = 73;
    public const int Break = 62;
    public const int RelLessThanOrEqual = 33;
    public const int MinusMinus = 42;
    public const int DecimalTypeSuffix = 71;
    public const int PFor = 54;
    public const int NotNullDigit = 70;
    public const int IntegerLiteral = 44;
    public const int RelLessThan = 32;
    public const int Star = 38;
    public const int T__76 = 76;
    public const int Else = 52;
    public const int EscapeSequence = 72;
    public const int Letter = 67;
    public const int Loop = 57;
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:9: simpleProgram
            	        {
            	        	PushFollow(FOLLOW_simpleProgram_in_compilationUnit66);
            	        	simpleProgram1 = simpleProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:25: multiFunctionalProgram
            	        {
            	        	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit70);
            	        	multiFunctionalProgram2 = multiFunctionalProgram();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit74); if (state.failed) return retval;
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:15:1: simpleProgram : ( statement )* ;
    public PsimulexParser.simpleProgram_return simpleProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.simpleProgram_return retval = new PsimulexParser.simpleProgram_return();
        retval.Start = input.LT(1);
        int simpleProgram_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.statement_return statement4 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:2: ( ( statement )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:4: ( statement )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == StringLiteral || LA2_0 == Identifier || (LA2_0 >= Bool && LA2_0 <= PQueue) || (LA2_0 >= Plus && LA2_0 <= Minus) || (LA2_0 >= PlusPlus && LA2_0 <= If) || (LA2_0 >= For && LA2_0 <= Continue) || LA2_0 == 76 || LA2_0 == 82) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_simpleProgram88);
            			    	statement4 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement4.Tree);

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
            			    	PushFollow(FOLLOW_importDeclaration_in_multiFunctionalProgram100);
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
            			    	PushFollow(FOLLOW_typeDeclaration_in_multiFunctionalProgram108);
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
            			    	PushFollow(FOLLOW_globalVariableDeclaration_in_multiFunctionalProgram116);
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

            	    if ( ((LA6_0 >= Bool && LA6_0 <= PQueue) || LA6_0 == Func) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: functionDeclaration
            			    {
            			    	PushFollow(FOLLOW_functionDeclaration_in_multiFunctionalProgram121);
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

            	PushFollow(FOLLOW_memberDeclaration_in_globalVariableDeclaration133);
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

            	Import10=(IToken)Match(input,Import,FOLLOW_Import_in_importDeclaration162); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Import10_tree = (CommonTree)adaptor.Create(Import10);
            		adaptor.AddChild(root_0, Import10_tree);
            	}
            	StringLiteral11=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclaration164); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{StringLiteral11_tree = (CommonTree)adaptor.Create(StringLiteral11);
            		adaptor.AddChild(root_0, StringLiteral11_tree);
            	}
            	char_literal12=(IToken)Match(input,76,FOLLOW_76_in_importDeclaration166); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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

            	PushFollow(FOLLOW_structDeclaration_in_typeDeclaration186);
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

            	Struct14=(IToken)Match(input,Struct,FOLLOW_Struct_in_structDeclaration205); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Struct14_tree = (CommonTree)adaptor.Create(Struct14);
            		adaptor.AddChild(root_0, Struct14_tree);
            	}
            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration207); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier15_tree = (CommonTree)adaptor.Create(Identifier15);
            		adaptor.AddChild(root_0, Identifier15_tree);
            	}
            	PushFollow(FOLLOW_structBody_in_structDeclaration209);
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:55:1: structBody : '{' ( memberDeclaration )+ '}' ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:5: ( '{' ( memberDeclaration )+ '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:9: '{' ( memberDeclaration )+ '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,77,FOLLOW_77_in_structBody228); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:14: ( memberDeclaration )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= Bool && LA7_0 <= PQueue) || LA7_0 == Func) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBody231);
            			    	memberDeclaration18 = memberDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberDeclaration18.Tree);

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

            	char_literal19=(IToken)Match(input,78,FOLLOW_78_in_structBody234); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:59:1: memberDeclaration : type Identifier ( arrayMatrxSize )? ( Assign literal )? ';' ;
    public PsimulexParser.memberDeclaration_return memberDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.memberDeclaration_return retval = new PsimulexParser.memberDeclaration_return();
        retval.Start = input.LT(1);
        int memberDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier21 = null;
        IToken Assign23 = null;
        IToken char_literal25 = null;
        PsimulexParser.type_return type20 = default(PsimulexParser.type_return);

        PsimulexParser.arrayMatrxSize_return arrayMatrxSize22 = default(PsimulexParser.arrayMatrxSize_return);

        PsimulexParser.literal_return literal24 = default(PsimulexParser.literal_return);


        CommonTree Identifier21_tree=null;
        CommonTree Assign23_tree=null;
        CommonTree char_literal25_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:5: ( type Identifier ( arrayMatrxSize )? ( Assign literal )? ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:9: type Identifier ( arrayMatrxSize )? ( Assign literal )? ';'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_memberDeclaration254);
            	type20 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type20.Tree);
            	Identifier21=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberDeclaration256); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier21_tree = (CommonTree)adaptor.Create(Identifier21);
            		adaptor.AddChild(root_0, Identifier21_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:25: ( arrayMatrxSize )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == 79) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: arrayMatrxSize
            	        {
            	        	PushFollow(FOLLOW_arrayMatrxSize_in_memberDeclaration258);
            	        	arrayMatrxSize22 = arrayMatrxSize();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayMatrxSize22.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:41: ( Assign literal )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == Assign) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:42: Assign literal
            	        {
            	        	Assign23=(IToken)Match(input,Assign,FOLLOW_Assign_in_memberDeclaration262); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Assign23_tree = (CommonTree)adaptor.Create(Assign23);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(Assign23_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_literal_in_memberDeclaration265);
            	        	literal24 = literal();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal24.Tree);

            	        }
            	        break;

            	}

            	char_literal25=(IToken)Match(input,76,FOLLOW_76_in_memberDeclaration270); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:1: localVariableDeclaration : type Identifier ( arrayMatrxSize )? ( Assign variableInitializer )? ;
    public PsimulexParser.localVariableDeclaration_return localVariableDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.localVariableDeclaration_return retval = new PsimulexParser.localVariableDeclaration_return();
        retval.Start = input.LT(1);
        int localVariableDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier27 = null;
        IToken Assign29 = null;
        PsimulexParser.type_return type26 = default(PsimulexParser.type_return);

        PsimulexParser.arrayMatrxSize_return arrayMatrxSize28 = default(PsimulexParser.arrayMatrxSize_return);

        PsimulexParser.variableInitializer_return variableInitializer30 = default(PsimulexParser.variableInitializer_return);


        CommonTree Identifier27_tree=null;
        CommonTree Assign29_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:5: ( type Identifier ( arrayMatrxSize )? ( Assign variableInitializer )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:9: type Identifier ( arrayMatrxSize )? ( Assign variableInitializer )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_localVariableDeclaration290);
            	type26 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type26.Tree);
            	Identifier27=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_localVariableDeclaration292); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier27_tree = (CommonTree)adaptor.Create(Identifier27);
            		adaptor.AddChild(root_0, Identifier27_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:25: ( arrayMatrxSize )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 79) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: arrayMatrxSize
            	        {
            	        	PushFollow(FOLLOW_arrayMatrxSize_in_localVariableDeclaration294);
            	        	arrayMatrxSize28 = arrayMatrxSize();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayMatrxSize28.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:41: ( Assign variableInitializer )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == Assign) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:42: Assign variableInitializer
            	        {
            	        	Assign29=(IToken)Match(input,Assign,FOLLOW_Assign_in_localVariableDeclaration298); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Assign29_tree = (CommonTree)adaptor.Create(Assign29);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(Assign29_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_variableInitializer_in_localVariableDeclaration301);
            	        	variableInitializer30 = variableInitializer();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableInitializer30.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:1: variableInitializer : expression ;
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
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:68:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:68:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_variableInitializer326);
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

    public class arrayMatrxSize_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arrayMatrxSize"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:71:1: arrayMatrxSize : ( '[' expression ']' | '[' expression ',' expression ']' ) ;
    public PsimulexParser.arrayMatrxSize_return arrayMatrxSize() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayMatrxSize_return retval = new PsimulexParser.arrayMatrxSize_return();
        retval.Start = input.LT(1);
        int arrayMatrxSize_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal32 = null;
        IToken char_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal37 = null;
        IToken char_literal39 = null;
        PsimulexParser.expression_return expression33 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression36 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression38 = default(PsimulexParser.expression_return);


        CommonTree char_literal32_tree=null;
        CommonTree char_literal34_tree=null;
        CommonTree char_literal35_tree=null;
        CommonTree char_literal37_tree=null;
        CommonTree char_literal39_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:2: ( ( '[' expression ']' | '[' expression ',' expression ']' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:4: ( '[' expression ']' | '[' expression ',' expression ']' )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:4: ( '[' expression ']' | '[' expression ',' expression ']' )
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == 79) )
            	{
            	    int LA12_1 = input.LA(2);

            	    if ( (synpred12_Psimulex()) )
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:6: '[' expression ']'
            	        {
            	        	char_literal32=(IToken)Match(input,79,FOLLOW_79_in_arrayMatrxSize348); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal32_tree = (CommonTree)adaptor.Create(char_literal32);
            	        		adaptor.AddChild(root_0, char_literal32_tree);
            	        	}
            	        	PushFollow(FOLLOW_expression_in_arrayMatrxSize350);
            	        	expression33 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression33.Tree);
            	        	char_literal34=(IToken)Match(input,80,FOLLOW_80_in_arrayMatrxSize352); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal34_tree = (CommonTree)adaptor.Create(char_literal34);
            	        		adaptor.AddChild(root_0, char_literal34_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:27: '[' expression ',' expression ']'
            	        {
            	        	char_literal35=(IToken)Match(input,79,FOLLOW_79_in_arrayMatrxSize356); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal35_tree = (CommonTree)adaptor.Create(char_literal35);
            	        		adaptor.AddChild(root_0, char_literal35_tree);
            	        	}
            	        	PushFollow(FOLLOW_expression_in_arrayMatrxSize358);
            	        	expression36 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression36.Tree);
            	        	char_literal37=(IToken)Match(input,81,FOLLOW_81_in_arrayMatrxSize360); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal37_tree = (CommonTree)adaptor.Create(char_literal37);
            	        		adaptor.AddChild(root_0, char_literal37_tree);
            	        	}
            	        	PushFollow(FOLLOW_expression_in_arrayMatrxSize362);
            	        	expression38 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression38.Tree);
            	        	char_literal39=(IToken)Match(input,80,FOLLOW_80_in_arrayMatrxSize364); if (state.failed) return retval;
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
            	Memoize(input, 12, arrayMatrxSize_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayMatrxSize"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:75:1: functionDeclaration : type ( arrayMatrixType )? Identifier formalParameters block ;
    public PsimulexParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclaration_return retval = new PsimulexParser.functionDeclaration_return();
        retval.Start = input.LT(1);
        int functionDeclaration_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier42 = null;
        PsimulexParser.type_return type40 = default(PsimulexParser.type_return);

        PsimulexParser.arrayMatrixType_return arrayMatrixType41 = default(PsimulexParser.arrayMatrixType_return);

        PsimulexParser.formalParameters_return formalParameters43 = default(PsimulexParser.formalParameters_return);

        PsimulexParser.block_return block44 = default(PsimulexParser.block_return);


        CommonTree Identifier42_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:76:5: ( type ( arrayMatrixType )? Identifier formalParameters block )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:76:7: type ( arrayMatrixType )? Identifier formalParameters block
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_functionDeclaration384);
            	type40 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type40.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:76:12: ( arrayMatrixType )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 79) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: arrayMatrixType
            	        {
            	        	PushFollow(FOLLOW_arrayMatrixType_in_functionDeclaration386);
            	        	arrayMatrixType41 = arrayMatrixType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayMatrixType41.Tree);

            	        }
            	        break;

            	}

            	Identifier42=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration389); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier42_tree = (CommonTree)adaptor.Create(Identifier42);
            		adaptor.AddChild(root_0, Identifier42_tree);
            	}
            	PushFollow(FOLLOW_formalParameters_in_functionDeclaration391);
            	formalParameters43 = formalParameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameters43.Tree);
            	PushFollow(FOLLOW_block_in_functionDeclaration393);
            	block44 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block44.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:79:1: formalParameters : '(' ( formalParameterDecls )? ')' ;
    public PsimulexParser.formalParameters_return formalParameters() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameters_return retval = new PsimulexParser.formalParameters_return();
        retval.Start = input.LT(1);
        int formalParameters_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal47 = null;
        PsimulexParser.formalParameterDecls_return formalParameterDecls46 = default(PsimulexParser.formalParameterDecls_return);


        CommonTree char_literal45_tree=null;
        CommonTree char_literal47_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:5: ( '(' ( formalParameterDecls )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:9: '(' ( formalParameterDecls )? ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal45=(IToken)Match(input,82,FOLLOW_82_in_formalParameters412); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:14: ( formalParameterDecls )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( ((LA14_0 >= Bool && LA14_0 <= PQueue) || LA14_0 == Func) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: formalParameterDecls
            	        {
            	        	PushFollow(FOLLOW_formalParameterDecls_in_formalParameters415);
            	        	formalParameterDecls46 = formalParameterDecls();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDecls46.Tree);

            	        }
            	        break;

            	}

            	char_literal47=(IToken)Match(input,83,FOLLOW_83_in_formalParameters418); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, formalParameters_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:83:1: formalParameterDecls : type ( arrayMatrixType )? ( Reference )? Identifier ( ',' formalParameterDecls )? ;
    public PsimulexParser.formalParameterDecls_return formalParameterDecls() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameterDecls_return retval = new PsimulexParser.formalParameterDecls_return();
        retval.Start = input.LT(1);
        int formalParameterDecls_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Reference50 = null;
        IToken Identifier51 = null;
        IToken char_literal52 = null;
        PsimulexParser.type_return type48 = default(PsimulexParser.type_return);

        PsimulexParser.arrayMatrixType_return arrayMatrixType49 = default(PsimulexParser.arrayMatrixType_return);

        PsimulexParser.formalParameterDecls_return formalParameterDecls53 = default(PsimulexParser.formalParameterDecls_return);


        CommonTree Reference50_tree=null;
        CommonTree Identifier51_tree=null;
        CommonTree char_literal52_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:5: ( type ( arrayMatrixType )? ( Reference )? Identifier ( ',' formalParameterDecls )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:9: type ( arrayMatrixType )? ( Reference )? Identifier ( ',' formalParameterDecls )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_formalParameterDecls442);
            	type48 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type48.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:14: ( arrayMatrixType )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 79) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: arrayMatrixType
            	        {
            	        	PushFollow(FOLLOW_arrayMatrixType_in_formalParameterDecls444);
            	        	arrayMatrixType49 = arrayMatrixType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayMatrixType49.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:31: ( Reference )?
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
            	        	Reference50=(IToken)Match(input,Reference,FOLLOW_Reference_in_formalParameterDecls447); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Reference50_tree = (CommonTree)adaptor.Create(Reference50);
            	        		adaptor.AddChild(root_0, Reference50_tree);
            	        	}

            	        }
            	        break;

            	}

            	Identifier51=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_formalParameterDecls450); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier51_tree = (CommonTree)adaptor.Create(Identifier51);
            		adaptor.AddChild(root_0, Identifier51_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:53: ( ',' formalParameterDecls )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == 81) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:54: ',' formalParameterDecls
            	        {
            	        	char_literal52=(IToken)Match(input,81,FOLLOW_81_in_formalParameterDecls453); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_formalParameterDecls_in_formalParameterDecls456);
            	        	formalParameterDecls53 = formalParameterDecls();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDecls53.Tree);

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
            	Memoize(input, 15, formalParameterDecls_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameterDecls"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:92:1: type : ( dataType | functionPointerType );
    public PsimulexParser.type_return type() // throws RecognitionException [1]
    {   
        PsimulexParser.type_return retval = new PsimulexParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.dataType_return dataType54 = default(PsimulexParser.dataType_return);

        PsimulexParser.functionPointerType_return functionPointerType55 = default(PsimulexParser.functionPointerType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:5: ( dataType | functionPointerType )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( ((LA18_0 >= Bool && LA18_0 <= PQueue)) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == Func) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:93:7: dataType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dataType_in_type488);
                    	dataType54 = dataType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType54.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:94:7: functionPointerType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionPointerType_in_type496);
                    	functionPointerType55 = functionPointerType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionPointerType55.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:97:1: dataType : ( primitiveType | builtInType );
    public PsimulexParser.dataType_return dataType() // throws RecognitionException [1]
    {   
        PsimulexParser.dataType_return retval = new PsimulexParser.dataType_return();
        retval.Start = input.LT(1);
        int dataType_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primitiveType_return primitiveType56 = default(PsimulexParser.primitiveType_return);

        PsimulexParser.builtInType_return builtInType57 = default(PsimulexParser.builtInType_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:98:2: ( primitiveType | builtInType )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( ((LA19_0 >= Bool && LA19_0 <= Void)) )
            {
                alt19 = 1;
            }
            else if ( ((LA19_0 >= Tree && LA19_0 <= PQueue)) )
            {
                alt19 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:98:4: primitiveType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primitiveType_in_dataType510);
                    	primitiveType56 = primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType56.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:98:20: builtInType
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_builtInType_in_dataType514);
                    	builtInType57 = builtInType();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, builtInType57.Tree);

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
            	Memoize(input, 17, dataType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "dataType"

    public class arrayMatrixType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "arrayMatrixType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:101:1: arrayMatrixType : ( '[' ']' | '[' ',' ']' );
    public PsimulexParser.arrayMatrixType_return arrayMatrixType() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayMatrixType_return retval = new PsimulexParser.arrayMatrixType_return();
        retval.Start = input.LT(1);
        int arrayMatrixType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal58 = null;
        IToken char_literal59 = null;
        IToken char_literal60 = null;
        IToken char_literal61 = null;
        IToken char_literal62 = null;

        CommonTree char_literal58_tree=null;
        CommonTree char_literal59_tree=null;
        CommonTree char_literal60_tree=null;
        CommonTree char_literal61_tree=null;
        CommonTree char_literal62_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:2: ( '[' ']' | '[' ',' ']' )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == 79) )
            {
                int LA20_1 = input.LA(2);

                if ( (LA20_1 == 80) )
                {
                    alt20 = 1;
                }
                else if ( (LA20_1 == 81) )
                {
                    alt20 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d20s1 =
                        new NoViableAltException("", 20, 1, input);

                    throw nvae_d20s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:4: '[' ']'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal58=(IToken)Match(input,79,FOLLOW_79_in_arrayMatrixType525); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal58_tree = (CommonTree)adaptor.Create(char_literal58);
                    		adaptor.AddChild(root_0, char_literal58_tree);
                    	}
                    	char_literal59=(IToken)Match(input,80,FOLLOW_80_in_arrayMatrixType527); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal59_tree = (CommonTree)adaptor.Create(char_literal59);
                    		adaptor.AddChild(root_0, char_literal59_tree);
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:102:14: '[' ',' ']'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal60=(IToken)Match(input,79,FOLLOW_79_in_arrayMatrixType531); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal60_tree = (CommonTree)adaptor.Create(char_literal60);
                    		adaptor.AddChild(root_0, char_literal60_tree);
                    	}
                    	char_literal61=(IToken)Match(input,81,FOLLOW_81_in_arrayMatrixType533); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal61_tree = (CommonTree)adaptor.Create(char_literal61);
                    		adaptor.AddChild(root_0, char_literal61_tree);
                    	}
                    	char_literal62=(IToken)Match(input,80,FOLLOW_80_in_arrayMatrixType535); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal62_tree = (CommonTree)adaptor.Create(char_literal62);
                    		adaptor.AddChild(root_0, char_literal62_tree);
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
            	Memoize(input, 18, arrayMatrixType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayMatrixType"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:105:1: primitiveType : ( Bool | Char | Int | Decimal | String | Void );
    public PsimulexParser.primitiveType_return primitiveType() // throws RecognitionException [1]
    {   
        PsimulexParser.primitiveType_return retval = new PsimulexParser.primitiveType_return();
        retval.Start = input.LT(1);
        int primitiveType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set63 = null;

        CommonTree set63_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:106:5: ( Bool | Char | Int | Decimal | String | Void )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set63 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Bool && input.LA(1) <= Void) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set63));
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:115:1: builtInType : ( Tree | BinTree | Set | List | Stack | Queue | PQueue );
    public PsimulexParser.builtInType_return builtInType() // throws RecognitionException [1]
    {   
        PsimulexParser.builtInType_return retval = new PsimulexParser.builtInType_return();
        retval.Start = input.LT(1);
        int builtInType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set64 = null;

        CommonTree set64_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:116:5: ( Tree | BinTree | Set | List | Stack | Queue | PQueue )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set64 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Tree && input.LA(1) <= PQueue) ) 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:134:1: expression : ( assignment | conditionalOrExpression | lambdaExpression );
    public PsimulexParser.expression_return expression() // throws RecognitionException [1]
    {   
        PsimulexParser.expression_return retval = new PsimulexParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.assignment_return assignment65 = default(PsimulexParser.assignment_return);

        PsimulexParser.conditionalOrExpression_return conditionalOrExpression66 = default(PsimulexParser.conditionalOrExpression_return);

        PsimulexParser.lambdaExpression_return lambdaExpression67 = default(PsimulexParser.lambdaExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:2: ( assignment | conditionalOrExpression | lambdaExpression )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                int LA21_1 = input.LA(2);

                if ( (synpred32_Psimulex()) )
                {
                    alt21 = 1;
                }
                else if ( (synpred33_Psimulex()) )
                {
                    alt21 = 2;
                }
                else if ( (true) )
                {
                    alt21 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d21s1 =
                        new NoViableAltException("", 21, 1, input);

                    throw nvae_d21s1;
                }
                }
                break;
            case 82:
            	{
                int LA21_2 = input.LA(2);

                if ( (synpred32_Psimulex()) )
                {
                    alt21 = 1;
                }
                else if ( (synpred33_Psimulex()) )
                {
                    alt21 = 2;
                }
                else if ( (true) )
                {
                    alt21 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d21s2 =
                        new NoViableAltException("", 21, 2, input);

                    throw nvae_d21s2;
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
                alt21 = 2;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expression663);
                    	assignment65 = assignment();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment65.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:136:4: conditionalOrExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalOrExpression_in_expression668);
                    	conditionalOrExpression66 = conditionalOrExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression66.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:137:4: lambdaExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lambdaExpression_in_expression673);
                    	lambdaExpression67 = lambdaExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaExpression67.Tree);

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
            	Memoize(input, 21, expression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:140:1: assignment : leftValue assignmentOperator expression ;
    public PsimulexParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        PsimulexParser.assignment_return retval = new PsimulexParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.leftValue_return leftValue68 = default(PsimulexParser.leftValue_return);

        PsimulexParser.assignmentOperator_return assignmentOperator69 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.expression_return expression70 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:141:2: ( leftValue assignmentOperator expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:141:4: leftValue assignmentOperator expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_leftValue_in_assignment685);
            	leftValue68 = leftValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue68.Tree);
            	PushFollow(FOLLOW_assignmentOperator_in_assignment687);
            	assignmentOperator69 = assignmentOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assignmentOperator69.Tree, root_0);
            	PushFollow(FOLLOW_expression_in_assignment690);
            	expression70 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression70.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, assignment_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:1: assignmentOperator : ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo );
    public PsimulexParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        PsimulexParser.assignmentOperator_return retval = new PsimulexParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set71 = null;

        CommonTree set71_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:2: ( Assign | AssignAndAdd | AssignAndSubstract | AssignAndMultiply | AssignAndDivide | AssignAndModulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set71 = (IToken)input.LT(1);
            	if ( input.LA(1) == Assign || (input.LA(1) >= AssignAndAdd && input.LA(1) <= AssignAndModulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set71));
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
            	Memoize(input, 23, assignmentOperator_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:1: conditionalOrExpression : conditionalAndExpression ( LogicalOr conditionalAndExpression )* ;
    public PsimulexParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalOrExpression_return retval = new PsimulexParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalOr73 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression72 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression74 = default(PsimulexParser.conditionalAndExpression_return);


        CommonTree LogicalOr73_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:5: ( conditionalAndExpression ( LogicalOr conditionalAndExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:9: conditionalAndExpression ( LogicalOr conditionalAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression731);
            	conditionalAndExpression72 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression72.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:34: ( LogicalOr conditionalAndExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == LogicalOr) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:36: LogicalOr conditionalAndExpression
            			    {
            			    	LogicalOr73=(IToken)Match(input,LogicalOr,FOLLOW_LogicalOr_in_conditionalOrExpression735); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalOr73_tree = (CommonTree)adaptor.Create(LogicalOr73);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalOr73_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression738);
            			    	conditionalAndExpression74 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression74.Tree);

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
            	Memoize(input, 24, conditionalOrExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:152:1: conditionalAndExpression : equalityExpression ( LogicalAnd equalityExpression )* ;
    public PsimulexParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalAndExpression_return retval = new PsimulexParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken LogicalAnd76 = null;
        PsimulexParser.equalityExpression_return equalityExpression75 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression77 = default(PsimulexParser.equalityExpression_return);


        CommonTree LogicalAnd76_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:5: ( equalityExpression ( LogicalAnd equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:9: equalityExpression ( LogicalAnd equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression760);
            	equalityExpression75 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression75.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:28: ( LogicalAnd equalityExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == LogicalAnd) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:30: LogicalAnd equalityExpression
            			    {
            			    	LogicalAnd76=(IToken)Match(input,LogicalAnd,FOLLOW_LogicalAnd_in_conditionalAndExpression764); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LogicalAnd76_tree = (CommonTree)adaptor.Create(LogicalAnd76);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(LogicalAnd76_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression767);
            			    	equalityExpression77 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression77.Tree);

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
            	Memoize(input, 25, conditionalAndExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:156:1: equalityExpression : relationalExpression ( ( equalityOp ) relationalExpression )* ;
    public PsimulexParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityExpression_return retval = new PsimulexParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.relationalExpression_return relationalExpression78 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.equalityOp_return equalityOp79 = default(PsimulexParser.equalityOp_return);

        PsimulexParser.relationalExpression_return relationalExpression80 = default(PsimulexParser.relationalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:5: ( relationalExpression ( ( equalityOp ) relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:9: relationalExpression ( ( equalityOp ) relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression789);
            	relationalExpression78 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression78.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:30: ( ( equalityOp ) relationalExpression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= RelEqual && LA24_0 <= RelNotEqual)) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:32: ( equalityOp ) relationalExpression
            			    {
            			    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:32: ( equalityOp )
            			    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:157:34: equalityOp
            			    	{
            			    		PushFollow(FOLLOW_equalityOp_in_equalityExpression795);
            			    		equalityOp79 = equalityOp();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(equalityOp79.Tree, root_0);

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression800);
            			    	relationalExpression80 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression80.Tree);

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
            	Memoize(input, 26, equalityExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:160:1: equalityOp : ( RelEqual | RelNotEqual );
    public PsimulexParser.equalityOp_return equalityOp() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityOp_return retval = new PsimulexParser.equalityOp_return();
        retval.Start = input.LT(1);
        int equalityOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set81 = null;

        CommonTree set81_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:2: ( RelEqual | RelNotEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set81 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelEqual && input.LA(1) <= RelNotEqual) ) 
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
            	Memoize(input, 27, equalityOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:164:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
    public PsimulexParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalExpression_return retval = new PsimulexParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.additiveExpression_return additiveExpression82 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp83 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression84 = default(PsimulexParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression835);
            	additiveExpression82 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression82.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:28: ( relationalOp additiveExpression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( ((LA25_0 >= RelLessThan && LA25_0 <= RelGreaterThanOrEqual)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression839);
            			    	relationalOp83 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relationalOp83.Tree, root_0);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression842);
            			    	additiveExpression84 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression84.Tree);

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
            	Memoize(input, 28, relationalExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:168:1: relationalOp : ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual );
    public PsimulexParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalOp_return retval = new PsimulexParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set85 = null;

        CommonTree set85_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:169:5: ( RelLessThan | RelLessThanOrEqual | RelGreaterThan | RelGreaterThanOrEqual )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set85 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= RelLessThan && input.LA(1) <= RelGreaterThanOrEqual) ) 
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
            	Memoize(input, 29, relationalOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:172:1: additiveExpression : multiplicativeExpression ( additiveOp multiplicativeExpression )* ;
    public PsimulexParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveExpression_return retval = new PsimulexParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression86 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.additiveOp_return additiveOp87 = default(PsimulexParser.additiveOp_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression88 = default(PsimulexParser.multiplicativeExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:5: ( multiplicativeExpression ( additiveOp multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:9: multiplicativeExpression ( additiveOp multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression896);
            	multiplicativeExpression86 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression86.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:34: ( additiveOp multiplicativeExpression )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= Plus && LA26_0 <= Minus)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:36: additiveOp multiplicativeExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOp_in_additiveExpression900);
            			    	additiveOp87 = additiveOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(additiveOp87.Tree, root_0);
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression903);
            			    	multiplicativeExpression88 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression88.Tree);

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
            	Memoize(input, 30, additiveExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:176:1: additiveOp : ( Plus | Minus );
    public PsimulexParser.additiveOp_return additiveOp() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveOp_return retval = new PsimulexParser.additiveOp_return();
        retval.Start = input.LT(1);
        int additiveOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set89 = null;

        CommonTree set89_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:177:2: ( Plus | Minus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set89 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) ) 
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
            	Memoize(input, 31, additiveOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:180:1: multiplicativeExpression : unaryExpression ( multiplicativeOp unaryExpression )* ;
    public PsimulexParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeExpression_return retval = new PsimulexParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryExpression_return unaryExpression90 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.multiplicativeOp_return multiplicativeOp91 = default(PsimulexParser.multiplicativeOp_return);

        PsimulexParser.unaryExpression_return unaryExpression92 = default(PsimulexParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:5: ( unaryExpression ( multiplicativeOp unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:9: unaryExpression ( multiplicativeOp unaryExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression938);
            	unaryExpression90 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression90.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:25: ( multiplicativeOp unaryExpression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= Star && LA27_0 <= Modulo)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:27: multiplicativeOp unaryExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeOp_in_multiplicativeExpression942);
            			    	multiplicativeOp91 = multiplicativeOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(multiplicativeOp91.Tree, root_0);
            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression945);
            			    	unaryExpression92 = unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression92.Tree);

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
            	Memoize(input, 32, multiplicativeExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:184:1: multiplicativeOp : ( Star | Divide | Modulo );
    public PsimulexParser.multiplicativeOp_return multiplicativeOp() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeOp_return retval = new PsimulexParser.multiplicativeOp_return();
        retval.Start = input.LT(1);
        int multiplicativeOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set93 = null;

        CommonTree set93_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:2: ( Star | Divide | Modulo )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set93 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Star && input.LA(1) <= Modulo) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set93));
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
            	Memoize(input, 33, multiplicativeOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:188:1: unaryExpression : ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? | castExpression );
    public PsimulexParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpression_return retval = new PsimulexParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.unaryPrefixOp_return unaryPrefixOp94 = default(PsimulexParser.unaryPrefixOp_return);

        PsimulexParser.unaryExpression_return unaryExpression95 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.primaryExpression_return primaryExpression96 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp97 = default(PsimulexParser.unaryPostfixOp_return);

        PsimulexParser.castExpression_return castExpression98 = default(PsimulexParser.castExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:5: ( unaryPrefixOp unaryExpression | primaryExpression ( unaryPostfixOp )? | castExpression )
            int alt29 = 3;
            switch ( input.LA(1) ) 
            {
            case Plus:
            case Minus:
            case PlusPlus:
            case MinusMinus:
            case LogicalNot:
            	{
                alt29 = 1;
                }
                break;
            case 82:
            	{
                int LA29_2 = input.LA(2);

                if ( (LA29_2 == StringLiteral || LA29_2 == Identifier || (LA29_2 >= Plus && LA29_2 <= Minus) || (LA29_2 >= PlusPlus && LA29_2 <= InfinityLiteral) || LA29_2 == 82) )
                {
                    alt29 = 2;
                }
                else if ( ((LA29_2 >= Bool && LA29_2 <= PQueue)) )
                {
                    alt29 = 3;
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
            case Identifier:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            	{
                alt29 = 2;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:7: unaryPrefixOp unaryExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryPrefixOp_in_unaryExpression980);
                    	unaryPrefixOp94 = unaryPrefixOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPrefixOp94.Tree, root_0);
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression983);
                    	unaryExpression95 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression95.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:7: primaryExpression ( unaryPostfixOp )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpression991);
                    	primaryExpression96 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression96.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:25: ( unaryPostfixOp )?
                    	int alt28 = 2;
                    	int LA28_0 = input.LA(1);

                    	if ( ((LA28_0 >= PlusPlus && LA28_0 <= MinusMinus)) )
                    	{
                    	    alt28 = 1;
                    	}
                    	switch (alt28) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:190:26: unaryPostfixOp
                    	        {
                    	        	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpression994);
                    	        	unaryPostfixOp97 = unaryPostfixOp();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp97.Tree, root_0);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:191:4: castExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpression1002);
                    	castExpression98 = castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, castExpression98.Tree);

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
            	Memoize(input, 34, unaryExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:194:1: castExpression : '(' dataType ')' unaryExpression ;
    public PsimulexParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.castExpression_return retval = new PsimulexParser.castExpression_return();
        retval.Start = input.LT(1);
        int castExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal99 = null;
        IToken char_literal101 = null;
        PsimulexParser.dataType_return dataType100 = default(PsimulexParser.dataType_return);

        PsimulexParser.unaryExpression_return unaryExpression102 = default(PsimulexParser.unaryExpression_return);


        CommonTree char_literal99_tree=null;
        CommonTree char_literal101_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:195:2: ( '(' dataType ')' unaryExpression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:195:4: '(' dataType ')' unaryExpression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal99=(IToken)Match(input,82,FOLLOW_82_in_castExpression1021); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal99_tree = (CommonTree)adaptor.Create(char_literal99);
            		adaptor.AddChild(root_0, char_literal99_tree);
            	}
            	PushFollow(FOLLOW_dataType_in_castExpression1023);
            	dataType100 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType100.Tree);
            	char_literal101=(IToken)Match(input,83,FOLLOW_83_in_castExpression1025); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal101_tree = (CommonTree)adaptor.Create(char_literal101);
            		adaptor.AddChild(root_0, char_literal101_tree);
            	}
            	PushFollow(FOLLOW_unaryExpression_in_castExpression1027);
            	unaryExpression102 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression102.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 35, castExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:198:1: unaryPrefixOp : ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot );
    public PsimulexParser.unaryPrefixOp_return unaryPrefixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPrefixOp_return retval = new PsimulexParser.unaryPrefixOp_return();
        retval.Start = input.LT(1);
        int unaryPrefixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set103 = null;

        CommonTree set103_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:199:2: ( Plus | Minus | PlusPlus | MinusMinus | LogicalNot )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set103 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= Plus && input.LA(1) <= Minus) || (input.LA(1) >= PlusPlus && input.LA(1) <= LogicalNot) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set103));
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
            	Memoize(input, 36, unaryPrefixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:1: unaryPostfixOp : ( PlusPlus | MinusMinus );
    public PsimulexParser.unaryPostfixOp_return unaryPostfixOp() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryPostfixOp_return retval = new PsimulexParser.unaryPostfixOp_return();
        retval.Start = input.LT(1);
        int unaryPostfixOp_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken set104 = null;

        CommonTree set104_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:203:2: ( PlusPlus | MinusMinus )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set104 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PlusPlus && input.LA(1) <= MinusMinus) ) 
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
            	Memoize(input, 37, unaryPostfixOp_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:206:1: unaryExpressionPostPlusPlusMinusMinus : primaryExpression ( unaryPostfixOp )* ;
    public PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return unaryExpressionPostPlusPlusMinusMinus() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return retval = new PsimulexParser.unaryExpressionPostPlusPlusMinusMinus_return();
        retval.Start = input.LT(1);
        int unaryExpressionPostPlusPlusMinusMinus_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.primaryExpression_return primaryExpression105 = default(PsimulexParser.primaryExpression_return);

        PsimulexParser.unaryPostfixOp_return unaryPostfixOp106 = default(PsimulexParser.unaryPostfixOp_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:207:5: ( primaryExpression ( unaryPostfixOp )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:207:9: primaryExpression ( unaryPostfixOp )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1076);
            	primaryExpression105 = primaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression105.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:207:27: ( unaryPostfixOp )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( ((LA30_0 >= PlusPlus && LA30_0 <= MinusMinus)) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:207:28: unaryPostfixOp
            			    {
            			    	PushFollow(FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1079);
            			    	unaryPostfixOp106 = unaryPostfixOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(unaryPostfixOp106.Tree, root_0);

            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 38, unaryExpressionPostPlusPlusMinusMinus_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:1: primaryExpression : ( parExpression | leftValue | literal );
    public PsimulexParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.primaryExpression_return retval = new PsimulexParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.parExpression_return parExpression107 = default(PsimulexParser.parExpression_return);

        PsimulexParser.leftValue_return leftValue108 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal109 = default(PsimulexParser.literal_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:5: ( parExpression | leftValue | literal )
            int alt31 = 3;
            switch ( input.LA(1) ) 
            {
            case 82:
            	{
                int LA31_1 = input.LA(2);

                if ( (synpred61_Psimulex()) )
                {
                    alt31 = 1;
                }
                else if ( (synpred62_Psimulex()) )
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
                alt31 = 2;
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
                alt31 = 3;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:9: parExpression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parExpression_in_primaryExpression1101);
                    	parExpression107 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression107.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:212:7: leftValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1109);
                    	leftValue108 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue108.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:9: literal
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1119);
                    	literal109 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal109.Tree);

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
            	Memoize(input, 39, primaryExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:216:1: parExpression : '(' expression ')' ;
    public PsimulexParser.parExpression_return parExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.parExpression_return retval = new PsimulexParser.parExpression_return();
        retval.Start = input.LT(1);
        int parExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal110 = null;
        IToken char_literal112 = null;
        PsimulexParser.expression_return expression111 = default(PsimulexParser.expression_return);


        CommonTree char_literal110_tree=null;
        CommonTree char_literal112_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:5: ( '(' expression ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:217:9: '(' expression ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal110=(IToken)Match(input,82,FOLLOW_82_in_parExpression1138); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression1141);
            	expression111 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression111.Tree);
            	char_literal112=(IToken)Match(input,83,FOLLOW_83_in_parExpression1143); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 40, parExpression_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:220:1: leftValue : ( variable | selecting );
    public PsimulexParser.leftValue_return leftValue() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValue_return retval = new PsimulexParser.leftValue_return();
        retval.Start = input.LT(1);
        int leftValue_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.variable_return variable113 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting114 = default(PsimulexParser.selecting_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:2: ( variable | selecting )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == Identifier) )
            {
                int LA32_1 = input.LA(2);

                if ( (LA32_1 == EOF || LA32_1 == Assign || (LA32_1 >= AssignAndAdd && LA32_1 <= MinusMinus) || LA32_1 == 76 || (LA32_1 >= 80 && LA32_1 <= 81) || LA32_1 == 83) )
                {
                    alt32 = 1;
                }
                else if ( (LA32_1 == 79 || LA32_1 == 84) )
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
            else if ( (LA32_0 == 82) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:221:4: variable
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1158);
                    	variable113 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable113.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:222:4: selecting
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1163);
                    	selecting114 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting114.Tree);

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
            	Memoize(input, 41, leftValue_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:225:1: variable : Identifier ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier115 = null;

        CommonTree Identifier115_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:226:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:226:4: Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Identifier115=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1174); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier115_tree = (CommonTree)adaptor.Create(Identifier115);
            		adaptor.AddChild(root_0, Identifier115_tree);
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
            	Memoize(input, 42, variable_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:229:1: selecting : ( Identifier | parExpression ) ( selector )+ ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier116 = null;
        PsimulexParser.parExpression_return parExpression117 = default(PsimulexParser.parExpression_return);

        PsimulexParser.selector_return selector118 = default(PsimulexParser.selector_return);


        CommonTree Identifier116_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:2: ( ( Identifier | parExpression ) ( selector )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:4: ( Identifier | parExpression ) ( selector )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:4: ( Identifier | parExpression )
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == Identifier) )
            	{
            	    alt33 = 1;
            	}
            	else if ( (LA33_0 == 82) )
            	{
            	    alt33 = 2;
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:5: Identifier
            	        {
            	        	Identifier116=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selecting1186); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier116_tree = (CommonTree)adaptor.Create(Identifier116);
            	        		adaptor.AddChild(root_0, Identifier116_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:16: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selecting1188);
            	        	parExpression117 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression117.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:230:31: ( selector )+
            	int cnt34 = 0;
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == 79 || LA34_0 == 84) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: selector
            			    {
            			    	PushFollow(FOLLOW_selector_in_selecting1191);
            			    	selector118 = selector();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selector118.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt34 >= 1 ) goto loop34;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(34, input);
            		            throw eee;
            	    }
            	    cnt34++;
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whinging that label 'loop34' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 43, selecting_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:1: selector : ( memberSelect | memberFunctionCall | indexing );
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.memberSelect_return memberSelect119 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall120 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing121 = default(PsimulexParser.indexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:5: ( memberSelect | memberFunctionCall | indexing )
            int alt35 = 3;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == 84) )
            {
                int LA35_1 = input.LA(2);

                if ( (LA35_1 == Identifier) )
                {
                    int LA35_3 = input.LA(3);

                    if ( (LA35_3 == EOF || LA35_3 == Assign || (LA35_3 >= AssignAndAdd && LA35_3 <= MinusMinus) || LA35_3 == 76 || (LA35_3 >= 79 && LA35_3 <= 81) || (LA35_3 >= 83 && LA35_3 <= 84)) )
                    {
                        alt35 = 1;
                    }
                    else if ( (LA35_3 == 82) )
                    {
                        alt35 = 2;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d35s3 =
                            new NoViableAltException("", 35, 3, input);

                        throw nvae_d35s3;
                    }
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d35s1 =
                        new NoViableAltException("", 35, 1, input);

                    throw nvae_d35s1;
                }
            }
            else if ( (LA35_0 == 79) )
            {
                alt35 = 3;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:9: memberSelect
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberSelect_in_selector1208);
                    	memberSelect119 = memberSelect();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect119.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:235:9: memberFunctionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberFunctionCall_in_selector1218);
                    	memberFunctionCall120 = memberFunctionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall120.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:236:9: indexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_indexing_in_selector1228);
                    	indexing121 = indexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing121.Tree);

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
            	Memoize(input, 44, selector_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:239:1: memberSelect : '.' Identifier ;
    public PsimulexParser.memberSelect_return memberSelect() // throws RecognitionException [1]
    {   
        PsimulexParser.memberSelect_return retval = new PsimulexParser.memberSelect_return();
        retval.Start = input.LT(1);
        int memberSelect_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal122 = null;
        IToken Identifier123 = null;

        CommonTree char_literal122_tree=null;
        CommonTree Identifier123_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:240:2: ( '.' Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:240:4: '.' Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal122=(IToken)Match(input,84,FOLLOW_84_in_memberSelect1242); if (state.failed) return retval;
            	Identifier123=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect1245); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier123_tree = (CommonTree)adaptor.Create(Identifier123);
            		adaptor.AddChild(root_0, Identifier123_tree);
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
            	Memoize(input, 45, memberSelect_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:243:1: memberFunctionCall : '.' Identifier arguments ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal124 = null;
        IToken Identifier125 = null;
        PsimulexParser.arguments_return arguments126 = default(PsimulexParser.arguments_return);


        CommonTree char_literal124_tree=null;
        CommonTree Identifier125_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:244:2: ( '.' Identifier arguments )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:244:4: '.' Identifier arguments
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal124=(IToken)Match(input,84,FOLLOW_84_in_memberFunctionCall1256); if (state.failed) return retval;
            	Identifier125=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall1259); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier125_tree = (CommonTree)adaptor.Create(Identifier125);
            		adaptor.AddChild(root_0, Identifier125_tree);
            	}
            	PushFollow(FOLLOW_arguments_in_memberFunctionCall1261);
            	arguments126 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments126.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 46, memberFunctionCall_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:247:1: indexing : ( arrayIndexing | matrixIndexing );
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.arrayIndexing_return arrayIndexing127 = default(PsimulexParser.arrayIndexing_return);

        PsimulexParser.matrixIndexing_return matrixIndexing128 = default(PsimulexParser.matrixIndexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:248:2: ( arrayIndexing | matrixIndexing )
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0 == 79) )
            {
                int LA36_1 = input.LA(2);

                if ( (synpred68_Psimulex()) )
                {
                    alt36 = 1;
                }
                else if ( (true) )
                {
                    alt36 = 2;
                }
                else 
                {
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:248:4: arrayIndexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayIndexing_in_indexing1272);
                    	arrayIndexing127 = arrayIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayIndexing127.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:249:4: matrixIndexing
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixIndexing_in_indexing1277);
                    	matrixIndexing128 = matrixIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, matrixIndexing128.Tree);

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
            	Memoize(input, 47, indexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:252:1: arrayIndexing : l= '[' expression r= ']' ;
    public PsimulexParser.arrayIndexing_return arrayIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayIndexing_return retval = new PsimulexParser.arrayIndexing_return();
        retval.Start = input.LT(1);
        int arrayIndexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken l = null;
        IToken r = null;
        PsimulexParser.expression_return expression129 = default(PsimulexParser.expression_return);


        CommonTree l_tree=null;
        CommonTree r_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:253:2: (l= '[' expression r= ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:253:4: l= '[' expression r= ']'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,79,FOLLOW_79_in_arrayIndexing1291); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_arrayIndexing1294);
            	expression129 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression129.Tree);
            	r=(IToken)Match(input,80,FOLLOW_80_in_arrayIndexing1298); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 48, arrayIndexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:257:1: matrixIndexing : '[' expression ',' expression ']' ;
    public PsimulexParser.matrixIndexing_return matrixIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.matrixIndexing_return retval = new PsimulexParser.matrixIndexing_return();
        retval.Start = input.LT(1);
        int matrixIndexing_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal130 = null;
        IToken char_literal132 = null;
        IToken char_literal134 = null;
        PsimulexParser.expression_return expression131 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression133 = default(PsimulexParser.expression_return);


        CommonTree char_literal130_tree=null;
        CommonTree char_literal132_tree=null;
        CommonTree char_literal134_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:258:2: ( '[' expression ',' expression ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:258:4: '[' expression ',' expression ']'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal130=(IToken)Match(input,79,FOLLOW_79_in_matrixIndexing1312); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_matrixIndexing1315);
            	expression131 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression131.Tree);
            	char_literal132=(IToken)Match(input,81,FOLLOW_81_in_matrixIndexing1317); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_matrixIndexing1320);
            	expression133 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression133.Tree);
            	char_literal134=(IToken)Match(input,80,FOLLOW_80_in_matrixIndexing1322); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 49, matrixIndexing_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:261:1: arguments : '(' ( expressionList )? ')' ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal135 = null;
        IToken char_literal137 = null;
        PsimulexParser.expressionList_return expressionList136 = default(PsimulexParser.expressionList_return);


        CommonTree char_literal135_tree=null;
        CommonTree char_literal137_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:262:5: ( '(' ( expressionList )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:262:9: '(' ( expressionList )? ')'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal135=(IToken)Match(input,82,FOLLOW_82_in_arguments1340); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:262:14: ( expressionList )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == StringLiteral || LA37_0 == Identifier || (LA37_0 >= Plus && LA37_0 <= Minus) || (LA37_0 >= PlusPlus && LA37_0 <= InfinityLiteral) || LA37_0 == 82) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1343);
            	        	expressionList136 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionList136.Tree);

            	        }
            	        break;

            	}

            	char_literal137=(IToken)Match(input,83,FOLLOW_83_in_arguments1346); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 50, arguments_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:265:1: expressionList : expression ( ',' expression )* ;
    public PsimulexParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        PsimulexParser.expressionList_return retval = new PsimulexParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal139 = null;
        PsimulexParser.expression_return expression138 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression140 = default(PsimulexParser.expression_return);


        CommonTree char_literal139_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:5: ( expression ( ',' expression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:7: expression ( ',' expression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1364);
            	expression138 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression138.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:18: ( ',' expression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 81) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:266:19: ',' expression
            			    {
            			    	char_literal139=(IToken)Match(input,81,FOLLOW_81_in_expressionList1367); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_expression_in_expressionList1370);
            			    	expression140 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression140.Tree);

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
            	Memoize(input, 51, expressionList_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
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
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
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
            	Memoize(input, 52, literal_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:285:1: lambdaExpression : ( Identifier | '(' lambdaParameterList ')' ) '=>' lambdaStatement ;
    public PsimulexParser.lambdaExpression_return lambdaExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.lambdaExpression_return retval = new PsimulexParser.lambdaExpression_return();
        retval.Start = input.LT(1);
        int lambdaExpression_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier142 = null;
        IToken char_literal143 = null;
        IToken char_literal145 = null;
        IToken string_literal146 = null;
        PsimulexParser.lambdaParameterList_return lambdaParameterList144 = default(PsimulexParser.lambdaParameterList_return);

        PsimulexParser.lambdaStatement_return lambdaStatement147 = default(PsimulexParser.lambdaStatement_return);


        CommonTree Identifier142_tree=null;
        CommonTree char_literal143_tree=null;
        CommonTree char_literal145_tree=null;
        CommonTree string_literal146_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:286:2: ( ( Identifier | '(' lambdaParameterList ')' ) '=>' lambdaStatement )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:286:4: ( Identifier | '(' lambdaParameterList ')' ) '=>' lambdaStatement
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:286:4: ( Identifier | '(' lambdaParameterList ')' )
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == Identifier) )
            	{
            	    alt39 = 1;
            	}
            	else if ( (LA39_0 == 82) )
            	{
            	    alt39 = 2;
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:286:6: Identifier
            	        {
            	        	Identifier142=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_lambdaExpression1481); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier142_tree = (CommonTree)adaptor.Create(Identifier142);
            	        		adaptor.AddChild(root_0, Identifier142_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:286:19: '(' lambdaParameterList ')'
            	        {
            	        	char_literal143=(IToken)Match(input,82,FOLLOW_82_in_lambdaExpression1485); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal143_tree = (CommonTree)adaptor.Create(char_literal143);
            	        		adaptor.AddChild(root_0, char_literal143_tree);
            	        	}
            	        	PushFollow(FOLLOW_lambdaParameterList_in_lambdaExpression1487);
            	        	lambdaParameterList144 = lambdaParameterList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaParameterList144.Tree);
            	        	char_literal145=(IToken)Match(input,83,FOLLOW_83_in_lambdaExpression1489); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal145_tree = (CommonTree)adaptor.Create(char_literal145);
            	        		adaptor.AddChild(root_0, char_literal145_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal146=(IToken)Match(input,85,FOLLOW_85_in_lambdaExpression1493); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal146_tree = (CommonTree)adaptor.Create(string_literal146);
            		adaptor.AddChild(root_0, string_literal146_tree);
            	}
            	PushFollow(FOLLOW_lambdaStatement_in_lambdaExpression1495);
            	lambdaStatement147 = lambdaStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaStatement147.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 53, lambdaExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lambdaExpression"

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:289:1: lambdaParameterList : lambdaParameter ( ',' lambdaParameter )* ;
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
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:2: ( lambdaParameter ( ',' lambdaParameter )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:4: lambdaParameter ( ',' lambdaParameter )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_lambdaParameter_in_lambdaParameterList1507);
            	lambdaParameter148 = lambdaParameter();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaParameter148.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:20: ( ',' lambdaParameter )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == 81) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:22: ',' lambdaParameter
            			    {
            			    	char_literal149=(IToken)Match(input,81,FOLLOW_81_in_lambdaParameterList1511); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal149_tree = (CommonTree)adaptor.Create(char_literal149);
            			    		adaptor.AddChild(root_0, char_literal149_tree);
            			    	}
            			    	PushFollow(FOLLOW_lambdaParameter_in_lambdaParameterList1513);
            			    	lambdaParameter150 = lambdaParameter();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lambdaParameter150.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 54, lambdaParameterList_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:293:1: lambdaParameter : ( dataType )? Identifier ;
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
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:2: ( ( dataType )? Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:4: ( dataType )? Identifier
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:294:4: ( dataType )?
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
            	        	PushFollow(FOLLOW_dataType_in_lambdaParameter1528);
            	        	dataType151 = dataType();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType151.Tree);

            	        }
            	        break;

            	}

            	Identifier152=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_lambdaParameter1531); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier152_tree = (CommonTree)adaptor.Create(Identifier152);
            		adaptor.AddChild(root_0, Identifier152_tree);
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
            	Memoize(input, 55, lambdaParameter_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:297:1: lambdaStatement : ( expression | block );
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
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:2: ( expression | block )
            int alt42 = 2;
            int LA42_0 = input.LA(1);

            if ( (LA42_0 == StringLiteral || LA42_0 == Identifier || (LA42_0 >= Plus && LA42_0 <= Minus) || (LA42_0 >= PlusPlus && LA42_0 <= InfinityLiteral) || LA42_0 == 82) )
            {
                alt42 = 1;
            }
            else if ( (LA42_0 == 77) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:4: expression
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_lambdaStatement1543);
                    	expression153 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression153.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:298:17: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_lambdaStatement1547);
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
            	Memoize(input, 56, lambdaStatement_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:301:1: functionPointerType : Func '<' dataType '>' ;
    public PsimulexParser.functionPointerType_return functionPointerType() // throws RecognitionException [1]
    {   
        PsimulexParser.functionPointerType_return retval = new PsimulexParser.functionPointerType_return();
        retval.Start = input.LT(1);
        int functionPointerType_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Func155 = null;
        IToken char_literal156 = null;
        IToken char_literal158 = null;
        PsimulexParser.dataType_return dataType157 = default(PsimulexParser.dataType_return);


        CommonTree Func155_tree=null;
        CommonTree char_literal156_tree=null;
        CommonTree char_literal158_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:2: ( Func '<' dataType '>' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:302:4: Func '<' dataType '>'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	Func155=(IToken)Match(input,Func,FOLLOW_Func_in_functionPointerType1559); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Func155_tree = (CommonTree)adaptor.Create(Func155);
            		adaptor.AddChild(root_0, Func155_tree);
            	}
            	char_literal156=(IToken)Match(input,RelLessThan,FOLLOW_RelLessThan_in_functionPointerType1561); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal156_tree = (CommonTree)adaptor.Create(char_literal156);
            		adaptor.AddChild(root_0, char_literal156_tree);
            	}
            	PushFollow(FOLLOW_dataType_in_functionPointerType1563);
            	dataType157 = dataType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dataType157.Tree);
            	char_literal158=(IToken)Match(input,RelGreaterThan,FOLLOW_RelGreaterThan_in_functionPointerType1565); if (state.failed) return retval;
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
            	Memoize(input, 57, functionPointerType_StartIndex); 
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:1: block : '{' ( statement )* '}' ;
    public PsimulexParser.block_return block() // throws RecognitionException [1]
    {   
        PsimulexParser.block_return retval = new PsimulexParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal159 = null;
        IToken char_literal161 = null;
        PsimulexParser.statement_return statement160 = default(PsimulexParser.statement_return);


        CommonTree char_literal159_tree=null;
        CommonTree char_literal161_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:5: ( '{' ( statement )* '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:9: '{' ( statement )* '}'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal159=(IToken)Match(input,77,FOLLOW_77_in_block1591); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:14: ( statement )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == StringLiteral || LA43_0 == Identifier || (LA43_0 >= Bool && LA43_0 <= PQueue) || (LA43_0 >= Plus && LA43_0 <= Minus) || (LA43_0 >= PlusPlus && LA43_0 <= If) || (LA43_0 >= For && LA43_0 <= Continue) || LA43_0 == 76 || LA43_0 == 82) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block1594);
            			    	statement160 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement160.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements

            	char_literal161=(IToken)Match(input,78,FOLLOW_78_in_block1597); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:318:1: branch : ( block | statement );
    public PsimulexParser.branch_return branch() // throws RecognitionException [1]
    {   
        PsimulexParser.branch_return retval = new PsimulexParser.branch_return();
        retval.Start = input.LT(1);
        int branch_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.block_return block162 = default(PsimulexParser.block_return);

        PsimulexParser.statement_return statement163 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:319:5: ( block | statement )
            int alt44 = 2;
            int LA44_0 = input.LA(1);

            if ( (LA44_0 == 77) )
            {
                alt44 = 1;
            }
            else if ( (LA44_0 == StringLiteral || LA44_0 == Identifier || (LA44_0 >= Bool && LA44_0 <= PQueue) || (LA44_0 >= Plus && LA44_0 <= Minus) || (LA44_0 >= PlusPlus && LA44_0 <= If) || (LA44_0 >= For && LA44_0 <= Continue) || LA44_0 == 76 || LA44_0 == 82) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:319:7: block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch1623);
                    	block162 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block162.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:319:15: statement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_branch1627);
                    	statement163 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement163.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:1: statement : ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' | localVariableDeclaration ';' );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken If164 = null;
        IToken Else167 = null;
        IToken set169 = null;
        IToken char_literal170 = null;
        IToken char_literal172 = null;
        IToken set174 = null;
        IToken char_literal175 = null;
        IToken char_literal177 = null;
        IToken Loop179 = null;
        IToken char_literal180 = null;
        IToken char_literal182 = null;
        IToken While184 = null;
        IToken Do187 = null;
        IToken While189 = null;
        IToken char_literal191 = null;
        IToken PDo192 = null;
        IToken Return194 = null;
        IToken char_literal196 = null;
        IToken Break197 = null;
        IToken char_literal198 = null;
        IToken Continue199 = null;
        IToken char_literal200 = null;
        IToken char_literal201 = null;
        IToken char_literal203 = null;
        IToken char_literal205 = null;
        PsimulexParser.parExpression_return parExpression165 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch166 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch168 = default(PsimulexParser.branch_return);

        PsimulexParser.forControl_return forControl171 = default(PsimulexParser.forControl_return);

        PsimulexParser.branch_return branch173 = default(PsimulexParser.branch_return);

        PsimulexParser.foreachControl_return foreachControl176 = default(PsimulexParser.foreachControl_return);

        PsimulexParser.branch_return branch178 = default(PsimulexParser.branch_return);

        PsimulexParser.loopControl_return loopControl181 = default(PsimulexParser.loopControl_return);

        PsimulexParser.branch_return branch183 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression185 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch186 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch188 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression190 = default(PsimulexParser.parExpression_return);

        PsimulexParser.block_return block193 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression195 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression202 = default(PsimulexParser.expression_return);

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration204 = default(PsimulexParser.localVariableDeclaration_return);


        CommonTree If164_tree=null;
        CommonTree Else167_tree=null;
        CommonTree set169_tree=null;
        CommonTree char_literal170_tree=null;
        CommonTree char_literal172_tree=null;
        CommonTree set174_tree=null;
        CommonTree char_literal175_tree=null;
        CommonTree char_literal177_tree=null;
        CommonTree Loop179_tree=null;
        CommonTree char_literal180_tree=null;
        CommonTree char_literal182_tree=null;
        CommonTree While184_tree=null;
        CommonTree Do187_tree=null;
        CommonTree While189_tree=null;
        CommonTree char_literal191_tree=null;
        CommonTree PDo192_tree=null;
        CommonTree Return194_tree=null;
        CommonTree char_literal196_tree=null;
        CommonTree Break197_tree=null;
        CommonTree char_literal198_tree=null;
        CommonTree Continue199_tree=null;
        CommonTree char_literal200_tree=null;
        CommonTree char_literal201_tree=null;
        CommonTree char_literal203_tree=null;
        CommonTree char_literal205_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:5: ( If parExpression branch ( options {k=1; } : Else branch )? | ( For | PFor ) '(' forControl ')' branch | ( ForEach | PForEach ) '(' foreachControl ')' branch | Loop '(' loopControl ')' branch | While parExpression branch | Do branch While parExpression ';' | PDo block | Return ( expression )? ';' | Break ';' | Continue ';' | ';' | expression ';' | localVariableDeclaration ';' )
            int alt47 = 13;
            switch ( input.LA(1) ) 
            {
            case If:
            	{
                alt47 = 1;
                }
                break;
            case For:
            case PFor:
            	{
                alt47 = 2;
                }
                break;
            case ForEach:
            case PForEach:
            	{
                alt47 = 3;
                }
                break;
            case Loop:
            	{
                alt47 = 4;
                }
                break;
            case While:
            	{
                alt47 = 5;
                }
                break;
            case Do:
            	{
                alt47 = 6;
                }
                break;
            case PDo:
            	{
                alt47 = 7;
                }
                break;
            case Return:
            	{
                alt47 = 8;
                }
                break;
            case Break:
            	{
                alt47 = 9;
                }
                break;
            case Continue:
            	{
                alt47 = 10;
                }
                break;
            case 76:
            	{
                alt47 = 11;
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
            case 82:
            	{
                alt47 = 12;
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
                alt47 = 13;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:7: If parExpression branch ( options {k=1; } : Else branch )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	If164=(IToken)Match(input,If,FOLLOW_If_in_statement1645); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{If164_tree = (CommonTree)adaptor.Create(If164);
                    		adaptor.AddChild(root_0, If164_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1647);
                    	parExpression165 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression165.Tree);
                    	PushFollow(FOLLOW_branch_in_statement1649);
                    	branch166 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch166.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:31: ( options {k=1; } : Else branch )?
                    	int alt45 = 2;
                    	int LA45_0 = input.LA(1);

                    	if ( (LA45_0 == Else) )
                    	{
                    	    int LA45_2 = input.LA(2);

                    	    if ( (synpred83_Psimulex()) )
                    	    {
                    	        alt45 = 1;
                    	    }
                    	}
                    	switch (alt45) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:47: Else branch
                    	        {
                    	        	Else167=(IToken)Match(input,Else,FOLLOW_Else_in_statement1659); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{Else167_tree = (CommonTree)adaptor.Create(Else167);
                    	        		adaptor.AddChild(root_0, Else167_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_branch_in_statement1661);
                    	        	branch168 = branch();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch168.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:324:9: ( For | PFor ) '(' forControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set169 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= For && input.LA(1) <= PFor) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set169));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal170=(IToken)Match(input,82,FOLLOW_82_in_statement1679); if (state.failed) return retval;
                    	PushFollow(FOLLOW_forControl_in_statement1682);
                    	forControl171 = forControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forControl171.Tree);
                    	char_literal172=(IToken)Match(input,83,FOLLOW_83_in_statement1684); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement1687);
                    	branch173 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch173.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:325:9: ( ForEach | PForEach ) '(' foreachControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	set174 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= ForEach && input.LA(1) <= PForEach) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set174));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal175=(IToken)Match(input,82,FOLLOW_82_in_statement1703); if (state.failed) return retval;
                    	PushFollow(FOLLOW_foreachControl_in_statement1706);
                    	foreachControl176 = foreachControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, foreachControl176.Tree);
                    	char_literal177=(IToken)Match(input,83,FOLLOW_83_in_statement1708); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement1711);
                    	branch178 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch178.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:326:9: Loop '(' loopControl ')' branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Loop179=(IToken)Match(input,Loop,FOLLOW_Loop_in_statement1721); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Loop179_tree = (CommonTree)adaptor.Create(Loop179);
                    		adaptor.AddChild(root_0, Loop179_tree);
                    	}
                    	char_literal180=(IToken)Match(input,82,FOLLOW_82_in_statement1723); if (state.failed) return retval;
                    	PushFollow(FOLLOW_loopControl_in_statement1726);
                    	loopControl181 = loopControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopControl181.Tree);
                    	char_literal182=(IToken)Match(input,83,FOLLOW_83_in_statement1728); if (state.failed) return retval;
                    	PushFollow(FOLLOW_branch_in_statement1731);
                    	branch183 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch183.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:9: While parExpression branch
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	While184=(IToken)Match(input,While,FOLLOW_While_in_statement1741); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While184_tree = (CommonTree)adaptor.Create(While184);
                    		adaptor.AddChild(root_0, While184_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1743);
                    	parExpression185 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression185.Tree);
                    	PushFollow(FOLLOW_branch_in_statement1745);
                    	branch186 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch186.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:328:9: Do branch While parExpression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Do187=(IToken)Match(input,Do,FOLLOW_Do_in_statement1755); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Do187_tree = (CommonTree)adaptor.Create(Do187);
                    		adaptor.AddChild(root_0, Do187_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement1757);
                    	branch188 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch188.Tree);
                    	While189=(IToken)Match(input,While,FOLLOW_While_in_statement1759); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{While189_tree = (CommonTree)adaptor.Create(While189);
                    		adaptor.AddChild(root_0, While189_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1761);
                    	parExpression190 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression190.Tree);
                    	char_literal191=(IToken)Match(input,76,FOLLOW_76_in_statement1763); if (state.failed) return retval;

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:329:9: PDo block
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PDo192=(IToken)Match(input,PDo,FOLLOW_PDo_in_statement1774); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PDo192_tree = (CommonTree)adaptor.Create(PDo192);
                    		adaptor.AddChild(root_0, PDo192_tree);
                    	}
                    	PushFollow(FOLLOW_block_in_statement1776);
                    	block193 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block193.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:330:9: Return ( expression )? ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Return194=(IToken)Match(input,Return,FOLLOW_Return_in_statement1786); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Return194_tree = (CommonTree)adaptor.Create(Return194);
                    		adaptor.AddChild(root_0, Return194_tree);
                    	}
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:330:16: ( expression )?
                    	int alt46 = 2;
                    	int LA46_0 = input.LA(1);

                    	if ( (LA46_0 == StringLiteral || LA46_0 == Identifier || (LA46_0 >= Plus && LA46_0 <= Minus) || (LA46_0 >= PlusPlus && LA46_0 <= InfinityLiteral) || LA46_0 == 82) )
                    	{
                    	    alt46 = 1;
                    	}
                    	switch (alt46) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement1788);
                    	        	expression195 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression195.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal196=(IToken)Match(input,76,FOLLOW_76_in_statement1791); if (state.failed) return retval;

                    }
                    break;
                case 9 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:9: Break ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Break197=(IToken)Match(input,Break,FOLLOW_Break_in_statement1802); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Break197_tree = (CommonTree)adaptor.Create(Break197);
                    		adaptor.AddChild(root_0, Break197_tree);
                    	}
                    	char_literal198=(IToken)Match(input,76,FOLLOW_76_in_statement1804); if (state.failed) return retval;

                    }
                    break;
                case 10 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:332:9: Continue ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	Continue199=(IToken)Match(input,Continue,FOLLOW_Continue_in_statement1815); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Continue199_tree = (CommonTree)adaptor.Create(Continue199);
                    		adaptor.AddChild(root_0, Continue199_tree);
                    	}
                    	char_literal200=(IToken)Match(input,76,FOLLOW_76_in_statement1817); if (state.failed) return retval;

                    }
                    break;
                case 11 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:9: ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal201=(IToken)Match(input,76,FOLLOW_76_in_statement1828); if (state.failed) return retval;

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:334:9: expression ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_statement1839);
                    	expression202 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression202.Tree);
                    	char_literal203=(IToken)Match(input,76,FOLLOW_76_in_statement1841); if (state.failed) return retval;

                    }
                    break;
                case 13 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:335:7: localVariableDeclaration ';'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_localVariableDeclaration_in_statement1850);
                    	localVariableDeclaration204 = localVariableDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration204.Tree);
                    	char_literal205=(IToken)Match(input,76,FOLLOW_76_in_statement1852); if (state.failed) return retval;

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:338:1: forControl : ( forInit )? ';' ( expression )? ';' ( forUpdate )? ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken char_literal207 = null;
        IToken char_literal209 = null;
        PsimulexParser.forInit_return forInit206 = default(PsimulexParser.forInit_return);

        PsimulexParser.expression_return expression208 = default(PsimulexParser.expression_return);

        PsimulexParser.forUpdate_return forUpdate210 = default(PsimulexParser.forUpdate_return);


        CommonTree char_literal207_tree=null;
        CommonTree char_literal209_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:5: ( ( forInit )? ';' ( expression )? ';' ( forUpdate )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:10: ( forInit )? ';' ( expression )? ';' ( forUpdate )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:10: ( forInit )?
            	int alt48 = 2;
            	int LA48_0 = input.LA(1);

            	if ( ((LA48_0 >= Bool && LA48_0 <= PQueue) || LA48_0 == Func) )
            	{
            	    alt48 = 1;
            	}
            	switch (alt48) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl1877);
            	        	forInit206 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInit206.Tree);

            	        }
            	        break;

            	}

            	char_literal207=(IToken)Match(input,76,FOLLOW_76_in_forControl1880); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:24: ( expression )?
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == StringLiteral || LA49_0 == Identifier || (LA49_0 >= Plus && LA49_0 <= Minus) || (LA49_0 >= PlusPlus && LA49_0 <= InfinityLiteral) || LA49_0 == 82) )
            	{
            	    alt49 = 1;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forControl1883);
            	        	expression208 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression208.Tree);

            	        }
            	        break;

            	}

            	char_literal209=(IToken)Match(input,76,FOLLOW_76_in_forControl1886); if (state.failed) return retval;
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:41: ( forUpdate )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == StringLiteral || LA50_0 == Identifier || (LA50_0 >= Plus && LA50_0 <= Minus) || (LA50_0 >= PlusPlus && LA50_0 <= InfinityLiteral) || LA50_0 == 82) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl1889);
            	        	forUpdate210 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forUpdate210.Tree);

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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:342:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration211 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:343:5: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:343:9: localVariableDeclaration
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit1909);
            	localVariableDeclaration211 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration211.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:346:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        CommonTree root_0 = null;

        PsimulexParser.expression_return expression212 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:9: expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate1928);
            	expression212 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression212.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:1: foreachControl options {k=3; } : type Identifier In expression ;
    public PsimulexParser.foreachControl_return foreachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.foreachControl_return retval = new PsimulexParser.foreachControl_return();
        retval.Start = input.LT(1);
        int foreachControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier214 = null;
        IToken In215 = null;
        PsimulexParser.type_return type213 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression216 = default(PsimulexParser.expression_return);


        CommonTree Identifier214_tree=null;
        CommonTree In215_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:352:5: ( type Identifier In expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:352:9: type Identifier In expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_foreachControl1959);
            	type213 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type213.Tree);
            	Identifier214=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_foreachControl1961); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier214_tree = (CommonTree)adaptor.Create(Identifier214);
            		adaptor.AddChild(root_0, Identifier214_tree);
            	}
            	In215=(IToken)Match(input,In,FOLLOW_In_in_foreachControl1963); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{In215_tree = (CommonTree)adaptor.Create(In215);
            		adaptor.AddChild(root_0, In215_tree);
            	}
            	PushFollow(FOLLOW_expression_in_foreachControl1965);
            	expression216 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression216.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:356:1: loopControl options {k=3; } : type Identifier To expression ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        CommonTree root_0 = null;

        IToken Identifier218 = null;
        IToken To219 = null;
        PsimulexParser.type_return type217 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression220 = default(PsimulexParser.expression_return);


        CommonTree Identifier218_tree=null;
        CommonTree To219_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:5: ( type Identifier To expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:9: type Identifier To expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_loopControl1997);
            	type217 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type217.Tree);
            	Identifier218=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_loopControl1999); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier218_tree = (CommonTree)adaptor.Create(Identifier218);
            		adaptor.AddChild(root_0, Identifier218_tree);
            	}
            	To219=(IToken)Match(input,To,FOLLOW_To_in_loopControl2001); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{To219_tree = (CommonTree)adaptor.Create(To219);
            		adaptor.AddChild(root_0, To219_tree);
            	}
            	PushFollow(FOLLOW_expression_in_loopControl2003);
            	expression220 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression220.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
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
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:9: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:9: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex66);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred12_Psimulex"
    public void synpred12_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:6: ( '[' expression ']' )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:72:6: '[' expression ']'
        {
        	Match(input,79,FOLLOW_79_in_synpred12_Psimulex348); if (state.failed) return ;
        	PushFollow(FOLLOW_expression_in_synpred12_Psimulex350);
        	expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,80,FOLLOW_80_in_synpred12_Psimulex352); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_Psimulex"

    // $ANTLR start "synpred32_Psimulex"
    public void synpred32_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:4: ( assignment )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:135:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred32_Psimulex663);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_Psimulex"

    // $ANTLR start "synpred33_Psimulex"
    public void synpred33_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:136:4: ( conditionalOrExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:136:4: conditionalOrExpression
        {
        	PushFollow(FOLLOW_conditionalOrExpression_in_synpred33_Psimulex668);
        	conditionalOrExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_Psimulex"

    // $ANTLR start "synpred61_Psimulex"
    public void synpred61_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:9: ( parExpression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:211:9: parExpression
        {
        	PushFollow(FOLLOW_parExpression_in_synpred61_Psimulex1101);
        	parExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred61_Psimulex"

    // $ANTLR start "synpred62_Psimulex"
    public void synpred62_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:212:7: ( leftValue )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:212:7: leftValue
        {
        	PushFollow(FOLLOW_leftValue_in_synpred62_Psimulex1109);
        	leftValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred62_Psimulex"

    // $ANTLR start "synpred68_Psimulex"
    public void synpred68_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:248:4: ( arrayIndexing )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:248:4: arrayIndexing
        {
        	PushFollow(FOLLOW_arrayIndexing_in_synpred68_Psimulex1272);
        	arrayIndexing();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred68_Psimulex"

    // $ANTLR start "synpred83_Psimulex"
    public void synpred83_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:47: ( Else branch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:47: Else branch
        {
        	Match(input,Else,FOLLOW_Else_in_synpred83_Psimulex1659); if (state.failed) return ;
        	PushFollow(FOLLOW_branch_in_synpred83_Psimulex1661);
        	branch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred83_Psimulex"

    // Delegated rules

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
   	public bool synpred12_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred32_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_Psimulex_fragment(); // can never throw exception
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


   	protected DFA1 dfa1;
   	protected DFA5 dfa5;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa5 = new DFA5(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);

	}

    const string DFA1_eotS =
        "\x16\uffff";
    const string DFA1_eofS =
        "\x01\x13\x15\uffff";
    const string DFA1_minS =
        "\x01\x04\x0f\uffff\x04\x00\x02\uffff";
    const string DFA1_maxS =
        "\x01\x52\x0f\uffff\x04\x00\x02\uffff";
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
    const string DFA5_eotS =
        "\x0b\uffff";
    const string DFA5_eofS =
        "\x01\x04\x0a\uffff";
    const string DFA5_minS =
        "\x01\x0a\x02\x07\x01\x20\x01\uffff\x01\x08\x01\x0a\x01\uffff\x02"+
        "\x22\x01\x07";
    const string DFA5_maxS =
        "\x01\x32\x02\x4f\x01\x20\x01\uffff\x01\x52\x01\x16\x01\uffff\x02"+
        "\x22\x01\x4f";
    const string DFA5_acceptS =
        "\x04\uffff\x01\x02\x02\uffff\x01\x01\x03\uffff";
    const string DFA5_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x06\x01\x07\x02\x1b\uffff\x01\x03",
            "\x01\x05\x47\uffff\x01\x04",
            "\x01\x05\x47\uffff\x01\x04",
            "\x01\x06",
            "",
            "\x01\x07\x43\uffff\x01\x07\x02\uffff\x01\x07\x02\uffff\x01"+
            "\x04",
            "\x06\x08\x07\x09",
            "",
            "\x01\x0a",
            "\x01\x0a",
            "\x01\x05\x47\uffff\x01\x04"
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

 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit66 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit70 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit74 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_simpleProgram88 = new BitSet(new ulong[]{0xFFEFFE30007FFCA2UL,0x0000000000041000UL});
    public static readonly BitSet FOLLOW_importDeclaration_in_multiFunctionalProgram100 = new BitSet(new ulong[]{0xFFEFFE30007FFCF2UL,0x0000000000049000UL});
    public static readonly BitSet FOLLOW_typeDeclaration_in_multiFunctionalProgram108 = new BitSet(new ulong[]{0xFFEFFE30007FFCE2UL,0x0000000000049000UL});
    public static readonly BitSet FOLLOW_globalVariableDeclaration_in_multiFunctionalProgram116 = new BitSet(new ulong[]{0xFFEFFE30007FFCA2UL,0x0000000000049000UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_multiFunctionalProgram121 = new BitSet(new ulong[]{0xFFEFFE30007FFCA2UL,0x0000000000049000UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_globalVariableDeclaration133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Import_in_importDeclaration162 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclaration164 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_importDeclaration166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclaration186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Struct_in_structDeclaration205 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration207 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_structBody228 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x000000000004D000UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBody231 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x000000000004D000UL});
    public static readonly BitSet FOLLOW_78_in_structBody234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_memberDeclaration254 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberDeclaration256 = new BitSet(new ulong[]{0x0000000000000100UL,0x0000000000009000UL});
    public static readonly BitSet FOLLOW_arrayMatrxSize_in_memberDeclaration258 = new BitSet(new ulong[]{0x0000000000000100UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_Assign_in_memberDeclaration262 = new BitSet(new ulong[]{0x0003F000000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_literal_in_memberDeclaration265 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_memberDeclaration270 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_localVariableDeclaration290 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_localVariableDeclaration292 = new BitSet(new ulong[]{0x0000000000000102UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_arrayMatrxSize_in_localVariableDeclaration294 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_Assign_in_localVariableDeclaration298 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_variableInitializer_in_localVariableDeclaration301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInitializer326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arrayMatrxSize348 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayMatrxSize350 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_arrayMatrxSize352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arrayMatrxSize356 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayMatrxSize358 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_arrayMatrxSize360 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayMatrxSize362 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_arrayMatrxSize364 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_functionDeclaration384 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_arrayMatrixType_in_functionDeclaration386 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration389 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_formalParameters_in_functionDeclaration391 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_formalParameters412 = new BitSet(new ulong[]{0xFFEFFE30007FFEA0UL,0x00000000000C9000UL});
    public static readonly BitSet FOLLOW_formalParameterDecls_in_formalParameters415 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_formalParameters418 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_formalParameterDecls442 = new BitSet(new ulong[]{0x0000000000000280UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_arrayMatrixType_in_formalParameterDecls444 = new BitSet(new ulong[]{0x0000000000000280UL});
    public static readonly BitSet FOLLOW_Reference_in_formalParameterDecls447 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameterDecls450 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_formalParameterDecls453 = new BitSet(new ulong[]{0xFFEFFE30007FFEA0UL,0x0000000000049000UL});
    public static readonly BitSet FOLLOW_formalParameterDecls_in_formalParameterDecls456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dataType_in_type488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionPointerType_in_type496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_dataType510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_builtInType_in_dataType514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arrayMatrixType525 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_arrayMatrixType527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arrayMatrixType531 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_arrayMatrixType533 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_arrayMatrixType535 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expression663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_expression668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lambdaExpression_in_expression673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_assignment685 = new BitSet(new ulong[]{0x000000000F800100UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignment687 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_assignment690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression731 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_LogicalOr_in_conditionalOrExpression735 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression738 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression760 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LogicalAnd_in_conditionalAndExpression764 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression767 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression789 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_equalityOp_in_equalityExpression795 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression800 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression835 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression839 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression842 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression896 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_additiveOp_in_additiveExpression900 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression903 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_set_in_additiveOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression938 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeOp_in_multiplicativeExpression942 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression945 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryPrefixOp_in_unaryExpression980 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpression991 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpression994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpression1002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_castExpression1021 = new BitSet(new ulong[]{0x00000000007FFC00UL});
    public static readonly BitSet FOLLOW_dataType_in_castExpression1023 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_castExpression1025 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPrefixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryPostfixOp0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpressionPostPlusPlusMinusMinus1076 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_unaryPostfixOp_in_unaryExpressionPostPlusPlusMinusMinus1079 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primaryExpression1101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_parExpression1138 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_parExpression1141 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_parExpression1143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1174 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selecting1186 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000108000UL});
    public static readonly BitSet FOLLOW_parExpression_in_selecting1188 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000108000UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1191 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000108000UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector1218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_indexing_in_selector1228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_memberSelect1242 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect1245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_memberFunctionCall1256 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall1259 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall1261 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_indexing1272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixIndexing_in_indexing1277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_arrayIndexing1291 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_arrayIndexing1294 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_arrayIndexing1298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_matrixIndexing1312 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1315 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_matrixIndexing1317 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1320 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_matrixIndexing1322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_arguments1340 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1343 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_arguments1346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1364 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_expressionList1367 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1370 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_lambdaExpression1481 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_82_in_lambdaExpression1485 = new BitSet(new ulong[]{0x00000000007FFC80UL});
    public static readonly BitSet FOLLOW_lambdaParameterList_in_lambdaExpression1487 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_lambdaExpression1489 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_lambdaExpression1493 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000042000UL});
    public static readonly BitSet FOLLOW_lambdaStatement_in_lambdaExpression1495 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lambdaParameter_in_lambdaParameterList1507 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_lambdaParameterList1511 = new BitSet(new ulong[]{0x00000000007FFC80UL});
    public static readonly BitSet FOLLOW_lambdaParameter_in_lambdaParameterList1513 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_dataType_in_lambdaParameter1528 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_lambdaParameter1531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_lambdaStatement1543 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_lambdaStatement1547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Func_in_functionPointerType1559 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_RelLessThan_in_functionPointerType1561 = new BitSet(new ulong[]{0x00000000007FFC00UL});
    public static readonly BitSet FOLLOW_dataType_in_functionPointerType1563 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_RelGreaterThan_in_functionPointerType1565 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_block1591 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000045000UL});
    public static readonly BitSet FOLLOW_statement_in_block1594 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000045000UL});
    public static readonly BitSet FOLLOW_78_in_block1597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch1623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_branch1627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_statement1645 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1647 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_statement1649 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_Else_in_statement1659 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_statement1661 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement1673 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_statement1679 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000041000UL});
    public static readonly BitSet FOLLOW_forControl_in_statement1682 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_statement1684 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_statement1687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement1697 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_statement1703 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000041000UL});
    public static readonly BitSet FOLLOW_foreachControl_in_statement1706 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_statement1708 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_statement1711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Loop_in_statement1721 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_statement1723 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000041000UL});
    public static readonly BitSet FOLLOW_loopControl_in_statement1726 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_statement1728 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_statement1731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_statement1741 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1743 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_statement1745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_statement1755 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_statement1757 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_While_in_statement1759 = new BitSet(new ulong[]{0x0000000000000080UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1761 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_statement1763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PDo_in_statement1774 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000042000UL});
    public static readonly BitSet FOLLOW_block_in_statement1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Return_in_statement1786 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000041000UL});
    public static readonly BitSet FOLLOW_expression_in_statement1788 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_statement1791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Break_in_statement1802 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_statement1804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Continue_in_statement1815 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_statement1817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_statement1828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement1839 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_statement1841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_statement1850 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_statement1852 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl1877 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_forControl1880 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000041000UL});
    public static readonly BitSet FOLLOW_expression_in_forControl1883 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_forControl1886 = new BitSet(new ulong[]{0x0003FE30000000A2UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl1889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit1909 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate1928 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_foreachControl1959 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_foreachControl1961 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_In_in_foreachControl1963 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_foreachControl1965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_loopControl1997 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_Identifier_in_loopControl1999 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_To_in_loopControl2001 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_loopControl2003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex66 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_synpred12_Psimulex348 = new BitSet(new ulong[]{0x0003FE30000000A0UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_expression_in_synpred12_Psimulex350 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_synpred12_Psimulex352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred32_Psimulex663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_synpred33_Psimulex668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_synpred61_Psimulex1101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_synpred62_Psimulex1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_synpred68_Psimulex1272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Else_in_synpred83_Psimulex1659 = new BitSet(new ulong[]{0xFFEFFE30007FFCA0UL,0x0000000000043000UL});
    public static readonly BitSet FOLLOW_branch_in_synpred83_Psimulex1661 = new BitSet(new ulong[]{0x0000000000000002UL});

}
