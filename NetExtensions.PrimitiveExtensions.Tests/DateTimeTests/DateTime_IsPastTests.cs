using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.DateTimeTests
{
    public class DateTime_IsPastTests : BaseDateTimeTests
    {
        public static IEnumerable<object[]> PastDates => new List<object[]>
            {
                new object[] { new DateTime(2010,10,10,09,59,00) },
                new object[] { new DateTime(2010,10,09,10,00,00) },
                new object[] { new DateTime(2010,09,10,10,00,00) },
                new object[] { new DateTime(2009,10,10,10,00,00) }
            };

        [Theory, MemberData(nameof(PastDates))]
        public void Should_Be_Able_To_Identify_Past_Dates(DateTime dateTime)
        {
            Clock.Adjust(new DateTime(2010, 10, 10, 10, 00, 00));

            var result = dateTime.IsPast(Clock);

            result.Should().BeTrue();
        }

        public static IEnumerable<object[]> FutureDates => new List<object[]>
        {
            new object[]{new DateTime(2010,10,10,10,00,01) },
            new object[]{new DateTime(2010,10,10,10,01,00) },
            new object[]{new DateTime(2010,10,11,10,00,00) },
            new object[]{new DateTime(2010,11,10,10,00,00) },
            new object[]{new DateTime(2011,10,10,10,00,00) }
        };

        [Theory, MemberData(nameof(FutureDates))]
        public void Should_Be_Able_To_Identify_Future_Dates(DateTime dateTime)
        {
            Clock.Adjust(new DateTime(2010, 10, 10, 10, 00, 00));

            var result = dateTime.IsPast(Clock);

            result.Should().BeFalse();
        }
    }
}