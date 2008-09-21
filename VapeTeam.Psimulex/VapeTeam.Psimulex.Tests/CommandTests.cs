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
        public void DeclareCommand()
        {
            // Testing declarations
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
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
                    new Call("print")));

            Assert.AreEqual("2-50-3", process.StandardOutput);
        }

        [TestMethod]
        public void CastCommand()
        {
            // Testing casts
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    // print((int) "15" + (int) '9'));
                    new Push("15"),
                    new Cast(TypeEnum.Integer),
                    new Push('9'),
                    new Cast(TypeEnum.Integer),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Call("print"),

                    new Push("-"),
                    new Call("print"),

                    // print((string) 4 + (stirng) 8);
                    new Push(4),
                    new Cast(TypeEnum.String),
                    new Push(8),
                    new Cast(TypeEnum.String),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Call("print"),

                    new Push("-"),
                    new Call("print"),

                    // print((char) "012" + (char) "345");
                    new Push("012"),
                    new Cast(TypeEnum.Character),
                    new Push("345"),
                    new Cast(TypeEnum.Character),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Call("print")

                    ));

            Assert.AreEqual("24-48-c", process.StandardOutput);
        }

        [TestMethod]
        public void AssignCommand()
        {
            // Testing assign
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    // int a, b;
                    // a = 2;
                    // b = 9;
                    // a = b = 6;
                    // print (a); print(b);

                    new Declare("a", TypeEnum.Integer),
                    new Declare("b", TypeEnum.Integer),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push(2),
                    new Assign(),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new Push(9),
                    new Assign(),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new Push(6),
                    new Assign(true),
                    new Assign(),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Call("print"),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new Call("print")
                    ));            

            Assert.AreEqual("66", process.StandardOutput);
            Assert.AreEqual(2, process.MainThread.RunStack.Count);
        }
    }
}