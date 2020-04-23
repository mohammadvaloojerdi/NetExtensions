using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_ContainsSeperatorTests
    {
        [Theory]
        [InlineData("1,2,3", ',')]
        [InlineData("a;b;c", ';')]
        [InlineData("a&b&c", '&')]
        [InlineData(",1,2,3,", ',')]
        [InlineData(";123;", ';')]
        [InlineData("a&bc&", '&')]
        public void Should_Return_True_On_Strings_With_Specific_Seperator(string input, char seperator)
        {
            var result = input.ContainsSeperator(seperator);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("123", ',')]
        [InlineData("abc", ';')]
        public void Should_Return_False_On_Strings_Without_Specific_Seperator(string input, char seperator)
        {
            var result = input.ContainsSeperator(seperator);

            result.Should().BeFalse();
        }
    }
}