using System;
using System.Runtime.Serialization;

namespace Forma1.myexeption
{
    [Serializable]
    internal class AgeIsZeroException : Exception
    {
        public AgeIsZeroException()
        {
        }

        public AgeIsZeroException(string message) : base(message)
        {
        }

        public AgeIsZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeIsZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}