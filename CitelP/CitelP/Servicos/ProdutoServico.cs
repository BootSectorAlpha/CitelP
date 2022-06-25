using CitelP.Models;
using CitelP.Servicos.Comunicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos
{
  public class ProdutoServico : IProdutoServico
  {
    private readonly IProdutoRepositorio _produtoRepositorio;
    private readonly IUnidadeDeTrabalhoRepositorio _unidadeDeTrabalho;

    public ProdutoServico(IProdutoRepositorio produtoRepositorio, IUnidadeDeTrabalhoRepositorio unidadeDeTrabalho)
    {
      _produtoRepositorio = produtoRepositorio;
      _unidadeDeTrabalho = unidadeDeTrabalho;
    }

    public async Task<IEnumerable<Produto>> ListAsync()
    {
      return await _produtoRepositorio.ListAsync();
    }

    public async Task<ProdutoResponse> SaveAsync(Produto produto)
    {
      try
      {
        await _produtoRepositorio.AddAsync(produto);
        await _unidadeDeTrabalho.CompleteAsync();

        return new ProdutoResponse(produto);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new ProdutoResponse($"Um Erro Ocorreu ao Salvar a Categoria: {ex.Message}");
      }
    }
  }
}
