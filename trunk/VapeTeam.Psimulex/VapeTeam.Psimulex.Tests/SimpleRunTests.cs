using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Commands;

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
            var machine = VapeTeam.Psimulex.Core.Factories.MachineBuilder.Instance.CreateMachine(1, 16);
            var program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Program;

            machine.System.Run(program);
        }

        [TestMethod]
        public void HelloWorld1()
        {
            var machine = VapeTeam.Psimulex.Core.Factories.MachineBuilder.Instance.CreateMachine(1, 16);
            var program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push("Hello world!"),
                new Call("print"));

            var process = machine.System.Load(program);

            machine.System.Run(program);

            Assert.AreEqual("Hello world!", process.StandardOutput);
            Assert.AreEqual("Hello world!", machine.ScreenContent);
        }
    }
}
