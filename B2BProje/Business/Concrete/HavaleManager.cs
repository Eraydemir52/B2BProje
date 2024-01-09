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
    public class HavaleManager : IHavaleService
    {
        IHavaleDal _havaleDal;
        public HavaleManager(IHavaleDal havaleDal)
        {
            _havaleDal = havaleDal;
        }

        public List<Havale> GetAll()
        {
            return new List<Havale>(_havaleDal.GetAll());
        }

        public List<HavaleDto> GetwithAll()
        {
            return _havaleDal.GetwithAll();
        }
    }
}
