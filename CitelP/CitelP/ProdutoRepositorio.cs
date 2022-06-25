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
  }
}
