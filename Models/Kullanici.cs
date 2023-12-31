﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class Kullanici: IdentityUser
    {
        [Key]
        public int KullaniciId { get; set; }
        public string Adi { get; set; }
        public string Soyadi{ get; set; }
        public string Email { get; set; }
        public string GSM { get; set; }
        public string Adres { get; set; }

        // İlişki: Kullanıcının randevuları
        public List<Randevu>? Randevular { get; set; }
    }

}
