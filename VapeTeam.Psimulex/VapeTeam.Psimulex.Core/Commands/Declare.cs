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
        private string typeName;    // This is used when a type is UserDefined

        public override void Do(ICommandContext context)
        {
            if (type == TypeEnum.UserDefinedType)
                context.AddVariable(name,
                    context.System.CallingThread.Program.CreataAnInstanceOfUserDefinedType(typeName));
            else
                context.AddVariable(name, ValueFactory.CreateValue(type));
        }

        public Declare(string name, TypeEnum type)
        {
            this.name = name;
            this.type = type;
        }

        public Declare(string name, TypeEnum type, string typeName)
        {
            this.name = name;
            this.type = type;
            this.typeName = typeName;
        }

        public override string ToString()
        {
            return string.Format("declare {0} {1}", type == TypeEnum.UserDefinedType ? typeName : type.ToString(), name);
        }
    }
}
