using PFMS.Domain.Models.Expenses;
using PFMS.Domain.Queries.Expenses;

namespace PFMS.Persistence.Queries.Expenses
{
    public class ExpenseQuery : Query<Expense>, IExpenseQuery
    {
        public ExpenseQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
