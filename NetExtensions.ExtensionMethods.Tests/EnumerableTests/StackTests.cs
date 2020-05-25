using System.Collections.Generic;

namespace NetExtensions.ExtensionMethods.Tests.EnumerableTests
{
    public class StackTests : EnumerableTests<Stack<string>>
    {
        /// <inheritdoc />
        protected override Stack<string> CreateEmptyEnumerable()
        {
            return new Stack<string>();
        }

        /// <inheritdoc />
        protected override Stack<string> CreateNonEmptyEnumerable()
        {
            var stack = new Stack<string>(1);
            stack.Push("something");
            return stack;
        }
    }
}