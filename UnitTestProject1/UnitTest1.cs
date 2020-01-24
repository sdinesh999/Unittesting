using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperation1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test()
        {
           Class1 tc = new Class1();
            int res = tc.Addition(10, 10);
            Assert.AreEqual(res, 20);
            Assert
        }
        [TestMethod]
        public void Substraction_Test()
        {
            Class1 tc = new Class1();
            int res = tc.Substraction(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Multiply_Test()
        {
            Class1 tc = new Class1();
            double res = tc.Multiply(10, 5);
            Assert.AreEqual(res, 50);
        }
        [TestMethod]
        public void Divide_Test()
        {
            Class1 tc = new Class1();
            double res = tc.Divide(10, 10);
            Assert.AreEqual(res, 1);
        }
    }
}
