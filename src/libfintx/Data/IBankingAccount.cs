using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    public interface IBankingAccount
    {
        string Name { get; }
        string Iban { get; }
        string Bic { get; }
    }
}
