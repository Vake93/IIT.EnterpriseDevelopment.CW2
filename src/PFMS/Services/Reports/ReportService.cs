using PFMS.Domain.Queries.BankAccounts;
using PFMS.Domain.Queries.Expenses;
using PFMS.Domain.Queries.Income;
using PFMS.Services.Authentication;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace PFMS.Services.Reports
{
    public class ReportService : IReportService
    {
        private readonly IIncomeQuery _incomeQuery;
        private readonly IExpenseQuery _expenseQuery;
        private readonly IBankAccountQuery _bankAccountQuery;
        private readonly IAuthenticationService _authenticationService;

        public ReportService(
            IIncomeQuery incomeQuery,
            IExpenseQuery expenseQuery,
            IBankAccountQuery bankAccountQuery,
            IAuthenticationService authenticationService)
        {
            _incomeQuery = incomeQuery;
            _expenseQuery = expenseQuery;
            _bankAccountQuery = bankAccountQuery;
            _authenticationService = authenticationService;
        }

        public async Task<MonthlySummeryReport> GetMonthlySummeryReportAsync(int year, int month)
        {
            var user = _authenticationService.LoggedInUser;

            if (user is null)
            {
                throw new Exception("No user is logged in");
            }

            if (year <= DateTime.MinValue.Year || year >= DateTime.MaxValue.Year)
            {
                throw new IndexOutOfRangeException("Invalid year");
            }

            if (month < 1 || month > 12)
            {
                throw new IndexOutOfRangeException("Invalid month");
            }

            var lastDay = DateTime.DaysInMonth(year, month);
            var startDate = new DateTime(year, month, 1);
            var endDate = new DateTime(year, month, lastDay);

            var monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];

            var totalIncome = await _incomeQuery.GetTotalIncomeAsync(
                i => i.IncomeSource.UserId == user.Id &&
                     i.ISOCurrencyCode == user.DefaultISOCurrencyCode &&
                     i.Date >= startDate &&
                     i.Date <= endDate &&
                     !i.Deleted);

            var totalExpense = await _expenseQuery.GetTotalExpenseAsync(
                i => i.ExpenseSource.UserId == user.Id &&
                     i.ISOCurrencyCode == user.DefaultISOCurrencyCode &&
                     i.Date >= startDate &&
                     i.Date <= endDate &&
                     !i.Deleted);

            var totalSavings = await _bankAccountQuery.GetTotalAsync(
                i => i.UserId == user.Id &&
                     i.ISOCurrencyCode == user.DefaultISOCurrencyCode &&
                     !i.Deleted);

            return new MonthlySummeryReport(
                monthName,
                user.DefaultISOCurrencyCode,
                totalIncome,
                totalExpense,
                totalSavings);
        }
    }
}
