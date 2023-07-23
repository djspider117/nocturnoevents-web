using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;
using NocturnoWeb.Services;

namespace NocturnoWeb.Pages
{
    public class ArtistModel : PageModel
    {
        private readonly ArtistsService _artistsService;

        public Artist Artist { get; set; }

        public ArtistModel(ArtistsService artistsService)
        {
            _artistsService = artistsService;
        }

        public async Task OnGetAsync(int id)
        {
            Artist = await _artistsService.GetArtistByIdAsync(id);
        }
    }
}
