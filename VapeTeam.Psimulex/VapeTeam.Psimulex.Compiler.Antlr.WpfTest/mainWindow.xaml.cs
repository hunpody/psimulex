using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

using VapeTeam.Psimulex.Compiler;
using VapeTeam.Psimulex.Compiler.Antlr;
using VapeTeam.Psimulex.Compiler.AST;
using VapeTeam.Psimulex.Compiler.Configuration;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Common;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Core.Types;

using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    /// <summary>
    /// Interaction logic for mainWindow.xaml
    /// </summary>
    public partial class mainWindow : Window
    {
        private Compiler compiler = new Compiler();
        private PsiCodeGeneratorVisitor visitor;
        private PsiNode psiNode;

        private TextEditorControl editor;
        private int currentCommandToHighLight;

        public mainWindow()
        {
            InitializeComponent();
        }

        #region HelpFunctions

        private void Init()
        {
            //sourceCodeTextEditorControl = this.FindName("sourceCodeTextEditorControl") as TextEditorControl;
            editor = winFormHost.Child as TextEditorControl;

            if (!Directory.Exists("Teszt"))
                Directory.CreateDirectory("Teszt");
            if (File.Exists("Teszt\\teszt.psi"))
                editor.LoadFile("Teszt\\teszt.psi");

            // DynamicHighLight Settings
            HighlightingManager.Manager.AddSyntaxModeFileProvider(new FileSyntaxModeProvider(@"References\SyntaxRes\"));

            // HighLightting Strategy Name is Psimulex
            editor.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("Psimulex");

            currentCommandToHighLight = 0;
        }
        
        private void Bulid(string fileName)
        {
            currentCommandToHighLight = 0;
            visitor = new PsiCodeGeneratorVisitor(editor.Text, fileName);
            var result = compiler.Compile(editor.Text);

            StringBuilder sb = new StringBuilder();
            foreach (var message in compiler.ErrorMessages)
                sb.AppendLine(message);
            sb.Append(compiler.ExceptionMessages);

            resultTextBox.Text = sb.ToString();
            resultTextBox.Text = compiler.OutputString;
            resultTextBox.Text = sb.ToString();

            if (resultTextBox.Text == "")
            {
                try
                {
                    psiNode = TreeConverter.FromCommonTreeToPsiNode(compiler.SyntaxTree) as CompilationUnitNode;
                    visitor.Visit(psiNode);
                }
                catch (Exception ex)
                {
                    resultTextBox.Text = ex.ToString();
                    return;
                }
                resultTextBox.Text += "Build Finished";
            }
        }

        private void Run()
        {
            resultTextBox.Text = "";
            var machine = MachineBuilder.Instance.CreateMachine(1, 16);
            visitor.Program.Program.AddFunctions(visitor.UserDefinedFunctionList);
            var process = machine.System.Load(visitor.Program);
            try
            {
                machine.System.Run(process);
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.ToString();
                return;
            }

            resultTextBox.Text = process.StandardOutput;

            GenerateUnitTestCase();
        }

        private void GenerateUnitTestCase()
        {   
            string testName = "TestGenAt_" + (DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString()).Replace(":", "_").Replace(" ", "_").Replace(".", "_");
            string testCase =
@"
        [TestMethod]
        public void " + testName + @"()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@""
" + editor.Text.Replace("\"", "\"\"") + @"
"");

            Assert.AreEqual(@""" + resultTextBox.Text + @""", result);
        }
";
            StreamWriter sw;
            string file = "Teszt\\testCase.cs";
            if (!File.Exists(file))
                sw = new StreamWriter(file);
            else
                sw = new StreamWriter(file, true);

            sw.WriteLine();
            sw.WriteLine(testCase);
            sw.Close();
        }

        private void Step()
        {
            if (visitor != null)
            {
                if (currentCommandToHighLight < visitor.CommandPositionChanges.CommandInfoList.Count)
                {
                    Interval iv = visitor.CommandPositionChanges.CommandInfoList[currentCommandToHighLight].Interval;

                    editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.Red);
                    editor.Refresh();

                    editor.Document.MarkerStrategy.AddMarker
                       (
                       new ICSharpCode.TextEditor.Document.TextMarker
                           (
                           iv.StartIndex, iv.EndIndex - iv.StartIndex,
                           ICSharpCode.TextEditor.Document.TextMarkerType.SolidBlock,
                           System.Drawing.Color.Red
                           )
                       );
                    editor.Refresh();

                    ++currentCommandToHighLight;
                }
                else
                {
                    currentCommandToHighLight = 0;
                    editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.Red);
                    editor.Refresh();
                }
            }
        }

        private void ShowProgramString()
        {
            var window = new programStringWindow();

            string funcString = "";

            foreach (var item in visitor.UserDefinedFunctionList)
            {
                int lineNumber = visitor.Program.Program.CommandList.Count;

                foreach (VapeTeam.Psimulex.Core.Commands.ICommand command in item.Commands)
                {
                    string line = "";
                    line = lineNumber.ToString("000") + " " + command.ToString() + "\r\n";
                    funcString += line;
                    lineNumber++;
                }
            }

            window.ProgramString =
                "*** Program Microlex Code ***\r\n\r\n" + visitor.Program.ToString() + funcString +


                /*"\r\n*** TypeOf CommandObjects ***\r\n\r\n" + types +*/
                "\r\n*** Compiler Messages ***\r\n\r\n" + visitor.CompilerMessages;
            window.Show();
        }

        private void ShowSyntaxTree()
        {
            var window = new SyntaxTreeWindow();
            window.PsiNode = psiNode;
            window.ConfigFilePath = "config.cgf";
            window.ShowDialog();
        }

        private void ShowFunctionsVariablesTree()
        {
            var window = new FunctionVariableVisibleConfigurationWindow();
            window.PsiNode = psiNode;
            window.Visitor = visitor;
            window.ConfigFilePath = "config.funcvar";
            window.ShowDialog();
        }

        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            string s = "Teszt\\teszt " + DateTime.Now.ToLongDateString().Replace(':', '-') + " " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".psi";
            editor.SaveFile(s);
            editor.SaveFile("Teszt\\teszt.psi");
            Close();
        }

        private void buildButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid("teszt.psi");
        }

        private void buildAndRunButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid("teszt.psi");
            Run();
        }

        private void stepButton_Click(object sender, RoutedEventArgs e)
        {
            Step();
        }

        private void syntaxTreeButton_Click(object sender, RoutedEventArgs e)
        {
            ShowSyntaxTree();
        }

        private void programStringButton_Click(object sender, RoutedEventArgs e)
        {
            ShowProgramString();
        }

        private void variableFunctionTreeButton_Click(object sender, RoutedEventArgs e)
        {
            ShowFunctionsVariablesTree();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    Bulid("teszt.psi");
                    ShowSyntaxTree();
                    break;
                case Key.F5:
                    Bulid("teszt.psi");
                    Run();
                    break;
                case Key.F6:
                    Bulid("teszt.psi");
                    break;
                case Key.F7:
                    Bulid("teszt.psi");
                    break;
                case Key.F8:
                    Bulid("teszt.psi");
                    ShowProgramString();
                    break;
            }
        }
    }
}
