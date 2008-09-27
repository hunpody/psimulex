using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// The size of each dimension will be popped from the run stack.
    /// </summary>
    public class ArrayDeclare : CommandBase
    {
        private string name;
        private TypeEnum type;
        private int dimension;

        public override void Do(ICommandContext context)
        {
            if (dimension == 1)
                context.AddVariable(name, new Types.Array(type, context.RunStack.Pop().ToInt32()));
            else
                throw new Psimulex.Core.Exceptions.PsimulexException("More than one dimensional array is not implemented yet!");
        }

        public ArrayDeclare(string name, TypeEnum type, int dimension)
        {
            this.name = name;
            this.type = type;
            this.dimension = dimension;
        }

        public override string ToString()
        {
            return string.Format("array_declare {0}[dim:{1}] {2}", type.ToString(), dimension, name);
        }
    
    }
}
