using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_ContainsLowecaseLetterTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("aBC")]
        [InlineData("AbC")]
        [InlineData("ABc")]
        public void Should_Return_True_On_Strings_That_Contains_Lowercase_Letter(string input)
        {
            var result = input.ContainsLowercaseLetter();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("A")]
        [InlineData("ABC")]
        [InlineData("123")]
        public void Should_Return_False_On_Strings_Without_Lowercase_Letter(string input)
        {
            var result = input.ContainsLowercaseLetter();

            result.Should().BeFalse();
        }
    }
}