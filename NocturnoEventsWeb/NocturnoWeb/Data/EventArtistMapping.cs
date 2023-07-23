namespace NocturnoWeb.Data
{
    public class EventArtistMapping
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int ArtistId { get; set; }

        public Event Event { get; set; }
        public Artist Artist { get; set; }
    }
}
