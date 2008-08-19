using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    interface IProcessorContext
    {
        BaseType GetRegister(string name);
        BaseType GetRegister(int id);
    }
}
