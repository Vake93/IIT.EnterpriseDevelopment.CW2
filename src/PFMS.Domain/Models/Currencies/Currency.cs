namespace PFMS.Domain.Models.Currencies
{
    public class Currency : Entity
    {
        public Currency(string name, string currencyCode, string symbol)
        {
            Name = name;
            ISOCurrencyCode = currencyCode;
            Symbol = symbol;
        }

        private Currency()
        {
            Name = string.Empty;
            ISOCurrencyCode = string.Empty;
            Symbol = string.Empty;
        }

        public string Name { get; set; }

        public string ISOCurrencyCode { get; set; }

        public string Symbol { get; set; }
    }
}
