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
        private TypeIdentifier type;

        public override void Do(ICommandContext context)
        {
            context.AddVariable(name, ValueFactory.CreateValue(type));
        }

        public Declare(string name, TypeEnum type)
        {
            this.type = new TypeIdentifier
            {
                TypeEnum = type,
                TypeName = type.ToString() 
            };

            this.name = name;
        }

        public Declare(string name, TypeEnum type, string typeName)
            : this(name, type)
        {
            this.type.TypeName = typeName;
        }

        public Declare(string name, TypeIdentifier ti)
        {
            this.name = name;
            type = ti;
        }

        public override string ToString()
        {
            return string.Format("declare {0} {1}", type == TypeEnum.UserDefinedType ? type.TypeName : type.ToString(), name);
        }
    }
}
