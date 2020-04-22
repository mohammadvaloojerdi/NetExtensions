using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests
{
    public class DateTimeTests
    {
        private readonly ClockStub _clock;

        public DateTimeTests()
        {
            _clock = new ClockStub();
        }

        public static IEnumerable<object[]> PastDates => new List<object[]>
            {
                new object[] { new DateTime(2010,10,10,09,59,00) },
                new object[] { new DateTime(2010,10,09,10,00,00) },
                new object[] { new DateTime(2010,09,10,10,00,00) },
                new object[] { new DateTime(2009,10,10,10,00,00) }
            };

        [Theory, MemberData(nameof(PastDates))]
        public void IsPast_Should_Identify_Past_Dates(DateTime dateTime)
        {
            _clock.Adjust(new DateTime(2010, 10, 10, 10, 00, 00));

            var result = dateTime.IsPast(_clock);

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
        public void IsPast_Should_Identify_Future_Dates(DateTime dateTime)
        {
            _clock.Adjust(new DateTime(2010, 10, 10, 10, 00, 00));

            var result = dateTime.IsPast(_clock);

            result.Should().BeFalse();
        }
    }
}