using System.Numerics;

namespace NocturnoWeb.Data
{
    public class EventsService
    {
        private List<Event> _events;

        public EventsService()
        {
            _events = new List<Event>()
            {
                new Event
                {
                    Name = "AfterDARK #003",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DateTime = new DateTime(2022,12,16,23,00,00),
                    TicketsUrl = "https://picsum.photos/600/600?random=12",
                    ThumbnailSource = "https://picsum.photos/600/600?random=11762",
                    VenueName = "ARCU, House of Beer",
                    VenueAddress = "Iași, Strada Arcu, nr. 18"
                },
                new Event
                {
                    Name = "AfterDARK #002",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DateTime = new DateTime(2022,11,11,23,00,00),
                    TicketsUrl = "https://picsum.photos/600/600?random=152",
                    ThumbnailSource = "https://picsum.photos/600/600?random=142",
                    VenueName = "ARCU, House of Beer",
                    VenueAddress = "Iași, Strada Arcu, nr. 18"
                },
                new Event
                {
                    Name = "AfterDARK #001",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DateTime = new DateTime(2022,10,23,23,00,00),
                    TicketsUrl = "https://picsum.photos/600/600?random=1232",
                    ThumbnailSource = "https://picsum.photos/600/600?random=122",
                    VenueName = "ARCU, House of Beer",
                    VenueAddress = "Iași, Strada Arcu, nr. 18"
                },
            };
        }

        public Task<List<Event>> GetEventsAsync() => Task.FromResult(_events);

    }
}
