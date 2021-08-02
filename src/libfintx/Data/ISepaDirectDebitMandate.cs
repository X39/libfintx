using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    public interface ISepaDirectDebitMandate
    {
        string MandateNumber { get; }
        DateTime Date { get; }
        string CreditorIdentifier { get; }
    }
}
