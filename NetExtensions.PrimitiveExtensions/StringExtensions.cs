namespace NetExtensions.PrimitiveExtensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string input)
        {
            return input != null && input.Equals(string.Empty);
        }
    }
}