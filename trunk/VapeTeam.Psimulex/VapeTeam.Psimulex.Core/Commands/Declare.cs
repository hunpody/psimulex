using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Initializes variable to a default value.
    /// </summary>
    public class Declare : CommandBase
    {
        private string name;
        private TypeEnum type;

        public override void Do(ICommandContext context)
        {
            context.AddVariable(name, ValueFactory.CreateValue(type));
        }

        public Declare(string name, TypeEnum type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
