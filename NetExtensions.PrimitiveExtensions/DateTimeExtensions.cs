using System;

namespace NetExtensions.PrimitiveExtensions
{
    public static class DateTimeExtensions
    {
        public static bool IsPast(this DateTime dateTime, IClock clock)
        {
            return dateTime < clock.Now();
        }

        public static bool IsToday(this DateTime dateTime, IClock clock)
        {
            return dateTime.Date == clock.Now().Date;
        }

        public static bool IsBefore(this DateTime dateTime, DateTime dateTimeToCompare)
        {
            return dateTime < dateTimeToCompare;
        }
    }
}