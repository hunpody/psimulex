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
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Compiler.Result;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Compiler.Antlr;

namespace VapeTeam.Psimulex.UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Compiler.Compiler compiler = new Compiler.Compiler(new PsiNodeParser());
        private PsiCodeGeneratorVisitor visitor;
        private PsiNode psiNode;

        private TextEditorControl editor;
        private int currentCommandToHighLight;
        private Machine machine;
        private bool isProgramLoaded;

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

            // HighLighting Strategy Name is Psimulex
            editor.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("Psimulex");

            currentCommandToHighLight = 0;
        }
        
        private void Build(string fileName)
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

            /*
            foreach (var item in compiler.CompileResult.CompilationUnitList)
            {                
                //foreach (var antlr in item.ANTLRErrorMessages)
                //{
                //    resultTextBox.Text += antlr + endl;
                //}

                //if (item.ANTLRExceptionText != "")
                //    resultTextBox.Text += "ANTLR Error : " + item.ANTLRExceptionText + endl;

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
            */
        }


        private void Run()
        {
            Process process = LoadProgram();

            try
            {
                this.machine.System.Run(process);
            }
            catch (Exception ex)
            {
                resultTextBox.Text = ex.ToString();
                return;
            }

            resultTextBox.Text = process.StandardOutput;

            GenerateUnitTestCase();
        }

        private Process LoadProgram()
        {
            resultTextBox.Text = "";

            if (machine != null)
            {
                this.machine.System.ThreadInstructionPointerChanged -= System_ThreadInstructionPointerChanged;
                // remove other handlers too
            }

            machine = MachineBuilder.Instance.CreateMachine(1, 1024);

            //maschine.System.InstallLibrary(new SampleInputLibrary());
            this.machine.System.InstallLibrary(new InputTools.PrimaryInputLibrary());
            this.machine.System.InstallLibrary(new InputTools.CollectionInputLibrary());

            this.machine.System.ThreadInstructionPointerChanged += System_ThreadInstructionPointerChanged;
            this.machine.System.ThreadStopped += (o,e) => RemoveHighlight();
            isProgramLoaded = true;
            return this.machine.System.Load(compiler.CompileResult.CompiledProgram);
        }

        void System_ThreadInstructionPointerChanged(object sender, VapeTeam.Psimulex.Core.OperatingSystem.ThreadInstructionPointerChangedEventArgs e)
        {
            HighlightCurrentStatement(e.SourcePosition.CharacterStartIndex, e.SourcePosition.CharacterEndIndex);
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

        /// <summary>
        /// Hightlights the given part of the source code.
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        private void HighlightCurrentStatement(int startIndex, int endIndex)
        {
            editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.YellowGreen);
            editor.Refresh();

            editor.Document.MarkerStrategy.AddMarker
               (
               new ICSharpCode.TextEditor.Document.TextMarker
                   (
                   startIndex, endIndex - startIndex,
                   ICSharpCode.TextEditor.Document.TextMarkerType.SolidBlock,
                   System.Drawing.Color.YellowGreen
                   )
               );
            editor.Refresh();
        }

        private void RemoveHighlight()
        {
            HighlightCurrentStatement(-1, -1);
        }

        private void Step()
        {
            //// Tabbolás , scrolozás jólenne ...
            //if (currentCommandToHighLight < compiler.CompileResult.CommandPositionChanges.CommandInfoList.Count)
            //{
            //    Interval iv = compiler.CompileResult.CommandPositionChanges.CommandInfoList[currentCommandToHighLight].Interval;



            //    ++currentCommandToHighLight;
            //}
            //else
            //{
            //    currentCommandToHighLight = 0;
            //    editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.YellowGreen);
            //    editor.Refresh();
            //}

            machine.System.Step();
        }

        private void ShowProgramString()
        {
            var window = new programStringWindow();
            
            string funcString = "";

            int lineNumber = compiler.CompileResult.CompiledProgram.CommandList.Count;
            foreach (var item in compiler.CompileResult.UserDefinedFunctionInfoList)
            {
                funcString += "\r\n" + item.Function.Name + "(ParameterCount : " + item.Function.ParameterCount + ")\r\n";
                foreach (VapeTeam.Psimulex.Core.Commands.ICommand command in item.Function.Commands)
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

            window.ProgramString += compiler.CompileResult.CompilerMessages.ToString() + endl;

            /*
            foreach (var item in compiler.CompileResult.CompilationUnitList)
            {                
                //foreach (var antlr in item.ANTLRErrorMessages)
                //{
                //    window.ProgramString += antlr + endl;
                //}

                //if (item.ANTLRExceptionText != "")
                //    window.ProgramString += "ANTLR Error : " + item.ANTLRExceptionText + endl;
                
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
            */

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
            Build("teszt.psi");
            isProgramLoaded = false;
        }

        private void buildAndRunButton_Click(object sender, RoutedEventArgs e)
        {
            Build("teszt.psi");
            if (compiler.CompileResult.Errors.Count + compiler.CompileResult.Warnings.Count != 0)
            {
                MessageBoxResult result =
                MessageBox.Show(string.Format("There are {0} warning(s) and {1} error(s). Are you sure you would like to run the previously compiled version?",
                    compiler.CompileResult.Warnings.Count, compiler.CompileResult.Errors.Count), "Warning"
                   , MessageBoxButton.YesNo);
                if (result == MessageBoxResult.No)
                    return;
            }
            Run();
        }

        private void stepButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isProgramLoaded)
            {
                var process = LoadProgram();
                machine.System.Start(process);
            }

            Step();
        }

        private void syntaxTreeButton_Click(object sender, RoutedEventArgs e)
        {
            Build("teszt.psi");
            ShowSyntaxTree();
        }

        private void programStringButton_Click(object sender, RoutedEventArgs e)
        {
            Build("teszt.psi");
            ShowProgramString();
        }

        private void variableFunctionTreeButton_Click(object sender, RoutedEventArgs e)
        {
            Build("teszt.psi");
            ShowFunctionsVariablesTree();
        }

        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.Key)
        //    {
        //        case Key.F1:
        //            Build("teszt.psi");
        //            ShowSyntaxTree();
        //            break;
        //        case Key.F5:
        //            Build("teszt.psi");
        //            Run();
        //            break;
        //        case Key.F6:
        //            Build("teszt.psi");
        //            break;
        //        case Key.F7:
        //            Build("teszt.psi");
        //            break;
        //        case Key.F8:
        //            Build("teszt.psi");
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
