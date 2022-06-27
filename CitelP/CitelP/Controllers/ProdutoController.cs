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
  public class ProdutoController : Controller
  {
    private readonly IProdutoServico _produtoServico;
    private readonly IMapper _mapper;

    public ProdutoController(IProdutoServico produtoServico, IMapper mapper)
    {
      _produtoServico = produtoServico;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<ProdutoResource>> ListAsync()
    {
      var produtos = await _produtoServico.ListAsync();
      var resources = _mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoResource>>(produtos);
      return resources;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveProdutoResource resource)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState.GetErrorMessages());

      var produto = _mapper.Map<SaveProdutoResource, Produto>(resource);
      var result = await _produtoServico.SaveAsync(produto);

      if (!result.Success)
        return BadRequest(result.Message);

      var produtoResource = _mapper.Map<Produto, ProdutoResource>(result.Produto);
      return Ok(produtoResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveProdutoResource resource)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState.GetErrorMessages());

      var produto = _mapper.Map<SaveProdutoResource, Produto>(resource);
      var result = await _produtoServico.UpdateAsync(id, produto);

      if (!result.Success)
        return BadRequest(result.Message);

      var produtoResource = _mapper.Map<Produto, ProdutoResource>(result.Produto);
      return Ok(produtoResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
      var result = await _produtoServico.DeleteAsync(id);

      if (!result.Success)
        return BadRequest(result.Message);

      var produtoResource = _mapper.Map<Produto, ProdutoResource>(result.Produto);
      return Ok(produtoResource);
    }
  }
}
