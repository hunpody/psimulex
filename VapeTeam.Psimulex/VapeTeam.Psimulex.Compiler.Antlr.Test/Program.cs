using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VapeTeam.Psimulex.Compiler.Antlr.Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TesterForm tf = new TesterForm();
            Application.Run(tf);

            string s = "Teszt\\teszt " + DateTime.Now.ToLongDateString().Replace(':', '-') + " " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".psi";
            tf.sourceCodeTextEditorControl.SaveFile(s);
            tf.sourceCodeTextEditorControl.SaveFile("Teszt\\teszt.psi");
        }
    }
}
