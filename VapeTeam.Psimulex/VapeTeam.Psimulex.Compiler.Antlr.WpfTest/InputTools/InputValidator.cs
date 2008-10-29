using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using System.Text.RegularExpressions;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    public class InputValidator
    {
        protected string typeName;
        protected string exampleText;

        public virtual string ErrorMessage
        {
            get
            {
                return string.Format("Input is not a valid {0}!", typeName);
            }
        }

        public virtual string ExampleMessage
        {
            get
            {
                return string.Format("Integer examples: {0}!", exampleText);
            }
        }

        public virtual string EnterMessage
        {
            get
            {
                return string.Format("Enter the {0} value:", typeName);
            }
        }

        public InputValidator()
        {
        }

        public virtual string GenerateRandomInput()
        {
            return "";
        }

        public virtual void ConvertInput(string text)
        {
        }
    }    
}
