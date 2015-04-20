using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppearanceCountTest
{
    [TestClass]
    public class AppearanceCountTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = { 1, 1, 1, 1, 1 };
            int actual = AppearanceCount.CountElementAppearance(numbers,searchNumber: 2, index: 0);
            Assert.AreEqual(0, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int actual = AppearanceCount.CountElementAppearance(numbers, searchNumber: 3, index: 0);
            Assert.AreEqual(1, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] numbers = { 1, 2, 4, 7, 2 };
            int actual = AppearanceCount.CountElementAppearance(numbers, searchNumber: 2, index: 0);
            Assert.AreEqual(2, actual);
        }
    }
}
