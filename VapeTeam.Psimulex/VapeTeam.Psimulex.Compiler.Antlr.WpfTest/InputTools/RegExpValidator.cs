using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    public static class RegExpValidator
    {
        private static Regex IntValidator = new Regex("^(0|[1-9][0-9]*)$", RegexOptions.Compiled);
        private static Regex DecimalValidator = new Regex("^((0|[1-9][0-9]*)[\\.,][0-9]+)$", RegexOptions.Compiled);
        private static Regex BoolValidator = new Regex("^(true|false)$", RegexOptions.Compiled);
        private static Regex CharValidator = new Regex("^(.|\\.)$", RegexOptions.Compiled);

        // Legyne külön jelölés lista, halamaz stb -re ? vagy elgé csak a felsorolást csekkolni
        /* Utóbbi tűnik nyerőnek.
         * lista elemei mik lehetnek ? int, decimal, char, string Kelljen külön jelölni ?
         * {almastring , 123 , d , 1.0 , true} Ez tűnik a nyerőnek.
         * Szavakban whitespace nem megengedett vagy kelel a macskaköröm, vagy csak vesszővel elválasztás lehet.
         * 
         * Csekk : if van vessző, akor vesszővel elválasztásról van szó, ha nincs vessző,
         * akkor whitespacevel van a felsorolás.
         * 
         * Sorrend: isbool, isint, ischar, isdecimal, ha nem -> string
         */

        private static Regex ListValidator = new Regex("^(([^,\"]+|\\s*\"([^\"]|\\\\\")*\"\\s*)(,([^,\"]+|\\s*\"([^\"]|\\\\\")*\"\\s*))*,?\\s*)$", RegexOptions.Compiled);

        public static bool IsInt(string str)
        {
            return IntValidator.IsMatch(str);
        }

        public static bool IsDecimal(string str)
        {
            return DecimalValidator.IsMatch(str);
        }

        public static bool IsBool(string str)
        {
            return DecimalValidator.IsMatch(str.ToLower());
        }

        public static bool IsChar(string str)
        {
            return IntValidator.IsMatch(str);
        }

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
