using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class CalismaSaati
    {
        [Key]
        public int CalismaSaatiId { get; set; }
        public string DoktorCalismaSaati { get; set; }
    }
}
