using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class Hasta
    {

        [Key]
        public int HastaId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
