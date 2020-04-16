using Microsoft.EntityFrameworkCore;
using PFMS.Domain.Models.BankAccounts;
using PFMS.Domain.Queries.BankAccounts;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Persistence.Queries.BankAccounts
{
    public class BankAccountQuery : Query<BankAccount>, IBankAccountQuery
    {
        public BankAccountQuery(DatabaseContext context)
            : base(context)
        {
        }

        public Task<decimal> GetTotalAsync(
            Expression<Func<BankAccount, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return Context
                .Set<BankAccount>()
                .AsNoTracking()
                .Where(predicate)
                .SumAsync(i => i.Balance, cancellationToken);
        }
    }
}
