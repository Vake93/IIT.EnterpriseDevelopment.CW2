using Microsoft.EntityFrameworkCore;
using PFMS.Domain.Models.Currencies;
using PFMS.Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PFMS.Seeders
{
    public class CurrencySeeder : ISeeder
    {
        private static readonly Currency[] Currencies = new Currency[]
        {
            new Currency("Euro", "EUR", "€"),
            new Currency("Pound Sterling", "GBP", "£"),
            new Currency("United States Dollar", "USD", "$"),
            new Currency("Sri Lankan Rupee", "LKR", "රු"),
        };

        public async Task SeedAsync(DatabaseContext context)
        {
            var existingRecords = await context
                .Set<Currency>()
                .AsNoTracking()
                .ToArrayAsync();

            var newRecords = Currencies
                .Where(c => Array.Find(existingRecords, er => er.ISOCurrencyCode == c.ISOCurrencyCode) is null)
                .ToArray();

            if (newRecords.Length > 0)
            {
                context.Set<Currency>().AddRange(newRecords);
                await context.SaveChangesAsync();
            }
        }
    }
}
