using CitelP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface ICategoriaRepositorio
  {
    Task<IEnumerable<Categoria>> ListAsync();

    Task AddAsync(Categoria categoria);

    Task<Categoria> FindByIdAsync(int id);

    void Update(Categoria categoria);

    //A API do EF Core não requer um método assíncrono para atualizar modelos.
  }
}
