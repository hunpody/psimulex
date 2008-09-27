using System;
namespace VapeTeam.Psimulex.Core
{
    public interface IRegistry
    {
        VapeTeam.Psimulex.Core.Types.BaseType this[string registryName] { get; set; }
        VapeTeam.Psimulex.Core.Types.BaseType this[int index] { get; set; }
    }
}
