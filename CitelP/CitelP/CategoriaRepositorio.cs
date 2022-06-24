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

    public async Task AddAsync(Categoria categoria)
    {
      await _context.Categoria.AddAsync(categoria);
    }

    public async Task<Categoria> FindByIdAsync(int id)
    {
      return await _context.Categoria.FindAsync(id);
    }

    public void Update(Categoria categoria)
    {
      _context.Categoria.Update(categoria);
    }

  }
}
