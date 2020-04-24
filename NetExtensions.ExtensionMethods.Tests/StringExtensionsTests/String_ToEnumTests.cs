using FluentAssertions;
using System;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.StringExtensionsTests
{
    public class String_ToEnumTests
    {
        public enum Color
        {
            Blue,
            Red
        }

        [Theory]
        [InlineData("Blue", Color.Blue)]
        [InlineData("Red", Color.Red)]
        [InlineData("blue", Color.Blue)]
        [InlineData("red", Color.Red)]
        public void Should_Be_Able_To_Convert_String_To_Enum(string input, Color expected)
        {
            var result = input.ToEnum<Color>();

            result.Should().Be(expected);
        }

        [Fact]
        public void Should_Throw_On_Invalid_Input()
        {
            const string invalidInput = "Green";

            Action toEnum = () => invalidInput.ToEnum<Color>();

            toEnum.Should().Throw<ArgumentException>();
        }
    }
}