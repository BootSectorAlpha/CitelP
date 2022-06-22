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

    private readonly AppDbContextCategoria _context;

    public CategoriaController(AppDbContextCategoria context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var categorias = await _context.Categoria.ToListAsync();
      return Ok(categorias);
    }

  }

  
}
