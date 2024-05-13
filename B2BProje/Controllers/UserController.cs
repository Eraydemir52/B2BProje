using B2BProje.Business.Abstract;
using B2BProje.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using B2BProje.Core.JwtService;
using Microsoft.IdentityModel.Tokens;
using B2BProje.Core.TokenService;


namespace B2BProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IJwtSettingsService _jwtSettingsService;

        public UserController(IUserService userService, IConfiguration configuration, IJwtSettingsService jwtSettingsService)
        {
            _userService = userService;
            _configuration = configuration;
            _jwtSettingsService = jwtSettingsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var ayar = _userService.GetAllUsers();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(ayar);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            try
            {
                _userService.RegisterUser(user);
                return Ok(new { Message = "Registration successful" });
            }
            catch (Exception ex)
            {
                // Hata durumunu loglama veya uygun bir şekilde işleme ekleme
                return BadRequest(new { Message = "Registration failed", Error = ex.Message });
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            try
            {
                // Burada _userService.Login(user.Username, user.Password) metodunu kullanmalısınız
                var authenticatedUser = _userService.Login(user.Username, user.Password);
               


                if (authenticatedUser == null )
                {
                    return Unauthorized(new { Message = "Invalid username or password" });
                }

                // Kullanıcı doğrulandıysa JWT token oluşturun
                var jwtSettings = _jwtSettingsService.GetJwtSettings();
                var tokenService = new TokenService(jwtSettings);

                // Token oluştur
                var token = tokenService.GenerateJwtToken(authenticatedUser.Id.ToString(), authenticatedUser.Username);

                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                // Hata durumunu loglama veya uygun bir şekilde işleme ekleme
                return BadRequest(new { Message = "Login failed", Error = ex.Message });
            }
        }
        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            try
            {
                // Gerekirse iş mantığı ekleyebilirsiniz
                _userService.Add(user);

                // Başarılı durumda HTTP 201 Created durumunu döndür
                return StatusCode(201, "Ürün başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost("update")]
        public IActionResult UpdateUser(User user)
        {
            try
            {
                _userService.Update(user);
                return Ok("Kullanıcı başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Güncelleme işlemi sırasında bir hata oluştu: {ex.Message}");
            }
        }
        [HttpGet("{username}")]
        public IActionResult GetUser(string username)
        {
            try
            {
                var user = _userService.Get(username);

                if (user == null)
                {
                    return NotFound(new { Message = "User not found" });
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("userDto")]
        public IActionResult GetwiturunAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var userRoles = _userService.GetUserDtos();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(userRoles);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }




    }
}
