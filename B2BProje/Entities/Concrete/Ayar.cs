using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("X_Ayarlar_Tablosu")]
    public class Ayar:IEntity
    {
        [Key]
        [Column("ayarlarID")] // Veritabanındaki sütun adını belirleme
        public int AyarlarID { get; set; }

        [Column("site_baslik")]
        public string SiteBaslik { get; set; }

        [Column("site_uyeler")]
        public int SiteUyeler { get; set; }

        [Column("site_logo")]
        public string SiteLogo { get; set; }

        [Column("site_kdv")]
        public int site_kdv { get; set; }

        
    }
}
