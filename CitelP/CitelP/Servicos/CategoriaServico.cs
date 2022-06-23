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
        return new SaveCategoriaResponse($"An error occurred when saving the category: {ex.Message}");
      }
    }
  }
}
