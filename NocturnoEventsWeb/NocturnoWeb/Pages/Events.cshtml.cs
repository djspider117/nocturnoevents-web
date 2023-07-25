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

        public List<Event> PastEvents { get; set; }
        public List<Event> FutureEvents { get; set; }

        public EventsModel(EventsService eventsService)
        {
            _eventsService = eventsService;
        }

        public async Task OnGet()
        {
            PastEvents = await _eventsService.GetPastEventsAsync();
            FutureEvents = await _eventsService.GetFutureEventsAsync();
        }
    }

}
