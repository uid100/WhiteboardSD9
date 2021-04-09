using System;

namespace Calendar
{
    public class Calendar
    {
        public static int JulianDay(int mon, int day)
        {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };

            for (int i = 0; i < mon; i++)
            {
                day += months[i];
            }
            return day;
        }

        public static string MmmYyyy(DateTime dt) => dt.ToString("MMM yyyy");

        public static bool IsLeapYear(DateTime dt) => dt.Year % 4 == 0;

        public static int DaysThisMonth(DateTime dt)
        {
            switch (dt.Month)
            {
                case 2:
                    return IsLeapYear(dt) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
            }
            return 31;
        }
        public static string cal(DateTime dt)
        {
            int nDays = DaysThisMonth(dt);
            DateTime firstDay = new DateTime(year: dt.Year, month: dt.Month, day: 1);

            string calendar = "Su Mo Tu We Th Fr Sa\n";

            int d = 0, i = 0;
            while (d < nDays)
            {
                if (d < 7 && i < (int)firstDay.DayOfWeek)
                    calendar += "   ";
                else
                    calendar += $"{++d,2}{ (i % 7 == 6 ? '\n' : ' ')}";
                i++;
            }
            return calendar + "\n";
        }

        static string Cal_Year( int yr = 2021)
        {
            string calendar = "";
            for (int mo = 0; mo < 12; mo++)
            {
                DateTime dt = new DateTime(year: yr, month: mo + 1, day: 1);
                calendar += $"      {MmmYyyy(dt)}\n";
                calendar += cal(dt) + '\n';
            }

            return calendar;
        }
    }
}
