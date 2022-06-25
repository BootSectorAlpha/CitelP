using CitelP.Models;
using CitelP.Servicos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
  public class ProdutoRepositorio : BaseRepositorio, IProdutoRepositorio
  {
    public ProdutoRepositorio(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Produto>> ListAsync()
    {
      return await _context.Produtos.Include(p => p.Categoria)
                                    .ToListAsync();
    }

    public async Task AddAsync(Produto produto)
    {
      await _context.Produtos.AddAsync(produto);
    }

    public async Task<Produto> FindByIdAsync(int id)
    {
      return await _context.Produtos.FindAsync(id);
    }

    public void Update(Produto produto)
    {
      _context.Produtos.Update(produto);
    }

    public void Remove(Produto produto)
    {
      _context.Produtos.Remove(produto);
    }

  }
}
