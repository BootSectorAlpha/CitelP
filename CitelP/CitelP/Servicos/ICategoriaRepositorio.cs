using CitelP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface ICategoriaRepositorio
  {
    Task<IEnumerable<Categoria>> ListAsync();
    Task AddAsync(Categoria categoria);
    Task<Categoria> FindByIdAsync(int id);
    void Update(Categoria categoria);
    void Remove(Categoria categoria);
  }
}
