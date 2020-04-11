using PFMS.Domain.Models.Currencies;
using PFMS.Domain.Repositories.Currencies;

namespace PFMS.Persistence.Repositories.Currencies
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
