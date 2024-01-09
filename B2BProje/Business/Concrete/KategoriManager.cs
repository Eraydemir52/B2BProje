using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoridal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoridal = kategoriDal;
        }

        public List<Kategori> GetAll()
        {
            return new List<Kategori>(_kategoridal.GetAll());
        }
    }
}
