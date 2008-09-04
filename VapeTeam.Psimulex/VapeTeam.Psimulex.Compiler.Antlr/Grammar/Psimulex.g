grammar Psimulex;
//options {k=2; backtrack=true; memoize=true;}
options {
    language=CSharp2;
    backtrack=true;
    memoize=true;
    output=AST;
    ASTLabelType=CommonTree;
}

compilationUnit
    :	( simpleProgram | multiFunctionalProgram ) EOF
    ;

simpleProgram
	:	statement*
	;

multiFunctionalProgram
	:	importDeclaration*
    	typeDeclaration*
    	globalVariableDeclaration*
		functionDeclaration*
	;

globalVariableDeclaration
	:	memberDeclaration
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

importDeclaration
    :   Import StringLiteral ';'!
    ;

typeDeclaration
    :   structDeclaration
    ;

structDeclaration
    :   Struct Identifier structBody
    ;

structBody
    :   '{'! memberDeclaration+ '}'! 
    ;

memberDeclaration
    :   typedIdentifierNonRef (Assign^ literal )? ';'!
    ;

localVariableDeclaration
    :   typedIdentifierNonRef (Assign^ variableInitializer)?
	|	typedIdentifierRef Assign^ variableInitializer
    ;
    
variableInitializer
    :   expression	/* arrayInitializer, MatrixInitializer */
    ;
    
scalarOrArrayType
	:	type ('[' expression (',' expression)* ']')?
	;
	
typedIdentifierNonRef
	:	 scalarOrArrayType Identifier 
	;

typedIdentifierRef
	:	scalarOrArrayType Reference Identifier
	;	
	
typedIdentifier
	:	typedIdentifierNonRef | typedIdentifierRef
	;
   
functionDeclaration
    :	typedIdentifier formalParameters block
    ;

formalParameters
    :   '('! typedIdentifier (','! typedIdentifier)* ')'!
    ;
    
///////////
// Types //
///////////

type
    :	dataType
    |	functionPointerType
    ;

dataType
	:	primitiveType | builtInType
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
	// ...
	;



/////////////////
// EXPRESSIONS //
/////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

expression
	:	assignment
	|	conditionalOrExpression
	|	lambdaExpression
	;
	
assignment
	:	leftValue assignmentOperator^ expression
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
    :   relationalExpression ( ( equalityOp^ ) relationalExpression )*
    ;

equalityOp
	:	RelEqual|RelNotEqual
	;

relationalExpression
    :   additiveExpression ( relationalOp^ additiveExpression )*
    ;
    
relationalOp
    :	RelLessThan| RelLessThanOrEqual|RelGreaterThan|RelGreaterThanOrEqual
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
    :	unaryPrefixOp^ unaryExpression
    |	primaryExpression (unaryPostfixOp^)?
	|	castExpression
    ;
    
castExpression 
	:	'(' dataType ')' unaryExpression
	;

unaryPrefixOp
	:	Plus|Minus|PlusPlus|MinusMinus|LogicalNot
	;
	
unaryPostfixOp
	:	PlusPlus|MinusMinus
	;

unaryExpressionPostPlusPlusMinusMinus
    :   primaryExpression (unaryPostfixOp^)*
    ;

primaryExpression
    :   parExpression
    |	leftValue
    |   literal
    ;

parExpression
    :   '('! expression ')'!
    ;

leftValue
	:	variable
	|	selecting
	;

variable
	:	Identifier
	;

selecting
	:	(Identifier|parExpression) selector+
	;

selector
    :   memberSelect
    |   memberFunctionCall
    |   indexing
    ;

memberSelect
	:	'.'! Identifier
	;

memberFunctionCall
	:	'.'! Identifier arguments
	;

indexing
	:	arrayIndexing
	|	matrixIndexing
	;
	
arrayIndexing
	:	l='['! expression r=']'!
	//{System.Windows.Forms.MessageBox.Show($l.text + $expression.tree.ToString() + $r.text);}
	;

matrixIndexing
	:	'['! expression ','! expression ']'!
	;
	
arguments
    :   '('! expressionList? ')'!
    ;

expressionList
    :	expression (','! expression)*
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
     
lambdaExpression
	:	( Identifier | '(' lambdaParameterList ')' ) '=>' lambdaStatement
	;
	
lambdaParameterList
	:	lambdaParameter ( ',' lambdaParameter )*
	;
 
lambdaParameter
	:	dataType? Identifier
	;
	
lambdaStatement
	:	expression | block
	;
	
functionPointerType
	:	Func '<' dataType '>' 
	;




////////////////
// STATEMENTS //
////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

block
    :   '{'! statement* '}'!
    ;    
    
branch
    :	block | statement
    ;

statement	// ElseIf kell mgé bele
    :	If parExpression branch (options {k=1;}:Else branch)?
    |   (For|PFor) '('! forControl ')'! branch
    |   (ForEach|PForEach) '('! foreachControl ')'! branch
    |   Loop '('! loopControl ')'! branch
    |   While parExpression branch
    |   Do branch While parExpression ';'!
    |   PDo block
    |   Return expression? ';'!
    |   Break ';'!
    |   Continue ';'!
    |   ';'!
    |   expression ';'!
    |	localVariableDeclaration ';'!
    ;
    
forControl
    :    forInit? ';'! expression? ';'! forUpdate?
    ;

forInit
    :   localVariableDeclaration
    ;

forUpdate
    :   expression
    ;
    
foreachControl
options {k=3;} //Emiatt kellene (ID ID in ID) ...
    :   type Identifier In expression
    ;

    
loopControl
options {k=3;} //Emiatt kellene (ID ID to ID) ...
    :   type Identifier To expression
    ;



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
Reference 		:	'&'		;

/*Primitive Types*/
Bool    :   'bool'|'Bool'|'BOOL'|'boolean'|'Boolean'|'BOOLEAN'				;
Char	:	'char'|'Char'|'CHAR'|'character'|'Character'|'CHARACTER'		;
Int		:	'int'|'Int'|'INT'|'integer'|'Integer'|'INTEGER'					;
Decimal	:	'decimal'|'Decimal'|'DECIMAL'	/*|'float'|'Float'|'FLOAT'*/	;
String	:	'string'|'String'|'STRING'										;
// ...

/*BuiltIn Types*/
Tree    :	'tree'|'Tree'|'TREE'			;
BinTree	:	'bintree'|'BinTree'|'BINTREE'	;
Set		:	'set'|'Set'|'SET'				;
List	:	'list'|'List'|'LIST'			;
Stack	:	'stack'|'Stack'|'STACK'			;
Queue	:	'queue'|'Queue'|'QUEUE'			;
PQueue	:	'pqueue'|'PQueue'|'PQUEUE'		;
Void	:	'void'|'Void'|'VOID'			;
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
PForEach:	'pforeach'|'PForEach'|'PFOREACH'				;	// MIért is ne ?
Do		:	'do'|'Do'|'DO'									;
PDo		:	'pdo'|'PDo'|'PDO'								;
While	:	'while'|'While'|'WHILE'							;
Loop	:	'loop'|'Loop'|'LOOP'							;
To		:	'to'|'To'|'TO'|'until'|'Until'|'UNTIL'			;
In		:	'in'|'In'|'IN'									;

Func	:	'func'|'Func'|'FUNC'							;


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
