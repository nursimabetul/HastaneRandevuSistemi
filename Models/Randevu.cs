using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class Randevu
    {
        [Key]
        public int Id { get; set; }
        public int DoktorID { get; set; }
        public Doktor Doktor { get; set; } 
        
        public DateTime Date { get; set; }



    }
} 
