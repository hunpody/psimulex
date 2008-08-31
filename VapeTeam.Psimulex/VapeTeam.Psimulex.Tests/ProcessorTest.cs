using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for ProcessorTest
    /// </summary>
    [TestClass]
    public class ProcessorTest
    {
        public ProcessorTest()
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
        public void ProcessorInterrupt()
        {
            VapeTeam.Psimulex.Core.Processor processor = new VapeTeam.Psimulex.Core.Processor();
            int numberOfTimesInterrupted = 0;
            processor.SetupPeriodicalTimeInterrupt(100,
                new EventHandler<VapeTeam.Psimulex.Core.InterruptRequestEventArgs>((o, e) => numberOfTimesInterrupted++));

            for (int i=0; i<=1000; ++i)
                processor.Cycle();

            Assert.AreEqual(10, numberOfTimesInterrupted);
        }
    }
}
