using PFMS.Persistence;
using System.Threading.Tasks;

namespace PFMS.Seeders
{
    public sealed class SeedOchestrator
    {
        public static async Task SeedAsync(DatabaseContext context)
        {
            await new CurrencySeeder()
                .SeedAsync(context);
        }
    }
}
