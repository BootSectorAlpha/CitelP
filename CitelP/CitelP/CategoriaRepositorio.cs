using CitelP.Models;
using CitelP.Servicos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CitelP
{
  public class CategoriaRepositorio : BaseRepositorio, ICategoriaRepositorio
  {
    public CategoriaRepositorio(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Categoria>> ListAsync()
    {
      return await _context.Categorias.ToListAsync();
    }
    public async Task AddAsync(Categoria categoria)
    {
      await _context.Categorias.AddAsync(categoria);
    }
    public async Task<Categoria> FindByIdAsync(int id)
    {
      return await _context.Categorias.FindAsync(id);
    }
    public void Update(Categoria categoria)
    {
      _context.Categorias.Update(categoria);
    }
    public void Remove(Categoria categoria)
    {
      _context.Categorias.Remove(categoria);
    }
  }
}
