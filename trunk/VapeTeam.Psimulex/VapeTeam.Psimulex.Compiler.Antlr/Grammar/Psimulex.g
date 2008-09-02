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
    :	simpleProgram
    |	multiFunctionalProgram
    ;

globalVariableDeclaration
	:	fieldDeclaration
	;

simpleProgram
	:	blockStatement*
	;

multiFunctionalProgram
	:	importDeclaration*
    	typeDeclaration*
    	globalVariableDeclaration*
		functionDeclaration*
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
    :   IMPORT StringLiteral SC!	// FileName
    ;

typeDeclaration
    :   structDeclaration
    |   SC!
    ;

structDeclaration
    :   STRUCT Identifier
        structBody
    ;

structBody
    :   LB! structBodyDeclaration* RB!
    ;

structBodyDeclaration
    :   memberDeclaration+
    ;

memberDeclaration
    :   type fieldDeclaration
    ;

fieldDeclaration
    :   variableDeclaratorId (A^ literal )? SC!
    ;

variableDeclarator
    :   variableDeclaratorId (A^ variableInitializer)?
    ;

functionDeclaration
    :
    	type Identifier LP! formalParameters RP! block
    ;
    
    
variableDeclaratorId
    :   Identifier (LS RS|LS C RS)?
    ;

variableInitializer
    :   /* arrayInitializer, MatrixInitializer */
    |   expression
    ;
        
/*
arrayInitializer
    :   '{' (variableInitializer (',' variableInitializer)* )? '}'
    ;
*/

type
    :	primitiveType (LS RS|LS C RS)?
    ;

primitiveType
    :   BOOL
    |	CHAR
    |	INT
    |	DECIMAL
    |	STRING
    // ...
    ;

builtInType
    :	TREE
	|	BINTREE
	|	SET
	|	LIST
	|	STACK
	|	QUEUE
	|	PQUEUE
	// ...
	;

formalParameters
    :   LP! formalParameterDecls? RP!
    ;
    
formalParameterDecls
    :   type (REF)? formalParameterDeclsRest
    ;
    
formalParameterDeclsRest
    :   variableDeclaratorId (C! formalParameterDecls)?
    ;




/////////////////
// EXPRESSIONS //
/////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

expression
	:	assignment
	|	conditionalOrExpression
	;
assignment
	:	leftValue assignmentOperator^ expression
	;
    
assignmentOperator
	:	A|AA|AS|AM|ADIV|AMOD
	;

conditionalOrExpression
    :   conditionalAndExpression ( OR^ conditionalAndExpression )*
    ;

conditionalAndExpression
    :   equalityExpression ( AND^ equalityExpression )*
    ;

equalityExpression
    :   relationalExpression ( ( equalityOp^ ) relationalExpression )*
    ;

equalityOp
	:	E|NE
	;

relationalExpression
    :   additiveExpression ( relationalOp^ additiveExpression )*
    ;
    
relationalOp
    :	LT|LTE|GT|GTE
    ;
    
    /*
relationalOp
    :   ('<' '=')=> t1='<' t2='=' 
        { $t1.Line == $t2.Line && 
          $t1.CharPositionInLine + 1 == $t2.CharPositionInLine }?
    |   ('>' '=')=> t1='>' t2='=' 
        { $t1.Line == $t2.Line && 
          $t1.CharPositionInLine + 1 == $t2.CharPositionInLine }?
    |   '<' 
    |   '>' 
    ;	// Loptam. Nem bántom.
    */

additiveExpression
    :   multiplicativeExpression ( additiveOp^ multiplicativeExpression )*
    ;

additiveOp
	:	P|M
	;

multiplicativeExpression
    :   unaryExpression ( multiplicativeOp^ unaryExpression )*
    ;

multiplicativeOp
	:	STAR|DIV|MOD
	;

unaryExpression
    :	unaryPrefixOp^ unaryExpression
    |	primaryExpression (unaryPostfixOp^)?
    ;

unaryPrefixOp
	:	P|M|PP|MM|NOT
	;
	
unaryPostfixOp
	:	PP|MM
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
    :   LP! expression RP!
    ;

leftValue
	:	variable
	|	selecting
	;

variable
	:	Identifier
	;

selecting
	:	(Identifier|parExpression) selector*
	;

selector
options {k=3;}
    :   memberSelect
    |   memberFunctionCall
    |   indexing
    ;

memberSelect
options {k=3;}
	:	DOT! Identifier
	;

memberFunctionCall
options {k=3;}
	:	DOT! Identifier arguments
	;

/*	
indexing
	:	'[' indexList ']'
	;

indexList
    :	expression (',' expression)?
    ;
*/
	
/*
indexing
	:	'[' firstIndex secondIndex? ']'
	;

firstIndex
	:	expression
	;

secondIndex
	:	',' expression
	;
*/

indexing
	:	arrayIndexing
	|	matrixIndexing
	;
	
arrayIndexing
	:	LS! expression RS!
	;

matrixIndexing
	:	LS! expression C! expression RS!
	;
	
arguments
    :   LP! expressionList? RP!
    ;

expressionList
    :	expression (C! expression)*
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
    
    
    
    
////////////////
// STATEMENTS //
////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

block
    :   LB! blockStatement* RB!
    ;
    
blockStatement
    :   localVariableDeclarationStatement
    |   statement
    ;
    
localVariableDeclarationStatement
    :    localVariableDeclaration SC!
    ;

localVariableDeclaration
    :   type variableDeclarator
    ;
    
branch
    :	block|blockStatement
    ;

statement
    :	IF parExpression branch (options {k=1;}:ELSE branch)?
    |   (FOR|PFOR) LP! forControl RP! branch
    |   (FOREACH|PFOREACH) LP! foreachControl RP! branch
    |   LOOP LP! loopControl RP! branch
    |   WHILE parExpression branch
    |   DO branch WHILE parExpression SC!
    |   PDO block
    |   RETURN expression? SC!
    |   BREAK SC!
    |   CONTINUE SC!
    |   SC!
    |   expression SC!
    ;
    
forControl
//options {k=3;} Emiatt kellene (ID ID : ID) ...
    :    forInit? SC! expression? SC! forUpdate?
    ;

forInit
    :   localVariableDeclaration
    ;

forUpdate
    :   expression
    ;
    
foreachControl
options {k=3;} //Emiatt kellene (ID ID in ID) ...
    :   type Identifier IN expression
    ;

    
loopControl
options {k=3;} //Emiatt kellene (ID ID to ID) ...
    :   type Identifier TO expression
    ;



///////////
// LEXER //
///////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// TOKENS //

/*Parensises*/
LP		:	'('		;    
RP		:	')'		;
LS		:	'['		;
RS		:	']'		;
LB		:	'{'		;
RB		:	'}'		;

/*Logical Comparisons*/
AND		:	'&&'	;
OR		:	'||'	;
NOT		:	'!'		;
E		:	'=='	;
NE		:	'!='	;
LT		:	'<'		;
LTE		:	'<='	;
GT		:	'>'		;
GTE		:	'>='	;

/*Assigns*/
A		:	'='		;
AA		:	'+='	;
AS		:	'-='	;
AM		:	'*='	;
ADIV	:	'/='	;
AMOD	:	'%='	;

/*Operators*/
P		:	'+'		;
M		:	'-'		;
STAR	:	'*'		;
DIV		:	'/'		;
MOD		:	'%'		;
PP		:	'++'	;
MM		:	'--'	;

/*Separators*/
REF 	:	'&'		;
SC		:	';'		;
C		:	','		;
DOT		:	'.'		;
AP		:	'\''	;
QM		:	'"'		;

/*Other*/
SLC		:	'//'	;
LMLC	:	'/*'	;
RMLC	:	'*/'	;
ESC		:	'\\'	;

/*Primitive Types*/
BOOL    :   'bool'|'Bool'|'BOOL'|'boolean'|'Boolean'|'BOOLEAN'				;
CHAR	:	'char'|'Char'|'CHAR'|'character'|'Character'|'CHARACTER'		;
INT		:	'int'|'Int'|'INT'|'integer'|'Integer'|'INTEGER'					;
DECIMAL	:	'decimal'|'Decimal'|'DECIMAL'	/*|'float'|'Float'|'FLOAT'*/	;
STRING	:	'string'|'String'|'STRING'										;
// ...

/*BuiltIn Types*/
TREE    :	'tree'|'Tree'|'TREE'			;
BINTREE	:	'bintree'|'BinTree'|'BINTREE'	;
SET		:	'set'|'Set'|'SET'				;
LIST	:	'list'|'List'|'LIST'			;
STACK	:	'stack'|'Stack'|'STACK'			;
QUEUE	:	'queue'|'Queue'|'QUEUE'			;
PQUEUE	:	'pqueue'|'PQueue'|'PQUEUE'		;
// ...

/*Key Words*/
STRUCT	:	'struct'|'Struct'|'STRUCT'						;
IMPORT	:	'import'|'Import'|'IMPORT'						;

BREAK	:	'break'|'Break'|'BREAK'							;
CONTINUE:	'continue'|'Continue'|'CONTINUE'				;
RETURN	:	'ret'|'Ret'|'RET'|'return'|'Return'|'RETURN'	;

IF		:	'if'|'If'|'IF'									;
ELSE	:	'else'|'Else'|'ELSE'							;
ELSEIF	:	'elseif'|'ElseIf'|'ELSEIF'						;
FOR		:	'for'|'For'|'FOR'								;
FOREACH	:	'foreach'|'ForEach'|'FOREACH'					;
PFOR	:	'pfor'|'PFor'|'PFOR'							;
PFOREACH:	'pforeach'|'PForEach'|'PFOREACH'				;	// MIért is ne ?
DO		:	'do'|'Do'|'DO'									;
PDO		:	'pdo'|'PDo'|'PDO'								;
WHILE	:	'while'|'While'|'WHILE'							;
LOOP	:	'loop'|'Loop'|'LOOP'							;
TO		:	'to'|'To'|'TO'|'until'|'Until'|'UNTIL'			;
IN		:	'in'|'In'|'IN'									;


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
    :   ESC ('t'|'n'|'r'|QM|AP|ESC)
    ;

CharacterLiteral
    :   AP ( EscapeSequence | ~(AP|ESC) )? AP
    ;

StringLiteral
    :	QM ( EscapeSequence | ~(QM|ESC) )* QM
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
    :	SLC ~('\n'|'\r')* '\r'? '\n'? {$channel=HIDDEN;}
    ;

MultiLineComment
    :   LMLC ( options {greedy=false;} : . )* RMLC {$channel=HIDDEN;}
    ;
