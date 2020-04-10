using PFMS.Domain.Models.Currencies;
using PFMS.Domain.Models.IncomeSources;
using System;

namespace PFMS.Domain.Models.Income
{
    public class Income : Entity
    {
        public Income(Guid incomeSourceId, string currencyCode, DateTime date, string title)
            : this()
        {
            IncomeSourceId = incomeSourceId;
            ISOCurrencyCode = currencyCode;
            Date = date;
            Title = title;
        }

        private Income()
        {
            ISOCurrencyCode = string.Empty;
            Title = string.Empty;
        }

        public Guid IncomeSourceId { get; set; }

        public string ISOCurrencyCode { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public IncomeSource IncomeSource { get; set; }

        public Currency Currency { get; set; }
    }
}
