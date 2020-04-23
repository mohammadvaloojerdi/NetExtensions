using System;
using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.NumberExtensions
{
    public abstract class NumberExtensions<T> where T : struct, IComparable, IComparable<T>, IConvertible
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(2, false)]
        [InlineData(4, false)]
        [InlineData(6, false)]
        public void IsOdd_Should_Be_Able_To_Identify_Odd_Numbers(object number, bool expected)
        {
            var result = CastNumberToT(number).IsOdd();

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(6, true)]
        [InlineData(1, false)]
        [InlineData(3, false)]
        [InlineData(5, false)]
        public void IsEven_Should_Be_Able_To_Identify_Even_Numbers(object number, bool expected)
        {
            var result = CastNumberToT(number).IsEven();

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(-1, false)]
        [InlineData(-2, false)]
        [InlineData(-3, false)]
        public void IsPositive_Should_Be_Able_To_Identify_Positive_Numbers(object number, bool expected)
        {
            var result = CastNumberToT(number).IsPositive();

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(-1, true)]
        [InlineData(-2, true)]
        [InlineData(-3, true)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, false)]
        public void IsNegative_Should_Be_Able_To_Identify_Negative_Numbers(object number, bool expected)
        {
            var result = CastNumberToT(number).IsNegative();

            result.Should().Be(expected);
        }

        public abstract T CastNumberToT(object number);
    }
}