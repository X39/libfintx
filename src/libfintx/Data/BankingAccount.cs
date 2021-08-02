using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    public class BankingAccount : IBankingAccount
    {
        public string Name { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }

        public BankingAccount(string name, string iban, string bic)
        {
            this.Name = name;
            this.Iban = iban;
            this.Bic = bic;
        }
    }
}
