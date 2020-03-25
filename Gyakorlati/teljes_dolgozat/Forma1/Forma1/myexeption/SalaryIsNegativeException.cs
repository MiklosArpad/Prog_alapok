using System;
using System.Runtime.Serialization;

namespace Forma1.myexeption
{
    [Serializable]
    internal class SalaryIsNegativeException : Exception
    {
        public SalaryIsNegativeException()
        {
        }

        public SalaryIsNegativeException(string message) : base(message)
        {
        }

        public SalaryIsNegativeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SalaryIsNegativeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}