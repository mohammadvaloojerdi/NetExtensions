using System;

namespace NetExtensions.PrimitiveExtensions
{
    public static class NumberExtensions
    {
        public static bool IsOdd<T>(this T number) where T : struct, IComparable, IComparable<T>,
            IConvertible, IEquatable<T>, IFormattable
        {
            return Convert.ToInt32(number) % 2 != 0;
        }
    }
}