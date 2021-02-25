using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySort;
using System.Linq;

namespace ArraySortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //int[] testArray = { 5,4,8,7,6,15,98,0,55,-88,98};
            int[] testArray = { 4, 5, 8, 3, 4 };
            int[] sorted = { 3, 4, 4, 5, 8 };

            Assert.IsTrue(sorted.SequenceEqual(Arrays.IntegerSort(testArray)));
        }
    }
}
