using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using IncomeModel = PFMS.Domain.Models.Income.Income;

namespace PFMS.Domain.Queries.Income
{
    public interface IIncomeQuery : IQuery<IncomeModel>
    {
        Task<decimal> GetTotalIncomeAsync(
            Expression<Func<IncomeModel, bool>> predicate,
            CancellationToken cancellationToken = default);
    }
}
