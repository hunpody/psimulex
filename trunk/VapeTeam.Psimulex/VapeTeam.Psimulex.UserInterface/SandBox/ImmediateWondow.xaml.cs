﻿using System;
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
using VapeTeam.Psimulex.Compiler;

namespace VapeTeam.Psimulex.UserInterface.SandBox
{
    /// <summary>
    /// Interaction logic for ImmediateWondow.xaml
    /// </summary>
    public partial class ImmediateWondow : Window
    {
        public ImmediateWondow()
        {
            InitializeComponent();
        }

        Compiler.Compiler compiler;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            compiler = new Compiler.Compiler();

            compiler.Compile(psimulex.Text, "s", ProgramPart.Statement);

            ProgramString();
        }

        private void ProgramString()
        {
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

            microlex.Text = compiler.CompileResult.CompiledProgram.ToString() + funcString;
        }
    }
}
