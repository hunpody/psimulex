using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Compiler.Tests.Helpers;

namespace VapeTeam.Psimulex.Compiler.Tests
{
    /// <summary>
    /// Summary description for HelloWorldTests
    /// </summary>
    [TestClass]
    public class ExpressionTests
    {
        public ExpressionTests()
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

        #region Generated Tests

        [TestMethod]
        public void TestGenAt_2008__szeptember_22_23_11_42()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int a;
a = 10;
a += 10;
print(a);
");

            Assert.AreEqual("20", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_23_0_36_29()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int b;
int c;
int a;
a = b = c = 20;
print(a);
print(b);
print(c);
");

            Assert.AreEqual("202020", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_12_49()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(10==10);
");

            Assert.AreEqual("True", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_12_52()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(10!=10);
");

            Assert.AreEqual("False", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_14_47()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(10<10);
");

            Assert.AreEqual("False", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_14_51()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(10<=10);
");

            Assert.AreEqual("True", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_14_55()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(10>10);
");

            Assert.AreEqual("False", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_14_59()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(10>=10);
");

            Assert.AreEqual("True", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_27_02()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 0;
i += 1;
i = ( ( 10 + i - 11 + i) * 10 / 10 ) - 1;
print(i);
");

            Assert.AreEqual("0", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_27_20()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 10 * 10;
print(i);
");

            Assert.AreEqual("100", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_27_27()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 20 / 10;
print(i);
");

            Assert.AreEqual("2", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_27_30()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 20 - 10;
print(i);
");

            Assert.AreEqual("10", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_27_32()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 20 + 10;
print(i);
");

            Assert.AreEqual("30", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_27_42()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 20 % 10;
print(i);
");

            Assert.AreEqual("0", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_28_05()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 20 % 11;
print(i);
");

            Assert.AreEqual("9", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_28_11()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 20 % 15;
print(i);
");

            Assert.AreEqual("5", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_28_13()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 20 % 19;
print(i);
");

            Assert.AreEqual("1", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_28_30()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(12 % 2 == 0);
");

            Assert.AreEqual("True", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_17_45_32()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print((int)10);
");

            Assert.AreEqual("10", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_19_19_21()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print((int)'1');
");

            Assert.AreEqual("1", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_19_24_36()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print((int)'9');
");

            Assert.AreEqual("9", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_19_24_53()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print((int)""120"");
");

            Assert.AreEqual("120", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_23_20_59_16()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print((int)'a');
");

            Assert.AreEqual("97", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_22_22_15()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print(true || true);
");

            Assert.AreEqual("True", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_23_22_22_58()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print( true || 10 / 0 == 0);
");

            Assert.AreEqual("True", result);
        }





        [TestMethod]
        public void TestGenAt_2008__szeptember_23_22_28_33()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print( false || false);
");

            Assert.AreEqual("False", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_22_28_37()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
print( false || true);
");

            Assert.AreEqual("True", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_22_29_31()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int a = 10;
int b = 10;
int c;
a += b -= c = 5;
print (a);
");

            Assert.AreEqual("15", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_23_22_31_05()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int a = 10;
int b = 10;
int c;
a += b -= c = 5;
print (a);
");

            Assert.AreEqual("15", result);
        }

        #endregion
    }
}
