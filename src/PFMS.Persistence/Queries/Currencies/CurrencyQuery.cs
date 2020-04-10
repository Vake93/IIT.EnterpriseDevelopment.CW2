using PFMS.Domain.Models.Currencies;
using PFMS.Domain.Queries.Currencies;

namespace PFMS.Persistence.Queries.Currencies
{
    public class CurrencyQuery : Query<Currency>, ICurrencyQuery
    {
        public CurrencyQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
