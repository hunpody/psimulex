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
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Factories;

namespace VapeTeam.Psimulex.Compiler.Antlr.Test
{
    public partial class TesterForm : Form
    {
        private Compiler compiler = new Compiler();
        PsiCodeGeneratorVisitor visitor = new PsiCodeGeneratorVisitor();
        
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
            visitor = new PsiCodeGeneratorVisitor();

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

            //if (txtErrors.Text == "")
            //{
            //    try
            //    {
            CompilationUnitNode cun = TreeConverter.FromCommonTreeToPsiNode(compiler.SintaxTree) as CompilationUnitNode;
            visitor.Visit(cun);
            //    }
            //    catch(Exception ex)
            //    {
            //        txtErrors.Text = ex.ToString();
            //    }
            //}
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
                    btnRun_Click(this, new EventArgs());
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

            //PsiProgramStringBuilderVisitor v = new PsiProgramStringBuilderVisitor();
            //v.Visit(TreeConverter.FromCommonTreeToPsiNode(compiler.SintaxTree) as CompilationUnitNode);      
            /*
            string src = sourceCodeTextEditorControl.Text;
            string types = "\t\t\tvar process = Helpers.SystemHelper.CompileAndRunGetProcess(@\"" +
                src.Replace("\"", "\"\"").Replace("\r\n", "") + "\");\r\n";
            types += "Assert.AreEqual(" + visitor.Program.Program.CommandList.Count + ", process.Program.CommandList.Count);\r\n";
            types += "\t\t\tType[] commandObjectTypes =\r\n\t\t\t{\r\n";
            foreach (ICommand cmd in visitor.Program.Program.CommandList)
            {
                types += "\t\t\t\ttypeof(" + cmd.GetType().ToString() + ")";
                if (cmd != visitor.Program.Program[visitor.Program.Program.CommandList.Count - 1])
                    types += ",\r\n";
            }
            types += "\r\n\t\t\t};\r\n";
            types += "\t\t\tfor (int i = 0; i < process.Program.CommandList.Count; i++)";
            types += "\r\n\t\t\t\tAssert.IsInstanceOfType(process.Program.CommandList[i], commandObjectTypes[i]);";
            */

            frmProgramString.ProgramString = 
                "*** Program Microlex Code ***\r\n\r\n" + visitor.Program.ToString() +
                /*"\r\n*** TypeOf CommandObjects ***\r\n\r\n" + types +*/
                "\r\n*** Compiler Messages ***\r\n\r\n" + visitor.CompilerMessages;
            frmProgramString.Show();
        }

        private void TesterForm_Load(object sender, EventArgs e)
        {
            //compileButton_Click(this, new EventArgs());
            //btnViewProgramString_Click(this, new EventArgs());
            //btnViewTree_Click(this, new EventArgs());
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            compileButton_Click(this, new EventArgs());

            var machine = MachineBuilder.Instance.CreateMachine(1, 16);

            visitor.Program.Program.AddFunction(visitor.UserDefinedFunctionList);

            var process = machine.System.Load(visitor.Program);

            try
            {
                machine.System.Run(process);
            }
            catch (Exception ex)
            {
                txtErrors.Text = ex.ToString();
            }

            resultTextBox.Text = process.StandardOutput;

            // Teszt Generátor
            string testName = "TestGenAt_" + (DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString()).Replace(":", "_").Replace(" ", "_").Replace(".", "_");
            string testCase =
@"
        [TestMethod]
        public void " + testName + @"()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@""
" + sourceCodeTextEditorControl.Text.Replace("\"","\"\"") + @"
"");

            Assert.AreEqual(@""" + resultTextBox.Text + @""", result);
        }
";
            StreamWriter sw;
            string file = "Teszt\\testCase.cs";
            if (!File.Exists(file))
                sw = new StreamWriter(file);
            else
                sw = new StreamWriter(file,true);
            sw.WriteLine();
            sw.WriteLine(testCase);
            sw.Close();
        }
    }
}
