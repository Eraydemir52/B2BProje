using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Adresler_Tablosu")]
    public class Adres : IEntity
    {

        [Key]
        [Column("adresID")]
        public int AdresID { get; set; }


        [Column("bayi_adres")]
        public string BayiAdres { get; set; }

        [Column("adres_baslik")]
        public string AdresBaslik { get; set; }

        [Column("adres_tarif")]
        public string AdresTarif { get; set; }

        [Column("adres_durum")]
        public string AdresDurum { get; set; }

        [Column("adres_tarih")]
        public DateTime AdresTarih { get; set; }

       // public List<Bayi> Bayiler { get; set; }


    }
}
