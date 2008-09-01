grammar Psimulex;
//options {k=2; backtrack=true; memoize=true;}
options {
    language=CSharp2;
    backtrack=true;
    memoize=true;
    output=AST;
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
    :   'import' StringLiteral ';'	// FileName
    ;

typeDeclaration
    :   structDeclaration
    |   ';'
    ;

structDeclaration
    :   'struct' Identifier
        structBody
    ;

structBody
    :   '{' structBodyDeclaration* '}'
    ;

structBodyDeclaration
    :   memberDeclaration+
    ;

memberDeclaration
    :   type fieldDeclaration
    ;

fieldDeclaration
    :   variableDeclaratorId ('=' literal )? ';'
    ;

variableDeclarator
    :   variableDeclaratorId ('=' variableInitializer)?
    ;

functionDeclaration
    :
    	type Identifier '(' formalParameters ')' block
    ;
    
    
variableDeclaratorId
    :   Identifier ('[' ']'|'[' ',' ']')?
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
    :	primitiveType ('[' ']'|'[' ',' ']')?
    ;

primitiveType
    :   'bool'
    |   'char'
    |   'int'
    |   'decimal'
    |	'string'
    // ...
    ;

builtInType
    :	'tree'
    |	'bintree'
    |	'set'
    |	'list'
    |	'stack'
    |	'queue'
    |	'pqueue'
    // ...
    ;

formalParameters
    :   '(' formalParameterDecls? ')'
    ;
    
formalParameterDecls
    :   type ('&')? formalParameterDeclsRest
    ;
    
formalParameterDeclsRest
    :   variableDeclaratorId (',' formalParameterDecls)?
    ;




/////////////////
// EXPRESSIONS //
/////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

parExpression
    :   LP! expression RP!
    ;
    
expression
    :   conditionalExpression (assignmentOperator expression)?
    ;
    
assignmentOperator
    :   '='
    |   '+='
    |   '-='
    |   '*='
    |   '/='
    |   '%='
    ;

conditionalExpression
    :   conditionalOrExpression ( '?' expression ':' expression )?
    ;

conditionalOrExpression
    :   conditionalAndExpression ( '||' conditionalAndExpression )*
    ;

conditionalAndExpression
    :   equalityExpression ( '&&' equalityExpression )*
    ;

equalityExpression
    :   relationalExpression ( ('==' | '!=') relationalExpression )*
    ;

relationalExpression
    :   additiveExpression ( relationalOp additiveExpression )*
    ;
    
relationalOp
    :   ('<' '=')=> t1='<' t2='=' 
        { $t1.Line == $t2.Line && 
          $t1.CharPositionInLine + 1 == $t2.CharPositionInLine }?
    |   ('>' '=')=> t1='>' t2='=' 
        { $t1.Line == $t2.Line && 
          $t1.CharPositionInLine + 1 == $t2.CharPositionInLine }?
    |   '<' 
    |   '>' 
    ;	// Loptam. Nem bántom. Nem teljesen értem, miért van így, csak sejtem.

additiveExpression
    :   multiplicativeExpression ( ('+'^ | '-'^) multiplicativeExpression )*
    ;

multiplicativeExpression
    :   unaryExpression ( ( '*' | '/' | '%' ) unaryExpression )*
    ;
    
unaryExpression
    :   '+' unaryExpression
    |   '-' unaryExpression
    |   '++' unaryExpression
    |   '--' unaryExpression
    |   unaryExpressionNotPlusMinus
    ;

unaryExpressionNotPlusMinus
    :   '!' unaryExpression
    |   primaryExpression ('++'|'--')?
    ;

primaryExpression
    :   leftValue    
    |   literal
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
    :   memberSelect
    |   memberFunctionCall
    |   indexing
    ;

memberSelect
	:	'.' Identifier
	;

memberFunctionCall
	:	'.' Identifier arguments
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
	:	'[' expression ']'
	;

matrixIndexing
	:	'[' expression ',' expression ']'
	;
	
arguments
    :   '(' expressionList? ')'
    ;

expressionList
    :	expression (',' expression)*
    ;
    
literal 
    :   IntegerLiteral
    |   DecimalLiteral
    |   CharacterLiteral
    |   StringLiteral
    |	BooleanLiteral
    |   NullLiteral
    |	InfinityLiteral
    ;
    
    
    
    
////////////////
// STATEMENTS //
////////////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

block
    :   '{' blockStatement* '}'
    ;
    
blockStatement
    :   localVariableDeclarationStatement
    |   statement
    ;
    
localVariableDeclarationStatement
    :    localVariableDeclaration ';'
    ;

localVariableDeclaration
    :   type variableDeclarator
    ;
    
branch
    :	block|blockStatement
    ;

statement
    :	'if' parExpression branch (options {k=1;}:'else' branch)?
    |   ('for'|'pfor') '(' forControl ')' branch
    |   'foreach' '(' foreachControl ')' branch
    |   'loop' '(' loopControl ')' branch
    |   'while' parExpression branch
    |   'do' branch 'while' parExpression ';'
    |   'pdo' block
    |   'return' expression? ';'
    |   'break' ';'
    |   'continue' ';'
    |   ';'
    |   expression ';'
    ;
    
forControl
//options {k=3;} Emiatt kellene (ID ID : ID) ...
    :    forInit? ';' expression? ';' forUpdate?
    ;

forInit
    :   localVariableDeclaration
    ;

forUpdate
    :   expression
    ;
    
foreachControl
options {k=3;} //Emiatt kellene (ID ID in ID) ...
    :   type Identifier 'in' expression
    ;

    
loopControl
options {k=3;} //Emiatt kellene (ID ID to ID) ...
    :   type Identifier 'to' expression
    ;



///////////
// LEXER //
///////////

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// TOKENS //

/* 
KeyWords, 
Operators, 
Marks 
*/

LP	:	'('	;    
RP	:	')'	;



// Még nem használtam fel sehol, hátha kell valahova, betükészlet korlátozására, egyebekre ...
fragment
Letter
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
    :   '\\' ('t'|'n'|'r'|'\"'|'\''|'\\')
    ;

CharacterLiteral
    :   '\'' ( EscapeSequence | ~('\''|'\\') ) '\''
    ;

StringLiteral
    :	'"' ( EscapeSequence | ~('"'|'\\') )+ '"'
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
        
Identifier 
    :   IDLetter (IDLetter|Digit)*
    ;

WS  :  (' '|'\t'|'\n'|'\r') {$channel=HIDDEN;}
    ;

SingleLineComment
    : '//' ~('\n'|'\r')* '\r'? '\n'? {$channel=HIDDEN;}
    ;

MultiLineComment
    :   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}
    ;
