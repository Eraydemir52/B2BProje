using B2BProje.Core.DataAccess.Entityframework;
using B2BProje.DataAccess.Abstract;
using B2BProje.DataAccess.Concrete.EntityFramework.B2BProje.DataAccess.Concrete.EntityFramework;
using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.DataAccess.Concrete.EntityFramework
{
    public class EfHavaleDal : EfEntityRepositoryBase<Havale, B2BContext>, IHavaleDal
    {
        public EfHavaleDal(B2BContext context) : base(context)
        {
            // ...
        }

        public List<HavaleDto> GetwithAll()
        {
            var result = _context.Havale_Bildirim_Tablosu
          .Join(
           _context.Bayiler_Tablosu,
          havale => havale.BayiID,
           bayi => bayi.BayiID,
         (havale, bayi) => new
         {
             Havale = havale,
             Bayi = bayi
         }
     )
     .Join(
         _context.Banka_Tablosu,
         result => result.Havale.BankaID,
         banka => banka.BankaID,
         (result, banka) => new HavaleDto
         {
             HavaleID = result.Havale.HavaleID,
             BayiID = result.Bayi.BayiID,
             HavaleTarihi = result.Havale.HavaleTarihi,
             HavaleTutar = result.Havale.HavaleTutar,
             HavaleAciklama = result.Havale.HavaleAciklama,
             BankaID = result.Havale.BankaID, // BankaID değeri Havale_Bildirim_Tablosu tablosundan gelir
             BankaAd = banka.BankaAd,
             // Diğer banka özelliklerini ekleyin
         }
     )
     .ToList();

            return result;






        }
    }
}
