using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BinaryFunctions;

namespace BinaryFunctionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random r = new Random();

            for (int i = 0; i < 12; i++)
            {
                int x = r.Next(0, 1024);
                Assert.AreEqual(Convert.ToString(x, 2), BinaryString.intToBinary(x));
            }
        }
    }
}
