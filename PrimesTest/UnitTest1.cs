using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primes;
namespace PrimesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod17()
        {
            Assert.AreEqual(true, PrimeNumbers.IsPrime(17));
        }
    }
}
