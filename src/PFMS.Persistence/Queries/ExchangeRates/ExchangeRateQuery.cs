using PFMS.Domain.Models.ExchangeRates;
using PFMS.Domain.Queries.ExchangeRates;

namespace PFMS.Persistence.Queries.ExchangeRates
{
    public class ExchangeRateQuery : Query<ExchangeRate>, IExchangeRateQuery
    {
        public ExchangeRateQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
