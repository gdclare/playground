using System;

namespace Playground.Core.Common.Exceptions
{
    public class InvalidStatusCodeException : Exception
    {
        public InvalidStatusCodeException()
        { }

        public InvalidStatusCodeException(string name) : base(string.Format("Invalid Status Code: {0}", name))
        { }
    }
}