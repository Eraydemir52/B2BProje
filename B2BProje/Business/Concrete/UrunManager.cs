using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs.B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }


        public List<Urun> GetAll()
        {
            return new List<Urun>(_urunDal.GetAll());
        }

        public List<UrunDto> GetUrunWithDetails()
        {
            return _urunDal.GetUrunWithDetails();
        }
        public void Add(Urun urun)
        {
            // Gerekli iş mantığını burada uygula
            _urunDal.Add(urun);
        }

        public void DeleteID(int urunID)
        {
            _urunDal.DeleteID(urunID);
        }

        public void Update(Urun urun)
        {
            _urunDal.Update(urun);
        }

    }
}
