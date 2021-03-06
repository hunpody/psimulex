﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Commands
{
    /// <summary>
    /// Performs a member selection.
    /// </summary>
    public class Select : CommandBase
    {
        private string name;

        public override void Do(ICommandContext context)
        {
            var value = context.RunStack.Pop().Dereference();

            if (value.Type.IsUserDefined)
            {
                var val = value as VapeTeam.Psimulex.Core.Types.UserDefinedType;
                context.RunStack.Push(val[name].Value.ToReference());
            }
            else
            {
                var propertiesOfValue = value.GetType().GetProperties();
                var property = propertiesOfValue.FirstOrDefault(prop => prop.Name.ToLower() == name.ToLower());

                if (property == null)
                {
                    throw new Psimulex.Core.Exceptions.PsimulexCoreException(string.Format("{0} has no member \"{1}\".",
                        value.GetTypeName(), name));
                }

                Types.BaseType selectionResult;
                object currentValue = null;

                // Try to get current value

                try
                {
                    currentValue = property.GetValue(value, null);
                }
                catch (System.Reflection.TargetInvocationException ex)
                {
                    throw new Exceptions.PsimulexCoreException(string.Format("Error selecting member {0} of type {1}.",
                        name, value.Type), ex.InnerException);
                }

                if (currentValue != null && (property.PropertyType.IsSubclassOf(typeof(Types.BaseType)) || property.PropertyType == typeof(Types.BaseType)))
                {
                    selectionResult = currentValue as Types.BaseType;
                }
                else
                {
                    try
                    {
                        selectionResult = new VapeTeam.Psimulex.Core.Types.PropertyWrapper(value, property);
                    }
                    catch (Exception ex)
                    {
                        throw new Exceptions.PsimulexCoreException(string.Format("Couldn't create a property wrapper for {0}.{1}.",
                            value.GetTypeName(), name), ex);
                    }
                }

                context.RunStack.Push(selectionResult);
            }
        }

        public Select(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("select {0}", name);
        }
    }
}
