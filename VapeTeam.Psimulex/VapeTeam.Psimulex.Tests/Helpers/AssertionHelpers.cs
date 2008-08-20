using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VapeTeam.Psimulex.Tests.Helpers
{
    internal static class AssertionHelpers
    {
        /// <summary>
        /// Asserts if a given action throws a specified type of exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="f"></param>
        public static void AssertThrows<T>(Action action) where T : Exception
        {
            try
            {
                action();
            }
            catch (T)
            {
                // Everything is OK.
                return;
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(T),
                    string.Format("The exception thrown is not an instance of type '{0}'.", typeof(T).FullName));
                return;
            }

            Assert.Fail("There was no exception thrown.");
        }
    }
}
