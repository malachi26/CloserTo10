using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloserTo10;

namespace CloserTo10_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(13, 15);
            Assert.AreEqual(result, 13);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(13, 13);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
             var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(3, 5);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestMethod4()
        {
             var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(13, 7);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(-3, -5);
            Assert.AreEqual(result, -3);
        }

        [TestMethod]
        public void ELippertTest1()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(int.MinValue + 10, 0);
            Assert.AreEqual(result, 0);
        }


        [TestMethod]
        public void MaxA_BCloser()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(int.MaxValue, 0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void MinA_BCloser()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(int.MinValue, 0);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void MaxAndMin_Zero()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(int.MinValue, int.MaxValue);
            Assert.AreEqual(result, int.MaxValue);
        }

        [TestMethod]
        public void MinAMinB()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(int.MinValue, int.MinValue);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void MinMinus10AndZero_Zero()
        {
            var Test = new CloserTo10.Program();
            var result = Test.Closer_LylesMug(int.MaxValue, 0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void User2023861_test1()
        {
            var Test = new CloserTo10.Program();
            var result = Test.user2023861_Closer(-10, -10);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void User2023861_test2()
        {
            var Test = new CloserTo10.Program();
            var result = Test.user2023861_Closer(-12, -10);
            Assert.AreEqual(result, -10);
        }

        [TestMethod]
        public void User2023861_test3()
        {
            var Test = new CloserTo10.Program();
            var result = Test.user2023861_Closer(10, -10);
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void User2023861_test4()
        {
            var Test = new CloserTo10.Program();
            var result = Test.user2023861_Closer(30, -10);
            Assert.AreEqual(result, 0);
        }
    }
}
