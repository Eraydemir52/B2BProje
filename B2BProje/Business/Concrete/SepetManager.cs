using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class SepetManager : ISepetService
    {
        ISepetDal _sepetDal;
        public SepetManager(ISepetDal sepetDal)
        {
            _sepetDal = sepetDal;
        }

        public List<Sepet> GetAll()
        {
            return new List<Sepet>(_sepetDal.GetAll());
        }

        public List<SepetDto> GetSepetDetails()
        {
            return _sepetDal.GetSepetDetails();
        }
    }
}
