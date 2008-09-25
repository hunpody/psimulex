using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for ThreadTests
    /// </summary>
    [TestClass]
    public class ThreadTests
    {
        public ThreadTests()
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

        /// <summary>
        /// It requires a scheduler to pass.
        /// </summary>
        [TestMethod]
        public void CreateThread()
        {
            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push(4),
                    new Call("create_thread"),
                    new CallMethod("Start"),
                    new Jump(6),
                    new Push("2"),
                    new Call("print"),
                    new Push("B"),
                    new Call("print")));

            Assert.AreEqual(2, process.Threads.Count);
            Assert.IsTrue(
                process.StandardOutput == "2BB" ||
                process.StandardOutput == "B2B");
        }

        [TestMethod]
        public void CreateThread2()
        {
            var program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    new Push(16),
                    new Call("create_thread"),
                    new CallMethod("Start"),
                    new Push(16),
                    new Call("create_thread"),
                    new CallMethod("Start"),
                    new Push(16),
                    new Call("create_thread"),
                    new CallMethod("Start"),
                    new Push(16),
                    new Call("create_thread"),
                    new CallMethod("Start"),
                    new Push(16),
                    new Call("create_thread"),
                    new CallMethod("Start"),
                    new Jump(18),
                    new Push("B"),
                    new Call("print"),
                    new Push("B"),
                    new Call("print"));

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(2, program);

            Assert.AreEqual(6, process.Threads.Count);
            Assert.IsTrue(process.StandardOutput.Length == 11);

            int maximumCyclesOfTwoProcessors = process.Machine.Processors.Max(p => p.Cycles);
            var process2 = Helpers.SystemHelper.CreateMachineAndRunProgram(1, program);
            Assert.IsTrue(process2.Machine.Processors[0].Cycles > 1.5 * maximumCyclesOfTwoProcessors);

            var process3 = Helpers.SystemHelper.CreateMachineAndRunProgram(4, program);
            int maximumCyclesOf4Processor = process3.Machine.Processors.Max(p => p.Cycles);
            Assert.IsTrue(process2.Machine.Processors[0].Cycles > 1.80 * maximumCyclesOf4Processor);

            // Test if too much processors doesn't help in this situation
            var process4 = Helpers.SystemHelper.CreateMachineAndRunProgram(16, program);
            var process5 = Helpers.SystemHelper.CreateMachineAndRunProgram(64, program);

            Assert.IsTrue(process4.Machine.Processors.Max(p => p.Cycles) == process5.Machine.Processors.Max(p => p.Cycles));
            var maxCycles = process4.Machine.Processors.Max(p => p.Cycles);
            Assert.IsTrue(process5.Machine.Processors.TrueForAll(p => p.Cycles == maxCycles));
        }

        [TestMethod]
        public void CreateThread3()
        {
            var program =
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(0),
                new Initialize("i"),
                new Push(5),
                new Call("create_thread"),
                new CallMethod("Start"),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Push(1),
                new Compare(Compare.ComparisonModes.LessThan),
                new ConditionalJump(15, false),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Push(1),
                new BinaryOperation(BinaryOperation.Operations.Addition),
                new Assign(),
                new Jump(5),
                new Push("OK"),
                new Call("print"));

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            //Assert.AreEqual(2, process.Threads.Count);

            Assert.AreEqual("OKOK", process.StandardOutput);

            var process2 = Helpers.SystemHelper.CreateMachineAndRunProgram(8, program);

            Assert.AreEqual("OKOK", process2.StandardOutput);

            Assert.IsTrue(process.Machine.Processors.Max(p => p.Cycles) > 2.2 * process2.Machine.Processors.Max(p => p.Cycles));

            Assert.IsTrue(process2.Machine.Processors.Count(p => p.CurrentThread != null && p.CurrentThread.Id == 1) <= 1);
            Assert.IsTrue(process2.Machine.Processors.Count(p => p.CurrentThread != null && p.CurrentThread.Id == 2) <= 1);
        }

        [TestMethod]
        public void ScheduleSimpleProgramHasNoOverhead()
        {
            // Assuem that Push's operation cost is 1
            var program =
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(0),
                new Push(1),
                new Push(2),
                new Push(3),
                new Push(4),
                new Push(5));

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            Assert.IsTrue(9 > process.Machine.Processors[0].Cycles);
        }
    }
}
