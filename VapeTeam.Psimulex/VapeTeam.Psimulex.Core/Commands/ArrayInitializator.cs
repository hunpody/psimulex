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
        private int size;
        private bool initFromStack;

        public override void Do(ICommandContext context)
        {
            if (dimension == 1)
            {
                if (initFromStack)
                {
                    var array = new Types.Array(type, 0);
                    for (int i = 0; i < size; i++)
                        array.Insert(context.RunStack.Pop());
                    context.RunStack.Push(array);
                }
                else
                {
                    context.RunStack.Push(new Types.Array(type, context.RunStack.Pop().ToInt32()));
                }
            }
            else
            {
                throw new Psimulex.Core.Exceptions.PsimulexException("More than one dimensional array is not implemented yet!");
            }
        }

        public ArrayInitializator(TypeEnum type, int dimension)
        {
            this.type = type;
            this.dimension = dimension;
            this.initFromStack = false;
        }

        public ArrayInitializator(TypeEnum type, int dimension, int size)
        {
            this.type = type;
            this.dimension = dimension;
            this.size = size;
            this.initFromStack = true;
        }

        public override string ToString()
        {
            return string.Format("array_initializator {0}[dim:{1}]", type.ToString(), dimension );
        }

    }
}
