using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class SiparisDurumManager : ISiparisDurumService
    {
        ISiparisDurumDal _siparisdurumDal;
        public SiparisDurumManager(ISiparisDurumDal siparisDurumDal)
        {
            _siparisdurumDal = siparisDurumDal;
        }

        public List<SiparisDurum> GetAll()
        {
            return new List<SiparisDurum>(_siparisdurumDal.GetAll());
        }
    }
}
