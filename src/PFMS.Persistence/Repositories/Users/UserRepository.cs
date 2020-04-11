using Microsoft.EntityFrameworkCore;
using PFMS.Domain.Models.Users;
using PFMS.Domain.Repositories.Users;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Persistence.Repositories.Users
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext context)
            : base(context)
        {
        }

        public Task<User> FindUserAsync(string userName, CancellationToken cancellationToken = default)
        {
            return Context
                .Set<User>()
                .FirstOrDefaultAsync(u => u.UserName == userName && !u.Deleted, cancellationToken);
        }
    }
}
