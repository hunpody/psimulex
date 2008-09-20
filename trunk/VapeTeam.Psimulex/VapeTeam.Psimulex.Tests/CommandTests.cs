using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for CommandTests
    /// </summary>
    [TestClass]
    public class CommandTests
    {
        public CommandTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void DeclareTest()
        {
            // Testing declarations
            var program =
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    // int a; int b; string c; a = 2 + c; b = a - 7; c = a+b; print(a); print(b); print(0+c);
                    new Declare("a", TypeEnum.Integer),
                    new Declare("b", TypeEnum.Integer),
                    new Declare("c", TypeEnum.String),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push(2),
                    new Push("c", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Assign(),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push(7),
                    new BinaryOperation(BinaryOperation.Operations.Subtraction),
                    new Assign(),
                    new Push("c", ValueAccessModes.LocalVariable),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Assign(),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Call("print"),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new Call("print"),
                    new Push(0),
                    new Push("c", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Call("print"));

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            Assert.AreEqual("2-50-3", process.StandardOutput);
        }
    }
}