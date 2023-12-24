﻿using HastaneRandevuSistemi.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HastaneRandevuSistemi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<AnaBilimDali> AnaBilimDallari { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Poliklinik> Poliklinikler { get; set; }

    }


}