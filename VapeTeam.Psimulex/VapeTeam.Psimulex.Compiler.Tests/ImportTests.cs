using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Compiler.Tests.Helpers;
using System.IO;

namespace VapeTeam.Psimulex.Compiler.Tests
{
    [TestClass]
    public class ImportTests
    {
        public ImportTests()
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
        public void ExistingCircuitImport()
        {
            TestFileHandler.CreateTestFiles();

            string src =
            @"
import ""src\\in.psi"";
void main()
{
wr(""almacsek"");
}

void fv(int a)
{
	return;
}
";

            var result = Helpers.CompilerProxy.CompileResult(src);
            Assert.AreEqual(result.CompilationUnitList[0].CompilerMessages.Warnings.Count, 0);
            Assert.AreEqual(result.CompilationUnitList[0].CompilerMessages.Errors.Count, 0);
            Assert.AreEqual(result.CompilationUnitList[1].CompilerMessages.Warnings.Count, 0);
            Assert.AreEqual(result.CompilationUnitList[1].CompilerMessages.Errors.Count, 0);

            TestFileHandler.DeleteTestFiles();
        }

        [TestMethod]
        public void NotExistingImport()
        {
            TestFileHandler.CreateTestFiles();

            string src =
            @"
import ""nixez.psi"";
void main()
{
wr(""almacsek"");
}

void fv(int a)
{
	return;
}
";

            var result = Helpers.CompilerProxy.CompileResult(src);
            Assert.AreEqual(result.CompilationUnitList[0].CompilerMessages.Warnings.Count, 0);
            Assert.AreEqual(result.CompilationUnitList[0].CompilerMessages.Errors.Count, 1);

            TestFileHandler.DeleteTestFiles();
        }

        [TestMethod]
        public void ImportFunctionNameCollision()
        {
            TestFileHandler.CreateTestFiles();

            string src =
            @"
import ""src\\in1.psi"";
void main()
{
wr(""almacsek"");
}

void fv(int a)
{
	return;
}
";

            var result = Helpers.CompilerProxy.CompileResult(src);
            Assert.AreEqual(result.CompilationUnitList[0].CompilerMessages.Warnings.Count, 0);
            Assert.AreEqual(result.CompilationUnitList[0].CompilerMessages.Errors.Count, 0);
            Assert.AreEqual(result.CompilationUnitList[1].CompilerMessages.Warnings.Count, 1);
            Assert.AreEqual(result.CompilationUnitList[1].CompilerMessages.Errors.Count, 0);

            TestFileHandler.DeleteTestFiles();
        }
        
    }
}
