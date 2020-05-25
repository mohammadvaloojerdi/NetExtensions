using System.Collections;

namespace NetExtensions.ExtensionMethods
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty(this IEnumerable enumerable)
        {
            return enumerable != null && !enumerable.GetEnumerator().MoveNext();
        }

        public static bool IsNotEmpty(this IEnumerable enumerable)
        {
            return !enumerable.IsEmpty();
        }
    }
}