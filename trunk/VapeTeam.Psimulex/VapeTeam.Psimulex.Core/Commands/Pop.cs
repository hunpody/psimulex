using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Simply pops the top of the stack. If a register index or name has been set the it assigns the popped value to the register.
    /// </summary>
    public class Pop : CommandBase
    {        
        /// <summary>
        /// The popped value will be assigned to a register if it is true.
        /// </summary>
        public bool MoveToRegister { get; private set ;}
        public int RegisterIndex { get; private set; }
        public string RegisterName { get; private set; }

        #region ICommand Members

        public override void Do(ICommandContext context)
        {
            var poppedValue = context.RunStack.Pop();

            if (MoveToRegister)
            {
                if (RegisterIndex >= 0)
                {
                    context.Registry[RegisterIndex] = poppedValue;
                }
                else
                {
                    context.Registry[RegisterName] = poppedValue;
                }
            }
        }

        #endregion

        public Pop()
            :this(-1)
        {
        }

        public Pop(int index)
        {
            RegisterIndex = index;
            MoveToRegister = index >= 0;
        }

        public Pop(string name)
            : this(-1)
        {
            RegisterName = name;
            MoveToRegister = !string.IsNullOrEmpty(name);
        }

        public override string ToString()
        {
            if (!MoveToRegister)
            {
                return "pop";
            }
            else
            {
                if (RegisterIndex >= 0)
                {
                    return string.Format("pop register {0}", RegisterIndex);
                }
                else
                {
                    return string.Format("pop register {0}", RegisterName);
                }
            }
        }
    }
}
