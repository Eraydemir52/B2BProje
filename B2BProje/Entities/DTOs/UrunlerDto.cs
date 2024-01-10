using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.DTOs
{
    using System;

    namespace B2BProje.Entities.DTOs
    {
        public class UrunDto
        {
            public int UrunID { get; set; }
            public int KategoriID { get; set; }
            public string Baslik { get; set; }
            public string Ozellik { get; set; }
            public string Icerik { get; set; }
            public string Kapakresim { get; set; }
            public string Bannerresim { get; set; }
            public Double Fiyat { get; set; }
            public string Urunkodu { get; set; }
            public int Urunstok { get; set; }
            //public string Adminkoyw { get; set; }
            //public string Adminkeydesc { get; set; }
            public DateTime Uruntarihi { get; set; }
            public string Urunekleyen { get; set; }
            public string Urundurum { get; set; }
            public int UreticiID { get; set; }
            public int ResimID { get; set; }

            // UreticiDto alanları
            public string UreticiAdi { get; set; }
            //public string UreticiKategoriAdi { get; set; }
            //public string UreticiKatSeviye { get; set; }
            //public string UreticiKatKeyw { get; set; }
            //public string UreticiKatDesc { get; set; }
            //public string UreticiKatDurum { get; set; }

            // KategoriDto alanları
            public string KategoriBaslik { get; set; }
            //public string KategoriSef { get; set; }
            //public string KategoriKeyw { get; set; }
            //public string KategoriDesc { get; set; }
            //public string KategoriDurum { get; set; }

            // ResimDto alanları
            public string ResimUrun { get; set; }
            public string ResimDosyasi { get; set; }
            //public DateTime ResimTarihi { get; set; }
            //public string ResimDurum { get; set; }
        }

    }

}
