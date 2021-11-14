using System;
using System.Runtime.Serialization;

namespace Actor.Streams.Shims
{
    public class IllegalStateException : Exception
    {
        public IllegalStateException(string message) : base(message){}

        public IllegalStateException(string itSIllegalToTryToSignalOnerrorWithASpecViolation, Exception cause)
        {
            throw new NotImplementedException();
        }

        protected IllegalStateException(SerializationInfo serializationInfo, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}