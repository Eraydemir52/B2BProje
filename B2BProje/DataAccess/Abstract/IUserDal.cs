﻿using B2BProje.Core.DataAccess.Entityframework;
using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserDto> GetUserDtos();
    }
}
