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

        [TestMethod]
        public void If1()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main()
{
    if (2 == 3)
    {
      print(""0"");
    }
    if (2 != 3)
    {
      print(""1"");
    }
    if (4 < 6)
    {
      print(""1"");
    }
    if (4 >= 6)
    {
      print(""1"");
    }
    if (8 > 5)
    {
      print(""1"");
    }
    if (8 <= 5)
    {
      print(""0"");
    }
    if (3 > f())
    {
      print(""1"");
    }
    if (f() > 3)
    {
      print(""0"");
    }
}

int f()
{
return 2;
}
");

            Assert.AreEqual("1111", result);
        }

        [TestMethod]
        public void MemoryTest01()
        {
            var result = Helpers.SystemHelper.CompileAndRunGetProcess(@"
for (int i=0; i<40; i++)
{
  string s = ""hello""; 
}
");
            Assert.IsTrue(VapeTeam.Psimulex.Core.Memory.Instance.AllocatedBytes == 0, string.Format("Memory leak: {0} bytes.", VapeTeam.Psimulex.Core.Memory.Instance.AllocatedBytes));
        }

        [TestMethod]
        public void MemoryTest02()
        {
            var result = Helpers.SystemHelper.CompileAndRunGetProcess(@"
for (int i=0; i<10; i++)
{
  string s = """";
  int j = intrandom(4,20);
  for (int k=0; k<j; ++k)
    s += intrandom(60,70);  
}

");

            Assert.IsTrue(VapeTeam.Psimulex.Core.Memory.Instance.AllocatedBytes == 0, string.Format("Memory leak: {0} bytes.", VapeTeam.Psimulex.Core.Memory.Instance.AllocatedBytes));
        }

        [TestMethod]
        public void MemoryTest03()
        {
            var result = Helpers.SystemHelper.CompileAndRunGetProcess(@"
string a = ""abcdefghijklmnopqrstuvwxyz"";
string b = ""11111111111111111111111111"";
string c = a.ToUpper();
string d = a + b + c;
print(GetUsedMemory());
");
            int mem = int.Parse(result.StandardOutput);

            Assert.IsTrue(mem > 52*6, string.Format("Too low memory usage. ({0} bytes)", mem));
        }

        [TestMethod]
        public void MemoryTest04()
        {
            var result = Helpers.SystemHelper.CompileAndRunGetProcess(@"
void main() {
  f();
  print(GetUsedMemory());
}

void f() {
string a = ""abcdefghijklmnopqrstuvwxyz"";
string b = ""11111111111111111111111111"";
string c = a.ToUpper();
string d = a + b + c;
}
");
            int mem = int.Parse(result.StandardOutput);

            Assert.IsTrue(mem == 0, string.Format("Function call memoryleaked: {0} bytes.", mem));
        }

        #region Generated Tests


        [TestMethod]
        public void TestGenAt_2008__szeptember_26_23_59_23()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int[] t = new int[2];
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
        public void TestGenAt_2008__szeptember_27_15_24_27_withMain()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main() {
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
        public void TestGenAt_2008__szeptember_27_15_27_50_withMain()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main() {
    for(int i = 0; i < 10; i++)
	    if( i == 5 )
		    break;
}
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

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_20_51_45()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 0;
while( i < 10 )
{
	print(i);
	i++;
}
");

            Assert.AreEqual(@"0123456789", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_27_21_18_09()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 0;
do
{
	print(i);
	++i;
}while( i < 10 );
");

            Assert.AreEqual(@"0123456789", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_21_18_09_withMain()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main() {
    int i = 0;
    do
    {
	    print(i);
	    ++i;
    }while( i < 10 );
}
");

            Assert.AreEqual(@"0123456789", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_21_18_17()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 0;
do
{
	print(i);
	++i;
}while( i < 0 );
");

            Assert.AreEqual(@"0", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_22_44_22()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
loop( int i = 0 to 10 )
{
print(i);
}
");

            Assert.AreEqual(@"012345678910", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_27_22_47_08()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
loop( char ch = 'a' to 'z' )
	print(ch);
");

            Assert.AreEqual(@"abcdefghijklmnopqrstuvwxyz", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_22_51_45()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
loop( char ch = 'A' to 'Z' )
	print(ch);
");

            Assert.AreEqual(@"ABCDEFGHIJKLMNOPQRSTUVWXYZ", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_22_52_14()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
loop( char ch = 'A' to 'z' )
	print(ch);
");

            Assert.AreEqual(@"ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_22_52_14_withMain()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main() {
    loop( char ch = 'A' to 'z' )
	    print(ch);
}
");

            Assert.AreEqual(@"ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_23_08_47()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 0;
while( i < 10 )
{
	print(i);
	++i;
}

print(""\n"");

int i = 0;
do
{
	print(i);
	i++;
}while( i < 10 );

print(""\n"");

for( int i = 0; i < 10; i++ )
	print(i);

print(""\n"");

loop( int i = 0 to 9 )
	print(i);
");

            Assert.AreEqual(@"0123456789
0123456789
0123456789
0123456789", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_27_23_08_47_withMain()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main() {
    int i = 0;
    while( i < 10 )
    {
	    print(i);
	    ++i;
    }

    print(""\n"");

    int i = 0;
    do
    {
	    print(i);
	    i++;
    }while( i < 10 );

    print(""\n"");

    for( int i = 0; i < 10; i++ )
	    print(i);

    print(""\n"");

    loop( int i = 0 to 9 )
	    print(i);
}
    ");

            Assert.AreEqual(@"0123456789
0123456789
0123456789
0123456789", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_23_10_44()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
loop( char ch = 'a' to 'z' )
	print(ch);

print(""\n"");

loop( char ch = 'A' to 'Z' )
	print(ch);
");

            Assert.AreEqual(@"abcdefghijklmnopqrstuvwxyz
ABCDEFGHIJKLMNOPQRSTUVWXYZ", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_27_23_15_44()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
loop( char ch = 'a' to 'z' )
	print(ch);

print(""\n"");

loop( char ch = 'A' to 'Z' )
	print(ch);

print(""\n"");
	
loop( char ch = 'a' to 'z' )
{
	if( ch == 'd')
		break;
	print(ch);
}

print(""\n"");
	
loop( char ch = 'A' to 'Z' )
{
	if( ch == 'D')
		break;
	print(ch);
}
");

            Assert.AreEqual(@"abcdefghijklmnopqrstuvwxyz
ABCDEFGHIJKLMNOPQRSTUVWXYZ
abc
ABC", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_27_23_18_15()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
if(true)
	print(""IF\n"");
elseif(true)
	print(""ELSEIF\n"");
else
	print(""ELSE\n"");

if(false)
	print(""IF\n"");
elseif(true)
	print(""ELSEIF\n"");
else
	print(""ELSE\n"");

if(false)
	print(""IF\n"");
elseif(false)
	print(""ELSEIF\n"");
else
	print(""ELSE\n"");
");

            Assert.AreEqual(@"IF
ELSEIF
ELSE
", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_27_23_18_15_withMain()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main() {
    if(true)
	    print(""IF\n"");
    elseif(true)
	    print(""ELSEIF\n"");
    else
	    print(""ELSE\n"");

    if(false)
	    print(""IF\n"");
    elseif(true)
	    print(""ELSEIF\n"");
    else
	    print(""ELSE\n"");

    if(false)
	    print(""IF\n"");
    elseif(false)
	    print(""ELSEIF\n"");
    else
	    print(""ELSE\n"");
}");

            Assert.AreEqual(@"IF
ELSEIF
ELSE
", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_28_18_24_20()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
list L;
L.Insert(0);
L.Insert(1);
L.Insert(2);

foreach( int i in L )
	print(i);
");

            Assert.AreEqual(@"012", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_28_19_06_53()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
list L;

for(int i = 0; i < 10; ++i)
	L.Insert(i);

foreach( int i in L )
	print(i);

print(""\n"");

iterator it=L.getiterator();
while(it.movenext())
{
	int i=it.current();
	print(i);
}
");

            Assert.AreEqual(@"0123456789
0123456789", result);
        }

        [TestMethod]
        public void TestGenAt_2008__október_21_11_07_26()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
void main()
{
}

");

            Assert.AreEqual(@"", result);
        }

        #endregion
    }
}








