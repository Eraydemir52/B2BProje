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
    public class SiparisVerilenUrunController : ControllerBase
    {
        ISiparisVerilenUrunService _siparisverilenurunService;

        public SiparisVerilenUrunController(ISiparisVerilenUrunService siparisverilenurunService)
        {
            _siparisverilenurunService = siparisverilenurunService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var siparisverilenurun = _siparisverilenurunService.GetAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(siparisverilenurun);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
