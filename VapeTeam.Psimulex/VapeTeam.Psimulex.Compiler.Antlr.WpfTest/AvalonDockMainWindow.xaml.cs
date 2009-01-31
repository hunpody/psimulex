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
using VapeTeam.Psimulex.Compiler.AST;
using ICSharpCode.TextEditor;
using System.IO;
using ICSharpCode.TextEditor.Document;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Compiler.Result;
using AvalonDock;
using System.Windows.Forms.Integration;
using System.ComponentModel;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    /// <summary>
    /// Interaction logic for AvalonDockMainWindow.xaml
    /// </summary>
    public partial class AvalonDockMainWindow : Window
    {               
        private Compiler compiler = new Compiler(new PsiNodeParser());
        private Process process;

        private TextEditorControl editor;
        private string currentFile;

        private string sourceToCompile;

        private int currentCommandToHighLight;

        private bool canRun;
        private bool canBuild;

        private DockableContent cmsg;
        private DockableContent rres;

        private TextBox compilerMessagesTextBox;
        private TextBox runtimeResultTextBox;

        public AvalonDockMainWindow()
        {
            InitializeComponent();
        } 

        #region HelpFunctions

        private void Init()
        {
            currentFile = "teszt.psi";
            canRun = false;
            canBuild = true;

            editor = winFormHost.Child as TextEditorControl;

            // DynamicHighLight Settings
            HighlightingManager.Manager.AddSyntaxModeFileProvider(new FileSyntaxModeProvider(@"References\SyntaxRes\"));

            // HighLightting Strategy Name is Psimulex
            editor.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("Psimulex");

            ResetStepping();

            // Menu setup

            ShowRuntimeResultsChecBox.IsChecked = true;
            ShowCompilerMessagesChecBox.IsChecked = true;

            // Avalon Dock Set Up

            mainDockingManager.KeyDown += new System.Windows.Input.KeyEventHandler(mainDockingManager_KeyDown);

            cmsg = new DockableContent();
            compilerMessagesTextBox = new TextBox();
            cmsg.Content = compilerMessagesTextBox;
            cmsg.Title = "Compiler Messages";
            TextBlocks.Items.Add(cmsg);

            rres = new DockableContent();
            runtimeResultTextBox = new TextBox();
            rres.Content = runtimeResultTextBox;
            rres.Title = "Runtime Result";
            TextBlocks.Items.Add(rres);

            this.Width = this.Width + 1;
        }

        void mainDockingManager_KeyDown(object sender, KeyEventArgs e)
        {
            Window_KeyDown(sender, e);
        }
        
        private void Bulid()
        {
            if (canBuild)
            {
                canRun = false;

                statusLabel.Content = "Building ...";

                compiler = new Compiler(new PsiNodeParser());

                if (mainDockingManager.Documents.Length == 0)
                    return;

                cmsg.SetAsActive();

                ResetStepping();

                runtimeResultTextBox.Text = "";
                compilerMessagesTextBox.Text = "";

                if (editor.Text == "")
                {
                    compilerMessagesTextBox.Text = "Nothing To Do";
                    canRun = true;
                    statusLabel.Content = "Building Succesfull";
                    return;
                }

                sourceToCompile = editor.Text;

                // Compile in the back ground
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(DoCompile);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompileFinished);
                sourceToCompile = editor.Text;
                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Running in progress. You must wait to begin Build !");
            }
        }

        private delegate void WriteCompileMsg();
        private WriteCompileMsg WriteCompilerMsg;

        private void DoCompile(object sender, DoWorkEventArgs e)
        {
            try
            {
                compiler.Compile(sourceToCompile, currentFile);
            }
            catch (Exception ex)
            {
                WriteCompilerMsg = new WriteCompileMsg((WriteCompileMsg)(() => compilerMessagesTextBox.Text = ex.Message));
            }
        }

        private void CompileFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            if (WriteCompilerMsg != null)
                WriteCompilerMsg();

            compilerMessagesTextBox.Text += compiler.CompileResult.CompilerMessages.ToString() + "\n";

            cmsg.SetAsActive();

            canRun = true;

            statusLabel.Content = "Building Succesfull";
        }

        private delegate void WriteRuntimeMsg();
        private WriteRuntimeMsg WriteRuntimerMsg;

        private void Run()
        {
            if (canRun)
            {
                canBuild = false;

                statusLabel.Content = "Running ...";

                if (mainDockingManager.Documents.Length == 0)
                    return;

                rres.SetAsActive();

                runtimeResultTextBox.Text = "";

                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(DoRun);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunFinished);
                bw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Building in progress. You must wait to begin Run !");
            }
            //GenerateUnitTestCase();
        }

        private void DoRun(object sender, DoWorkEventArgs e)
        {
            var maschine = MachineBuilder.Instance.CreateMachine(1, 1024);

            maschine.System.InstallLibrary(new SampleInputLibrary());
            maschine.System.InstallLibrary(new InputTools.PrimaryInputLibrary());
            maschine.System.InstallLibrary(new InputTools.CollectionInputLibrary());

            process = maschine.System.Load(compiler.CompileResult.CompiledProgram);
            try
            {
                maschine.System.Run(process);
            }
            catch (Exception ex)
            {
                WriteRuntimerMsg += new WriteRuntimeMsg((WriteRuntimeMsg)(() => runtimeResultTextBox.Text = ex.Message));
            }
        }

        private void RunFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            rres.SetAsActive();

            if (WriteRuntimerMsg != null)
                WriteRuntimerMsg();
            runtimeResultTextBox.Text = process.StandardOutput +"\n";

            canBuild = true;

            statusLabel.Content = "Running Finished";
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
            Assert.AreEqual(@""" + runtimeResultTextBox.Text + @""", result);
        }
";
            string file = "Teszt\\testCase.cs";
            if (!File.Exists(file))
                File.Create(file).Close();

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine();
                sw.WriteLine(testCase);
                sw.Close();
            }
        }

        private void ResetStepping()
        {
            currentCommandToHighLight = 0;
            editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.Yellow);
            editor.Refresh();
        }

        private void Step()
        {
            if (currentCommandToHighLight < compiler.CompileResult.CommandPositionChanges.CommandInfoList.Count)
            {
                Interval iv = compiler.CompileResult.CommandPositionChanges.CommandInfoList[currentCommandToHighLight].Interval;

                editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.Yellow);
                editor.Refresh();

                editor.Document.MarkerStrategy.AddMarker
                   (
                   new ICSharpCode.TextEditor.Document.TextMarker
                       (
                       iv.StartIndex, iv.EndIndex - iv.StartIndex,
                       ICSharpCode.TextEditor.Document.TextMarkerType.SolidBlock,
                       System.Drawing.Color.Yellow
                       )
                   );
                editor.Refresh();

                ++currentCommandToHighLight;
            }
            else
            {
                currentCommandToHighLight = 0;
                editor.Document.MarkerStrategy.RemoveAll(x => x.Color == System.Drawing.Color.Yellow);
                editor.Refresh();
            }
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

            window.ProgramString += compiler.CompileResult.CompilerMessages.ToString() + "\n";

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
            window.ConfigFilePath = "config.funcvar";
            window.ShowDialog();
        }

        #endregion

        #region Window Events Handlers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            editor.SaveFile(currentFile);
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    //Bulid();
                    ShowSyntaxTree();
                    break;
                case Key.F5:
                    //Bulid();
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
                    break;
                case Key.F6:
                    Bulid();
                    break;
                //case Key.F7:
                //    Run();
                //    break;
                case Key.F8:
                    //Bulid();
                    ShowProgramString();
                    break;
            }
        }

        #endregion

        #region Commands Event Handlers

        private void buildButton_Click(object sender, RoutedEventArgs e)
        {
            Bulid();
        }

        private void runToolbarButton_Click(object sender, RoutedEventArgs e)
        {
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

        private void buildAndRunButton_Click(object sender, RoutedEventArgs e)
        {
            //Bulid();
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
            //Bulid();
            ShowSyntaxTree();
        }

        private void programStringButton_Click(object sender, RoutedEventArgs e)
        {
            //Bulid(); 
            ShowProgramString();
        }

        private void variableFunctionTreeButton_Click(object sender, RoutedEventArgs e)
        {
            //Bulid(); 
            ShowFunctionsVariablesTree();
        }

        private void immediateWindowButton_Click(object sender, RoutedEventArgs e)
        {
            var w = new SandBox.ImmediateWindow();
            w.ShowDialog();
        }

        #endregion

        #region Menu Event Handlers

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            editor.SaveFile(currentFile);
            Close();
        }

        private void MenuItem_Click_New(object sender, RoutedEventArgs e)
        {
            if(mainDockingManager.Documents.Length > 0)
                foreach (var doc in mainDockingManager.Documents)
                    doc.Close();

            currentFile = "untitled.psi";
            var d = new DocumentContent { Content = new WindowsFormsHost { Child = editor}, Title = currentFile };
            mainDockingManager.MainDocumentPane.Items.Add(d);

            editor.Text = "";            
        }

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            editor.SaveFile(currentFile);
        }

        private void MenuItem_Click_SaveAs(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Save Psimulex Source File";
            dlg.DefaultExt = ".psi";
            dlg.Filter = "Psimulex Source File (.psi)|*.psi";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                currentFile = dlg.FileName;
                editor.SaveFile(currentFile);
            }
        }

        private void MenuItem_Click_Open(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Open Psimulex Source File";
            dlg.DefaultExt = ".psi";
            dlg.Filter = "Psimulex Source File (.psi)|*.psi";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                currentFile = dlg.FileName;

                if (mainDockingManager.Documents.Length > 0)
                    foreach (var doc in mainDockingManager.Documents)
                        doc.Close();

                var d = new DocumentContent { Content = new WindowsFormsHost { Child = editor }, Title = System.IO.Path.GetFileName(currentFile) };
                mainDockingManager.MainDocumentPane.Items.Add(d);

                editor.LoadFile(currentFile);

                ResetStepping();
            }
        }

        private void MenuItem_Click_View(object sender, RoutedEventArgs e)
        {
            ShowCompilerMessagesChecBox.IsChecked = cmsg.IsLoaded;
            ShowRuntimeResultsChecBox.IsChecked = rres.IsLoaded;
        }

        private void ShowCompilerMessagesChecBox_Click(object sender, RoutedEventArgs e)
        {
            if (ShowCompilerMessagesChecBox.IsChecked == true)
            {
                if (!cmsg.IsLoaded)
                {
                    cmsg = new DockableContent();
                    compilerMessagesTextBox = new TextBox();
                    cmsg.Content = compilerMessagesTextBox;
                    cmsg.Title = "Compiler Messages";
                    TextBlocks.Items.Add(cmsg);

                    this.Width = this.Width + 1;
                }
            }
            else
            {
                if (cmsg.IsLoaded)
                {
                    TextBlocks.Items.Remove(cmsg);
                }
            }
        }

        private void ShowRuntimeResultsChecBox_Click(object sender, RoutedEventArgs e)
        {
            if (ShowRuntimeResultsChecBox.IsChecked == true)
            {
                if (!rres.IsLoaded)
                {
                    rres = new DockableContent();
                    runtimeResultTextBox = new TextBox();
                    rres.Content = runtimeResultTextBox;
                    rres.Title = "Runtime Result";
                    TextBlocks.Items.Add(rres);

                    this.Width = this.Width + 1;
                }
            }
            else
            {
                if (rres.IsLoaded)
                {
                    TextBlocks.Items.Remove(rres);
                }
            }
        }

        #endregion



    }
}
