using System;

namespace PFMS.Domain.Models
{
    public abstract class Entity : IEntity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; protected set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public virtual bool Deleted { get; set; }

        public virtual void Delete()
        {
            Deleted = true;
        }
    }
}
