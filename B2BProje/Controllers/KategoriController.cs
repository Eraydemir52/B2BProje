﻿using B2BProje.Business.Abstract;
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
    }
}
