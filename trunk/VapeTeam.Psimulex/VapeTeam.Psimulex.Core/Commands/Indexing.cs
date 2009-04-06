using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Array, list indexer.
    /// </summary>
    public class Indexing : CommandBase
    {
        private int index;

        private bool initializedWithIndex = false;

        public override void Do(ICommandContext context)
        {
            var value = context.RunStack.Pop().Dereference();
            var container = value as IIndexable;
            if (container == null)
            {
                throw new Exceptions.PsimulexCoreException(string.Format("Cannot index {0}.", value.GetTypeName()));
            }

            int index = this.index;
            if (!initializedWithIndex)
            {
                index = context.RunStack.Pop().ToInt32();
            }

            context.RunStack.Push(container.Index(index, context).ToReference());
        }

        public Indexing(int index)
        {
            this.index = index;
            this.initializedWithIndex = true;
        }

        public Indexing()
        {
        }

        public override string ToString()
        {
            if (initializedWithIndex)
            {
                return string.Format("indexing at {0}", index);
            }
            else
            {
                return "indexing";
            }
        }
    }
}
