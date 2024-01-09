using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Kategoriler_Tablosu")]
    public class Kategori : IEntity
    {

        [Key]
        [Column("kategoriID")]
        public int kategoriID { get; set; }


        [Column("kategoribaslik")]
        public string kategoribaslik { get; set; }

        [Column("katsef")]
        public string katsef { get; set; }

        [Column("katkeyw")]
        public string katkeyw { get; set; }

        [Column("katdesc")]
        public string katdesc { get; set; }

        [Column("katdurum")]
        public string katdurum { get; set; }
    }
}