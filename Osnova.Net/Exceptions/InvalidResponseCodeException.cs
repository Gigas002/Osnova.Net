using System;

namespace Osnova.Net.Exceptions
{
    /// <summary>
    /// Exception signals, that response code from API was not correct
    /// </summary>
    public class InvalidResponseCodeException : Exception
    {
        /// <inheritdoc />
        public InvalidResponseCodeException()
        { }

        /// <inheritdoc />
        public InvalidResponseCodeException(string message) : base(message)
        { }

        /// <inheritdoc />
        public InvalidResponseCodeException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
