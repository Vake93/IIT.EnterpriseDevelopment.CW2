using PFMS.Domain.Models.IncomeSources;
using PFMS.Domain.Repositories.IncomeSources;

namespace PFMS.Persistence.Repositories.IncomeSources
{
    public class IncomeSourceRepository : Repository<IncomeSource>, IIncomeSourceRepository
    {
        public IncomeSourceRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
