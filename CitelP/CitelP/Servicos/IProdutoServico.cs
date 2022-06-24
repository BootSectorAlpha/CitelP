using CitelP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public interface IProdutoServico
  {
    Task<IEnumerable<Produto>> ListAsync();
  }
}
