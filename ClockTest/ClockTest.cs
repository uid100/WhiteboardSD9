using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clock;

namespace Clock.Test
{
    [TestClass]
    public class ClockTest
    {
        [TestMethod]
        public void AngleDiffTest_645()
        {
            Assert.AreEqual(90, Clock.AngleDiff(6, 45));
        }
        [TestMethod]
        public void AngleDiffTest_900()
        {
            Assert.AreEqual(90, Clock.AngleDiff(6, 45));
        }
        [TestMethod]
        public void AngleDiffTest_540()
        {
            Assert.AreEqual(90, Clock.AngleDiff(5, 40));
        }
    }
}
