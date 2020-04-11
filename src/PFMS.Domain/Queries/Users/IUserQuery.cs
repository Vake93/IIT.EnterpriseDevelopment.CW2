using PFMS.Domain.Models.Users;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Domain.Queries.Users
{
    public interface IUserQuery : IQuery<User>
    {
        Task<User> FindUserAsync(string userName, CancellationToken cancellationToken = default);
    }
}
