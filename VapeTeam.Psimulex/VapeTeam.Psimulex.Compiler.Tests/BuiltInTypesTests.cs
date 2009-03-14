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


        [TestMethod]
        public void PriorityQueue_1()
        {
            string src =
            @"
pqueue p;
p.Insert(1,2);
p.Insert(4,5);
pqueue q;
q.Insert(4,5);
q.Insert(1,2);
write(p==q);
q.Insert(9,0);
write(p==q);
q.Clear();
q = p;
write(q==p);
p.removemax();
writeline(q==p);
write((list)(p + 5 + 6 + 7));
";
            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(src));
            Assert.AreEqual(@"True False True False
(2, 5, 6, 7) ", result);
        }



        [TestMethod]
        public void PriorityQueue_2()
        {
            string src =
            @"
pqueue p;
p.enqueue(2,5);
p.enqueue(5,9);
p.enqueue(-3,155);
write(p[0] + "" "" + p[2]);
write(p.min == 155);
write(p.max == 9);
write(p.size == 3);
p.removemax();
write(p);
p.removemin();
write(p);
write(p[0]);

";
            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(src));
            Assert.AreEqual(@"9 155 True True True <(Priority: 2, Value: 5), (Priority: -3, Value: 155)> <(Priority: 2, Value: 5)> 5 ", result);
        }


        [TestMethod]
        public void PriorityQueue_3()
        {
            string src =
            @"
pqueue p;
p.Insert(1,2);
p.Insert(3,4);
pqueue q = p;
q.removemin();
write(p==q);
q = q + p;
writeline(q);
write(p);
";

            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(src));
            Assert.AreEqual(@"False <(Priority: 3, Value: 4), (Priority: 3, Value: 4), (Priority: 1, Value: 2)>
<(Priority: 3, Value: 4), (Priority: 1, Value: 2)> ", result);
        }

        [TestMethod]
        public void Tree_01()
        {
            string src =
            @"
tree t;
t.Add(5);
print(t.Children.Size);
print(t.Children[0].Value);
t.Children[0].Value = 4;
print(t.Children[0].Value);
t.Add(15);
t.Children.Insert(9);
t.Children[1].Add(12);
t.Value = ""8"";
print(""\n"");
print(t);

";

            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(src));
            Assert.AreEqual(@"154
8 (4, 15 (12), 9)", result);
        }

        [TestMethod]
        public void Tree_02()
        {
            string src =
            @"
tree t;
t.Add(5);
t.Add(15);
t.Children[1].Add(12);
t.Value = 8;
tree k = t;
t.Value = 10;
print(t.Value != k.Value);
tree &r = t;
t.Value = 5;
print(r.Value == t.Value);

";

            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(src));
            Assert.AreEqual(@"TrueTrue", result);
        }

        [TestMethod]
        public void Tree_03()
        {
            string src =
            @"
tree t;
t.Add(5);
t.Add(15);
t.Children[1].Add(12);
t.Value = 8;
tree k = t;
t.Value = 10;
print(t.Value != k.Value);
tree &r = t;
t.Value = 5;
print(r.Value == t.Value);

";

            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(src));
            Assert.AreEqual(@"TrueTrue", result);
        }

        [TestMethod]
        public void Tree_04_AddReferencedTree()
        {
            string src =
            @"
tree t;
t.value = 5;
t.add(1);
t.add(2);
t.add(3);
t.add(&t);
t.value = 10;
print(t.value == t.children[3].value);
t.add(&t);
t.value = 8;
print(t.value == t.children[3].value);
print(t.value == t.children[4].value);
print(t.value == t.children[4].children[3].value);

tree t;
t.value = 5;
t.add(1);
t.add(2);
t.add(3);
t.add(t);
t.value = 10;
print(t.value == t.children[3].value);
t.add(t);
t.value = 8;
print(t.value == t.children[3].value);
print(t.value == t.children[4].value);
print(t.value == t.children[4].children[3].value);

";
            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(src));
            Assert.AreEqual(@"TrueTrueTrueTrueFalseFalseFalseFalse", result);
        }

        #region Generated Tests

        [TestMethod]
        public void TestGenAt_2008__szeptember_28_23_28_17()
        {
            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(@"
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
"));

            Assert.AreEqual(@"10 20 30 40 50 60 70 80 90 100 
10, 100, 10, 10, 100
20 30 40 50 70 80 90 
100 90 80 70 60 50 40 30 20 10 
0True", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_28_23_46_01()
        {
            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(@"
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
"));

            Assert.AreEqual(@"10 20 
10 20 
10
20
20 10 True3 1 2 3 0", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_29_0_33_08()
        {
            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(@"
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
"));

            Assert.AreEqual(@"100 90 80 70 60 50 40 30 20 10 
100 90 80 70 60 50 40 30 20 10 
10 20 30 40 50 60 70 80 90 100 ", result);
        }


        [TestMethod]
        public void TestGenAt_2008__szeptember_30_13_46_15()
        {
            var result = Helpers.SystemHelper.CompileAndRun(Helpers.SystemHelper.WrapInFunction(@"
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
writeline(""GetMax: "" + pq.removemax());
writeline(""GetMin: "" + pq.removemin());


writeline(pq);
writeline(pq.count);
writeline(pq.isEmpty);

queue a;
queue b;
writeline(a==b);

"));

            Assert.AreEqual(@">1, 2, 3>
>3, 2, 1>
>3, 2, 1, 3, 2, 1>
3 1 3 
>2, 1, 3, 2, 1>
5
False
>2, 3>
<(Priority: 0, Value: 1), (Priority: 0, Value: 2), (Priority: 0, Value: 3)>
Min: 3
Max: 1
<(Priority: 10, Value: 10), (Priority: 10, Value: 9), (Priority: 5, Value: 100), (Priority: 0, Value: 1), (Priority: 0, Value: 2), (Priority: 0, Value: 3)>
GetMax: 10
GetMin: 3
<(Priority: 10, Value: 9), (Priority: 5, Value: 100), (Priority: 0, Value: 1), (Priority: 0, Value: 2)>
4
False
True
", result);
        }

        //        [TestMethod]
        //        public void TestGenAt_2008__szeptember_30_15_37_34()
        //        {
        //            var result = Helpers.SystemHelper.CompileAndRun(@"
        //list l;
        //stack s;
        //write(s.isempty);
        //writeline(l.isempty);
        //
        //l.insert(10);
        //s = l;
        //writeline(l);
        //s.push(100);
        //writeline(s);
        //
        //set h;
        //s.push(10);
        //h = s;
        //write(h);
        //write(s);
        //write(l);
        //
        //set a;
        //set b;
        //a.insert(10);
        //a.insert(10);
        //a.insert(20);
        //a.insert(20);
        //a.insert(200);
        //
        //b.insert(20);
        //b.insert(100);
        //b.insert(1);
        //
        //writeLine(a);
        //writeLine(b);
        //
        //writeline(a+b);
        //
        //set d;
        //set e;
        //
        //d.insert(1);
        //d.insert(7);
        //d.insert(3);
        //d.insert(2);
        //
        //writeline(d);
        //d.remove(7);
        //writeline(d);
        //
        //e.insert(2);
        //e.insert(5);
        //e.insert(4);
        //
        //writeline(d/e);
        //
        //
        //");

        //            Assert.AreEqual(@"True True
        //( 10 )
        //[ 10, 100 >
        //{ 10, 100 } [ 10, 100, 10 > ( 10 ) { 10, 20, 200 }
        //{ 20, 100, 1 }
        //{ 10, 20, 200, 100, 1 }
        //{ 1, 7, 3, 2 }
        //{ 1, 3, 2 }
        //{ 1, 3 }
        //", result);
        //        }




        #endregion
    }
}
