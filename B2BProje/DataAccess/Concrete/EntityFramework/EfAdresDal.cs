using B2BProje.Core.DataAccess.Entityframework;
using B2BProje.DataAccess.Abstract;
using B2BProje.DataAccess.Concrete.EntityFramework.B2BProje.DataAccess.Concrete.EntityFramework;
using B2BProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.DataAccess.Concrete.EntityFramework
{
    public class EfAdresDal : EfEntityRepositoryBase<Adres, B2BContext>, IAdresDal
    {
        public EfAdresDal(B2BContext context) : base(context)
        {
            // ...
        }
    }
}
