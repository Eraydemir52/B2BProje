using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.DTOs
{
    public class SepetDto
    {
        public int SepetID { get; set; }
        public int SepetAdet { get; set; }
        public DateTime SepetTarih { get; set; }
        public int UrunID { get; set; }

        //***Urunden
        public string Baslik { get; set; }
        public string Ozellik { get; set; }
        public Double Fiyat { get; set; }
        public string UrunKodu { get; set; }
        public string Icerik { get; set; }
    }
}
