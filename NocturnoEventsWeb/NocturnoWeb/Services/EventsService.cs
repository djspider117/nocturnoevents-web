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
            {
                new Event
                {
                    Name = "AfterDARK #003",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DateTime = new DateTime(2023,06,10,21,00,00),
                    CoverUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/352374181_521939570003847_1035381052089041473_n.png?stp=dst-jpg&_nc_cat=104&ccb=1-7&_nc_sid=19026a&_nc_ohc=d1xqEj9DdEYAX9e71kc&_nc_oc=AQlvvRZr058FBfjCOkBY5rg29tTGcHxBe5LETrM9gmigrAp0RrEo0lW0giaLAAdGgd8&_nc_ht=scontent.fias1-2.fna&oh=00_AfCeW81lVE-DlRV-UhmZNKFHYxmZIkWDjJCHUuFpDZLdCw&oe=64C221D1",
                    PosterUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/352226020_559121299706695_7867892168344441921_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=730e14&_nc_ohc=GrD_oGMSyTcAX_LsPry&_nc_ht=scontent.fias1-2.fna&oh=00_AfCftysyfj_uke4vhQhmuUpBZ3E50Vg_KATVaiEY1WBRMw&oe=64C33449",
                    VenueName = "Oddity Copou",
                    VenueAddress = "Bulevardul Carol I 4, Iași"
                },
                new Event
                {
                    Name = "AfterDARK #002",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DateTime = new DateTime(2023,02,11,22,00,00),
                    CoverUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/325894935_724163079217291_3997336417686492451_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=730e14&_nc_ohc=wDnTRgsfcfwAX_djBj8&_nc_ht=scontent.fias1-2.fna&oh=00_AfB86dvD0yxfVmm3OP8C1C0lMjchbNlT3kooF3Gonv4K8Q&oe=64C2D9B2",
                    PosterUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/327253490_3309314895986028_5837408892811883225_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=730e14&_nc_ohc=-NI5352lUQAAX-ll-Wv&_nc_ht=scontent.fias1-2.fna&oh=00_AfDndWMKqF56Y4l-Q6B161FF-6ln_UgT2err3l2rt3copA&oe=64C2D139",
                    VenueName = "ARCU, House of Beer",
                    VenueAddress = "Iași, Strada Arcu, nr. 18"
                },
                new Event
                {
                    Name = "AfterDARK #001",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DateTime = new DateTime(2022,11,19,22,00,00),
                    CoverUri = "https://static.iabilet.ro/img/auto_resized/db/event/01/37/9c/00000199325-09cf-800x800-n-ea16908c.png",
                    PosterUri = "https://scontent.fias1-2.fna.fbcdn.net/v/t39.30808-6/316123439_127104616850090_5426185151048108449_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=730e14&_nc_ohc=Yp2TCGAKWIoAX-ClCh8&_nc_ht=scontent.fias1-2.fna&oh=00_AfDbvPvpq-RixcakXF_UH0-1p6ZeLqbvU_LYYH16JY4p5w&oe=64C31D4D",
                    VenueName = "ARCU, House of Beer",
                    VenueAddress = "Iași, Strada Arcu, nr. 18"
                },
            };

            foreach (var x in events)
            {
                _ctx.Events.Add(x);
            }

            await _ctx.SaveChangesAsync();
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            var count = await _ctx.Events.CountAsync();
            if (count <= 0)
                await SeedAsync();

            return await _ctx.Events.AsNoTracking().ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _ctx.Events.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
