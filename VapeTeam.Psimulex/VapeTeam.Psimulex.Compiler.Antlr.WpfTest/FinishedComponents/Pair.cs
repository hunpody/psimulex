using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest
{
    /// <summary>
    /// Simple Pair Template Class
    /// </summary>
    /// <typeparam name="TypeLeft">Type of Left value</typeparam>
    /// <typeparam name="TypeRight">Type of Right value</typeparam>
    [Serializable]
    public class Pair<TypeLeft, TypeRight>
    {
        public Pair()
        { }

        public Pair(TypeLeft left, TypeRight right)
        {
            Left = left;
            Right = right;
        }

        public void Set(TypeLeft left, TypeRight right)
        {
            Left = left;
            Right = right;
        }

        public TypeLeft Left { get; set; }
        public TypeRight Right { get; set; }
    }
}
