﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /// <summary>
    /// Type of PsiAST Node
    /// </summary>
    public enum NodeType
    {
        /*Undefined*/
        X,

        /*High Level Node Types*/
        CompilationUnit,
        SimpleProgram,
        MultiFunctionalProgram,
        ImportDeclarations,
        TypeDeclarations,
        StructDeclaration,
        GlobalVariableDeclarations,
        MemberDeclaration,
        FunctionDeclarations,
        FunctionDeclaration,
        FormalParameterList,
        FormalParameter,

        /*ProgramStructures*/
        Block,
        Statement,

	    IfStatement,
	    IfBranch,
	    ElseIfBranches,
        ConditionalBranch,
	    ElseBranch,

        DoStatement,
        WhileStatement,

	    PForStatement,
	    ForStatement,
        ForCondition,
	    ForInitialization,
	    ForUpdate,
    	
	    PForEachStatement,
	    ForEachStatement,
	    ForEachInitialization,
        ForEachCollectionExpression,

	    LoopStatement,
	    LoopInitialization,
        LoopLimit,

        Condition,
        Core,        

	    PDoStatement,
	    AsynStatement,
	    LockStatement,
	
        ReturnStatement,
	    Return,
        Break,
//        Continue,
        ExpressionStatement,

        VariableDeclarationStatement,
        VariableInitialization,
        VariableDeclaration,        	

        /*Operators*/
        AssignmentOp,
        LogicalOrOp,
        LogicalAndOp,
        EqualityOp,
        RelationOp,
        AdditiveOp,
        MultiplicativeOp,
        UnaryOp,

        /*Expressions*/
        Expression,
        Cast,
        PrefixUnaryOperation,
        /*
        LambdaExpression,
        LambdaParameter,
        LambdaStatement,
        */

        Selector,
        MemberSelect,
        MemberFunctionCall,        
        FunctionCall,
        Arguments,
        Indexing,        
        ArrayInitializer,
        CollectionInitializer,

        /*ID*/
        Identifier,        

        /*Literals*/
        CharLiteral,
        StringLiteral,
        IntLiteral,
        DecimalLiteral,
        BoolLiteral,
        NullLiteral,
        InfinityLiteral,

        /*Types*/
        DimensionMarker,
        DataTypeName,
        DataType,
        FunctionPointerType,
        Type,
        Reference,
    }
}
