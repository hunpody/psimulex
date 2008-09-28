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
    public class BuiltInTypesTests
    {
        public BuiltInTypesTests()
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
        public void TestGenAt_2008__szeptember_28_23_28_17()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
list L;

for(int i = 0; i < 10; ++i)
	L.Insert( ( i + 1 ) * 10 );

foreach( int i in L )
	print(i + "" "");

print(""\n"");
print(L.First);
print("", "");

print(L.Last);
print("", "");

print(L.Count);
print("", "");

L.RemoveAt(5);
print(L.PopFront());
print("", "");
print(L.PopBack());

print(""\n"");
foreach( int i in L )
	print(i + "" "");
	
L.PushFront(10);
L.PushBack(100);
L.InsertAt(5, 60);

L.Reverse();

print(""\n"");
for(int i = 0; i < L.size; ++i)
	print(L[i] + "" "");

L.Clear();
print(""\n"" + L.Length);
print(L.IsEmpty);
");

            Assert.AreEqual(@"10 20 30 40 50 60 70 80 90 100 
10, 100, 10, 10, 100
20 30 40 50 70 80 90 
100 90 80 70 60 50 40 30 20 10 
0True", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_28_23_46_01()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
queue q;

q.Insert( 10 );
q.EnQueue( 20 );

foreach( int i in q )
	print(i + "" "");

print(""\n"");
for( int i = 0; i < q.size; ++i )
	print(q[i] + "" "");
	
print(""\n"");
print(q.First);

print(""\n"");
print(q.Last);

q.reverse();
print(""\n"");
for( int i = 0; i < q.size; ++i )
	print(q[i] + "" "");

q.Delete();
print( q.isempty );

q.EnQueue(1);
q.EnQueue(2);
q.EnQueue(3);

print(q.size + "" "");
print(q.DeQueue() + "" "");
print(q.DeQueue() + "" "");
print(q.DeQueue() + "" "");
print(q.size);
");

            Assert.AreEqual(@"10 20 
10 20 
10
20
20 10 True3 1 2 3 0", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_29_0_33_08()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
stack s;

for( int i = 0; i < 10; ++i )
	s.push( ( i + 1 ) * 10 );

foreach( int i in s )
	write(i);

writeline("""");

while( !s.IsEmpty )
	write(s.pop());

for( int i = 0; i < 10; ++i )
	s.push( ( i + 1 ) * 10 );

writeline("""");
s.invert();	
while( s.size != 0)
{
	write(s.top);
	s.pop();
}
");

            Assert.AreEqual(@"10 20 30 40 50 60 70 80 90 100 
100 90 80 70 60 50 40 30 20 10 
10 20 30 40 50 60 70 80 90 100 ", result);
        }



        #endregion
    }
}
