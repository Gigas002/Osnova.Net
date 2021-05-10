using System;

namespace Osnova.Net.Exceptions
{
    public class InvalidResponseCodeException : Exception
    {
        public InvalidResponseCodeException()
        { }

        public InvalidResponseCodeException(string message) : base(message)
        { }

        public InvalidResponseCodeException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
