using System.ComponentModel.DataAnnotations.Schema;

namespace NocturnoWeb.Data
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUri { get; set; }
        public string LogoUri { get; set; }
        public string Bio { get; set; }
        public string Video { get; set; }
        public string CoverUri { get; set; }
        public string StyleLine { get; set; }

        public string DbSocialLinks { get; set; }


        [NotMapped]
        public IEnumerable<string> SocialLinks => DbSocialLinks.Split(',');
    }
}
