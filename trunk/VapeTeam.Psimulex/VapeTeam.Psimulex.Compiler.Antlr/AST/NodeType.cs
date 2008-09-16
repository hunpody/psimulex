using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
{
    /// <summary>
    /// Type of PsiAST Node
    /// </summary>
    public enum NodeType
    {
        /*Undef*/
        X,

        /*High Level Node Types*/
        SimpleProgram,
        MultiFunctionalProgram,
        ImportDeclarations,
        TypeDeclarations,
        StructDeclaration,
        GlobalVariableDeclarations,
        MemberDeclaration,
        FunctionDeclarations,
        FunctionDeclaration,
        FormalParameter,
        Block,

        VariableInitialisation,
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
        Assignment,
        LambdaExpression,
        LambdaParameter,
        LambdaStatement,

        MemberSelect,
        MemberFunctionCall,        
        FunctionCall,
        Indexing,
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
