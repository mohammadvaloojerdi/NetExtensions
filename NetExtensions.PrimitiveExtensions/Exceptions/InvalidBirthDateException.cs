using System;

namespace NetExtensions.PrimitiveExtensions.Exceptions
{
    public class InvalidBirthDateException : Exception
    {
        /// <inheritdoc />
        public override string Message => "BirthDate should not be in future";
    }
}