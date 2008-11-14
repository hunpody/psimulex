using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.UserInterface
{
    public class SampleInputLibrary : VapeTeam.Psimulex.Core.Libraries.ILibrary
    {
        public string readText()
        {
            SampleInputBox inputBox = new SampleInputBox();
            inputBox.ShowDialog();
            return inputBox.EnteredText;
        }
    }
}
