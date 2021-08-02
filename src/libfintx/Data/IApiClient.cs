using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LibFinTx.Data
{
    public interface IApiClient : IDisposable
    {
        Task<IApiResult<IBalance>> ReceiveBankingAccountBalanceAsync(IBankingAccount bankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken);
        Task<IApiResult<IEnumerable<IBankingAccount>>> ReceiveBankingAccountsAsync(UserAccount userAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken);

        [Obsolete("This method is a stub and may change in the future.")]
        Task<IApiResult> ChargePrepaidPhone(IBankingAccount sourceBankingAccount, PrepaidPhone prepaidPhone, decimal amount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken);
        Task<IApiResult> DoCollectiveDirectDebit(IEnumerable<DirectDebit> directDebits, IBankingAccount creditBankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken);
        Task<IApiResult> DoDirectDebit(IBankingAccount debitBankingAccount, ISepaDirectDebitMandate sepaDirectDebitMandate, IBankingAccount creditBankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken);
        Task<IApiResult> DoTransferBalanceAsync(IBankingAccount debitBankingAccount, IBankingAccount creditBankingAccount, TanRequestHandler tanRequestHandler, CancellationToken cancellationToken);
    }
}
