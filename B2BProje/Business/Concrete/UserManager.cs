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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void RegisterUser(User user)
        {
            // İş mantığı kodları buraya eklenebilir (örneğin şifre hashleme ve diğer validasyon işlemleri).

            _userDal.Add(user);
        }

        public User Login(string username, string password)
        {
            try
            {
                // İş mantığı kodları buraya eklenebilir (örneğin şifre karşılaştırma ve kullanıcı doğrulama işlemleri).

                return _userDal.Get(u => u.Username == username && u.Password == password);
            }
            catch (Exception ex)
            {
                // Hata durumunu loglama veya uygun bir şekilde işleme ekleme
                Console.WriteLine($"Login method error: {ex.Message}");
                throw; // Hatanın tekrar fırlatılması
            }
        }


        public List<User> GetAllUsers()
        {
            return new List<User>(_userDal.GetAll());
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            try
            {
                var existingUser = _userDal.Get(u => u.Username == user.Username);

                if (existingUser == null)
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                // Güncelleme işlemleri
               
               
                existingUser.Password = user.Password;
               

                _userDal.Update(existingUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Update method error: {ex.Message}");
                throw; // Hatanın tekrar fırlatılması
            }
        }

        public User Get(string username)
        {
            try
            {
                return _userDal.Get(u => u.Username == username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Get method error: {ex.Message}");
                throw; // Hatanın tekrar fırlatılması
            }
        }

        public List<UserDto> GetUserDtos()
        {
            return _userDal.GetUserDtos();
        }
    }
}
