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
            

            public B2BContext(DbContextOptions<B2BContext> options) : base(options)
            {
                // ...
            }
            public B2BContext()
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // Veritabanı bağlantı dizesini konfigüre et
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=B2B;Trusted_Connection=true");
            }

            public DbSet<Banka> Banka_Tablosu { get; set; }
            public DbSet<Mesaj> Mesaj_Tablosu { get; set; }
        }
    }

}
