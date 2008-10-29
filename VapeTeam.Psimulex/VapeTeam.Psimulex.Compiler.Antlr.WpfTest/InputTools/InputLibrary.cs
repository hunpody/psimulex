﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Compiler.Antlr.WpfTest.InputTools
{
    public class InputLibrary : VapeTeam.Psimulex.Core.Libraries.ILibrary
    {
        protected bool randomInput { get; set; }

        public void RandomInputs(bool rnd)
        {
            randomInput = rnd;
        }
    }
}
