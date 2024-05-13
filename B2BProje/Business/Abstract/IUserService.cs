using B2BProje.Entities.Concrete;
using B2BProje.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Business.Abstract
{
    public interface IUserService
    {
        void RegisterUser(User user);
        User Login(string username, string password);
        // Diğer metotlar buraya eklenir.
        List<User> GetAllUsers();
        void Add(User user);
        void Update(User user);
        User Get(string username);
        List<UserDto> GetUserDtos();



    }
}
