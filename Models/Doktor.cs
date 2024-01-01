using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Models
{
    public class Doktor
    {
        [Key]
		public int DoktorId { get; set; }
		public string DoktorAdi { get; set; }



		[ForeignKey("Poliklinik")]
        public int PoliklinikID { get; set; }

        [Display(Name = "Poliklinik")]
        public Poliklinik Poliklinik { get; set; }



        // Foreign Keys
        public Kullanici User { get; set; }


        // İlişki: Doktor Calışma Saatleri
        public virtual ICollection<CalismaSaati> DoktorCalismaSaatleri { get; set; }

        // İlişki: Doktor Calışma günleri
        public virtual ICollection<CalismaGunu> DoktorCalismaGunleri { get; set; }
    }
}
