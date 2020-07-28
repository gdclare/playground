using System;

namespace Common.Exceptions
{
    public class InvalidStatusCodeException : Exception
    {
        public InvalidStatusCodeException()
        {}

        public InvalidStatusCodeException(string name) : base(String.Format("Invalid Status Code: {0}", name))
        {}
    }
}