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
	    ForEachControl,

	    LoopStatement,
	    LoopControl,

        Condition,
        Core,        

	    PDoStatement,
	    AsynStatement,
	    LockStatement,
	
	    Return,
        Break,
//        Continue,

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
        ConstantDimensions,
        Dimensions,
        DimensionMarker,        

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
        DataTypeName,
        DataType,
        FunctionPointerType,
        Type,
        Reference,
    }
}
