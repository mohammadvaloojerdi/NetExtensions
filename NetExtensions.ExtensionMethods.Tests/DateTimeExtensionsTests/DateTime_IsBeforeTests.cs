using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.DateTimeExtensionsTests
{
    public class DateTime_IsBeforeTests : BaseDateTimeTests
    {
        public static IEnumerable<object[]> Dates => new List<object[]>
        {
            new object[]
            {
                new DateTime(2010, 10, 10),
                new DateTime(2010, 10, 11),
                true
            },
            new object[] {
                new DateTime(2010, 10, 10, 10, 00, 00),
                new DateTime(2010, 10, 10, 10, 00, 01),
                true
            },
            new object[]
            {
                new DateTime(2010, 10, 10),
                new DateTime(2010, 10, 09),
                false
            },
            new object[] {
                new DateTime(2010, 10, 10, 10, 00, 00),
                new DateTime(2010, 10, 10, 09, 59, 59),
                false
            }
        };

        [Theory, MemberData(nameof(Dates))]
        public void Should_Be_Able_To_Compare_Dates(DateTime dateTime, DateTime dateTimeToCompare, bool expected)
        {
            var result = dateTime.IsBefore(dateTimeToCompare);

            result.Should().Be(expected);
        }
    }
}