using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Abstract
{
     public interface IBayiService
    {
        List<Bayi> GetAll();
        List<BayiDetailDto> GetAllWithAdres();
    }
}
