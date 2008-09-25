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
    /// Summary description for FunctionTests
    /// </summary>
    [TestClass]
    public class FunctionTests
    {
        public FunctionTests()
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
        public void FunctionCallByAddress1()
        {
            // Test native calls

            /* The program is:
             * 
             * int i = 0;
             * for (int j=0; j<10; ++j)
             *     i = inc(i);
             * print(i);
             * int inc(int i) { return i + 1; }
             * 
             * Result == 45
            */
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                new Declare("i", TypeEnum.Integer),
                new Push(0),
                new Initialize("j", TypeEnum.Integer),
                new Push("j", ValueAccessModes.LocalVariableReference),
                new Push(10),
                new Compare(Compare.ComparisonModes.LessThan),
                new RelativeJumpIfFalse(11),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Call(20),
                new Assign(),
                new Push("j", ValueAccessModes.LocalVariableReference),
                new Push("j", ValueAccessModes.LocalVariableReference),
                new Push(1),
                new BinaryOperation(BinaryOperation.Operations.Addition),
                new Assign(),
                new RelativeJump(-13),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Call("print"),
                new Return(),
                // Here begins the inc function
                new Initialize("i", TypeEnum.Integer),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Push(1),
                new BinaryOperation(BinaryOperation.Operations.Addition),
                new Return()));

            Assert.AreEqual("10", process.StandardOutput);
            Assert.AreEqual(19, process.MainThread.PC);
        }

        private long Fibonacci(long n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        private VapeTeam.Psimulex.Core.Process CreateAndRunFibonacci(long n)
        {

            /* The program is:
             * 
             * print(fib(x));
             * int fib(int n) { if (n <= 0) return 0; if (n == 1) return 1; return fib(n-2) + fib(n-1); }
             * 
             * Result == Fibonacci(x)
            */

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                new Push(n),
                new Call(4),
                new Call("print"),
                new Return(),

                // fib
                new Initialize("n", TypeEnum.Integer),
                new Push("n", ValueAccessModes.LocalVariableReference),
                new Push(0),
                new Compare(Compare.ComparisonModes.LessThanOrEqual),
                new RelativeJumpIfFalse(3),
                new Push(0),
                new Return(),
                new Push("n", ValueAccessModes.LocalVariableReference),
                new Push(1),
                new Compare(Compare.ComparisonModes.Equal),
                new RelativeJumpIfFalse(3),
                new Push(1),
                new Return(),
                new Push("n", ValueAccessModes.LocalVariableReference),
                new Push(2),
                new BinaryOperation(BinaryOperation.Operations.Subtraction),
                new Call(4),
                new Push("n", ValueAccessModes.LocalVariableReference),
                new Push(1),
                new BinaryOperation(BinaryOperation.Operations.Subtraction),
                new Call(4),
                new BinaryOperation(BinaryOperation.Operations.Addition),
                new Return()
                ));
            return process;
        }

        [TestMethod]
        public void RecursiveFunctionCallByAddress_Fibonacci1()
        {
            // Test recursive native calls

            for (int i = 0; i <= 10; ++i)
            {
                Assert.AreEqual(Fibonacci(i).ToString(), CreateAndRunFibonacci(i).StandardOutput);
            }
        }
    }
}
