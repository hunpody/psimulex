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

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.SandBox
{
    /// <summary>
    /// Interaction logic for ImmediateWondow.xaml
    /// </summary>
    public partial class ImmediateWindow : Window
    {
        public ImmediateWindow()
        {
            InitializeComponent();
        }

        private Compiler compiler;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            compiler = new Compiler(new PsiNodeParser());

            compiler.Compile(psimulex.Text, "s", false, ProgramPart.Statement);

            ProgramString();
        }

        private void ProgramString()
        {
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

            microlex.Text = compiler.CompileResult.CompiledProgram.ToString() + funcString;
        }
    }
}
