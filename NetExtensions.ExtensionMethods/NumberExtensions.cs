using System;

namespace NetExtensions.ExtensionMethods
{
    // TODO : Find Better Way Than Convert To Dynamic
    public static class NumberExtensions
    {
        public static bool IsOdd<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return (dynamic)number % 2 != 0;
        }

        public static bool IsEven<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return !number.IsOdd();
        }

        public static bool IsPositive<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return (dynamic)number >= 0;
        }

        public static bool IsNegative<T>(this T number) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return !number.IsPositive();
        }

        public static bool IsLessThan<T>(this T number, T numberToCompare) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return (dynamic)number < (dynamic)numberToCompare;
        }

        public static bool IsLessThanOrEqualTo<T>(this T number, T numberToCompare) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return (dynamic)number <= (dynamic)numberToCompare;
        }

        public static bool IsGreaterThan<T>(this T number, T numberToCompare) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return (dynamic)number > (dynamic)numberToCompare;
        }

        public static bool IsGreaterThanOrEqualTo<T>(this T number, T numberToCompare) where T : struct, IComparable, IComparable<T>, IConvertible
        {
            return (dynamic)number >= (dynamic)numberToCompare;
        }
    }
}