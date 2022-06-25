using CitelP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public class ProdutoServico : IProdutoServico
  {
    private readonly IProdutoRepositorio _produtoRepositorio;

    public ProdutoServico(IProdutoRepositorio produtoRepositorio)
    {
      _produtoRepositorio = produtoRepositorio;
    }

    public async Task<IEnumerable<Produto>> ListAsync()
    {
      return await _produtoRepositorio.ListAsync();
    }
  }
}
