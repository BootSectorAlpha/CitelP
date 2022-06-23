using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Extensoes
{
  public static class ModelStateExtensoes
  {
    public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
    {
      return dictionary.SelectMany(m => m.Value.Errors)
                       .Select(m => m.ErrorMessage)
                       .ToList();
    }
  }
}
