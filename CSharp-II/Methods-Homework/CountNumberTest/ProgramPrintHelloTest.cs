using CountNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CountNumberTest
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
        ///A test for CountNumberIsInArray
        ///</summary>
        [TestMethod()]
        public void BasicTest()
        {
            int[] array = { 4, -7, 20, 5, 0, -1, 3, 4, 4, 5, 0, 5, 5 };
            int number = 4;
            int expected = 3;
            int actual;
            actual = Program_Accessor.CountNumberIsInArray(array, number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestZeroElements()
        {
            int[] array = {};
            int number = 5;
            int expected = 0;
            int actual;
            actual = Program_Accessor.CountNumberIsInArray(array, number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestNumberNotInArray()
        {
            int[] array = { 7, 1, 3, 3, 2, 1 };
            int number = 9;
            int expected = 0;
            int actual;
            actual = Program_Accessor.CountNumberIsInArray(array, number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestEqualElements()
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = 2;
            }

            int number = 2;
            int expected = 10;
            int actual;
            actual = Program_Accessor.CountNumberIsInArray(array, number);
            Assert.AreEqual(expected, actual);
        }
    }
}
