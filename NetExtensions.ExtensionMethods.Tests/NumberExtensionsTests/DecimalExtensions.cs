using System;

namespace NetExtensions.ExtensionMethods.Tests.NumberExtensionsTests
{
    public class DecimalExtensions : NumberExtensions<decimal>
    {
        /// <inheritdoc />
        public override decimal CastNumberToT(object number)
        {
            return Convert.ToDecimal(number);
        }
    }
}