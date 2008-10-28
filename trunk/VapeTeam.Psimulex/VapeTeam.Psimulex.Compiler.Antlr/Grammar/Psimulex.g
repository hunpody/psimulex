grammar Psimulex;
//options {k=2; backtrack=true; memoize=true;}
options {
    language=CSharp2;
    backtrack=true;
    memoize=true;
    output=AST;
    ASTLabelType=CommonTree;
}

tokens {
	COMPILATION_UNIT;
	SIMPLE_PROGRAM;
	MULTY_FUNCTIONAL_PROGRAM;
	
	IMPORT_DECLARATIONS;
	TYPE_DECLARATIONS;
	STRUCTDEC;
	GLOBAL_VARIABLE_DECLARATIONS;
	MEMBERDEC;
	FUNCTION_DECLARATIONS;
	FUNCDEC;
	FORMAL_PARAMETER_LIST;
	FORMAL_PARAMETER;
	
	BLOCK;
	STATEMENT;
	
	IFSTATEMENT;
	IFBRANCH;
	ELSEIFBRANCHES;
	CONDITIONALBRANCH;
	ELSEBRANCH;
	
	PFORSTATEMENT;
	FORSTATEMENT;
	FORCONDITION;
	FORINIT;
	FORUPDATE;
	
	DOSTATEMENT;
	
	WHILESTATEMENT;
	
	PFOREACHSTATEMENT;
	FOREACHSTATEMENT;
	FOREACHINIT;
	FOREACHCOLLECTION;

	LOOPSTATEMENT;
	LOOPINIT;
	LOOPLIMIT;
	
	CORE;
	CONDITION;
	
	PDOSTATEMENT;
	ASYNCSTATEMENT;
	LOCKSTATEMENT;
	
	RETURN_STATEMENT;
	EXPRESSION_STATEMENT;
	
	VARIABLE_DECLARATION_STATEMENT;
	VARINIT;
	VARDECLARE;	

	TYPE;
	DATATYPE;
	FUNCTIONPOINTERTYPE;
	
	EXPRESSION;
	CAST;
	PREFIXOP;
	POSTFIXOP;
	/*LAMBDA_EXPRESSION;*/
	
	SELECTOR;
	MEMBER_FUNCTION_CALL;
	FUNCTION_CALL;
	ARGUMENTS;
	MEMBER_SELECT;
	INDEXING;

	/*
	LAMBDAPARAM;
	LAMBDA_STATEMENT;
	*/
	
	// Others
	DIMS;
	CONSTANT_DIMS;
	DIMMARKER;
}

compilationUnit
    :	( simpleProgram | multiFunctionalProgram )? EOF!
    ;

simpleProgram
	:	statement* -> ^( COMPILATION_UNIT ^( SIMPLE_PROGRAM statement* ) )
	;

multiFunctionalProgram
	:	importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations
		-> ^( COMPILATION_UNIT ^( MULTY_FUNCTIONAL_PROGRAM importDeclarations typeDeclarations globalVariableDeclarations functionDeclarations ) )
	;

globalVariableDeclarations
	:	memberDeclaration* -> ^( GLOBAL_VARIABLE_DECLARATIONS memberDeclaration* )
	;


//////////////////
// DECLARATIONS //
//////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
usingDeclaration
    :   'using' StringLiteral ';'	// Ide még kell a fv azonosítására valmi szintax. Fv-nél kellenek a paraméterek is ...
    ;
*/

importDeclarations
    :   ( Import StringLiteral ';' )* -> ^( IMPORT_DECLARATIONS StringLiteral* )
    ;

typeDeclarations
    :   structDeclaration* -> ^( TYPE_DECLARATIONS structDeclaration* )
    ;

structDeclaration
    :   Struct Identifier structBody -> ^( STRUCTDEC Identifier structBody)
    ;

structBody
    :   '{'! memberDeclaration+ '}'! 
    ;

memberDeclaration
    :   memberTypedIdentifierNonRef ( Assign literal )? ';' -> ^( MEMBERDEC memberTypedIdentifierNonRef literal? )
    ;

localVariableDeclaration
options {k=3;}
    :   typedIdentifierNonRef -> ^(VARDECLARE typedIdentifierNonRef)
    |   typedIdentifierNonRef Assign variableInitializer -> ^(VARINIT typedIdentifierNonRef variableInitializer)
	|	typedIdentifierRef Assign variableInitializer -> ^(VARINIT typedIdentifierRef variableInitializer)
    ;
    
variableInitializer
    :   expression	/* arrayInitializer, MatrixInitializer */
    ;
    
scalarOrArrayType
	:	type staticArrayType? -> ^( TYPE type staticArrayType? )
	;

arrayType
	:	staticArrayType | dynamicArrayType
	;
	
staticArrayType
	:	'[' expression (',' expression)* ']' -> ^( DIMS expression ( expression )* )
	;

dynamicArrayType
	:	'[' ( ',' )* ']' -> ^( DIMMARKER '[' ( ',' )* ']' )
	;

memberScalarOrArrayType
	:	type memberArrayType? -> ^( TYPE type memberArrayType? )
	;

memberArrayType
	:	memberStaticArrayType | dynamicArrayType
	;

memberStaticArrayType
	:	'[' IntegerLiteral (',' IntegerLiteral)* ']' -> ^( CONSTANT_DIMS IntegerLiteral ( IntegerLiteral )* )
	;
	
memberTypedIdentifierNonRef
	:	memberScalarOrArrayType Identifier
	;

typedIdentifierNonRef
	:	scalarOrArrayType Identifier
	;

typedIdentifierRef
	:	scalarOrArrayType Reference? Identifier
	;	
	
typedIdentifier
	:	typedIdentifierNonRef | typedIdentifierRef
	;
   
functionDeclarations
    :	functionDeclaration* -> ^( FUNCTION_DECLARATIONS functionDeclaration* )
    ;
    
functionDeclaration
    :	typedIdentifier formalParameterList  block -> ^( FUNCDEC typedIdentifier formalParameterList? block )
    ;

formalParameterList
    :   '(' ( formalParameter (',' formalParameter)* )? ')' -> ^( FORMAL_PARAMETER_LIST ( formalParameter formalParameter* )? )
    ;

formalParameter
    :   typedIdentifier -> ^( FORMAL_PARAMETER typedIdentifier )
    ;

    
///////////
// Types //
///////////

type
    :	dataType /*| functionPointerType*/
    ;

/*
functionPointerType
	:	Func '<' dataType dynamicArrayType? '>' -> ^( FUNCTIONPOINTERTYPE dataType dynamicArrayType? )
	;
*/

dataType
	:	dataTypeName -> ^( DATATYPE dataTypeName )
	;

dataTypeName
	:	primitiveType | builtInType | userDefinedTypes
	;
	
userDefinedTypes
	:	Identifier
	;

primitiveType
    :   Bool
    |	Char
    |	Int
    |	Decimal
    |	String
	|   Void
    // ...
    ;

builtInType
    :	Tree
	|	BinTree
	|	Set
	|	List
	|	Stack
	|	Queue
	|	PQueue
	|	Graph
	|	Node
	|	Edge
	|	Thread
	|	Iterator
	// ...
	;



/////////////////
// EXPRESSIONS //
/////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
expression
	:	assignment | exp //| lambdaExpression
	;

exp
	:	conditionalOrExpression -> ^( EXPRESSION conditionalOrExpression )
	;
	
assignment
	:	leftValue assignmentOperator expression -> ^( ASSIGNMENT ^( assignmentOperator leftValue expression ) )
	;
	*/
	
expression
	:	exp -> ^( EXPRESSION exp )
	;
	
exp
	:	assignment | conditionalOrExpression //| lambdaExpression
	;
	
assignment
	:	leftValue assignmentOperator^ exp
	;
    
assignmentOperator
	:	Assign|AssignAndAdd|AssignAndSubstract|AssignAndMultiply|AssignAndDivide|AssignAndModulo
	;

conditionalOrExpression
    :   conditionalAndExpression ( LogicalOr^ conditionalAndExpression )*
    ;

conditionalAndExpression
    :   equalityExpression ( LogicalAnd^ equalityExpression )*
    ;

equalityExpression
    :   relationalExpression ( equalityOp^ relationalExpression )*
    ;

equalityOp
	:	RelEqual|RelNotEqual
	;

relationalExpression
    :   additiveExpression ( relationalOp^ additiveExpression )*
    ;
    
relationalOp
    :	RelLessThan|RelLessThanOrEqual|RelGreaterThan|RelGreaterThanOrEqual
    ;
    
additiveExpression
    :   multiplicativeExpression ( additiveOp^ multiplicativeExpression )*
    ;

additiveOp
	:	Plus|Minus
	;

multiplicativeExpression
    :   unaryExpression ( multiplicativeOp^ unaryExpression )*
    ;

multiplicativeOp
	:	Star|Divide|Modulo
	;

unaryExpression
    :	unaryPrefixExpression
    |	unaryPostfixExpression
	|	castExpression
    ;

unaryPrefixExpression
	:	unaryPrefixOp unaryExpression	-> ^( PREFIXOP ^( unaryPrefixOp unaryExpression) )
	;
    
unaryPostfixExpression
	:	leftValueExpression (unaryPostfixOp^)?
	|	primaryExpression
	;

leftValueExpression
	:	leftValue
	|	unaryPrefixAssignerOp leftValueExpression -> ^( PREFIXOP ^( unaryPrefixAssignerOp leftValueExpression) )
	;
    
castExpression 
	:	'(' dataType ')' unaryExpression -> ^( CAST dataType unaryExpression )
	;

unaryPrefixOp
	:	Minus|LogicalNot
	;
	
unaryPrefixAssignerOp
	:	PlusPlus|MinusMinus
	;
	
unaryPostfixOp
	:	PlusPlus|MinusMinus
	;

primaryExpression
    :   parExpression
    |	leftValue
    |   literal
    |	functionCall
    ;

parExpression
    :   '('! expression ')'!
    ;

leftValue
	:	variable
	|	selecting
	;

variable
	:	Reference? Identifier -> ^( Identifier Reference? )
	;

selecting
	:	selector -> ^( SELECTOR selector )
	;

selector
    :   ( Identifier | parExpression | functionCall )
    	( memberSelect | memberFunctionCall | indexing )+
    ;

memberSelect
	:	'.' Identifier -> ^( MEMBER_SELECT Identifier )
	;

memberFunctionCall
	:	'.' Identifier arguments -> ^( MEMBER_FUNCTION_CALL Identifier arguments )
	;

functionCall
	:	Identifier arguments -> ^( FUNCTION_CALL Identifier arguments )
	;


indexing
	:	'[' expression ( ',' expression )* ']' -> ^( INDEXING expression ( expression )* )
	;
	
arguments
    :   '(' ( expression (',' expression)* )? ')' -> ^( ARGUMENTS ( expression expression* )? )
    ;
    
literal
    :	IntegerLiteral
    |   DecimalLiteral
    |   CharacterLiteral
    |   StringLiteral
    |	BooleanLiteral
    |   NullLiteral
    |   InfinityLiteral
    ;
  
////////////////////
// LAMBDA SECTION //
////////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
lambdaExpression
	:	parameters '=>' lambdaStatement -> ^( LAMBDA_EXPRESSION parameters ^( LAMBDA_STATEMENT lambdaStatement ) )
	;

parameters
	:	( id | '('! lambdaParameterList ')'! )
	;

id
	:	Identifier -> ^( LAMBDAPARAM Identifier )
	;
	
lambdaParameterList
	:	lambdaParameter ( ','! lambdaParameter )*
	;
 
lambdaParameter
	:	dataType? Identifier -> ^( LAMBDAPARAM dataType? Identifier )
	;
	
lambdaStatement
	:	expression | block
	;
*/


////////////////
// STATEMENTS //
////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

block
    :   '{' statement* '}'	-> ^( BLOCK ^( STATEMENT statement )* )
    ;    
    
branch
    :	block | statement
    ;

statement
    :	ifStatement -> ^( IFSTATEMENT ifStatement )
    |	( forStatement | pForStatement )
    |   ( forEachStatement | pForEachStatement )
    |   loopStatement
    |   whileStatement
    |   doStatement   
    |   PDo block -> ^( PDOSTATEMENT block )									// PDO { STATEMENT(n) } n db Statement n db Thread
    |   Async block -> ^( ASYNCSTATEMENT block )								// A blockot Assinkron futtatja
    |   Lock '(' Identifier ')' block -> ^( LOCKSTATEMENT Identifier block )	// Egy változót zárol kizárólagos hozzáférésre
    |   Return expression? ';' -> ^( RETURN_STATEMENT Return expression? )
    |   Break ';'!
//    |   Continue ';'!
    |   ';'!
    |   expression ';' -> ^( EXPRESSION_STATEMENT expression )
    |	localVariableDeclaration ';' -> ^( VARIABLE_DECLARATION_STATEMENT localVariableDeclaration )
    ;
    
ifStatement			:	ifBranch ( ( elseIfBranches elseBranch ) | elseBranch? );
ifBranch			:	If condition core -> ^( IFBRANCH ^( CONDITIONALBRANCH condition core ) );
elseIfBranches		:	( ElseIf condition core )* -> ^( ELSEIFBRANCHES ( ^( CONDITIONALBRANCH condition core ) )* );
elseBranch			:	Else core -> ^( ELSEBRANCH core);

forStatement		:	For '(' forControl ')' core -> ^( FORSTATEMENT forControl core );
pForStatement		:	PFor '(' forControl ')' core -> ^( PFORSTATEMENT forControl core );
forControl			:	forInit? ';' forCondition? ';' forUpdate? -> ^( FORINIT forInit? ) ^( FORCONDITION forCondition? ) ^( FORUPDATE forUpdate? );
forInit				:   localVariableDeclaration;
forCondition		:   expression;
forUpdate			:   expression;

whileStatement		:	While condition core -> ^( WHILESTATEMENT condition core );

doStatement			:	Do core While condition ';' -> ^( DOSTATEMENT core condition );

pForEachStatement	:	PForEach forEachTrailer -> ^( PFOREACHSTATEMENT forEachTrailer );
forEachStatement	:	ForEach forEachTrailer -> ^( FOREACHSTATEMENT forEachTrailer );
forEachTrailer		:	'('! forEachControl ')'! core;  
forEachControl			options {k=3;} // Emiatt kellene (ID ID in ID)
    				:   type Identifier In expression -> ^( FOREACHINIT type  Identifier ) ^( FOREACHCOLLECTION expression );

loopStatement		:	Loop '(' loopControl ')' core -> ^( LOOPSTATEMENT loopControl core ); 
loopControl				options {k=3;} // Emiatt kellene (ID ID to ID)
				    :   localVariableDeclaration To expression -> ^( LOOPINIT localVariableDeclaration ) ^( LOOPLIMIT expression );

core				:	branch -> ^( CORE branch );
condition			:	parExpression -> ^( CONDITION parExpression );



///////////
// LEXER //
///////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// TOKENS //

/*Logical Comparisons*/
LogicalAnd				:	'&&'	;
LogicalOr				:	'||'	;
LogicalNot				:	'!'		;
RelEqual				:	'=='	;
RelNotEqual				:	'!='	;
RelLessThan				:	'<'		;
RelLessThanOrEqual		:	'<='	;
RelGreaterThan			:	'>'		;
RelGreaterThanOrEqual	:	'>='	;

/*Assigns*/
Assign				:	'='		;
AssignAndAdd		:	'+='	;
AssignAndSubstract	:	'-='	;
AssignAndMultiply	:	'*='	;
AssignAndDivide		:	'/='	;
AssignAndModulo		:	'%='	;

/*Operators*/
Plus		:	'+'		;
Minus		:	'-'		;
Star		:	'*'		;
Divide		:	'/'		;
Modulo		:	'%'		;
PlusPlus	:	'++'	;
MinusMinus	:	'--'	;

/*Reference*/
Reference 	:	'&'|'ref'|'Ref'|'REF'		;

/*Primitive Types*/
Bool    :   'bool'|'Bool'|'BOOL'|'boolean'|'Boolean'|'BOOLEAN'				;
Char	:	'char'|'Char'|'CHAR'|'character'|'Character'|'CHARACTER'		;
Int		:	'int'|'Int'|'INT'|'integer'|'Integer'|'INTEGER'					;
Decimal	:	'decimal'|'Decimal'|'DECIMAL'	/*|'float'|'Float'|'FLOAT'*/	;
String	:	'string'|'String'|'STRING'										;
Void	:	'void'|'Void'|'VOID'											;
//Var		:	'var'|'Var'|'VAR'												;

/*BuiltIn Types*/
Tree    :	'tree'|'Tree'|'TREE'			;
BinTree	:	'bintree'|'BinTree'|'BINTREE'	;
Set		:	'set'|'Set'|'SET'				;
List	:	'list'|'List'|'LIST'			;
Stack	:	'stack'|'Stack'|'STACK'			;
Queue	:	'queue'|'Queue'|'QUEUE'			;
PQueue	:	'pqueue'|'PQueue'|'PQUEUE'		;
Graph	:	'graph'|'Graph'|'GRAPH'			;
Edge	:	'edge'|'Edge'|'EDGE'			;
Node	:	'node'|'Node'|'NODE'			;

/*Other*/
Thread	:	'thread'|'Thread'|'THREAD'		;
//Timer	:	'timer'|'Timer'|'TIMER'			;
Iterator:	'iterator'|'Iterator'|'ITERATOR';

// ...

/*Key Words*/
Struct	:	'struct'|'Struct'|'STRUCT'						;
Import	:	'import'|'Import'|'IMPORT'						;

Break	:	'break'|'Break'|'BREAK'							;
Continue:	'continue'|'Continue'|'CONTINUE'				;
Return	:	'ret'|'Ret'|'RET'|'return'|'Return'|'RETURN'	;

If		:	'if'|'If'|'IF'									;
Else	:	'else'|'Else'|'ELSE'							;
ElseIf	:	'elseif'|'ElseIf'|'ELSEIF'						;
For		:	'for'|'For'|'FOR'								;
ForEach	:	'foreach'|'ForEach'|'FOREACH'					;
PFor	:	'pfor'|'PFor'|'PFOR'							;
PForEach:	'pforeach'|'PForEach'|'PFOREACH'				;
Do		:	'do'|'Do'|'DO'									;
PDo		:	'pdo'|'PDo'|'PDO'								;
While	:	'while'|'While'|'WHILE'							;
Loop	:	'loop'|'Loop'|'LOOP'							;
To		:	'to'|'To'|'TO'|'until'|'Until'|'UNTIL'			;
In		:	'in'|'In'|'IN'									;
Async	:	'async'|'Async'|'ASYNC'							;
Atomic	:	'atomic'|'Atomic'|'ATOMIC'						;
Lock	:	'lock'|'Lock'|'LOCK'							;

/*Func	:	'func'|'Func'|'FUNC'							;*/


// Literals
fragment
Letter		// Még nem használtam fel sehol, hátha kell valahova, betükészlet korlátozására, egyebekre ...
    :  '\u0024' |
       '\u0041'..'\u005a' |
       '\u005f' |
       '\u0061'..'\u007a' |
       '\u00c0'..'\u00d6' |
       '\u00d8'..'\u00f6' |
       '\u00f8'..'\u00ff' |
       '\u0100'..'\u1fff' |
       '\u3040'..'\u318f' |
       '\u3300'..'\u337f' |
       '\u3400'..'\u3d2d' |
       '\u4e00'..'\u9fff' |
       '\uf900'..'\ufaff'
    ;

fragment
IDLetter
    :	'a'..'z'
    |	'A'..'Z'
    |	'_'
    ;

fragment
Digit
    :	'0'..'9'
    ;

fragment
NotNullDigit
    :	'1'..'9'
    ;

IntegerLiteral : ('0' | NotNullDigit Digit*);

fragment
DecimalTypeSuffix : ('m'|'M'|'d'|'D') ;

DecimalLiteral
    :   Digit+ '.' Digit*
    |   '.' Digit+
    |   Digit+ DecimalTypeSuffix
    ;
    
fragment
EscapeSequence
    :   '\\' ('t'|'n'|'r'|'"'|'\''|'\\')
    ;

CharacterLiteral
    :   '\'' ( EscapeSequence | ~('\''|'\\') )? '\''
    ;

StringLiteral
    :	'"' ( EscapeSequence | ~('"'|'\\') )* '"'
    ;

BooleanLiteral
    :	'true'|'false'
    |	'True'|'False'
    |	'TRUE'|'FALSE'
    ;

NullLiteral
    :	'null'|'nil'
    |	'Null'|'Nil'
    |	'NULL'|'NIL'
    ;
    
InfinityLiteral
    :	'inf'|'infinity'
    |	'Inf'|'Infinity'
    |	'INF'|'INFINITY'
	;
        
Identifier		// Kivételek definiálása ?
    :   IDLetter (IDLetter|Digit)*
    ;
    
// White Space
WS  :	(' '|'\t'|'\n'|'\r') {$channel=HIDDEN;}
    ;

// Comments
SingleLineComment
    :	'//' ~('\n'|'\r')* '\r'? '\n'? {$channel=HIDDEN;}
    ;

MultiLineComment
    :   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}
    ;
