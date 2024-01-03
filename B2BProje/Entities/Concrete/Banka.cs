using B2BProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Entities.Concrete
{
    [Table("Banka_Tablosu")] // Veritabanındaki tablo adını belirleme
    public class Banka : IEntity
    {
        [Key]
        [Column("bankaID")] // Veritabanındaki sütun adını belirleme
        public int BankaID { get; set; }

        [Column("banka_ad")]
        public string BankaAd { get; set; }

        [Column("banka_hesap")]
        public string BankaHesap { get; set; }

        [Column("banka_sube")]
        public string BankaSube { get; set; }

        [Column("banka_iban")]
        public string BankaIBAN { get; set; }

        [Column("banka_durum")]
        public string BankaDurum { get; set; }
    }

}
