using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class BankaManager : IBankaService

    {
        IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }

        public void Add(Banka banka)
        {
            _bankaDal.Add(banka);
        }

        public List<Banka> GetAll()
        {
            return new List<Banka>(_bankaDal.GetAll());
        }
    }
}
