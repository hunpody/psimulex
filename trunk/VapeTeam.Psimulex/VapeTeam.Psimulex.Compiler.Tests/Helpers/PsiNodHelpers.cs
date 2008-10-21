using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Compiler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VapeTeam.Psimulex.Compiler.Tests.Helpers
{
    public static class PsiNodHelpers
    {
        public static void ParentTestOne(string source)
        {
            ParentTestOne(CompilerProxy.CompileResult(source).PsiNodeTree);
        }

        public static void ParentTestOne(AST.IPsiNode node)
        {
            RecursiveParentTest(node, true);
        }

        public static void RecursiveParentTest(AST.IPsiNode node, bool isRoot)
        {
            foreach (var child in node.Children)
                RecursiveParentTest(child, false);

            if (!isRoot)
            {
                Assert.AreNotEqual(node.Parent, null);
                Assert.AreEqual(node.Parent.Children.Contains(node), true);
            }
        }

        public static void ParentTestTwo(string source)
        {
            ParentTestTwo(CompilerProxy.CompileResult(source).PsiNodeTree);
        }

        public static void ParentTestTwo(AST.IPsiNode node)
        {
            var deepList = new List<KeyValuePair<VapeTeam.Psimulex.Compiler.AST.IPsiNode,int>>();
            RecursiveLeafDeepSerch(node, 1, deepList);

            deepList.ForEach(x => SearchRoot(x.Key, x.Value));
        }

        public static void SearchRoot(AST.IPsiNode node, int deep)
        {
            int i = deep;
            var next = node;

            while (i != 0)
            {
                Assert.AreNotEqual(next, null);

                next = next.Parent;
                i--; 
            }
        }

        public static void RecursiveLeafDeepSerch(AST.IPsiNode node, int deep, List<KeyValuePair<AST.IPsiNode,int>> deepList)
        {
            foreach (var child in node.Children)
                RecursiveLeafDeepSerch(child, deep + 1, deepList);

            deepList.Add(new KeyValuePair<VapeTeam.Psimulex.Compiler.AST.IPsiNode, int>(node, deep));
        }
    }
}
