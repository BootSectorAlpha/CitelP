using CitelP.Extensoes;
using CitelP.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Controllers.Config
{
  public static class InvalidModelStateResponseFactory
  {
    public static IActionResult ProduceErrorResponse(ActionContext context)
    {
      var errors = context.ModelState.GetErrorMessages();
      var response = new ErrorResource(mensagens: errors);

      return new BadRequestObjectResult(response);
    }
  }
}
