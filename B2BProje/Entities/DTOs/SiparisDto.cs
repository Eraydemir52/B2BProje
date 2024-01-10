using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.DTOs
{
    public class SiparisDto
    {
        public int SiparisID { get; set; }
        public string SiparisBayi { get; set; }
        public DateTime SiparisTarih { get; set; }
        public string SiparisDurum { get; set; }
        public string SiparisNot { get; set; }


        // ***************/

        public int SiparisVerilenUrunlerID { get; set; }
        public string SiparisVerilenKodu { get; set; }
        public string SiparisVerilenUrun { get; set; }
    }
}
