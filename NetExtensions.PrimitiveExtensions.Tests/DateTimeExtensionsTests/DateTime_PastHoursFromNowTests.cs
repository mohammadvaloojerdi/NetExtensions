﻿using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.DateTimeExtensionsTests
{
    public class DateTime_PastHoursFromNowTests : BaseDateTimeTests
    {
        public static IEnumerable<object[]> Dates = new List<object[]>
        {
            new object[] {new DateTime(2010, 01, 01, 10, 01, 01), 0},
            new object[] {new DateTime(2010, 01, 01, 12, 00, 00), 2},
            new object[] {new DateTime(2010, 01, 01, 15, 00, 00), 5}
        };

        [Theory, MemberData(nameof(Dates))]
        public void Should_Be_Able_To_Count_Past_Hours_From_Now(DateTime birthDate, int expected)
        {
            Clock.Adjust(new DateTime(2010, 01, 01, 10, 00, 00));

            var result = birthDate.PastHoursFromNow(Clock);

            result.Should().Be(expected);
        }
    }
}