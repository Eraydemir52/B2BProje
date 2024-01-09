using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Urunler_Tablosu")]
    public class Urun : IEntity
    {
        [Key]
        [Column("urunID")]
        public int UrunID { get; set; }

        [Column("kategoriID")]
        public int KategoriID { get; set; }

        [Column("baslik")]
        public string Baslik { get; set; }

        [Column("ozellik")]
        public string Ozellik { get; set; }

        [Column("icerik")]
        public string Icerik { get; set; }

        [Column("kapakresim")]
        public string KapakResim { get; set; }

        [Column("bannerresim")]
        public string BannerResim { get; set; }

        [Column("fiyat")]
        public Double Fiyat { get; set; }

        [Column("urunkodu")]
        public string UrunKodu { get; set; }

        [Column("urunstok")]
        public int UrunStok { get; set; }

        [Column("adminkoyw")]
        public string AdminKoyw { get; set; }

        [Column("adminkeydesc")]
        public string AdminKeyDesc { get; set; }

        [Column("uruntarihi")]
        public DateTime UrunTarihi { get; set; }

        [Column("urunekleyen")]
        public string UrunEkleyen { get; set; }

        [Column("urundurum")]
        public string UrunDurum { get; set; }

        [Column("ureticiID")]
        public int UreticiID { get; set; }

        [Column("resimID")]
        public int ResimID { get; set; }
    }

}
