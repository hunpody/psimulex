using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VapeTeam.Psimulex.Compiler.Tests
{
    /// <summary>
    /// Summary description for ArrayCollectionInitializerTests
    /// </summary>
    [TestClass]
    public class ArrayCollectionInitializerTests
    {
        public ArrayCollectionInitializerTests()
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
        public void TestGenAt_2008__október_29_11_39_07()
        {
            string src =
            @"
void main()
{
	List t;
	t = new List{99,88,""asdfasd"",'a',true,231.0,new int[]{100,100}};
	writeline(t);
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"(99, 88, asdfasd, a, True, 231,0, [100, 100])
", result);
        }



        [TestMethod]
        public void TestGenAt_2008__október_29_11_39_21()
        {
            string src =
            @"
void main()
{
	int[] t;
	t = new int[]{99,88,""asdfasd"",'a',true,231.0,new int[]{100,100}};
	writeline(t);
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"[99, 88, asdfasd, a, True, 231,0, [100, 100]]
", result);
        }



        [TestMethod]
        public void TestGenAt_2008__október_29_11_39_54()
        {
            string src =
            @"
void main()
{
	int[] t = new int[2*4];
	print(t.size);
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"8", result);
        }

        [TestMethod]
        public void TestGenAt_2008__október_29_10_57_38()
        {
            string src =
            @"
void main()
{
	int[] t;
	t = new int[1];
	t[0] = 99;
	//t[7] = 10;
	writeline(t);
	/*
	int[] v;
	v = new int[3];
	v[1] = 999;
	writeline(v);*/
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"[99]
", result);
        }
        [TestMethod]
        public void TestGenAt_2008__október_28_22_25_44()
        {
            string src =
            @"
void main()
{
	int[] t = new int[10];
	t[7] = 10;
	writeline(t);
	
	int[] v;
	v = new int[3];
	v[1] = 999;
	writeline(v);
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"[0, 0, 0, 0, 0, 0, 0, 10, 0, 0]
[0, 999, 0]
", result);
        }

        #endregion
    }
}
