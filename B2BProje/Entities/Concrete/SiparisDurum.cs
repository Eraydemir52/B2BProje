using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Siparis_Durumları_Tablosu")]
    public class SiparisDurum : IEntity
    {

        [Key]
        [Column("durumID")]
        public int DurumID { get; set; }

        [Column("baslik")]
        public string Baslik { get; set; }

        [Column("durumkodu")]
        public string Durumkodu { get; set; }

        [Column("durumtarihi")]
        public DateTime Durumtarihi { get; set; }


        [Column("durum")]
        public string Durum { get; set; }

        [Column("siparislerID")]
        public int SiparislerID { get; set; }





    }
}