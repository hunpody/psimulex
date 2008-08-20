using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core
{
    public interface ICommandContext
    {
        CallStack CallStack { get; }
        RunStack RunStack { get; }
        IFunctionLookup FunctionLookup { get; }
        ISystemContext System { get; }
    }
}
