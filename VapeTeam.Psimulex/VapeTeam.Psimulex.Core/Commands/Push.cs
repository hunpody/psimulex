using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Pusher Microlex command. It can push registers, constants or in-memory objects to the stack.
    /// 
    /// TODO: There are too many constructors. Marked for refactoring.
    /// </summary>
    public class Push : CommandBase
    {
        public ValueAccessModes AccessMode { get; private set; }

        private BaseType value;
        private string name;

        private int registryIndex = -1;
        private string registerName; 

        private TypeEnum type;

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            BaseType valueToPush = null;

            switch (AccessMode)
            {
                case ValueAccessModes.Constant:
                    valueToPush = value;
                    break;
                case ValueAccessModes.LocalVariable:
                case ValueAccessModes.LocalVariableReference:
                    valueToPush = context.GetVariable(name);
                    break;
                case ValueAccessModes.Register:
                case ValueAccessModes.RegisterByReference:
                    if (registryIndex >= 0)
                    {
                        valueToPush = context.Registry[registryIndex];
                    }
                    else
                    {
                        valueToPush = context.Registry[registerName];
                    }
                    break;
            }

            if (AccessMode == ValueAccessModes.Constant || AccessMode == ValueAccessModes.Register)
            {
                valueToPush = valueToPush.Dereference().Clone();
            }
            // To revise: this code snippet has no effect on the tests.
            else if (AccessMode == ValueAccessModes.LocalVariableReference || AccessMode == ValueAccessModes.RegisterByReference)
            {
                valueToPush = valueToPush.ToReference();
            }
            //else
            //{
            //    valueToPush = valueToPush.Clone();
            //}

            if (valueToPush == null)
            {
                throw new Exceptions.InvalidOperationException("Cannot push a null.");
            }

            context.RunStack.Push(valueToPush);
        }

        public Push(object name, ValueAccessModes accessMode)
        {
            AccessMode = accessMode;
            this.name = name.ToString();
            if (accessMode == ValueAccessModes.Register || accessMode == ValueAccessModes.RegisterByReference)
            {
                if (name is int)
                {
                    this.registryIndex = (int)name;
                }
                else
                {
                    this.registerName = name.ToString();
                }
            }           
        }

        public Push(BaseType value)
        {
            this.value = value;
            this.type = value.Type;
            this.AccessMode = ValueAccessModes.Constant;
        }

        /// <summary>
        /// Pushes the value converted into Psimulex type system.
        /// </summary>
        /// <param name="value"></param>
        public Push(object value)
            : this(value, TypeEnum.Undefined)
        {
        }

        /// <summary>
        /// Pushes the value converted to the given type.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
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
            else if (AccessMode == ValueAccessModes.Register)
            {
                return string.Format("push register {0}", name);
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

    public class PushRegister : Push
    {
        public PushRegister(int index, bool byReference)
            : base(index, byReference ? ValueAccessModes.RegisterByReference : ValueAccessModes.Register)
        {
        }

        public PushRegister(string name, bool byReference)
            : base(name, byReference ? ValueAccessModes.RegisterByReference : ValueAccessModes.Register)
        {
        }

        public PushRegister(int index)
            : this(index, false)
        {
        }

        public PushRegister(string name)
            : this(name, false)
        {
        }
    }
}
