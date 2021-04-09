using System;

namespace Clock
{
    public class Clock
    {
        public static double AngleDiff(int hour, int minute)
        {
            double minuteAngle = (double)minute / 60.0 * 360.0;
            double hourAngle = (double)hour / 12.0 * 360.0; // + (minAngle * 360.0 / 12.0);

            double diff = Math.Abs(minuteAngle - hourAngle);
            return (diff <= 180) ? diff : 360 - diff;
        }
    }
}
