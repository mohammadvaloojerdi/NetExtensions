using System.Collections;
using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public abstract class EnumerableTests<T> where T : IEnumerable
    {
        [Fact]
        public void IsEmpty_Should_Return_True_On_Empty_Enumerables()
        {
            var enumerable = CreateEmptyEnumerable();

            enumerable.Should().BeEmpty();
        }

        [Fact]
        public void IsEmpty_Should_Return_False_On_Non_Empty_Enumerables()
        {
            var enumerable = CreateNonEmptyEnumerable();

            enumerable.Should().NotBeEmpty();
        }

        [Fact]
        public void IsNotEmpty_Should_Return_True_On_Non_Empty_Enumerables()
        {
            var enumerable = CreateNonEmptyEnumerable();

            enumerable.Should().NotBeEmpty();
        }

        [Fact]
        public void IsNotEmpty_Should_Return_False_On_Empty_Enumerables()
        {
            var enumerable = CreateEmptyEnumerable();

            enumerable.Should().BeEmpty();
        }

        protected abstract T CreateEmptyEnumerable();
        protected abstract T CreateNonEmptyEnumerable();
    }
}