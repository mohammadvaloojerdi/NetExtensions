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
        public void Should_Be_Able_To_Identify_Strings_With_Lowercase_Letter(string input)
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
        public void Should_Be_Able_To_Identify_Strings_Without_Lowercase_Letter(string input)
        {
            var result = input.ContainsLowercaseLetter();

            result.Should().BeFalse();
        }
    }
}