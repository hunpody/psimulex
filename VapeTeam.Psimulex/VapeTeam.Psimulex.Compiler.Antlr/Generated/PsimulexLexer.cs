// $ANTLR 3.1 C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g 2008-09-02 01:17:04

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class PsimulexLexer : Lexer {
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int NullLiteral = 12;
    public const int T__29 = 29;
    public const int T__64 = 64;
    public const int T__28 = 28;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__63 = 63;
    public const int T__25 = 25;
    public const int SingleLineComment = 21;
    public const int RP = 7;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int CharacterLiteral = 10;
    public const int LP = 6;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int IDLetter = 15;
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
    public const int T__46 = 46;
    public const int T__80 = 80;
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
    public const int T__33 = 33;
    public const int T__71 = 71;
    public const int WS = 20;
    public const int T__34 = 34;
    public const int T__72 = 72;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__70 = 70;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int DecimalTypeSuffix = 18;
    public const int IntegerLiteral = 8;
    public const int NotNullDigit = 17;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int Letter = 14;
    public const int EscapeSequence = 19;
    public const int T__79 = 79;
    public const int BooleanLiteral = 11;
    public const int T__78 = 78;
    public const int T__77 = 77;
    public const int InfinityLiteral = 13;

    // delegates
    // delegators

    public PsimulexLexer() 
    {
		InitializeCyclicDFAs();
    }
    public PsimulexLexer(ICharStream input)
		: this(input, null) {
    }
    public PsimulexLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g";} 
    }

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:7:7: ( 'import' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:7:9: 'import'
            {
            	Match("import"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:8:7: ( ';' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:8:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:9:7: ( 'struct' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:9:9: 'struct'
            {
            	Match("struct"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:10:7: ( '{' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:10:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:11:7: ( '}' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:11:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:7: ( '=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:12:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:13:7: ( '[' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:13:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:14:7: ( ']' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:14:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:15:7: ( ',' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:15:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:7: ( 'bool' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:16:9: 'bool'
            {
            	Match("bool"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:17:7: ( 'char' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:17:9: 'char'
            {
            	Match("char"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:18:7: ( 'int' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:18:9: 'int'
            {
            	Match("int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:19:7: ( 'decimal' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:19:9: 'decimal'
            {
            	Match("decimal"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:7: ( 'string' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:20:9: 'string'
            {
            	Match("string"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:21:7: ( 'tree' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:21:9: 'tree'
            {
            	Match("tree"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:22:7: ( 'bintree' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:22:9: 'bintree'
            {
            	Match("bintree"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:23:7: ( 'set' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:23:9: 'set'
            {
            	Match("set"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:24:7: ( 'list' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:24:9: 'list'
            {
            	Match("list"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:25:7: ( 'stack' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:25:9: 'stack'
            {
            	Match("stack"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:26:7: ( 'queue' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:26:9: 'queue'
            {
            	Match("queue"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:27:7: ( 'pqueue' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:27:9: 'pqueue'
            {
            	Match("pqueue"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:28:7: ( '&' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:28:9: '&'
            {
            	Match('&'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:29:7: ( '+=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:29:9: '+='
            {
            	Match("+="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:30:7: ( '-=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:30:9: '-='
            {
            	Match("-="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:31:7: ( '*=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:31:9: '*='
            {
            	Match("*="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:32:7: ( '/=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:32:9: '/='
            {
            	Match("/="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:33:7: ( '%=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:33:9: '%='
            {
            	Match("%="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:34:7: ( '?' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:34:9: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:35:7: ( ':' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:35:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:36:7: ( '||' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:36:9: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:37:7: ( '&&' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:37:9: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:38:7: ( '==' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:38:9: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:39:7: ( '!=' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:39:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:40:7: ( '<' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:40:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:41:7: ( '>' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:41:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:42:7: ( '+' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:42:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:7: ( '-' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:43:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:44:7: ( '*' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:44:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:45:7: ( '/' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:45:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:46:7: ( '%' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:46:9: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:7: ( '++' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:47:9: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:48:7: ( '--' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:48:9: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:49:7: ( '!' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:49:9: '!'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:50:7: ( '.' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:50:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:51:7: ( 'if' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:51:9: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:52:7: ( 'else' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:52:9: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:53:7: ( 'for' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:53:9: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:7: ( 'pfor' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:54:9: 'pfor'
            {
            	Match("pfor"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:55:7: ( 'foreach' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:55:9: 'foreach'
            {
            	Match("foreach"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:7: ( 'loop' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:56:9: 'loop'
            {
            	Match("loop"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:57:7: ( 'while' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:57:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:7: ( 'do' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:58:9: 'do'
            {
            	Match("do"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:59:7: ( 'pdo' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:59:9: 'pdo'
            {
            	Match("pdo"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:7: ( 'return' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:60:9: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:61:7: ( 'break' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:61:9: 'break'
            {
            	Match("break"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:62:7: ( 'continue' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:62:9: 'continue'
            {
            	Match("continue"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:7: ( 'in' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:63:9: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:7: ( 'to' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:64:9: 'to'
            {
            	Match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "LP"
    public void mLP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:385:4: ( '(' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:385:6: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LP"

    // $ANTLR start "RP"
    public void mRP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:386:4: ( ')' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:386:6: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RP"

    // $ANTLR start "Letter"
    public void mLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:393:5: ( '\\u0024' | '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	if ( input.LA(1) == '$' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Letter"

    // $ANTLR start "IDLetter"
    public void mIDLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:410:5: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDLetter"

    // $ANTLR start "Digit"
    public void mDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:5: ( '0' .. '9' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:417:7: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Digit"

    // $ANTLR start "NotNullDigit"
    public void mNotNullDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:5: ( '1' .. '9' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:422:7: '1' .. '9'
            {
            	MatchRange('1','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NotNullDigit"

    // $ANTLR start "IntegerLiteral"
    public void mIntegerLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IntegerLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:16: ( ( '0' | NotNullDigit ( Digit )* ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:18: ( '0' | NotNullDigit ( Digit )* )
            {
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:18: ( '0' | NotNullDigit ( Digit )* )
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '0') )
            	{
            	    alt2 = 1;
            	}
            	else if ( ((LA2_0 >= '1' && LA2_0 <= '9')) )
            	{
            	    alt2 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:19: '0'
            	        {
            	        	Match('0'); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:25: NotNullDigit ( Digit )*
            	        {
            	        	mNotNullDigit(); 
            	        	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:38: ( Digit )*
            	        	do 
            	        	{
            	        	    int alt1 = 2;
            	        	    int LA1_0 = input.LA(1);

            	        	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	        	    {
            	        	        alt1 = 1;
            	        	    }


            	        	    switch (alt1) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:425:38: Digit
            	        			    {
            	        			    	mDigit(); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop1;
            	        	    }
            	        	} while (true);

            	        	loop1:
            	        		;	// Stops C# compiler whining that label 'loop1' has no statements


            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IntegerLiteral"

    // $ANTLR start "DecimalTypeSuffix"
    public void mDecimalTypeSuffix() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:428:19: ( ( 'm' | 'M' | 'd' | 'D' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:428:21: ( 'm' | 'M' | 'd' | 'D' )
            {
            	if ( input.LA(1) == 'D' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'm' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DecimalTypeSuffix"

    // $ANTLR start "DecimalLiteral"
    public void mDecimalLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DecimalLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:431:5: ( ( Digit )+ '.' ( Digit )* | '.' ( Digit )+ | ( Digit )+ DecimalTypeSuffix )
            int alt7 = 3;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:431:9: ( Digit )+ '.' ( Digit )*
                    {
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:431:9: ( Digit )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:431:9: Digit
                    			    {
                    			    	mDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt3 >= 1 ) goto loop3;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(3, input);
                    		            throw eee;
                    	    }
                    	    cnt3++;
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whinging that label 'loop3' has no statements

                    	Match('.'); 
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:431:20: ( Digit )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:431:20: Digit
                    			    {
                    			    	mDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:9: '.' ( Digit )+
                    {
                    	Match('.'); 
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:13: ( Digit )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:432:13: Digit
                    			    {
                    			    	mDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(5, input);
                    		            throw eee;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whinging that label 'loop5' has no statements


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:433:9: ( Digit )+ DecimalTypeSuffix
                    {
                    	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:433:9: ( Digit )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:433:9: Digit
                    			    {
                    			    	mDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(6, input);
                    		            throw eee;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whinging that label 'loop6' has no statements

                    	mDecimalTypeSuffix(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DecimalLiteral"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:438:5: ( '\\\\' ( 't' | 'n' | 'r' | '\\\"' | '\\'' | '\\\\' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:438:9: '\\\\' ( 't' | 'n' | 'r' | '\\\"' | '\\'' | '\\\\' )
            {
            	Match('\\'); 
            	if ( input.LA(1) == '\"' || input.LA(1) == '\'' || input.LA(1) == '\\' || input.LA(1) == 'n' || input.LA(1) == 'r' || input.LA(1) == 't' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "CharacterLiteral"
    public void mCharacterLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CharacterLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:442:5: ( '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' ) ) '\\'' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:442:9: '\\'' ( EscapeSequence | ~ ( '\\'' | '\\\\' ) ) '\\''
            {
            	Match('\''); 
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:442:14: ( EscapeSequence | ~ ( '\\'' | '\\\\' ) )
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == '\\') )
            	{
            	    alt8 = 1;
            	}
            	else if ( ((LA8_0 >= '\u0000' && LA8_0 <= '&') || (LA8_0 >= '(' && LA8_0 <= '[') || (LA8_0 >= ']' && LA8_0 <= '\uFFFE')) )
            	{
            	    alt8 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:442:16: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:442:33: ~ ( '\\'' | '\\\\' )
            	        {
            	        	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFE') ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CharacterLiteral"

    // $ANTLR start "StringLiteral"
    public void mStringLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = StringLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:5: ( '\"' ( EscapeSequence | ~ ( '\"' | '\\\\' ) )+ '\"' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:7: '\"' ( EscapeSequence | ~ ( '\"' | '\\\\' ) )+ '\"'
            {
            	Match('\"'); 
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:11: ( EscapeSequence | ~ ( '\"' | '\\\\' ) )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 3;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == '\\') )
            	    {
            	        alt9 = 1;
            	    }
            	    else if ( ((LA9_0 >= '\u0000' && LA9_0 <= '!') || (LA9_0 >= '#' && LA9_0 <= '[') || (LA9_0 >= ']' && LA9_0 <= '\uFFFE')) )
            	    {
            	        alt9 = 2;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:13: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:446:30: ~ ( '\"' | '\\\\' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            		            EarlyExitException eee =
            		                new EarlyExitException(9, input);
            		            throw eee;
            	    }
            	    cnt9++;
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whinging that label 'loop9' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "StringLiteral"

    // $ANTLR start "BooleanLiteral"
    public void mBooleanLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BooleanLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:5: ( 'true' | 'false' | 'True' | 'False' | 'TRUE' | 'FALSE' )
            int alt10 = 6;
            switch ( input.LA(1) ) 
            {
            case 't':
            	{
                alt10 = 1;
                }
                break;
            case 'f':
            	{
                alt10 = 2;
                }
                break;
            case 'T':
            	{
                int LA10_3 = input.LA(2);

                if ( (LA10_3 == 'r') )
                {
                    alt10 = 3;
                }
                else if ( (LA10_3 == 'R') )
                {
                    alt10 = 5;
                }
                else 
                {
                    NoViableAltException nvae_d10s3 =
                        new NoViableAltException("", 10, 3, input);

                    throw nvae_d10s3;
                }
                }
                break;
            case 'F':
            	{
                int LA10_4 = input.LA(2);

                if ( (LA10_4 == 'a') )
                {
                    alt10 = 4;
                }
                else if ( (LA10_4 == 'A') )
                {
                    alt10 = 6;
                }
                else 
                {
                    NoViableAltException nvae_d10s4 =
                        new NoViableAltException("", 10, 4, input);

                    throw nvae_d10s4;
                }
                }
                break;
            	default:
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:7: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:450:14: 'false'
                    {
                    	Match("false"); 


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:451:7: 'True'
                    {
                    	Match("True"); 


                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:451:14: 'False'
                    {
                    	Match("False"); 


                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:452:7: 'TRUE'
                    {
                    	Match("TRUE"); 


                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:452:14: 'FALSE'
                    {
                    	Match("FALSE"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BooleanLiteral"

    // $ANTLR start "NullLiteral"
    public void mNullLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NullLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:456:5: ( 'null' | 'nil' | 'Null' | 'Nil' | 'NULL' | 'NIL' )
            int alt11 = 6;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == 'n') )
            {
                int LA11_1 = input.LA(2);

                if ( (LA11_1 == 'u') )
                {
                    alt11 = 1;
                }
                else if ( (LA11_1 == 'i') )
                {
                    alt11 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d11s1 =
                        new NoViableAltException("", 11, 1, input);

                    throw nvae_d11s1;
                }
            }
            else if ( (LA11_0 == 'N') )
            {
                switch ( input.LA(2) ) 
                {
                case 'u':
                	{
                    alt11 = 3;
                    }
                    break;
                case 'i':
                	{
                    alt11 = 4;
                    }
                    break;
                case 'U':
                	{
                    alt11 = 5;
                    }
                    break;
                case 'I':
                	{
                    alt11 = 6;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d11s2 =
                	        new NoViableAltException("", 11, 2, input);

                	    throw nvae_d11s2;
                }

            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:456:7: 'null'
                    {
                    	Match("null"); 


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:456:14: 'nil'
                    {
                    	Match("nil"); 


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:457:7: 'Null'
                    {
                    	Match("Null"); 


                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:457:14: 'Nil'
                    {
                    	Match("Nil"); 


                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:458:7: 'NULL'
                    {
                    	Match("NULL"); 


                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:458:14: 'NIL'
                    {
                    	Match("NIL"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NullLiteral"

    // $ANTLR start "InfinityLiteral"
    public void mInfinityLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = InfinityLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:462:5: ( 'inf' | 'infinity' | 'Inf' | 'Infinity' | 'INF' | 'INFINITY' )
            int alt12 = 6;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:462:7: 'inf'
                    {
                    	Match("inf"); 


                    }
                    break;
                case 2 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:462:13: 'infinity'
                    {
                    	Match("infinity"); 


                    }
                    break;
                case 3 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:463:7: 'Inf'
                    {
                    	Match("Inf"); 


                    }
                    break;
                case 4 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:463:13: 'Infinity'
                    {
                    	Match("Infinity"); 


                    }
                    break;
                case 5 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:464:7: 'INF'
                    {
                    	Match("INF"); 


                    }
                    break;
                case 6 :
                    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:464:13: 'INFINITY'
                    {
                    	Match("INFINITY"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "InfinityLiteral"

    // $ANTLR start "Identifier"
    public void mIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Identifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:468:5: ( IDLetter ( IDLetter | Digit )* )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:468:9: IDLetter ( IDLetter | Digit )*
            {
            	mIDLetter(); 
            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:468:18: ( IDLetter | Digit )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '0' && LA13_0 <= '9') || (LA13_0 >= 'A' && LA13_0 <= 'Z') || LA13_0 == '_' || (LA13_0 >= 'a' && LA13_0 <= 'z')) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Identifier"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:471:5: ( ( ' ' | '\\t' | '\\n' | '\\r' ) )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:471:8: ( ' ' | '\\t' | '\\n' | '\\r' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "SingleLineComment"
    public void mSingleLineComment() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SingleLineComment;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? ( '\\n' )? )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:7: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? ( '\\n' )?
            {
            	Match("//"); 

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:12: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= '\u0000' && LA14_0 <= '\t') || (LA14_0 >= '\u000B' && LA14_0 <= '\f') || (LA14_0 >= '\u000E' && LA14_0 <= '\uFFFE')) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:12: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:26: ( '\\r' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == '\r') )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:26: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:32: ( '\\n' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == '\n') )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:475:32: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;

            	}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SingleLineComment"

    // $ANTLR start "MultiLineComment"
    public void mMultiLineComment() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MultiLineComment;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:479:5: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:479:9: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); 

            	// C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:479:14: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == '*') )
            	    {
            	        int LA17_1 = input.LA(2);

            	        if ( (LA17_1 == '/') )
            	        {
            	            alt17 = 2;
            	        }
            	        else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '.') || (LA17_1 >= '0' && LA17_1 <= '\uFFFE')) )
            	        {
            	            alt17 = 1;
            	        }


            	    }
            	    else if ( ((LA17_0 >= '\u0000' && LA17_0 <= ')') || (LA17_0 >= '+' && LA17_0 <= '\uFFFE')) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:479:42: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	Match("*/"); 

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MultiLineComment"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:8: ( T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | LP | RP | IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral | Identifier | WS | SingleLineComment | MultiLineComment )
        int alt18 = 71;
        alt18 = dfa18.Predict(input);
        switch (alt18) 
        {
            case 1 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:10: T__23
                {
                	mT__23(); 

                }
                break;
            case 2 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:16: T__24
                {
                	mT__24(); 

                }
                break;
            case 3 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:22: T__25
                {
                	mT__25(); 

                }
                break;
            case 4 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:28: T__26
                {
                	mT__26(); 

                }
                break;
            case 5 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:34: T__27
                {
                	mT__27(); 

                }
                break;
            case 6 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:40: T__28
                {
                	mT__28(); 

                }
                break;
            case 7 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:46: T__29
                {
                	mT__29(); 

                }
                break;
            case 8 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:52: T__30
                {
                	mT__30(); 

                }
                break;
            case 9 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:58: T__31
                {
                	mT__31(); 

                }
                break;
            case 10 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:64: T__32
                {
                	mT__32(); 

                }
                break;
            case 11 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:70: T__33
                {
                	mT__33(); 

                }
                break;
            case 12 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:76: T__34
                {
                	mT__34(); 

                }
                break;
            case 13 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:82: T__35
                {
                	mT__35(); 

                }
                break;
            case 14 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:88: T__36
                {
                	mT__36(); 

                }
                break;
            case 15 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:94: T__37
                {
                	mT__37(); 

                }
                break;
            case 16 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:100: T__38
                {
                	mT__38(); 

                }
                break;
            case 17 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:106: T__39
                {
                	mT__39(); 

                }
                break;
            case 18 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:112: T__40
                {
                	mT__40(); 

                }
                break;
            case 19 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:118: T__41
                {
                	mT__41(); 

                }
                break;
            case 20 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:124: T__42
                {
                	mT__42(); 

                }
                break;
            case 21 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:130: T__43
                {
                	mT__43(); 

                }
                break;
            case 22 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:136: T__44
                {
                	mT__44(); 

                }
                break;
            case 23 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:142: T__45
                {
                	mT__45(); 

                }
                break;
            case 24 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:148: T__46
                {
                	mT__46(); 

                }
                break;
            case 25 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:154: T__47
                {
                	mT__47(); 

                }
                break;
            case 26 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:160: T__48
                {
                	mT__48(); 

                }
                break;
            case 27 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:166: T__49
                {
                	mT__49(); 

                }
                break;
            case 28 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:172: T__50
                {
                	mT__50(); 

                }
                break;
            case 29 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:178: T__51
                {
                	mT__51(); 

                }
                break;
            case 30 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:184: T__52
                {
                	mT__52(); 

                }
                break;
            case 31 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:190: T__53
                {
                	mT__53(); 

                }
                break;
            case 32 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:196: T__54
                {
                	mT__54(); 

                }
                break;
            case 33 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:202: T__55
                {
                	mT__55(); 

                }
                break;
            case 34 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:208: T__56
                {
                	mT__56(); 

                }
                break;
            case 35 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:214: T__57
                {
                	mT__57(); 

                }
                break;
            case 36 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:220: T__58
                {
                	mT__58(); 

                }
                break;
            case 37 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:226: T__59
                {
                	mT__59(); 

                }
                break;
            case 38 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:232: T__60
                {
                	mT__60(); 

                }
                break;
            case 39 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:238: T__61
                {
                	mT__61(); 

                }
                break;
            case 40 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:244: T__62
                {
                	mT__62(); 

                }
                break;
            case 41 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:250: T__63
                {
                	mT__63(); 

                }
                break;
            case 42 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:256: T__64
                {
                	mT__64(); 

                }
                break;
            case 43 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:262: T__65
                {
                	mT__65(); 

                }
                break;
            case 44 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:268: T__66
                {
                	mT__66(); 

                }
                break;
            case 45 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:274: T__67
                {
                	mT__67(); 

                }
                break;
            case 46 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:280: T__68
                {
                	mT__68(); 

                }
                break;
            case 47 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:286: T__69
                {
                	mT__69(); 

                }
                break;
            case 48 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:292: T__70
                {
                	mT__70(); 

                }
                break;
            case 49 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:298: T__71
                {
                	mT__71(); 

                }
                break;
            case 50 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:304: T__72
                {
                	mT__72(); 

                }
                break;
            case 51 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:310: T__73
                {
                	mT__73(); 

                }
                break;
            case 52 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:316: T__74
                {
                	mT__74(); 

                }
                break;
            case 53 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:322: T__75
                {
                	mT__75(); 

                }
                break;
            case 54 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:328: T__76
                {
                	mT__76(); 

                }
                break;
            case 55 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:334: T__77
                {
                	mT__77(); 

                }
                break;
            case 56 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:340: T__78
                {
                	mT__78(); 

                }
                break;
            case 57 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:346: T__79
                {
                	mT__79(); 

                }
                break;
            case 58 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:352: T__80
                {
                	mT__80(); 

                }
                break;
            case 59 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:358: LP
                {
                	mLP(); 

                }
                break;
            case 60 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:361: RP
                {
                	mRP(); 

                }
                break;
            case 61 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:364: IntegerLiteral
                {
                	mIntegerLiteral(); 

                }
                break;
            case 62 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:379: DecimalLiteral
                {
                	mDecimalLiteral(); 

                }
                break;
            case 63 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:394: CharacterLiteral
                {
                	mCharacterLiteral(); 

                }
                break;
            case 64 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:411: StringLiteral
                {
                	mStringLiteral(); 

                }
                break;
            case 65 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:425: BooleanLiteral
                {
                	mBooleanLiteral(); 

                }
                break;
            case 66 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:440: NullLiteral
                {
                	mNullLiteral(); 

                }
                break;
            case 67 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:452: InfinityLiteral
                {
                	mInfinityLiteral(); 

                }
                break;
            case 68 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:468: Identifier
                {
                	mIdentifier(); 

                }
                break;
            case 69 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:479: WS
                {
                	mWS(); 

                }
                break;
            case 70 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:482: SingleLineComment
                {
                	mSingleLineComment(); 

                }
                break;
            case 71 :
                // C:\\Works\\Psimulex\\VapeTeam.Psimulex\\VapeTeam.Psimulex.Compiler.Antlr\\Grammar\\Psimulex.g:1:500: MultiLineComment
                {
                	mMultiLineComment(); 

                }
                break;

        }

    }


    protected DFA7 dfa7;
    protected DFA12 dfa12;
    protected DFA18 dfa18;
	private void InitializeCyclicDFAs()
	{
	    this.dfa7 = new DFA7(this);
	    this.dfa12 = new DFA12(this);
	    this.dfa18 = new DFA18(this);



	}

    const string DFA7_eotS =
        "\x05\uffff";
    const string DFA7_eofS =
        "\x05\uffff";
    const string DFA7_minS =
        "\x02\x2e\x03\uffff";
    const string DFA7_maxS =
        "\x01\x39\x01\x6d\x03\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x01";
    const string DFA7_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x04\x01\uffff\x0a\x01\x0a\uffff\x01\x03\x08\uffff\x01"+
            "\x03\x16\uffff\x01\x03\x08\uffff\x01\x03",
            "",
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
            get { return "430:1: DecimalLiteral : ( ( Digit )+ '.' ( Digit )* | '.' ( Digit )+ | ( Digit )+ DecimalTypeSuffix );"; }
        }

    }

    const string DFA12_eotS =
        "\x06\uffff\x01\x0a\x01\x0c\x01\x0e\x06\uffff";
    const string DFA12_eofS =
        "\x0f\uffff";
    const string DFA12_minS =
        "\x01\x49\x01\x6e\x01\x4e\x02\x66\x01\x46\x02\x69\x01\x49\x06\uffff";
    const string DFA12_maxS =
        "\x01\x69\x02\x6e\x02\x66\x01\x46\x02\x69\x01\x49\x06\uffff";
    const string DFA12_acceptS =
        "\x09\uffff\x01\x02\x01\x01\x01\x04\x01\x03\x01\x06\x01\x05";
    const string DFA12_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x02\x1f\uffff\x01\x01",
            "\x01\x03",
            "\x01\x05\x1f\uffff\x01\x04",
            "\x01\x06",
            "\x01\x07",
            "\x01\x08",
            "\x01\x09",
            "\x01\x0b",
            "\x01\x0d",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "461:1: InfinityLiteral : ( 'inf' | 'infinity' | 'Inf' | 'Infinity' | 'INF' | 'INFINITY' );"; }
        }

    }

    const string DFA18_eotS =
        "\x01\uffff\x01\x2d\x01\uffff\x01\x2d\x02\uffff\x01\x35\x03\uffff"+
        "\x07\x2d\x01\x46\x01\x49\x01\x4c\x01\x4e\x01\x52\x01\x54\x03\uffff"+
        "\x01\x56\x02\uffff\x01\x58\x04\x2d\x02\uffff\x02\x5e\x02\uffff\x05"+
        "\x2d\x02\uffff\x01\x2d\x01\x6f\x01\x70\x02\x2d\x02\uffff\x06\x2d"+
        "\x01\x7a\x01\x2d\x01\x7d\x06\x2d\x14\uffff\x05\x2d\x01\uffff\x01"+
        "\x5e\x0d\x2d\x01\u0096\x01\u0098\x02\uffff\x02\x2d\x01\u009c\x06"+
        "\x2d\x01\uffff\x02\x2d\x01\uffff\x05\x2d\x01\u00aa\x01\x2d\x01\u00ad"+
        "\x08\x2d\x01\u00b6\x01\x2d\x01\u00b6\x01\x2d\x01\u00b6\x02\u0098"+
        "\x01\x2d\x01\uffff\x01\x2d\x01\uffff\x03\x2d\x01\uffff\x01\u00c0"+
        "\x02\x2d\x01\u00c3\x02\x2d\x01\u00c6\x01\u00c7\x01\u00c8\x01\u00c9"+
        "\x02\x2d\x01\u00cc\x01\uffff\x01\u00cd\x01\x2d\x01\uffff\x03\x2d"+
        "\x02\u00c7\x02\x2d\x01\u00b6\x01\uffff\x02\u00b6\x06\x2d\x01\u00da"+
        "\x01\uffff\x01\x2d\x01\u00dc\x01\uffff\x02\x2d\x04\uffff\x01\u00df"+
        "\x01\x2d\x02\uffff\x01\x2d\x01\u00c7\x01\u00e2\x01\x2d\x02\u00c7"+
        "\x02\x2d\x01\u00e6\x01\x2d\x01\u00e8\x01\u00e9\x01\uffff\x01\x2d"+
        "\x01\uffff\x02\x2d\x01\uffff\x01\u00ed\x01\x2d\x01\uffff\x01\u00ef"+
        "\x02\x2d\x01\uffff\x01\x2d\x02\uffff\x01\u00f3\x01\x2d\x01\u00f5"+
        "\x01\uffff\x01\u00f6\x01\uffff\x02\x2d\x01\u0098\x01\uffff\x01\u00f9"+
        "\x02\uffff\x02\u0098\x01\uffff";
    const string DFA18_eofS =
        "\u00fa\uffff";
    const string DFA18_minS =
        "\x01\x09\x01\x66\x01\uffff\x01\x65\x02\uffff\x01\x3d\x03\uffff"+
        "\x01\x69\x01\x68\x01\x65\x01\x6f\x01\x69\x01\x75\x01\x64\x01\x26"+
        "\x01\x2b\x01\x2d\x01\x3d\x01\x2a\x01\x3d\x03\uffff\x01\x3d\x02\uffff"+
        "\x01\x30\x01\x6c\x01\x61\x01\x68\x01\x65\x02\uffff\x02\x2e\x02\uffff"+
        "\x01\x52\x01\x41\x01\x69\x01\x49\x01\x4e\x02\uffff\x01\x70\x02\x30"+
        "\x01\x61\x01\x74\x02\uffff\x01\x6f\x01\x6e\x01\x65\x01\x61\x01\x6e"+
        "\x01\x63\x01\x30\x01\x65\x01\x30\x01\x73\x01\x6f\x01\x65\x01\x75"+
        "\x02\x6f\x14\uffff\x01\x73\x01\x72\x01\x6c\x01\x69\x01\x74\x01\uffff"+
        "\x01\x2e\x01\x75\x01\x55\x01\x6c\x01\x4c\x04\x6c\x02\x4c\x01\x66"+
        "\x01\x46\x01\x6f\x02\x30\x02\uffff\x01\x69\x01\x63\x01\x30\x01\x6c"+
        "\x01\x74\x01\x61\x01\x72\x01\x74\x01\x69\x01\uffff\x02\x65\x01\uffff"+
        "\x01\x74\x01\x70\x01\x75\x01\x65\x01\x72\x01\x30\x01\x65\x01\x30"+
        "\x01\x73\x01\x6c\x01\x75\x01\x65\x01\x45\x01\x73\x01\x53\x01\x6c"+
        "\x01\x30\x01\x6c\x01\x30\x01\x4c\x03\x30\x01\x72\x01\uffff\x01\x6e"+
        "\x01\uffff\x01\x63\x01\x6e\x01\x6b\x01\uffff\x01\x30\x01\x72\x01"+
        "\x6b\x01\x30\x01\x69\x01\x6d\x04\x30\x01\x65\x01\x75\x01\x30\x01"+
        "\uffff\x01\x30\x01\x61\x01\uffff\x02\x65\x01\x72\x02\x30\x01\x65"+
        "\x01\x45\x01\x30\x01\uffff\x02\x30\x01\x6e\x01\x4e\x01\x74\x01\x69"+
        "\x01\x74\x01\x67\x01\x30\x01\uffff\x01\x65\x01\x30\x01\uffff\x01"+
        "\x6e\x01\x61\x04\uffff\x01\x30\x01\x65\x02\uffff\x01\x63\x02\x30"+
        "\x01\x6e\x02\x30\x01\x69\x01\x49\x01\x30\x01\x74\x02\x30\x01\uffff"+
        "\x01\x65\x01\uffff\x01\x75\x01\x6c\x01\uffff\x01\x30\x01\x68\x01"+
        "\uffff\x01\x30\x01\x74\x01\x54\x01\uffff\x01\x79\x02\uffff\x01\x30"+
        "\x01\x65\x01\x30\x01\uffff\x01\x30\x01\uffff\x01\x79\x01\x59\x01"+
        "\x30\x01\uffff\x01\x30\x02\uffff\x02\x30\x01\uffff";
    const string DFA18_maxS =
        "\x01\x7d\x01\x6e\x01\uffff\x01\x74\x02\uffff\x01\x3d\x03\uffff"+
        "\x01\x72\x02\x6f\x01\x72\x01\x6f\x01\x75\x01\x71\x01\x26\x05\x3d"+
        "\x03\uffff\x01\x3d\x02\uffff\x01\x39\x01\x6c\x01\x6f\x01\x68\x01"+
        "\x65\x02\uffff\x02\x6d\x02\uffff\x01\x72\x01\x61\x02\x75\x01\x6e"+
        "\x02\uffff\x01\x70\x02\x7a\x01\x72\x01\x74\x02\uffff\x01\x6f\x01"+
        "\x6e\x01\x65\x01\x61\x01\x6e\x01\x63\x01\x7a\x01\x75\x01\x7a\x01"+
        "\x73\x01\x6f\x01\x65\x01\x75\x02\x6f\x14\uffff\x01\x73\x01\x72\x01"+
        "\x6c\x01\x69\x01\x74\x01\uffff\x01\x6d\x01\x75\x01\x55\x01\x6c\x01"+
        "\x4c\x04\x6c\x02\x4c\x01\x66\x01\x46\x01\x6f\x02\x7a\x02\uffff\x01"+
        "\x75\x01\x63\x01\x7a\x01\x6c\x01\x74\x01\x61\x01\x72\x01\x74\x01"+
        "\x69\x01\uffff\x02\x65\x01\uffff\x01\x74\x01\x70\x01\x75\x01\x65"+
        "\x01\x72\x01\x7a\x01\x65\x01\x7a\x01\x73\x01\x6c\x01\x75\x01\x65"+
        "\x01\x45\x01\x73\x01\x53\x01\x6c\x01\x7a\x01\x6c\x01\x7a\x01\x4c"+
        "\x03\x7a\x01\x72\x01\uffff\x01\x6e\x01\uffff\x01\x63\x01\x6e\x01"+
        "\x6b\x01\uffff\x01\x7a\x01\x72\x01\x6b\x01\x7a\x01\x69\x01\x6d\x04"+
        "\x7a\x01\x65\x01\x75\x01\x7a\x01\uffff\x01\x7a\x01\x61\x01\uffff"+
        "\x02\x65\x01\x72\x02\x7a\x01\x65\x01\x45\x01\x7a\x01\uffff\x02\x7a"+
        "\x01\x6e\x01\x4e\x01\x74\x01\x69\x01\x74\x01\x67\x01\x7a\x01\uffff"+
        "\x01\x65\x01\x7a\x01\uffff\x01\x6e\x01\x61\x04\uffff\x01\x7a\x01"+
        "\x65\x02\uffff\x01\x63\x02\x7a\x01\x6e\x02\x7a\x01\x69\x01\x49\x01"+
        "\x7a\x01\x74\x02\x7a\x01\uffff\x01\x65\x01\uffff\x01\x75\x01\x6c"+
        "\x01\uffff\x01\x7a\x01\x68\x01\uffff\x01\x7a\x01\x74\x01\x54\x01"+
        "\uffff\x01\x79\x02\uffff\x01\x7a\x01\x65\x01\x7a\x01\uffff\x01\x7a"+
        "\x01\uffff\x01\x79\x01\x59\x01\x7a\x01\uffff\x01\x7a\x02\uffff\x02"+
        "\x7a\x01\uffff";
    const string DFA18_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x04\x01\x05\x01\uffff\x01\x07"+
        "\x01\x08\x01\x09\x0d\uffff\x01\x1c\x01\x1d\x01\x1e\x01\uffff\x01"+
        "\x22\x01\x23\x05\uffff\x01\x3b\x01\x3c\x02\uffff\x01\x3f\x01\x40"+
        "\x05\uffff\x01\x44\x01\x45\x05\uffff\x01\x20\x01\x06\x0f\uffff\x01"+
        "\x1f\x01\x16\x01\x17\x01\x29\x01\x24\x01\x18\x01\x2a\x01\x25\x01"+
        "\x19\x01\x26\x01\x1a\x01\x46\x01\x47\x01\x27\x01\x1b\x01\x28\x01"+
        "\x21\x01\x2b\x01\x3e\x01\x2c\x05\uffff\x01\x3d\x10\uffff\x01\x39"+
        "\x01\x2d\x09\uffff\x01\x34\x02\uffff\x01\x3a\x18\uffff\x01\x0c\x01"+
        "\uffff\x01\x43\x03\uffff\x01\x11\x0d\uffff\x01\x35\x02\uffff\x01"+
        "\x2f\x08\uffff\x01\x42\x09\uffff\x01\x0a\x02\uffff\x01\x0b\x02\uffff"+
        "\x01\x0f\x01\x41\x01\x12\x01\x32\x02\uffff\x01\x30\x01\x2e\x0c\uffff"+
        "\x01\x13\x01\uffff\x01\x37\x02\uffff\x01\x14\x02\uffff\x01\x33\x03"+
        "\uffff\x01\x01\x01\uffff\x01\x03\x01\x0e\x03\uffff\x01\x15\x01\uffff"+
        "\x01\x36\x03\uffff\x01\x10\x01\uffff\x01\x0d\x01\x31\x02\uffff\x01"+
        "\x38";
    const string DFA18_specialS =
        "\u00fa\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x02\x2e\x02\uffff\x01\x2e\x12\uffff\x01\x2e\x01\x1a\x01\x27"+
            "\x02\uffff\x01\x16\x01\x11\x01\x26\x01\x22\x01\x23\x01\x14\x01"+
            "\x12\x01\x09\x01\x13\x01\x1d\x01\x15\x01\x24\x09\x25\x01\x18"+
            "\x01\x02\x01\x1b\x01\x06\x01\x1c\x01\x17\x01\uffff\x05\x2d\x01"+
            "\x29\x02\x2d\x01\x2c\x04\x2d\x01\x2b\x05\x2d\x01\x28\x06\x2d"+
            "\x01\x07\x01\uffff\x01\x08\x01\uffff\x01\x2d\x01\uffff\x01\x2d"+
            "\x01\x0a\x01\x0b\x01\x0c\x01\x1e\x01\x1f\x02\x2d\x01\x01\x02"+
            "\x2d\x01\x0e\x01\x2d\x01\x2a\x01\x2d\x01\x10\x01\x0f\x01\x21"+
            "\x01\x03\x01\x0d\x02\x2d\x01\x20\x03\x2d\x01\x04\x01\x19\x01"+
            "\x05",
            "\x01\x31\x06\uffff\x01\x2f\x01\x30",
            "",
            "\x01\x33\x0e\uffff\x01\x32",
            "",
            "",
            "\x01\x34",
            "",
            "",
            "",
            "\x01\x37\x05\uffff\x01\x36\x02\uffff\x01\x38",
            "\x01\x39\x06\uffff\x01\x3a",
            "\x01\x3b\x09\uffff\x01\x3c",
            "\x01\x3e\x02\uffff\x01\x3d",
            "\x01\x3f\x05\uffff\x01\x40",
            "\x01\x41",
            "\x01\x44\x01\uffff\x01\x43\x0a\uffff\x01\x42",
            "\x01\x45",
            "\x01\x48\x11\uffff\x01\x47",
            "\x01\x4b\x0f\uffff\x01\x4a",
            "\x01\x4d",
            "\x01\x51\x04\uffff\x01\x50\x0d\uffff\x01\x4f",
            "\x01\x53",
            "",
            "",
            "",
            "\x01\x55",
            "",
            "",
            "\x0a\x57",
            "\x01\x59",
            "\x01\x5b\x0d\uffff\x01\x5a",
            "\x01\x5c",
            "\x01\x5d",
            "",
            "",
            "\x01\x57\x01\uffff\x0a\x57\x0a\uffff\x01\x57\x08\uffff\x01"+
            "\x57\x16\uffff\x01\x57\x08\uffff\x01\x57",
            "\x01\x57\x01\uffff\x0a\x5f\x0a\uffff\x01\x57\x08\uffff\x01"+
            "\x57\x16\uffff\x01\x57\x08\uffff\x01\x57",
            "",
            "",
            "\x01\x61\x1f\uffff\x01\x60",
            "\x01\x63\x1f\uffff\x01\x62",
            "\x01\x65\x0b\uffff\x01\x64",
            "\x01\x69\x0b\uffff\x01\x68\x13\uffff\x01\x67\x0b\uffff\x01"+
            "\x66",
            "\x01\x6b\x1f\uffff\x01\x6a",
            "",
            "",
            "\x01\x6c",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x05"+
            "\x2d\x01\x6e\x0d\x2d\x01\x6d\x06\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\x72\x10\uffff\x01\x71",
            "\x01\x73",
            "",
            "",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\x7b\x0f\uffff\x01\x7c",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
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
            "",
            "",
            "",
            "",
            "",
            "\x01\u0084",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "",
            "\x01\x57\x01\uffff\x0a\x5f\x0a\uffff\x01\x57\x08\uffff\x01"+
            "\x57\x16\uffff\x01\x57\x08\uffff\x01\x57",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\u008f",
            "\x01\u0090",
            "\x01\u0091",
            "\x01\u0092",
            "\x01\u0093",
            "\x01\u0094",
            "\x01\u0095",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x08"+
            "\x2d\x01\u0097\x11\x2d",
            "",
            "",
            "\x01\u009a\x0b\uffff\x01\u0099",
            "\x01\u009b",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u009d",
            "\x01\u009e",
            "\x01\u009f",
            "\x01\u00a0",
            "\x01\u00a1",
            "\x01\u00a2",
            "",
            "\x01\u00a3",
            "\x01\u00a4",
            "",
            "\x01\u00a5",
            "\x01\u00a6",
            "\x01\u00a7",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00ab",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x04"+
            "\x2d\x01\u00ac\x15\x2d",
            "\x01\u00ae",
            "\x01\u00af",
            "\x01\u00b0",
            "\x01\u00b1",
            "\x01\u00b2",
            "\x01\u00b3",
            "\x01\u00b4",
            "\x01\u00b5",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00b7",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00b8",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x08"+
            "\x2d\x01\u00b9\x11\x2d",
            "\x0a\x2d\x07\uffff\x08\x2d\x01\u00ba\x11\x2d\x04\uffff\x01"+
            "\x2d\x01\uffff\x1a\x2d",
            "\x01\u00bb",
            "",
            "\x01\u00bc",
            "",
            "\x01\u00bd",
            "\x01\u00be",
            "\x01\u00bf",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00c1",
            "\x01\u00c2",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00c4",
            "\x01\u00c5",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00ca",
            "\x01\u00cb",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00ce",
            "",
            "\x01\u00cf",
            "\x01\u00d0",
            "\x01\u00d1",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00d2",
            "\x01\u00d3",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00d4",
            "\x01\u00d5",
            "\x01\u00d6",
            "\x01\u00d7",
            "\x01\u00d8",
            "\x01\u00d9",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x01\u00db",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x01\u00dd",
            "\x01\u00de",
            "",
            "",
            "",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00e0",
            "",
            "",
            "\x01\u00e1",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00e3",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00e4",
            "\x01\u00e5",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00e7",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x01\u00ea",
            "",
            "\x01\u00eb",
            "\x01\u00ec",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00ee",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00f0",
            "\x01\u00f1",
            "",
            "\x01\u00f2",
            "",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x01\u00f4",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x01\u00f7",
            "\x01\u00f8",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "",
            "",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            "\x0a\x2d\x07\uffff\x1a\x2d\x04\uffff\x01\x2d\x01\uffff\x1a"+
            "\x2d",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | LP | RP | IntegerLiteral | DecimalLiteral | CharacterLiteral | StringLiteral | BooleanLiteral | NullLiteral | InfinityLiteral | Identifier | WS | SingleLineComment | MultiLineComment );"; }
        }

    }

 
    
}
