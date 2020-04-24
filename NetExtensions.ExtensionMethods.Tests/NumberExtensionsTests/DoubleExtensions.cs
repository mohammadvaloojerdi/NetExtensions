using System;

namespace NetExtensions.ExtensionMethods.Tests.NumberExtensionsTests
{
    public class DoubleExtensions : NumberExtensions<double>
    {
        /// <inheritdoc />
        public override double CastNumberToT(object number)
        {
            return Convert.ToDouble(number);
        }
    }
}