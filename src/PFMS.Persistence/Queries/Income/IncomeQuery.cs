using Microsoft.EntityFrameworkCore;
using PFMS.Domain.Queries.Income;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using IncomeModel = PFMS.Domain.Models.Income.Income;

namespace PFMS.Persistence.Queries.Income
{
    public class IncomeQuery : Query<IncomeModel>, IIncomeQuery
    {
        public IncomeQuery(DatabaseContext context)
            : base(context)
        {
        }

        public Task<decimal> GetTotalIncomeAsync(
            Expression<Func<IncomeModel, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<IncomeModel>()
                .AsNoTracking()
                .Where(predicate)
                .SumAsync(i => i.Amount, cancellationToken);
        }
    }
}
