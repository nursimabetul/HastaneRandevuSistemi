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
        public string Aciklama { get; set; }

        public virtual ICollection<Poliklinik> Poliklinikler { get; set; }
    }
}


