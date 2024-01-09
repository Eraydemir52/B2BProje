using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Havale_Bildirim_Tablosu")]
    public class Havale : IEntity
    {

        [Key]
        [Column("havaleID")]
        public int HavaleID { get; set; }

        [Column("bayiID")]
        public int BayiID { get; set; }

        [Column("havaletarihi")]
        public DateTime HavaleTarihi { get; set; }

        [Column("havaletutar")]
        public Double HavaleTutar { get; set; }

        [Column("havaleaciklama")]
        public string HavaleAciklama { get; set; }

        [Column("bankaID")]
        public int BankaID { get; set; }

        // public List<Bayi> Bayiler { get; set; }


    }
}
