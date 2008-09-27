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
    public class ProgramStructureTests
    {
        public ProgramStructureTests()
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
        public void TestGenAt_2008__szeptember_26_23_59_23()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int[2] t;
t[0] = 111;
t[1] = t[0];	
print(t[1]);

");

            Assert.AreEqual("111", result);
        }




        [TestMethod]
        public void TestGenAt_2008__szeptember_27_1_09_29()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0;i<10;i++)
{
	print(i);
}

");

            Assert.AreEqual("0123456789", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_1_11_06()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0;i<10;i++)
{
	print(i);
	break;
}

");

            Assert.AreEqual("0", result);
        }




        [TestMethod]
        public void TestGenAt_2008__szeptember_27_12_22_38()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0;i<10;i=i+1)
{
	for(int j = 0;j<10;j=j+1)
	{
		print(j);
	}
	print(i);
	print(""\n"");
}

");

            Assert.AreEqual(@"01234567890
01234567891
01234567892
01234567893
01234567894
01234567895
01234567896
01234567897
01234567898
01234567899
", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_27_12_24_01()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0;i<10;i++)
{
	for(int j = 0;j<10;j++)
	{
		print(j);
	}
	print(""\n"");
}

");

            Assert.AreEqual(@"0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
0123456789
", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_27_12_24_08()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0;i<10;++i++)
{
	for(int j = 0;j<10;j++)
	{
		print(j);
	}
	print(""\n"");
}

");

            Assert.AreEqual(@"0123456789
0123456789
0123456789
0123456789
0123456789
", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_12_24_19()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0;i<10;++i++)
{
	for(int j = 0;j<10;++j++)
	{
		print(j);
	}
	print(""\n"");
}

");

            Assert.AreEqual(@"02468
02468
02468
02468
02468
", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_15_24_19()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
if(true)
{
print(""if"");
}
elseif(false)
{
print(""elseif1"");
}
elseif(false)
{
print(""elseif2"");
}
else
{
print(""else"");
}
");

            Assert.AreEqual(@"if", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_15_24_27()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
if(false)
{
print(""if"");
}
elseif(true)
{
print(""elseif1"");
}
elseif(false)
{
print(""elseif2"");
}
else
{
print(""else"");
}
");

            Assert.AreEqual(@"elseif1", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_15_24_43()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
if(false)
{
print(""if"");
}
elseif(false)
{
print(""elseif1"");
}
elseif(true)
{
print(""elseif2"");
}
else
{
print(""else"");
}
");

            Assert.AreEqual(@"elseif2", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_27_15_24_57()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
if(false)
{
print(""if"");
}
elseif(false)
{
print(""elseif1"");
}
elseif(false)
{
print(""elseif2"");
}
else
{
print(""else"");
}
");

            Assert.AreEqual(@"else", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_15_27_50()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0; i < 10; i++)
	if( i == 5 )
		break;
");

            Assert.AreEqual(@"", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_15_28_21()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
for(int i = 0; i < 10; i++)
{
	print(i);
	if( i == 5 )
	{
		print(""break"");
		break;
	}
}
");

            Assert.AreEqual(@"012345break", result);
        }



        #endregion
    }
}








