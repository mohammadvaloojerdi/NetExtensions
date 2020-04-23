using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.ObjectExtensions
{
    internal class Customer
    {
        public static Customer CreateNull() => null;
    }

    internal class Order
    {
        public static Order CreateNull() => null;
    }

    public class Object_IsNullTests
    {
        public static IEnumerable<object[]> NullObjects = new List<object[]>
        {
            new object[] {Customer.CreateNull()},
            new object[] {Order.CreateNull()},
            new object[] {null}
        };

        [Theory, MemberData(nameof(NullObjects))]
        public void Should_Return_True_On_Null_Objects(object obj)
        {
            var result = obj.IsNull();

            result.Should().BeTrue();
        }

        public static IEnumerable<object[]> NonNullObjects = new List<object[]>
        {
            new object[] {new Customer()},
            new object[] {new Order()}
        };

        [Theory, MemberData(nameof(NonNullObjects))]
        public void Should_Return_False_On_Non_Null_Objects(object obj)
        {
            var result = obj.IsNull();

            result.Should().BeFalse();
        }
    }
}