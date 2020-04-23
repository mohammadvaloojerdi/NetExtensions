using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.StringExtensionsTests
{
    public class String_ContainsUppercaseLetterTests
    {
        [Theory]
        [InlineData("A")]
        [InlineData("Abc")]
        [InlineData("aBc")]
        [InlineData("abC")]
        public void Should_Return_True_On_Strings_That_Contains_Uppercase_Letter(string input)
        {
            var result = input.ContainsUppercaseLetter();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("a")]
        [InlineData("abc")]
        [InlineData("123")]
        public void Should_Return_False_On_Strings_Without_Uppercase_Letter(string input)
        {
            var result = input.ContainsUppercaseLetter();

            result.Should().BeFalse();
        }
    }
}