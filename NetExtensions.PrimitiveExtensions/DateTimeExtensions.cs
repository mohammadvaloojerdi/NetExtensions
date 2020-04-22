using System;

namespace NetExtensions.PrimitiveExtensions
{
    public static class DateTimeExtensions
    {
        public static bool IsPast(this DateTime dateTime, IClock clock)
        {
            return dateTime < clock.Now();
        }
    }
}