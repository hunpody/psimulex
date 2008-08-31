using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VapeTeam.Psimulex.Compiler.Antlr.Test
{
    public partial class TesterForm : Form
    {
        private Compiler compiler = new Compiler();

        public TesterForm()
        {
            InitializeComponent();
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            var result = compiler.Compile(sourceCodeTextEditorControl.Text);

            StringBuilder sb = new StringBuilder();
            foreach (var message in compiler.ErrorMessages)
            {
                sb.AppendLine(message);
            }

            resultTextBox.Text = sb.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
