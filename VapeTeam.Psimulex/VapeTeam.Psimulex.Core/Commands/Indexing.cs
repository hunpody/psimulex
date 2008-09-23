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
            int index = this.index;
            if (!initializedWithIndex)
            {
                index = context.RunStack.Pop().ToInt32();
            }

            var value = context.RunStack.Pop();
            var container = value as IIndexable;
            if (container == null)
            {
                throw new Exceptions.PsimulexCoreException(string.Format("Cannot index {0}.", value.GetTypeName()));
            }
            context.RunStack.Push(container.Index(index).ToReference());
        }

        public Indexing(int index)
        {
            this.index = index;
            this.initializedWithIndex = true;
        }

        /*
        private int dimension; 
         
        public Indexing(int dimension)
        {
            this.dimension = dimension;
            // Annyit jelent, hogy dimension darab indexet kell kivennie a tömbből.
        }
        
        // Csak egy gondolat, milenne, ha lenne asszociatív tömbünk, vagy Dictionary típusunk.
        // Csak desszertnek :)
        */

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
