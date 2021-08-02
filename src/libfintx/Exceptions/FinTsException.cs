using System;
using System.Runtime.Serialization;

namespace LibFinTx.Exceptions
{
    [Serializable]
    internal class FinTsException : Exception
    {
        public FinTsException()
        {
        }

        public FinTsException(string message) : base(message)
        {
        }

        public FinTsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FinTsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
