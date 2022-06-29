using System;

namespace library.domain.Exceptions
{
    [Serializable]
    public class RequestInvalidException : Exception
    {
        public override string Message { get; }
        public RequestInvalidException(string message)
        {
            Message = message;
        }
    }
}