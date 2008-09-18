using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.AST
{
    /*
    /// <summary>
    /// TreeVisiting and ToString() converting.
    /// </summary>
    public class PsiProgramStringBuilderVisitor : IPsiVisitor
    {
        #region PsiProgramStringBuilderVisitor Members

        public StringBuilder Program { get; set; }
        private int lineNumber;

        public PsiProgramStringBuilderVisitor()
        {
            Program = new StringBuilder();
            lineNumber = 0;
        }

        private void Add(string preFix, IPsiNode node, string postFix)
        {
            Program.Append(lineNumber.ToString("000")
               + " " + preFix + " ( " + node.Type + " ) << "
               + node.Value + " >> Comment = " + postFix + "\r\n");
            lineNumber++;
        }

        private void Add(IPsiNode node, string postFix)
        {
            Add("", node, postFix);
        }

        private void Add(IPsiNode node)
        {
            Add("", node, "");
        }

        #endregion


        #region IPsiVisitor Members

        //Undefined Tree Node Visits
        public void Visit(PsiNode node)
        {
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
            Add(node,"PsiNode");
        }

        public void Visit(XNode node)
        {
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
            Add(node,"XNode");
        }

        //High Level Tree Nodes Visits
        public void Visit(CompilationUnitNode node)
        {
            Add("----", node, "CompilationUnitNode");
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
            
        }
        public void Visit(SimpleProgramNode node)
        {     
            Add("---", node, "SimpleProgramNode");
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
        }

        public void Visit(MultiFuncionalProgramNode node)
        {
            Add("---", node, "MultiFuncionalProgramNode");
            foreach (IPsiNode child in node.Children)
                child.Accept(this);            
        }

        public void Visit(ImportDeclarationNode node)
        {
            foreach (IPsiNode child in node.Children)
                child.Accept(this);
            Add("--", node, "ImportDeclarationNode");
        }

        #endregion
    }
    */
}
