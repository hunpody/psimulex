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
    public class AdvancedTests
    {
        public AdvancedTests()
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
        public void RecursionAndReference()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"

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
            
            Assert.AreEqual(@"20
11
10
9
8
7
6
5
4
3
2
1
0
3628800
", result);
        }

        [TestMethod]
        public void ParameterPassByReferences()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main()
{
    int j = 1;
    incbyref(j);
    myprint(j);
//    incnormal(&j);
//    myprint(j);
    incnormal(j);
    myprint(j);
    myprint(j++);
    myprint(j);
}

void incbyref(int& a)
{
	++a;
}

void incnormal(int i)
{
	i++;
}

void myprint(string s)
{
    if (getoutputlength() > 0)
    {
        print("", "");
    }
    print(s);
}

");

            //Assert.AreEqual(@"2, 3, 3, 3, 4", result);
            Assert.AreEqual(@"2, 2, 2, 3", result);        
        }

    }
}
