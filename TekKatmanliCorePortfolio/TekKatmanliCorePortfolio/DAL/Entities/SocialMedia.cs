using System.ComponentModel.DataAnnotations;

namespace TekKatmanliCorePortfolio.DAL.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
