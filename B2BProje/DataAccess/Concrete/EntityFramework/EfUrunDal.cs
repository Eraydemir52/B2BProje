using B2BProje.Core.DataAccess.Entityframework;
using B2BProje.DataAccess.Abstract;
using B2BProje.DataAccess.Concrete.EntityFramework.B2BProje.DataAccess.Concrete.EntityFramework;
using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs.B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.DataAccess.Concrete.EntityFramework
{
    public class EfUrunDal : EfEntityRepositoryBase<Urun, B2BContext>, IUrunDal
    {
        public EfUrunDal(B2BContext context) : base(context)
        {
            // Burada _context zaten EfEntityRepositoryBase sınıfı tarafından ayarlanmış olacaktır.
        }

        public List<UrunDto> GetUrunWithDetails()
        { 
            var result = _context.Urun_Tablosu
                .Join(
                    _context.Ureticiler_Tablosu,
                    urun => urun.UreticiID,
                    uretici => uretici.UreticiID,
                    (urun, uretici) => new
                    {
                        Urun = urun,
                        Uretici = uretici
                    }
                )
                .Join(
                    _context.Kategoriler_Tablosu,
                    result => result.Uretici.KategoriID,
                    kategori => kategori.kategoriID,
                    (result, kategori) => new
                    {
                        result.Urun,
                        result.Uretici,
                        Kategori = kategori
                    }
                )
                .Join(
                    _context.Resimler_Tablosu,
                    result => result.Urun.ResimID,
                    resim => resim.resimID,
                    (result, resim) => new UrunDto
                    {
                        UrunID = result.Urun.UrunID,
                        KategoriID = result.Urun.KategoriID,
                        Baslik = result.Urun.Baslik,
                        Ozellik = result.Urun.Ozellik,
                        Icerik = result.Urun.Icerik,
                        Kapakresim = result.Urun.KapakResim,
                        Bannerresim = result.Urun.BannerResim,
                        Fiyat = result.Urun.Fiyat,
                        Urunkodu = result.Urun.UrunKodu,
                        Urunstok = result.Urun.UrunStok,

                        Uruntarihi = result.Urun.UrunTarihi,
                        Urunekleyen = result.Urun.UrunEkleyen,
                        Urundurum = result.Urun.UrunDurum,
                        UreticiID = result.Urun.UreticiID,
                        ResimID = result.Urun.ResimID,
                        // UreticiDto alanları
                        UreticiAdi = result.Uretici.Ureticiadi,

                        // KategoriDto alanları
                        KategoriBaslik = result.Kategori.kategoribaslik,
                        ResimUrun = resim.resimurun,
                        ResimDosyasi = resim.resimdosyasi

                    }
                )
        
                .ToList();

            return result;
        }

    }
}
