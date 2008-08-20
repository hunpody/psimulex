using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Libraries
{
    public interface ILibrary
    {
        ISystemContext System { get; set;  }
    }
}
