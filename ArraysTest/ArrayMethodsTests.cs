using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayMethods;
using System;

namespace ArraysTest
{
    [TestClass]
    public class ArrayMethodsTests
    {
        [TestMethod]
        public void TestGetMinPos()
        {
            int[] testArray = { 3, 1, 4, 1, 5, 9, 2 };
            Assert.AreEqual( 1, ArrayClass.GetMinPos(testArray));
        }
        [TestMethod]
        public void TestRandomIntArray3()
        {
            int seed = 64;
            Random randomNumber = new Random(seed);

            int size = 3;

            int[] testArray = ArrayClass.RandomIntArray(size, seed);
            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual(testArray[i], randomNumber.Next());
            }
        }
        [TestMethod]
        public void TestRandomIntArray5()
        {
            int seed = 64;
            Random randomNumber = new Random(seed);

            int size = 5;
            int[] testArray = ArrayClass.RandomIntArray(size, seed);
            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual(testArray[i], randomNumber.Next());
            }
        }
        [TestMethod]
        public void TestRandomIntArray10()
        {
            int seed = 64;
            Random randomNumber = new Random(seed);

            int size = 10;
            int[] testArray = ArrayClass.RandomIntArray(size, seed);
            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual(testArray[i], randomNumber.Next());
            }
        }

        [TestMethod]
        public void TestSortIntArray50()
        {
            int seed = 64;
            Random randomNumber = new Random(seed);

            int size = 50;
            int[] randomArray = ArrayClass.RandomIntArray(size, seed);

            int[] arr1 = ArrayClass.SortIntArray(randomArray);
            for (int i = 0; i < size; i++)
            {
                Assert.AreNotEqual(arr1[i], randomArray[i]);
            }

            //Array.Sort(randomArray);
            //for (int i = 0; i < size; i++)
            //{
            //    Assert.AreEqual(arr1[i], randomArray[i]);
            //}
        }
    }
}
