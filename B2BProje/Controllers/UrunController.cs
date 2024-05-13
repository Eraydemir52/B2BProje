using B2BProje.Business.Abstract;
using B2BProje.Entities.Concrete;
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
                // Banka listesini Business katmanından burda alır
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

        [HttpPost("AddUrun")]
        public IActionResult AddUrun([FromBody] Urun urun)
        {
            try
            {
                // Gerekirse iş mantığı ekleyebilirsiniz
                _urunService.Add(urun);

                // Başarılı durumda HTTP 201 Created durumunu döndür
                return StatusCode(201, "Ürün başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpDelete("DeleteUrun/{urunID}")]
        public IActionResult Delete(int urunID)
        {
            try
            {
                _urunService.DeleteID(urunID);
                return Ok("Urun başarıyla silindi.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"İç Sunucu Hatası: {ex.Message}");
            }
        }

        [HttpPost("UpdateUrun")]
        public IActionResult Update([FromBody] Urun urun)
        {
            try
            {
                // Gerekirse iş mantığı ekleyebilirsiniz**Eray
                _urunService.Update(urun);

                // Başarılı durumda HTTP 200 OK durumunu döndür
                return Ok("Urun başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


    }
}
