using PFMS.Persistence;
using System.Threading.Tasks;

namespace PFMS.Seeders
{
    public interface ISeeder
    {
        Task SeedAsync(DatabaseContext context);
    }
}
