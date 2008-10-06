using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Commands;
using VapeTeam.Psimulex.Core.Types;
using VapeTeam.Psimulex.Core;

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

        #region Fibonacci-test

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

        #endregion

        [TestMethod]
        public void UserDefinedFunctions1()
        {
            Program program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(2),
                new Push(3),
                new Call("add"),
                new Call("print")
                );

            UserDefinedFunction addFunction = new UserDefinedFunction 
            { 
                Name = "add", 
                Parameters = new List<VariableDescriptor> { 
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "a" 
                    },
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "b" 
                    }
                },
                ReturnValue = new VariableDescriptor 
                {
                    Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }
                },
                Commands = new CommandList 
                {
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Addition),
                    new Return(true),
                }
            };

            program.AddFunction(addFunction);

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            Assert.AreEqual("5", process.StandardOutput);
        }

        [TestMethod]
        public void UserDefinedFunctions2()
        {
            Program program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(2),
                new Push(3),
                new Call("subtract"),
                new Call("print")
                );

            UserDefinedFunction addFunction = new UserDefinedFunction
            {
                Name = "subtract",
                Parameters = new List<VariableDescriptor> { 
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "a" 
                    },
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "b" 
                    }
                },
                ReturnValue = new VariableDescriptor
                {
                    Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }
                },
                Commands = new CommandList 
                {
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Subtraction),
                    new Return(true),
                }
            };

            program.AddFunction(addFunction);

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            Assert.AreEqual("-1", process.StandardOutput);
        }

        [TestMethod]
        public void UserDefinedFunctions3()
        {
            Program program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(2),
                new Push(3),
                new Call("multiply", 2),
                new Call("print"),
                new Push(2),
                new Push(3),
                new Push(4),
                new Call("multiply", 3),
                new Call("print")
                );

            UserDefinedFunction mulFunction1 = new UserDefinedFunction
            {
                Name = "multiply",
                Parameters = new List<VariableDescriptor> { 
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "a" 
                    },
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "b" 
                    }
                },
                ReturnValue = new VariableDescriptor
                {
                    Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }
                },
                Commands = new CommandList 
                {
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Multiplication),
                    new Return(true),
                }
            };

            UserDefinedFunction mulFunction2 = new UserDefinedFunction
            {
                Name = "multiply",
                Parameters = new List<VariableDescriptor> { 
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "a" 
                    },
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "b" 
                    },
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "c" 
                    }
                },
                ReturnValue = new VariableDescriptor
                {
                    Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }
                },
                Commands = new CommandList 
                {
                    new Push("a", ValueAccessModes.LocalVariable),
                    new Push("b", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Multiplication),
                    new Push("c", ValueAccessModes.LocalVariable),
                    new BinaryOperation(BinaryOperation.Operations.Multiplication),
                    new Return(true),
                }
            };

            program.AddFunction(mulFunction1);
            program.AddFunction(mulFunction2);

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            Assert.AreEqual("624", process.StandardOutput);
        }

        private string GetPsimulexFactorial(int n)
        {
            Program program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(n),
                new Call("factor"),
                new Call("print")
                );

            UserDefinedFunction factor = new UserDefinedFunction
            {
                Name = "factor",
                Parameters = new List<VariableDescriptor> { 
                    new VariableDescriptor 
                    { 
                        Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }, 
                        Name = "n" 
                    }
                },
                ReturnValue = new VariableDescriptor
                {
                    Type = new TypeIdentifier { TypeEnum = TypeEnum.Integer }
                },
                Commands = new CommandList 
                {
                    new Push("n", ValueAccessModes.LocalVariable),
                    new Push(1),
                    new Compare(Compare.ComparisonModes.LessThanOrEqual),
                    new RelativeJumpIfFalse(3),
                    new Push(1),
                    new Return(true),
                    new Push("n", ValueAccessModes.LocalVariable),
                    new Push("n", ValueAccessModes.LocalVariable),
                    new Push(1),
                    new BinaryOperation(BinaryOperation.Operations.Subtraction),
                    new Call("factor"),
                    new BinaryOperation(BinaryOperation.Operations.Multiplication),
                    new Return(true),
                }
            };

            program.AddFunction(factor);

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            return process.StandardOutput;
        }

        private int GetFactorial(int n)
        {
            if (n <= 1) return 1;
            else return n * GetFactorial(n - 1);
        }

        [TestMethod]
        public void UserDefinedFunctions4_Factorial()
        {
            for (int i = 0; i < 10; ++i)
                Assert.AreEqual(GetFactorial(i).ToString(), GetPsimulexFactorial(i));
        }


    }
}
