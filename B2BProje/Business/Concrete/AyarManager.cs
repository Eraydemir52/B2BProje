using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class AyarManager : IAyarService
    {
        IAyarDal _ayarDal;

        public AyarManager(IAyarDal ayarDal)
        {
            _ayarDal = ayarDal;
        }

        public List<Ayar> GetAll()
        {
            return new List<Ayar>(_ayarDal.GetAll());
        }
    }
}
