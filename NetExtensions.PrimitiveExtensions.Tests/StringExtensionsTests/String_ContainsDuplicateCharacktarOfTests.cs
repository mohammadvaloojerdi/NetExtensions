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
        public void Should_Return_True_On_Strings_That_Contains_Duplicate_Characktar(string input, char characktar)
        {
            var result = input.ContainsDuplicateCharacktarOf(characktar);

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("abc", 'a')]
        [InlineData("123", '1')]
        [InlineData("@#!", '@')]
        public void Should_Return_False_On_Strings_Without_Duplicate_Characktar(string input, char characktar)
        {
            var result = input.ContainsDuplicateCharacktarOf(characktar);

            result.Should().BeFalse();
        }
    }
}