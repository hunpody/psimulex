using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VapeTeam.Psimulex.Compiler.Tests
{
    /// <summary>
    /// Summary description for BugFixTests
    /// </summary>
    [TestClass]
    public class BugFixTests
    {
        public BugFixTests()
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
        public void MemberCallOnFunctionAntlrErrorFixedTest()
        {
            string src =
            @"
void main()
{
	print(fv().First);
}

List fv()
{
	List l;
	l.AddToEnd(10);
	return l;
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"10", result);
        }

        [TestMethod]
        public void TestGenAt_2008__október_27_22_38_38()
        {
            string src =
            @"
void main()
{
	print(fv()[0].ToString());
}

List fv()
{
	List l;
	List k;
	k.AddToEnd(10);
	l.addtoend(k);
	return l;
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"(10)", result);
        }



        [TestMethod]
        public void TestGenAt_2008__október_27_22_38_50()
        {
            string src =
            @"
void main()
{
	print(fv()[0].First.ToString());
}

List fv()
{
	List l;
	List k;
	k.AddToEnd(10);
	l.addtoend(k);
	return l;
}
";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"10", result);
        }
    }
}
