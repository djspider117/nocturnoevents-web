using Microsoft.EntityFrameworkCore;
using NocturnoWeb.Data;

namespace NocturnoWeb.Services
{
    public class ArtistsService
    {
        private readonly NocturnoDbContext _ctx;

        public ArtistsService(NocturnoDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task SeedAsync()
        {
            var artists = new List<Artist>()
            {
                new Artist
                {
                    Name = "John Spider",
                    StyleLine = "deep//progressive//trance//psy",
                    Bio = "John Spider is a talented trance and progressive DJ and producer hailing from Iasi, Romania. He has made a name for himself in the electronic dance music scene with his unique style that blends deep and progressive vibes with high-energy trance sounds.\r\nHis music is characterized by its emotional quality, and he has a particular affinity for creating tracks that evoke powerful feelings in his listeners.\r\n\r\nJohn has had the opportunity to perform at events in several cities, including London, Bucharest, and Iasi. These performances have given him the chance to connect with audiences and showcase his DJ skills, solidifying his reputation as a talented and versatile artist.\r\n\r\nAs a producer, John has released tracks and remixes on several labels, including Alter Ego, Arkham Digital, and Boomtic Records. He has worked with a range of talented artists and has consistently demonstrated his ability to create innovative and dynamic tracks that push the boundaries of trance and progressive music.\r\n\r\nJohn has also had the opportunity to play on stage with some of the biggest names in the trance and progressive music scene, including Davey Asprey and Mickey Marr. These experiences have given him the chance to learn from some of the best in the business and have undoubtedly helped him to further develop his own unique style and sound.\r\n\r\nOverall, John Spider is a rising star in the trance and progressive music scene, and his emotional, high-energy tracks and performances have earned him a growing fanbase and recognition as a talented and innovative artist.",
                    CoverUri = "https://static.wixstatic.com/media/f482ab_29306231646249fb8cd1bc1f7c7efe9c~mv2.jpg/v1/fill/w_1920,h_924,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/f482ab_29306231646249fb8cd1bc1f7c7efe9c~mv2.jpg",
                    ImageUri = "https://static.wixstatic.com/media/f482ab_fea98be3ed4f48c0b1ea134f2d1dafca~mv2.jpg/v1/fill/w_1000,h_751,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/f482ab_fea98be3ed4f48c0b1ea134f2d1dafca~mv2.jpg",
                    LogoUri = "https://storage.rcs-rds.ro/content/links/72a768f0-4076-4ac8-5c1d-2a6ffc9660fe/files/get/logo_white.png?path=%2Flogo_white.png",
                    Video = "https://www.youtube.com/embed/Fz4SNnj8gRI",
                    DbSocialLinks = "https://www.facebook.com/djjspider,https://www.youtube.com/@johnspider,https://soundcloud.com/johnspidermusic,https://www.instagram.com/johnspidermusic/,https://www.beatport.com/artist/john-spider/769557"
                },
                new Artist
                {
                    Name = "Crainicu",
                    StyleLine = "hard techno//trance",
                    Bio = "Crainicu is a passionate Techno DJ and producer who has been devoted to electronic music since 2008. With a focus on mixing since 2020, he has developed a signature sound based on Acid and high energy performances that were heard in cities like Bucharest, Iasi and Timisoara. \r\nIn addition to his techno sets, he has also lent his talents to the Romanian Trance Family, performing sets for their weekly radioshow on Trance Energy Radio. With a love for the genre that shines through in every beat, he is a rising star in the world of electronic music.",
                    CoverUri = "https://scontent.fias1-1.fna.fbcdn.net/v/t39.30808-6/335294108_175049155297957_1944003770819148287_n.png?_nc_cat=100&ccb=1-7&_nc_sid=e3f864&_nc_ohc=rd2Y_ZS3wvkAX-53JuH&_nc_ht=scontent.fias1-1.fna&oh=00_AfCEn1nl-MxUgbkeB-kKZmi5ITi1GhB76zZXgz_m_zQsbQ&oe=64C34CA4",
                    ImageUri = "https://scontent.fias1-1.fna.fbcdn.net/v/t39.30808-6/327154007_3457678767889632_389392511855682412_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=vptIy3WBWxUAX-HfP3A&_nc_ht=scontent.fias1-1.fna&oh=00_AfCKd1tIhiLPGIRQYyqvI908YaZ6p784zDX8-G13YT12ew&oe=64C30732",
                    LogoUri = "https://crainicu.com/assets/images/crainicu_white.png",
                    Video = "https://www.youtube.com/embed/bffbQEvs94E",
                    DbSocialLinks =  "https://www.facebook.com/crainicu,https://www.instagram.com/crainicu_/,https://www.youtube.com/c/Crainicu"
                }
            };

            foreach (var item in artists)
            {
                _ctx.Artists.Add(item);
            }

            await _ctx.SaveChangesAsync();
        }

        public async Task<List<Artist>> GetArtistsAsync()
        {
            var count = await _ctx.Artists.CountAsync();
            if (count <= 0)
                await SeedAsync();

            return await _ctx.Artists.AsNoTracking().ToListAsync();
        }

        public async Task<Artist> GetArtistByIdAsync(int id)
        {
            return await _ctx.Artists.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<FeaturedArtist>> GetFeaturedArtists()
        {
            return await _ctx.Artists.AsNoTracking().Select(x => new FeaturedArtist{ Id = x.Id, ImageUri = x.ImageUri, Name = x.Name }).ToListAsync();
        }
    }
}
