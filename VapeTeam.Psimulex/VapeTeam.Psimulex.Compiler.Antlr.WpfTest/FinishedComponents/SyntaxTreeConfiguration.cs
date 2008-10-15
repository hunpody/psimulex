using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    using NodeBoolPair = Pair<NodeType, bool>;
    using ConfigSerializer = SerializationUtil<List<NodeTypeGroup>>;
    using NodeTypeGoupList = List<NodeTypeGroup>;

    [Serializable]
    public class NodeTypeGroup
    {
        public string Name { get; set; }
        public List<NodeBoolPair> NodeTypeList { get; set; }
    }

    /// <summary>
    /// Initialize, Savel, Load the syntax tree configuraton.
    /// </summary>
    public class SyntaxTreeConfiguration
    {
        public NodeTypeGoupList NodeTypeGroupList { get; set; }

        public SyntaxTreeConfiguration()
        {
            NodeTypeGroupList = new NodeTypeGoupList();
        }

        public SyntaxTreeConfiguration(string fileName)
            :   this()
        {
            Load(fileName);
        }

        /// <summary>
        /// Save the configuration to file.
        /// </summary>
        /// <param name="fileName">Save file name</param>
        public void Save(string fileName)
        {
            new ConfigSerializer().Save(NodeTypeGroupList, fileName);
        }

        /// <summary>
        /// Load the configuration from file.
        /// If file does not exist initialize the configuration with default daten.
        /// </summary>
        /// <param name="fileName">The file where the configuration is stored.</param>
        public void Load(string fileName)
        {
            if (!File.Exists(fileName))
                Initialize();
            else
                NodeTypeGroupList = new ConfigSerializer().Load(fileName);
        }


        /// <summary>
        /// Initialize the configuration
        /// </summary>
        public void Initialize()
        {
            NodeTypeGroupList = new NodeTypeGoupList
            {
                new NodeTypeGroup
                { 
                    Name = "High Level Node Types", 
                    NodeTypeList = 
                    new List<NodeBoolPair>
                    {
                         new NodeBoolPair(NodeType.CompilationUnit,  true),
                         new NodeBoolPair(NodeType.SimpleProgram,  true),
                         new NodeBoolPair(NodeType.MultiFunctionalProgram, true),
                         new NodeBoolPair(NodeType.ImportDeclarations, true),
                         new NodeBoolPair(NodeType.TypeDeclarations, true),
                         new NodeBoolPair(NodeType.GlobalVariableDeclarations, true),
                         new NodeBoolPair(NodeType.StructDeclaration, true),
                         new NodeBoolPair(NodeType.MemberDeclaration, true),
                         new NodeBoolPair(NodeType.FunctionDeclarations, true),
                         new NodeBoolPair(NodeType.FunctionDeclaration, true),
                         new NodeBoolPair(NodeType.FormalParameterList, true),
                         new NodeBoolPair(NodeType.FormalParameter, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "LoopStatements", 
                    NodeTypeList = 
                    new List<NodeBoolPair>
                    {
                         new NodeBoolPair(NodeType.PForStatement, true),
                         new NodeBoolPair(NodeType.ForStatement, true),
                         new NodeBoolPair(NodeType.ForCondition, true),
                         new NodeBoolPair(NodeType.ForInitialization, true),
                         new NodeBoolPair(NodeType.ForUpdate, true),
    	                 new NodeBoolPair(NodeType.DoStatement, true),
    	                 new NodeBoolPair(NodeType.WhileStatement, true),
    	                 new NodeBoolPair(NodeType.PForEachStatement, true),
                         new NodeBoolPair(NodeType.ForEachStatement, true),
                         new NodeBoolPair(NodeType.ForEachInitialization, true),
                         new NodeBoolPair(NodeType.ForEachCollectionExpression, true),
    	                 new NodeBoolPair(NodeType.LoopStatement, true),
                         new NodeBoolPair(NodeType.LoopInitialization, true),
                         new NodeBoolPair(NodeType.LoopLimit, true),
                         new NodeBoolPair(NodeType.Condition, true),
                         new NodeBoolPair(NodeType.Core, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "OtherStatements", 
                    NodeTypeList = 
                    new List<NodeBoolPair>
                    {
                         new NodeBoolPair(NodeType.Block, true),
                         new NodeBoolPair(NodeType.Statement, true),                        
                         new NodeBoolPair(NodeType.IfStatement, true),
                         new NodeBoolPair(NodeType.IfBranch, true),
                         new NodeBoolPair(NodeType.ElseIfBranches, true),
                         new NodeBoolPair(NodeType.ConditionalBranch, true),
                         new NodeBoolPair(NodeType.ElseBranch, true),                         
                         new NodeBoolPair(NodeType.PDoStatement, true),
                         new NodeBoolPair(NodeType.AsynStatement, true),
                         new NodeBoolPair(NodeType.LockStatement, true),
                         new NodeBoolPair(NodeType.ReturnStatement, true),
                         new NodeBoolPair(NodeType.Return, true),
                         new NodeBoolPair(NodeType.Break, true),                        
                         new NodeBoolPair(NodeType.ExpressionStatement, true),
                         new NodeBoolPair(NodeType.VariableDeclarationStatement, true),
                         new NodeBoolPair(NodeType.VariableInitialization, true),
                         new NodeBoolPair(NodeType.VariableDeclaration, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Literals", 
                    NodeTypeList = 
                    new List<NodeBoolPair>
                    {
                         new NodeBoolPair(NodeType.CharLiteral, true),
                         new NodeBoolPair(NodeType.StringLiteral, true),
                         new NodeBoolPair(NodeType.IntLiteral, true),
                         new NodeBoolPair(NodeType.DecimalLiteral, true),
                         new NodeBoolPair(NodeType.BoolLiteral, true),
                         new NodeBoolPair(NodeType.NullLiteral, true),
                         new NodeBoolPair(NodeType.InfinityLiteral, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Operators", 
                    NodeTypeList = 
                    new List<NodeBoolPair>
                    {
                         new NodeBoolPair(NodeType.AssignmentOp, true),
                         new NodeBoolPair(NodeType.LogicalOrOp, true),
                         new NodeBoolPair(NodeType.LogicalAndOp, true),
                         new NodeBoolPair(NodeType.EqualityOp, true),
                         new NodeBoolPair(NodeType.RelationOp, true),
                         new NodeBoolPair(NodeType.AdditiveOp, true),
                         new NodeBoolPair(NodeType.MultiplicativeOp, true),
                         new NodeBoolPair(NodeType.UnaryOp, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Expressions", 
                    NodeTypeList = 
                    new List<NodeBoolPair>
                    {
                         new NodeBoolPair(NodeType.Expression, true),
                         new NodeBoolPair(NodeType.Cast, true),
                         new NodeBoolPair(NodeType.PrefixUnaryOperation, true),
                         new NodeBoolPair(NodeType.Selector, true),
                         new NodeBoolPair(NodeType.MemberSelect, true),
                         new NodeBoolPair(NodeType.FunctionCall, true),
                         new NodeBoolPair(NodeType.MemberFunctionCall, true),
                         new NodeBoolPair(NodeType.Arguments, true),
                         new NodeBoolPair(NodeType.Indexing, true),
                         new NodeBoolPair(NodeType.Dimensions, true),
                         new NodeBoolPair(NodeType.ConstantDimensions, true),
                         new NodeBoolPair(NodeType.DimensionMarker, true)
                    }
                },                
                new NodeTypeGroup
                { 
                    Name = "Other", 
                    NodeTypeList = 
                    new List<NodeBoolPair>
                    {
                         new NodeBoolPair(NodeType.Identifier, true),
                         new NodeBoolPair(NodeType.DataTypeName, true),
                         new NodeBoolPair(NodeType.DataType, true),
                         new NodeBoolPair(NodeType.Type, true),
                         new NodeBoolPair(NodeType.Reference, true)
                    }
                }
            };
        }
    }
}
