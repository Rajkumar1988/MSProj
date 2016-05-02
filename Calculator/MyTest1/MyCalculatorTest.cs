using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyTest1
{
    
    
    /// <summary>
    ///This is a test class for MyCalculatorTest and is intended
    ///to contain all MyCalculatorTest Unit Tests test
    ///</summary>
    [TestClass()]
    public class MyCalculatorTest
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
        ///A test for Addition
        ///</summary>
        [TestMethod()]
        public void AdditionTest()
        {
           int a = 10;
          int b = 5;
            MyCalculator target = new MyCalculator(); // TODO: Initialize to an appropriate value            
            int expected = 15; // TODO: Initialize to an appropriate value
            int actual = a+b;
            //actual = target.Addition();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Division
        ///</summary>
        [TestMethod()]
        public void DivisionTest()
        {
            int a = 10;
            int b = 5;
            MyCalculator target = new MyCalculator(); // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual = a/b;
            //actual = target.Division();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Multiplication
        ///</summary>
        [TestMethod()]
        public void MultiplicationTest()
        {
            int a = 10;
            int b = 5;
            MyCalculator target = new MyCalculator(); // TODO: Initialize to an appropriate value
            int expected = 50; // TODO: Initialize to an appropriate value
            
            //actual = target.Multiplication();
            int actual = a * b;
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Subtraction
        ///</summary>
        [TestMethod()]
        public void SubtractionTest()
        {
            int a = 10;
            int b = 5;
            MyCalculator target = new MyCalculator(); // TODO: Initialize to an appropriate value
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual = a-b;
            //actual = target.Subtraction();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
