using System.Numerics;

namespace NocturnoWeb.Data
{
    public class Event
    {
        public int Id { get; set; }
        public string ThumbnailSource { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

        public string VenueName { get; set; }
        public string VenueAddress { get; set; }

        public string TicketsUrl { get; set; }
    }
}
