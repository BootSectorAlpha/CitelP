using CitelP.Models;
using CitelP.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
  public class CategoriaServico : ICategoriaServico
  {

    private readonly ICategoriaRespositorio _categoriaRepositorio;

    public CategoriaServico(ICategoriaRespositorio categoriaRepositorio)
    {
      _categoriaRepositorio = categoriaRepositorio;
    }

    public async Task<IEnumerable<Categoria>> ListAsync()
    {
      return await _categoriaRepositorio.ListAsync();
    }

  }
}
