using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;
using NocturnoWeb.Services;
using System.Numerics;

namespace NocturnoWeb.Pages
{
    public class EventsModel : PageModel
    {
        private readonly EventsService _eventsService;

        public List<Event> Events { get; set; }

        public EventsModel(EventsService eventsService)
        {
            _eventsService = eventsService;
        }

        public async Task OnGet()
        {
            Events = await _eventsService.GetEventsAsync();
        }
    }

}
