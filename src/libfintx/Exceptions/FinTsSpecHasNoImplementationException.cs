using System;
using System.Runtime.Serialization;

namespace LibFinTx.Exceptions
{
    [Serializable]
    internal class FinTsSpecHasNoImplementationException : FinTsException
    {
        public Version FinTsSpec { get; }
        public FinTsSpecHasNoImplementationException(Version finTsSpecVersion) : base($"The requested FinTS spec {finTsSpecVersion} has no implementation.")
        {
            this.FinTsSpec = finTsSpecVersion;
        }
    }
}
