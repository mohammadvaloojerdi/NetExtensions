using NetExtensions.PrimitiveExtensions.Exceptions;
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

        public static bool IsInFuture(this DateTime dateTime, IClock clock)
        {
            return !dateTime.IsPast(clock);
        }

        public static int CalculateAge(this DateTime birthDate, IClock clock)
        {
            if (birthDate.IsInFuture(clock))
                throw new InvalidBirthDateException();

            var age = clock.Now().Year - birthDate.Year;

            // Go back to the year the person was born in case of a leap year
            if (birthDate.Date > clock.Now().AddYears(-age)) age--;

            return age;
        }

        public static int PastHoursFromNow(this DateTime dateTime, IClock clock)
        {
            return (int) (dateTime - clock.Now()).TotalHours;
        }
    }
}