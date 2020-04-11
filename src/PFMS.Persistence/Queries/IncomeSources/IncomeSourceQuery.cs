using PFMS.Domain.Models.IncomeSources;
using PFMS.Domain.Queries.IncomeSources;

namespace PFMS.Persistence.Queries.IncomeSources
{
    public class IncomeSourceQuery : Query<IncomeSource>, IIncomeSourceQuery
    {
        public IncomeSourceQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
