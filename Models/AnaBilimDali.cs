using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class AnaBilimDali
    {
        [Key]
        public int AnaBilimDaliID { get; set; }

        [Required(ErrorMessage = "Ana Bilim Dalı Adı zorunludur.")]
        [Display(Name = "Ana Bilim Dalı Adı")]
        public string AnaBilimDaliAdi { get; set; }

        [Display(Name = "Açıklama")]
        public string? Aciklama { get; set; }// null olabilir.
 
    }
}
