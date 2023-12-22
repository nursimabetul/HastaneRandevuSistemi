using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class Randevu
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
} 
