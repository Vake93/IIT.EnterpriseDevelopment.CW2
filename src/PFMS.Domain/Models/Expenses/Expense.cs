using PFMS.Domain.Models.Currencies;
using PFMS.Domain.Models.ExpenseSources;
using System;

namespace PFMS.Domain.Models.Expenses
{
    public class Expense : Entity
    {
        public Expense(Guid expenseSourceId, string currencyCode, DateTime date, string title)
            : this()
        {
            ExpenseSourceId = expenseSourceId;
            ISOCurrencyCode = currencyCode;
            Date = date;
            Title = title;
        }

        private Expense()
        {
            ISOCurrencyCode = string.Empty;
            Title = string.Empty;
        }

        public Guid ExpenseSourceId { get; set; }

        public string ISOCurrencyCode { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public ExpenseSource ExpenseSource { get; set; }

        public Currency Currency { get; set; }
    }
}
