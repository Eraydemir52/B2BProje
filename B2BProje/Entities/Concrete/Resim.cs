using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Resimler_Tablosu")]
    public class Resim : IEntity
    {

        [Key]
        [Column("resimID")]
        public int resimID { get; set; }


        [Column("resimurun")]
        public string resimurun { get; set; }

        [Column("resimdosyasi")]
        public string resimdosyasi { get; set; }
       
        [Column("resimtarihi")]
        public DateTime resimtarihi { get; set; }

        [Column("resimdurum")]
        public string resimdurum { get; set; }
    }
}