﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.AST
{
    public interface IPsiNodeFactory
    {
        IPsiNode CreateNode(NodeType type, string value, string viewComment, IPsiNode parent, List<IPsiNode> children);
        IPsiNode CreateNode(NodeType type);
        IPsiNode CreateNode(NodeType type, string value);
    }
}