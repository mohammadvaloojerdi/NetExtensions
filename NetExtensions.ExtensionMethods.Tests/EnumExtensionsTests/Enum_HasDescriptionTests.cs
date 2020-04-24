using FluentAssertions;
using System.ComponentModel;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.EnumExtensionsTests
{
    public class Enum_HasDescriptionTests
    {
        public enum Color
        {
            [Description("Red")]
            Red,
            [Description("Blue")]
            Blue,
            Green,
            Yellow
        }

        [Theory]
        [InlineData(Color.Red)]
        [InlineData(Color.Blue)]
        public void Should_Return_True_On_Enums_With_Description_Attribute(Color color)
        {
            var result = color.HasDescription();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(Color.Green)]
        [InlineData(Color.Yellow)]
        public void Should_Return_False_On_Enums_Without_Description_Attribute(Color color)
        {
            var result = color.HasDescription();

            result.Should().BeFalse();
        }
    }
}