using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    public interface IFunctionLookup
    {
//        bool IsDefined(string name);
        Function GetFunctionByName(string name);
    }
}
