using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            
            int expected = 25;
            int actual =Class1.sqr(5);
            Assert.AreEqual(expected, actual);
        }
    }
}
