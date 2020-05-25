using System.Collections.Generic;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public class QueueTests : EnumerableTests<Queue<string>>
    {
        /// <inheritdoc />
        protected override Queue<string> CreateEmptyEnumerable()
        {
            return new Queue<string>();
        }

        /// <inheritdoc />
        protected override Queue<string> CreateNonEmptyEnumerable()
        {
            var queue = new Queue<string>();
            queue.Enqueue("something");
            return queue;
        }
    }
}