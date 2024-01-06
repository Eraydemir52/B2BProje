using B2BProje.Business.Abstract;
using B2BProje.DataAccess.Concrete.EntityFramework.B2BProje.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BayiController : ControllerBase
    {
        private readonly IBayiService _bayiService;

        public BayiController(IBayiService bayiService)
        {
            _bayiService = bayiService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var bankalar = _bayiService.GetAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(bankalar);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpGet("withAdres")]
        public IActionResult GetAllWithAdres()
        {
            try
            {
                // Bayi listesini Business katmanından al, bu sefer GetAllWithAdres metodunu kullan
                var bayilerWithAdres = _bayiService.GetAllWithAdres();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(bayilerWithAdres);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

    }
}
