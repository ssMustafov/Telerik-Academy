using PrintName;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PrintNameTest
{
    
    
    /// <summary>
    ///This is a test class for ProgramPrintHelloTestTest and is intended
    ///to contain all ProgramPrintHelloTestTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramPrintHelloTestTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for PrintHello
        ///</summary>
        [TestMethod()]
        public void PrintHelloTest()
        {
            string name = "Peter";
            string expected = "Peter";
            string actual;
            actual = Program.PrintHello(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestNumbers()
        {
            string name = "123 456";
            string expected = "123 456";
            string actual;
            actual = Program.PrintHello(name);
            Assert.AreEqual(expected, actual);
        }
    }
}
