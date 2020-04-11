using PFMS.Domain.Models.Users;
using PFMS.Domain.Queries.Users;

namespace PFMS.Persistence.Queries.Users
{
    public class UserQuery : Query<User>, IUserQuery
    {
        public UserQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
