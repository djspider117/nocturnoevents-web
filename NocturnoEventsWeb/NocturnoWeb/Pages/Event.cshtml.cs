using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;
using NocturnoWeb.Services;

namespace NocturnoWeb.Pages
{
    public class EventModel : PageModel
    {
        private readonly EventsService _eventService;
        public Event Event { get; private set; }

        public EventModel(EventsService eventService)
        {
            _eventService = eventService;
        }

        public async Task OnGetAsync(int id)
        {
            Event = await _eventService.GetEventByIdAsync(id);
        }
    }
}
