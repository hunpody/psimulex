using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Compiler.Tests.Helpers;

namespace VapeTeam.Psimulex.Compiler.Tests
{
    /// <summary>
    /// Summary description for HelloWorldTests
    /// </summary>
    [TestClass]
    public class HelloWorldTests
    {
        public HelloWorldTests()
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
        public void SimpleHelloWorld1()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"print(""Hello world!"");");

            Assert.AreEqual("Hello world!", result);
        }

        [TestMethod]
        public void SimpleHelloWorld2_TestCommands()
        {
            var process = Helpers.SystemHelper.CompileAndRunGetProcess(@"print(""Hello world!"");");

            Assert.AreEqual(2, process.Program.CommandList.Count);
            Assert.IsInstanceOfType(process.Program.CommandList[0], typeof(VapeTeam.Psimulex.Core.Commands.Push));
            Assert.IsInstanceOfType(process.Program.CommandList[1], typeof(VapeTeam.Psimulex.Core.Commands.Call));
        }
    }
}
