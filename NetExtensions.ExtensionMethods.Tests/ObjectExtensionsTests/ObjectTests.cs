using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.ObjectExtensionsTests
{
    internal class Customer
    {
        public static Customer CreateNull() => null;
    }

    internal class VipCustomer : Customer { }

    internal class Order
    {
        public static Order CreateNull() => null;
    }

    public class ObjectTests
    {
        public static IEnumerable<object[]> NullObjects = new List<object[]>
        {
            new object[] {Customer.CreateNull()},
            new object[] {Order.CreateNull()},
            new object[] {null}
        };

        public static IEnumerable<object[]> NonNullObjects = new List<object[]>
        {
            new object[] {new Customer()},
            new object[] {new Order()}
        };

        [Theory, MemberData(nameof(NullObjects))]
        public void IsNull_Should_Return_True_On_Null_Objects(object obj)
        {
            var result = obj.IsNull();

            result.Should().BeTrue();
        }

        [Theory, MemberData(nameof(NonNullObjects))]
        public void IsNull_Should_Return_False_On_Non_Null_Objects(object obj)
        {
            var result = obj.IsNull();

            result.Should().BeFalse();
        }

        [Theory, MemberData(nameof(NonNullObjects))]
        public void IsNotNull_Should_Return_True_On_Non_Null_Objects(object obj)
        {
            var result = obj.IsNotNull();

            result.Should().BeTrue();
        }

        [Theory, MemberData(nameof(NullObjects))]
        public void IsNotNull_Should_Return_False_On_Null_Objects(object obj)
        {
            var result = obj.IsNotNull();

            result.Should().BeFalse();
        }

        [Fact]
        public void Is_Should_Return_True_On_Objects_Derived_From_Specific_Types()
        {
            var vipCustomer = new VipCustomer();

            var result = vipCustomer.Is<Customer>();

            result.Should().BeTrue();
        }
    }
}