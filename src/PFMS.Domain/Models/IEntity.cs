using System;

namespace PFMS.Domain.Models
{
    public interface IEntity
    {
        Guid Id { get; }

        DateTime Created { get; set; }

        DateTime Modified { get; set; }
    }
}
