using System.ComponentModel.DataAnnotations;

namespace TekKatmanliCorePortfolio.DAL.Entities
{
    public class Feature
    {
        [Key]
        public int FeautreID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
