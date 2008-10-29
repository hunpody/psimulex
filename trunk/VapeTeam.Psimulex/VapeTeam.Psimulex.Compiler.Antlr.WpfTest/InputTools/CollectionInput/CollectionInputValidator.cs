using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    public class CollectionInputValidator : InputValidator
    {
        public BaseType Input { get; set; }

        public virtual void ConvertInput(string[,] matrix)
        {
            Input = new Null();
        }

        public virtual void ConvertInput(string[] array)
        {
            Input = new Null();
        }
    }

    public class ListInputValidator : CollectionInputValidator
    {
        public ListInputValidator()
        {
            typeName = "List";
            exampleText = "???";
        }

        public override string GenerateRandomInput()
        {
            return base.GenerateRandomInput();
        }

        public override void ConvertInput(string text)
        {
            base.ConvertInput(text);
        }

        public override void ConvertInput(string[,] matrix)
        {
            base.ConvertInput(matrix);
        }

        public override void ConvertInput(string[] array)
        {
            base.ConvertInput(array);
        }
    }
}
