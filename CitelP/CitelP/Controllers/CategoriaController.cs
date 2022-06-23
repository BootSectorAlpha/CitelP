using CitelP.Models;
using CitelP.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CitelP.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CategoriaController : ControllerBase
  {

    private readonly AppDbContext _context;

    public CategoriaController(AppDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      try
      {
        var categorias = await _context.Categoria.ToListAsync();
        return Ok(categorias);
      }
      catch (Exception ex)
      {

        return BadRequest(ex.Message);
      }
      
    }

  }

  
}
