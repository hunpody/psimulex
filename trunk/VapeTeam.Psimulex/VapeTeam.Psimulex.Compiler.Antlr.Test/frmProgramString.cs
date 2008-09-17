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
    public partial class frmProgramString : Form
    {
        public string ProgramString { get; set; }

        public frmProgramString()
        {
            InitializeComponent();
        }

        public void Init()
        {
            txtProgramString.Text = ProgramString;
        }

        private void frmProgramString_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
