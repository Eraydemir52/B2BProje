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
    public class KategoriController : ControllerBase
    {
        IKategoriService _kategoriService;

        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                // Banka listesini Business katmanından al
                var kategori = _kategoriService.GetAll();

                // Dönen veriyi kullanarak HTTP 200 OK durumunu döndür
                return Ok(kategori);
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        [HttpPost("Addkategori")]
        public IActionResult AddUrun([FromBody] Kategori kategori )
        {
            try
            {
                // Gerekirse iş mantığı ekleyebilirsiniz
                _kategoriService.Add(kategori);

                // Başarılı durumda HTTP 201 Created durumunu döndür
                return StatusCode(201, "Ürün başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpDelete("DeleteKategori/{categoryId}")]
        public IActionResult Delete(int categoryId)
        {
            try
            {
                _kategoriService.DeleteID(categoryId);
                return Ok("Kategori başarıyla silindi.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"İç Sunucu Hatası: {ex.Message}");
            }
        }



        [HttpPost("UpdateKategori")]
        public IActionResult Update([FromBody] Kategori kategori)
        {
            try
            {
                // Gerekirse iş mantığı ekleyebilirsiniz
                _kategoriService.Update(kategori);

                // Başarılı durumda HTTP 200 OK durumunu döndür
                return Ok("Kategori başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 Internal Server Error döndür
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

    }
}
