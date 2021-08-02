using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LibFinTx.Data;

namespace LibFinTx
{
    public class FinTsClient : IDisposable
    {
        #region IDisposable
        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion


        public Version SpecVersion { get; }
        private readonly IApiClient _apiClient;
        private readonly TanRequestHandler _tanRequestHandler;
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exceptions.FinTsSpecHasNoImplementationException">Thrown when the FinTS 3.0 spec is not available as implementation.</exception>
        /// <param name="specVersion"></param>
        public FinTsClient(TanRequestHandler tanRequestHandler) : this(tanRequestHandler, new Version(3, 0, 0, 0)) { }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exceptions.FinTsSpecHasNoImplementationException">Thrown when the FinTS <see cref="SpecVersion"/> is not available as implementation.</exception>
        /// <param name="specVersion"></param>
        public FinTsClient(TanRequestHandler tanRequestHandler, Version specVersion)
        {
            this.SpecVersion = specVersion;
            this._apiClient = ApiClientFactory.Instance.Produce(this.SpecVersion);
            this._tanRequestHandler = tanRequestHandler;
        }

        public virtual void Dispose()
        {
            this._apiClient.Dispose();
        }


        protected async Task ExWrapAsync(Func<Task<IApiResult>> func)
        {
            var apiResult = await func();
            if (!apiResult.IsSuccess)
            {
                throw new Exceptions.FinTsApiException(apiResult);
            }
        }
        protected async Task<T> ExWrapAsync<T>(Func<Task<IApiResult<T>>> func)
        {
            var apiResult = await func();
            if (!apiResult.IsSuccess)
            {
                throw new Exceptions.FinTsApiException(apiResult);
            }
            return apiResult.Paload;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userAccount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.FinTsApiException">Thrown when an API call fails.</exception>
        public async Task<IEnumerable<IBankingAccount>> GetBankingAccountsAsync(UserAccount userAccount, CancellationToken cancellationToken = default)
        {
            return await ExWrapAsync(async () => await _apiClient.ReceiveBankingAccountsAsync(userAccount, this._tanRequestHandler, cancellationToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bankingAccount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.FinTsApiException">Thrown when an API call fails.</exception>
        public async Task<IBalance> GetBankingAccountBalanceAsync(IBankingAccount bankingAccount, CancellationToken cancellationToken = default)
        {
            return await ExWrapAsync(async () => await _apiClient.ReceiveBankingAccountBalanceAsync(bankingAccount, this._tanRequestHandler, cancellationToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="debitBankingAccount"></param>
        /// <param name="creditBankingAccount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.FinTsApiException">Thrown when an API call fails.</exception>
        public async Task TransferBalanceAsync(IBankingAccount debitBankingAccount, IBankingAccount creditBankingAccount, CancellationToken cancellationToken = default)
        {
            await ExWrapAsync(async () => await _apiClient.DoTransferBalanceAsync(debitBankingAccount, creditBankingAccount, this._tanRequestHandler, cancellationToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directDebit"></param>
        /// <param name="creditBankingAccount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.FinTsApiException">Thrown when an API call fails.</exception>
        public async Task DirectDebitAsync(DirectDebit directDebit, IBankingAccount creditBankingAccount, CancellationToken cancellationToken = default)
        {
            await ExWrapAsync(async () => await _apiClient.DoDirectDebit(directDebit.BankingAccount, directDebit.SepaDirectDebitMandate, creditBankingAccount, this._tanRequestHandler, cancellationToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="debitBankingAccount"></param>
        /// <param name="sepaDirectDebitMandate"></param>
        /// <param name="creditBankingAccount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.FinTsApiException">Thrown when an API call fails.</exception>
        public async Task DirectDebitAsync(IBankingAccount debitBankingAccount, ISepaDirectDebitMandate sepaDirectDebitMandate, IBankingAccount creditBankingAccount, CancellationToken cancellationToken = default)
        {
            await ExWrapAsync(async () => await _apiClient.DoDirectDebit(debitBankingAccount, sepaDirectDebitMandate, creditBankingAccount, this._tanRequestHandler, cancellationToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directDebits"></param>
        /// <param name="creditBankingAccount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.FinTsApiException">Thrown when an API call fails.</exception>
        public async Task CollectiveDirectDebitAsync(IEnumerable<DirectDebit> directDebits, IBankingAccount creditBankingAccount, CancellationToken cancellationToken = default)
        {
            await ExWrapAsync(async () => await _apiClient.DoCollectiveDirectDebit(directDebits, creditBankingAccount, this._tanRequestHandler, cancellationToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceBankingAccount"></param>
        /// <param name="prepaidPhone"></param>
        /// <param name="amount"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.FinTsApiException">Thrown when an API call fails.</exception>
        [Obsolete("This method is a stub and may change in the future.")]
        public async Task ChargePrepaidPhone(IBankingAccount sourceBankingAccount, PrepaidPhone prepaidPhone, decimal amount, CancellationToken cancellationToken = default)
        {
            await ExWrapAsync(async () => await _apiClient.ChargePrepaidPhone(sourceBankingAccount, prepaidPhone, amount, this._tanRequestHandler, cancellationToken));
        }
    }
}
