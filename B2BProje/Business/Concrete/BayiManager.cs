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
    public class BayiManager : IBayiService
    {
        IBayiDal _bayidal;

        public BayiManager(IBayiDal bayiDal)
        {
            _bayidal = bayiDal;
        }
        public List<Bayi> GetAll()
        {
            try
            {
                return new List<Bayi>(_bayidal.GetAll());
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama veya gerekli diğer işlemleri yapabilirsiniz.
                throw new Exception("Bayi verilerini alma sırasında hata oluştu: " + ex.Message);

            }
        }

        public List<BayiDetailDto> GetAllWithAdres()
        {
            try
            {
                return _bayidal.GetBayilerWithAdres();
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama veya gerekli diğer işlemleri yapabilirsiniz.
                throw new Exception("Bayi verilerini alma sırasında hata oluştu: " + ex.Message);
            }
        }
    }
}
