using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_ContainsDigitsTests
    {
        [Theory]
        [InlineData("1ab")]
        [InlineData("a1b")]
        [InlineData("ab1")]
        [InlineData("passw0rd")]
        public void Should_Be_Able_To_Identify_Strings_That_Contains_Digits(string input)
        {
            var result = input.ContainsDigit();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("abc")]
        public void Should_Be_Able_To_Identify_Strings_Without_Digits(string input)
        {
            var result = input.ContainsDigit();

            result.Should().BeFalse();
        }
    }
}