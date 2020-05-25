using System.Collections.ObjectModel;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public class CollectionTests : EnumerableTests<Collection<string>>
    {
        /// <inheritdoc />
        protected override Collection<string> CreateEmptyEnumerable()
        {
            return new Collection<string>();
        }

        /// <inheritdoc />
        protected override Collection<string> CreateNonEmptyEnumerable()
        {
            return new Collection<string> { "something" };
        }
    }
}