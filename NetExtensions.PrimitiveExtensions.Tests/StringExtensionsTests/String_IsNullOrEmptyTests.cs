using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_IsNullOrEmptyTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Should_Be_Able_To_Identify_Null_Or_Empty_Strings(string input)
        {
            var result = input.IsNullOrEmpty();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("abc")]
        [InlineData("123")]
        public void Should_Be_Able_To_Identify_Non_Null_Or_Empty_Strings(string input)
        {
            var result = input.IsNullOrEmpty();

            result.Should().BeFalse();
        }
    }
}