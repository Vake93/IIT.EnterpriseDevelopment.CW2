using Microsoft.EntityFrameworkCore;
using PFMS.Domain.Models.Expenses;
using PFMS.Domain.Queries.Expenses;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Persistence.Queries.Expenses
{
    public class ExpenseQuery : Query<Expense>, IExpenseQuery
    {
        public ExpenseQuery(DatabaseContext context)
            : base(context)
        {
        }

        public Task<decimal> GetTotalExpenseAsync(
            Expression<Func<Expense, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<Expense>()
                .AsNoTracking()
                .Where(predicate)
                .SumAsync(i => i.Amount, cancellationToken);
        }
    }
}
