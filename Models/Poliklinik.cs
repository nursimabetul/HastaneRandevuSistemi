using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Models
{
    public class Poliklinik
    {
        public int PoliklinikId { get; set; }

        [Required(ErrorMessage = "Poliklinik Adı zorunludur.")]
        [Display(Name = "Poliklinik Adı")]
        public string PoliklinikAdi { get; set; }

        [Required(ErrorMessage = "Ana Bilim Dalı zorunludur.")]
        [ForeignKey("AnaBilimDali")]
        public int AnaBilimDaliID { get; set; }

        [Display(Name = "Ana Bilim Dalı")]
        public AnaBilimDali AnaBilimDali { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
    }
}
