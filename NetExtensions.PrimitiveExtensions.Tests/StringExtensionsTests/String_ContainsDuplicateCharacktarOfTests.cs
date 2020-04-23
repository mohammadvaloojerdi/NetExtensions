using FluentAssertions;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.StringExtensionsTests
{
    public class String_ContainsDuplicateCharacktarOfTests
    {
        [Theory]
        [InlineData("abca", 'a')]
        [InlineData("1231", '1')]
        [InlineData("@#!@", '@')]
        public void Should_Be_Able_To_Identify_Strings_With_Duplicate_Specific_Characktar(
            string input, char characktar)
        {
            var result = input.ContainsDuplicateCharacktarOf(characktar);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("abc", 'a')]
        [InlineData("123", '1')]
        [InlineData("@#!", '@')]
        public void Should_Be_Able_To_Identify_Strings_Without_Duplicate_Specific_Characktar(
            string input, char characktar)
        {
            var result = input.ContainsDuplicateCharacktarOf(characktar);

            result.Should().BeFalse();
        }
    }
}