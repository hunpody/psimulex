using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    public static class RegExpValidator
    {
        public static Regex IntValidator = new Regex("^(0|(-?|\\+?)[1-9][0-9]*)$", RegexOptions.Compiled);
        public static Regex DecimalValidator = new Regex("^(((-|\\+)?0([\\.][0-9]+)?|(-|\\+)?[1-9][0-9]*)([\\.][0-9]+)?)$", RegexOptions.Compiled);
        public static Regex BoolValidator = new Regex("^(true|false)|(igaz|hamis)|(t|f)|(i|h)|(1|0)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        //public static Regex CharValidator = new Regex("^([^\\\\']|\\\\.)$", RegexOptions.Compiled);
        public static Regex CharValidator = new Regex("^(.)$", RegexOptions.Compiled);

        //public static Regex StringValidator = new Regex("^([^\\\\\"]|\\\\.)*$", RegexOptions.Compiled);
        public static Regex StringValidator = new Regex("^(.)*$", RegexOptions.Compiled);


        //public static Regex ListValidator = new Regex("^(([^,\"]+|\\s*\"([^\"]|\\\\\")*\"\\s*)(,([^,\"]+|\\s*\"([^\"]|\\\\\")*\"\\s*))*,?\\s*)$", RegexOptions.Compiled);

        public static string GetValue(string pattern, string text)
        {
            Regex regex = new Regex(pattern);
            return regex.Match(text).Groups[1].Value;
        }

        public static List<string> GetValues(string pattern, string text)
        {
            List<string> lst = new List<string>();
            Regex regex = new Regex(pattern);
            foreach (Match m in regex.Matches(text))
                lst.Add(m.Groups[1].Value);
            return lst;
        }

        public static bool IsMatch(Regex regex, string text)
        {
            return regex.IsMatch(text);
        }

        public static bool IsMatch(string pattern, string text)
        {
            return (new Regex(pattern)).IsMatch(text);
        }
    }



    

    // ... :)


    //temp
    public static class Tokenizer
    {
        public static List<string> GetList(string str)
        {
            List<string> tokens = new List<string>();

            string current = "";
            bool isInStrLiteral = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',' && !isInStrLiteral)
                {
                    current += str[i];
                }
                else if (str[i] == ',' && !isInStrLiteral)
                {
                    tokens.Add(current.Trim());
                }
                else if (isInStrLiteral)
                {
                    current += str[i];
                }
            }

            return tokens;
        }
    }
}
