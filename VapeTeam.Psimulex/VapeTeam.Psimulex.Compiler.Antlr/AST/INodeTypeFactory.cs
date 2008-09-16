using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
{
    public interface INodeTypeFactory
    {
        NodeType CreateNodeType(string s);
        NodeType CreateNodeType(int t);
    }
}
