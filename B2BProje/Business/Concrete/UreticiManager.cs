using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class UreticiManager : IUreticiService
    {
        IUreticiDal _ureticiDal;
        public UreticiManager(IUreticiDal ureticiDal)
        {
            _ureticiDal = ureticiDal;
        }

        public List<Uretici> GetAll()
        {
            return new List<Uretici>(_ureticiDal.GetAll());
        }
    }
}
