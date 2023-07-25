using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;
using NocturnoWeb.Services;

namespace NocturnoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ArtistsService _artistService;
        private readonly EventsService _eventsService;

        public List<FeaturedArtist> FeaturedArtists { get; set; }
        public List<Event> Events { get; set; }
        public Event LatestEvent { get; set; }

        public IndexModel(ILogger<IndexModel> logger, EventsService eventsService, ArtistsService artistsService)
        {
            _artistService = artistsService;
            _eventsService = eventsService;
            _logger = logger;
        }

        public async Task OnGet()
        {
            Events = await _eventsService.GetEventsAsync(3);
            LatestEvent = await _eventsService.GetLatestEventAsync();
            FeaturedArtists = await _artistService.GetFeaturedArtists();
        }
    }
}