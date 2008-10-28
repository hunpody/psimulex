using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Core.Commands
{
    public class ArrayInitializator : CommandBase
    {
        private TypeEnum type;
        private int dimension;

        public override void Do(ICommandContext context)
        {
            if (dimension == 1)
                context.RunStack.Push(new Types.Array(type, context.RunStack.Pop().ToInt32()));
            else
                throw new Psimulex.Core.Exceptions.PsimulexException("More than one dimensional array is not implemented yet!");
        }

        public ArrayInitializator(TypeEnum type, int dimension)
        {
            this.type = type;
            this.dimension = dimension;
        }

        public override string ToString()
        {
            return string.Format("array_initializator {0}[dim:{1}]", type.ToString(), dimension );
        }

    }
}
