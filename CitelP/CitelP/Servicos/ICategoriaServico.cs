using CitelP.Models;
using CitelP.Servicos.Comunicacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface ICategoriaServico
  {
    Task<IEnumerable<Categoria>> ListAsync();
    Task<CategoriaResponse> SaveAsync(Categoria categoria);
    Task<CategoriaResponse> UpdateAsync(int id, Categoria categoria);
    Task<CategoriaResponse> DeleteAsync(int id);
  }
}
