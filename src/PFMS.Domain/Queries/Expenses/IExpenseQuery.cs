using PFMS.Domain.Models.Expenses;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Domain.Queries.Expenses
{
    public interface IExpenseQuery : IQuery<Expense>
    {
        Task<decimal> GetTotalExpenseAsync(
            Expression<Func<Expense, bool>> predicate,
            CancellationToken cancellationToken = default);
    }
}
