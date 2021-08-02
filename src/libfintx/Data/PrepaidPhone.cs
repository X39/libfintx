using System;
using System.Collections.Generic;
using System.Text;

namespace LibFinTx.Data
{
    public class PrepaidPhone
    {
        public int MobileServiceProvider { get; set; }
        public string PhoneNumber { get; set; }

        public PrepaidPhone(int mobileServiceProvider, string phoneNumber)
        {
            this.MobileServiceProvider = mobileServiceProvider;
            this.PhoneNumber = phoneNumber;
        }
    }
}
