using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_IsNumericTests
    {
        [Theory]
        [InlineData("1")]
        [InlineData("12")]
        [InlineData("123")]
        public void Should_Be_Able_To_Identify_Numeric_Strings(string input)
        {
            var result = input.IsNumeric();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("abc")]
        [InlineData("ab1")]
        [InlineData("1b1")]
        public void Should_Be_Able_To_Identify_Non_Numeric_Strings(string input)
        {
            var result = input.IsNumeric();

            result.Should().BeFalse();
        }
    }
}