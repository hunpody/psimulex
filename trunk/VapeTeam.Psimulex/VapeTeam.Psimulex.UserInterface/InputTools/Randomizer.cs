using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.UserInterface.InputTools
{
    public static class Randomizer
    {
        public static Random Random { get; set; }
        public static int Min { get; set; }
        public static int Max { get; set; }

        public static string charSett;

        static Randomizer()
        {
            Random = new Random();
            Min = -100;
            Max = 100;
            charSett = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public static int NextInt()
        {
            return Random.Next(Min, Max);
        }

        public static decimal NextDecimal()
        {
            return (decimal)NextInt() + (decimal)NextInt() / 10;
        }

        public static bool NextBool()
        {
            return Random.Next(0,100) <= 50 ? false : true ;
        }

        public static char NextChar()
        {
            return charSett[Random.Next(0, charSett.Length - 1)];
        }

        public static string NextString()
        {
            string rndstr = "";
            int length = Math.Abs(NextInt()) / 4;
            if (length < 2)
                length = 2;
            for (int i = 0; i < length; i++)
            {
                rndstr += NextChar();
            }
            return rndstr;
        }
    }
}
