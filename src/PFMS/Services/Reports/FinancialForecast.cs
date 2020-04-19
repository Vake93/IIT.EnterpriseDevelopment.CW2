using System;

namespace PFMS.Services.Reports
{
    public struct FinancialForecast
    {
        public DateTime Date { get; set; }

        public string ISOCurrencyCode { get; set; }

        public decimal AvarageIncome { get; set; }

        public decimal AvarageExpense { get; set; }

        public decimal Savings { get; set; }

        public decimal PredictedIncome { get; set; }

        public decimal PredictedExpense { get; set; }
    }
}
