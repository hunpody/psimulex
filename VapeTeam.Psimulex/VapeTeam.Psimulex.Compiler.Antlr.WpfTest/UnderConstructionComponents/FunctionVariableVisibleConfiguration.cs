using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    using ConfigSerializer = SerializationUtil<List<PsiFunctionsVariablesNode>>;
    using NodeList = List<PsiFunctionsVariablesNode>;

    class FunctionVariableVisibleConfiguration
    {
        public NodeList PsiFunctionsVariablesNodeList { get; set; }

        public FunctionVariableVisibleConfiguration()
        { }

        public FunctionVariableVisibleConfiguration(string configFileName, NodeList psiNodeList)
            : this()
        {
            PsiFunctionsVariablesNodeList = psiNodeList;
            Load(configFileName);
        }

        /// <summary>
        /// Merge config from saved file, to current.
        /// </summary>
        /// <param name="current">Current config tree list</param>
        /// <param name="loaded">Loaded config tree list</param>
        public void MergeConfig(NodeList current, NodeList loaded)
        {
            // Basic Checking
            foreach (var currentCompilationUnit in current)
            {
                foreach (var loadedCompilationUnit in loaded)
                {
                    if (currentCompilationUnit.Value == loadedCompilationUnit.Value)
                    {
                        foreach (var currentFunc in currentCompilationUnit.Children)
                        {
                            foreach (var loadedFunc in loadedCompilationUnit.Children)
                            {
                                if ((currentFunc as PsiFunctionsVariablesNode).StructuralEquals(loadedFunc as PsiFunctionsVariablesNode))
                                    (currentFunc as PsiFunctionsVariablesNode).CopyMarksFrom(loadedFunc as PsiFunctionsVariablesNode);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Save the configuration to file.
        /// </summary>
        /// <param name="fileName">Save file name</param>
        public void Save(string fileName)
        {
            new ConfigSerializer().Save(PsiFunctionsVariablesNodeList, fileName);
        }

        /// <summary>
        /// Load the configuration from file.
        /// If file does not exist initialize the configuration with default daten.
        /// </summary>
        /// <param name="fileName">The file where the configuration is stored.</param>
        public void Load(string fileName)
        {
            if (File.Exists(fileName))
                MergeConfig(PsiFunctionsVariablesNodeList, new ConfigSerializer().Load(fileName));
        }


        /// <summary>
        /// Initialize the configuration
        /// </summary>
        public void Initialize()
        {
            PsiFunctionsVariablesNodeList = new NodeList();
        }
    }
}
