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
        public void SimpleBasicVariableInitialization1()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
                int i = 10;
                bool bt = true;
                bool bf = false;
                string s = ""alma"";
                char c = 'c';
                print(i);
                print(bt);
                print(bf);
                print(s);
                print(c);");

            Assert.AreEqual("10TrueFalsealmac", result);
        }

        [TestMethod]
        public void SimpleEscapeCharUse1()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
                string sEsc = ""a\na\'a\""a\\a"";
                char cEscSQ = '\'';
                char cEscDQ = '\""';
                char cEscBS = '\\';
                print(cEscSQ);
                print(cEscDQ);
                print(cEscBS);
                print(sEsc);");

            Assert.AreEqual("'\"\\a\r\na'a\"a\\a", result);
        }



        #region Generated Tests

        // ...

        #endregion
    }
}
