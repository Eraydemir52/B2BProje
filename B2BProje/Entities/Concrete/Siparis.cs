using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Siparisler_Tablosu")]
    public class Siparis : IEntity
    {
        [Key]
        [Column("siparislerID")] // Veritabanındaki sütun adını belirleme
        public int SiparisID { get; set; }

        [Column("siparisbayi")]
        public string SiparisBayi { get; set; }

        [Column("siparistarih")]
        public DateTime SiparisTarih { get; set; }

        [Column("siparisdurum")]
        public string SiparisDurum { get; set; }

        [Column("siparisnot")]
        public string SiparisNot { get; set; }

        [Column("siparistutar")]
        public Double SiparisTutar { get; set; }

        [Column("sipariskodu")]
        public string SiparisKodu { get; set; }
       
        [Column("siparisverilenurunlerID")]
        public int SiparisVerilenUrunlerID { get; set; }
        //public SiparisUrun SiparisUrun { get; set; }


    }
}
