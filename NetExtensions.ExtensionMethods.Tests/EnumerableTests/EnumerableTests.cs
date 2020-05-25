using FluentAssertions;
using System.Collections;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public abstract class EnumerableTests<T> where T : IEnumerable
    {
        [Fact]
        public void IsEmpty_Should_Return_True_On_Empty_Enumerables()
        {
            var enumerable = CreateEmptyEnumerable();

            enumerable.IsEmpty().Should().BeTrue();
        }

        [Fact]
        public void IsEmpty_Should_Return_False_On_Non_Empty_Enumerables()
        {
            var enumerable = CreateNonEmptyEnumerable();

            enumerable.IsEmpty().Should().BeFalse();
        }

        [Fact]
        public void IsNotEmpty_Should_Return_True_On_Non_Empty_Enumerables()
        {
            var enumerable = CreateNonEmptyEnumerable();

            enumerable.IsNotEmpty().Should().BeTrue();
        }

        [Fact]
        public void IsNotEmpty_Should_Return_False_On_Empty_Enumerables()
        {
            var enumerable = CreateEmptyEnumerable();

            enumerable.IsNotEmpty().Should().BeFalse();
        }

        protected abstract T CreateEmptyEnumerable();
        protected abstract T CreateNonEmptyEnumerable();
    }
}