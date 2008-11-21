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
using ICSharpCode.TextEditor;
using VapeTeam.Psimulex.Compiler.AST;
using System.IO;
using ICSharpCode.TextEditor.Document;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Compiler.Compiler compiler = new Compiler.Compiler();
        private PsiCodeGeneratorVisitor visitor;
        private PsiNode psiNode;

        private TextEditorControl editor;
        private int currentCommandToHighLight;

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

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

            resultTextBox.Text = "";

            try
            {
                compiler.Compile(editor.Text, fileName);
            }
            catch (Exception e)
            {
                resultTextBox.Text = e.ToString();
            }

            string endl = "\n";

            foreach (var item in compiler.CompileResult.CompilationUnitList)
            {
                /*foreach (var antlr in item.ANTLRErrorMessages)
                {
                    resultTextBox.Text += antlr + endl;
                }

                if (item.ANTLRExceptionText != "")
                    resultTextBox.Text += "ANTLR Error : " + item.ANTLRExceptionText + endl;
                */
                foreach (var info in item.CompilerMessages.Informations)
                {
                    resultTextBox.Text += info.ToString() + endl;
                }
                
                foreach (var warn in item.CompilerMessages.Warnings)
                {
                    resultTextBox.Text += warn.ToString() + endl;
                }

                foreach (var err in item.CompilerMessages.Errors)
                {
                    resultTextBox.Text += err.ToString() + endl;
                }

                foreach (var an in item.CompilerMessages.AntlrErrors)
                {
                    resultTextBox.Text += an.ToString() + endl;
                }
            }
        }

        private void Run()
        {
            resultTextBox.Text = "";
            var maschine = MachineBuilder.Instance.CreateMachine(1, 1024);

            //maschine.System.InstallLibrary(new SampleInputLibrary());
            maschine.System.InstallLibrary(new InputTools.PrimaryInputLibrary());
            maschine.System.InstallLibrary(new InputTools.CollectionInputLibrary());

            var process = maschine.System.Load(compiler.CompileResult.CompiledProgram);
            try
            {
                maschine.System.Run(process);
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
            string src =
            @""
" + editor.Text.Replace("\"", "\"\"") + @"
"";            
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@""" + resultTextBox.Text + @""", result);
        }
";
            /*
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestTwo(src);
             */

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
            // Tabbolás , scrolozás jólenne ...
            if (currentCommandToHighLight < compiler.CompileResult.CommandPositionChanges.CommandInfoList.Count)
            {
                Interval iv = compiler.CompileResult.CommandPositionChanges.CommandInfoList[currentCommandToHighLight].Interval;

                editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.YellowGreen);
                editor.Refresh();

                editor.Document.MarkerStrategy.AddMarker
                   (
                   new ICSharpCode.TextEditor.Document.TextMarker
                       (
                       iv.StartIndex, iv.EndIndex - iv.StartIndex,
                       ICSharpCode.TextEditor.Document.TextMarkerType.SolidBlock,
                       System.Drawing.Color.YellowGreen
                       )
                   );
                editor.Refresh();

                ++currentCommandToHighLight;
            }
            else
            {
                currentCommandToHighLight = 0;
                editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.YellowGreen);
                editor.Refresh();
            }
        }

        private void ShowProgramString()
        {
            var window = new programStringWindow();
            
            string funcString = "";

            int lineNumber = compiler.CompileResult.CompiledProgram.CommandList.Count;
            foreach (var item in compiler.CompileResult.UserDefinedFunctionList)
            {                
                funcString += "\r\n" + item.Name + "(ParameterCount : " + item.ParameterCount + ")\r\n";
                foreach (VapeTeam.Psimulex.Core.Commands.ICommand command in item.Commands)
                {
                    string line = "";
                    line = lineNumber.ToString("000") + " " + command.ToString() + "\r\n";
                    funcString += line;
                    lineNumber++;
                }
            }

            window.ProgramString =
                "*** Program Microlex Code ***\r\n\r\n" +
                compiler.CompileResult.CompiledProgram.ToString() + funcString +
                "\r\n*** Compiler Messages ***\r\n\r\n";

            string endl = "\n";
            foreach (var item in compiler.CompileResult.CompilationUnitList)
            {
                /*
                foreach (var antlr in item.ANTLRErrorMessages)
                {
                    window.ProgramString += antlr + endl;
                }

                if (item.ANTLRExceptionText != "")
                    window.ProgramString += "ANTLR Error : " + item.ANTLRExceptionText + endl;
                */
                foreach (var info in item.CompilerMessages.Informations)
                {
                    window.ProgramString += info.ToString() + endl;
                }

                foreach (var warn in item.CompilerMessages.Warnings)
                {
                    window.ProgramString += warn.ToString() + endl;
                }

                foreach (var err in item.CompilerMessages.Errors)
                {
                    window.ProgramString += err.ToString() + endl;
                }

                foreach (var an in item.CompilerMessages.AntlrErrors)
                {
                    window.ProgramString += an.ToString() + endl;
                }
            }

            window.Show();
        }

        private void ShowSyntaxTree()
        {
            var window = new SyntaxTreeWindow();

            window.PsiNodeList = new List<IPsiNode>();
            compiler.CompileResult.CompilationUnitList.ForEach(x => window.PsiNodeList.Add(x.PsiNodeSyntaxTree));

            window.ConfigFilePath = "config.cgf";
            window.ShowDialog();
        }

        private void ShowFunctionsVariablesTree()
        {
            var window = new FunctionVariableVisibleConfigurationWindow();
            window.PsiFunctionsVariablesNodeList = compiler.CompileResult.PsiFunctionsVariablesNodeList;
            window.Visitor = visitor;
            window.ConfigFilePath = "config.funcvar";
            window.ShowDialog();
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buildButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid("teszt.psi");
        }

        private void buildAndRunButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid("teszt.psi");
            if (compiler.CompileResult.Errors.Count + compiler.CompileResult.Warnings.Count != 0)
            {
                MessageBoxResult result =
                MessageBox.Show(string.Format("There is {0} warning and {1} error are you sure to run ?",
                    compiler.CompileResult.Warnings.Count, compiler.CompileResult.Errors.Count), "Warning"
                   , MessageBoxButton.YesNo);
                if (result == MessageBoxResult.No)
                    return;
            }
            Run();
        }

        private void stepButton_Click(object sender, RoutedEventArgs e)
        {
            Step();
        }

        private void syntaxTreeButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid("teszt.psi");
            ShowSyntaxTree();
        }

        private void programStringButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid("teszt.psi");
            ShowProgramString();
        }

        private void variableFunctionTreeButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid("teszt.psi");
            ShowFunctionsVariablesTree();
        }

        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.Key)
        //    {
        //        case Key.F1:
        //            Bulid("teszt.psi");
        //            ShowSyntaxTree();
        //            break;
        //        case Key.F5:
        //            Bulid("teszt.psi");
        //            Run();
        //            break;
        //        case Key.F6:
        //            Bulid("teszt.psi");
        //            break;
        //        case Key.F7:
        //            Bulid("teszt.psi");
        //            break;
        //        case Key.F8:
        //            Bulid("teszt.psi");
        //            ShowProgramString();
        //            break;
        //    }
        //}

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new InputTools.ValidatorTester().Show();
        }

        private void immediateWindowButton_Click(object sender, RoutedEventArgs e)
        {
            var w = new SandBox.ImmediateWondow();
            w.ShowDialog();
        }

        private void showGraphDrawer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new GraphDraw().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DocumentContent_Closed(object sender, EventArgs e)
        {
            string s = "Teszt\\teszt " + DateTime.Now.ToLongDateString().Replace(':', '-') + " " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".psi";
            editor.SaveFile(s);
            editor.SaveFile("Teszt\\teszt.psi");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            string s = "Teszt\\teszt " + DateTime.Now.ToLongDateString().Replace(':', '-') + " " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".psi";
            editor.SaveFile(s);
            editor.SaveFile("Teszt\\teszt.psi");
        }
    }
}
