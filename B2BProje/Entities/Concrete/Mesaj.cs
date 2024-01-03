using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Mesajlar_Tablosu")] // Veritabanındaki tablo adını belirleme
    public class Mesaj : IEntity
    {
        [Key]
        [Column("mesajid")] // Veritabanındaki sütun adını belirleme
        public int MesajID{ get; set; }

        [Column("adsoyad")]
        public string Adsoyad { get; set; }

        [Column("mesajmail")]
        public string Mesajmail { get; set; }

        [Column("mesajkonu")]
        public string Mesajkonu { get; set; }

        [Column("mesajicerik")]
        public string Mesajicerik { get; set; }

        [Column("mesajdurum")]
        public string Mesajdurum { get; set; }

        [Column("mesajtarihi")]
        public DateTime Mesajtarih { get; set; }

    }
}
