using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Antlr.Test
{
    public partial class TesterForm : Form
    {
        private Compiler compiler = new Compiler();

        public TesterForm()
        {
            InitializeComponent();
            if (!Directory.Exists("Teszt"))
                Directory.CreateDirectory("Teszt");
            if (File.Exists("Teszt\\teszt.psi"))
                sourceCodeTextEditorControl.LoadFile("Teszt\\teszt.psi");            
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            var result = compiler.Compile(sourceCodeTextEditorControl.Text);

            StringBuilder sb = new StringBuilder();
            foreach (var message in compiler.ErrorMessages)
            {
                sb.AppendLine(message);
            }
            sb.Append(compiler.exception);

            //resultTextBox.Text = sb.ToString();
            //resultTextBox.Text = compiler.treeAdaptor.ToString();
            resultTextBox.Text = compiler.output;
            txtErrors.Text = sb.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            string s = "Teszt\\teszt " + DateTime.Now.ToLongDateString().Replace(':', '-') + " " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".psi";
            sourceCodeTextEditorControl.SaveFile(s);
            sourceCodeTextEditorControl.SaveFile("Teszt\\teszt.psi");
            Close();
        }

        protected bool processKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    compileButton_Click(this, new EventArgs());
                    btnViewProgramString_Click(this, new EventArgs());
                    return true;
                case Keys.F5:
                    compileButton_Click(this, new EventArgs());
                    return true;
                case Keys.F6:
                    compileButton_Click(this, new EventArgs());
                    return true;
                case Keys.F7:
                    compileButton_Click(this, new EventArgs());
                    return true;
                case Keys.F8:
                    btnViewTree_Click(this, new EventArgs());
                    return true;

            }
            return false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (processKey(keyData))
                return true;
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnViewTree_Click(object sender, EventArgs e)
        {
            frmTree frmTree = new frmTree();
            frmTree.PsiNode = TreeConverter.FromCommonTreeToPsiNode(compiler.SintaxTree) as CompilationUnitNode;
            frmTree.Show();
        }

        private void btnViewProgramString_Click(object sender, EventArgs e)
        {
            frmProgramString frmProgramString = new frmProgramString();

            PsiProgramStringBuilderVisitor v = new PsiProgramStringBuilderVisitor();
            v.Visit(TreeConverter.FromCommonTreeToPsiNode(compiler.SintaxTree) as CompilationUnitNode);

            frmProgramString.ProgramString = v.Program.ToString();
            frmProgramString.Show();
        }
    }
}
