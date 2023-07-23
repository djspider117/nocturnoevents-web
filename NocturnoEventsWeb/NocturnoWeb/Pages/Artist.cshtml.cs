using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NocturnoWeb.Data;

namespace NocturnoWeb.Pages
{
    public class ArtistModel : PageModel
    {
        public Artist Artist { get; set; }

        public void OnGet(int id)
        {
            Artist = new Artist
            {
                Id = 1,
                StyleLine = "deep//progressive//trance//psy",
                Name = "John Spider",
                Bio = "John Spider is a talented trance and progressive DJ and producer hailing from Iasi, Romania. He has made a name for himself in the electronic dance music scene with his unique style that blends deep and progressive vibes with high-energy trance sounds.\r\nHis music is characterized by its emotional quality, and he has a particular affinity for creating tracks that evoke powerful feelings in his listeners.\r\n\r\nJohn has had the opportunity to perform at events in several cities, including London, Bucharest, and Iasi. These performances have given him the chance to connect with audiences and showcase his DJ skills, solidifying his reputation as a talented and versatile artist.\r\n\r\nAs a producer, John has released tracks and remixes on several labels, including Alter Ego, Arkham Digital, and Boomtic Records. He has worked with a range of talented artists and has consistently demonstrated his ability to create innovative and dynamic tracks that push the boundaries of trance and progressive music.\r\n\r\nJohn has also had the opportunity to play on stage with some of the biggest names in the trance and progressive music scene, including Davey Asprey and Mickey Marr. These experiences have given him the chance to learn from some of the best in the business and have undoubtedly helped him to further develop his own unique style and sound.\r\n\r\nOverall, John Spider is a rising star in the trance and progressive music scene, and his emotional, high-energy tracks and performances have earned him a growing fanbase and recognition as a talented and innovative artist.",
                CoverUri = "https://static.wixstatic.com/media/f482ab_29306231646249fb8cd1bc1f7c7efe9c~mv2.jpg/v1/fill/w_1920,h_924,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/f482ab_29306231646249fb8cd1bc1f7c7efe9c~mv2.jpg",
                ImageUri = "https://static.wixstatic.com/media/f482ab_fea98be3ed4f48c0b1ea134f2d1dafca~mv2.jpg/v1/fill/w_1000,h_751,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/f482ab_fea98be3ed4f48c0b1ea134f2d1dafca~mv2.jpg",
                LogoUri = "https://storage.rcs-rds.ro/content/links/72a768f0-4076-4ac8-5c1d-2a6ffc9660fe/files/get/logo_white.png?path=%2Flogo_white.png",
                Video = "https://www.youtube.com/embed/Fz4SNnj8gRI",
                DbSocialLinks = "https://www.facebook.com/djjspider,https://www.youtube.com/@johnspider,https://soundcloud.com/johnspidermusic,https://www.instagram.com/johnspidermusic/,https://www.beatport.com/artist/john-spider/769557"
            };
        }
    }
}
