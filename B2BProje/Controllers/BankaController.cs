using B2BProje.Business.Abstract;
using B2BProje.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BProje
{
    // BankaController.cs
    [Route("api/[controller]")]
    [ApiController]
    public class BankaController : ControllerBase
    {
        private readonly IBankaService _bankaService;

        public BankaController(IBankaService bankaService)
        {
            _bankaService = bankaService;
        }

       
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var bankalar = _bankaService.GetAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(bankalar);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpPost("AddBanka")]
        public IActionResult AddBanka([FromBody] Banka banka)
        {
            try
            {
                // BankaService'teki ekleme metodunu çağır
                _bankaService.Add(banka);

                // Başarılı durumda HTTP 201 Created durumunu döndür
                return StatusCode(201, "Banka başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

    }

}
