using CitelP.Models;
using CitelP.Servicos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
  public class CategoriaRepositorio : BaseRepositorio, ICategoriaRepositorio
  {
    public CategoriaRepositorio (AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Categoria>> ListAsync()
    {
      return await _context.Categoria.ToListAsync();
    }
  }
}
