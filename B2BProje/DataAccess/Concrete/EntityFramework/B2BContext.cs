using B2BProje.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.DataAccess.Concrete.EntityFramework
{
    using Microsoft.EntityFrameworkCore;

    namespace B2BProje.DataAccess.Concrete.EntityFramework
    {
        public class B2BContext : DbContext
        {
            // Parametresiz kurucu metod ekleyin
            public B2BContext()
            {
            }

            public B2BContext(DbContextOptions<B2BContext> options) : base(options)
            {
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder
                
                    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=B2B;Trusted_Connection=true");
                 
                // Tembel yükleme özelliğini etkinleştir

                base.OnConfiguring(optionsBuilder);
            }


            // DbSet'ler burada tanımlanır
            public DbSet<Banka> Banka_Tablosu { get; set; }
            public DbSet<Mesaj> Mesaj_Tablosu { get; set; }
            public DbSet<Bayi> Bayiler_Tablosu { get; set; }
            public DbSet<Adres> Adresler_Tablosu { get; set; }
            public DbSet<Ayar> X_Ayarlar_Tablosu { get; set; }

            // Model oluşturulurken özel konfigürasyonları yapmak için kullanılır
            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    modelBuilder.Entity<Bayi>()
            //        .HasOne(b => b.Adres)  // "Bayi" sınıfının "Adres" özelliğine referans
            //        .WithMany(a => a.Bayiler)  // "Adres" sınıfının "Bayiler" özelliğine referans
            //        .HasForeignKey(b => b.AdresID);

            //    // Diğer konfigürasyonlar...

            //    base.OnModelCreating(modelBuilder);
            //}





            // Veritabanı bağlantı dizesini belirlemek için kullanılır

        }
    }

    }
