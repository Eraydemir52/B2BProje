using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.DTOs
{
    public class SiparisDrumDto
    {
        public int DurumID { get; set; }
        public string Baslik { get; set; }
        public DateTime Durumtarihi { get; set; }
    }
}
