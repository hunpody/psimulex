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

        [TestMethod]
        public void LogicalComparisons()
        {
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push(false),
                    new Push(false),
                    new BinaryOperation(BinaryOperation.Operations.LogicalAnd),
                    new Call("print"),
                    new Push(true),
                    new Push(false),
                    new BinaryOperation(BinaryOperation.Operations.LogicalAnd),
                    new Call("print"),
                    new Push(true),
                    new Push(true),
                    new BinaryOperation(BinaryOperation.Operations.LogicalAnd),
                    new Call("print"),
                    new Push(false),
                    new Push(false),
                    new BinaryOperation(BinaryOperation.Operations.LogicalOr),
                    new Call("print"),
                    new Push(true),
                    new Push(false),
                    new BinaryOperation(BinaryOperation.Operations.LogicalOr),
                    new Call("print"),
                    new Push(true),
                    new Push(true),
                    new BinaryOperation(BinaryOperation.Operations.LogicalOr),
                    new Call("print"),
                    new Push(false),
                    new Push(false),
                    new BinaryOperation(BinaryOperation.Operations.LogicalXor),
                    new Call("print"),
                    new Push(true),
                    new Push(false),
                    new BinaryOperation(BinaryOperation.Operations.LogicalXor),
                    new Call("print"),
                    new Push(true),
                    new Push(true),
                    new BinaryOperation(BinaryOperation.Operations.LogicalXor),
                    new Call("print")));

            Assert.AreEqual("FalseFalseTrueFalseTrueTrueFalseTrueFalse", process.StandardOutput);
        }

        [TestMethod]
        public void IntegerPrefixAndPostfixUnaryOperations1()
        {
            // We test the prefix/postfix increasing/decreasing operations on values.
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push(1),
                    new UnaryOperation(UnaryOperation.Operations.PostfixDecrement),
                    new Call("print"),
                    new Push(1),
                    new UnaryOperation(UnaryOperation.Operations.PrefixDecrement),
                    new Call("print"),
                    new Push(1),
                    new UnaryOperation(UnaryOperation.Operations.PostfixIncrement),
                    new Call("print"),
                    new Push(1),
                    new UnaryOperation(UnaryOperation.Operations.PrefixIncrement),
                    new Call("print")
            
                ));

            Assert.AreEqual("1012", process.StandardOutput);

            // We test the prefix and postfix increasing / decreasing operations on local variables.

            process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push(1),
                    new Initialize("a"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.PostfixDecrement),
                    new Call("print"),
                    // should be 1
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Call("print"),
                    // should be 0
                    new Push(1),
                    new Initialize("b"),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.PrefixDecrement),
                    new Call("print"),
                    // 0
                    new Push("b", ValueAccessModes.LocalVariable),
                    new Call("print"),
                    // 0
                    new Push(1),
                    new Initialize("c"),
                    new Push("c", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.PostfixIncrement),
                    new Call("print"),
                    // 1
                    new Push("c", ValueAccessModes.LocalVariable),
                    new Call("print"),
                    // 2
                    new Push(1),
                    new Initialize("d"),
                    new Push("d", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.PrefixIncrement),
                    new Call("print"),
                    // 2
                    new Push("d", ValueAccessModes.LocalVariable),
                    new Call("print")
                    // 2
                ));

            Assert.AreEqual("10001222", process.StandardOutput);
        }

        [TestMethod]
        public void IntegerUnaryOperations1()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push(1),
                    new UnaryOperation(UnaryOperation.Operations.Negate),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),
                    new Push(5),
                    new Initialize("a"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.Negate),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Call("print")

                ));

            Assert.AreEqual("-1;-5;5", process.StandardOutput);
        }

        [TestMethod]
        public void LogicalNotOperations1()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push(true),
                    new UnaryOperation(UnaryOperation.Operations.LogicalNot),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),
                    new Push(false),
                    new UnaryOperation(UnaryOperation.Operations.LogicalNot),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),
                    new Push(false),
                    new Initialize("a"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.LogicalNot),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Call("print")

                ));

            Assert.AreEqual("False;True;True;False", process.StandardOutput);
        }

        [TestMethod]
        public void IntegerBinaryOperations1()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push(4),
                    new Push(5),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(8),
                    new Push(5),
                    new BinaryOperation(BinaryOperation.Operations.Subtraction),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(8),
                    new Push(2),
                    new BinaryOperation(BinaryOperation.Operations.Multiplication),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(15),
                    new Push(5),
                    new BinaryOperation(BinaryOperation.Operations.Division),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(3),
                    new Push(4),
                    new BinaryOperation(BinaryOperation.Operations.Power),
                    new Call("print"),
                    new Push(";"),
                    new Call("print")

                ));

            Assert.AreEqual("9;3;16;3;81;", process.StandardOutput);

        }
    }
}
