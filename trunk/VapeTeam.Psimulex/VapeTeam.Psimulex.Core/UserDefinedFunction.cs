using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// User defined function.
    /// The Function Object Contains the CommandList.
    /// </summary>
    public class UserDefinedFunction : Function
    {
        public override bool IsUserDefined
        {
            get
            {
                return true;
            }
        }
        public CommandList Commands { get; set; }
        public int EntryPoint { get; set; }
    }
}
