using FluentAssertions;
using NetExtensions.PrimitiveExtensions.Exceptions;
using System;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.DateTimeExtensionsTests
{
    public class DateTime_CalculateAgeTests : BaseDateTimeTests
    {
        public static IEnumerable<object[]> BirthDates = new List<object[]>
        {
            new object[] {new DateTime(2005, 01, 01), 5},
            new object[] {new DateTime(2000, 01, 01), 10},
            new object[] {new DateTime(1990, 01, 01), 20}
        };

        [Theory, MemberData(nameof(BirthDates))]
        public void Should_Return_Age_With_Counting_Leap_Years(DateTime birthDate, int expectedAge)
        {
            Clock.Adjust(new DateTime(2010, 01, 01));

            var age = birthDate.CalculateAge(Clock);

            age.Should().Be(expectedAge);
        }

        public static IEnumerable<object[]> FutureDates = new List<object[]>
        {
            new object[] {new DateTime(2010, 01, 02)},
            new object[] {new DateTime(2020, 01, 01)}
        };

        [Theory, MemberData(nameof(FutureDates))]
        public void Should_Throw_On_Future_Dates(DateTime birthDate)
        {
            Clock.Adjust(new DateTime(2010, 01, 01));

            Action calculateAge = () => birthDate.CalculateAge(Clock);

            calculateAge.Should().Throw<InvalidBirthDateException>();
        }
    }
}