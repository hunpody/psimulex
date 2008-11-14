using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VapeTeam.Psimulex.UserInterface.InputTools
{
    public class PrimaryInputValidator : InputValidator
    {
        protected Regex validator;

        public object Input { get; set; }

        public bool Validate(string text)
        {
            bool valid = validator.IsMatch(text);
            if (valid)
                ConvertInput(text);
            return valid;
        }
    }

    public class IntValidator : PrimaryInputValidator
    {
        public IntValidator()
        {
            validator = RegExpValidator.IntValidator;

            typeName = "Integer";
            exampleText = "0, -21, 100, +10";

            Input = Randomizer.NextInt();
        }

        public override void ConvertInput(string text)
        {
            Input = Convert.ToInt32(text);
        }

        public override string GenerateRandomInput()
        {
            return Randomizer.NextInt().ToString();
        }
    }

    public class DecimalValidator : PrimaryInputValidator
    {
        public DecimalValidator()
        {
            validator = RegExpValidator.DecimalValidator;

            typeName = "Decimal";
            exampleText = "0, 0.0, -21, -1.0, -0.001, 100, +10, +1.2, 1.2";

            Input = Randomizer.NextDecimal();
        }

        public override void ConvertInput(string text)
        {
            Input = Convert.ToDecimal(text.Replace('.', ','));
        }

        public override string GenerateRandomInput()
        {
            return Randomizer.NextDecimal().ToString().Replace(',', '.');
        }
    }

    public class BoolValidator : PrimaryInputValidator
    {
        public BoolValidator()
        {
            validator = RegExpValidator.BoolValidator;

            typeName = "Bool";
            exampleText = "true, false, igaz, hamis, i, h, t, f, 1, 0";

            Input = Randomizer.NextBool();
        }

        public override void ConvertInput(string text)
        {
            if (text.ToLower() == "true" || text.ToLower() == "t" ||
                text.ToLower() == "igaz" || text.ToLower() == "i" || text.ToLower() == "1")
                Input = true;
            else
                Input = false;
        }

        public override string GenerateRandomInput()
        {
            return Randomizer.NextBool().ToString();
        }
    }

    public class CharValidator : PrimaryInputValidator
    {
        public CharValidator()
        {
            validator = RegExpValidator.CharValidator;

            typeName = "Char";
            exampleText = "a, z, A, Z, +, -, *, /, 0, 9";

            Input = Randomizer.NextChar();
        }

        public override void ConvertInput(string text)
        {
            //string s = text.Replace("\\\\", "\\");
            Input = Convert.ToChar(text);
        }

        public override string GenerateRandomInput()
        {
            return Randomizer.NextChar().ToString();
        }
    }

    public class StringValidator : PrimaryInputValidator
    {
        public StringValidator()
        {
            validator = RegExpValidator.StringValidator;

            typeName = "String";
            exampleText = "aesdfz, ASASDZ, sadfnsa, aasad, asdfas";

            Input = Randomizer.NextString();
        }

        public override void ConvertInput(string text)
        {
            Input = text;
        }

        public override string GenerateRandomInput()
        {
            return Randomizer.NextString();
        }
    }
}
