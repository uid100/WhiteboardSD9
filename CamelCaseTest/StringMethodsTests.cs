using Microsoft.VisualStudio.TestTools.UnitTesting;
using CamelCase;

namespace CamelCaseTest
{
    [TestClass]
    public class StringMethodsTests
    {
        [TestMethod]
        public void TestCamelCase_TheCatInTheHat()
        {
            Assert.AreEqual("theCatInTheHat", StringMethods.CamelCase("The Cat In The Hat"));
        }
        [TestMethod]
        public void TestCamelCase_TheQuickBrownFoxJumpsOverTheLazyDog()
        {
            Assert.AreEqual("theQuickBrownFoxJumpsOverTheLazyDog", StringMethods.CamelCase("the quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void TestCamelCase_ERAU()
        {
            Assert.AreEqual("embryRiddleAeronauticalUniversity", StringMethods.CamelCase("Embry-Riddle Aeronautical University"));
        }
        [TestMethod]
        public void TestCamelCase_ShadowsInTheRain()
        {
            Assert.AreEqual("shadowsInTheRain", StringMethods.CamelCase("Shadows  in   the .. Rain"));
        }
        [TestMethod]
        public void TestCamelCase_Programming_101()
        {
            Assert.AreEqual("programming101", StringMethods.CamelCase("Programming 101"));
        }
        [TestMethod]
        public void TestPascalCase_TheCatInTheHat()
        {
            Assert.AreEqual("TheCatInTheHat", StringMethods.PascalCase("The Cat In The Hat"));
        }
        [TestMethod]
        public void TestPascalCase_TheQuickBrownFoxJumpsOverTheLazyDog()
        {
            Assert.AreEqual("TheQuickBrownFoxJumpsOverTheLazyDog", StringMethods.PascalCase("the quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void TestPascalCase_ERAU()
        {
            Assert.AreEqual("EmbryRiddleAeronauticalUniversity", StringMethods.PascalCase("Embry-Riddle Aeronautical University"));
        }
        [TestMethod]
        public void TestPascalCase_ShadowsInTheRain()
        {
            Assert.AreEqual("ShadowsInTheRain", StringMethods.PascalCase("Shadows  in   the .. Rain"));
        }
        [TestMethod]
        public void TestPascalCase_Programming_101()
        {
            Assert.AreEqual("Programming101", StringMethods.PascalCase("Programming 101"));
        }

    }
}
