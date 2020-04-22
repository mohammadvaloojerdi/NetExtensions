using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_ContainsDuplicateCharacktarTests
    {
        [Theory]
        [InlineData("aab")]
        [InlineData("aba")]
        [InlineData("112")]
        public void Should_Be_Able_To_Identify_Strings_With_Duplicate_Characktar(string input)
        {
            var result = input.ContainsDuplicateCharacktar();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("abc")]
        [InlineData("123")]
        public void Should_Be_Able_To_Identify_Strings_Without_Duplicate_Characktar(string input)
        {
            var result = input.ContainsDuplicateCharacktar();

            result.Should().BeFalse();
        }
    }
}