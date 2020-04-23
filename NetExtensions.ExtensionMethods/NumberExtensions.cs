using System;

namespace NetExtensions.ExtensionMethods
{
    // TODO : Find Better Way Than Convert.ToInt32(number);
    public static class NumberExtensions
    {
        public static bool IsOdd<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return Convert.ToInt32(number) % 2 != 0;
        }

        public static bool IsEven<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return !number.IsOdd();
        }

        public static bool IsPositive<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return Convert.ToInt32(number) >= 0;
        }

        public static bool IsNegative<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return !number.IsPositive();
        }
    }
}