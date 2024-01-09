using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace B2BProje.Business.Concrete
{
    public class SiparisVerilenUrunManager : ISiparisVerilenUrunService
    {
        ISiparisVerilenDal _siparVerilenDal;

        public SiparisVerilenUrunManager(ISiparisVerilenDal siparVerilenDal)
        {
            _siparVerilenDal = siparVerilenDal;
        }

        public List<SiparisUrun> GetAll()
        {
            return new List<SiparisUrun>(_siparVerilenDal.GetAll());
        }
    }
}
