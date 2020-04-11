using PFMS.Domain.Models.Users;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Domain.Repositories.Users
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> FindUserAsync(string userName, CancellationToken cancellationToken = default);
    }
}
