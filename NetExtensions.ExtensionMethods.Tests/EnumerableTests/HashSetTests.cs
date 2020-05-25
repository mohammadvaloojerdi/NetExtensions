using System.Collections.Generic;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public class HashSetTests : EnumerableTests<HashSet<string>>
    {
        /// <inheritdoc />
        protected override HashSet<string> CreateEmptyEnumerable()
        {
            return new HashSet<string>();
        }

        /// <inheritdoc />
        protected override HashSet<string> CreateNonEmptyEnumerable()
        {
            return new HashSet<string> { "something" };
        }
    }
}