using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.UserInterface.InputTools
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
