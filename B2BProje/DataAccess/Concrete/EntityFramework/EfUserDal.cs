using B2BProje.Core.DataAccess.Entityframework;
using B2BProje.DataAccess.Abstract;
using B2BProje.DataAccess.Concrete.EntityFramework.B2BProje.DataAccess.Concrete.EntityFramework;
using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, B2BContext>, IUserDal
    {
        public EfUserDal(B2BContext context) : base(context)
        {
        }

        public List<UserDto> GetUserDtos()
        {
            var result = _context.Users.Join(
                _context.Role,
                user => user.roleID,
                role => role.roleID,

               

                 (user, role) => new UserDto
                 {
                     Id = user.Id,
                     Username=user.Username,
                     Password =user.Password,
                     phonenumber =user.phonenumber,
                     address =user.address,
                     roleID =role.roleID,
                     name=role.name
                 }



                ).ToList();
            return result;
        }

       
    }
}
