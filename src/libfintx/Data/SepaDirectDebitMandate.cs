using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    public class SepaDirectDebitMandate : ISepaDirectDebitMandate
    {
        public string MandateNumber { get; set; }
        public DateTime Date { get; set; }
        public string CreditorIdentifier { get; set; }

        public SepaDirectDebitMandate(string mandateNumber, DateTime date, string creditorIdentifier)
        {
            this.MandateNumber = mandateNumber;
            this.Date = date;
            this.CreditorIdentifier = creditorIdentifier;
        }
    }
}
