using System.Linq;

namespace NetExtensions.ExtensionMethods
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

        public static bool IsNotNullOrEmpty(this string input)
        {
            return !input.IsNullOrEmpty();
        }

        public static bool ContainsLowercaseLetter(this string input)
        {
            return input.IsNotNullOrEmpty() && input.Any(char.IsLower);
        }

        public static bool ContainsUppercaseLetter(this string input)
        {
            return input.IsNotNullOrEmpty() && input.Any(char.IsUpper);
        }

        public static bool ContainsDigit(this string input)
        {
            return input.IsNotNullOrEmpty() && input.Any(char.IsDigit);
        }

        public static bool IsNumeric(this string input)
        {
            return input.IsNotNullOrEmpty() && input.All(char.IsNumber);
        }

        public static bool ContainsDuplicateCharacktar(this string input)
        {
            return input.IsNotNullOrEmpty() && input.GroupBy(x => x).Any(x => x.Count() > 1);
        }

        public static bool ContainsDuplicateCharacktarOf(this string input, char characktar)
        {
            return input.IsNotNullOrEmpty() && input.GroupBy(x => x).Any(x => x.Key == characktar && x.Count() > 1);
        }

        public static bool ContainsWhiteSpace(this string input)
        {
            return input.IsNotNullOrEmpty() && input.Contains(" ");
        }

        public static bool ContainsSeperator(this string input, char seperator)
        {
            return input.Contains(seperator) && input.Split(seperator).Any();
        }
    }
}