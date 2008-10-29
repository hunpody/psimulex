using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    public class PrimaryInputLibrary : InputLibrary
    {
        private object Show(PrimaryInputValidator piv)
        {
            object ret = piv.Input;
            if (!randomInput)
            {
                CommonPrimaryInputBox window = new CommonPrimaryInputBox();
                window.Validator = piv;
                window.ShowDialog();
                ret = window.Validator.Input;
            }
            return ret;
        }

        public int ReadInt()
        {
            return (int)Show(new IntValidator());
        }

        public decimal ReadDecimal()
        {
            return (decimal)Show(new DecimalValidator());
        }

        public char ReadChar()
        {
            return (char)Show(new CharValidator());
        }

        public string ReadString()
        {
            return (string)Show(new StringValidator());
        }

        public bool ReadBool()
        {
            return (bool)Show(new BoolValidator());
        }

        public bool ReadYesNo()
        {
            return ReadYesNo("");
        }

        public bool ReadYesNo(string question)
        {
            var window = new YesNoInputBox();
            window.Question = question;
            window.ShowDialog();
            return window.Answer;
        }
    }
}
