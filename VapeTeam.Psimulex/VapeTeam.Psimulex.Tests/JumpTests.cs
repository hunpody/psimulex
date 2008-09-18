using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VapeTeam.Psimulex.Core.Commands;

namespace VapeTeam.Psimulex.Tests
{
    /// <summary>
    /// Summary description for JumpTests
    /// </summary>
    [TestClass]
    public class JumpTests
    {
        public JumpTests()
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
        public void SimpleJumpOver()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push("A"),
                    new Call("print"),

                    new Push("B"),
                    new Call("print"),

                    new Jump(9),

                    new Push("C"),
                    new Call("print"),

                    new Push("D"),
                    new Call("print"),

                    new Push("E"),
                    new Call("print"),

                    new Push("F"),
                    new Call("print")
                ));

            Assert.AreEqual("ABEF", process.StandardOutput);
        }

        [TestMethod]
        public void RelativeJumpOver()
        {
            VapeTeam.Psimulex.Core.Process process2 = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push("A"),
                    new Call("print"),

                    new Push("B"),
                    new Call("print"),

                    new Jump(1, true),
                    new Jump(5, true),

                    new Push("C"),
                    new Call("print"),

                    new Push("D"),
                    new Call("print"),

                    new Push("E"),
                    new Call("print"),

                    new Push("F"),
                    new Call("print")
                ));

            Assert.AreEqual("ABEF", process2.StandardOutput);
        }

        [TestMethod]
        public void SimpleJumps()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push("A"),
                    new Call("print"),

                    new Push("B"),
                    new Call("print"),

                    new Jump(10),

                    new Push("C"),
                    new Call("print"),

                    new Push("D"),
                    new Call("print"),

                    new Jump(17),

                    new Push("E"),
                    new Call("print"),

                    new Push("F"),
                    new Call("print"),

                    new Push("G"),
                    new Call("print"),

                    new Jump(7),

                    new Push("H"),
                    new Call("print")

                ));

            // A B Jump10 E F G Jump7 D Jump17 H

            Assert.AreEqual("ABEFGDH", process.StandardOutput);
        }

        [TestMethod]
        public void RelativeJumps()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push("A"),
                    new Call("print"),

                    new Push("B"),
                    new Call("print"),

                    new RelativeJump(6),

                    new Push("C"),
                    new Call("print"),

                    new Push("D"),
                    new Call("print"),

                    new RelativeJump(8),

                    new Push("E"),
                    new Call("print"),

                    new Push("F"),
                    new Call("print"),

                    new Push("G"),
                    new Call("print"),

                    new RelativeJump(-9),

                    new Push("H"),
                    new Call("print")

                ));

            // A B Jump10 E F G Jump7 D Jump17 H

            Assert.AreEqual("ABEFGDH", process.StandardOutput);
        }

        [TestMethod]
        public void ConditionalJump1()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(                
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(
                    
                    new Push("X"),
                    new Call("print"),

                    new Push(0),
                    new Initialize("i"),

                    new Push("i", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.PostfixIncrement),

                    new Push("A"),
                    new Call("print"),

                    new Jump(14),

                    new Push("B"),
                    new Call("print"),

                    new Push("C"),
                    new Call("print"),

                    new Jump(17),

                    new Push("D"),
                    new Call("print"),

                    new Jump(9),

                    new Push("E"),
                    new Call("print"),

                    // Here we simulate a loop condition i < 5
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push(5),
                    new Compare(Compare.ComparisonModes.LessThan),
                    new JumpIfTrue(4),

                    new Push("X"),
                    new Call("print")

                ));

            // X, i=0, ++i, A, Jump14, D, Jump9, B, C, Jump17, E, Jump4 if i<5 

            /*
             * The program in pseudo:
             * 
             * print("X");
             * 
             * i=0;
             * do { 
             *      ++i;
             *      print("A");
             *      goto _L14;
             *   label _L9:
             *      print "B";
             *      print "C";
             *      goto _L17;
             *   label _L14:
             *      print "D";
             *      goto _L9;
             *   label _L17:
             *      print "E";
             * } while (i < 5);
             * 
             * print "X";
             * 
             */

            Assert.AreEqual("XADBCEADBCEADBCEADBCEADBCEX", process.StandardOutput);
        }

        [TestMethod]
        public void RelativeConditionalJump1()
        {
            VapeTeam.Psimulex.Core.Process process = Helpers.SystemHelper.CreateMachineAndRunProgram(
                VapeTeam.Psimulex.Core.Factories.ProgramBuilder.Create().Add(

                    new Push("X"),
                    new Call("print"),

                    new Push(0),
                    new Initialize("i"),

                    new Push("i", ValueAccessModes.LocalVariable),
                    new UnaryOperation(UnaryOperation.Operations.PostfixIncrement),

                    new Push("A"),
                    new Call("print"),

                    new RelativeJump(6), //8

                    new Push("B"),
                    new Call("print"),

                    new Push("C"),
                    new Call("print"),

                    new RelativeJump(4),  //13

                    new Push("D"),
                    new Call("print"),

                    new RelativeJump(-7), //16

                    new Push("E"),
                    new Call("print"),

                    // Here we simulate a loop condition i < 5
                    new Push("i", ValueAccessModes.LocalVariable),
                    new Push(5),
                    new Compare(Compare.ComparisonModes.LessThan),
                    new RelativeJumpIfTrue(-18),

                    new Push("X"),
                    new Call("print")

                ));

            // X, i=0, ++i, A, Jump14, D, Jump9, B, C, Jump17, E, Jump4 if i<5 

            /*
             * The program in pseudo:
             * 
             * print("X");
             * 
             * i=0;
             * do { 
             *      ++i;
             *      print("A");
             *      goto _L14;
             *   label _L9:
             *      print "B";
             *      print "C";
             *      goto _L17;
             *   label _L14:
             *      print "D";
             *      goto _L9;
             *   label _L17:
             *      print "E";
             * } while (i < 5);
             * 
             * print "X";
             * 
             */

            Assert.AreEqual("XADBCEADBCEADBCEADBCEADBCEX", process.StandardOutput);
        }
    }
}
