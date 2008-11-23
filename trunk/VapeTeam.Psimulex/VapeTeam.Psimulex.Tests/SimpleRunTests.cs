using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for SimpleRunTests
    /// </summary>
    [TestClass]
    public class SimpleRunTests
    {
        public SimpleRunTests()
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
        public void EmptyRun()
        {
            //var machine = VapeTeam.Psimulex.Core.Factories.MachineBuilder.Instance.CreateMachine(1, 1024);
            //var program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Program;

            //machine.System.Run(program);

            Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Program);
        }

        [TestMethod]
        public void HelloWorld1()
        {
            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello world!"),
                new Call("print")));

            Assert.AreEqual("Hello world!", process.StandardOutput);
            Assert.AreEqual("Hello world!", process.Machine.ScreenContent);
        }

        [TestMethod]
        public void HelloWorld2()
        {
            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello "),
                new Call("print"),
                new Push("world!"),
                new Call("print")));

            Assert.AreEqual("Hello world!", process.StandardOutput);
            Assert.AreEqual("Hello world!", process.Machine.ScreenContent);
        }

        [TestMethod]
        public void HelloWorld3()
        {
            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello world!"),
                new Initialize("s"),
                new Push("s", ValueAccessModes.LocalVariableReference),
                new Call("print")));

            Assert.AreEqual("Hello world!", process.StandardOutput);
        }

        [TestMethod]
        public void HelloWorld4()
        {
            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello "),
                new Initialize("s"),
                new Push("world!"),
                new Initialize("s2"),
                new Push("s", ValueAccessModes.LocalVariableReference),
                new Call("print"),
                new Push("s2", ValueAccessModes.LocalVariableReference),
                new Call("print")));

            Assert.AreEqual("Hello world!", process.StandardOutput);
        }

        [TestMethod]
        public void HelloWorld5()
        {
            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello "),
                new Initialize("s"),
                new Push("world!"),
                new Initialize("s2"),
                new Push("s", ValueAccessModes.LocalVariableReference),
                new Push("s2", ValueAccessModes.LocalVariableReference),
                new Call("concat"),
                new Push("Hello world!"),
                new Compare(Compare.ComparisonModes.Equal),
                new Call("print")));

            Assert.AreEqual("True", process.StandardOutput);
        }

        [TestMethod]
        public void HelloWorld6_UppercaseFunctionNames()
        {
            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello "),
                new Initialize("s"),
                new Push("world!"),
                new Initialize("s2"),
                new Push("s", ValueAccessModes.LocalVariableReference),
                new Push("s2", ValueAccessModes.LocalVariableReference),
                new Call("coNCat"),
                new Push("Hello world!"),
                new Compare(Compare.ComparisonModes.Equal),
                new Call("Print")));

            Assert.AreEqual("True", process.StandardOutput);
        }

        [TestMethod]
        public void RunStackSizeIsGood()
        {
            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello "),
                new Initialize("s"),
                new Push("world!"),
                new Initialize("s2"),
                new Push("s", ValueAccessModes.LocalVariableReference),
                new Push("s2", ValueAccessModes.LocalVariableReference),
                new Call("concat"),
                new Push("Hello world!"),
                new Compare(Compare.ComparisonModes.Equal),
                new Call("print")));

            Assert.AreEqual("True", process.StandardOutput);
            // Local variables get stored in the runstack, so its size should be 2.
            Assert.AreEqual(0, process.MainThread.RunStack.Count);
        }
    }
}
