using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Portfolio.CalendarEvent.Microservice.Controllers
{
    [ApiController]
    [Route("api/calendar-event")]
    public class CalendarEventController : ControllerBase
    {
        private readonly ILogger<CalendarEventController> _logger;

        public CalendarEventController(ILogger<CalendarEventController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<CalendarEvent>>> GetAsync()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<CalendarEvent>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("calendar/{calendarId:int}")]
        public async Task<ActionResult<IEnumerable<CalendarEvent>>> GetByCalendarIdAsync(int calendarId)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] CalendarEvent calendarEvent)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<int>> CreateAsync([FromBody] CalendarEvent calendarEvent)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
