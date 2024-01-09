using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using B2BProje.Core.Entities;
using Newtonsoft.Json;

namespace B2BProje.Entities.Concrete
{
    [Table("bayiler_tablosu")]
    public class Bayi : IEntity
    {
        [Key]
        [Column("bayiID")]
        public int BayiID { get; set; }

        [Column("bayikodu")]
        public string BayiKodu { get; set; }

        [Column("bayiadi")]
        public string BayiAdi { get; set; }

        [Column("bayimail")]
        public string BayiMail { get; set; }

        [Column("bayisifre")]
        public string BayiSifre { get; set; }

        [Column("bayitarih")]
        public DateTime BayiTarih { get; set; }

        [Column("bayiiskonto")]
        public Double BayiIskonto { get; set; }

        [Column("bayitelefon")]
        public string BayiTelefon { get; set; }

        [Column("bayivergino")]
        public string BayiVergiNo { get; set; }

        [Column("bayivergidaire")]
        public string BayiVergiDaire { get; set; }

        [Column("bayilogo")]
        public string Bayilogo { get; set; }

        [ForeignKey("BayiAdres")]
        public int AdresID { get; set; }

       // public Adres BayiAdres { get; set; }




        // Diğer özellikler...
    }
}
