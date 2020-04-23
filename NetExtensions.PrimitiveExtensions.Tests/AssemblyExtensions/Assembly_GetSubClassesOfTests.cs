using System;
using System.Collections.Generic;
using System.Reflection;
using FluentAssertions;
using Xunit;

namespace NetExtensions.ExtensionMethods.Tests.AssemblyExtensions
{
    public class Assembly_GetSubClassesOfTests
    {
        internal abstract class Customer { }
        internal abstract class SpecialCustomer : Customer { }
        internal class VipCustomer : Customer { }
        internal class NormalCustomer : Customer { }

        [Fact]
        public void Should_Return_SubClassess_Of_Specific_Class()
        {
            var expected = new List<Type> { typeof(VipCustomer), typeof(NormalCustomer) };

            var result = Assembly.GetExecutingAssembly().GetSubClassesOf<Customer>();

            result.Should().HaveCount(expected.Count).And.Contain(expected);
        }

        [Fact]
        public void Should_Ignore_Abstract_SubClasses()
        {
            var result = Assembly.GetExecutingAssembly().GetSubClassesOf<Customer>();

            result.Should().NotContain(typeof(SpecialCustomer));
        }
    }
}