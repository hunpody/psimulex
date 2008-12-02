using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Historization;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for HistorizationTests
    /// </summary>
    [TestClass]
    public class HistorizationTests
    {
        public HistorizationTests()
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
        public void HistoricalStack01()
        {
            History history = new History();
            var hs = new HistoricalStack<int>(history);
            hs.Push(1);
            hs.Push(2);
            hs.Push(3);
            hs.Push(4);
            hs.Pop();
            hs.Pop();
            hs.Push(5);
            hs.Push(6);

            // This is 8 event.

            // Revert back to fifth moment.
            history.WindTo(5);
            Assert.AreEqual(3, hs.Top);
            history.WindTo(7);
            Assert.AreEqual(5, hs.Top);
            history.WindTo(5);
            Assert.AreEqual(3, hs.Top);
            history.WindTo(7);
            Assert.AreEqual(5, hs.Top);
            history.WindTo(0);
            Assert.IsTrue(hs.IsEmpty);
            history.WindTo(8);
            Assert.AreEqual(6, hs.Top);
            Assert.AreEqual(4, hs.Count);

            history.WindTo(2);
            Assert.AreEqual(2, hs.Top);

            // Test multiple reversion
            history.WindTo(2);
            Assert.AreEqual(2, hs.Top);
            history.WindTo(2);
            Assert.AreEqual(2, hs.Top);

            // Check if it reverts back to the current state
            hs.Push(7);
            Assert.AreEqual(7, hs.Top);
            Assert.AreEqual(5, hs.Count);

            history.WindTo(5);
            history.NewBranch();
            Assert.AreEqual(3, hs.Count);
            Assert.AreEqual(3, hs.Top);
            hs.Push(10);
            Assert.AreEqual(10, hs.Top);
            Assert.AreEqual(4, hs.Count);
        }

        [TestMethod]
        public void HistoricalStack02()
        {
            History history = new History();
            var hs = new HistoricalStack<int>(history);
            var hs2 = new HistoricalStack<int>(history);
            var hs3 = new HistoricalStack<int>(history);

            for (int i = 0; i < 30; ++i)
            {
                switch (i % 3)
                {
                    case 0:
                        hs.Push(i);
                        break;
                    case 1:
                        hs2.Push(i);
                        break;
                    case 2:
                        hs3.Push(i);
                        break;
                }
            }

            // Take snapshot 
            int snapShot = history.TakeSnapshot();

            hs2.Push(hs.Pop());
            hs2.Push(hs3.Pop());
            hs.Push(hs2.Pop());
            hs.Push(hs2.Pop());
            hs3.Push(hs.Pop());
            hs3.Push(hs.Pop());

            // Take another snapshot
            int ss2 = history.TakeSnapshot();

            // Revert to first snapshot
            history.RevertToSnapshot(snapShot);
            Assert.AreEqual(10, hs.Count);
            Assert.AreEqual(10, hs2.Count);
            Assert.AreEqual(10, hs3.Count);

            // Revert to second snapshot
            history.RevertToSnapshot(ss2);
            Assert.AreEqual(9, hs.Count);
            Assert.AreEqual(10, hs2.Count);
            Assert.AreEqual(11, hs3.Count);
        }

        private class IntHolder
        {
            public int IP { get; set; }
        }

        [TestMethod]
        public void HistoricalProperty01()
        {
            History history = new History();
            IntHolder ih = new IntHolder();
            ih.IP = 5;

            HistoricalProperty<int> ip = new HistoricalProperty<int>(history, ih, "IP");

            int s1 = history.TakeSnapshot();

            HistoricalStack<int> stack = new HistoricalStack<int>(history);

            ip.Value = 6;
            ip.Value = 7;
            stack.Push(ip.Value);

            int s2 = history.TakeSnapshot();

            stack.Push(++ip.Value);
            stack.Push(ip.Value = stack.Pop() * stack.Pop());

            int s3 = history.TakeSnapshot();

            history.RevertToSnapshot(s1);

            Assert.AreEqual(ih.IP, 5);
            Assert.IsTrue(stack.IsEmpty);

            history.RevertToSnapshot(s2);

            Assert.AreEqual(7, ih.IP);
            Assert.AreEqual(7, stack[0]);

            history.RevertToSnapshot(s3);

            Assert.AreEqual(56, ih.IP);
            Assert.AreEqual(56, stack[0]);

            // Once again
            history.RevertToSnapshot(s1);

            Assert.AreEqual(ih.IP, 5);
            Assert.IsTrue(stack.IsEmpty);

            history.RevertToSnapshot(s2);

            Assert.AreEqual(7, ih.IP);
            Assert.AreEqual(7, stack[0]);

            history.RevertToSnapshot(s3);

            Assert.AreEqual(56, ih.IP);
            Assert.AreEqual(56, stack[0]);
        }

        [TestMethod]
        public void Historization_01()
        {
            int s1 = GlobalHistory.Instance.TakeSnapshot();

            var process =
                Helpers.SystemHelper.CreateMachineAndRunProgram(VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                new Push(5),
                new Push(10),
                new Push(20),
                new BinaryOperation(BinaryOperation.Operations.Addition),
                new BinaryOperation(BinaryOperation.Operations.Subtraction),
                new Call("print")));

            int s2 = GlobalHistory.Instance.TakeSnapshot();

            Assert.AreEqual("-25", process.StandardOutput);

            GlobalHistory.Instance.RevertToSnapshot(s1);
        }
    }
}
