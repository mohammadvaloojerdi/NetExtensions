using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_IsEmptyTests
    {
        [Fact]
        public void Should_Be_Able_To_Identify_Empty_Strings()
        {
            var input = "";

            var result = input.IsEmpty();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(null)]
        [InlineData(" ")]
        [InlineData("abc")]
        public void Should_Be_Able_To_Identify_Non_Empty_Strings(string input)
        {
            var result = input.IsEmpty();

            result.Should().BeFalse();
        }
    }
}