using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class ResimManager : IResimService
    {
        IResimDal _resimDal;
        public ResimManager(IResimDal resimDal)
        {
            _resimDal = resimDal;
        }

        public List<Resim> GetAll()
        {
            return new List<Resim>(_resimDal.GetAll());
        }
    }
}
