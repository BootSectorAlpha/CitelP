using AutoMapper;
using CitelP.Models;
using CitelP.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Mapping
{
  public class ModelToResourceProfile : Profile
  {
    public ModelToResourceProfile()
    {
      //var config = new MapperConfiguration(cfg =>
      //cfg.CreateMap<Categoria, CategoriaResource>().ReverseMap().ForMember(dest => dest.Produto,
      //opt => opt.Ignore()));

      CreateMap<Categoria, CategoriaResource>().ReverseMap();

      CreateMap<Produto, ProdutoResource>().;
    }
  }
}
