using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Info
{
    /// <summary>
    /// Simple abstract base class of GlobalVariableInfo, UserDefinedTypeInfo, UserDefinedFunctionInfo
    /// </summary>
    public abstract class Info
    {
        public Info()
        {
            IsAnalised = false;
            IsCompiled = false;
        }

        public Info(string fileName, NodeValueInfo nvi)
            : this()
        {
            FileName = fileName;
            NodeValueInfo = nvi;
        }

        public bool IsAnalised { get; set; }
        public bool IsCompiled { get; set; }

        /// <summary>
        /// Info about the location of the element.
        /// </summary>
        public NodeValueInfo NodeValueInfo { get; set; }

        /// <summary>
        /// The file name, that contain the global variable declaration.
        /// </summary>
        public string FileName { get; set; }
    }
}
