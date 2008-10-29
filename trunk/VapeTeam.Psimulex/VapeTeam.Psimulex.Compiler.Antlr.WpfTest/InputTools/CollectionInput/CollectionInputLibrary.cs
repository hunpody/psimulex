using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    public class CollectionInputLibrary : InputLibrary
    {
        public void ReadCollection()
        {
            var window = new CommonCollectionInputBox();
            window.ShowDialog();
        }
    }
}
