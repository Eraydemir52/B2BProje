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
    public class EfSepetDal : EfEntityRepositoryBase<Sepet, B2BContext>, ISepetDal
    {
        public EfSepetDal(B2BContext context) : base(context)
        {
            // ...
        }
        public List<SepetDto> GetSepetDetails()
        {
            var result = _context.Sepet_Tablosu
                .Join(
                    _context.Urun_Tablosu,
                    sepet => sepet.UrunID,
                    urun => urun.UrunID,
                    (sepet, urun) => new SepetDto
                    {
                        SepetID = sepet.SepetID,
                        SepetAdet = sepet.SepetAdet,
                        SepetTarih = sepet.SepetTarih,
                        UrunID = urun.UrunID,
                        Baslik = urun.Baslik,
                        Ozellik = urun.Ozellik,
                        Fiyat = urun.Fiyat,
                        UrunKodu = urun.UrunKodu,
                        Icerik = urun.Icerik
                    }
                )
                .ToList();

            return result;
        }
    }
}
