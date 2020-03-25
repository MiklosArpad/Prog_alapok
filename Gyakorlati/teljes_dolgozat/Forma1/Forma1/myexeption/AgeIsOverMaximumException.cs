using System;
using System.Runtime.Serialization;

namespace Forma1.myexeption
{
    [Serializable]
    internal class AgeIsOverMaximumException : Exception
    {
        public AgeIsOverMaximumException()
        {
        }

        public AgeIsOverMaximumException(string message) : base(message)
        {
        }

        public AgeIsOverMaximumException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeIsOverMaximumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}