using PFMS.Domain.Models.BankAccounts;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Domain.Queries.BankAccounts
{
    public interface IBankAccountQuery : IQuery<BankAccount>
    {
        Task<decimal> GetTotalAsync(
            Expression<Func<BankAccount, bool>> predicate,
            CancellationToken cancellationToken = default);
    }
}
