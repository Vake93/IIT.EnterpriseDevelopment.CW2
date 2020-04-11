using PFMS.Domain.Repositories.Income;
using IncomeModel = PFMS.Domain.Models.Income.Income;

namespace PFMS.Persistence.Repositories.Income
{
    public class IncomeRepository : Repository<IncomeModel>, IIncomeRepository
    {
        public IncomeRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
