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
    public class EfBayiDal : EfEntityRepositoryBase<Bayi, B2BContext>, IBayiDal
    {
        public EfBayiDal(B2BContext context) : base(context)
        {
            // Burada _context zaten EfEntityRepositoryBase sınıfı tarafından ayarlanmış olacaktır.
        }

        public List<BayiDetailDto> GetBayilerWithAdres()
        {
            var result = _context.Bayiler_Tablosu
                .Join(
                    _context.Adresler_Tablosu,
                    bayi => bayi.AdresID,
                    adres => adres.AdresID,
                    (bayi, adres) => new BayiDetailDto
                    {
                        BayiID = bayi.BayiID,
                        BayiKodu = bayi.BayiKodu,
                        BayiAdi =bayi.BayiAdi,
                        //... (Diğer bayi özelliklerini ekleyin)
                        AdresID = adres.AdresID,
                        BayiAdres = adres.BayiAdres,
                        //... (Diğer adres özelliklerini ekleyin)
                    })
                .ToList();

            return result;
        }
    }


}