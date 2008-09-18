using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    public interface INodeTypeFactory
    {
        NodeType CreateNodeType(string s);
        NodeType CreateNodeType(int t);
    }
}
