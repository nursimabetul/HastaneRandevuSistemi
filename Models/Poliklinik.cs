using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Models
{
    public class Poliklinik
    {
        [Key]
        public int PoliklinikId { get; set; }
        public string PoliklinikAdi { get; set; }

        [ForeignKey("AnaBilimDali")]
        public int AnaBilimDaliID { get; set; }

        public AnaBilimDali AnaBilimDali { get; set; }

        public string Aciklama { get; set; }
        


    }
}
