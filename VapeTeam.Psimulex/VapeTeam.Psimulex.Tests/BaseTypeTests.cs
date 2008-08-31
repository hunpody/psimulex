using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for BaseTypeTests
    /// </summary>
    [TestClass]
    public class BaseTypeTests
    {
        public BaseTypeTests()
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
        public void StringOperations1()
        {
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push("Hello "),
                    new Push("world!"),
                    new Call("concat"),
                    new Call("print")));

            Assert.AreEqual("Hello world!", process.StandardOutput);
        }

        [TestMethod]
        public void StringOperations2()
        {
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push("Hello world"),
                    new CallMethod("ToUpper"),
                    new Call("print")));

            Assert.AreEqual("HELLO WORLD", process.StandardOutput);
        }

        [TestMethod]
        public void StringOperations3()
        {
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push("w"),
                    new Push("Hello world"),
                    new CallMethod("Contains"),
                    new Call("print")));

            Assert.AreEqual("True", process.StandardOutput);
        }

        [TestMethod]
        public void StringOperations4()
        {
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push("w"),
                    new Push("Hello world"),
                    new CallMethod("Contains"),
                    new Push(new Psimulex.Core.Types.Boolean(true)),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print")));

            Assert.AreEqual("True", process.StandardOutput);

            var process2 = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push("s"),
                    new Push("Hello world"),
                    new CallMethod("Contains"),
                    new Push(new Psimulex.Core.Types.Boolean(true)),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print")));

            Assert.AreEqual("False", process2.StandardOutput);

            var process3 = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push("s"),
                    new Push("Hello world"),
                    new CallMethod("Contains"),
                    new Push(false),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print")));

            Assert.AreEqual("True", process3.StandardOutput);

            var process4 = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push("s"),
                    new Push("Hello world"),
                    new CallMethod("Contains"),
                    new Call("print")));

            Assert.AreEqual("False", process4.StandardOutput);
        }

        [TestMethod]
        public void IntegerOperations1()
        {
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push(5),
                    new Push(6),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"),
                    new Push(118),
                    new Push(118),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print")));

            Assert.AreEqual("FalseTrue", process.StandardOutput);

            var process2 = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push(-9),
                    new Push(9),
                    new Compare(Compare.ComparisonModes.LessThan),
                    new Call("print"),
                    new Push(-9),
                    new Push(9),
                    new Compare(Compare.ComparisonModes.LessThanOrEqual),
                    new Call("print"),
                    new Push(-9),
                    new Push(9),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Call("print"),
                    new Push(11),
                    new Push(11),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"),
                    new Push(11),
                    new Push(11),
                    new Compare(Compare.ComparisonModes.LessThanOrEqual),
                    new Call("print"),
                    new Push(11),
                    new Push(11),
                    new Compare(Compare.ComparisonModes.GreaterThanOrEqual),
                    new Call("print"),
                    new Push(11),
                    new Push(11),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Push(false),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"),
                    new Push(50),
                    new Push(9),
                    new Compare(Compare.ComparisonModes.GreaterThan),
                    new Call("print"),
                    new Push(50),
                    new Push(9),
                    new Compare(Compare.ComparisonModes.GreaterThanOrEqual),
                    new Call("print"),
                    new Push(50),
                    new Push(9),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Call("print")));

            Assert.AreEqual("TrueTrueTrueTrueTrueTrueTrueTrueTrueTrue", process2.StandardOutput);
        }
    }
}
