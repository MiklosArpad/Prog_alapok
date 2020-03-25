using System;
using System.Runtime.Serialization;

namespace Forma1.myexeption
{
    [Serializable]
    internal class AgeIsNegativeException : Exception
    {
        public AgeIsNegativeException()
        {
        }

        public AgeIsNegativeException(string message) : base(message)
        {
        }

        public AgeIsNegativeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeIsNegativeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}