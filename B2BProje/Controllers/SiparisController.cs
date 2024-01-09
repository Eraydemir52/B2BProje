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
    public class SiparisController : ControllerBase
    {
        ISiparisService _siparisService;

        public SiparisController(ISiparisService siparisService)
        {
            _siparisService = siparisService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var siparis = _siparisService.GetAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(siparis);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpGet("sipariswith")]
        public IActionResult GetwithAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var siparis = _siparisService.GetwithAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(siparis);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
