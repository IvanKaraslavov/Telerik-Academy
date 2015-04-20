using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SayHelloTest
{
    [TestClass]
    public class SayHelloTest
    {
        [TestMethod]
        public void TestMethodIvan()
        {
            string result = SayHello.WriteName("Ivan");
            Assert.AreEqual("Hello, Ivan!", result);
        }
        [TestMethod]
        public void TestMethodPeter()
        {
            string result = SayHello.WriteName("Peter");
            Assert.AreEqual("Hello, Peter!", result);
        }
        [TestMethod]
        public void TestMethodNikolay()
        {
            string result = SayHello.WriteName("Nikolay");
            Assert.AreEqual("Hello, Nikolay!", result);
        }
    }
}
