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
        public PsiCodeGeneratorVisitor visitor { get; set; }
        public PsiNode PsiNode { get; set; }
        
        public TesterForm()
        {
            InitializeComponent();

            if (!Directory.Exists("Teszt"))
                Directory.CreateDirectory("Teszt");
            if (File.Exists("Teszt\\teszt.psi"))
                sourceCodeTextEditorControl.LoadFile("Teszt\\teszt.psi");

            // DynamicHighLight Settings
            ICSharpCode.TextEditor.Document.HighlightingManager.Manager.AddSyntaxModeFileProvider(
                new ICSharpCode.TextEditor.Document.FileSyntaxModeProvider(@"References\SyntaxRes\"));

            // HighLightting Strategy Name is Psimulex
            sourceCodeTextEditorControl.Document.HighlightingStrategy =
                ICSharpCode.TextEditor.Document.HighlightingStrategyFactory.CreateHighlightingStrategy("Psimulex");
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            currentCommandToHighLight = 0;

            visitor = new PsiCodeGeneratorVisitor(sourceCodeTextEditorControl.Text,"teszt.psi");

            var result = compiler.Compile(sourceCodeTextEditorControl.Text);

            StringBuilder sb = new StringBuilder();
            foreach (var message in compiler.ErrorMessages)
            {
                sb.AppendLine(message);
            }
            sb.Append(compiler.ExceptionMessages);

            //resultTextBox.Text = sb.ToString();
            //resultTextBox.Text = compiler.treeAdaptor.ToString();
            resultTextBox.Text = compiler.OutputString;
            txtErrors.Text = sb.ToString();

            if (txtErrors.Text == "")
            {
                try
                {
                    PsiNode = TreeConverter.FromCommonTreeToPsiNode(compiler.SyntaxTree) as CompilationUnitNode;
                    visitor.Visit(PsiNode);
                }
                catch (Exception ex)
                {
                    txtErrors.Text = ex.ToString();
                }
            }
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
            frmTree.PsiNode = TreeConverter.FromCommonTreeToPsiNode(compiler.SyntaxTree) as CompilationUnitNode;
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
            
            string funcString = "";

            foreach (var item in visitor.UserDefinedFunctionList)
            {
                int lineNumber = visitor.Program.Program.CommandList.Count;

                foreach (ICommand command in item.Commands)
                {
                    string line = "";
                    line = lineNumber.ToString("000") + " " + command.ToString() + "\r\n";
                    funcString += line;
                    lineNumber++;
                }
            }
            
            frmProgramString.ProgramString = 
                "*** Program Microlex Code ***\r\n\r\n" + visitor.Program.ToString() +funcString +


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

            visitor.Program.Program.AddFunctions(visitor.UserDefinedFunctionList);

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

        int currentCommandToHighLight = 0;
        private void StepButton_Click(object sender, EventArgs e)
        {
            if (visitor != null)
            {
                if (currentCommandToHighLight < visitor.CommandPositionChanges.CommandInfoList.Count)
                {
                    Interval iv = visitor.CommandPositionChanges.CommandInfoList[currentCommandToHighLight].Interval;

                    sourceCodeTextEditorControl.Document.MarkerStrategy.RemoveAll(x => x.Color == Color.Red);
                    sourceCodeTextEditorControl.Refresh();

                    sourceCodeTextEditorControl.Document.MarkerStrategy.AddMarker
                       (
                       new ICSharpCode.TextEditor.Document.TextMarker
                           (
                           iv.StartIndex, iv.EndIndex - iv.StartIndex,
                           ICSharpCode.TextEditor.Document.TextMarkerType.SolidBlock,
                           Color.Red
                           )
                       );
                    sourceCodeTextEditorControl.Refresh();

                    ++currentCommandToHighLight;
                }
                else
                {
                    currentCommandToHighLight = 0;
                    sourceCodeTextEditorControl.Document.MarkerStrategy.RemoveAll(x => x.Color == Color.Red);
                    sourceCodeTextEditorControl.Refresh();
                }
            }
            /*
            if (visitor != null)
            {
                CommandID cmdid = new CommandID { FunctionName = "main", FunctionParameterCount = 0, CommandIndex = i };
                while (!visitor.CommandPositionChanges.Contains(cmdid) && i < 1000)
                {
                    ++i;
                    cmdid = new CommandID { FunctionName = "main", FunctionParameterCount = 0, CommandIndex = i };
                }
                Interval iv = visitor.CommandPositionChanges[cmdid];

                if (iv != null)
                {
                    sourceCodeTextEditorControl.Document.MarkerStrategy.AddMarker
                       (
                       new ICSharpCode.TextEditor.Document.TextMarker
                           (
                           iv.FromIndex, iv.ToIndex - iv.FromIndex,
                           ICSharpCode.TextEditor.Document.TextMarkerType.SolidBlock,
                           Color.Red
                           )
                       );
                    sourceCodeTextEditorControl.Refresh();
                }
                ++i;
            }
            */
        }

        private void HighLightButton_Click(object sender, EventArgs e)
        {
           sourceCodeTextEditorControl.Document.MarkerStrategy.AddMarker
           (
           new ICSharpCode.TextEditor.Document.TextMarker
               (
               Convert.ToInt32(StartTextBox.Text), Convert.ToInt32( StopTextBox.Text),
               ICSharpCode.TextEditor.Document.TextMarkerType.SolidBlock,
               Color.Red
               )
           );

           sourceCodeTextEditorControl.Refresh();
        }

        private void RemoveHighLightButton_Click(object sender, EventArgs e)
        {
            sourceCodeTextEditorControl.Document.MarkerStrategy.RemoveAll(x => x.Color == Color.Red);

            sourceCodeTextEditorControl.Refresh();
        }
    }
}
