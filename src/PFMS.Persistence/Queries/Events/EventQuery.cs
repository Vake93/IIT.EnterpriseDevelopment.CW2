using PFMS.Domain.Models.Events;
using PFMS.Domain.Queries.Events;

namespace PFMS.Persistence.Queries.Events
{
    public class EventQuery : Query<Event>, IEventQuery
    {
        public EventQuery(DatabaseContext context)
            : base(context)
        {
        }
    }
}
