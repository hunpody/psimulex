using System;
namespace VapeTeam.Psimulex.Core.Factories
{
    public interface IThreadFactory
    {
        VapeTeam.Psimulex.Core.Thread CreateThread();
    }
}
