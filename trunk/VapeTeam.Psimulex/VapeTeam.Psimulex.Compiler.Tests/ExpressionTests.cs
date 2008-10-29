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

        [TestMethod]
        public void PostfixPlusPlus()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int a=10;
print(a++);
print(a);
");
            Assert.AreEqual("1011", result);
        }

        [TestMethod]
        public void PrefixPlusPlus()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int a=10;
print(--a);
print(a);
");
            Assert.AreEqual("99", result);
        }

        [TestMethod]
        public void ArraySizeAsExpression()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int[] a = new int[(7+5)*2];
print(a[0]);
print(a.Size);
");
            Assert.AreEqual("024", result);
        }

        [TestMethod]
        public void Reference_01()
        {
            string src =
            @"
void main()
{
	int i = 10;	
	write(i);
	int &a = i;	
	write(a);
	write(i);
	i = 1;
	write(a);
	write(i);
}

";
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"10 10 10 1 1 ", result);
        }

        [TestMethod]
        public void Reference_02()
        {
            string src =
            @"
import ""in.psi"";
void main()
{
	int[] a = new int[5];
    int& a3 = a[3];
    a3 = 5;
    write(a3 == a[3]);
    a[3] = 7;
    write(a3 == a[3]);
    ++a[3];
    write(a3 == a[3]);  
    ++a3; 
    write(a3 == a[3]);  
    write(a3);
    write(a[3]);
}

";
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"True True True True 9 9 ", result);
        }

        [TestMethod]
        public void Reference_03_Chain()
        {
            string src =
            @"
import ""in.psi"";
void main()
{
	int[] a = new int[5];
    int& a3 = a[3];
    int& ra3 = a3;
    ra3 = 5;
    write(a3 == a[3] && a[3] == ra3);
    a[3] = 7;
    write(a3 == a[3] && a[3] == ra3);
    ++a[3];
    write(a3 == a[3] && a[3] == ra3);  
    ++a3; 
    write(a3 == a[3] && a[3] == ra3);  
    ++ra3; 
    write(a3 == a[3] && a[3] == ra3);  
    write(a3);
    write(a[3]);
    write(ra3);
}

";
            var result = Helpers.SystemHelper.CompileAndRun(src);
            Assert.AreEqual(@"True True True True True 10 10 10 ", result);
        }

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
        public void TestGenAt_2008__szeptember_25_14_11_47()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 10;
print(------i++);
print(i);
");

            Assert.AreEqual("78", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_12_04()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 10;
print(!i++);
print(i);
");

            Assert.AreEqual("False11", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_14_30()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 10;
print((int)'a');
print(i);
");

            Assert.AreEqual("9710", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_15_37()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = (int)'a';
print((char)(i++));
print(i);
");

            Assert.AreEqual("a98", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_15_47()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = (int)'a';
print((char)(i++));
print((char)i);
");

            Assert.AreEqual("ab", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_16_08()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = (int)'a';
print(++--++--++i++);
print(i);
");

            Assert.AreEqual("9899", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_16_13()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 10;
print(++--++--++i++);
print(i);
");

            Assert.AreEqual("1112", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_16_22()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 10;
print(-++--++--++i++);
print(i);
");

            Assert.AreEqual("-1112", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_16_27()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 10;
print(!-++--++--++i++);
print(i);
");

            Assert.AreEqual("False12", result);
        }



        [TestMethod]
        public void TestGenAt_2008__szeptember_25_14_17_46()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
int i = 0;
print(!--i++);
print(-++--++--++i++);
print(i);
");

            Assert.AreEqual("True-12", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_25_17_00_03()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
	int[] t = new int[2];
	t[0] = 111;
	print(t[0]);
");

            Assert.AreEqual("111", result);
        }

        [TestMethod]
        public void TestGenAt_2008__szeptember_25_17_04_32()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
	int[] t = new int[2];
	t[0] = 111;
	t[1] = t[0];	
	print(t[1]);

");

            Assert.AreEqual("111", result);
        }

        #endregion
    }
}
