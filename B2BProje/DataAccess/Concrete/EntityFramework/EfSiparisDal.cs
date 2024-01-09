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
    public class EfSiparisDal : EfEntityRepositoryBase<Siparis, B2BContext>, ISiparisDal
    {
        public EfSiparisDal(B2BContext context) : base(context)
        {
            // Burada _context zaten EfEntityRepositoryBase sınıfı tarafından ayarlanmış olacaktır.
        }
        public List<SiparisDto> GetwithAll()
        {
            var result = _context.Siparisler_Tablosu
                .Join(
                    _context.Siparis_Verilen_Urunler_Tablosu,
                    siparis => siparis.SiparisVerilenuUrunlerID,
                    sipasurun => sipasurun.SiparisVerilenUrunlerID,
                    (siparis, sipasurun) => new SiparisDto
                    {
                        SiparisID = siparis.SiparisID,
                        SiparisBayi = siparis.SiparisBayi,
                        SiparisTarih = siparis.SiparisTarih,
                        //... (Diğer bayi özelliklerini ekleyin)
                        SiparisVerilenUrunlerID = sipasurun.SiparisVerilenUrunlerID,
                        SiparisVerilenKodu = sipasurun.SiparisVerilenKodu,
                        SiparisVerilenUrun = sipasurun.SiparisVerilenUrun
                        //... (Diğer adres özelliklerini ekleyin)
                    })
                .ToList();

            return result;
        }
    }
}
