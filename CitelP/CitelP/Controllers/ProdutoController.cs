using CitelP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitelP.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProdutoController : ControllerBase
  {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

    // GET: api/<ProdutoController>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
            try
            {
                var listProdutos = await _context.Produto.ToListAsync();
                return Ok(listProdutos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
    }
    //método acima é responsável por listar os produtos

    // GET api/<ProdutoController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
            try
            {
                var produto = await _context.Produto.FindAsync(id);

                if (produto == null)
                {
                    return NotFound();
                }

                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
    }

    // POST api/<ProdutoController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Produto produto)
    {
            try
            {
                _context.Add(produto);
                await _context.SaveChangesAsync();

                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
    }

    // PUT api/<ProdutoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Produto produto)
    {
            try
            {
                if (id != produto.Id)
                {
                    return BadRequest();
                }

                _context.Update(produto);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Produto Atualizado com Sucesso!" });
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
    }

    // DELETE api/<ProdutoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {

            try
            {
                var produto = await _context.Produto.FindAsync(id);

                if (produto == null)
                {
                    return NotFound();
                }

                _context.Produto.Remove(produto);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Produto Eliminado com Sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
    }
  }
}
