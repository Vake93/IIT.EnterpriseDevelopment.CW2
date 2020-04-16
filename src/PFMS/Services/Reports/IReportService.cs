using System.Threading.Tasks;

namespace PFMS.Services.Reports
{
    public interface IReportService
    {
        Task<MonthlySummeryReport> GetMonthlySummeryReportAsync(int year, int month);
    }
}