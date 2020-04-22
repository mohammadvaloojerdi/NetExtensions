using System.Linq;

namespace NetExtensions.PrimitiveExtensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string input)
        {
            return input != null && input.Equals(string.Empty);
        }

        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static bool ContainsLowecaseLetter(this string input)
        {
            return !input.IsNullOrEmpty() && input.Any(char.IsLower);
        }
    }
}