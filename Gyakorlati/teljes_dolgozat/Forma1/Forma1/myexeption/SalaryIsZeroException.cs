using System;
using System.Runtime.Serialization;

namespace Forma1.myexeption
{
    [Serializable]
    internal class SalaryIsZeroException : Exception
    {
        public SalaryIsZeroException()
        {
        }

        public SalaryIsZeroException(string message) : base(message)
        {
        }

        public SalaryIsZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SalaryIsZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}