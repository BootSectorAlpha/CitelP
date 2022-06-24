using CitelP.Models;
using CitelP.Servicos.Comunicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface ICategoriaServico
  {
    Task<IEnumerable<Categoria>> ListAsync();

    Task<CategoriaResponse> SaveAsync(Categoria category);

    Task<CategoriaResponse> UpdateAsync(int id, Categoria category);

    Task<CategoriaResponse> DeleteAsync(int id);
  }
}
