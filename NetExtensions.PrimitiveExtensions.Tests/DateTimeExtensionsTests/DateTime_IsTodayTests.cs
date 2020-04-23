using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.DateTimeExtensionsTests
{
    public class DateTime_IsTodayTests : BaseDateTimeTests
    {
        public static IEnumerable<object[]> TodayDates => new List<object[]>
        {
            new object[]{new DateTime(2010,10,10,23,59,59) },
            new object[]{new DateTime(2010,10,10,00,00,01) },
            new object[]{new DateTime(2010,10,10,12,00,00) }
        };

        [Theory, MemberData(nameof(TodayDates))]
        public void Should_Return_True_On_Today_Dates(DateTime dateTime)
        {
            Clock.Adjust(new DateTime(2010, 10, 10, 10, 00, 00));

            var result = dateTime.IsToday(Clock);

            result.Should().BeTrue();
        }

        public static IEnumerable<object[]> NonTodayDates => new List<object[]>
        {
            new object[]{new DateTime(2010,10,09,23,59,59) },
            new object[]{new DateTime(2010,10,11,00,00,01) }
        };

        [Theory, MemberData(nameof(NonTodayDates))]
        public void Should_Return_False_On_Non_Today_Dates(DateTime dateTime)
        {
            Clock.Adjust(new DateTime(2010, 10, 10, 10, 00, 00));

            var result = dateTime.IsToday(Clock);

            result.Should().BeFalse();
        }
    }
}