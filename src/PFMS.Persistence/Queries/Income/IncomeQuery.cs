using PFMS.Domain.Queries.Income;
using IncomeModel = PFMS.Domain.Models.Income.Income;

namespace PFMS.Persistence.Queries.Income
{
    public class IncomeQuery : Query<IncomeModel>, IIncomeQuery
    {
        public IncomeQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
