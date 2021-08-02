using System;
using System.Runtime.Serialization;

namespace LibFinTx.Exceptions
{
    [Serializable]
    internal class FinTsApiException : FinTsException
    {
        public Data.IApiResult Result { get; }
        public FinTsApiException(Data.IApiResult result) : base("Failed to execute api call.")
        {
            this.Result = result;
        }
        public FinTsApiException(Data.IApiResult result, string message) : base(message)
        {
            this.Result = result;
        }
    }
}
