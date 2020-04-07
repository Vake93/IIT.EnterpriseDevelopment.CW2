using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Domain
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
