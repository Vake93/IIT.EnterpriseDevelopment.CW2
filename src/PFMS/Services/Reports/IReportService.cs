using System;
using System.Threading.Tasks;

namespace PFMS.Services.Reports
{
    public interface IReportService
    {
        Task<MonthlySummeryReport> GetMonthlySummeryReportAsync(int year, int month);

        Task<FinancialForecast> GenerateFinancialForecast(DateTime date);
    }
}