using PFMS.Domain.Models.ExchangeRates;
using PFMS.Domain.Repositories.ExchangeRates;

namespace PFMS.Persistence.Repositories.ExchangeRates
{
    public class ExchangeRateRepository : Repository<ExchangeRate>, IExchangeRateRepository
    {
        public ExchangeRateRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
