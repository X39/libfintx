using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    public class DirectDebit
    {
        public IBankingAccount BankingAccount { get; set; }
        public ISepaDirectDebitMandate SepaDirectDebitMandate { get; set; }

        public DirectDebit(IBankingAccount bankingAccount, ISepaDirectDebitMandate sepaDirectDebitMandate)
        {
            this.BankingAccount = bankingAccount;
            this.SepaDirectDebitMandate = sepaDirectDebitMandate;
        }
    }
}
