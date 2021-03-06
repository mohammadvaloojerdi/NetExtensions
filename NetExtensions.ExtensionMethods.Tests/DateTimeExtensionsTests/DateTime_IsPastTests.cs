﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.DateTimeExtensionsTests
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
        public void Should_Return_True_On_Past_Dates(DateTime dateTime)
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
        public void Should_Return_False_On_Future_Dates(DateTime dateTime)
        {
            Clock.Adjust(new DateTime(2010, 10, 10, 10, 00, 00));

            var result = dateTime.IsPast(Clock);

            result.Should().BeFalse();
        }
    }
}