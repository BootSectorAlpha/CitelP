using CitelP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface IProdutoRepositorio
  {
    Task<IEnumerable<Produto>> ListAsync();
    Task AddAsync(Produto produto);
    Task<Produto> FindByIdAsync(int id);
    void Update(Produto produto);
    void Remove(Produto produto);
  }
}
