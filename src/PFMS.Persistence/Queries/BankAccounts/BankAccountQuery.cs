using PFMS.Domain.Models.BankAccounts;
using PFMS.Domain.Queries.BankAccounts;

namespace PFMS.Persistence.Queries.BankAccounts
{
    public class BankAccountQuery : Query<BankAccount>, IBankAccountQuery
    {
        public BankAccountQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
