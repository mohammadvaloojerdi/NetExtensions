using FluentAssertions;
using System.ComponentModel;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.EnumExtensionsTests
{
    public class Enum_GetDescriptionTests
    {
        public enum Gender
        {
            [Description("Men")]
            Male,

            [Description("Women")]
            Female,

            Other
        }

        [Theory]
        [InlineData(Gender.Male, "Men")]
        [InlineData(Gender.Female, "Women")]
        public void Should_Return_Value_Of_Description_Attribute(Gender gender, string expected)
        {
            var result = gender.GetDescription();

            result.Should().Be(expected);
        }

        [Fact]
        public void Should_Return_Enum_Value_When_Description_Attribute_Not_Exists()
        {
            var result = Gender.Other.GetDescription();

            result.Should().Be("Other");
        }
    }
}