// $ANTLR 3.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-09-02 01:17:03

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
		"StringLiteral", 
		"Identifier", 
		"LP", 
		"RP", 
		"IntegerLiteral", 
		"DecimalLiteral", 
		"CharacterLiteral", 
		"BooleanLiteral", 
		"NullLiteral", 
		"InfinityLiteral", 
		"Letter", 
		"IDLetter", 
		"Digit", 
		"NotNullDigit", 
		"DecimalTypeSuffix", 
		"EscapeSequence", 
		"WS", 
		"SingleLineComment", 
		"MultiLineComment", 
		"'import'", 
		"';'", 
		"'struct'", 
		"'{'", 
		"'}'", 
		"'='", 
		"'['", 
		"']'", 
		"','", 
		"'bool'", 
		"'char'", 
		"'int'", 
		"'decimal'", 
		"'string'", 
		"'tree'", 
		"'bintree'", 
		"'set'", 
		"'list'", 
		"'stack'", 
		"'queue'", 
		"'pqueue'", 
		"'&'", 
		"'+='", 
		"'-='", 
		"'*='", 
		"'/='", 
		"'%='", 
		"'?'", 
		"':'", 
		"'||'", 
		"'&&'", 
		"'=='", 
		"'!='", 
		"'<'", 
		"'>'", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'%'", 
		"'++'", 
		"'--'", 
		"'!'", 
		"'.'", 
		"'if'", 
		"'else'", 
		"'for'", 
		"'pfor'", 
		"'foreach'", 
		"'loop'", 
		"'while'", 
		"'do'", 
		"'pdo'", 
		"'return'", 
		"'break'", 
		"'continue'", 
		"'in'", 
		"'to'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int NullLiteral = 12;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__29 = 29;
    public const int T__65 = 65;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int T__26 = 26;
    public const int SingleLineComment = 21;
    public const int T__25 = 25;
    public const int RP = 7;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int CharacterLiteral = 10;
    public const int LP = 6;
    public const int T__61 = 61;
    public const int IDLetter = 15;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int Identifier = 5;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int T__50 = 50;
    public const int MultiLineComment = 22;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__80 = 80;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int Digit = 16;
    public const int DecimalLiteral = 9;
    public const int StringLiteral = 4;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 20;
    public const int T__71 = 71;
    public const int T__33 = 33;
    public const int T__72 = 72;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__70 = 70;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int DecimalTypeSuffix = 18;
    public const int NotNullDigit = 17;
    public const int IntegerLiteral = 8;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int EscapeSequence = 19;
    public const int Letter = 14;
    public const int T__73 = 73;
    public const int BooleanLiteral = 11;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int InfinityLiteral = 13;
    public const int T__77 = 77;

    // delegates
    // delegators



        public PsimulexParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PsimulexParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
    		InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[149+1];
             
             
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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "compilationUnit"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:10:1: compilationUnit : ( simpleProgram | multiFunctionalProgram );
    public PsimulexParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        PsimulexParser.compilationUnit_return retval = new PsimulexParser.compilationUnit_return();
        retval.Start = input.LT(1);
        int compilationUnit_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.simpleProgram_return simpleProgram1 = default(PsimulexParser.simpleProgram_return);

        PsimulexParser.multiFunctionalProgram_return multiFunctionalProgram2 = default(PsimulexParser.multiFunctionalProgram_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:11:5: ( simpleProgram | multiFunctionalProgram )
            int alt1 = 2;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:11:7: simpleProgram
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_simpleProgram_in_compilationUnit55);
                    	simpleProgram1 = simpleProgram();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleProgram1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:7: multiFunctionalProgram
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_multiFunctionalProgram_in_compilationUnit63);
                    	multiFunctionalProgram2 = multiFunctionalProgram();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiFunctionalProgram2.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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

    public class globalVariableDeclaration_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "globalVariableDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:15:1: globalVariableDeclaration : fieldDeclaration ;
    public PsimulexParser.globalVariableDeclaration_return globalVariableDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.globalVariableDeclaration_return retval = new PsimulexParser.globalVariableDeclaration_return();
        retval.Start = input.LT(1);
        int globalVariableDeclaration_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.fieldDeclaration_return fieldDeclaration3 = default(PsimulexParser.fieldDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:2: ( fieldDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:4: fieldDeclaration
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_fieldDeclaration_in_globalVariableDeclaration77);
            	fieldDeclaration3 = fieldDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fieldDeclaration3.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, globalVariableDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "globalVariableDeclaration"

    public class simpleProgram_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "simpleProgram"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:19:1: simpleProgram : ( blockStatement )* ;
    public PsimulexParser.simpleProgram_return simpleProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.simpleProgram_return retval = new PsimulexParser.simpleProgram_return();
        retval.Start = input.LT(1);
        int simpleProgram_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.blockStatement_return blockStatement4 = default(PsimulexParser.blockStatement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:2: ( ( blockStatement )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:4: ( blockStatement )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:4: ( blockStatement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= StringLiteral && LA2_0 <= LP) || (LA2_0 >= IntegerLiteral && LA2_0 <= InfinityLiteral) || LA2_0 == 24 || (LA2_0 >= 32 && LA2_0 <= 36) || (LA2_0 >= 58 && LA2_0 <= 59) || (LA2_0 >= 63 && LA2_0 <= 65) || LA2_0 == 67 || (LA2_0 >= 69 && LA2_0 <= 78)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: blockStatement
            			    {
            			    	PushFollow(FOLLOW_blockStatement_in_simpleProgram88);
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, simpleProgram_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "simpleProgram"

    public class multiFunctionalProgram_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiFunctionalProgram"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:23:1: multiFunctionalProgram : ( importDeclaration )* ( typeDeclaration )* ( globalVariableDeclaration )* ( functionDeclaration )* ;
    public PsimulexParser.multiFunctionalProgram_return multiFunctionalProgram() // throws RecognitionException [1]
    {   
        PsimulexParser.multiFunctionalProgram_return retval = new PsimulexParser.multiFunctionalProgram_return();
        retval.Start = input.LT(1);
        int multiFunctionalProgram_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.importDeclaration_return importDeclaration5 = default(PsimulexParser.importDeclaration_return);

        PsimulexParser.typeDeclaration_return typeDeclaration6 = default(PsimulexParser.typeDeclaration_return);

        PsimulexParser.globalVariableDeclaration_return globalVariableDeclaration7 = default(PsimulexParser.globalVariableDeclaration_return);

        PsimulexParser.functionDeclaration_return functionDeclaration8 = default(PsimulexParser.functionDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:24:2: ( ( importDeclaration )* ( typeDeclaration )* ( globalVariableDeclaration )* ( functionDeclaration )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:24:4: ( importDeclaration )* ( typeDeclaration )* ( globalVariableDeclaration )* ( functionDeclaration )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:24:4: ( importDeclaration )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == 23) )
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

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:25:6: ( typeDeclaration )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= 24 && LA4_0 <= 25)) )
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

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:26:6: ( globalVariableDeclaration )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == Identifier) )
            	    {
            	        alt5 = 1;
            	    }


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

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:27:3: ( functionDeclaration )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= 32 && LA6_0 <= 36)) )
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, multiFunctionalProgram_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multiFunctionalProgram"

    public class importDeclaration_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "importDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:44:1: importDeclaration : 'import' StringLiteral ';' ;
    public PsimulexParser.importDeclaration_return importDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.importDeclaration_return retval = new PsimulexParser.importDeclaration_return();
        retval.Start = input.LT(1);
        int importDeclaration_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal9 = null;
        IToken StringLiteral10 = null;
        IToken char_literal11 = null;

        object string_literal9_tree=null;
        object StringLiteral10_tree=null;
        object char_literal11_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:45:5: ( 'import' StringLiteral ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:45:9: 'import' StringLiteral ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal9=(IToken)Match(input,23,FOLLOW_23_in_importDeclaration152); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal9_tree = (object)adaptor.Create(string_literal9);
            		adaptor.AddChild(root_0, string_literal9_tree);
            	}
            	StringLiteral10=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_importDeclaration154); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{StringLiteral10_tree = (object)adaptor.Create(StringLiteral10);
            		adaptor.AddChild(root_0, StringLiteral10_tree);
            	}
            	char_literal11=(IToken)Match(input,24,FOLLOW_24_in_importDeclaration156); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal11_tree = (object)adaptor.Create(char_literal11);
            		adaptor.AddChild(root_0, char_literal11_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "typeDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:48:1: typeDeclaration : ( structDeclaration | ';' );
    public PsimulexParser.typeDeclaration_return typeDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.typeDeclaration_return retval = new PsimulexParser.typeDeclaration_return();
        retval.Start = input.LT(1);
        int typeDeclaration_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal13 = null;
        PsimulexParser.structDeclaration_return structDeclaration12 = default(PsimulexParser.structDeclaration_return);


        object char_literal13_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:49:5: ( structDeclaration | ';' )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == 25) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == 24) )
            {
                alt7 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:49:9: structDeclaration
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structDeclaration_in_typeDeclaration176);
                    	structDeclaration12 = structDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, structDeclaration12.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:50:9: ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal13=(IToken)Match(input,24,FOLLOW_24_in_typeDeclaration186); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal13_tree = (object)adaptor.Create(char_literal13);
                    		adaptor.AddChild(root_0, char_literal13_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:53:1: structDeclaration : 'struct' Identifier structBody ;
    public PsimulexParser.structDeclaration_return structDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.structDeclaration_return retval = new PsimulexParser.structDeclaration_return();
        retval.Start = input.LT(1);
        int structDeclaration_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal14 = null;
        IToken Identifier15 = null;
        PsimulexParser.structBody_return structBody16 = default(PsimulexParser.structBody_return);


        object string_literal14_tree=null;
        object Identifier15_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:5: ( 'struct' Identifier structBody )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:9: 'struct' Identifier structBody
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal14=(IToken)Match(input,25,FOLLOW_25_in_structDeclaration205); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal14_tree = (object)adaptor.Create(string_literal14);
            		adaptor.AddChild(root_0, string_literal14_tree);
            	}
            	Identifier15=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_structDeclaration207); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier15_tree = (object)adaptor.Create(Identifier15);
            		adaptor.AddChild(root_0, Identifier15_tree);
            	}
            	PushFollow(FOLLOW_structBody_in_structDeclaration217);
            	structBody16 = structBody();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, structBody16.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structBody"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:1: structBody : '{' ( structBodyDeclaration )* '}' ;
    public PsimulexParser.structBody_return structBody() // throws RecognitionException [1]
    {   
        PsimulexParser.structBody_return retval = new PsimulexParser.structBody_return();
        retval.Start = input.LT(1);
        int structBody_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal17 = null;
        IToken char_literal19 = null;
        PsimulexParser.structBodyDeclaration_return structBodyDeclaration18 = default(PsimulexParser.structBodyDeclaration_return);


        object char_literal17_tree=null;
        object char_literal19_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:59:5: ( '{' ( structBodyDeclaration )* '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:59:9: '{' ( structBodyDeclaration )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal17=(IToken)Match(input,26,FOLLOW_26_in_structBody236); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal17_tree = (object)adaptor.Create(char_literal17);
            		adaptor.AddChild(root_0, char_literal17_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:59:13: ( structBodyDeclaration )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= 32 && LA8_0 <= 36)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: structBodyDeclaration
            			    {
            			    	PushFollow(FOLLOW_structBodyDeclaration_in_structBody238);
            			    	structBodyDeclaration18 = structBodyDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, structBodyDeclaration18.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	char_literal19=(IToken)Match(input,27,FOLLOW_27_in_structBody241); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal19_tree = (object)adaptor.Create(char_literal19);
            		adaptor.AddChild(root_0, char_literal19_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structBodyDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:62:1: structBodyDeclaration : ( memberDeclaration )+ ;
    public PsimulexParser.structBodyDeclaration_return structBodyDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.structBodyDeclaration_return retval = new PsimulexParser.structBodyDeclaration_return();
        retval.Start = input.LT(1);
        int structBodyDeclaration_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.memberDeclaration_return memberDeclaration20 = default(PsimulexParser.memberDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:5: ( ( memberDeclaration )+ )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:9: ( memberDeclaration )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:9: ( memberDeclaration )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= 32 && LA9_0 <= 36)) )
            	    {
            	        int LA9_2 = input.LA(2);

            	        if ( (synpred9_Psimulex()) )
            	        {
            	            alt9 = 1;
            	        }


            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: memberDeclaration
            			    {
            			    	PushFollow(FOLLOW_memberDeclaration_in_structBodyDeclaration260);
            			    	memberDeclaration20 = memberDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberDeclaration20.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee =
            		                new EarlyExitException(9, input);
            		            throw eee;
            	    }
            	    cnt9++;
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whinging that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "memberDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:66:1: memberDeclaration : type fieldDeclaration ;
    public PsimulexParser.memberDeclaration_return memberDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.memberDeclaration_return retval = new PsimulexParser.memberDeclaration_return();
        retval.Start = input.LT(1);
        int memberDeclaration_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.type_return type21 = default(PsimulexParser.type_return);

        PsimulexParser.fieldDeclaration_return fieldDeclaration22 = default(PsimulexParser.fieldDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:5: ( type fieldDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:67:9: type fieldDeclaration
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_memberDeclaration280);
            	type21 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type21.Tree);
            	PushFollow(FOLLOW_fieldDeclaration_in_memberDeclaration282);
            	fieldDeclaration22 = fieldDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fieldDeclaration22.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fieldDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:70:1: fieldDeclaration : variableDeclaratorId ( '=' literal )? ';' ;
    public PsimulexParser.fieldDeclaration_return fieldDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.fieldDeclaration_return retval = new PsimulexParser.fieldDeclaration_return();
        retval.Start = input.LT(1);
        int fieldDeclaration_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal24 = null;
        IToken char_literal26 = null;
        PsimulexParser.variableDeclaratorId_return variableDeclaratorId23 = default(PsimulexParser.variableDeclaratorId_return);

        PsimulexParser.literal_return literal25 = default(PsimulexParser.literal_return);


        object char_literal24_tree=null;
        object char_literal26_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:71:5: ( variableDeclaratorId ( '=' literal )? ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:71:9: variableDeclaratorId ( '=' literal )? ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaratorId_in_fieldDeclaration301);
            	variableDeclaratorId23 = variableDeclaratorId();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaratorId23.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:71:30: ( '=' literal )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 28) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:71:31: '=' literal
            	        {
            	        	char_literal24=(IToken)Match(input,28,FOLLOW_28_in_fieldDeclaration304); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal24_tree = (object)adaptor.Create(char_literal24);
            	        		adaptor.AddChild(root_0, char_literal24_tree);
            	        	}
            	        	PushFollow(FOLLOW_literal_in_fieldDeclaration306);
            	        	literal25 = literal();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal25.Tree);

            	        }
            	        break;

            	}

            	char_literal26=(IToken)Match(input,24,FOLLOW_24_in_fieldDeclaration311); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal26_tree = (object)adaptor.Create(char_literal26);
            		adaptor.AddChild(root_0, char_literal26_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclarator"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:74:1: variableDeclarator : variableDeclaratorId ( '=' variableInitializer )? ;
    public PsimulexParser.variableDeclarator_return variableDeclarator() // throws RecognitionException [1]
    {   
        PsimulexParser.variableDeclarator_return retval = new PsimulexParser.variableDeclarator_return();
        retval.Start = input.LT(1);
        int variableDeclarator_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal28 = null;
        PsimulexParser.variableDeclaratorId_return variableDeclaratorId27 = default(PsimulexParser.variableDeclaratorId_return);

        PsimulexParser.variableInitializer_return variableInitializer29 = default(PsimulexParser.variableInitializer_return);


        object char_literal28_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:75:5: ( variableDeclaratorId ( '=' variableInitializer )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:75:9: variableDeclaratorId ( '=' variableInitializer )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaratorId_in_variableDeclarator330);
            	variableDeclaratorId27 = variableDeclaratorId();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaratorId27.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:75:30: ( '=' variableInitializer )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 28) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:75:31: '=' variableInitializer
            	        {
            	        	char_literal28=(IToken)Match(input,28,FOLLOW_28_in_variableDeclarator333); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal28_tree = (object)adaptor.Create(char_literal28);
            	        		adaptor.AddChild(root_0, char_literal28_tree);
            	        	}
            	        	PushFollow(FOLLOW_variableInitializer_in_variableDeclarator335);
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:78:1: functionDeclaration : type Identifier '(' formalParameters ')' block ;
    public PsimulexParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.functionDeclaration_return retval = new PsimulexParser.functionDeclaration_return();
        retval.Start = input.LT(1);
        int functionDeclaration_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier31 = null;
        IToken char_literal32 = null;
        IToken char_literal34 = null;
        PsimulexParser.type_return type30 = default(PsimulexParser.type_return);

        PsimulexParser.formalParameters_return formalParameters33 = default(PsimulexParser.formalParameters_return);

        PsimulexParser.block_return block35 = default(PsimulexParser.block_return);


        object Identifier31_tree=null;
        object char_literal32_tree=null;
        object char_literal34_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:79:5: ( type Identifier '(' formalParameters ')' block )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:80:6: type Identifier '(' formalParameters ')' block
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_functionDeclaration359);
            	type30 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type30.Tree);
            	Identifier31=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration361); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier31_tree = (object)adaptor.Create(Identifier31);
            		adaptor.AddChild(root_0, Identifier31_tree);
            	}
            	char_literal32=(IToken)Match(input,LP,FOLLOW_LP_in_functionDeclaration363); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal32_tree = (object)adaptor.Create(char_literal32);
            		adaptor.AddChild(root_0, char_literal32_tree);
            	}
            	PushFollow(FOLLOW_formalParameters_in_functionDeclaration365);
            	formalParameters33 = formalParameters();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameters33.Tree);
            	char_literal34=(IToken)Match(input,RP,FOLLOW_RP_in_functionDeclaration367); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal34_tree = (object)adaptor.Create(char_literal34);
            		adaptor.AddChild(root_0, char_literal34_tree);
            	}
            	PushFollow(FOLLOW_block_in_functionDeclaration369);
            	block35 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block35.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclaratorId"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:84:1: variableDeclaratorId : Identifier ( '[' ']' | '[' ',' ']' )? ;
    public PsimulexParser.variableDeclaratorId_return variableDeclaratorId() // throws RecognitionException [1]
    {   
        PsimulexParser.variableDeclaratorId_return retval = new PsimulexParser.variableDeclaratorId_return();
        retval.Start = input.LT(1);
        int variableDeclaratorId_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier36 = null;
        IToken char_literal37 = null;
        IToken char_literal38 = null;
        IToken char_literal39 = null;
        IToken char_literal40 = null;
        IToken char_literal41 = null;

        object Identifier36_tree=null;
        object char_literal37_tree=null;
        object char_literal38_tree=null;
        object char_literal39_tree=null;
        object char_literal40_tree=null;
        object char_literal41_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:5: ( Identifier ( '[' ']' | '[' ',' ']' )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:9: Identifier ( '[' ']' | '[' ',' ']' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier36=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableDeclaratorId397); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier36_tree = (object)adaptor.Create(Identifier36);
            		adaptor.AddChild(root_0, Identifier36_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:20: ( '[' ']' | '[' ',' ']' )?
            	int alt12 = 3;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == 29) )
            	{
            	    int LA12_1 = input.LA(2);

            	    if ( (LA12_1 == 30) )
            	    {
            	        alt12 = 1;
            	    }
            	    else if ( (LA12_1 == 31) )
            	    {
            	        alt12 = 2;
            	    }
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:21: '[' ']'
            	        {
            	        	char_literal37=(IToken)Match(input,29,FOLLOW_29_in_variableDeclaratorId400); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal37_tree = (object)adaptor.Create(char_literal37);
            	        		adaptor.AddChild(root_0, char_literal37_tree);
            	        	}
            	        	char_literal38=(IToken)Match(input,30,FOLLOW_30_in_variableDeclaratorId402); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal38_tree = (object)adaptor.Create(char_literal38);
            	        		adaptor.AddChild(root_0, char_literal38_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:85:29: '[' ',' ']'
            	        {
            	        	char_literal39=(IToken)Match(input,29,FOLLOW_29_in_variableDeclaratorId404); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal39_tree = (object)adaptor.Create(char_literal39);
            	        		adaptor.AddChild(root_0, char_literal39_tree);
            	        	}
            	        	char_literal40=(IToken)Match(input,31,FOLLOW_31_in_variableDeclaratorId406); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal40_tree = (object)adaptor.Create(char_literal40);
            	        		adaptor.AddChild(root_0, char_literal40_tree);
            	        	}
            	        	char_literal41=(IToken)Match(input,30,FOLLOW_30_in_variableDeclaratorId408); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal41_tree = (object)adaptor.Create(char_literal41);
            	        		adaptor.AddChild(root_0, char_literal41_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableInitializer"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:88:1: variableInitializer : ( | expression );
    public PsimulexParser.variableInitializer_return variableInitializer() // throws RecognitionException [1]
    {   
        PsimulexParser.variableInitializer_return retval = new PsimulexParser.variableInitializer_return();
        retval.Start = input.LT(1);
        int variableInitializer_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.expression_return expression42 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:89:5: ( | expression )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == EOF || LA13_0 == 24) )
            {
                alt13 = 1;
            }
            else if ( ((LA13_0 >= StringLiteral && LA13_0 <= LP) || (LA13_0 >= IntegerLiteral && LA13_0 <= InfinityLiteral) || (LA13_0 >= 58 && LA13_0 <= 59) || (LA13_0 >= 63 && LA13_0 <= 65)) )
            {
                alt13 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:90:5: 
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:90:9: expression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_variableInitializer439);
                    	expression42 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression42.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:99:1: type : primitiveType ( '[' ']' | '[' ',' ']' )? ;
    public PsimulexParser.type_return type() // throws RecognitionException [1]
    {   
        PsimulexParser.type_return retval = new PsimulexParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal44 = null;
        IToken char_literal45 = null;
        IToken char_literal46 = null;
        IToken char_literal47 = null;
        IToken char_literal48 = null;
        PsimulexParser.primitiveType_return primitiveType43 = default(PsimulexParser.primitiveType_return);


        object char_literal44_tree=null;
        object char_literal45_tree=null;
        object char_literal46_tree=null;
        object char_literal47_tree=null;
        object char_literal48_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:5: ( primitiveType ( '[' ']' | '[' ',' ']' )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:7: primitiveType ( '[' ']' | '[' ',' ']' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_primitiveType_in_type467);
            	primitiveType43 = primitiveType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primitiveType43.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:21: ( '[' ']' | '[' ',' ']' )?
            	int alt14 = 3;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 29) )
            	{
            	    int LA14_1 = input.LA(2);

            	    if ( (LA14_1 == 30) )
            	    {
            	        alt14 = 1;
            	    }
            	    else if ( (LA14_1 == 31) )
            	    {
            	        alt14 = 2;
            	    }
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:22: '[' ']'
            	        {
            	        	char_literal44=(IToken)Match(input,29,FOLLOW_29_in_type470); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal44_tree = (object)adaptor.Create(char_literal44);
            	        		adaptor.AddChild(root_0, char_literal44_tree);
            	        	}
            	        	char_literal45=(IToken)Match(input,30,FOLLOW_30_in_type472); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal45_tree = (object)adaptor.Create(char_literal45);
            	        		adaptor.AddChild(root_0, char_literal45_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:100:30: '[' ',' ']'
            	        {
            	        	char_literal46=(IToken)Match(input,29,FOLLOW_29_in_type474); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal46_tree = (object)adaptor.Create(char_literal46);
            	        		adaptor.AddChild(root_0, char_literal46_tree);
            	        	}
            	        	char_literal47=(IToken)Match(input,31,FOLLOW_31_in_type476); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal47_tree = (object)adaptor.Create(char_literal47);
            	        		adaptor.AddChild(root_0, char_literal47_tree);
            	        	}
            	        	char_literal48=(IToken)Match(input,30,FOLLOW_30_in_type478); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal48_tree = (object)adaptor.Create(char_literal48);
            	        		adaptor.AddChild(root_0, char_literal48_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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

    public class primitiveType_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "primitiveType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:103:1: primitiveType : ( 'bool' | 'char' | 'int' | 'decimal' | 'string' );
    public PsimulexParser.primitiveType_return primitiveType() // throws RecognitionException [1]
    {   
        PsimulexParser.primitiveType_return retval = new PsimulexParser.primitiveType_return();
        retval.Start = input.LT(1);
        int primitiveType_StartIndex = input.Index();
        object root_0 = null;

        IToken set49 = null;

        object set49_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:104:5: ( 'bool' | 'char' | 'int' | 'decimal' | 'string' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set49 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 32 && input.LA(1) <= 36) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set49));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, primitiveType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "primitiveType"

    public class builtInType_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "builtInType"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:112:1: builtInType : ( 'tree' | 'bintree' | 'set' | 'list' | 'stack' | 'queue' | 'pqueue' );
    public PsimulexParser.builtInType_return builtInType() // throws RecognitionException [1]
    {   
        PsimulexParser.builtInType_return retval = new PsimulexParser.builtInType_return();
        retval.Start = input.LT(1);
        int builtInType_StartIndex = input.Index();
        object root_0 = null;

        IToken set50 = null;

        object set50_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:113:5: ( 'tree' | 'bintree' | 'set' | 'list' | 'stack' | 'queue' | 'pqueue' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set50 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 37 && input.LA(1) <= 43) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set50));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, builtInType_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "builtInType"

    public class formalParameters_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "formalParameters"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:123:1: formalParameters : '(' ( formalParameterDecls )? ')' ;
    public PsimulexParser.formalParameters_return formalParameters() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameters_return retval = new PsimulexParser.formalParameters_return();
        retval.Start = input.LT(1);
        int formalParameters_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal51 = null;
        IToken char_literal53 = null;
        PsimulexParser.formalParameterDecls_return formalParameterDecls52 = default(PsimulexParser.formalParameterDecls_return);


        object char_literal51_tree=null;
        object char_literal53_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:5: ( '(' ( formalParameterDecls )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:9: '(' ( formalParameterDecls )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal51=(IToken)Match(input,LP,FOLLOW_LP_in_formalParameters631); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal51_tree = (object)adaptor.Create(char_literal51);
            		adaptor.AddChild(root_0, char_literal51_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:124:13: ( formalParameterDecls )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( ((LA15_0 >= 32 && LA15_0 <= 36)) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: formalParameterDecls
            	        {
            	        	PushFollow(FOLLOW_formalParameterDecls_in_formalParameters633);
            	        	formalParameterDecls52 = formalParameterDecls();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDecls52.Tree);

            	        }
            	        break;

            	}

            	char_literal53=(IToken)Match(input,RP,FOLLOW_RP_in_formalParameters636); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal53_tree = (object)adaptor.Create(char_literal53);
            		adaptor.AddChild(root_0, char_literal53_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, formalParameters_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameters"

    public class formalParameterDecls_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "formalParameterDecls"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:127:1: formalParameterDecls : type ( '&' )? formalParameterDeclsRest ;
    public PsimulexParser.formalParameterDecls_return formalParameterDecls() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameterDecls_return retval = new PsimulexParser.formalParameterDecls_return();
        retval.Start = input.LT(1);
        int formalParameterDecls_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal55 = null;
        PsimulexParser.type_return type54 = default(PsimulexParser.type_return);

        PsimulexParser.formalParameterDeclsRest_return formalParameterDeclsRest56 = default(PsimulexParser.formalParameterDeclsRest_return);


        object char_literal55_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:5: ( type ( '&' )? formalParameterDeclsRest )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:9: type ( '&' )? formalParameterDeclsRest
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_formalParameterDecls659);
            	type54 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type54.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:14: ( '&' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 44) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:128:15: '&'
            	        {
            	        	char_literal55=(IToken)Match(input,44,FOLLOW_44_in_formalParameterDecls662); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal55_tree = (object)adaptor.Create(char_literal55);
            	        		adaptor.AddChild(root_0, char_literal55_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_formalParameterDeclsRest_in_formalParameterDecls666);
            	formalParameterDeclsRest56 = formalParameterDeclsRest();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDeclsRest56.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, formalParameterDecls_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameterDecls"

    public class formalParameterDeclsRest_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "formalParameterDeclsRest"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:131:1: formalParameterDeclsRest : variableDeclaratorId ( ',' formalParameterDecls )? ;
    public PsimulexParser.formalParameterDeclsRest_return formalParameterDeclsRest() // throws RecognitionException [1]
    {   
        PsimulexParser.formalParameterDeclsRest_return retval = new PsimulexParser.formalParameterDeclsRest_return();
        retval.Start = input.LT(1);
        int formalParameterDeclsRest_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal58 = null;
        PsimulexParser.variableDeclaratorId_return variableDeclaratorId57 = default(PsimulexParser.variableDeclaratorId_return);

        PsimulexParser.formalParameterDecls_return formalParameterDecls59 = default(PsimulexParser.formalParameterDecls_return);


        object char_literal58_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:5: ( variableDeclaratorId ( ',' formalParameterDecls )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:9: variableDeclaratorId ( ',' formalParameterDecls )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaratorId_in_formalParameterDeclsRest689);
            	variableDeclaratorId57 = variableDeclaratorId();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaratorId57.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:30: ( ',' formalParameterDecls )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == 31) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:132:31: ',' formalParameterDecls
            	        {
            	        	char_literal58=(IToken)Match(input,31,FOLLOW_31_in_formalParameterDeclsRest692); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal58_tree = (object)adaptor.Create(char_literal58);
            	        		adaptor.AddChild(root_0, char_literal58_tree);
            	        	}
            	        	PushFollow(FOLLOW_formalParameterDecls_in_formalParameterDeclsRest694);
            	        	formalParameterDecls59 = formalParameterDecls();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, formalParameterDecls59.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, formalParameterDeclsRest_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "formalParameterDeclsRest"

    public class parExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:144:1: parExpression : LP expression RP ;
    public PsimulexParser.parExpression_return parExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.parExpression_return retval = new PsimulexParser.parExpression_return();
        retval.Start = input.LT(1);
        int parExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken LP60 = null;
        IToken RP62 = null;
        PsimulexParser.expression_return expression61 = default(PsimulexParser.expression_return);


        object LP60_tree=null;
        object RP62_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:5: ( LP expression RP )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:145:9: LP expression RP
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LP60=(IToken)Match(input,LP,FOLLOW_LP_in_parExpression724); if (state.failed) return retval;
            	PushFollow(FOLLOW_expression_in_parExpression727);
            	expression61 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression61.Tree);
            	RP62=(IToken)Match(input,RP,FOLLOW_RP_in_parExpression729); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, parExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "parExpression"

    public class expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:148:1: expression : conditionalExpression ( assignmentOperator expression )? ;
    public PsimulexParser.expression_return expression() // throws RecognitionException [1]
    {   
        PsimulexParser.expression_return retval = new PsimulexParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.conditionalExpression_return conditionalExpression63 = default(PsimulexParser.conditionalExpression_return);

        PsimulexParser.assignmentOperator_return assignmentOperator64 = default(PsimulexParser.assignmentOperator_return);

        PsimulexParser.expression_return expression65 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:5: ( conditionalExpression ( assignmentOperator expression )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:9: conditionalExpression ( assignmentOperator expression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression753);
            	conditionalExpression63 = conditionalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression63.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:31: ( assignmentOperator expression )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 28 || (LA18_0 >= 45 && LA18_0 <= 49)) )
            	{
            	    int LA18_1 = input.LA(2);

            	    if ( (synpred30_Psimulex()) )
            	    {
            	        alt18 = 1;
            	    }
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:32: assignmentOperator expression
            	        {
            	        	PushFollow(FOLLOW_assignmentOperator_in_expression756);
            	        	assignmentOperator64 = assignmentOperator();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentOperator64.Tree);
            	        	PushFollow(FOLLOW_expression_in_expression758);
            	        	expression65 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression65.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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

    public class assignmentOperator_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignmentOperator"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:152:1: assignmentOperator : ( '=' | '+=' | '-=' | '*=' | '/=' | '%=' );
    public PsimulexParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        PsimulexParser.assignmentOperator_return retval = new PsimulexParser.assignmentOperator_return();
        retval.Start = input.LT(1);
        int assignmentOperator_StartIndex = input.Index();
        object root_0 = null;

        IToken set66 = null;

        object set66_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:153:5: ( '=' | '+=' | '-=' | '*=' | '/=' | '%=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set66 = (IToken)input.LT(1);
            	if ( input.LA(1) == 28 || (input.LA(1) >= 45 && input.LA(1) <= 49) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set66));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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

    public class conditionalExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:161:1: conditionalExpression : conditionalOrExpression ( '?' expression ':' expression )? ;
    public PsimulexParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalExpression_return retval = new PsimulexParser.conditionalExpression_return();
        retval.Start = input.LT(1);
        int conditionalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal68 = null;
        IToken char_literal70 = null;
        PsimulexParser.conditionalOrExpression_return conditionalOrExpression67 = default(PsimulexParser.conditionalOrExpression_return);

        PsimulexParser.expression_return expression69 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression71 = default(PsimulexParser.expression_return);


        object char_literal68_tree=null;
        object char_literal70_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:5: ( conditionalOrExpression ( '?' expression ':' expression )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:9: conditionalOrExpression ( '?' expression ':' expression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression852);
            	conditionalOrExpression67 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression67.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:33: ( '?' expression ':' expression )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 50) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:162:35: '?' expression ':' expression
            	        {
            	        	char_literal68=(IToken)Match(input,50,FOLLOW_50_in_conditionalExpression856); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal68_tree = (object)adaptor.Create(char_literal68);
            	        		adaptor.AddChild(root_0, char_literal68_tree);
            	        	}
            	        	PushFollow(FOLLOW_expression_in_conditionalExpression858);
            	        	expression69 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression69.Tree);
            	        	char_literal70=(IToken)Match(input,51,FOLLOW_51_in_conditionalExpression860); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal70_tree = (object)adaptor.Create(char_literal70);
            	        		adaptor.AddChild(root_0, char_literal70_tree);
            	        	}
            	        	PushFollow(FOLLOW_expression_in_conditionalExpression862);
            	        	expression71 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression71.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, conditionalExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "conditionalExpression"

    public class conditionalOrExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalOrExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:165:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public PsimulexParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalOrExpression_return retval = new PsimulexParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal73 = null;
        PsimulexParser.conditionalAndExpression_return conditionalAndExpression72 = default(PsimulexParser.conditionalAndExpression_return);

        PsimulexParser.conditionalAndExpression_return conditionalAndExpression74 = default(PsimulexParser.conditionalAndExpression_return);


        object string_literal73_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression884);
            	conditionalAndExpression72 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression72.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == 52) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:166:36: '||' conditionalAndExpression
            			    {
            			    	string_literal73=(IToken)Match(input,52,FOLLOW_52_in_conditionalOrExpression888); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal73_tree = (object)adaptor.Create(string_literal73);
            			    		adaptor.AddChild(root_0, string_literal73_tree);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression890);
            			    	conditionalAndExpression74 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression74.Tree);

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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalAndExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:169:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public PsimulexParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.conditionalAndExpression_return retval = new PsimulexParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal76 = null;
        PsimulexParser.equalityExpression_return equalityExpression75 = default(PsimulexParser.equalityExpression_return);

        PsimulexParser.equalityExpression_return equalityExpression77 = default(PsimulexParser.equalityExpression_return);


        object string_literal76_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression912);
            	equalityExpression75 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression75.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 53) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:170:30: '&&' equalityExpression
            			    {
            			    	string_literal76=(IToken)Match(input,53,FOLLOW_53_in_conditionalAndExpression916); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal76_tree = (object)adaptor.Create(string_literal76);
            			    		adaptor.AddChild(root_0, string_literal76_tree);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression918);
            			    	equalityExpression77 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression77.Tree);

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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:173:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public PsimulexParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.equalityExpression_return retval = new PsimulexParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken set79 = null;
        PsimulexParser.relationalExpression_return relationalExpression78 = default(PsimulexParser.relationalExpression_return);

        PsimulexParser.relationalExpression_return relationalExpression80 = default(PsimulexParser.relationalExpression_return);


        object set79_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression940);
            	relationalExpression78 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression78.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( ((LA22_0 >= 54 && LA22_0 <= 55)) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:174:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	set79 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 54 && input.LA(1) <= 55) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set79));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression952);
            			    	relationalExpression80 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression80.Tree);

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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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

    public class relationalExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:177:1: relationalExpression : additiveExpression ( relationalOp additiveExpression )* ;
    public PsimulexParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalExpression_return retval = new PsimulexParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.additiveExpression_return additiveExpression81 = default(PsimulexParser.additiveExpression_return);

        PsimulexParser.relationalOp_return relationalOp82 = default(PsimulexParser.relationalOp_return);

        PsimulexParser.additiveExpression_return additiveExpression83 = default(PsimulexParser.additiveExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:5: ( additiveExpression ( relationalOp additiveExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:9: additiveExpression ( relationalOp additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression974);
            	additiveExpression81 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression81.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:28: ( relationalOp additiveExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( ((LA23_0 >= 56 && LA23_0 <= 57)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:178:30: relationalOp additiveExpression
            			    {
            			    	PushFollow(FOLLOW_relationalOp_in_relationalExpression978);
            			    	relationalOp82 = relationalOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalOp82.Tree);
            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression980);
            			    	additiveExpression83 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression83.Tree);

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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "relationalOp"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:181:1: relationalOp : ( ( '<' '=' )=>t1= '<' t2= '=' {...}? | ( '>' '=' )=>t1= '>' t2= '=' {...}? | '<' | '>' );
    public PsimulexParser.relationalOp_return relationalOp() // throws RecognitionException [1]
    {   
        PsimulexParser.relationalOp_return retval = new PsimulexParser.relationalOp_return();
        retval.Start = input.LT(1);
        int relationalOp_StartIndex = input.Index();
        object root_0 = null;

        IToken t1 = null;
        IToken t2 = null;
        IToken char_literal84 = null;
        IToken char_literal85 = null;

        object t1_tree=null;
        object t2_tree=null;
        object char_literal84_tree=null;
        object char_literal85_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:5: ( ( '<' '=' )=>t1= '<' t2= '=' {...}? | ( '>' '=' )=>t1= '>' t2= '=' {...}? | '<' | '>' )
            int alt24 = 4;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == 56) )
            {
                int LA24_1 = input.LA(2);

                if ( (LA24_1 == 28) && (synpred42_Psimulex()) )
                {
                    alt24 = 1;
                }
                else if ( ((LA24_1 >= StringLiteral && LA24_1 <= LP) || (LA24_1 >= IntegerLiteral && LA24_1 <= InfinityLiteral) || (LA24_1 >= 58 && LA24_1 <= 59) || (LA24_1 >= 63 && LA24_1 <= 65)) )
                {
                    alt24 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d24s1 =
                        new NoViableAltException("", 24, 1, input);

                    throw nvae_d24s1;
                }
            }
            else if ( (LA24_0 == 57) )
            {
                int LA24_2 = input.LA(2);

                if ( (LA24_2 == 28) && (synpred43_Psimulex()) )
                {
                    alt24 = 2;
                }
                else if ( ((LA24_2 >= StringLiteral && LA24_2 <= LP) || (LA24_2 >= IntegerLiteral && LA24_2 <= InfinityLiteral) || (LA24_2 >= 58 && LA24_2 <= 59) || (LA24_2 >= 63 && LA24_2 <= 65)) )
                {
                    alt24 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d24s2 =
                        new NoViableAltException("", 24, 2, input);

                    throw nvae_d24s2;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:9: ( '<' '=' )=>t1= '<' t2= '=' {...}?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	t1=(IToken)Match(input,56,FOLLOW_56_in_relationalOp1015); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{t1_tree = (object)adaptor.Create(t1);
                    		adaptor.AddChild(root_0, t1_tree);
                    	}
                    	t2=(IToken)Match(input,28,FOLLOW_28_in_relationalOp1019); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{t2_tree = (object)adaptor.Create(t2);
                    		adaptor.AddChild(root_0, t2_tree);
                    	}
                    	if ( !(( t1.Line == t2.Line && 
                    	          t1.CharPositionInLine + 1 == t2.CharPositionInLine )) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    throw new FailedPredicateException(input, "relationalOp", " $t1.Line == $t2.Line && \r\n          $t1.CharPositionInLine + 1 == $t2.CharPositionInLine ");
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:9: ( '>' '=' )=>t1= '>' t2= '=' {...}?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	t1=(IToken)Match(input,57,FOLLOW_57_in_relationalOp1049); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{t1_tree = (object)adaptor.Create(t1);
                    		adaptor.AddChild(root_0, t1_tree);
                    	}
                    	t2=(IToken)Match(input,28,FOLLOW_28_in_relationalOp1053); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{t2_tree = (object)adaptor.Create(t2);
                    		adaptor.AddChild(root_0, t2_tree);
                    	}
                    	if ( !(( t1.Line == t2.Line && 
                    	          t1.CharPositionInLine + 1 == t2.CharPositionInLine )) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    throw new FailedPredicateException(input, "relationalOp", " $t1.Line == $t2.Line && \r\n          $t1.CharPositionInLine + 1 == $t2.CharPositionInLine ");
                    	}

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:188:9: '<'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal84=(IToken)Match(input,56,FOLLOW_56_in_relationalOp1074); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal84_tree = (object)adaptor.Create(char_literal84);
                    		adaptor.AddChild(root_0, char_literal84_tree);
                    	}

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:189:9: '>'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal85=(IToken)Match(input,57,FOLLOW_57_in_relationalOp1085); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal85_tree = (object)adaptor.Create(char_literal85);
                    		adaptor.AddChild(root_0, char_literal85_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:192:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public PsimulexParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.additiveExpression_return retval = new PsimulexParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal87 = null;
        IToken char_literal88 = null;
        PsimulexParser.multiplicativeExpression_return multiplicativeExpression86 = default(PsimulexParser.multiplicativeExpression_return);

        PsimulexParser.multiplicativeExpression_return multiplicativeExpression89 = default(PsimulexParser.multiplicativeExpression_return);


        object char_literal87_tree=null;
        object char_literal88_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1106);
            	multiplicativeExpression86 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression86.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= 58 && LA26_0 <= 59)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:36: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:36: ( '+' | '-' )
            			    	int alt25 = 2;
            			    	int LA25_0 = input.LA(1);

            			    	if ( (LA25_0 == 58) )
            			    	{
            			    	    alt25 = 1;
            			    	}
            			    	else if ( (LA25_0 == 59) )
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
            			    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:37: '+'
            			    	        {
            			    	        	char_literal87=(IToken)Match(input,58,FOLLOW_58_in_additiveExpression1111); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal87_tree = (object)adaptor.Create(char_literal87);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal87_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:193:44: '-'
            			    	        {
            			    	        	char_literal88=(IToken)Match(input,59,FOLLOW_59_in_additiveExpression1116); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal88_tree = (object)adaptor.Create(char_literal88);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal88_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1120);
            			    	multiplicativeExpression89 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression89.Tree);

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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:196:1: multiplicativeExpression : unaryExpression ( ( '*' | '/' | '%' ) unaryExpression )* ;
    public PsimulexParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.multiplicativeExpression_return retval = new PsimulexParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken set91 = null;
        PsimulexParser.unaryExpression_return unaryExpression90 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.unaryExpression_return unaryExpression92 = default(PsimulexParser.unaryExpression_return);


        object set91_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:5: ( unaryExpression ( ( '*' | '/' | '%' ) unaryExpression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:9: unaryExpression ( ( '*' | '/' | '%' ) unaryExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1142);
            	unaryExpression90 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression90.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:25: ( ( '*' | '/' | '%' ) unaryExpression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= 60 && LA27_0 <= 62)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:197:27: ( '*' | '/' | '%' ) unaryExpression
            			    {
            			    	set91 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 60 && input.LA(1) <= 62) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set91));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression1160);
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

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

    public class unaryExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:200:1: unaryExpression : ( '+' unaryExpression | '-' unaryExpression | '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public PsimulexParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpression_return retval = new PsimulexParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal93 = null;
        IToken char_literal95 = null;
        IToken string_literal97 = null;
        IToken string_literal99 = null;
        PsimulexParser.unaryExpression_return unaryExpression94 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.unaryExpression_return unaryExpression96 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.unaryExpression_return unaryExpression98 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.unaryExpression_return unaryExpression100 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus101 = default(PsimulexParser.unaryExpressionNotPlusMinus_return);


        object char_literal93_tree=null;
        object char_literal95_tree=null;
        object string_literal97_tree=null;
        object string_literal99_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:5: ( '+' unaryExpression | '-' unaryExpression | '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt28 = 5;
            switch ( input.LA(1) ) 
            {
            case 58:
            	{
                alt28 = 1;
                }
                break;
            case 59:
            	{
                alt28 = 2;
                }
                break;
            case 63:
            	{
                alt28 = 3;
                }
                break;
            case 64:
            	{
                alt28 = 4;
                }
                break;
            case StringLiteral:
            case Identifier:
            case LP:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            case 65:
            	{
                alt28 = 5;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:201:9: '+' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal93=(IToken)Match(input,58,FOLLOW_58_in_unaryExpression1186); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal93_tree = (object)adaptor.Create(char_literal93);
                    		adaptor.AddChild(root_0, char_literal93_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1188);
                    	unaryExpression94 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression94.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:202:9: '-' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal95=(IToken)Match(input,59,FOLLOW_59_in_unaryExpression1198); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal95_tree = (object)adaptor.Create(char_literal95);
                    		adaptor.AddChild(root_0, char_literal95_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1200);
                    	unaryExpression96 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression96.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:203:9: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal97=(IToken)Match(input,63,FOLLOW_63_in_unaryExpression1210); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal97_tree = (object)adaptor.Create(string_literal97);
                    		adaptor.AddChild(root_0, string_literal97_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1212);
                    	unaryExpression98 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression98.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:204:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal99=(IToken)Match(input,64,FOLLOW_64_in_unaryExpression1222); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal99_tree = (object)adaptor.Create(string_literal99);
                    		adaptor.AddChild(root_0, string_literal99_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1224);
                    	unaryExpression100 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression100.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:205:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1234);
                    	unaryExpressionNotPlusMinus101 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpressionNotPlusMinus101.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 33, unaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class unaryExpressionNotPlusMinus_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:208:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | primaryExpression ( '++' | '--' )? );
    public PsimulexParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        PsimulexParser.unaryExpressionNotPlusMinus_return retval = new PsimulexParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);
        int unaryExpressionNotPlusMinus_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal102 = null;
        IToken set105 = null;
        PsimulexParser.unaryExpression_return unaryExpression103 = default(PsimulexParser.unaryExpression_return);

        PsimulexParser.primaryExpression_return primaryExpression104 = default(PsimulexParser.primaryExpression_return);


        object char_literal102_tree=null;
        object set105_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:5: ( '!' unaryExpression | primaryExpression ( '++' | '--' )? )
            int alt30 = 2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0 == 65) )
            {
                alt30 = 1;
            }
            else if ( ((LA30_0 >= StringLiteral && LA30_0 <= LP) || (LA30_0 >= IntegerLiteral && LA30_0 <= InfinityLiteral)) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:209:9: '!' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal102=(IToken)Match(input,65,FOLLOW_65_in_unaryExpressionNotPlusMinus1253); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal102_tree = (object)adaptor.Create(char_literal102);
                    		adaptor.AddChild(root_0, char_literal102_tree);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1255);
                    	unaryExpression103 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression103.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:9: primaryExpression ( '++' | '--' )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_unaryExpressionNotPlusMinus1265);
                    	primaryExpression104 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression104.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:210:27: ( '++' | '--' )?
                    	int alt29 = 2;
                    	int LA29_0 = input.LA(1);

                    	if ( ((LA29_0 >= 63 && LA29_0 <= 64)) )
                    	{
                    	    alt29 = 1;
                    	}
                    	switch (alt29) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
                    	        {
                    	        	set105 = (IToken)input.LT(1);
                    	        	if ( (input.LA(1) >= 63 && input.LA(1) <= 64) ) 
                    	        	{
                    	        	    input.Consume();
                    	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set105));
                    	        	    state.errorRecovery = false;state.failed = false;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    throw mse;
                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 34, unaryExpressionNotPlusMinus_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:213:1: primaryExpression : ( leftValue | literal );
    public PsimulexParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        PsimulexParser.primaryExpression_return retval = new PsimulexParser.primaryExpression_return();
        retval.Start = input.LT(1);
        int primaryExpression_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.leftValue_return leftValue106 = default(PsimulexParser.leftValue_return);

        PsimulexParser.literal_return literal107 = default(PsimulexParser.literal_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:5: ( leftValue | literal )
            int alt31 = 2;
            int LA31_0 = input.LA(1);

            if ( ((LA31_0 >= Identifier && LA31_0 <= LP)) )
            {
                alt31 = 1;
            }
            else if ( (LA31_0 == StringLiteral || (LA31_0 >= IntegerLiteral && LA31_0 <= InfinityLiteral)) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:214:9: leftValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftValue_in_primaryExpression1291);
                    	leftValue106 = leftValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue106.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:215:9: literal
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression1305);
                    	literal107 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal107.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 35, primaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class leftValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "leftValue"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:218:1: leftValue : ( variable | selecting );
    public PsimulexParser.leftValue_return leftValue() // throws RecognitionException [1]
    {   
        PsimulexParser.leftValue_return retval = new PsimulexParser.leftValue_return();
        retval.Start = input.LT(1);
        int leftValue_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.variable_return variable108 = default(PsimulexParser.variable_return);

        PsimulexParser.selecting_return selecting109 = default(PsimulexParser.selecting_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:219:2: ( variable | selecting )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == Identifier) )
            {
                int LA32_1 = input.LA(2);

                if ( (synpred58_Psimulex()) )
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
            else if ( (LA32_0 == LP) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:219:4: variable
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_leftValue1319);
                    	variable108 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable108.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:220:4: selecting
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selecting_in_leftValue1324);
                    	selecting109 = selecting();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selecting109.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 36, leftValue_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "leftValue"

    public class variable_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:223:1: variable : Identifier ;
    public PsimulexParser.variable_return variable() // throws RecognitionException [1]
    {   
        PsimulexParser.variable_return retval = new PsimulexParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier110 = null;

        object Identifier110_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:224:2: ( Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:224:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier110=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable1335); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier110_tree = (object)adaptor.Create(Identifier110);
            		adaptor.AddChild(root_0, Identifier110_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 37, variable_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class selecting_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "selecting"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:227:1: selecting : ( Identifier | parExpression ) ( selector )* ;
    public PsimulexParser.selecting_return selecting() // throws RecognitionException [1]
    {   
        PsimulexParser.selecting_return retval = new PsimulexParser.selecting_return();
        retval.Start = input.LT(1);
        int selecting_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier111 = null;
        PsimulexParser.parExpression_return parExpression112 = default(PsimulexParser.parExpression_return);

        PsimulexParser.selector_return selector113 = default(PsimulexParser.selector_return);


        object Identifier111_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:2: ( ( Identifier | parExpression ) ( selector )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:4: ( Identifier | parExpression ) ( selector )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:4: ( Identifier | parExpression )
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == Identifier) )
            	{
            	    alt33 = 1;
            	}
            	else if ( (LA33_0 == LP) )
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
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:5: Identifier
            	        {
            	        	Identifier111=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_selecting1347); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier111_tree = (object)adaptor.Create(Identifier111);
            	        		adaptor.AddChild(root_0, Identifier111_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:16: parExpression
            	        {
            	        	PushFollow(FOLLOW_parExpression_in_selecting1349);
            	        	parExpression112 = parExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression112.Tree);

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:228:31: ( selector )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == 29 || LA34_0 == 66) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: selector
            			    {
            			    	PushFollow(FOLLOW_selector_in_selecting1352);
            			    	selector113 = selector();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selector113.Tree);

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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 38, selecting_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "selecting"

    public class selector_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "selector"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:231:1: selector : ( memberSelect | memberFunctionCall | indexing );
    public PsimulexParser.selector_return selector() // throws RecognitionException [1]
    {   
        PsimulexParser.selector_return retval = new PsimulexParser.selector_return();
        retval.Start = input.LT(1);
        int selector_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.memberSelect_return memberSelect114 = default(PsimulexParser.memberSelect_return);

        PsimulexParser.memberFunctionCall_return memberFunctionCall115 = default(PsimulexParser.memberFunctionCall_return);

        PsimulexParser.indexing_return indexing116 = default(PsimulexParser.indexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:232:5: ( memberSelect | memberFunctionCall | indexing )
            int alt35 = 3;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == 66) )
            {
                int LA35_1 = input.LA(2);

                if ( (LA35_1 == Identifier) )
                {
                    int LA35_3 = input.LA(3);

                    if ( (LA35_3 == LP) )
                    {
                        alt35 = 2;
                    }
                    else if ( (LA35_3 == EOF || LA35_3 == RP || LA35_3 == 24 || (LA35_3 >= 28 && LA35_3 <= 31) || (LA35_3 >= 45 && LA35_3 <= 64) || LA35_3 == 66) )
                    {
                        alt35 = 1;
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
            else if ( (LA35_0 == 29) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:232:9: memberSelect
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberSelect_in_selector1369);
                    	memberSelect114 = memberSelect();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberSelect114.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:233:9: memberFunctionCall
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_memberFunctionCall_in_selector1379);
                    	memberFunctionCall115 = memberFunctionCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberFunctionCall115.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:234:9: indexing
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_indexing_in_selector1389);
                    	indexing116 = indexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, indexing116.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 39, selector_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "selector"

    public class memberSelect_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "memberSelect"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:237:1: memberSelect : '.' Identifier ;
    public PsimulexParser.memberSelect_return memberSelect() // throws RecognitionException [1]
    {   
        PsimulexParser.memberSelect_return retval = new PsimulexParser.memberSelect_return();
        retval.Start = input.LT(1);
        int memberSelect_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal117 = null;
        IToken Identifier118 = null;

        object char_literal117_tree=null;
        object Identifier118_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:238:2: ( '.' Identifier )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:238:4: '.' Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal117=(IToken)Match(input,66,FOLLOW_66_in_memberSelect1403); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal117_tree = (object)adaptor.Create(char_literal117);
            		adaptor.AddChild(root_0, char_literal117_tree);
            	}
            	Identifier118=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberSelect1405); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier118_tree = (object)adaptor.Create(Identifier118);
            		adaptor.AddChild(root_0, Identifier118_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 40, memberSelect_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberSelect"

    public class memberFunctionCall_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "memberFunctionCall"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:241:1: memberFunctionCall : '.' Identifier arguments ;
    public PsimulexParser.memberFunctionCall_return memberFunctionCall() // throws RecognitionException [1]
    {   
        PsimulexParser.memberFunctionCall_return retval = new PsimulexParser.memberFunctionCall_return();
        retval.Start = input.LT(1);
        int memberFunctionCall_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal119 = null;
        IToken Identifier120 = null;
        PsimulexParser.arguments_return arguments121 = default(PsimulexParser.arguments_return);


        object char_literal119_tree=null;
        object Identifier120_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:242:2: ( '.' Identifier arguments )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:242:4: '.' Identifier arguments
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal119=(IToken)Match(input,66,FOLLOW_66_in_memberFunctionCall1416); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal119_tree = (object)adaptor.Create(char_literal119);
            		adaptor.AddChild(root_0, char_literal119_tree);
            	}
            	Identifier120=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_memberFunctionCall1418); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier120_tree = (object)adaptor.Create(Identifier120);
            		adaptor.AddChild(root_0, Identifier120_tree);
            	}
            	PushFollow(FOLLOW_arguments_in_memberFunctionCall1420);
            	arguments121 = arguments();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arguments121.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 41, memberFunctionCall_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "memberFunctionCall"

    public class indexing_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "indexing"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:269:1: indexing : ( arrayIndexing | matrixIndexing );
    public PsimulexParser.indexing_return indexing() // throws RecognitionException [1]
    {   
        PsimulexParser.indexing_return retval = new PsimulexParser.indexing_return();
        retval.Start = input.LT(1);
        int indexing_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.arrayIndexing_return arrayIndexing122 = default(PsimulexParser.arrayIndexing_return);

        PsimulexParser.matrixIndexing_return matrixIndexing123 = default(PsimulexParser.matrixIndexing_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:2: ( arrayIndexing | matrixIndexing )
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0 == 29) )
            {
                int LA36_1 = input.LA(2);

                if ( (synpred63_Psimulex()) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:4: arrayIndexing
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayIndexing_in_indexing1438);
                    	arrayIndexing122 = arrayIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayIndexing122.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:271:4: matrixIndexing
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixIndexing_in_indexing1443);
                    	matrixIndexing123 = matrixIndexing();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, matrixIndexing123.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 42, indexing_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "indexing"

    public class arrayIndexing_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arrayIndexing"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:274:1: arrayIndexing : '[' expression ']' ;
    public PsimulexParser.arrayIndexing_return arrayIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.arrayIndexing_return retval = new PsimulexParser.arrayIndexing_return();
        retval.Start = input.LT(1);
        int arrayIndexing_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal124 = null;
        IToken char_literal126 = null;
        PsimulexParser.expression_return expression125 = default(PsimulexParser.expression_return);


        object char_literal124_tree=null;
        object char_literal126_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:2: ( '[' expression ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:275:4: '[' expression ']'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal124=(IToken)Match(input,29,FOLLOW_29_in_arrayIndexing1455); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal124_tree = (object)adaptor.Create(char_literal124);
            		adaptor.AddChild(root_0, char_literal124_tree);
            	}
            	PushFollow(FOLLOW_expression_in_arrayIndexing1457);
            	expression125 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression125.Tree);
            	char_literal126=(IToken)Match(input,30,FOLLOW_30_in_arrayIndexing1459); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal126_tree = (object)adaptor.Create(char_literal126);
            		adaptor.AddChild(root_0, char_literal126_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 43, arrayIndexing_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arrayIndexing"

    public class matrixIndexing_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixIndexing"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:278:1: matrixIndexing : '[' expression ',' expression ']' ;
    public PsimulexParser.matrixIndexing_return matrixIndexing() // throws RecognitionException [1]
    {   
        PsimulexParser.matrixIndexing_return retval = new PsimulexParser.matrixIndexing_return();
        retval.Start = input.LT(1);
        int matrixIndexing_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal127 = null;
        IToken char_literal129 = null;
        IToken char_literal131 = null;
        PsimulexParser.expression_return expression128 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression130 = default(PsimulexParser.expression_return);


        object char_literal127_tree=null;
        object char_literal129_tree=null;
        object char_literal131_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:279:2: ( '[' expression ',' expression ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:279:4: '[' expression ',' expression ']'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal127=(IToken)Match(input,29,FOLLOW_29_in_matrixIndexing1470); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal127_tree = (object)adaptor.Create(char_literal127);
            		adaptor.AddChild(root_0, char_literal127_tree);
            	}
            	PushFollow(FOLLOW_expression_in_matrixIndexing1472);
            	expression128 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression128.Tree);
            	char_literal129=(IToken)Match(input,31,FOLLOW_31_in_matrixIndexing1474); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal129_tree = (object)adaptor.Create(char_literal129);
            		adaptor.AddChild(root_0, char_literal129_tree);
            	}
            	PushFollow(FOLLOW_expression_in_matrixIndexing1476);
            	expression130 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression130.Tree);
            	char_literal131=(IToken)Match(input,30,FOLLOW_30_in_matrixIndexing1478); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal131_tree = (object)adaptor.Create(char_literal131);
            		adaptor.AddChild(root_0, char_literal131_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 44, matrixIndexing_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "matrixIndexing"

    public class arguments_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arguments"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:282:1: arguments : '(' ( expressionList )? ')' ;
    public PsimulexParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        PsimulexParser.arguments_return retval = new PsimulexParser.arguments_return();
        retval.Start = input.LT(1);
        int arguments_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal132 = null;
        IToken char_literal134 = null;
        PsimulexParser.expressionList_return expressionList133 = default(PsimulexParser.expressionList_return);


        object char_literal132_tree=null;
        object char_literal134_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:283:5: ( '(' ( expressionList )? ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:283:9: '(' ( expressionList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal132=(IToken)Match(input,LP,FOLLOW_LP_in_arguments1495); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal132_tree = (object)adaptor.Create(char_literal132);
            		adaptor.AddChild(root_0, char_literal132_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:283:13: ( expressionList )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( ((LA37_0 >= StringLiteral && LA37_0 <= LP) || (LA37_0 >= IntegerLiteral && LA37_0 <= InfinityLiteral) || (LA37_0 >= 58 && LA37_0 <= 59) || (LA37_0 >= 63 && LA37_0 <= 65)) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1497);
            	        	expressionList133 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionList133.Tree);

            	        }
            	        break;

            	}

            	char_literal134=(IToken)Match(input,RP,FOLLOW_RP_in_arguments1500); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal134_tree = (object)adaptor.Create(char_literal134);
            		adaptor.AddChild(root_0, char_literal134_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 45, arguments_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class expressionList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expressionList"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:286:1: expressionList : expression ( ',' expression )* ;
    public PsimulexParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        PsimulexParser.expressionList_return retval = new PsimulexParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal136 = null;
        PsimulexParser.expression_return expression135 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression137 = default(PsimulexParser.expression_return);


        object char_literal136_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:5: ( expression ( ',' expression )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:7: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1517);
            	expression135 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression135.Tree);
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:18: ( ',' expression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 31) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:287:19: ',' expression
            			    {
            			    	char_literal136=(IToken)Match(input,31,FOLLOW_31_in_expressionList1520); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal136_tree = (object)adaptor.Create(char_literal136);
            			    		adaptor.AddChild(root_0, char_literal136_tree);
            			    	}
            			    	PushFollow(FOLLOW_expression_in_expressionList1522);
            			    	expression137 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression137.Tree);

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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 46, expressionList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expressionList"

    public class literal_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "literal"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:290:1: literal : ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral );
    public PsimulexParser.literal_return literal() // throws RecognitionException [1]
    {   
        PsimulexParser.literal_return retval = new PsimulexParser.literal_return();
        retval.Start = input.LT(1);
        int literal_StartIndex = input.Index();
        object root_0 = null;

        IToken set138 = null;

        object set138_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:291:5: ( IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set138 = (IToken)input.LT(1);
            	if ( input.LA(1) == StringLiteral || (input.LA(1) >= IntegerLiteral && input.LA(1) <= InfinityLiteral) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set138));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 47, literal_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "literal"

    public class block_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:309:1: block : '{' ( blockStatement )* '}' ;
    public PsimulexParser.block_return block() // throws RecognitionException [1]
    {   
        PsimulexParser.block_return retval = new PsimulexParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal139 = null;
        IToken char_literal141 = null;
        PsimulexParser.blockStatement_return blockStatement140 = default(PsimulexParser.blockStatement_return);


        object char_literal139_tree=null;
        object char_literal141_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:5: ( '{' ( blockStatement )* '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:9: '{' ( blockStatement )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal139=(IToken)Match(input,26,FOLLOW_26_in_block1648); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal139_tree = (object)adaptor.Create(char_literal139);
            		adaptor.AddChild(root_0, char_literal139_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:310:13: ( blockStatement )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( ((LA39_0 >= StringLiteral && LA39_0 <= LP) || (LA39_0 >= IntegerLiteral && LA39_0 <= InfinityLiteral) || LA39_0 == 24 || (LA39_0 >= 32 && LA39_0 <= 36) || (LA39_0 >= 58 && LA39_0 <= 59) || (LA39_0 >= 63 && LA39_0 <= 65) || LA39_0 == 67 || (LA39_0 >= 69 && LA39_0 <= 78)) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: blockStatement
            			    {
            			    	PushFollow(FOLLOW_blockStatement_in_block1650);
            			    	blockStatement140 = blockStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement140.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	char_literal141=(IToken)Match(input,27,FOLLOW_27_in_block1653); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal141_tree = (object)adaptor.Create(char_literal141);
            		adaptor.AddChild(root_0, char_literal141_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 48, block_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "block"

    public class blockStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "blockStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:313:1: blockStatement : ( localVariableDeclarationStatement | statement );
    public PsimulexParser.blockStatement_return blockStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.blockStatement_return retval = new PsimulexParser.blockStatement_return();
        retval.Start = input.LT(1);
        int blockStatement_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.localVariableDeclarationStatement_return localVariableDeclarationStatement142 = default(PsimulexParser.localVariableDeclarationStatement_return);

        PsimulexParser.statement_return statement143 = default(PsimulexParser.statement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:5: ( localVariableDeclarationStatement | statement )
            int alt40 = 2;
            int LA40_0 = input.LA(1);

            if ( ((LA40_0 >= 32 && LA40_0 <= 36)) )
            {
                alt40 = 1;
            }
            else if ( ((LA40_0 >= StringLiteral && LA40_0 <= LP) || (LA40_0 >= IntegerLiteral && LA40_0 <= InfinityLiteral) || LA40_0 == 24 || (LA40_0 >= 58 && LA40_0 <= 59) || (LA40_0 >= 63 && LA40_0 <= 65) || LA40_0 == 67 || (LA40_0 >= 69 && LA40_0 <= 78)) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:314:9: localVariableDeclarationStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_localVariableDeclarationStatement_in_blockStatement1676);
                    	localVariableDeclarationStatement142 = localVariableDeclarationStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclarationStatement142.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:315:9: statement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_blockStatement1686);
                    	statement143 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement143.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 49, blockStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "blockStatement"

    public class localVariableDeclarationStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "localVariableDeclarationStatement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:318:1: localVariableDeclarationStatement : localVariableDeclaration ';' ;
    public PsimulexParser.localVariableDeclarationStatement_return localVariableDeclarationStatement() // throws RecognitionException [1]
    {   
        PsimulexParser.localVariableDeclarationStatement_return retval = new PsimulexParser.localVariableDeclarationStatement_return();
        retval.Start = input.LT(1);
        int localVariableDeclarationStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal145 = null;
        PsimulexParser.localVariableDeclaration_return localVariableDeclaration144 = default(PsimulexParser.localVariableDeclaration_return);


        object char_literal145_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:319:5: ( localVariableDeclaration ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:319:10: localVariableDeclaration ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_localVariableDeclarationStatement1710);
            	localVariableDeclaration144 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration144.Tree);
            	char_literal145=(IToken)Match(input,24,FOLLOW_24_in_localVariableDeclarationStatement1712); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal145_tree = (object)adaptor.Create(char_literal145);
            		adaptor.AddChild(root_0, char_literal145_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 50, localVariableDeclarationStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "localVariableDeclarationStatement"

    public class localVariableDeclaration_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "localVariableDeclaration"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:322:1: localVariableDeclaration : type variableDeclarator ;
    public PsimulexParser.localVariableDeclaration_return localVariableDeclaration() // throws RecognitionException [1]
    {   
        PsimulexParser.localVariableDeclaration_return retval = new PsimulexParser.localVariableDeclaration_return();
        retval.Start = input.LT(1);
        int localVariableDeclaration_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.type_return type146 = default(PsimulexParser.type_return);

        PsimulexParser.variableDeclarator_return variableDeclarator147 = default(PsimulexParser.variableDeclarator_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:5: ( type variableDeclarator )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:323:9: type variableDeclarator
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_localVariableDeclaration1731);
            	type146 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type146.Tree);
            	PushFollow(FOLLOW_variableDeclarator_in_localVariableDeclaration1733);
            	variableDeclarator147 = variableDeclarator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarator147.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 51, localVariableDeclaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "localVariableDeclaration"

    public class branch_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "branch"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:326:1: branch : ( block | blockStatement );
    public PsimulexParser.branch_return branch() // throws RecognitionException [1]
    {   
        PsimulexParser.branch_return retval = new PsimulexParser.branch_return();
        retval.Start = input.LT(1);
        int branch_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.block_return block148 = default(PsimulexParser.block_return);

        PsimulexParser.blockStatement_return blockStatement149 = default(PsimulexParser.blockStatement_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:5: ( block | blockStatement )
            int alt41 = 2;
            int LA41_0 = input.LA(1);

            if ( (LA41_0 == 26) )
            {
                alt41 = 1;
            }
            else if ( ((LA41_0 >= StringLiteral && LA41_0 <= LP) || (LA41_0 >= IntegerLiteral && LA41_0 <= InfinityLiteral) || LA41_0 == 24 || (LA41_0 >= 32 && LA41_0 <= 36) || (LA41_0 >= 58 && LA41_0 <= 59) || (LA41_0 >= 63 && LA41_0 <= 65) || LA41_0 == 67 || (LA41_0 >= 69 && LA41_0 <= 78)) )
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:7: block
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_block_in_branch1754);
                    	block148 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block148.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:327:13: blockStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_blockStatement_in_branch1756);
                    	blockStatement149 = blockStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, blockStatement149.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 52, branch_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "branch"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:330:1: statement : ( 'if' parExpression branch ( options {k=1; } : 'else' branch )? | ( 'for' | 'pfor' ) '(' forControl ')' branch | 'foreach' '(' foreachControl ')' branch | 'loop' '(' loopControl ')' branch | 'while' parExpression branch | 'do' branch 'while' parExpression ';' | 'pdo' block | 'return' ( expression )? ';' | 'break' ';' | 'continue' ';' | ';' | expression ';' );
    public PsimulexParser.statement_return statement() // throws RecognitionException [1]
    {   
        PsimulexParser.statement_return retval = new PsimulexParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal150 = null;
        IToken string_literal153 = null;
        IToken set155 = null;
        IToken char_literal156 = null;
        IToken char_literal158 = null;
        IToken string_literal160 = null;
        IToken char_literal161 = null;
        IToken char_literal163 = null;
        IToken string_literal165 = null;
        IToken char_literal166 = null;
        IToken char_literal168 = null;
        IToken string_literal170 = null;
        IToken string_literal173 = null;
        IToken string_literal175 = null;
        IToken char_literal177 = null;
        IToken string_literal178 = null;
        IToken string_literal180 = null;
        IToken char_literal182 = null;
        IToken string_literal183 = null;
        IToken char_literal184 = null;
        IToken string_literal185 = null;
        IToken char_literal186 = null;
        IToken char_literal187 = null;
        IToken char_literal189 = null;
        PsimulexParser.parExpression_return parExpression151 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch152 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch154 = default(PsimulexParser.branch_return);

        PsimulexParser.forControl_return forControl157 = default(PsimulexParser.forControl_return);

        PsimulexParser.branch_return branch159 = default(PsimulexParser.branch_return);

        PsimulexParser.foreachControl_return foreachControl162 = default(PsimulexParser.foreachControl_return);

        PsimulexParser.branch_return branch164 = default(PsimulexParser.branch_return);

        PsimulexParser.loopControl_return loopControl167 = default(PsimulexParser.loopControl_return);

        PsimulexParser.branch_return branch169 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression171 = default(PsimulexParser.parExpression_return);

        PsimulexParser.branch_return branch172 = default(PsimulexParser.branch_return);

        PsimulexParser.branch_return branch174 = default(PsimulexParser.branch_return);

        PsimulexParser.parExpression_return parExpression176 = default(PsimulexParser.parExpression_return);

        PsimulexParser.block_return block179 = default(PsimulexParser.block_return);

        PsimulexParser.expression_return expression181 = default(PsimulexParser.expression_return);

        PsimulexParser.expression_return expression188 = default(PsimulexParser.expression_return);


        object string_literal150_tree=null;
        object string_literal153_tree=null;
        object set155_tree=null;
        object char_literal156_tree=null;
        object char_literal158_tree=null;
        object string_literal160_tree=null;
        object char_literal161_tree=null;
        object char_literal163_tree=null;
        object string_literal165_tree=null;
        object char_literal166_tree=null;
        object char_literal168_tree=null;
        object string_literal170_tree=null;
        object string_literal173_tree=null;
        object string_literal175_tree=null;
        object char_literal177_tree=null;
        object string_literal178_tree=null;
        object string_literal180_tree=null;
        object char_literal182_tree=null;
        object string_literal183_tree=null;
        object char_literal184_tree=null;
        object string_literal185_tree=null;
        object char_literal186_tree=null;
        object char_literal187_tree=null;
        object char_literal189_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:5: ( 'if' parExpression branch ( options {k=1; } : 'else' branch )? | ( 'for' | 'pfor' ) '(' forControl ')' branch | 'foreach' '(' foreachControl ')' branch | 'loop' '(' loopControl ')' branch | 'while' parExpression branch | 'do' branch 'while' parExpression ';' | 'pdo' block | 'return' ( expression )? ';' | 'break' ';' | 'continue' ';' | ';' | expression ';' )
            int alt44 = 12;
            switch ( input.LA(1) ) 
            {
            case 67:
            	{
                alt44 = 1;
                }
                break;
            case 69:
            case 70:
            	{
                alt44 = 2;
                }
                break;
            case 71:
            	{
                alt44 = 3;
                }
                break;
            case 72:
            	{
                alt44 = 4;
                }
                break;
            case 73:
            	{
                alt44 = 5;
                }
                break;
            case 74:
            	{
                alt44 = 6;
                }
                break;
            case 75:
            	{
                alt44 = 7;
                }
                break;
            case 76:
            	{
                alt44 = 8;
                }
                break;
            case 77:
            	{
                alt44 = 9;
                }
                break;
            case 78:
            	{
                alt44 = 10;
                }
                break;
            case 24:
            	{
                alt44 = 11;
                }
                break;
            case StringLiteral:
            case Identifier:
            case LP:
            case IntegerLiteral:
            case DecimalLiteral:
            case CharacterLiteral:
            case BooleanLiteral:
            case NullLiteral:
            case InfinityLiteral:
            case 58:
            case 59:
            case 63:
            case 64:
            case 65:
            	{
                alt44 = 12;
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
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:7: 'if' parExpression branch ( options {k=1; } : 'else' branch )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal150=(IToken)Match(input,67,FOLLOW_67_in_statement1773); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal150_tree = (object)adaptor.Create(string_literal150);
                    		adaptor.AddChild(root_0, string_literal150_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1775);
                    	parExpression151 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression151.Tree);
                    	PushFollow(FOLLOW_branch_in_statement1777);
                    	branch152 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch152.Tree);
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:33: ( options {k=1; } : 'else' branch )?
                    	int alt42 = 2;
                    	int LA42_0 = input.LA(1);

                    	if ( (LA42_0 == 68) )
                    	{
                    	    int LA42_1 = input.LA(2);

                    	    if ( (synpred75_Psimulex()) )
                    	    {
                    	        alt42 = 1;
                    	    }
                    	}
                    	switch (alt42) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:49: 'else' branch
                    	        {
                    	        	string_literal153=(IToken)Match(input,68,FOLLOW_68_in_statement1787); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal153_tree = (object)adaptor.Create(string_literal153);
                    	        		adaptor.AddChild(root_0, string_literal153_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_branch_in_statement1789);
                    	        	branch154 = branch();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch154.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:332:9: ( 'for' | 'pfor' ) '(' forControl ')' branch
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	set155 = (IToken)input.LT(1);
                    	if ( (input.LA(1) >= 69 && input.LA(1) <= 70) ) 
                    	{
                    	    input.Consume();
                    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set155));
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	char_literal156=(IToken)Match(input,LP,FOLLOW_LP_in_statement1807); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal156_tree = (object)adaptor.Create(char_literal156);
                    		adaptor.AddChild(root_0, char_literal156_tree);
                    	}
                    	PushFollow(FOLLOW_forControl_in_statement1809);
                    	forControl157 = forControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forControl157.Tree);
                    	char_literal158=(IToken)Match(input,RP,FOLLOW_RP_in_statement1811); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal158_tree = (object)adaptor.Create(char_literal158);
                    		adaptor.AddChild(root_0, char_literal158_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement1813);
                    	branch159 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch159.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:333:9: 'foreach' '(' foreachControl ')' branch
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal160=(IToken)Match(input,71,FOLLOW_71_in_statement1823); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal160_tree = (object)adaptor.Create(string_literal160);
                    		adaptor.AddChild(root_0, string_literal160_tree);
                    	}
                    	char_literal161=(IToken)Match(input,LP,FOLLOW_LP_in_statement1825); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal161_tree = (object)adaptor.Create(char_literal161);
                    		adaptor.AddChild(root_0, char_literal161_tree);
                    	}
                    	PushFollow(FOLLOW_foreachControl_in_statement1827);
                    	foreachControl162 = foreachControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, foreachControl162.Tree);
                    	char_literal163=(IToken)Match(input,RP,FOLLOW_RP_in_statement1829); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal163_tree = (object)adaptor.Create(char_literal163);
                    		adaptor.AddChild(root_0, char_literal163_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement1831);
                    	branch164 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch164.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:334:9: 'loop' '(' loopControl ')' branch
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal165=(IToken)Match(input,72,FOLLOW_72_in_statement1841); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal165_tree = (object)adaptor.Create(string_literal165);
                    		adaptor.AddChild(root_0, string_literal165_tree);
                    	}
                    	char_literal166=(IToken)Match(input,LP,FOLLOW_LP_in_statement1843); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal166_tree = (object)adaptor.Create(char_literal166);
                    		adaptor.AddChild(root_0, char_literal166_tree);
                    	}
                    	PushFollow(FOLLOW_loopControl_in_statement1845);
                    	loopControl167 = loopControl();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, loopControl167.Tree);
                    	char_literal168=(IToken)Match(input,RP,FOLLOW_RP_in_statement1847); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal168_tree = (object)adaptor.Create(char_literal168);
                    		adaptor.AddChild(root_0, char_literal168_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement1849);
                    	branch169 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch169.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:335:9: 'while' parExpression branch
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal170=(IToken)Match(input,73,FOLLOW_73_in_statement1859); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal170_tree = (object)adaptor.Create(string_literal170);
                    		adaptor.AddChild(root_0, string_literal170_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1861);
                    	parExpression171 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression171.Tree);
                    	PushFollow(FOLLOW_branch_in_statement1863);
                    	branch172 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch172.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:336:9: 'do' branch 'while' parExpression ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal173=(IToken)Match(input,74,FOLLOW_74_in_statement1873); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal173_tree = (object)adaptor.Create(string_literal173);
                    		adaptor.AddChild(root_0, string_literal173_tree);
                    	}
                    	PushFollow(FOLLOW_branch_in_statement1875);
                    	branch174 = branch();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, branch174.Tree);
                    	string_literal175=(IToken)Match(input,73,FOLLOW_73_in_statement1877); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal175_tree = (object)adaptor.Create(string_literal175);
                    		adaptor.AddChild(root_0, string_literal175_tree);
                    	}
                    	PushFollow(FOLLOW_parExpression_in_statement1879);
                    	parExpression176 = parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, parExpression176.Tree);
                    	char_literal177=(IToken)Match(input,24,FOLLOW_24_in_statement1881); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal177_tree = (object)adaptor.Create(char_literal177);
                    		adaptor.AddChild(root_0, char_literal177_tree);
                    	}

                    }
                    break;
                case 7 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:337:9: 'pdo' block
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal178=(IToken)Match(input,75,FOLLOW_75_in_statement1891); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal178_tree = (object)adaptor.Create(string_literal178);
                    		adaptor.AddChild(root_0, string_literal178_tree);
                    	}
                    	PushFollow(FOLLOW_block_in_statement1893);
                    	block179 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block179.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:338:9: 'return' ( expression )? ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal180=(IToken)Match(input,76,FOLLOW_76_in_statement1903); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal180_tree = (object)adaptor.Create(string_literal180);
                    		adaptor.AddChild(root_0, string_literal180_tree);
                    	}
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:338:18: ( expression )?
                    	int alt43 = 2;
                    	int LA43_0 = input.LA(1);

                    	if ( ((LA43_0 >= StringLiteral && LA43_0 <= LP) || (LA43_0 >= IntegerLiteral && LA43_0 <= InfinityLiteral) || (LA43_0 >= 58 && LA43_0 <= 59) || (LA43_0 >= 63 && LA43_0 <= 65)) )
                    	{
                    	    alt43 = 1;
                    	}
                    	switch (alt43) 
                    	{
                    	    case 1 :
                    	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_statement1905);
                    	        	expression181 = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression181.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal182=(IToken)Match(input,24,FOLLOW_24_in_statement1908); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal182_tree = (object)adaptor.Create(char_literal182);
                    		adaptor.AddChild(root_0, char_literal182_tree);
                    	}

                    }
                    break;
                case 9 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:339:9: 'break' ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal183=(IToken)Match(input,77,FOLLOW_77_in_statement1918); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal183_tree = (object)adaptor.Create(string_literal183);
                    		adaptor.AddChild(root_0, string_literal183_tree);
                    	}
                    	char_literal184=(IToken)Match(input,24,FOLLOW_24_in_statement1920); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal184_tree = (object)adaptor.Create(char_literal184);
                    		adaptor.AddChild(root_0, char_literal184_tree);
                    	}

                    }
                    break;
                case 10 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:340:9: 'continue' ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal185=(IToken)Match(input,78,FOLLOW_78_in_statement1930); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal185_tree = (object)adaptor.Create(string_literal185);
                    		adaptor.AddChild(root_0, string_literal185_tree);
                    	}
                    	char_literal186=(IToken)Match(input,24,FOLLOW_24_in_statement1932); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal186_tree = (object)adaptor.Create(char_literal186);
                    		adaptor.AddChild(root_0, char_literal186_tree);
                    	}

                    }
                    break;
                case 11 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:341:9: ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal187=(IToken)Match(input,24,FOLLOW_24_in_statement1942); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal187_tree = (object)adaptor.Create(char_literal187);
                    		adaptor.AddChild(root_0, char_literal187_tree);
                    	}

                    }
                    break;
                case 12 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:342:9: expression ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expression_in_statement1952);
                    	expression188 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression188.Tree);
                    	char_literal189=(IToken)Match(input,24,FOLLOW_24_in_statement1954); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal189_tree = (object)adaptor.Create(char_literal189);
                    		adaptor.AddChild(root_0, char_literal189_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 53, statement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class forControl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forControl"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:345:1: forControl : ( forInit )? ';' ( expression )? ';' ( forUpdate )? ;
    public PsimulexParser.forControl_return forControl() // throws RecognitionException [1]
    {   
        PsimulexParser.forControl_return retval = new PsimulexParser.forControl_return();
        retval.Start = input.LT(1);
        int forControl_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal191 = null;
        IToken char_literal193 = null;
        PsimulexParser.forInit_return forInit190 = default(PsimulexParser.forInit_return);

        PsimulexParser.expression_return expression192 = default(PsimulexParser.expression_return);

        PsimulexParser.forUpdate_return forUpdate194 = default(PsimulexParser.forUpdate_return);


        object char_literal191_tree=null;
        object char_literal193_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:5: ( ( forInit )? ';' ( expression )? ';' ( forUpdate )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:10: ( forInit )? ';' ( expression )? ';' ( forUpdate )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:10: ( forInit )?
            	int alt45 = 2;
            	int LA45_0 = input.LA(1);

            	if ( ((LA45_0 >= 32 && LA45_0 <= 36)) )
            	{
            	    alt45 = 1;
            	}
            	switch (alt45) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forInit
            	        {
            	        	PushFollow(FOLLOW_forInit_in_forControl1979);
            	        	forInit190 = forInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInit190.Tree);

            	        }
            	        break;

            	}

            	char_literal191=(IToken)Match(input,24,FOLLOW_24_in_forControl1982); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal191_tree = (object)adaptor.Create(char_literal191);
            		adaptor.AddChild(root_0, char_literal191_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:23: ( expression )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( ((LA46_0 >= StringLiteral && LA46_0 <= LP) || (LA46_0 >= IntegerLiteral && LA46_0 <= InfinityLiteral) || (LA46_0 >= 58 && LA46_0 <= 59) || (LA46_0 >= 63 && LA46_0 <= 65)) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forControl1984);
            	        	expression192 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression192.Tree);

            	        }
            	        break;

            	}

            	char_literal193=(IToken)Match(input,24,FOLLOW_24_in_forControl1987); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal193_tree = (object)adaptor.Create(char_literal193);
            		adaptor.AddChild(root_0, char_literal193_tree);
            	}
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:347:39: ( forUpdate )?
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( ((LA47_0 >= StringLiteral && LA47_0 <= LP) || (LA47_0 >= IntegerLiteral && LA47_0 <= InfinityLiteral) || (LA47_0 >= 58 && LA47_0 <= 59) || (LA47_0 >= 63 && LA47_0 <= 65)) )
            	{
            	    alt47 = 1;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:0:0: forUpdate
            	        {
            	        	PushFollow(FOLLOW_forUpdate_in_forControl1989);
            	        	forUpdate194 = forUpdate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forUpdate194.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 54, forControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forControl"

    public class forInit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forInit"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:350:1: forInit : localVariableDeclaration ;
    public PsimulexParser.forInit_return forInit() // throws RecognitionException [1]
    {   
        PsimulexParser.forInit_return retval = new PsimulexParser.forInit_return();
        retval.Start = input.LT(1);
        int forInit_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.localVariableDeclaration_return localVariableDeclaration195 = default(PsimulexParser.localVariableDeclaration_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:5: ( localVariableDeclaration )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:351:9: localVariableDeclaration
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_localVariableDeclaration_in_forInit2009);
            	localVariableDeclaration195 = localVariableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, localVariableDeclaration195.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 55, forInit_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forInit"

    public class forUpdate_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forUpdate"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:354:1: forUpdate : expression ;
    public PsimulexParser.forUpdate_return forUpdate() // throws RecognitionException [1]
    {   
        PsimulexParser.forUpdate_return retval = new PsimulexParser.forUpdate_return();
        retval.Start = input.LT(1);
        int forUpdate_StartIndex = input.Index();
        object root_0 = null;

        PsimulexParser.expression_return expression196 = default(PsimulexParser.expression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:5: ( expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:355:9: expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_forUpdate2028);
            	expression196 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression196.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 56, forUpdate_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "forUpdate"

    public class foreachControl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "foreachControl"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:358:1: foreachControl options {k=3; } : type Identifier 'in' expression ;
    public PsimulexParser.foreachControl_return foreachControl() // throws RecognitionException [1]
    {   
        PsimulexParser.foreachControl_return retval = new PsimulexParser.foreachControl_return();
        retval.Start = input.LT(1);
        int foreachControl_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier198 = null;
        IToken string_literal199 = null;
        PsimulexParser.type_return type197 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression200 = default(PsimulexParser.expression_return);


        object Identifier198_tree=null;
        object string_literal199_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:5: ( type Identifier 'in' expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:360:9: type Identifier 'in' expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_foreachControl2059);
            	type197 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type197.Tree);
            	Identifier198=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_foreachControl2061); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier198_tree = (object)adaptor.Create(Identifier198);
            		adaptor.AddChild(root_0, Identifier198_tree);
            	}
            	string_literal199=(IToken)Match(input,79,FOLLOW_79_in_foreachControl2063); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal199_tree = (object)adaptor.Create(string_literal199);
            		adaptor.AddChild(root_0, string_literal199_tree);
            	}
            	PushFollow(FOLLOW_expression_in_foreachControl2065);
            	expression200 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression200.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 57, foreachControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "foreachControl"

    public class loopControl_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "loopControl"
    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:364:1: loopControl options {k=3; } : type Identifier 'to' expression ;
    public PsimulexParser.loopControl_return loopControl() // throws RecognitionException [1]
    {   
        PsimulexParser.loopControl_return retval = new PsimulexParser.loopControl_return();
        retval.Start = input.LT(1);
        int loopControl_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier202 = null;
        IToken string_literal203 = null;
        PsimulexParser.type_return type201 = default(PsimulexParser.type_return);

        PsimulexParser.expression_return expression204 = default(PsimulexParser.expression_return);


        object Identifier202_tree=null;
        object string_literal203_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:366:5: ( type Identifier 'to' expression )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:366:9: type Identifier 'to' expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_type_in_loopControl2097);
            	type201 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type201.Tree);
            	Identifier202=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_loopControl2099); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier202_tree = (object)adaptor.Create(Identifier202);
            		adaptor.AddChild(root_0, Identifier202_tree);
            	}
            	string_literal203=(IToken)Match(input,80,FOLLOW_80_in_loopControl2101); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal203_tree = (object)adaptor.Create(string_literal203);
            		adaptor.AddChild(root_0, string_literal203_tree);
            	}
            	PushFollow(FOLLOW_expression_in_loopControl2103);
            	expression204 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression204.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( state.backtracking==0 )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 58, loopControl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "loopControl"

    // $ANTLR start "synpred1_Psimulex"
    public void synpred1_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:11:7: ( simpleProgram )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:11:7: simpleProgram
        {
        	PushFollow(FOLLOW_simpleProgram_in_synpred1_Psimulex55);
        	simpleProgram();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Psimulex"

    // $ANTLR start "synpred9_Psimulex"
    public void synpred9_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:9: ( memberDeclaration )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:9: memberDeclaration
        {
        	PushFollow(FOLLOW_memberDeclaration_in_synpred9_Psimulex260);
        	memberDeclaration();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Psimulex"

    // $ANTLR start "synpred30_Psimulex"
    public void synpred30_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:32: ( assignmentOperator expression )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:149:32: assignmentOperator expression
        {
        	PushFollow(FOLLOW_assignmentOperator_in_synpred30_Psimulex756);
        	assignmentOperator();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_expression_in_synpred30_Psimulex758);
        	expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_Psimulex"

    // $ANTLR start "synpred42_Psimulex"
    public void synpred42_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:9: ( '<' '=' )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:182:10: '<' '='
        {
        	Match(input,56,FOLLOW_56_in_synpred42_Psimulex1007); if (state.failed) return ;
        	Match(input,28,FOLLOW_28_in_synpred42_Psimulex1009); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_Psimulex"

    // $ANTLR start "synpred43_Psimulex"
    public void synpred43_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:9: ( '>' '=' )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:185:10: '>' '='
        {
        	Match(input,57,FOLLOW_57_in_synpred43_Psimulex1041); if (state.failed) return ;
        	Match(input,28,FOLLOW_28_in_synpred43_Psimulex1043); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred43_Psimulex"

    // $ANTLR start "synpred58_Psimulex"
    public void synpred58_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:219:4: ( variable )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:219:4: variable
        {
        	PushFollow(FOLLOW_variable_in_synpred58_Psimulex1319);
        	variable();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred58_Psimulex"

    // $ANTLR start "synpred63_Psimulex"
    public void synpred63_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:4: ( arrayIndexing )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:270:4: arrayIndexing
        {
        	PushFollow(FOLLOW_arrayIndexing_in_synpred63_Psimulex1438);
        	arrayIndexing();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred63_Psimulex"

    // $ANTLR start "synpred75_Psimulex"
    public void synpred75_Psimulex_fragment() //throws RecognitionException
    {   
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:49: ( 'else' branch )
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:331:49: 'else' branch
        {
        	Match(input,68,FOLLOW_68_in_synpred75_Psimulex1787); if (state.failed) return ;
        	PushFollow(FOLLOW_branch_in_synpred75_Psimulex1789);
        	branch();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred75_Psimulex"

    // Delegated rules

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
   	public bool synpred43_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred43_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred42_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred42_Psimulex_fragment(); // can never throw exception
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
   	public bool synpred75_Psimulex() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred75_Psimulex_fragment(); // can never throw exception
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
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x10\uffff";
    const string DFA1_eofS =
        "\x01\x05\x0f\uffff";
    const string DFA1_minS =
        "\x01\x04\x01\x05\x01\uffff\x01\x00\x01\x18\x01\x00\x01\uffff\x01"+
        "\x1e\x01\x06\x02\x04\x01\x00\x01\x05\x01\x1e\x01\x18\x01\x05";
    const string DFA1_maxS =
        "\x01\x4e\x01\x1d\x01\uffff\x01\x00\x01\x42\x01\x00\x01\uffff\x01"+
        "\x1f\x01\x1d\x02\x41\x01\x00\x01\x05\x01\x1e\x01\x40\x01\x05";
    const string DFA1_acceptS =
        "\x02\uffff\x01\x01\x03\uffff\x01\x02\x09\uffff";
    const string DFA1_specialS =
        "\x03\uffff\x01\x00\x01\uffff\x01\x02\x05\uffff\x01\x01\x04\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x02\x01\x04\x01\x02\x01\uffff\x06\x02\x09\uffff\x01\x06"+
            "\x01\x03\x01\x06\x06\uffff\x05\x01\x15\uffff\x02\x02\x03\uffff"+
            "\x03\x02\x01\uffff\x01\x02\x01\uffff\x0a\x02",
            "\x01\x08\x17\uffff\x01\x07",
            "",
            "\x01\uffff",
            "\x01\x0b\x03\uffff\x01\x0a\x01\x09\x0f\uffff\x06\x02\x01\uffff"+
            "\x0d\x02\x01\uffff\x01\x02",
            "\x01\uffff",
            "",
            "\x01\x0c\x01\x0d",
            "\x01\x06\x11\uffff\x01\x02\x03\uffff\x02\x02",
            "\x03\x02\x01\uffff\x06\x02\x10\uffff\x02\x06\x1a\uffff\x02"+
            "\x02\x03\uffff\x03\x02",
            "\x01\x0e\x02\x02\x01\uffff\x06\x0e\x2c\uffff\x02\x02\x03\uffff"+
            "\x03\x02",
            "\x01\uffff",
            "\x01\x08",
            "\x01\x0f",
            "\x01\x0b\x03\uffff\x01\x02\x10\uffff\x06\x02\x01\uffff\x0d"+
            "\x02",
            "\x01\x08"
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
            get { return "10:1: compilationUnit : ( simpleProgram | multiFunctionalProgram );"; }
        }

    }


    protected internal int DFA1_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA1_3 = input.LA(1);

                   	 
                   	int index1_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 2; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index1_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_11 = input.LA(1);

                   	 
                   	int index1_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 2; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index1_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_5 = input.LA(1);

                   	 
                   	int index1_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_Psimulex()) ) { s = 2; }

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
 

    public static readonly BitSet FOLLOW_simpleProgram_in_compilationUnit55 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiFunctionalProgram_in_compilationUnit63 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fieldDeclaration_in_globalVariableDeclaration77 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_blockStatement_in_simpleProgram88 = new BitSet(new ulong[]{0x8C00001F01003F72UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_importDeclaration_in_multiFunctionalProgram100 = new BitSet(new ulong[]{0x0000001F03800022UL});
    public static readonly BitSet FOLLOW_typeDeclaration_in_multiFunctionalProgram108 = new BitSet(new ulong[]{0x0000001F03000022UL});
    public static readonly BitSet FOLLOW_globalVariableDeclaration_in_multiFunctionalProgram116 = new BitSet(new ulong[]{0x0000001F00000022UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_multiFunctionalProgram121 = new BitSet(new ulong[]{0x0000001F00000002UL});
    public static readonly BitSet FOLLOW_23_in_importDeclaration152 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_importDeclaration154 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_importDeclaration156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structDeclaration_in_typeDeclaration176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_24_in_typeDeclaration186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_structDeclaration205 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Identifier_in_structDeclaration207 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_structBody_in_structDeclaration217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_structBody236 = new BitSet(new ulong[]{0x0000001F08000020UL});
    public static readonly BitSet FOLLOW_structBodyDeclaration_in_structBody238 = new BitSet(new ulong[]{0x0000001F08000020UL});
    public static readonly BitSet FOLLOW_27_in_structBody241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_structBodyDeclaration260 = new BitSet(new ulong[]{0x0000001F08000022UL});
    public static readonly BitSet FOLLOW_type_in_memberDeclaration280 = new BitSet(new ulong[]{0x0000001F00000020UL});
    public static readonly BitSet FOLLOW_fieldDeclaration_in_memberDeclaration282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaratorId_in_fieldDeclaration301 = new BitSet(new ulong[]{0x0000000011000000UL});
    public static readonly BitSet FOLLOW_28_in_fieldDeclaration304 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_literal_in_fieldDeclaration306 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_fieldDeclaration311 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaratorId_in_variableDeclarator330 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_variableDeclarator333 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_variableInitializer_in_variableDeclarator335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_functionDeclaration359 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration361 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LP_in_functionDeclaration363 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_formalParameters_in_functionDeclaration365 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RP_in_functionDeclaration367 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_functionDeclaration369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableDeclaratorId397 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_variableDeclaratorId400 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_variableDeclaratorId402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_variableDeclaratorId404 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_variableDeclaratorId406 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_variableDeclaratorId408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInitializer439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_type467 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_type470 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_type472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_type474 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_type476 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_type478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_builtInType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_formalParameters631 = new BitSet(new ulong[]{0x0000101F800000A0UL});
    public static readonly BitSet FOLLOW_formalParameterDecls_in_formalParameters633 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RP_in_formalParameters636 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_formalParameterDecls659 = new BitSet(new ulong[]{0x0000101F80000020UL});
    public static readonly BitSet FOLLOW_44_in_formalParameterDecls662 = new BitSet(new ulong[]{0x0000101F80000020UL});
    public static readonly BitSet FOLLOW_formalParameterDeclsRest_in_formalParameterDecls666 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaratorId_in_formalParameterDeclsRest689 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_formalParameterDeclsRest692 = new BitSet(new ulong[]{0x0000101F80000020UL});
    public static readonly BitSet FOLLOW_formalParameterDecls_in_formalParameterDeclsRest694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_parExpression724 = new BitSet(new ulong[]{0x8C00001F01003FF0UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_parExpression727 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RP_in_parExpression729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression753 = new BitSet(new ulong[]{0x0003E00010000002UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_expression756 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_expression758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression852 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_conditionalExpression856 = new BitSet(new ulong[]{0x8C08001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_conditionalExpression858 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_conditionalExpression860 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_conditionalExpression862 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression884 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_52_in_conditionalOrExpression888 = new BitSet(new ulong[]{0x8C10001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression890 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression912 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_conditionalAndExpression916 = new BitSet(new ulong[]{0x8C20001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression918 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression940 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression944 = new BitSet(new ulong[]{0x8CC0001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression952 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression974 = new BitSet(new ulong[]{0x0300000000000002UL});
    public static readonly BitSet FOLLOW_relationalOp_in_relationalExpression978 = new BitSet(new ulong[]{0x8F00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression980 = new BitSet(new ulong[]{0x8F00001F01003F72UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_56_in_relationalOp1015 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_relationalOp1019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_relationalOp1049 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_relationalOp1053 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_relationalOp1074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_relationalOp1085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1106 = new BitSet(new ulong[]{0x0C00000000000002UL});
    public static readonly BitSet FOLLOW_58_in_additiveExpression1111 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_59_in_additiveExpression1116 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1120 = new BitSet(new ulong[]{0x0C00000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1142 = new BitSet(new ulong[]{0x7000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression1146 = new BitSet(new ulong[]{0xFC00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression1160 = new BitSet(new ulong[]{0x7000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_unaryExpression1186 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_unaryExpression1198 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1200 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_unaryExpression1210 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_unaryExpression1222 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_unaryExpressionNotPlusMinus1253 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_unaryExpressionNotPlusMinus1265 = new BitSet(new ulong[]{0x8000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus1267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftValue_in_primaryExpression1291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression1305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_leftValue1319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selecting_in_leftValue1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable1335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_selecting1347 = new BitSet(new ulong[]{0x0000000020000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_parExpression_in_selecting1349 = new BitSet(new ulong[]{0x0000000020000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_selector_in_selecting1352 = new BitSet(new ulong[]{0x0000000020000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_memberSelect_in_selector1369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberFunctionCall_in_selector1379 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_indexing_in_selector1389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_memberSelect1403 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberSelect1405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_memberFunctionCall1416 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Identifier_in_memberFunctionCall1418 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_arguments_in_memberFunctionCall1420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_indexing1438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixIndexing_in_indexing1443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_arrayIndexing1455 = new BitSet(new ulong[]{0x8C00001F41003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_arrayIndexing1457 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_arrayIndexing1459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_matrixIndexing1470 = new BitSet(new ulong[]{0x8C00001F81003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1472 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixIndexing1474 = new BitSet(new ulong[]{0x8C00001F41003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_matrixIndexing1476 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixIndexing1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_arguments1495 = new BitSet(new ulong[]{0x8C00001F81003FF0UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1497 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RP_in_arguments1500 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1517 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_31_in_expressionList1520 = new BitSet(new ulong[]{0x8C00001F81003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1522 = new BitSet(new ulong[]{0x0000000080000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_block1648 = new BitSet(new ulong[]{0x8C00001F09003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_blockStatement_in_block1650 = new BitSet(new ulong[]{0x8C00001F09003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_27_in_block1653 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclarationStatement_in_blockStatement1676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_blockStatement1686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_localVariableDeclarationStatement1710 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_localVariableDeclarationStatement1712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_localVariableDeclaration1731 = new BitSet(new ulong[]{0x0000001F10000020UL});
    public static readonly BitSet FOLLOW_variableDeclarator_in_localVariableDeclaration1733 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_in_branch1754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_blockStatement_in_branch1756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_statement1773 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1775 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_statement1777 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_statement1787 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_statement1789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_statement1801 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LP_in_statement1807 = new BitSet(new ulong[]{0x0000001F01000000UL});
    public static readonly BitSet FOLLOW_forControl_in_statement1809 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RP_in_statement1811 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_statement1813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_71_in_statement1823 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LP_in_statement1825 = new BitSet(new ulong[]{0x0000001F00000020UL});
    public static readonly BitSet FOLLOW_foreachControl_in_statement1827 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RP_in_statement1829 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_statement1831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_statement1841 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LP_in_statement1843 = new BitSet(new ulong[]{0x0000001F00000020UL});
    public static readonly BitSet FOLLOW_loopControl_in_statement1845 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RP_in_statement1847 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_statement1849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_statement1859 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1861 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_statement1863 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_statement1873 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_statement1875 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_statement1877 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_parExpression_in_statement1879 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_statement1881 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_statement1891 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_statement1893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_statement1903 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_statement1905 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_statement1908 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_statement1918 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_statement1920 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_statement1930 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_statement1932 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_24_in_statement1942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_statement1952 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_statement1954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInit_in_forControl1979 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_forControl1982 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_forControl1984 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_forControl1987 = new BitSet(new ulong[]{0x8C00001F01003F72UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_forUpdate_in_forControl1989 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_localVariableDeclaration_in_forInit2009 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forUpdate2028 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_foreachControl2059 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Identifier_in_foreachControl2061 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_foreachControl2063 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_foreachControl2065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_loopControl2097 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_Identifier_in_loopControl2099 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_loopControl2101 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_loopControl2103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleProgram_in_synpred1_Psimulex55 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberDeclaration_in_synpred9_Psimulex260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_synpred30_Psimulex756 = new BitSet(new ulong[]{0x8C00001F01003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_expression_in_synpred30_Psimulex758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_synpred42_Psimulex1007 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_synpred42_Psimulex1009 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_synpred43_Psimulex1041 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_synpred43_Psimulex1043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_synpred58_Psimulex1319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayIndexing_in_synpred63_Psimulex1438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_synpred75_Psimulex1787 = new BitSet(new ulong[]{0x8C00001F05003F70UL,0x0000000000007FEBUL});
    public static readonly BitSet FOLLOW_branch_in_synpred75_Psimulex1789 = new BitSet(new ulong[]{0x0000000000000002UL});

}
