using PFMS.Domain.Models.Events;
using PFMS.Domain.Repositories.Events;

namespace PFMS.Persistence.Repositories.Events
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
