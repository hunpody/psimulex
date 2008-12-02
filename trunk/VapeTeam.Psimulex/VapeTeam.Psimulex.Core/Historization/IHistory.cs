using System;
namespace VapeTeam.Psimulex.Core.Historization
{
    public interface IHistory
    {
        int TakeSnapshot();
        void WindTo(int operationId);
        void RevertToSnapshot(int snapShotId);
        void Record(IHistoricalOperation op);
    }
}
