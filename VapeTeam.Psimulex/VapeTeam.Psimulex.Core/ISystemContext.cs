using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core
{
    /// <summary>
    /// The context of the operating system. 
    /// It allows system calls currently.
    /// </summary>
    public interface ISystemContext
    {
        Thread CallingThread { get; set; }
        Thread CreateThread(Thread callingThread, int entryPoint);
        BaseType SystemCall(Function function, IEnumerable<BaseType> parameters);
    }
}
