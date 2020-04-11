using PFMS.Domain.Models.ExpenseSources;
using PFMS.Domain.Repositories.ExpenseSources;

namespace PFMS.Persistence.Repositories.ExpenseSources
{
    public class ExpenseSourceRepository : Repository<ExpenseSource>, IExpenseSourceRepository
    {
        public ExpenseSourceRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
