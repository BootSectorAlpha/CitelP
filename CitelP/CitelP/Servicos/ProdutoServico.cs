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
        return new ProdutoResponse($"Um Erro Ocorreu ao Salvar o Produto: {ex.Message}");
      }
    }

    public async Task<ProdutoResponse> UpdateAsync(int id, Produto produto)
    {
      var existindoProduto = await _produtoRepositorio.FindByIdAsync(id);

      if (existindoProduto == null)
        return new ProdutoResponse("Produto não Encontrado.");

      existindoProduto.Nome = produto.Nome;
      existindoProduto.Fabricacao = produto.Fabricacao;
      existindoProduto.Validade = produto.Validade;
      existindoProduto.Preco= produto.Preco;

      try
      {
        _produtoRepositorio.Update(existindoProduto);
        await _unidadeDeTrabalho.CompleteAsync();

        return new ProdutoResponse(existindoProduto);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new ProdutoResponse($"Um Erro Ocorreu ao Atualizar o Produto: {ex.Message}");
      }
    }

    public async Task<ProdutoResponse> DeleteAsync(int id)
    {
      var existindoProduto = await _produtoRepositorio.FindByIdAsync(id);

      if (existindoProduto == null)
        return new ProdutoResponse("Produto não Encontrado.");

      try
      {
        _produtoRepositorio.Remove(existindoProduto);
        await _unidadeDeTrabalho.CompleteAsync();

        return new ProdutoResponse(existindoProduto);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new ProdutoResponse($"Um Erro Ocorreu ao Deletar o Produto: {ex.Message}");
      }
    }
  }
}
