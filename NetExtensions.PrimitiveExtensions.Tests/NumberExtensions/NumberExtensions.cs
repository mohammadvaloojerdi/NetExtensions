using FluentAssertions;
using System;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.NumberExtensions
{
    public abstract class NumberExtensions<T> where T : struct, IComparable, IComparable<T>,
        IConvertible, IEquatable<T>, IFormattable
    {
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void IsOdd_Should_Return_True_On_Odd_Numbers(object number)
        {
            var result = CastNumberToT(number).IsOdd();

            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void IsOdd_Should_Return_False_On_Even_Numbers(object number)
        {
            var result = CastNumberToT(number).IsOdd();

            result.Should().BeFalse();
        }

        public abstract T CastNumberToT(object number);
    }
}