using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
  public class UnidadeDeTrabalho : IUnidadeDeTrabalhoRepositorio
  {
    private readonly AppDbContext _context;

    public UnidadeDeTrabalho(AppDbContext context)
    {
      _context = context;
    }

    public async Task CompleteAsync()
    {
      await _context.SaveChangesAsync();
    }
  }
}
