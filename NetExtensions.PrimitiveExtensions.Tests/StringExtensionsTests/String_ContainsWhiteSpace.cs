using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_ContainsWhiteSpace
    {
        [Theory]
        [InlineData(" ")]
        [InlineData(" abc")]
        [InlineData("a bc")]
        [InlineData("abc ")]
        public void Should_Be_Able_To_Identify_Strings_That_Contains_WhiteSpace(string input)
        {
            var result = input.ContainsWhiteSpace();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("abc")]
        public void Should_Be_Able_To_Identify_Strings_Without_WhiteSpace(string input)
        {
            var result = input.ContainsWhiteSpace();

            result.Should().BeFalse();
        }
    }
}