using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for BasicCoreTest
    /// </summary>
    [TestClass]
    public class BasicCoreTest
    {
        public BasicCoreTest()
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
        public void MachineSetup()
        {
            MachineBuilder machineBuilder = new MachineBuilder();
            Machine machine = machineBuilder.CreateMachine(1, 1024);
            Assert.AreEqual(1, machine.Processors.Count);

            Assert.AreEqual(1024, machine.MemorySize);
        }

        private class TestLibrary : VapeTeam.Psimulex.Core.Libraries.ILibrary
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        [TestMethod]
        public void LibraryCall()
        {
            var machine = VapeTeam.Psimulex.Core.Factories.MachineBuilder.Instance.CreateMachine(1, 16);

            machine.System.InstallLibrary(new TestLibrary());

            var program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(1),
                new Push(2),
                new Call("add"),
                new Call("print"));

            var process = machine.System.Load(program);

            machine.System.Run(process);

            Assert.AreEqual("3", process.StandardOutput);
        }
        [TestMethod]
        public void PerformanceTest1()
        {
            var program = VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(0),
                new Initialize("i"),
                new Push("i", ValueAccessModes.LocalVariableReference),
                new Push("i", ValueAccessModes.LocalVariable),
                new Push(1),
                new BinaryOperation(BinaryOperation.Operations.Addition),
                new Assign(true),
                new Push(3000),
                new Compare(Compare.ComparisonModes.LessThan),
                new JumpIfTrue(2));

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            
            sw.Start();

            var process = Helpers.SystemHelper.CreateMachineAndRunProgram(program);

            sw.Stop();

            int numberOfCycles = process.Machine.Processors[0].Cycles;

            double cyclesPerSecond = (double)numberOfCycles / sw.Elapsed.TotalSeconds;

            Assert.IsTrue(cyclesPerSecond > 100000, string.Format("The virtual machine is too slow: only {0:0.00} MHz.", cyclesPerSecond / 1000000));
        }
    }
}
