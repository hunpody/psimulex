using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Compiler.Utils;
using System.IO;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Compiler.Info;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /// <summary>
    /// This visitor resolve the import conflict and
    /// query informations from source files for the Semantic Analyzer.
    /// (Types, Global variables, Function signatures)
    /// </summary>
    class PsiImportResolverVisitor : PsiVisitor
    {
        /*Input*/
        #region Input

        private Compiler compiler;
        
        public PsiImportResolverVisitor(CompilationUnit cu, CompilerDTO dto, Compiler c)
            : base(cu,dto)
        {
            compiler = c;
            InitHelpers();
        }

        #endregion

        /*Helper Methods*/
        #region Helper Methods

        private Member lastCompiledMember;

        private void InitHelpers()
        {
            lastCompiledMember = new Member();
        }

        private bool IsImportFounded(string name)
        {
            if (CompilationUnitList.Find(cu => cu.FileName == name) == null)
                return false;
            return true;
        }

        private bool IsUserDefinedTypeFounded(string name)
        {
            if (UserDefinedTypeInfoList.Find(udti => udti.Name == name) == null)
                return false;
            return true;
        }

        private bool IsAttributeFounded(List<AttributeDescriptor> attrList, string name)
        {
            if (attrList.Find(attr => attr.Descriptor.Name == name) == null)
                return false;
            return true;
        }

        private bool IsGlobalVariableFounded(string name)
        {
            if (GlobalVariableInfoList.Find(gv => gv.Name == name) == null)
                return false;
            return true;
        }

        private bool IsFunctionParameterFounded(string name)
        {
            if (lastCompiledUserDefinedFunction.Parameters.Find(param => param.Name == name) == null)
                return false;
            return true;
        }

        private bool IsFunctionFounded(string name, int parameterCount)
        {
            if (UserDefinedFunctionInfoList.Find( func => func.Name == name && func.ParameterCount == parameterCount) == null)
                return false;
            return true;
        }

        #endregion

        #region IPsiVisitor Members

        /*High Level Tree Nodes*/
        #region High Level Tree Nodes

        public override void Visit(SimpleProgramNode node)
        {
            // Nothing to do !
            return;
        }

        public override void Visit(MultiFuncionalProgramNode node)
        {
            // Query Types
            node.ProgramTypeDeclarations.Accept(this);

            // Query Global variables
            node.ProgramGlobalVariableDeclarations.Accept(this);

            // Query Functions
            node.ProgramFunctionDeclarations.Accept(this);

            // Resolve Imports
            node.ProgramImports.Accept(this);
        }

        public override void Visit(ImportDeclarationNode node)
        {
            // Message
            string imports = "Imports Found : ( ";
            foreach (IPsiNode child in node.Children)
            {
                imports += child.Value;
                if (child != node.Right)
                    imports += ", ";
            }
            imports += " )";
            AddInformation(imports, node.NodeValueInfo);

            foreach (IPsiNode child in node.Children)
            {
                string import = child.Value.SplitQuotes();               

                // Create Full path and Get importFileName
                string importFileName = import;
                string importFile = Path.GetFullPath(import);
                if (importFile.Contains(DTO.ProgramPath))
                    importFileName = importFile.Substring(
                        DTO.ProgramPath.Length + 1,
                        importFile.Length - DTO.ProgramPath.Length - 1);

                if (!IsImportFounded(importFileName))
                {
                    // Check Existance
                    if (!File.Exists(importFile))
                    {
                        AddError(CompilerErrorCode.ImportFileNotFound,
                            string.Format("Import file not found \"{0}\" !", import),
                            child.NodeValueInfo);
                    }
                    else
                    {
                        using (StreamReader sr = new StreamReader(importFile))
                        {
                            compiler.ResolveImports(sr.ReadToEnd(), importFileName, DTO, ProgramPart.CompilationUnit);
                            sr.Close();
                        }
                    }
                }
                // Else Duplicated Import Not a really Problem.
            }
        }

        public override void Visit(StructDeclarationNode node)
        {
            // User Defined Struct Name
            string structName = node.StructName.Value;
            List<Member> structMembers = new List<Member>();

            foreach (IPsiNode member in node.StructMemberList)
            {
                member.Accept(this);
                structMembers.Add(lastCompiledMember);
            }

            // Message
            string msg = "Struct Found : " + structName + " { ";
            foreach (Member member in structMembers)
            {
                msg += member.ToString();

                if (member != structMembers[structMembers.Count - 1])
                    msg += ", ";
            }
            msg += " }";
            AddInformation(msg, node.NodeValueInfo);

            // Check Existance
            if (IsUserDefinedTypeFounded(structName))
            {
                AddError(CompilerErrorCode.TypeCollision,
                    string.Format("User defined type \"{0}\" is already used, this will be skipped!", structName),
                    node.NodeValueInfo);
            }
            else
            {
                // Create a Struct Descriptor
                var desc = new StructDescriptor { Name = structName };

                foreach (var member in structMembers)
                {
                    if (member.Type == TypeEnum.Undefined)
                    {
                        AddWarning(CompilerErrorCode.NotSupported,
                            "User defined types in records is not supported, member will be skipped!",
                            node.NodeValueInfo);
                    }
                    else
                    {
                        // Check Existance
                        if (IsAttributeFounded(desc.Attributes, member.Name))
                        {
                            AddError(CompilerErrorCode.StructAttributeNameCollision, string.Format(
                                "Struct \"{0}\" has already a member \"{1}\", member will be skipped!", desc.Name, member.Name),
                                node.NodeValueInfo);
                        }
                        else
                        {
                            desc.Attributes.Add(
                                new AttributeDescriptor
                                {
                                    Value = member.Value,
                                    Descriptor = new VariableDescriptor
                                    {
                                        IsReference = member.IsReference,
                                        Name = member.Name,
                                        Type = new TypeIdentifier
                                        {
                                            TypeEnum = member.Type,
                                            TypeName = member.TypeName,
                                            Dimensions = new List<int>(member.DimensionCount)
                                        }
                                    }
                                });
                        }
                    }
                }

                // Add to UserDefinedTypeInfoList
                UserDefinedTypeInfoList.Add(
                    new UserDefinedTypeInfo(
                        new TypeIdentifier
                        {
                            UserDefinedType = desc,
                            TypeEnum = TypeEnum.UserDefinedType,
                            TypeName = desc.Name
                        },
                        SourceFileName,
                        node.NodeValueInfo));
            }
        }

        public override void Visit(MemberDeclarationNode node)
        {
            // MemberType
            node.MemberType.Accept(this);
            TypeEnum memberType = lastCompiledDataType;
            string memberTypeName = node.MemberTypeName.Value;

            int memberDimensionCount = lastCompiledDimensionCount;
            List<int> memberDimensionList = lastCompiledDimensionList;

            // MemberName
            string memberName = node.MemberName.Value;
            bool memberIsInitialized = false;

            // MemberInitialValue
            BaseType memberValue = null;
            if (node.MemberInitialValue != null)
            {
                if (node.MemberInitialValue.Children.Count > 1)
                {
                    AddWarning(CompilerErrorCode.NotSupported,
                        "Initializers in struct default values not supported yet! Initial value will be skipped!",
                        node.NodeValueInfo);
                }
                else
                {
                    node.MemberInitialValue.Accept(this);
                    memberValue = lastCompiledConstantValue;
                    memberIsInitialized = true;
                }
            }

            // Last compiled Member
            lastCompiledMember = new Member
            {
                Type = memberType,
                TypeName = memberTypeName,
                DimensionCount = memberDimensionCount,
                DimensionList = memberDimensionList,
                Name = memberName,
                Value = memberValue,
                IsInitialised = memberIsInitialized,
                IsReference = false
            };

            // Set back to Defaults
            lastCompiledDimensionList = new List<int>();
            lastCompiledDimensionCount = 0;
            lastCompiledDataType = TypeEnum.Undefined;
            lastCompiledDataTypeName = "";
        }

        public override void Visit(GlobalVariableDeclarationsNode node)
        {
            foreach (IPsiNode child in node.Children)
            {
                child.Accept(this);

                // Message
                string global = "Global Variable Found : " + lastCompiledMember.ToString();
                AddInformation(global, node.NodeValueInfo);

                if (IsGlobalVariableFounded(lastCompiledMember.Name))
                {
                    AddWarning(CompilerErrorCode.GlobalVariableNameCollision,
                        string.Format(
                            "Global variable name \"{0}\" is already exist. Global variable will be skipped!",
                            lastCompiledMember.Name),
                        node.NodeValueInfo);
                }
                else
                {
                    lastCompiledMember.Type =
                        lastCompiledMember.Type == TypeEnum.Undefined
                        ? TypeEnum.UserDefinedType
                        : lastCompiledMember.Type;

                    GlobalVariableInfoList.Add(
                        new GlobalVariableInfo(
                            lastCompiledMember.Name,                            
                            new TypeIdentifier
                            {
                                Dimensions = lastCompiledMember.DimensionList,
                                GenericType = lastCompiledMember.Type,
                                TypeEnum =
                                    lastCompiledMember.DimensionCount == 0
                                    ? lastCompiledMember.Type
                                    : TypeEnum.Array,
                                TypeName = lastCompiledMember.TypeName
                            },
                            lastCompiledMember.IsInitialised ? lastCompiledMember.Value : null,
                            SourceFileName,
                            node.NodeValueInfo));
                }
            }
        }

        public override void Visit(FunctionDeclarationNode node)
        {
            // Start Compile a new function
            lastCompiledUserDefinedFunction = new UserDefinedFunction();

            // FunctionType
            node.FunctionType.Accept(this);
            TypeEnum functionType = lastCompiledDataType;
            string functionTypeName = lastCompiledDataTypeName;

            int functionDimensionCount = lastCompiledDimensionCount;
            List<int> functionDimensionList = lastCompiledDimensionList;

            // FunctionReference
            bool functionIsReferenceType = false;
            if (node.FunctionReference != null)
                functionIsReferenceType = true;

            // FunctionName
            string functionName = node.FunctionName.Value;

            // Message
            string function = "Function Found : " + functionType + " " + functionName + " () ";
            AddInformation(function, node.NodeValueInfo);

            lastCompiledUserDefinedFunction.Name = functionName;

            // FunctionParameterList
            node.FunctionParameterList.Accept(this);

            // Check function existance
            if (IsFunctionFounded(lastCompiledUserDefinedFunction.Name, lastCompiledUserDefinedFunction.ParameterCount))
            {
                AddError(CompilerErrorCode.FunctionCollison, string.Format(
                   "Function \"{0}\" with {1} parameter is already exist! The function will skipped.",
                   lastCompiledUserDefinedFunction.Name, lastCompiledUserDefinedFunction.ParameterCount),
                   node.NodeValueInfo);
            }
            else
            {
                // Set Up rest of the function property-s.
                lastCompiledUserDefinedFunction.ReturnValueType =
                    new VariableDescriptor
                    {
                        Type = new TypeIdentifier
                        {
                            TypeEnum = functionType,
                            TypeName = functionTypeName,
                            Dimensions = new List<int>(functionDimensionCount)
                        },
                        IsReference = functionIsReferenceType,
                        Name = ""
                    };

                // Add to UserDefinedFunctionInfoList
                UserDefinedFunctionInfoList.Add(
                    new UserDefinedFunctionInfo(
                        lastCompiledUserDefinedFunction,
                        SourceFileName,
                        node.NodeValueInfo));
            }
        }

        public override void Visit(FormalParameterNode node)
        {
            // Parameter Type
            node.ParameterType.Accept(this);

            TypeEnum parameterType = lastCompiledDataType;
            string parameterTypeName = lastCompiledDataTypeName;

            int parameterDimensionCount = lastCompiledDimensionCount;
            List<int> parameterDimensionList = lastCompiledDimensionList;

            // Parameter Reference
            bool parameterIsReference = false;
            if (node.ParameterReference != null)
                parameterIsReference = true;

            // Parameter Name
            string parameterName = node.ParameterName.Value;

            // Check Function Parameter existance
            if (IsFunctionParameterFounded(parameterName))
            {
                AddError(CompilerErrorCode.FormalParameterNameCollision,
                    string.Format("Function \"{0}\" has already a parameter named \"{1}\"! Parameter will be skipped!",
                    lastCompiledUserDefinedFunction.Name, parameterName), node.NodeValueInfo);
            }
            else
            {
                lastCompiledUserDefinedFunction.Parameters.Add(
                    new VariableDescriptor
                    {
                        Type = new TypeIdentifier
                        {
                            TypeEnum = parameterType,
                            TypeName = parameterTypeName,
                            Dimensions = new List<int>(parameterDimensionCount)
                        },
                        Name = parameterName,
                        IsReference = parameterIsReference,
                    });

                lastCompiledDataType = TypeEnum.Undefined;
                lastCompiledDataTypeName = "";
                lastCompiledDimensionCount = 0;
                lastCompiledDimensionList = new List<int>();
            }
        }

        #endregion

        #endregion
    }
}
