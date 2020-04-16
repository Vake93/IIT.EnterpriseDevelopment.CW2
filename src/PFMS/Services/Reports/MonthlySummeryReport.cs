namespace PFMS.Services.Reports
{
    public struct MonthlySummeryReport
    {
        public MonthlySummeryReport(
            string monthName,
            string currencyCode,
            decimal totalIncome,
            decimal totalExpense,
            decimal totalSavings)
        {
            MonthName = monthName;
            ISOCurrencyCode = currencyCode;
            TotalIncome = totalIncome;
            TotalExpense = totalExpense;
            TotalSavings = totalSavings;
        }

        public string MonthName { get; }

        public string ISOCurrencyCode { get; }

        public decimal TotalIncome { get; }

        public decimal TotalExpense { get; }

        public decimal TotalSavings { get; }
    }
}
