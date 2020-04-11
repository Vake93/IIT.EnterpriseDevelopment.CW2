using PFMS.Domain.Models.ExpenseSources;
using PFMS.Domain.Queries.ExpenseSources;

namespace PFMS.Persistence.Queries.ExpenseSources
{
    public class ExpenseSourceQuery : Query<ExpenseSource>, IExpenseSourceQuery
    {
        public ExpenseSourceQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
