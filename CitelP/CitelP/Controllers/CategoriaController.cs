using AutoMapper;
using CitelP.Extensoes;
using CitelP.Models;
using CitelP.Resources;
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

    private readonly ICategoriaServico _categoriaServico;
    private readonly IMapper _mapper;

    //private readonly AppDbContext _context;

    public CategoriaController(ICategoriaServico categoriaServico, IMapper mapper)
    {
      _categoriaServico = categoriaServico;
      _mapper = mapper;
    }

    //public CategoriaController(AppDbContext context)
    //{
    //  _context = context;
    //}

    [HttpGet]
    public async Task<IEnumerable<CategoriaResource>> GetAllAsync()
    { 
        var categorias = await _categoriaServico.ListAsync();
        var resources = _mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaResource>>(categorias);

        return resources;

      //try
      //{
      //  var categorias = await _context.Categoria.ToListAsync();
      //  return Ok(categorias);
      //}
      //catch (Exception ex)
      //{
      //  return BadRequest(ex.Message);
      //}

      /*Após a finalização desta implementação, teste a API no navegador com o comando
       "https://localhost:5001/api/categoria". Verá que não retornará via JSON o array
       de Produtos da model Categoria do BD.*/
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveCategoriaResource resource)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState.GetErrorMessages());
    }
  } 
}


  

