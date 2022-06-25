using AutoMapper;
using CitelP.Models;
using CitelP.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Mapping
{
  public class ResourceToModelProfile : Profile
  {
      public ResourceToModelProfile()
      {
        CreateMap<SaveCategoriaResource, Categoria>();

        CreateMap<SaveProdutoResource, Produto>();
    }



  }
}
