using PFMS.Domain.Models.Expenses;
using PFMS.Domain.Repositories.Expenses;

namespace PFMS.Persistence.Repositories.Expenses
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
