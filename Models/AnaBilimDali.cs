using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class AnaBilimDali
    {
        [Key]
        public int AnaBilimDaliID { get; set; }
        public string AnaBilimDaliAdi { get; set; }
        public string Aciklama { get; set; }
 
    }
}
