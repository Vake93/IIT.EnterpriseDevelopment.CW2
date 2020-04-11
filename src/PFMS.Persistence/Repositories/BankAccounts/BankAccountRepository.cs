using PFMS.Domain.Models.BankAccounts;
using PFMS.Domain.Repositories.BankAccounts;

namespace PFMS.Persistence.Repositories.BankAccounts
{
    public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
