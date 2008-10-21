using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VapeTeam.Psimulex.Compiler.Tests
{
    /// <summary>
    /// Summary description for AdvancedTests
    /// </summary>
    [TestClass]
    public class PsiNodeTest
    {
        public PsiNodeTest()
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
        public void ParentTestOneTest()
        {
            Helpers.PsiNodHelpers.ParentTestOne(@"

void main()
{
	writeLine(add(10,10));
	itn j = 10;
	inc(j);
	writeLine(j);
	writeline(factor(10));
}

int add(int a, int b)
{
	return a + b;
}

void inc( int & i)
{
	i++;
}

int factor(int n)
{
	writeline(n);
	if( n == 0 )
		return 1;
	else
		return n * factor(n-1);
}");
        }

        [TestMethod]
        public void ParentTestTwoTest()
        {
            Helpers.PsiNodHelpers.ParentTestTwo(@"

void main()
{
	writeLine(add(10,10));
	itn j = 10;
	inc(j);
	writeLine(j);
	writeline(factor(10));
}

int add(int a, int b)
{
	return a + b;
}

void inc( int & i)
{
	i++;
}

int factor(int n)
{
	writeline(n);
	if( n == 0 )
		return 1;
	else
		return n * factor(n-1);
}");
        }
    }
}
