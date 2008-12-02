using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Historization
{
    /// <summary>
    /// A history manager that records all operations that are marked historical.
    /// </summary>
    public class History : IHistory
    {
        private int maxEventId = 0;

        private int currentEventId = 0;

        private List<int> snapShots;

        private List<IHistoricalOperation> operations;

        public History()
        {
            operations = new List<IHistoricalOperation>();
            snapShots = new List<int>();
        }

        public int TakeSnapshot()
        {
            snapShots.Add(maxEventId);
            return snapShots.Count - 1;
        }

        public void RevertToSnapshot(int snapShotId)
        {
            if (snapShotId < 0 || snapShotId >= snapShots.Count)
            {
                throw new Core.Exceptions.InvalidOperationException("Invalid snapshot id.");
            }

            int eventId = snapShots[snapShotId];
            WindTo(eventId);
        }

        public void NewBranch()
        {
            while (operations.Count > currentEventId)
            {
                operations.RemoveAt(operations.Count - 1);
            }
            maxEventId = currentEventId;
        }

        public void Record(IHistoricalOperation operation)
        {
            operations.Add(operation);
            if (currentEventId < maxEventId)
            {
                WindTo(maxEventId);
            }
            ++maxEventId;
            currentEventId = maxEventId;
        }

        public void WindTo(int moment)
        {
            moment = Math.Max(0, Math.Min(moment, maxEventId));
            if (moment < currentEventId)
            {
                // Rewinding
                for (int i = currentEventId; i > moment; --i)
                {
                    operations[i-1].Undo();
                }
            }
            else if (moment > currentEventId)
            {
                // Forward winding
                for (int i = currentEventId; i < moment; ++i)
                {
                    operations[i].Redo();
                }
            }

            currentEventId = moment;
        }
    }
}
