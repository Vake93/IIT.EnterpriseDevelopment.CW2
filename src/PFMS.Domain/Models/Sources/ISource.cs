using PFMS.Domain.Models.Users;
using System;

namespace PFMS.Domain.Models.Sources
{
    public interface ISource : IEntity
    {
        string Title { get; set; }

        string Description { get; set; }

        Guid UserId { get; set; }

        User User { get; set; }
    }
}
