using System;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public class ArrayTests : EnumerableTests<Array>
    {
        /// <inheritdoc />
        protected override Array CreateEmptyEnumerable()
        {
            return Array.Empty<string>();
        }

        /// <inheritdoc />
        protected override Array CreateNonEmptyEnumerable()
        {
            return new[] { "something" };
        }
    }
}