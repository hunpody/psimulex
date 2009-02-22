using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VapeTeam.Psimulex.Compiler.Tests
{
    /// <summary>
    /// Summary description for ExceptionTests
    /// </summary>
    [TestClass]
    public class ExceptionTests
    {
        public ExceptionTests()
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
        public void IndexOutOfRangeException()
        {
            string src = 
@"void main() {
    int[] array = new int[5];
    array[26] = 5;
    print(array[11]);
}";
            try
            {
                Helpers.SystemHelper.CompileAndRun(src);
            }
            catch (VapeTeam.Psimulex.Core.Exceptions.PsimulexCoreException ex)
            {
                var rex = (VapeTeam.Psimulex.Core.Exceptions.RuntimeException)ex.InnerException;
                Assert.AreEqual(2, rex.PsimulexStackTrace.Trace.Count);
                Assert.AreEqual(3, rex.PsimulexStackTrace.Trace[0].Position.Line);
                Assert.AreEqual("main", rex.PsimulexStackTrace.Trace[0].Position.FunctionName);

                // The entry point : call main is the number 0 command.
                Assert.AreEqual(0, rex.PsimulexStackTrace.Trace[1].PC);
            }
        }

        [TestMethod]
        public void FactorialCallStackException()
        {
            string src =
@"void main() {
    print(fact(20));
}

int fact(int i) {
   // bad indexing
   if (i == 0) h[0] = 1;
   
   if (i > 0)
     return fact(i-1) * i;
   else return 1;
}
";

            try
            {
                Helpers.SystemHelper.CompileAndRun(src);
            }
            catch (VapeTeam.Psimulex.Core.Exceptions.PsimulexCoreException ex)
            {
                var rex = (VapeTeam.Psimulex.Core.Exceptions.RuntimeException)ex.InnerException;
                Assert.AreEqual(23, rex.PsimulexStackTrace.Trace.Count);
                Assert.AreEqual(7, rex.PsimulexStackTrace.Trace[0].Position.Line);
                Assert.AreEqual("fact", rex.PsimulexStackTrace.Trace[0].Position.FunctionName);
                Assert.AreEqual(10, rex.PsimulexStackTrace.Trace[1].Position.Line);
                Assert.AreEqual("fact", rex.PsimulexStackTrace.Trace[1].Position.FunctionName);
                Assert.AreEqual(10, rex.PsimulexStackTrace.Trace[2].Position.Line);
                Assert.AreEqual("fact", rex.PsimulexStackTrace.Trace[2].Position.FunctionName);
            }
        }

        [TestMethod]
        public void PsimulexStackTraceCommandPositionLocator()
        {
            string src =
@"void main() {
    a();
}

void a() {
    b();
}

void b() {
    c();
}

void c() {
    d();
}

void d() { 
    e();
}

void f() {
    h(); 
}

void e() {
    f();
}

void g() { 
   print (""g"");
   t[1]=""a"";
}

void h() {
    g();
}
";

            try
            {
                Helpers.SystemHelper.CompileAndRun(src);
            }
            catch (VapeTeam.Psimulex.Core.Exceptions.PsimulexCoreException ex)
            {
                var rex = (VapeTeam.Psimulex.Core.Exceptions.RuntimeException)ex.InnerException;
                Assert.AreEqual(10, rex.PsimulexStackTrace.Trace.Count);
                Assert.AreEqual(31, rex.PsimulexStackTrace.Trace[0].Position.Line);
                Assert.AreEqual("g", rex.PsimulexStackTrace.Trace[0].Position.FunctionName);
                Assert.AreEqual(35, rex.PsimulexStackTrace.Trace[1].Position.Line);
                Assert.AreEqual("h", rex.PsimulexStackTrace.Trace[1].Position.FunctionName);
                Assert.AreEqual(22, rex.PsimulexStackTrace.Trace[2].Position.Line);
                Assert.AreEqual("f", rex.PsimulexStackTrace.Trace[2].Position.FunctionName);
                Assert.AreEqual(26, rex.PsimulexStackTrace.Trace[3].Position.Line);
                Assert.AreEqual("e", rex.PsimulexStackTrace.Trace[3].Position.FunctionName);
                Assert.AreEqual(18, rex.PsimulexStackTrace.Trace[4].Position.Line);
                Assert.AreEqual("d", rex.PsimulexStackTrace.Trace[4].Position.FunctionName);
                Assert.AreEqual(14, rex.PsimulexStackTrace.Trace[5].Position.Line);
                Assert.AreEqual("c", rex.PsimulexStackTrace.Trace[5].Position.FunctionName);
                Assert.AreEqual(10, rex.PsimulexStackTrace.Trace[6].Position.Line);
                Assert.AreEqual("b", rex.PsimulexStackTrace.Trace[6].Position.FunctionName);
                Assert.AreEqual(6, rex.PsimulexStackTrace.Trace[7].Position.Line);
                Assert.AreEqual("a", rex.PsimulexStackTrace.Trace[7].Position.FunctionName);
                Assert.AreEqual(2, rex.PsimulexStackTrace.Trace[8].Position.Line);
                Assert.AreEqual("main", rex.PsimulexStackTrace.Trace[8].Position.FunctionName);
            }
        }
    }
}
