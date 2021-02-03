using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace TrianglesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AreaOfATriangle_2_6()
        {
            Assert.AreEqual(6, Triangles.Program.AreaOfATriangle(2, 6));
        }
        [TestMethod]
        public void Test_AreaOfATriangle_4_5()
        {
            Assert.AreEqual(10, Triangles.Program.AreaOfATriangle(4, 5));
        }
        [TestMethod]
        public void Test_AreaOfATriangle_4_25()
        {
            Assert.AreEqual(50, Triangles.Program.AreaOfATriangle(4, 25));
        }
    }
}
