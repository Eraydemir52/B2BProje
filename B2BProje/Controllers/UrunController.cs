using B2BProje.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        IUrunService _urunService;

        public UrunController(IUrunService urunService)
        {
            _urunService = urunService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var urun = _urunService.GetAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(urun);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("witurun")]
        public IActionResult GetwiturunAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var urunler = _urunService.GetUrunWithDetails();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(urunler);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
