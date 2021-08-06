using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LibFinTx.Data;

namespace LibFinTx.FinTs3_0
{
    [FinTsSpec(3, 0)]
    public class ApiClient : IApiClient
    {
        #region IApiClient
        public Task<IApiResult> ChargePrepaidPhone(IBankingAccount sourceBankingAccount, PrepaidPhone prepaidPhone, decimal amount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IApiResult> DoCollectiveDirectDebit(IEnumerable<DirectDebit> directDebits, IBankingAccount creditBankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IApiResult> DoDirectDebit(IBankingAccount debitBankingAccount, ISepaDirectDebitMandate sepaDirectDebitMandate, IBankingAccount creditBankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IApiResult> DoTransferBalanceAsync(IBankingAccount debitBankingAccount, IBankingAccount creditBankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IApiResult<IBalance>> ReceiveBankingAccountBalanceAsync(IBankingAccount bankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IApiResult<IEnumerable<IBankingAccount>>> ReceiveBankingAccountsAsync(UserAccount userAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }
        #endregion
    }
}
