﻿using System;

namespace NetExtensions.PrimitiveExtensions.Tests.NumberExtensions
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