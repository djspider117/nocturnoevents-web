using Microsoft.EntityFrameworkCore;
using NocturnoWeb.Data;
using System.Numerics;

namespace NocturnoWeb.Services
{
    public class EventsService
    {
        private readonly NocturnoDbContext _ctx;

        public EventsService(NocturnoDbContext ctx)
        {
            _ctx = ctx;
        }

        private async Task SeedAsync()
        {
            var events = new List<Event>()
            {   new Event
                {
                    Name = "AfterDARK #004",
                    Description = "TODO",
                    DateTime = new DateTime(2023,08,12,21,00,00),
                    CoverUri = "/img/events/ad04-fb-test.jpg",
                    PosterUri = "/img/events/ad04-poster-test.jpg",
                    VenueName = "Oddity Copou",
                    VenueAddress = "Bulevardul Carol I 4, Iași",
                    MapsUri = "https://goo.gl/maps/XXDQWVqgXLwmRd3z9",
                    MapEmbedding = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2712.300963440205!2d27.57280017675273!3d47.17154371791845!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40cafb3a4b319f2f%3A0xc7adaec382d14a48!2sOddity%20Copou!5e0!3m2!1sro!2sro!4v1690323974820!5m2!1sro!2sro"
                },
                new Event
                {
                    Name = "AfterDARK #003",
                    Description = "Nocturno Events would like to welcome you to the third edition of AfterDARK, where we'll serve you with a healthy dose of techno and progressive house music. We would like to invite you Saturday, the 10th of June at ODDITY Copou on 4th Carol I boulevard in Iasi for a night you won't soon forget.",
                    DateTime = new DateTime(2023,06,10,21,00,00),
                    CoverUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/352374181_521939570003847_1035381052089041473_n.png?stp=dst-jpg&_nc_cat=104&ccb=1-7&_nc_sid=19026a&_nc_ohc=d1xqEj9DdEYAX9e71kc&_nc_oc=AQlvvRZr058FBfjCOkBY5rg29tTGcHxBe5LETrM9gmigrAp0RrEo0lW0giaLAAdGgd8&_nc_ht=scontent.fias1-2.fna&oh=00_AfCeW81lVE-DlRV-UhmZNKFHYxmZIkWDjJCHUuFpDZLdCw&oe=64C221D1",
                    PosterUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/352226020_559121299706695_7867892168344441921_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=730e14&_nc_ohc=GrD_oGMSyTcAX_LsPry&_nc_ht=scontent.fias1-2.fna&oh=00_AfCftysyfj_uke4vhQhmuUpBZ3E50Vg_KATVaiEY1WBRMw&oe=64C33449",
                    VenueName = "Oddity Copou",
                    VenueAddress = "Bulevardul Carol I 4, Iași",
                    MapsUri = "https://goo.gl/maps/XXDQWVqgXLwmRd3z9",
                    MapEmbedding = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2712.300963440205!2d27.57280017675273!3d47.17154371791845!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40cafb3a4b319f2f%3A0xc7adaec382d14a48!2sOddity%20Copou!5e0!3m2!1sro!2sro!4v1690323974820!5m2!1sro!2sro"
                },
                new Event
                {
                    Name = "AfterDARK #002",
                    Description = "Nocturno Events would like to welcome you to the second edition of AfterDARK, where we'll serve you with a healty does of techno and progressive house music. We would like to invite you Saturday, the 11th of February at Arcu, House of Beer on 18 Arcu street in Iasi for a night you won't soon forget.",
                    DateTime = new DateTime(2023,02,11,22,00,00),
                    CoverUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/325894935_724163079217291_3997336417686492451_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=730e14&_nc_ohc=wDnTRgsfcfwAX_djBj8&_nc_ht=scontent.fias1-2.fna&oh=00_AfB86dvD0yxfVmm3OP8C1C0lMjchbNlT3kooF3Gonv4K8Q&oe=64C2D9B2",
                    PosterUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/327253490_3309314895986028_5837408892811883225_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=730e14&_nc_ohc=-NI5352lUQAAX-ll-Wv&_nc_ht=scontent.fias1-2.fna&oh=00_AfDndWMKqF56Y4l-Q6B161FF-6ln_UgT2err3l2rt3copA&oe=64C2D139",
                    VenueName = "ARCU, House of Beer",
                    VenueAddress = "Iași, Strada Arcu, nr. 18",
                    MapsUri = "https://goo.gl/maps/fxX2rzKHHgDRGiwn6",
                    MapEmbedding = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2712.5266635335743!2d27.570817591737427!3d47.16712414385061!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40cafb339cb459af%3A0x74fbb2f04f542385!2sArcu%20House%20of%20Beer!5e0!3m2!1sro!2sro!4v1690324525760!5m2!1sro!2sro"
                },
                new Event
                {
                    Name = "AfterDARK #001",
                    Description = "Nocturno Events presents the first edition of the AfterDARK concept where we'll serve you with a healthy does of electronic music from genres like progressive & melodic house, trance, techno and many more. We would like to invite you Saturday, the 19th of November at Arcu, House of Beer on 18 Arcu street in Iasi for a night you won't soon forget.",
                    DateTime = new DateTime(2022,11,19,22,00,00),
                    CoverUri = "https://static.iabilet.ro/img/auto_resized/db/event/01/37/9c/00000199325-09cf-800x800-n-ea16908c.png",
                    PosterUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/316123439_127104616850090_5426185151048108449_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=730e14&_nc_ohc=Yp2TCGAKWIoAX-ClCh8&_nc_ht=scontent.fias1-2.fna&oh=00_AfDbvPvpq-RixcakXF_UH0-1p6ZeLqbvU_LYYH16JY4p5w&oe=64C31D4D",
                    VenueName = "ARCU, House of Beer",
                    VenueAddress = "Iași, Strada Arcu, nr. 18",
                    MapsUri = "https://goo.gl/maps/fxX2rzKHHgDRGiwn6",
                    MapEmbedding = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2712.5266635335743!2d27.570817591737427!3d47.16712414385061!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40cafb339cb459af%3A0x74fbb2f04f542385!2sArcu%20House%20of%20Beer!5e0!3m2!1sro!2sro!4v1690324525760!5m2!1sro!2sro"
                },
            };

            foreach (var x in events)
            {
                _ctx.Events.Add(x);
            }

            await _ctx.SaveChangesAsync();
        }

        public async Task<List<Event>> GetEventsAsync(int take = 0)
        {
            var count = await _ctx.Events.CountAsync();
            if (count <= 0)
                await SeedAsync();

            var q = _ctx.Events.AsNoTracking();
            if (take > 0)
                q = q.Take(take);

            return await q.ToListAsync();
        }

        public async Task<List<Event>> GetPastEventsAsync()
        {
            var count = await _ctx.Events.CountAsync();
            if (count <= 0)
                await SeedAsync();

            return await _ctx.Events.Where(x => x.DateTime < DateTime.Now).AsNoTracking().ToListAsync();
        }

        public async Task<List<Event>> GetFutureEventsAsync()
        {
            var count = await _ctx.Events.CountAsync();
            if (count <= 0)
                await SeedAsync();

            return await _ctx.Events.Where(x => x.DateTime >= DateTime.Now).AsNoTracking().ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _ctx.Events.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Event> GetLatestEventAsync()
        {
            return await _ctx.Events.OrderByDescending(x => x.DateTime)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync();
        }
    }
}
