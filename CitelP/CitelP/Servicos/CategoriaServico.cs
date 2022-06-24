using CitelP.Models;
using CitelP.Servicos;
using CitelP.Servicos.Comunicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
  public class CategoriaServico : ICategoriaServico
  {

    private readonly ICategoriaRepositorio _categoriaRepositorio;
    private readonly IUnidadeDeTrabalhoRepositorio _unidadeDeTrabalho;

    public CategoriaServico(ICategoriaRepositorio categoriaRepositorio, IUnidadeDeTrabalhoRepositorio unidadeDeTrabalho)
    {
      _categoriaRepositorio = categoriaRepositorio;
      _unidadeDeTrabalho = unidadeDeTrabalho;
    }

    public async Task<IEnumerable<Categoria>> ListAsync()
    {
      return await _categoriaRepositorio.ListAsync();
    }

    public async Task<SaveCategoriaResponse> SaveAsync(Categoria category)
    {
      try
      {
        await _categoriaRepositorio.AddAsync(category);
        await _unidadeDeTrabalho.CompleteAsync();

        return new SaveCategoriaResponse(category);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new SaveCategoriaResponse($"Um Erro Ocorreu ao Salvar a Categoria: {ex.Message}");
      }
    }

    public async Task<SaveCategoriaResponse> UpdateAsync(int id, Categoria categoria)
    {
      var existindoCategoria = await _categoriaRepositorio.FindByIdAsync(id);

      if (existindoCategoria == null)
        return new SaveCategoriaResponse("Categoria não Encontrada.");

      existindoCategoria.Nome = categoria.Nome;

      try
      {
        _categoriaRepositorio.Update(existindoCategoria);
        await _unidadeDeTrabalho.CompleteAsync();

        return new SaveCategoriaResponse(existindoCategoria);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new SaveCategoriaResponse($"Um Erro Ocorreu ao Atualizar a Categoria: {ex.Message}");
      }
    }
  }
}
