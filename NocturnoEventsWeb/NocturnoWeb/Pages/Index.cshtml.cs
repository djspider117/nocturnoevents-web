using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;
using NocturnoWeb.Services;

namespace NocturnoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly EventsService _eventsService;

        public List<FeaturedArtist> FeaturedArtists { get; set; }
        public List<Event> Events { get; set; }

        public IndexModel(ILogger<IndexModel> logger, EventsService eventsService)
        {
            _eventsService = eventsService;
            _logger = logger;
            FeaturedArtists = new List<FeaturedArtist>
            {
                new FeaturedArtist
                {
                    Id = 1,
                    ImageUri = "https://picsum.photos/400/400?random=1",
                    Name = "John Spider"
                },
                new FeaturedArtist
                {
                    Id = 2,
                    ImageUri = "https://picsum.photos/400/400?random=2",
                    Name = "Crainicu"
                },
                new FeaturedArtist
                {
                    Id = 3,
                    ImageUri = "https://picsum.photos/400/400?random=3",
                    Name = "DanTECH"
                },
                new FeaturedArtist
                {
                    Id = 4,
                    ImageUri = "https://picsum.photos/400/400?random=4",
                    Name = "Iulian Toma"
                },
                new FeaturedArtist
                {
                    Id = 5,
                    ImageUri = "https://picsum.photos/400/400?random=9",
                    Name = "mRaw"
                },
            };
        }

        public async Task OnGet()
        {
            Events = await _eventsService.GetEventsAsync();
        }
    }
}