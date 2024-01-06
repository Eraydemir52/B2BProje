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
    [Table("Bayiler_Tablosu")]
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
        public int BayiIskonto { get; set; }

        [Column("bayitelefon")]
        public string BayiTelefon { get; set; }

        [Column("bayivergino")]
        public string BayiVergiNo { get; set; }

        [Column("bayivergidaire")]
        public string BayiVergiDaire { get; set; }

        [Column("bayilogo")]
        public string Bayilogo { get; set; }

        // Bayi ile Adres arasındaki ilişkiyi ifade eden özellik
        [ForeignKey("Adres")]
        public int AdresID { get; set; }
       
        public Adres BayiAdres { get; set; }



        // Diğer özellikler...
    }
}
