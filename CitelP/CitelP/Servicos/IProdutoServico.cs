using CitelP.Models;
using CitelP.Servicos.Comunicacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface IProdutoServico
  {
    Task<IEnumerable<Produto>> ListAsync();
    Task<ProdutoResponse> SaveAsync(Produto produto);
    Task<ProdutoResponse> UpdateAsync(int id, Produto produto);
    Task<ProdutoResponse> DeleteAsync(int id);
  }
}
