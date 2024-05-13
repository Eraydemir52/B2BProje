using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> GetAll();
        void Add(Kategori kategori);
        void Update(Kategori kategori);
        void DeleteID(int kategoriID);
        
    }
}
