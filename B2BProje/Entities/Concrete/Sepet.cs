using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Sepet_Tablosu")]
    public class Sepet : IEntity
    {

        [Key]
        [Column("sepetID")]
        public int SepetID { get; set; }

        [Column("sepetbayi")]
        public string SepetBayi { get; set; }

        [Column("sepeturunkodu")]
        public string SepetUrunKodu { get; set; }

        [Column("sepetadet")]
        public int SepetAdet { get; set; }

        [Column("sepettarih")]
        public DateTime SepetTarih { get; set; }

        [Column("urunID")]
        public int UrunID { get; set; }

        // public List<Bayi> Bayiler { get; set; }


    }
}
