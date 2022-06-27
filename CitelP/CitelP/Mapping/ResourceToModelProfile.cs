using AutoMapper;
using CitelP.Models;
using CitelP.Models.Consultas;
using CitelP.Resources;

namespace CitelP.Mapping
{
  public class ResourceToModelProfile : Profile
  {
    public ResourceToModelProfile()
    {
      CreateMap<SaveCategoriaResource, Categoria>();

      CreateMap<SaveProdutoResource, Produto>();

      CreateMap<ConsultaProdutosResource, ConsultaProdutos>();
    }
  }
}
