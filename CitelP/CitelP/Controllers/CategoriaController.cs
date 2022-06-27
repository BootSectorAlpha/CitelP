using AutoMapper;
using CitelP.Extensoes;
using CitelP.Models;
using CitelP.Resources;
using CitelP.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CitelP.Controllers
{
  [Route("api/[controller]")]
  public class CategoriaController : ControllerBase
  {

    private readonly ICategoriaServico _categoriaServico;
    private readonly IMapper _mapper;

    public CategoriaController(ICategoriaServico categoriaServico, IMapper mapper)
    {
      _categoriaServico = categoriaServico;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<CategoriaResource>> GetAllAsync()
    {
      var categorias = await _categoriaServico.ListAsync();
      var resources = _mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaResource>>(categorias);

      return resources;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveCategoriaResource resource)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState.GetErrorMessages());

      var categoria = _mapper.Map<SaveCategoriaResource, Categoria>(resource);
      var result = await _categoriaServico.SaveAsync(categoria);

      if (!result.Success)
        return BadRequest(result.Message);

      var categoriaResource = _mapper.Map<Categoria, CategoriaResource>(result.Categoria);
      return Ok(categoriaResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCategoriaResource resource)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState.GetErrorMessages());

      var categoria = _mapper.Map<SaveCategoriaResource, Categoria>(resource);
      var result = await _categoriaServico.UpdateAsync(id, categoria);

      if (!result.Success)
        return BadRequest(result.Message);

      var categoriaResource = _mapper.Map<Categoria, CategoriaResource>(result.Categoria);
      return Ok(categoriaResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
      var result = await _categoriaServico.DeleteAsync(id);

      if (!result.Success)
        return BadRequest(result.Message);

      var categoriaResource = _mapper.Map<Categoria, CategoriaResource>(result.Categoria);
      return Ok(categoriaResource);
    }
  }
}




