using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PFMS.Services.ExchangeRates
{
    public class ExchangeRateService : IExchangeRateService
    {
        private const string _defaultCurrencyCode = "EUR";
        private const string _historicalRatesUrl = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";
        private static readonly HttpClient _httpClient = new HttpClient();

        public IReadOnlyList<ExchangeRate> ExchangeRates { get; private set; }

        public async Task LoadExchangeRatesAsync(
            CancellationToken cancellationToken = default)
        {
            using (var httpResponse = await _httpClient.GetAsync(_historicalRatesUrl, cancellationToken))
            using (var resultContent = await httpResponse.Content.ReadAsStreamAsync())
            using (var reader = new XmlTextReader(resultContent))
            {
                var serializer = new XmlSerializer(typeof(HistoricalEnvelope));

                var deserializedEnvelope = (HistoricalEnvelope)serializer.Deserialize(reader);
                ExchangeRates = new List<ExchangeRate>(deserializedEnvelope.ExchangeRates);
            }
        }

        public decimal ConvertCurrency(
            string fromISOCurrencyCode,
            string toISOCurrencyCode,
            DateTime date,
            decimal amount)
        {
            if (string.IsNullOrEmpty(fromISOCurrencyCode))
            {
                throw new ArgumentNullException(nameof(fromISOCurrencyCode));
            }

            if (string.IsNullOrEmpty(toISOCurrencyCode))
            {
                throw new ArgumentNullException(nameof(toISOCurrencyCode));
            }

            date = date.Date.AddDays(-1);
            fromISOCurrencyCode = fromISOCurrencyCode.ToUpperInvariant();
            toISOCurrencyCode = toISOCurrencyCode.ToUpperInvariant();

            if ((fromISOCurrencyCode == _defaultCurrencyCode && toISOCurrencyCode == _defaultCurrencyCode) ||
                fromISOCurrencyCode == toISOCurrencyCode)
            {
                return decimal.Round(amount, 2);
            }

            var currencyCodes = new List<string> { fromISOCurrencyCode, toISOCurrencyCode };
            currencyCodes.RemoveAll(code => code == _defaultCurrencyCode);

            var rates = ExchangeRates
                .Where(r => r.Date.Date <= date)
                .OrderBy(r => r.Date)
                .First()
                .ReferenceRates;

            if (fromISOCurrencyCode == _defaultCurrencyCode)
            {
                var rate = Array.Find(rates, ex => ex.ISOCurrencyCode == toISOCurrencyCode).Rate;
                return decimal.Round(rate * amount, 2);
            }

            if (toISOCurrencyCode == _defaultCurrencyCode)
            {
                var rate = Array.Find(rates, ex => ex.ISOCurrencyCode == fromISOCurrencyCode).Rate;
                return decimal.Round(amount / rate, 2);
            }

            var fromRate = Array.Find(rates, ex => ex.ISOCurrencyCode == fromISOCurrencyCode).Rate;
            var toRate = Array.Find(rates, ex => ex.ISOCurrencyCode == toISOCurrencyCode).Rate;

            return decimal.Round((amount * toRate) / fromRate, 2);
        }

        public string[] GetCurrencyCodes()
        {
            if (ExchangeRates is List<ExchangeRate>)
            {
                return ExchangeRates
                    .First()
                    .ReferenceRates
                    .Select(r => r.ISOCurrencyCode)
                    .Union(new string[] { "EUR" })
                    .OrderBy(c => c)
                    .ToArray();
            }

            return Array.Empty<string>();
        }
    }
}
