﻿using System;
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

        [TestMethod]
        public void Swap_01()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main()
{
  int a = 2;
  int b = 3;
  swap(&a, &b);
  write(a); write(b);
}
");

            Assert.AreEqual(@"3 2 ", result);
        }


        #region Generated Tests

        [TestMethod]
        public void TestGenAt_2008__október_21_12_11_41()
        {
            string src =
            @"
void main()
{
}

";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"", result);
        }

        [TestMethod]
        public void TestGenAt_2008__október_21_12_18_23()
        {
            string src =
            @"
void main()
{
	for(int i = 1; i <= 10; ++i)
	{
		for(int j = 1; j <= 10; ++j)
		{
			write(i * j);
			if( i * j < 10 )
				print(""  "");
		}
		writeline("""");
	}
}

";
            Helpers.PsiNodHelpers.ParentTestOne(src);
            Helpers.PsiNodHelpers.ParentTestOne(src);
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"1   2   3   4   5   6   7   8   9   10 
2   4   6   8   10 12 14 16 18 20 
3   6   9   12 15 18 21 24 27 30 
4   8   12 16 20 24 28 32 36 40 
5   10 15 20 25 30 35 40 45 50 
6   12 18 24 30 36 42 48 54 60 
7   14 21 28 35 42 49 56 63 70 
8   16 24 32 40 48 56 64 72 80 
9   18 27 36 45 54 63 72 81 90 
10 20 30 40 50 60 70 80 90 100 
", result);
        }

        #endregion
    }
}
