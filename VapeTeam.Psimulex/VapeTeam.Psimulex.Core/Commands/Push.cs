using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Pusher Microlex command. It can push registers, constants or in-memory objects to the stack.
    /// </summary>
    public class Push : CommandBase
    {
        public ValueAccessModes AccessMode { get; private set; }

        private BaseType value;
        private string name;
        private TypeEnum type;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            switch (AccessMode)
            {
                case ValueAccessModes.Constant:
                    context.RunStack.Push(value.Clone());
                    break;
                case ValueAccessModes.LocalVariable:
                    context.RunStack.Push(context.GetVariable(name).Clone());
                    break;
                case ValueAccessModes.LocalVariableReference:
                    context.RunStack.Push(context.GetVariable(name));
                    break;
                default:
                    break;
            }

        }

        //public Push(BaseType value, ValueAccessModes accessMode)
        //{
        //    AccessMode = accessMode;
        //    this.value = value;
        //}

        public Push(string name, ValueAccessModes accessMode)
        {
            AccessMode = accessMode;
            this.name = name;
        }

        public Push(BaseType value)
        {
            this.value = value;
            this.type = value.TypeEnum;
            this.AccessMode = ValueAccessModes.Constant;
        }

        public Push(object value)
            : this(value, TypeEnum.Undefined)
        {
        }

        //public Push(TypeEnum type)
        //{
        //    this.value = ValueFactory.CreateValue(type);
        //}

        public Push(object value, TypeEnum type)
        {
            AccessMode = ValueAccessModes.Constant;
            this.type = type;
            if (type == TypeEnum.Undefined)
            {
                this.value = ValueFactory.Create(value);
            }
            else
            {
                this.value = ValueFactory.CreateValue(type);
                BaseType param = ValueFactory.Create(value);
                this.value.Assign(param);
            }
        }

        #endregion

        public override string ToString()
        {
            if (AccessMode == ValueAccessModes.LocalVariable)
            {
                return string.Format("push local {0}", name);
            }
            else if (AccessMode == ValueAccessModes.LocalVariableReference)
            {
                return string.Format("push local &{0}", name);
            }
            else 
            {
                if (type != TypeEnum.Undefined)
                {
                    return string.Format("push {1} {0}", value, type);
                }
                else
                {
                    return string.Format("push {0}", value);
                }

            }
        }
    }

    public class PushByValue : Push
    {
        public PushByValue(string variableName)
            : base(variableName, ValueAccessModes.LocalVariable)
        {
        }
    }

    public class PushByReference : Push
    {
        public PushByReference(string variableName)
            : base(variableName, ValueAccessModes.LocalVariableReference)
        {
        }
    }
}
