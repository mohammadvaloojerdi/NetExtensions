using System;

namespace NetExtensions.PrimitiveExtensions.Tests.NumberExtensions
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