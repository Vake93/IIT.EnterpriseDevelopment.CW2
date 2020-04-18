using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Services.ExchangeRates
{
    public interface IExchangeRateService
    {
        IReadOnlyList<ExchangeRate> ExchangeRates { get; }

        string[] GetCurrencyCodes();

        decimal ConvertCurrency(
            string fromISOCurrencyCode,
            string toISOCurrencyCode,
            DateTime date,
            decimal amount);

        Task LoadExchangeRatesAsync(CancellationToken cancellationToken = default);
    }
}