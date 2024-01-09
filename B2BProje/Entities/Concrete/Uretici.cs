using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Ureticiler_Tablosu")]
    public class Uretici : IEntity
    {

        [Key]
        [Column("ureticiID")]
        public int UreticiID { get; set; }


        [Column("uretici_adi")]
        public string Ureticiadi { get; set; }

        [Column("kategoriID")]
        public int KategoriID { get; set; }
    }
}