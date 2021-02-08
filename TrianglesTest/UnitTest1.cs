using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace TrianglesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AreaOfATriangle_simple()
        {
            Assert.AreEqual(6, Triangles.Program.AreaOfATriangle(2, 6));
            Assert.AreEqual(10, Triangles.Program.AreaOfATriangle(4, 5));
            Assert.AreEqual(50, Triangles.Program.AreaOfATriangle(4, 25));
        }
    }
}
