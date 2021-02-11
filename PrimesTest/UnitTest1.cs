using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primes;
namespace PrimesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPrime_17()
        {
            Assert.AreEqual(true, PrimeNumbers.IsPrime(17));
        }
        [TestMethod]
        public void TestIsPrime_4()
        {
            Assert.AreEqual(false, PrimeNumbers.IsPrime(4));
        }
        [TestMethod]
        public void TestIsPrime_8()
        {
            Assert.AreEqual(false, PrimeNumbers.IsPrime(8));
        }
        [TestMethod]
        public void TestIsPrime_9()
        {
            Assert.AreEqual(false, PrimeNumbers.IsPrime(9));
        }

        [TestMethod]
        public void TestSumOfPrimes_8()
        {            
            Assert.AreEqual(17, PrimeNumbers.SumOfPrimes(8));
        }
        [TestMethod]
        public void TestSumOfPrimes_6()
        {
            Assert.AreEqual(10, PrimeNumbers.SumOfPrimes(6));
        }
        [TestMethod]
        public void TestSumOfPrimes_2()
        {
            Assert.AreEqual(2, PrimeNumbers.SumOfPrimes(2));
        }
        [TestMethod]
        public void TestSumOfPrimes_0()
        {
            Assert.AreEqual(0, PrimeNumbers.SumOfPrimes(0));
        }
        [TestMethod]
        public void TestSumOfPrimes_1()
        {
            Assert.AreEqual(0, PrimeNumbers.SumOfPrimes(1));
        }
        [TestMethod]
        public void TestSumOfPrimes_neg1()
        {
            Assert.AreEqual(0, PrimeNumbers.SumOfPrimes(-1));
        }
        [TestMethod]
        public void TestSumOfPrimes_4()
        {
            Assert.AreEqual(5, PrimeNumbers.SumOfPrimes(4));
        }

    }
}
