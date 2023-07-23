using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;
using NocturnoWeb.Services;
using static System.Net.WebRequestMethods;

namespace NocturnoWeb.Pages
{
    public class ArtistsModel : PageModel
    {
        private readonly ArtistsService _artistsService;

        public List<Artist> Artists { get; set; }

        public ArtistsModel(ArtistsService artistsService)
        {
            _artistsService = artistsService;
        }

        public async Task OnGetAsync()
        {
            Artists = await _artistsService.GetArtistsAsync();
        }
    }
}
