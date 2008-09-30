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


        [TestMethod]
        public void TestGenAt_2008__szeptember_30_13_46_15()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
queue q;
q.insert(1);
q.insert(2);
q.insert(3);
writeline(q);
queue z = -q;
writeline(z);
queue p = z + z;
writeline(p);

write(p.first);
write(p.last);
write(p.dequeue());
writeline("""");
writeline(p);
writeline(p.size);
writeline(p.isempty);

pqueue pq;
pq = q;

q.dequeue();
writeline(q);

writeline(pq);
writeline(""Min: "" + pq.min);
writeline(""Max: "" + pq.max);

pq.insert(10,10);
pq.insert(10,9);
pq.insert(5,100);

writeline(pq);
writeline(""GetMax: "" + pq.getmax());
writeline(""GetMin: "" + pq.getmin());


writeline(pq);
writeline(pq.count);
writeline(pq.isEmpty);


queue a;
queue b;
writeline(a==b);

pqueue c;
c.enqueue(0,1);
pqueue d;
d.enqueue(1,10);
writeline(a==b);
writeline(a<=b);
writeline(a<b);

");

            Assert.AreEqual(@">In> 3, 2, 1 >Out>
>In> 1, 2, 3 >Out>
>In> 1, 2, 3, 1, 2, 3 >Out>
3 1 3 
>In> 1, 2, 3, 1, 2 >Out>
5
False
>In> 1, 2, 3, 1 >Out>
>Max> ( Key: 0, Value: 2 ), ( Key: 0, Value: 1 ), ( Key: 0, Value: 3 ), ( Key: 0, Value: 2 ), ( Key: 0, Value: 1 ) >Min>
Min: 1
Max: 2
>Max> ( Key: 10, Value: 9 ), ( Key: 10, Value: 10 ), ( Key: 5, Value: 100 ), ( Key: 0, Value: 2 ), ( Key: 0, Value: 1 ), ( Key: 0, Value: 3 ), ( Key: 0, Value: 2 ), ( Key: 0, Value: 1 ) >Min>
GetMax: 9
GetMin: 1
>Max> ( Key: 10, Value: 10 ), ( Key: 5, Value: 100 ), ( Key: 0, Value: 2 ), ( Key: 0, Value: 1 ), ( Key: 0, Value: 3 ), ( Key: 0, Value: 2 ) >Min>
6
False
True
True
True
False
", result);
        }




        [TestMethod]
        public void TestGenAt_2008__szeptember_30_15_37_34()
        {
            var result = Helpers.SystemHelper.CompileAndRun(@"
list l;
stack s;
write(s.isempty);
writeline(l.isempty);

l.insert(10);
s = l;
writeline(l);
s.push(100);
writeline(s);

set h;
s.push(10);
h = s;
write(h);
write(s);
write(l);

set a;
set b;
a.insert(10);
a.insert(10);
a.insert(20);
a.insert(20);
a.insert(200);

b.insert(20);
b.insert(100);
b.insert(1);

writeLine(a);
writeLine(b);

writeline(a+b);

set d;
set e;

d.insert(1);
d.insert(7);
d.insert(3);
d.insert(2);

writeline(d);
d.remove(7);
writeline(d);

e.insert(2);
e.insert(5);
e.insert(4);

writeline(d/e);


");

            Assert.AreEqual(@"True True
(First( 10 )Last)
[Bottom[ 10, 100 >Top>
{ 10, 100 } [Bottom[ 10, 100, 10 >Top> (First( 10 )Last) { 10, 20, 200 }
{ 20, 100, 1 }
{ 10, 20, 200, 100, 1 }
{ 1, 7, 3, 2 }
{ 1, 3, 2 }
{ 1, 3 }
", result);
        }




        #endregion
    }
}
