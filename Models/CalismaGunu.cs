using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class CalismaGunu
    {
        [Key]
        public int CalismaGunuiId { get; set; }
        public DateTime DoktorCalismaGunu{ get; set; }
    }
}
