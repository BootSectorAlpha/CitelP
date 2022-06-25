using CitelP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface IProdutoRepositorio
  {
    Task<IEnumerable<Produto>> ListAsync();

    Task AddAsync(Produto produto);

    Task<Produto> FindByIdAsync(int id);

    void Update(Produto produto);

    //*A API do EF Core não requer um método assíncrono para update na controller*.

    void Remove(Produto produto);
  }
}
