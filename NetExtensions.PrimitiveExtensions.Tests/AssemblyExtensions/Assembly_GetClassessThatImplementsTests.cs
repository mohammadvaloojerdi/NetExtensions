using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace NetExtensions.PrimitiveExtensions.Tests.AssemblyExtensions
{
    public class Assembly_GetClassessThatImplementsTests
    {
        internal interface IRepository { }
        internal abstract class Repository : IRepository { }
        internal class CustomerRepository : IRepository { }
        internal class VipCustomerRepository : CustomerRepository { }
        internal class OrderRepository : IRepository { }

        [Fact]
        public void Should_Return_Classess_That_Implement_Specific_Interface()
        {
            var expected = new List<Type> { typeof(CustomerRepository), typeof(OrderRepository), typeof(VipCustomerRepository) };

            var result = Assembly.GetExecutingAssembly().GetClassesThatImplements<IRepository>();

            result.Should().HaveCount(expected.Count).And.Contain(expected);
        }

        [Fact]
        public void Should_Return_Classes_That_Implements_Specific_Class()
        {
            var expected = new List<Type> { typeof(VipCustomerRepository) };

            var result = Assembly.GetExecutingAssembly().GetClassesThatImplements<CustomerRepository>();

            result.Should().HaveCount(expected.Count).And.Contain(expected);
        }

        [Fact]
        public void Should_Ignore_Abstract_Classes()
        {
            var result = Assembly.GetExecutingAssembly().GetClassesThatImplements<IRepository>();

            result.Should().NotContain(typeof(Repository));
        }
    }
}