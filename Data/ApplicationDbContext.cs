﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HastaneRandevuSistemi.Models;

namespace HastaneRandevuSistemi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AnaBilimDali> AnaBilimDallari { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Poliklinik> Poliklinikler { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        public DbSet<Hasta> Hasta { get; set; }



    }
}