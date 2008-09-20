using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Types;

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
            // Testing system function concat
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
            // Testing string.ToUpper
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
            // Testing string.Contains
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
            // Testing string.Contains and ==
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
        public void IntegerComparisons1()
        {
            // Testing integer ==
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

            // Testing integer <, <=, !=, ==, >, >=
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
            // Testing logical &&, ||, ^
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
            // Testing integer postfix and prefix ++, and --
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

            // Testing integer postfix and prefix ++, and -- on local variables

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
            // Testing unary operation "-" (negation)
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
            // Testing logical not "!"

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
            // Testing binary integer operations : +, -, *, /, ^
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

        [TestMethod]
        public void DecimalComparison1()
        {
            // Testing decimal <, <=, !=, ==, >, >=
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push(-9, TypeEnum.Decimal),
                    new Push(9, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.LessThan),
                    new Call("print"),
                    new Push(-9, TypeEnum.Decimal),
                    new Push(9, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.LessThanOrEqual),
                    new Call("print"),
                    new Push(-9, TypeEnum.Decimal),
                    new Push(9, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Call("print"),
                    new Push(11, TypeEnum.Decimal),
                    new Push(11, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"),
                    new Push(11, TypeEnum.Decimal),
                    new Push(11, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.LessThanOrEqual),
                    new Call("print"),
                    new Push(11, TypeEnum.Decimal),
                    new Push(11, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.GreaterThanOrEqual),
                    new Call("print"),
                    new Push(11, TypeEnum.Decimal),
                    new Push(11, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Push(false),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"),
                    new Push(50, TypeEnum.Decimal),
                    new Push(9, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.GreaterThan),
                    new Call("print"),
                    new Push(50, TypeEnum.Decimal),
                    new Push(9, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.GreaterThanOrEqual),
                    new Call("print"),
                    new Push(50, TypeEnum.Decimal),
                    new Push(9, TypeEnum.Decimal),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Call("print")));

            Assert.AreEqual("TrueTrueTrueTrueTrueTrueTrueTrueTrueTrue", process.StandardOutput);
        }

        [TestMethod]
        public void DecimalBinaryOperations1()
        {
            // Testing binary decimal operations : +, -, *, /, ^
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push(4, TypeEnum.Decimal),
                    new Push(5, TypeEnum.Decimal),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(8, TypeEnum.Decimal),
                    new Push(5, TypeEnum.Decimal),
                    new BinaryOperation(BinaryOperation.Operations.Subtraction),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(8, TypeEnum.Decimal),
                    new Push(2, TypeEnum.Decimal),
                    new BinaryOperation(BinaryOperation.Operations.Multiplication),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(15, TypeEnum.Decimal),
                    new Push(5, TypeEnum.Decimal),
                    new BinaryOperation(BinaryOperation.Operations.Division),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(3, TypeEnum.Decimal),
                    new Push(4, TypeEnum.Decimal),
                    new BinaryOperation(BinaryOperation.Operations.Power),
                    new Call("print"),
                    new Push(";"),
                    new Call("print")

                ));

            Assert.AreEqual("9;3;16;3;81;", process.StandardOutput);
        }

        [TestMethod]
        public void FloatComparison1()
        {
            // Testing Float <, <=, !=, ==, >, >=
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push(-9, TypeEnum.Float),
                    new Push(9, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.LessThan),
                    new Call("print"),
                    new Push(-9, TypeEnum.Float),
                    new Push(9, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.LessThanOrEqual),
                    new Call("print"),
                    new Push(-9, TypeEnum.Float),
                    new Push(9, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Call("print"),
                    new Push(11, TypeEnum.Float),
                    new Push(11, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"),
                    new Push(11, TypeEnum.Float),
                    new Push(11, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.LessThanOrEqual),
                    new Call("print"),
                    new Push(11, TypeEnum.Float),
                    new Push(11, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.GreaterThanOrEqual),
                    new Call("print"),
                    new Push(11, TypeEnum.Float),
                    new Push(11, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Push(false),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"),
                    new Push(50, TypeEnum.Float),
                    new Push(9, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.GreaterThan),
                    new Call("print"),
                    new Push(50, TypeEnum.Float),
                    new Push(9, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.GreaterThanOrEqual),
                    new Call("print"),
                    new Push(50, TypeEnum.Float),
                    new Push(9, TypeEnum.Float),
                    new Compare(Compare.ComparisonModes.NotEqual),
                    new Call("print")));

            Assert.AreEqual("TrueTrueTrueTrueTrueTrueTrueTrueTrueTrue", process.StandardOutput);
        }

        [TestMethod]
        public void FloatBinaryOperations1()
        {
            // Testing binary float operations : +, -, *, /, ^
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push(4, TypeEnum.Float),
                    new Push(5, TypeEnum.Float),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(8, TypeEnum.Float),
                    new Push(5, TypeEnum.Float),
                    new BinaryOperation(BinaryOperation.Operations.Subtraction),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(8, TypeEnum.Float),
                    new Push(2, TypeEnum.Float),
                    new BinaryOperation(BinaryOperation.Operations.Multiplication),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(15, TypeEnum.Float),
                    new Push(5, TypeEnum.Float),
                    new BinaryOperation(BinaryOperation.Operations.Division),
                    new Call("print"),
                    new Push(";"),
                    new Call("print"),

                    new Push(3, TypeEnum.Float),
                    new Push(4, TypeEnum.Float),
                    new BinaryOperation(BinaryOperation.Operations.Power),
                    new Call("print"),
                    new Push(";"),
                    new Call("print")

                ));

            Assert.AreEqual("9;3;16;3;81;", process.StandardOutput);
        }

        [TestMethod]
        public void ArrayOperations1()
        {
            // Testing array operations: create, index, Size
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    // int[5] a;
                    // a[0]=0;a[1]=1;a[2]=2;a[3]=3;a[4]=8;
                    new Push(new VapeTeam.Psimulex.Core.Types.Array(TypeEnum.Integer, 5)),
                    new Initialize("a"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Indexing(0),
                    new Push(0),
                    new Assign(),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Indexing(1),
                    new Push(1),
                    new Assign(),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Indexing(2),
                    new Push(2),
                    new Assign(),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Indexing(3),
                    new Push(3),
                    new Assign(),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Indexing(4),
                    new Push(8),
                    new Assign(),

                    // for (i=0;i<5;++i) print(a[i]);
                    new Push(0),
                    new Initialize("i"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Indexing(),
                    new Call("print"),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push(1),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Assign(),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push(5),
                    new Compare(Compare.ComparisonModes.GreaterThanOrEqual),
                    new RelativeJumpIfTrue(2),
                    new RelativeJump(-13),

                    // print(a.Size);
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Select("Size"),
                    new Call("print"),

                    // print(a.Size - 1 == 4);
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Select("Size"),
                    new Push(1),
                    new BinaryOperation(BinaryOperation.Operations.Subtraction),
                    new Push(4),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print")
                ));

            Assert.AreEqual("012385True", process.StandardOutput);
        }

        [TestMethod]
        public void ArrayIndexOutOfRange()
        {
            // Testing array indexing with bad index
            var program = 
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    // int[5] a; a[7]=0;
                    new Push(new VapeTeam.Psimulex.Core.Types.Array(TypeEnum.Integer, 5)),
                    new Initialize("a"),
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Indexing(7),
                    new Push(0),
                    new Assign());

            Helpers.AssertionHelpers.AssertThrows<Psimulex.Core.Exceptions.IndexOutOfRangeException>(
                () => Helpers.SystemHelper.CreateMachineAndRunProgram(program));
        }

        [TestMethod]
        public void ListOperations1()
        {
            // Testing list operations : add, length, pushfront, pushback, removeat, clear
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    // list L; L.Insert(0); L.Insert(1); L.Insert(2);
                    new Push(ValueFactory.CreateValue(TypeEnum.List)),
                    new Initialize("L"),
                    new Push(0),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new CallMethod("Insert"),
                    new Push(1),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new CallMethod("Insert"),
                    new Push(2),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new CallMethod("Insert"),

                    // print(L.Length == 3)
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("Length"),
                    new Push(3),
                    new Compare(Compare.ComparisonModes.Equal),
                    new Call("print"), // Prints true

                    // for (int i=0;i<3;++i) print(L[i]);
                    new Push(0),
                    new Initialize("i"),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Indexing(),
                    new Call("print"),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push(1),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Assign(),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push(3),
                    new Compare(Compare.ComparisonModes.LessThan),
                    new RelativeJumpIfTrue(-12),

                    // print(L.First);
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("First"),
                    new Call("print"),

                    // print(L.Last);
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("Last"),
                    new Call("print"),

                    // L.PushFront(-1);
                    new Push(-1),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new CallMethod("PushFront"),

                    // L.PushBack(3);
                    new Push(3),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new CallMethod("PushBack"),

                    // print(L.Size);
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("Size"),
                    new Call("print"),

                    // L.RemoveAt(2);
                    new Push(2),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new CallMethod("RemoveAt"),

                    // print(L.First);
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("First"),
                    new Call("print"),

                    // print(L.Last);
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("Last"),
                    new Call("print"),

                    // for (i=0; i<L.Size; ++i) print(L[i]);
                    new Push(0),
                    new Initialize("i"),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Indexing(),
                    new Call("print"),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push(1),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Assign(),
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("Size"),
                    new Compare(Compare.ComparisonModes.LessThan),
                    new RelativeJumpIfTrue(-13),

                    new Push("L", ValueAccessModes.LocalVariable),
                    new CallMethod("clear"),
                    new Push("L", ValueAccessModes.LocalVariable),
                    new Select("Size"),
                    new Call("print")
                ));

            Assert.AreEqual("True012025-13-10230", process.StandardOutput);
            Assert.AreEqual(2, process.MainThread.RunStack.Count);
        }
    }
}
