using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.DateTimeExtensionsTests
{
    public class DateTime_IsInFutureTests : BaseDateTimeTests
    {
        public static IEnumerable<object[]> FutureDates => new List<object[]>
        {
            new object[]{new DateTime(2010,01,01,10,00,01) },
            new object[]{new DateTime(2010,01,01,10,01,00) },
            new object[]{new DateTime(2010,01,01,11,00,00) },
            new object[]{new DateTime(2010,01,02,10,00,00) },
            new object[]{new DateTime(2010,02,01,10,00,00) },
            new object[]{new DateTime(2011,01,01,10,00,00) }
        };

        [Theory, MemberData(nameof(FutureDates))]
        public void Should_Return_True_On_Future_Dates(DateTime dateTime)
        {
            Clock.Adjust(new DateTime(2010, 01, 01, 10, 00, 00));

            var result = dateTime.IsInFuture(Clock);

            result.Should().BeTrue();
        }

        public static IEnumerable<object[]> PasDates => new List<object[]>
        {
            new object[]{new DateTime(2010,01,01,09,59,59) },
            new object[]{new DateTime(2010,01,01,09,59,00) },
            new object[]{new DateTime(2009,01,01,09,00,00) }
        };

        [Theory, MemberData(nameof(PasDates))]
        public void Should_Return_False_On_Past_Dates(DateTime dateTime)
        {
            Clock.Adjust(new DateTime(2010, 01, 01, 10, 00, 00));

            var result = dateTime.IsInFuture(Clock);

            result.Should().BeFalse();
        }
    }
}