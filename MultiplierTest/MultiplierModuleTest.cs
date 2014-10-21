using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixMultiplier;

namespace MultiplierTest
{
    [TestClass]
    public class MultiplierModuleTest
    {
        [TestMethod]
        public void FullShortTest()
        {
            long A = (long)Math.Pow(2, 32)-103832, B = A-20620;
            int width = 32, truncated = 25;
            Multiplier mul = new Multiplier(A, B, width, truncated);
            double actual = mul.ShortMultiply();
            double expected = mul.Multiply();
            Assert.AreEqual(expected, actual, Math.Pow(2, width), "Incorrect short multiplication");
        }
    }
}
