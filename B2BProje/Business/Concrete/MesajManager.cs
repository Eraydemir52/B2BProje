using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Abstract;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Concrete
{
    public class MesajManager :IMesajService
    {
        IMesajDal _mesajdal;

        public MesajManager(IMesajDal mesajdal)
        {
            _mesajdal = mesajdal;
        }

        public List<Mesaj> GetAll()
        {
            try
            {
                return new List<Mesaj>(_mesajdal.GetAll());
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama veya gerekli diğer işlemleri yapabilirsiniz.
                throw new Exception("Hata burda "+ex); // veya başka bir şekilde ele alın
            }
        }
    }
}
