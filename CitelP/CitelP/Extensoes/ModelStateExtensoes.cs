using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace CitelP.Extensoes
{
  public static class ModelStateExtensoes
  {
    public static List<string> GetErrorMessages(this ModelStateDictionary dicionario)
    {
      return dicionario.SelectMany(m => m.Value.Errors)
                       .Select(m => m.ErrorMessage)
                       .ToList();
    }
  }
}
