using System.ComponentModel.DataAnnotations;

namespace TekKatmanliCorePortfolio.DAL.Entities
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Phone1{ get; set; }
        public string Phone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2{ get; set; }
    }
}
