using System;
using System.Runtime.Serialization;

namespace Forma1.myexeption
{
    [Serializable]
    internal class AgeIsUnderMinimumException : Exception
    {
        public AgeIsUnderMinimumException()
        {
        }

        public AgeIsUnderMinimumException(string message) : base(message)
        {
        }

        public AgeIsUnderMinimumException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeIsUnderMinimumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}