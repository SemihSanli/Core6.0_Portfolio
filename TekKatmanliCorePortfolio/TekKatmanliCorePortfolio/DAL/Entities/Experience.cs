using System.ComponentModel.DataAnnotations;

namespace TekKatmanliCorePortfolio.DAL.Entities
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string Header { get; set; }
        public string PersonTitle { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}
