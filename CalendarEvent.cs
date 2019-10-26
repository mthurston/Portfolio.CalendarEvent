using System;
using System.Collections.Generic;

namespace Portfolio.CalendarEvent.Microservice
{
    public class CalendarEvent
    {
        public Guid CalendarEventId { get; set; }

        public IEnumerable<Guid> CalendarIds { get; set; }

        public DateTime DateTimeUtc { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
