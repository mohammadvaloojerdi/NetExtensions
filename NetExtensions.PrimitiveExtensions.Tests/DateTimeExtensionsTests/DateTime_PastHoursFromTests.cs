using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.DateTimeExtensionsTests
{
    public class DateTime_PastHoursFromTests : BaseDateTimeTests
    {
        public static IEnumerable<object[]> Dates = new List<object[]>
        {
            new object[]
            {
                new DateTime(2010, 01, 01, 10, 00, 00),
                new DateTime(2010, 01, 01, 10, 59, 59),
                0
            },
            new object[]
            {
                new DateTime(2010, 01, 01, 10, 00, 00),
                new DateTime(2010, 01, 01, 11, 00, 00),
                1
            },
            new object[]
            {
                new DateTime(2010, 01, 01, 10, 00, 00),
                new DateTime(2010, 01, 01, 12, 00, 00),
                2
            }
        };

        [Theory, MemberData(nameof(Dates))]
        public void Should_Be_Able_To_Count_Past_Hours_From_Specific_Date(DateTime startDate, DateTime endDate, int expected)
        {
            var result = endDate.PastHoursFrom(startDate);

            result.Should().Be(expected);
        }
    }
}