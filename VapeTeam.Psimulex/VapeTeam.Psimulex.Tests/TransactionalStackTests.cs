using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Tests.Helpers;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for TransactionalStackTests
    /// </summary>
    [TestClass]
    public class TransactionalStackTests
    {
        public TransactionalStackTests()
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
        public void TransactionalStack1()
        {
            var stack = new TransactionalStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.IsFalse(stack.IsEmpty);
            var t = stack.BeginTransaction();
            Assert.AreEqual(3, t.Top);
            Assert.AreEqual(3, t.Pop());
            Assert.AreEqual(2, t.Pop());
            Assert.AreEqual(1, t.Pop());
            Assert.AreEqual(3, stack.Top);
            Assert.IsTrue(t.IsEmpty);
            Assert.IsFalse(stack.IsEmpty);
            t.Commit();
            Assert.IsTrue(stack.IsEmpty);
            Helpers.AssertionHelpers.AssertThrows<Exception>(() => stack.Pop());
            Helpers.AssertionHelpers.AssertThrows<Exception>(() => t.Pop());

            stack = new TransactionalStack<int>();
            t = stack.BeginTransaction();
            t.Push(1);
            t.Push(2);
            t.Push(3);
            Assert.IsTrue(stack.IsEmpty);
            Assert.IsFalse(t.IsEmpty);
            Assert.AreEqual(3, t.Top);
            Assert.AreEqual(3, t.Pop());
            t.Commit();
            Assert.AreEqual(2, stack.Top);

            stack = new TransactionalStack<int>();
            t = stack.BeginTransaction();
            t.Push(1);
            t.Push(2);
            t.Push(3);
            t.Commit();
            var verifier = stack.BeginTransaction();
            Assert.AreEqual(3, verifier.Pop());
            Assert.AreEqual(2, verifier.Pop());
            Assert.AreEqual(1, verifier.Pop());
            var modifier = stack.BeginTransaction();
            modifier.Pop();
            modifier.Pop();
            modifier.Pop();
            modifier.Push(5);
            modifier.Push(6);
            modifier.Push(7);
            modifier.Commit();
            Assert.AreEqual(7, stack.Pop());
            Assert.AreEqual(6, stack.Pop());
            Assert.AreEqual(5, stack.Pop());
        }

        [TestMethod]
        public void TransactionalStack2()
        {
            var stack = new TransactionalStack<int>();
            for (int i = 0; i < 1000; ++i)
            {
                stack.Push(i);
            }

            for (int i = 0; i < 100; ++i)
            {
                var t = stack.BeginTransaction();
                t.Pop();
                t.Push(-1);
                t.Commit();
                Assert.AreEqual(-1, stack.Top);
                t = stack.BeginTransaction();
                t.Pop();
                t.Commit();
                Assert.AreEqual(998 - i, stack.Top);
                t = stack.BeginTransaction();
                t.Clear();
                Assert.IsTrue(t.IsEmpty);
                Assert.IsFalse(stack.IsEmpty);
                t.Rollback();
                Assert.IsFalse(t.IsEmpty);
                Assert.IsFalse(stack.IsEmpty);
                Assert.AreEqual(998 - i, t.Top);
                Assert.AreEqual(998 - i, stack.Top);
            }

            var ts = stack.BeginTransaction();
            ts.Clear();
            ts.Commit();
            Assert.IsTrue(ts.IsEmpty);
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void TransactionalStack3()
        {
            var stack = new TransactionalStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var t1 = stack.BeginTransaction();
            var t2 = stack.BeginTransaction();

            t1.Push(4);
            t2.Push(5);

            t1.Commit();
            AssertionHelpers.AssertThrows<Psimulex.Core.Exceptions.InvalidTransactionException>(() => t2.Commit());

            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());

            var transactions = new List<StackTransaction<int>>();
            for (int i = 0; i < 100; ++i)
            {
                transactions.Add(stack.BeginTransaction());
            }

            transactions[22].Push(9);
            transactions[22].Commit();

            transactions.TrueForAll(t => t.Status == TransactionStates.Invalid || t.Status == TransactionStates.Committed);
            transactions.ForEach(t => AssertionHelpers.AssertThrows<Psimulex.Core.Exceptions.InvalidTransactionException>(() => t.Commit()));
        }

        [TestMethod]
        public void SpecialStackOperations1()
        {
            Psimulex.Core.Stack<int> stack = new VapeTeam.Psimulex.Core.Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var poppedList = stack.Pop(3).ToArray();

            Assert.AreEqual(3, poppedList[0]);
            Assert.AreEqual(2, poppedList[1]);
            Assert.AreEqual(1, poppedList[2]);
            Assert.IsTrue(stack.IsEmpty);
        }
    }
}
