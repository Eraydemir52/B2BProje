﻿using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Abstract
{
    public interface IBankaService
    {
        List<Banka> GetAll();
        void Add(Banka banka);
    }
}
