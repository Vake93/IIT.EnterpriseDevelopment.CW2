using Microsoft.EntityFrameworkCore;
using PFMS.Domain.Models.Users;
using PFMS.Domain.Queries.Users;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Persistence.Queries.Users
{
    public class UserQuery : Query<User>, IUserQuery
    {
        public UserQuery(DatabaseContext context)
            : base(context)
        {
        }

        public Task<User> FindUserAsync(string userName, CancellationToken cancellationToken = default)
        {
            return Context
                .Set<User>()
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.UserName == userName && !u.Deleted, cancellationToken);
        }
    }
}
