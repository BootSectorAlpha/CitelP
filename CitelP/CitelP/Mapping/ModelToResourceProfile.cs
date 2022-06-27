using AutoMapper;
using CitelP.Models;
using CitelP.Models.Consultas;
using CitelP.Resources;

namespace CitelP.Mapping
{
  public class ModelToResourceProfile : Profile
  {
    public ModelToResourceProfile()
    {
      CreateMap<Categoria, CategoriaResource>();

      CreateMap<Produto, ProdutoResource>();

      CreateMap<ResultadoDaConsulta<Produto>, ResultadoDaConsultaResource<ProdutoResource>>();
    }
  }
}
