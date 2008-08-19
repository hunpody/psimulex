using VapeTeam.Psimulex.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace VapeTeam.Psimulex.Tests
{
    
    
    /// <summary>
    ///This is a test class for MachineTest and is intended
    ///to contain all MachineTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MachineTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Machine Constructor
        ///</summary>
        [TestMethod()]
        public void MachineConstructorTest()
        {
            Machine target = new Machine();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddProcessor
        ///</summary>
        [TestMethod()]
        public void AddProcessorTest()
        {
            Machine target = new Machine(); // TODO: Initialize to an appropriate value
            Processor processor = null; // TODO: Initialize to an appropriate value
            target.AddProcessor(processor);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void LoadTest()
        {
            Machine target = new Machine(); // TODO: Initialize to an appropriate value
            Program program = null; // TODO: Initialize to an appropriate value
            //target.Load(program);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Run
        ///</summary>
        [TestMethod()]
        public void RunTest()
        {
            Machine target = new Machine(); // TODO: Initialize to an appropriate value
            Program program = null; // TODO: Initialize to an appropriate value
            //target.Run(program);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MemorySize
        ///</summary>
        [TestMethod()]
        public void MemorySizeTest()
        {
            Machine target = new Machine(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.MemorySize = expected;
            actual = target.MemorySize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
