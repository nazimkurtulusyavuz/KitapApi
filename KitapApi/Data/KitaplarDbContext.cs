using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapApi.Data
{
    public class KitaplarDbContext : DbContext
    {
        public KitaplarDbContext(DbContextOptions<KitaplarDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kitap>().HasData(
             new Kitap() { Id = 1, Ad = "Çalıkuşu", Yazar = "Reşat Nuri Güntekin", Yil = 1922 },
             new Kitap() { Id = 2, Ad = "Çulsuzlar", Yazar = "Dan Kavanagh", Yil = 2002 },
             new Kitap() { Id = 3, Ad = "Kendi Everest'inize Tırmanın", Yazar = "Nasuh Mahruki", Yil = 2019 },
             new Kitap() { Id = 4, Ad = "Körlük", Yazar = "Jose Saramago", Yil = 1995 },
             new Kitap() { Id = 5, Ad = "Aptallığın övgüsü", Yazar = "Erasmus", Yil = 1511 }
            );
    }
        public DbSet<Kitap> Kitaplar { get; set; }
    }
}
