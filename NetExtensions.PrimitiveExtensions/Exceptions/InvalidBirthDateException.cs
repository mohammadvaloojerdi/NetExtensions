using System;

namespace NetExtensions.ExtensionMethods.Exceptions
{
    public class InvalidBirthDateException : Exception
    {
        /// <inheritdoc />
        public override string Message => "BirthDate should not be in future";
    }
}