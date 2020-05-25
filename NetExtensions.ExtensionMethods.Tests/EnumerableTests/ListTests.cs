using System.Collections.Generic;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public class ListTests : EnumerableTests<List<string>>
    {
        /// <inheritdoc />
        protected override List<string> CreateEmptyEnumerable()
        {
            return new List<string>();
        }

        /// <inheritdoc />
        protected override List<string> CreateNonEmptyEnumerable()
        {
            return new List<string> { "Something" };
        }
    }
}