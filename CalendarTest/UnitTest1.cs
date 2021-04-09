using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calendar.Test
{
    [TestClass()]
    public class CalendarTests
    {
        [TestMethod()]
        public void JulianDayTest_Jan15()
        {
            Assert.AreEqual(15, Calendar.JulianDay(1, 15));
        }
        [TestMethod()]
        public void JulianDayTest_Feb2()
        {
            Assert.AreEqual(33, Calendar.JulianDay(2, 2));
        }
        [TestMethod()]
        public void JulianDayTest_Mar15()
        {
            Assert.AreEqual(74, Calendar.JulianDay(3, 15));
        }
        [TestMethod()]
        public void JulianDayTest_Dec31()
        {
            Assert.AreEqual(365, Calendar.JulianDay(12, 31));
        }
    }
}
