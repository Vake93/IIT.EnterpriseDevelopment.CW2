using PFMS.Domain.Models.Users;
using PFMS.Domain.Repositories.Users;

namespace PFMS.Persistence.Repositories.Users
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
