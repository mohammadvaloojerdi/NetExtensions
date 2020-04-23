using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.StringExtensionsTests
{
    public class String_ContainsDuplicateCharacktarTests
    {
        [Theory]
        [InlineData("aab")]
        [InlineData("aba")]
        [InlineData("112")]
        public void Should_Return_True_On_Strings_That_Contains_Duplicate_Characktar(string input)
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
        public void Should_Return_False_On_Strings_Without_Duplicate_Characktar(string input)
        {
            var result = input.ContainsDuplicateCharacktar();

            result.Should().BeFalse();
        }
    }
}