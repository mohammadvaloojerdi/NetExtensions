using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_IsNullOrEmptyTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Should_Return_True_On_Null_Or_Empty_Strings(string input)
        {
            var result = input.IsNullOrEmpty();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("abc")]
        [InlineData("123")]
        public void Should_Return_False_On_Non_Null_Or_Empty_Strings(string input)
        {
            var result = input.IsNullOrEmpty();

            result.Should().BeFalse();
        }
    }
}