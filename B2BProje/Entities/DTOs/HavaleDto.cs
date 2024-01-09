using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.DTOs
{
    public class HavaleDto
    {
        public int HavaleID { get; set; }
        public int BayiID { get; set; }
        public string BankaAd { get; set; }
        public DateTime HavaleTarihi { get; set; }
        public Double HavaleTutar { get; set; }
        public string HavaleAciklama { get; set; }
        public int BankaID { get; set; }

    }
}
