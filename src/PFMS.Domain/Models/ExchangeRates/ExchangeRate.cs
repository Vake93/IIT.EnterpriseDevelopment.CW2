using PFMS.Domain.Models.Currencies;
using System;

namespace PFMS.Domain.Models.ExchangeRates
{
    public class ExchangeRate : Entity
    {
        public ExchangeRate(DateTime effectiveDate, string fromCurrencyCode, string toCurrencyCode, decimal rate)
        {
            EffectiveDate = effectiveDate;
            FromISOCurrencyCode = fromCurrencyCode;
            ToISOCurrencyCode = toCurrencyCode;
            Rate = rate;
        }

        private ExchangeRate()
        {
            ToISOCurrencyCode = string.Empty;
            FromISOCurrencyCode = string.Empty;
        }

        public DateTime EffectiveDate { get; set; }

        public string FromISOCurrencyCode { get; set; }

        public string ToISOCurrencyCode { get; set; }

        public decimal Rate { get; set; }

        public Currency FromCurrency { get; set; }

        public Currency ToCurrency { get; set; }
    }
}
