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
    public class SiparisManager : ISiparisService
    {
        ISiparisDal _siparisDal;

        public SiparisManager(ISiparisDal siparisDal)
        {
            _siparisDal = siparisDal;
        }

        public List<Siparis> GetAll()
        {
            return new List<Siparis>(_siparisDal.GetAll());
        }

        public List<SiparisDto> GetwithAll()
        {
              return _siparisDal.GetwithAll();
        }
    }
}
