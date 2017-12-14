using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FacLib;

namespace FacTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod5()
        {
            FacClass obj = new FacClass();
            long actual = obj.FacFunc(5);
            Assert.AreEqual(120, actual);

        }

        [TestMethod]
        public void TestMethod20()
        {
            FacClass obj = new FacClass();

            long actual = obj.FacFunc(20);

            Assert.AreEqual(2432902008176640000, actual);

        }
    }
}
