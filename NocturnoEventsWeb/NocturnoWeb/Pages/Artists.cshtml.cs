using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;
using static System.Net.WebRequestMethods;

namespace NocturnoWeb.Pages
{
    public class ArtistsModel : PageModel
    {
        public List<Artist> Artists { get; set; }
        public void OnGet()
        {
            Artists = new List<Artist>()
            {
                new Artist
                {
                    Id = 1,
                    Name = "John Spider",
                    Bio = "Ionut Popovici a.k.a JOHN SPIDER is a trance DJ and producer hailing from Iasi, Romania. He specializes in emotional vibes and outputs a variety of subgenres from deep/progressive trance to hard hitting uplifting and psytrance.",
                    ImageUri = "https://static.wixstatic.com/media/f482ab_29306231646249fb8cd1bc1f7c7efe9c~mv2.jpg/v1/fill/w_1920,h_924,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/f482ab_29306231646249fb8cd1bc1f7c7efe9c~mv2.jpg",
                    LogoUri = "https://storage.rcs-rds.ro/content/links/72a768f0-4076-4ac8-5c1d-2a6ffc9660fe/files/get/logo_white.png?path=%2Flogo_white.png",
                    Video = "https://www.youtube.com/watch?v=Fz4SNnj8gRI",
                    DbSocialLinks = "https://www.facebook.com/djjspider,https://www.youtube.com/@johnspider,https://soundcloud.com/johnspidermusic,https://www.instagram.com/johnspidermusic/,https://www.beatport.com/artist/john-spider/769557"

                },
                new Artist
                {
                    Id = 2,
                    Name = "Crainicu",
                    Bio = "Techno producer and DJ.",
                    ImageUri = "https://crainicu.com/assets/images/crainicu.jpg",
                    LogoUri = "https://crainicu.com/assets/images/crainicu_white.png",
                    Video = "https://www.youtube.com/watch?v=bffbQEvs94E",
                    DbSocialLinks =  "https://www.facebook.com/crainicu,https://www.instagram.com/crainicu_/,https://www.youtube.com/c/Crainicu"
                }
            };
        }
    }
}
