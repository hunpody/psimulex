using System;
namespace VapeTeam.Psimulex.Core.Historization
{
    /// <summary>
    /// An interface that represents an operation that is historized.
    /// </summary>
    public interface IHistoricalOperation
    {
        void Redo();
        void Undo();
    }
}
