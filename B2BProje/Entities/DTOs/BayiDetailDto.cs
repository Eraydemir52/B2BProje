using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.DTOs
{
    public class BayiDetailDto
    {
        public int BayiID { get; set; }
        public string BayiKodu { get; set; }
        // ... Diğer bayi özellikleri
        public int AdresID { get; set; }
        public string BayiAdres { get; set; }
        // ... Diğer adres özellikleri
    }

}
