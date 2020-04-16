using PFMS.Domain.Models.Users;
using System;

namespace PFMS.Domain.Models.Events
{
    public class Event : Entity
    {
        public Event(Guid userId, string title, DateTime dateTime)
        {
            UserId = userId;
            Title = title;
            DateTime = dateTime;
        }

        private Event()
        {
            Title = string.Empty;
        }

        public Guid UserId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public string Location { get; set; }

        public DateTime DateTime { get; set; }

        public int Duration { get; set; }

        public User User { get; set; }
    }
}
