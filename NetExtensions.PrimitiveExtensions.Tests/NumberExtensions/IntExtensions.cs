using System;

namespace NetExtensions.PrimitiveExtensions.Tests.NumberExtensions
{
    public class IntExtensions : NumberExtensions<int>
    {
        /// <inheritdoc />
        public override int CastNumberToT(object number)
        {
            return Convert.ToInt32(number);
        }
    }
}