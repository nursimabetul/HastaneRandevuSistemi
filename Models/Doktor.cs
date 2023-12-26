using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class Doktor
    {
        [Key]
        public int DoktorId { get; set; }
        public string Adi { get; set; }
        public string Sifre { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }

        public int PoliklinikID { get; set; }
        public Poliklinik Poliklinik { get; set; }
    }
}
