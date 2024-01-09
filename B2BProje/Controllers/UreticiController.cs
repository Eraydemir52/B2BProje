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
    public class UreticiController : ControllerBase
    {
        IUreticiService _ureticiService;

        public UreticiController(IUreticiService ureticiService)
        {
            _ureticiService = ureticiService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var uretici = _ureticiService.GetAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(uretici);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
