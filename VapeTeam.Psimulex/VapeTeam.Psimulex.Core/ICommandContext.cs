using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    public interface ICommandContext
    {
        CallStack CallStack { get; }
        RunStack RunStack { get; }
        IRegistry Registry { get; }
        IFunctionLookup FunctionLookup { get; }
        ISystemContext System { get; }
        int PC { get; set;  }

        BaseType GetVariable(string name);
        void AddVariable(string name, BaseType value);

        void PopState();
        void PushState();
    }
}
