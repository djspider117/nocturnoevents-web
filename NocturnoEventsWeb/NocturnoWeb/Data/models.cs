namespace NocturnoWeb.Data
{
    public class models
    {
    }

    public class FeaturedArtist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUri { get; set; }
    }

    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUri { get; set; }
        public string LogoUri { get; set; }
        public string Bio { get; set; }
        public string Video { get; set; }
        public List<string> SocialLinks { get; set; }
        public string CoverUri { get; set; }
        public string StyleLine { get; set; }
    }
}
