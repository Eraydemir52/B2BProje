using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;


namespace B2BProje.Entities.Concrete
{
   

        [Table("Siparis_Verilen_Urunler_Tablosu")]
        public class SiparisUrun : IEntity
        {
            [Key]
            [Column("siparisverilenurunlerID")] // Veritabanındaki sütun adını belirleme
            public int SiparisVerilenUrunlerID { get; set; }

            [Column("siparisverilenkodu")]
            public string SiparisVerilenKodu { get; set; }

            [Column("siparisverilenurun")]
            public string SiparisVerilenUrun { get; set; }

            [Column("siparisverilenadet")]
            public int SiparisVerilenAdet { get; set; }

            [Column("siparisverilentutar")]
            public Double SiparisVerilenTutar { get; set; }

            [Column("urunadi")]
            public string UrunAdi { get; set; }



    }
    
}
