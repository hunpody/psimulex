using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Supports multiple ways of runtime initialization of collections.
    /// </summary>
    public class CollectionInitializer : CommandBase
    {
        private TypeIdentifier type;
        private int dimension;
        private int size;
        private bool initFromStack;
        private bool readSizesFromStack;

        public override void Do(ICommandContext context)
        {
            //if (dimension == 1)
            //{
                if (initFromStack)
                {
                    if (type.TypeEnum == TypeEnum.Array && readSizesFromStack)
                    {
                        type.Dimensions = context.RunStack.Pop(dimension).Select(value => value.ToInt32()).ToList();
                    }
                    var list = new Types.List();
                    for (int i = 0; i < size; i++)
                        list.Insert(context.RunStack.Pop());
                    context.RunStack.Push(list.ConvertTo(type));
                }
                else
                {
                    // ???
                    context.RunStack.Push(new Types.Array(type, context.RunStack.Pop().ToInt32()));
                }
            //}
            //else
            //{
            //    throw new Psimulex.Core.Exceptions.PsimulexException("More than one dimensional array is not implemented yet!");
            //}
        }

        public CollectionInitializer(TypeIdentifier type, int dimension)
        {
            this.type = type;
            //this.size = size;
            //this.dimension = 1;
            this.dimension = dimension;
            readSizesFromStack = true;
            this.initFromStack = true;
        }

        public CollectionInitializer(TypeIdentifier type, int dimension, int size)
        {
            this.type = type;
            this.dimension = dimension;
            this.size = size;
            this.initFromStack = true;
        }

        public override string ToString()
        {
            return string.Format("collection_initializer {0}[dim:{1}]", type.ToString(), dimension );
        }

    }
}
