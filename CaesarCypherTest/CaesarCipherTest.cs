using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCrypto;

namespace SimpleCryptoTest
{
    [TestClass]
    public class CaesarCipherTest
    {
        [TestMethod]
        public void EncryptionTest_1()
        {
            Assert.AreEqual("JCRRA", CaesarCipher.CharShift("Happy", 2));
            Assert.AreEqual("HAPPY", CaesarCipher.CharShift("JCRRA", -2));
        }

        [TestMethod]
        public void EncryptionTest_2()
        {
            Assert.AreEqual("JCRRA", CaesarCipher.Shift("Happy", 2));
            Assert.AreEqual("HAPPY", CaesarCipher.Shift("JCRRA", -2));
        }

        [TestMethod]
        public void EncryptionTest_Reverse()
        {
            int key = 3;
            string PlainText = "The quick brown fox jumps over the lazy dogs";
            string CipherText = CaesarCipher.CharShift(PlainText, key);

            System.Console.WriteLine(PlainText);
            System.Console.WriteLine(CipherText);
            System.Console.WriteLine(CaesarCipher.CharShift(CipherText, -key));
            System.Console.WriteLine(PlainText.ToUpper());

            Assert.AreEqual(PlainText.ToUpper(), CaesarCipher.CharShift(CipherText, -key));
        }
    }
}
