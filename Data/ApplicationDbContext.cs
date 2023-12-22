using HastaneRandevuSistemi.Models;
using Microsoft.EntityFrameworkCore;

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

    }


}
