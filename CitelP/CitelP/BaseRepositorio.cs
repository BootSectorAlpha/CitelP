using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
  public abstract class BaseRepositorio
  {

    protected readonly AppDbContext _context;

    public BaseRepositorio(AppDbContext context)
    {
      _context = context;
    }
  }
}

//Esta classe é apenas uma classe abstrata que todos os nossos repositórios herdarão.
