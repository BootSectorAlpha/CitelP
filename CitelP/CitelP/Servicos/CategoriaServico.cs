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

    public async Task<CategoriaResponse> SaveAsync(Categoria category)
    {
      try
      {
        await _categoriaRepositorio.AddAsync(category);
        await _unidadeDeTrabalho.CompleteAsync();

        return new CategoriaResponse(category);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new CategoriaResponse($"Um Erro Ocorreu ao Salvar a Categoria: {ex.Message}");
      }
    }

    public async Task<CategoriaResponse> UpdateAsync(int id, Categoria categoria)
    {
      var existindoCategoria = await _categoriaRepositorio.FindByIdAsync(id);

      if (existindoCategoria == null)
        return new CategoriaResponse("Categoria não Encontrada.");

      existindoCategoria.Nome = categoria.Nome;

      try
      {
        _categoriaRepositorio.Update(existindoCategoria);
        await _unidadeDeTrabalho.CompleteAsync();

        return new CategoriaResponse(existindoCategoria);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new CategoriaResponse($"Um Erro Ocorreu ao Atualizar a Categoria: {ex.Message}");
      }
    }

    public async Task<CategoriaResponse> DeleteAsync(int id)
    {
      var existingCategory = await _categoriaRepositorio.FindByIdAsync(id);

      if (existingCategory == null)
        return new CategoriaResponse("Categoria não Encontrada.");

      try
      {
        _categoriaRepositorio.Remove(existingCategory);
        await _unidadeDeTrabalho.CompleteAsync();

        return new CategoriaResponse(existingCategory);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new CategoriaResponse($"Um Erro Ocorreu ao Deletar a Categoria: {ex.Message}");
      }
    }
  }
}
